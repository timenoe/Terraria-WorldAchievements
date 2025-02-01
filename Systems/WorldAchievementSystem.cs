using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ID;
using TerrariaAchievementLib.Achievements.Conditions;
using TerrariaAchievementLib.Achievements;
using TerrariaAchievementLib.Systems;

namespace WorldAchievements.Systems
{
    /// <summary>
    /// Adds achievements for world difficulties/special seeds to the in-game list
    /// </summary>
    public class WorldAchievementSystem : AchievementSystem
    {
        protected override string Identifier { get => "WORLD"; }

        protected override List<string> TexturePaths { get => ["WorldAchievements/Assets/Achievements-1", "WorldAchievements/Assets/Achievements-2"]; }


        protected override void RegisterAchievements()
        {
            ConditionReqs expertReqs = new(PlayerDiff.Classic, WorldDiff.Expert, SpecialSeed.None);
            RegisterExpertBossAchievements(expertReqs);
            RegisterExpertDevSetAchievements(expertReqs);
            RegisterExpertItemAchievements(expertReqs);

            ConditionReqs masterReqs = new(PlayerDiff.Classic, WorldDiff.Master, SpecialSeed.None);
            RegisterMasterBossAchievements(masterReqs);
            RegisterMasterBossPetAchievements(masterReqs);
            RegisterMasterItemAchievements(masterReqs);

            ConditionReqs legendaryReqs = new(PlayerDiff.Classic, WorldDiff.Master, SpecialSeed.Worthy);
            RegisterLegendaryBossAchievements(legendaryReqs);

            RegisterSeedItemAchievements();
        }

        /// <summary>
        /// Register Expert Mode boss achievements
        /// </summary>
        /// <param name="reqs">Common achievement requirements</param>
        private void RegisterExpertBossAchievements(ConditionReqs reqs)
        {
            Dictionary<string, int> TreasureBags = new()
            {
                { "EXPERT_KING_SLIME", ItemID.KingSlimeBossBag },
                { "EXPERT_EYE_OF_CTHULHU", ItemID.EyeOfCthulhuBossBag },
                { "EXPERT_EATER_OF_WORLDS", ItemID.EaterOfWorldsBossBag },
                { "EXPERT_BRAIN_OF_CTHULHU", ItemID.BrainOfCthulhuBossBag },
                { "EXPERT_QUEEN_BEE", ItemID.QueenBeeBossBag },
                { "EXPERT_SKELETRON", ItemID.SkeletronBossBag },
                { "EXPERT_DEERCLOPS", ItemID.DeerclopsBossBag },
                { "EXPERT_WALL_OF_FLESH", ItemID.WallOfFleshBossBag },
                { "EXPERT_QUEEN_SLIME", ItemID.QueenSlimeBossBag },
                { "EXPERT_TWINS", ItemID.TwinsBossBag },
                { "EXPERT_DESTROYER", ItemID.DestroyerBossBag },
                { "EXPERT_SKELETRON_PRIME", ItemID.SkeletronPrimeBossBag },
                { "EXPERT_PLANTERA", ItemID.PlanteraBossBag },
                { "EXPERT_GOLEM", ItemID.GolemBossBag },
                { "EXPERT_EMPRESS_OF_LIGHT", ItemID.FairyQueenBossBag },
                { "EXPERT_DUKE_FISHRON", ItemID.FishronBossBag },
                { "EXPERT_MOON_LORD", ItemID.MoonLordBossBag },
                { "EXPERT_BETSY", ItemID.BossBagBetsy }
            };

            // Kill Expert Mode bosses for the first time
            foreach (var bag in TreasureBags)
                RegisterAchievement(bag.Key, NpcKillCondition.KillAny(reqs, true, AchData.DefeatBoss[bag.Key.Split("EXPERT_")[1]]), AchievementCategory.Slayer);
        }

