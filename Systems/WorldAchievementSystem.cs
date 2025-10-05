using Terraria;
using TerrariaAchievementLib.Achievements;
using TerrariaAchievementLib.Systems;

namespace WorldAchievements.Systems
{
    /// <summary>
    /// Creates a helper AchievementSystem instance
    /// </summary>
    public class WorldAchievementSystem : AchievementSystem
    {
        public override void OnModLoad()
        {
            if (Main.dedServ)
                return;

            base.OnModLoad();
            AchievementProgression.Enable(ProgressionRestriction.World);
        }
    }
}
