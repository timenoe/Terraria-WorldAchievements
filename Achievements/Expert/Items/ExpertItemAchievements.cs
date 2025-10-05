using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ID;
using Terraria.ModLoader;
using TerrariaAchievementLib.Achievements.Conditions;
using WorldAchievements.Achievements.Expert.Dev;

namespace WorldAchievements.Achievements.Expert.Items
{
    public class ExpertDemonHeartAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertDemonHeartAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(ItemUseCondition.Use(ExpertAchievements.reqs, ItemID.DemonHeart));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetGhostarAchievement>());
        }
    }

    public class ExpertMinecartUpgradeKitAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertMinecartUpgradeKitAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(ItemUseCondition.Use(ExpertAchievements.reqs, ItemID.MinecartPowerup));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertDemonHeartAchievement>());
        }
    }

    public class ExpertWitchBroomAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertWitchBroomAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(ExpertAchievements.reqs, BuffID.WitchBroom));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertMinecartUpgradeKitAchievement>());
        }
    }
}
