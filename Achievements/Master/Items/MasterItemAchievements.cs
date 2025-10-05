using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ID;
using Terraria.ModLoader;
using TerrariaAchievementLib.Achievements.Conditions;
using WorldAchievements.Achievements.Master.Pet;

namespace WorldAchievements.Achievements.Master.Items
{
    public class MasterResplendentDessertAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterResplendentDessertAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(ItemCraftCondition.Craft(MasterAchievements.reqs, ItemID.ResplendentDessert));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetMartianSaucerAchievement>());
        }
    }
}
