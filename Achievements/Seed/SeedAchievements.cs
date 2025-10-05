using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ID;
using Terraria.ModLoader;
using TerrariaAchievementLib.Achievements;
using TerrariaAchievementLib.Achievements.Conditions;
using WorldAchievements.Achievements.Zenith;

namespace WorldAchievements.Achievements.Seed
{
    public class SeedMoonLordLegsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/SeedMoonLordLegsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionReqs reqs = new(PlayerDiff.Classic, WorldDiff.Classic, SpecialSeed.Drunk);
            AddCondition(ItemGrabCondition.Grab(reqs, ItemID.MoonLordLegs));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithMartianSaucerAchievement>());
        }
    }

    public class SeedRedPotionBadAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/SeedRedPotionBadAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionReqs reqs = new(PlayerDiff.Classic, WorldDiff.Classic, SpecialSeed.Unworthy);
            AddCondition(ItemUseCondition.Use(reqs, ItemID.RedPotion));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<SeedMoonLordLegsAchievement>());
        }
    }

    public class SeedRedPotionGoodAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/SeedRedPotionGoodAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionReqs reqs = new(PlayerDiff.Classic, WorldDiff.Classic, SpecialSeed.Worthy);
            AddCondition(ItemUseCondition.Use(reqs, ItemID.RedPotion));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<SeedRedPotionBadAchievement>());
        }
    }
}
