using TerrariaAchievementLib.Achievements;

namespace WorldAchievements.Achievements.Master
{
    /// <summary>
    /// Master achievement attributes
    /// </summary>
    public class MasterAchievements
    {
        /// <summary>
        /// Master achievement condition requirements
        /// </summary>
        public static readonly ConditionReqs reqs = new(PlayerDiff.Classic, WorldDiff.Master, SpecialSeed.None);
    }
}
