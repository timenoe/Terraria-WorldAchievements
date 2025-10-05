using TerrariaAchievementLib.Achievements;

namespace WorldAchievements.Achievements.Expert
{
    /// <summary>
    /// Expert achievement attributes
    /// </summary>
    public class ExpertAchievements
    {
        /// <summary>
        /// Expert achievement condition requirements
        /// </summary>
        public static readonly ConditionReqs reqs = new(PlayerDiff.Classic, WorldDiff.Expert, SpecialSeed.None);
    }
}
