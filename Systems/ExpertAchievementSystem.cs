using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ID;
using TerrariaAchievementLib.Achievements.Conditions;
using TerrariaAchievementLib.Achievements;
using TerrariaAchievementLib.Systems;

namespace ExpertAchievements.Systems
{
    /// <summary>
    /// Adds achievements for Expert Mode to the in-game list
    /// </summary>
    public class ExpertAchievementSystem : AchievementSystem
    {
        /// <summary>
        /// Item IDs for the developer sets
        /// </summary>
        private static readonly Dictionary<string, int[]> ExpertDevSets = new()
        {
            { "Aaron", [ItemID.AaronsHelmet, ItemID.AaronsBreastplate, ItemID.AaronsLeggings] },
            { "Arkhalis", [ItemID.ArkhalisHat, ItemID.ArkhalisShirt, ItemID.ArkhalisPants, ItemID.ArkhalisWings, ItemID.Arkhalis] },
            { "Cenx", [ItemID.CenxsTiara, ItemID.CenxsBreastplate, ItemID.CenxsLeggings, ItemID.CenxsWings] },
            { "Cenx Dress", [ItemID.CenxsTiara, ItemID.CenxsDress, ItemID.CenxsDressPants, ItemID.CenxsWings] },
            { "Crowno", [ItemID.CrownosMask, ItemID.CrownosBreastplate, ItemID.CrownosLeggings, ItemID.CrownosWings] },
            { "D-Town", [ItemID.DTownsHelmet, ItemID.DTownsBreastplate, ItemID.DTownsLeggings, ItemID.DTownsWings] },
            { "Jim", [ItemID.JimsHelmet, ItemID.JimsBreastplate, ItemID.JimsLeggings, ItemID.JimsWings] },
            { "Lazure", [ItemID.BejeweledValkyrieHead, ItemID.BejeweledValkyrieBody, ItemID.BejeweledValkyrieWing, ItemID.ValkyrieYoyo] },
            { "Leinfor", [ItemID.LeinforsHat, ItemID.LeinforsShirt, ItemID.LeinforsPants, ItemID.LeinforsAccessory, ItemID.LeinforsWings] },
            { "Loki", [ItemID.LokisHelm, ItemID.LokisShirt, ItemID.LokisPants, ItemID.LokisWings, ItemID.LokisDye] },
            { "Red", [ItemID.RedsHelmet, ItemID.RedsBreastplate, ItemID.RedsLeggings, ItemID.RedsWings, ItemID.RedsYoyo] },
            { "Skiphs", [ItemID.SkiphsHelm, ItemID.SkiphsShirt, ItemID.SkiphsPants, ItemID.SkiphsWings, ItemID.DevDye] },
            { "Will", [ItemID.WillsHelmet, ItemID.WillsBreastplate, ItemID.WillsLeggings, ItemID.WillsWings] },
            { "Yoraiz0r", [ItemID.Yoraiz0rHead, ItemID.Yoraiz0rShirt, ItemID.Yoraiz0rPants, ItemID.Yoraiz0rDarkness, ItemID.Yoraiz0rWings] },
            { "Grox The Great", [ItemID.GroxTheGreatHelm, ItemID.GroxTheGreatArmor, ItemID.GroxTheGreatGreaves, ItemID.GroxTheGreatWings] },
            { "FoodBarbarian", [ItemID.FoodBarbarianHelm, ItemID.FoodBarbarianArmor, ItemID.FoodBarbarianGreaves, ItemID.FoodBarbarianWings] },
            { "Safeman", [ItemID.SafemanSunHair, ItemID.SafemanSunDress, ItemID.SafemanDressLeggings, ItemID.SafemanWings] },
            { "Ghostar", [ItemID.GhostarSkullPin, ItemID.GhostarShirt, ItemID.GhostarPants, ItemID.GhostarsWings] }
        };

        /// <summary>
        /// Item IDs for the Treasure Bags
        /// </summary>
        private static readonly Dictionary<string, int> ExpertTreasureBags = new()
        {
            { "King Slime", ItemID.KingSlimeBossBag },
            { "Eye of Cthulhu", ItemID.EyeOfCthulhuBossBag },
            { "Eater of Worlds", ItemID.EaterOfWorldsBossBag },
            { "Brain of Cthulhu", ItemID.BrainOfCthulhuBossBag },
            { "Queen Bee", ItemID.QueenBeeBossBag },
            { "Skeletron", ItemID.SkeletronBossBag },
            { "Deerclops", ItemID.DeerclopsBossBag },
            { "Wall of Flesh", ItemID.WallOfFleshBossBag },
            { "Queen Slime", ItemID.QueenSlimeBossBag },
            { "Destroyer", ItemID.DestroyerBossBag },
            { "Twins", ItemID.TwinsBossBag },
            { "Skeletron Prime", ItemID.SkeletronPrimeBossBag },
            { "Plantera", ItemID.PlanteraBossBag },
            { "Golem", ItemID.GolemBossBag },
            { "Duke Fishron", ItemID.FishronBossBag },
            { "Empress of Light", ItemID.FairyQueenBossBag },
            // { "Lunatic Cultist", ItemID.CultistBossBag },
            { "Moon Lord", ItemID.MoonLordBossBag },
            // { "Dark Mage (T3)", ItemID.BossBagDarkMage },
            // { "Ogre (T3)", ItemID.BossBagOgre },
            { "Betsy", ItemID.BossBagBetsy }
        };


        protected override string Identifier { get => "EXPERT"; }

        protected override string TexturePath { get => "ExpertAchievements/Assets/Achievements"; }

        protected override void RegisterAchievements()
        {
            string name;
            AchCondition cond;
            List<AchCondition> conds;
            ConditionReqs reqs = new(PlayerDiff.Classic, WorldDiff.Expert, SpecialSeed.None);

            // Add achievements for the Treasure Bags
            foreach (var bag in ExpertTreasureBags)
            {
                string boss = bag.Key;
                name = $"{boss.ToUpper().Replace(" ", "_")}_BAG";
                conds = [];
                conds.Add(NpcKillCondition.KillAny(reqs, AchData.DefeatBossIds[boss]));
                conds.Add(ItemGrabCondition.Grab(reqs, bag.Value));
                RegisterAchievement(name, conds, false, AchievementCategory.Slayer);
            }

            // Add achievement for the Minecart upgrade
            name = "MINECART_UPGRADE";
            cond = ItemCraftCondition.Craft(reqs, ItemID.MinecartPowerup);
            RegisterAchievement(name, cond, AchievementCategory.Collector);

            // Add achievement for the Mourning Wood mount
            name = "WITCH_BROOM";
            cond = BuffAddCondition.Add(reqs, BuffID.WitchBroom);
            RegisterAchievement(name, cond, AchievementCategory.Collector);

            // Add achievements for the developer sets
            foreach (var set in ExpertDevSets)
            {
                name = $"{set.Key.ToUpper().Replace(" ", "_")}_SET";
                conds = ItemGrabCondition.GrabAll(reqs, set.Value);
                RegisterAchievement(name, conds, true, AchievementCategory.Collector);
            }
        }
    }
}