        /// <summary>
        /// Register Expert Mode developer set achievements
        /// </summary>
        /// <param name="reqs">Common achievement requirements</param>
        private void RegisterExpertDevSetAchievements(ConditionReqs reqs)
        {
            Dictionary<string, int[]> DevSets = new()
            {
                { "EXPERT_SET_AARON", [ItemID.AaronsHelmet, ItemID.AaronsBreastplate, ItemID.AaronsLeggings] },
                { "EXPERT_SET_ARKHALIS", [ItemID.ArkhalisHat, ItemID.ArkhalisShirt, ItemID.ArkhalisPants, ItemID.ArkhalisWings, ItemID.Arkhalis] },
                { "EXPERT_SET_CENX", [ItemID.CenxsTiara, ItemID.CenxsBreastplate, ItemID.CenxsLeggings, ItemID.CenxsWings] },
                { "EXPERT_SET_CENX_DRESS", [ItemID.CenxsTiara, ItemID.CenxsDress, ItemID.CenxsDressPants, ItemID.CenxsWings] },
                { "EXPERT_SET_CROWNO", [ItemID.CrownosMask, ItemID.CrownosBreastplate, ItemID.CrownosLeggings, ItemID.CrownosWings] },
                { "EXPERT_SET_D-TOWN", [ItemID.DTownsHelmet, ItemID.DTownsBreastplate, ItemID.DTownsLeggings, ItemID.DTownsWings] },
                { "EXPERT_SET_JIM", [ItemID.JimsHelmet, ItemID.JimsBreastplate, ItemID.JimsLeggings, ItemID.JimsWings] },
                { "EXPERT_SET_LAZURE", [ItemID.BejeweledValkyrieHead, ItemID.BejeweledValkyrieBody, ItemID.BejeweledValkyrieWing, ItemID.ValkyrieYoyo] },
                { "EXPERT_SET_LEINFOR", [ItemID.LeinforsHat, ItemID.LeinforsShirt, ItemID.LeinforsPants, ItemID.LeinforsAccessory, ItemID.LeinforsWings] },
                { "EXPERT_SET_LOKI", [ItemID.LokisHelm, ItemID.LokisShirt, ItemID.LokisPants, ItemID.LokisWings, ItemID.LokisDye] },
                { "EXPERT_SET_RED", [ItemID.RedsHelmet, ItemID.RedsBreastplate, ItemID.RedsLeggings, ItemID.RedsWings, ItemID.RedsYoyo] },
                { "EXPERT_SET_SKIPHS", [ItemID.SkiphsHelm, ItemID.SkiphsShirt, ItemID.SkiphsPants, ItemID.SkiphsWings, ItemID.DevDye] },
                { "EXPERT_SET_WILL", [ItemID.WillsHelmet, ItemID.WillsBreastplate, ItemID.WillsLeggings, ItemID.WillsWings] },
                { "EXPERT_SET_YORAI", [ItemID.Yoraiz0rHead, ItemID.Yoraiz0rShirt, ItemID.Yoraiz0rPants, ItemID.Yoraiz0rDarkness, ItemID.Yoraiz0rWings] },
                { "EXPERT_SET_GROX_THE_GREAT", [ItemID.GroxTheGreatHelm, ItemID.GroxTheGreatArmor, ItemID.GroxTheGreatGreaves, ItemID.GroxTheGreatWings] },
                { "EXPERT_SET_FOODBARBARIAN", [ItemID.FoodBarbarianHelm, ItemID.FoodBarbarianArmor, ItemID.FoodBarbarianGreaves, ItemID.FoodBarbarianWings] },
                { "EXPERT_SET_SAFEMAN", [ItemID.SafemanSunHair, ItemID.SafemanSunDress, ItemID.SafemanDressLeggings, ItemID.SafemanWings] },
                { "EXPERT_SET_GHOSTAR", [ItemID.GhostarSkullPin, ItemID.GhostarShirt, ItemID.GhostarPants, ItemID.GhostarsWings] }
            };

            // Open Expert Mode developer sets from Treasure Bags
            foreach (var set in DevSets)
                RegisterAchievement(set.Key, ItemOpenCondition.OpenAll(reqs, ItemID.None, set.Value), set.Value.Length > 1, AchievementCategory.Collector);
        }

