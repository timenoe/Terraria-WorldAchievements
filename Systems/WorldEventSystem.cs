using Terraria;
using Terraria.ModLoader;

namespace WorldAchievements.Systems
{
    /// <summary>
    /// Used to detect various world events
    /// </summary>
    public class WorldEventSystem : ModSystem
    {
        /// <summary>
        /// How many stars were hit during the minigame (max of 200)
        /// </summary>
        private static int _starsHit;

        /// <summary>
        /// How many stars were hit during the minigame (max of 200)
        /// </summary>
        public static double StarsHit => _starsHit;

        public override void OnModLoad()
        {
            On_Main.starGameMath += On_Main_starGameMath;
        }

        public override void OnModUnload()
        {
            On_Main.starGameMath -= On_Main_starGameMath;
        }

        public override void PreWorldGen() => _starsHit = 0;

        /// <summary>
        /// Detour to cache how many stars were hit during the minigame
        /// </summary>
        /// <param name="orig">Original starGameMath method</param>
        /// <param name="value">Star game math value</param>
        /// <returns>Original starGameMath calculation</returns>
        private double On_Main_starGameMath(On_Main.orig_starGameMath orig, double value)
        {
            _starsHit = Main.starsHit;
            return orig.Invoke(value);
        }
    }
}
