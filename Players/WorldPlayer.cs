using Terraria;
using Terraria.ModLoader;
using TerrariaAchievementLib.Tools;
using WorldAchievements.Systems;

namespace WorldAchievements.Players
{
    /// <summary>
    /// Used to interact with the world
    /// </summary>
    public class WorldPlayer : ModPlayer
    {
        public override void OnEnterWorld()
        {
            // Display the minigame score if applicable when entering a Zenith seed world
            if (Main.zenithWorld && WorldEventSystem.StarsHit > 0)
            {
                LogTool.ChatLog($"You hit {WorldEventSystem.StarsHit} stars while the Zenith world was generating");

                // 200 is very hard to do
                if (WorldEventSystem.StarsHit >= 200)
                    WorldAchievementSystem.Instance.UnlockManualAchievement("ZENITH_MINIGAME");
            }
        }
    }
}