        /// <summary>
        /// Register Expert Mode item achievements
        /// </summary>
        /// <param name="reqs">Common achievement requirements</param>
        private void RegisterExpertItemAchievements(ConditionReqs reqs)
        {
            RegisterAchievement("EXPERT_DEMON_HEART", ItemUseCondition.Use(reqs, ItemID.DemonHeart), AchievementCategory.Collector);
            RegisterAchievement("EXPERT_MINECART_UPGRADE_KIT", ItemUseCondition.Use(reqs, ItemID.MinecartPowerup), AchievementCategory.Collector);
            RegisterAchievement("EXPERT_WITCH_BROOM", BuffAddCondition.Add(reqs, BuffID.WitchBroom), AchievementCategory.Collector);
        }

        /// <summary>
        /// Register Master Mode boss achievements
        /// </summary>
        /// <param name="reqs">Common achievement requirements</param>
        private void RegisterMasterBossAchievements(ConditionReqs reqs)
        {
            Dictionary<string, int> Relics = new()
            {
                { "MASTER_KING_SLIME", ItemID.KingSlimeMasterTrophy },
                { "MASTER_EYE_OF_CTHULHU", ItemID.EyeofCthulhuMasterTrophy },
                { "MASTER_EATER_OF_WORLDS", ItemID.EaterofWorldsMasterTrophy },
                { "MASTER_BRAIN_OF_CTHULHU", ItemID.BrainofCthulhuMasterTrophy },
                { "MASTER_QUEEN_BEE", ItemID.QueenBeeMasterTrophy },
                { "MASTER_SKELETRON", ItemID.SkeletronMasterTrophy },
                { "MASTER_DEERCLOPS", ItemID.DeerclopsMasterTrophy },
                { "MASTER_WALL_OF_FLESH", ItemID.WallofFleshMasterTrophy },
                { "MASTER_QUEEN_SLIME", ItemID.QueenSlimeMasterTrophy },
                { "MASTER_TWINS", ItemID.TwinsMasterTrophy },
                { "MASTER_DESTROYER", ItemID.DestroyerMasterTrophy },
                { "MASTER_SKELETRON_PRIME", ItemID.SkeletronPrimeMasterTrophy },
                { "MASTER_PLANTERA", ItemID.PlanteraMasterTrophy },
                { "MASTER_GOLEM", ItemID.GolemMasterTrophy },
                { "MASTER_EMPRESS_OF_LIGHT", ItemID.FairyQueenMasterTrophy },
                { "MASTER_DUKE_FISHRON", ItemID.DukeFishronMasterTrophy },
                { "MASTER_LUNATIC_CULTIST", ItemID.LunaticCultistMasterTrophy },
                { "MASTER_MOON_LORD", ItemID.MoonLordMasterTrophy },
                { "MASTER_MOURNING_WOOD", ItemID.MourningWoodMasterTrophy },
                { "MASTER_PUMPKING", ItemID.PumpkingMasterTrophy },
                { "MASTER_EVERSCREAM", ItemID.EverscreamMasterTrophy },
                { "MASTER_SANTA-NK1", ItemID.SantankMasterTrophy },
                { "MASTER_ICE_QUEEN", ItemID.IceQueenMasterTrophy },
                { "MASTER_DARK_MAGE_T3", ItemID.DarkMageMasterTrophy },
                { "MASTER_OGRE_T3", ItemID.OgreMasterTrophy },
                { "MASTER_BETSY", ItemID.BetsyMasterTrophy },
                { "MASTER_FLYING_DUTCHMAN", ItemID.FlyingDutchmanMasterTrophy },
                { "MASTER_MARTIAN_SAUCER", ItemID.UFOMasterTrophy }
            };

            // Kill Master Mode bosses for the first time
            foreach (var relic in Relics)
                RegisterAchievement(relic.Key, NpcKillCondition.KillAny(reqs, true, AchData.DefeatBoss[relic.Key.Split("MASTER_")[1]]), AchievementCategory.Slayer);
        }

        /// <summary>
        /// Register Master Mode boss pet achievements
        /// </summary>
        /// <param name="reqs">Common achievement requirements</param>
        private void RegisterMasterBossPetAchievements(ConditionReqs reqs)
        {
            Dictionary<string, int> MasterPets = new()
            {
                { "MASTER_PET_KING_SLIME", BuffID.KingSlimePet },
                { "MASTER_PET_EYE_OF_CTHULHU", BuffID.EyeOfCthulhuPet },
                { "MASTER_PET_EATER_OF_WORLDS", BuffID.EaterOfWorldsPet },
                { "MASTER_PET_BRAIN_OF_CTHULHU", BuffID.BrainOfCthulhuPet },
                { "MASTER_PET_QUEEN_BEE", BuffID.QueenBeePet },
                { "MASTER_PET_SKELETRON", BuffID.SkeletronPet },
                { "MASTER_PET_DEERCLOPS", BuffID.DeerclopsPet },
                { "MASTER_PET_WALL_OF_FLESH", BuffID.WallOfFleshGoatMount },
                { "MASTER_PET_QUEEN_SLIME", BuffID.QueenSlimePet },
                { "MASTER_PET_TWINS", BuffID.TwinsPet },
                { "MASTER_PET_DESTROYER", BuffID.DestroyerPet },
                { "MASTER_PET_SKELETRON_PRIME", BuffID.SkeletronPrimePet },
                { "MASTER_PET_PLANTERA", BuffID.PlanteraPet },
                { "MASTER_PET_GOLEM", BuffID.GolemPet },
                { "MASTER_PET_EMPRESS_OF_LIGHT", BuffID.FairyQueenPet },
                { "MASTER_PET_DUKE_FISHRON", BuffID.DukeFishronPet },
                { "MASTER_PET_LUNATIC_CULTIST", BuffID.LunaticCultistPet },
                { "MASTER_PET_MOON_LORD", BuffID.MoonLordPet },
                { "MASTER_PET_MOURNING_WOOD", BuffID.SpookyWoodMount },
                { "MASTER_PET_PUMPKING", BuffID.PumpkingPet },
                { "MASTER_PET_EVERSCREAM", BuffID.EverscreamPet },
                { "MASTER_PET_SANTA-NK1", BuffID.SantankMount },
                { "MASTER_PET_ICE_QUEEN", BuffID.IceQueenPet },
                { "MASTER_PET_DARK_MAGE_T3", BuffID.DarkMageBookMount },
                { "MASTER_PET_OGRE_T3", BuffID.DD2OgrePet },
                { "MASTER_PET_BETSY", BuffID.DD2BetsyPet },
                { "MASTER_PET_FLYING_DUTCHMAN", BuffID.PirateShipMount },
                { "MASTER_PET_MARTIAN_SAUCER", BuffID.MartianPet }
            };

            // Use Master Mode boss pets
            foreach (var pet in MasterPets)
                RegisterAchievement(pet.Key, BuffAddCondition.Add(reqs, pet.Value), AchievementCategory.Collector);
        }

        /// <summary>
        /// Register Master Mode item achievements
        /// </summary>
        /// <param name="reqs">Common achievement requirements</param>
        private void RegisterMasterItemAchievements(ConditionReqs reqs)
        {
            RegisterAchievement("MASTER_RESPLENDENT_DESSERT", ItemCraftCondition.Craft(reqs, ItemID.ResplendentDessert), AchievementCategory.Collector);
        }

        /// <summary>
        /// Register Legendary Mode boss achievements
        /// </summary>
        /// <param name="reqs">Common achievement requirements</param>
        private void RegisterLegendaryBossAchievements(ConditionReqs reqs)
        {
            Dictionary<string, int> Relics = new()
            {
                { "LEGENDARY_KING_SLIME", ItemID.KingSlimeMasterTrophy },
                { "LEGENDARY_EYE_OF_CTHULHU", ItemID.EyeofCthulhuMasterTrophy },
                { "LEGENDARY_EATER_OF_WORLDS", ItemID.EaterofWorldsMasterTrophy },
                { "LEGENDARY_BRAIN_OF_CTHULHU", ItemID.BrainofCthulhuMasterTrophy },
                { "LEGENDARY_QUEEN_BEE", ItemID.QueenBeeMasterTrophy },
                { "LEGENDARY_SKELETRON", ItemID.SkeletronMasterTrophy },
                { "LEGENDARY_DEERCLOPS", ItemID.DeerclopsMasterTrophy },
                { "LEGENDARY_WALL_OF_FLESH", ItemID.WallofFleshMasterTrophy },
                { "LEGENDARY_QUEEN_SLIME", ItemID.QueenSlimeMasterTrophy },
                { "LEGENDARY_TWINS", ItemID.TwinsMasterTrophy },
                { "LEGENDARY_DESTROYER", ItemID.DestroyerMasterTrophy },
                { "LEGENDARY_SKELETRON_PRIME", ItemID.SkeletronPrimeMasterTrophy },
                { "LEGENDARY_PLANTERA", ItemID.PlanteraMasterTrophy },
                { "LEGENDARY_GOLEM", ItemID.GolemMasterTrophy },
                { "LEGENDARY_EMPRESS_OF_LIGHT", ItemID.FairyQueenMasterTrophy },
                { "LEGENDARY_DUKE_FISHRON", ItemID.DukeFishronMasterTrophy },
                { "LEGENDARY_LUNATIC_CULTIST", ItemID.LunaticCultistMasterTrophy },
                { "LEGENDARY_MOON_LORD", ItemID.MoonLordMasterTrophy },
                { "LEGENDARY_MOURNING_WOOD", ItemID.MourningWoodMasterTrophy },
                { "LEGENDARY_PUMPKING", ItemID.PumpkingMasterTrophy },
                { "LEGENDARY_EVERSCREAM", ItemID.EverscreamMasterTrophy },
                { "LEGENDARY_SANTA-NK1", ItemID.SantankMasterTrophy },
                { "LEGENDARY_ICE_QUEEN", ItemID.IceQueenMasterTrophy },
                { "LEGENDARY_DARK_MAGE_T3", ItemID.DarkMageMasterTrophy },
                { "LEGENDARY_OGRE_T3", ItemID.OgreMasterTrophy },
                { "LEGENDARY_BETSY", ItemID.BetsyMasterTrophy },
                { "LEGENDARY_FLYING_DUTCHMAN", ItemID.FlyingDutchmanMasterTrophy },
                { "LEGENDARY_MARTIAN_SAUCER", ItemID.UFOMasterTrophy }
            };

            // Kill Legendary Mode bosses for the first time
            foreach (var relic in Relics)
                RegisterAchievement(relic.Key, NpcKillCondition.KillAny(reqs, true, AchData.DefeatBoss[relic.Key.Split("LEGENDARY_")[1]]), AchievementCategory.Slayer);
        }

        /// <summary>
        /// Register seed item achievements
        /// </summary>
        private void RegisterSeedItemAchievements()
        {
            ConditionReqs moonLordLegsReqs = new(PlayerDiff.Classic, WorldDiff.Classic, SpecialSeed.Drunk);
            RegisterAchievement("SEED_MOON_LORD_LEGS", ItemGrabCondition.Grab(moonLordLegsReqs, ItemID.MoonLordLegs), AchievementCategory.Collector);

            // Drink Red Potion when not worthy
            ConditionReqs redPotionBadReqs = new(PlayerDiff.Classic, WorldDiff.Classic, SpecialSeed.Unworthy);
            RegisterAchievement("SEED_RED_POTION_BAD", ItemUseCondition.Use(redPotionBadReqs, ItemID.RedPotion), AchievementCategory.Collector);

            // Drink Red Potion when worthy
            ConditionReqs redPotionGoodReqs = new(PlayerDiff.Classic, WorldDiff.Classic, SpecialSeed.Worthy);
            RegisterAchievement("SEED_RED_POTION_GOOD", ItemUseCondition.Use(redPotionGoodReqs, ItemID.RedPotion), AchievementCategory.Collector);

            ConditionReqs wafflesIronReqs = new(PlayerDiff.Classic, WorldDiff.Classic, SpecialSeed.Zenith);
            RegisterAchievement("SEED_WAFFLES_IRON", NpcDropCondition.Drop(wafflesIronReqs, NPCID.None, ItemID.WaffleIron), AchievementCategory.Collector);
        }
    }
}
