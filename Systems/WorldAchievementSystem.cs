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

        protected override List<string> TexturePaths { get => ["WorldAchievements/Assets/Achievements"]; }

        protected override void RegisterAchievements()
        {
            ConditionReqs expertReqs = new(PlayerDiff.Classic, WorldDiff.Expert, SpecialSeed.None);
            RegisterExpertBagAchievements(expertReqs);
            RegisterExpertDevAchievements(expertReqs);
            RegisterExpertItemAchievements(expertReqs);

            ConditionReqs masterReqs = new(PlayerDiff.Classic, WorldDiff.Master, SpecialSeed.None);
            RegisterMasterRelicAchievements(masterReqs);
            RegisterMasterPetAchievements(masterReqs);
            RegisterMasterItemAchievements(masterReqs);
        }

        private void RegisterExpertBagAchievements(ConditionReqs reqs)
        {
            Dictionary<string, int> TreasureBags = new()
            {
                { "BAG_KING_SLIME", ItemID.KingSlimeBossBag },
                { "BAG_EYE_OF_CTHULHU", ItemID.EyeOfCthulhuBossBag },
                { "BAG_EATER_OF_WORLDS", ItemID.EaterOfWorldsBossBag },
                { "BAG_BRAIN_OF_CTHULHU", ItemID.BrainOfCthulhuBossBag },
                { "BAG_QUEEN_BEE", ItemID.QueenBeeBossBag },
                { "BAG_SKELETRON", ItemID.SkeletronBossBag },
                { "BAG_DEERCLOPS", ItemID.DeerclopsBossBag },
                { "BAG_WALL_OF_FLESH", ItemID.WallOfFleshBossBag },
                { "BAG_QUEEN_SLIME", ItemID.QueenSlimeBossBag },
                { "BAG_TWINS", ItemID.TwinsBossBag },
                { "BAG_DESTROYER", ItemID.DestroyerBossBag },
                { "BAG_SKELETRON_PRIME", ItemID.SkeletronPrimeBossBag },
                { "BAG_PLANTERA", ItemID.PlanteraBossBag },
                { "BAG_GOLEM", ItemID.GolemBossBag },
                { "BAG_EMPRESS_OF_LIGHT", ItemID.FairyQueenBossBag },
                { "BAG_DUKE_FISHRON", ItemID.FishronBossBag },
                { "BAG_MOON_LORD", ItemID.MoonLordBossBag },
                { "BAG_BETSY", ItemID.BossBagBetsy }
            };

            foreach (var bag in TreasureBags)
                RegisterAchievement(bag.Key, NpcDropCondition.Drop(reqs, NPCID.None, bag.Value), AchievementCategory.Slayer);
        }

        private void RegisterExpertDevAchievements(ConditionReqs reqs)
        {
            Dictionary<string, int[]> DevSets = new()
            {
                { "SET_AARON", [ItemID.AaronsHelmet, ItemID.AaronsBreastplate, ItemID.AaronsLeggings] },
                { "SET_ARKHALIS", [ItemID.ArkhalisHat, ItemID.ArkhalisShirt, ItemID.ArkhalisPants, ItemID.ArkhalisWings, ItemID.Arkhalis] },
                { "SET_CENX", [ItemID.CenxsTiara, ItemID.CenxsBreastplate, ItemID.CenxsLeggings, ItemID.CenxsWings] },
                { "SET_CENX_DRESS", [ItemID.CenxsTiara, ItemID.CenxsDress, ItemID.CenxsDressPants, ItemID.CenxsWings] },
                { "SET_CROWNO", [ItemID.CrownosMask, ItemID.CrownosBreastplate, ItemID.CrownosLeggings, ItemID.CrownosWings] },
                { "SET_D-TOWN", [ItemID.DTownsHelmet, ItemID.DTownsBreastplate, ItemID.DTownsLeggings, ItemID.DTownsWings] },
                { "SET_JIM", [ItemID.JimsHelmet, ItemID.JimsBreastplate, ItemID.JimsLeggings, ItemID.JimsWings] },
                { "SET_LAZURE", [ItemID.BejeweledValkyrieHead, ItemID.BejeweledValkyrieBody, ItemID.BejeweledValkyrieWing, ItemID.ValkyrieYoyo] },
                { "SET_LEINFOR", [ItemID.LeinforsHat, ItemID.LeinforsShirt, ItemID.LeinforsPants, ItemID.LeinforsAccessory, ItemID.LeinforsWings] },
                { "SET_LOKI", [ItemID.LokisHelm, ItemID.LokisShirt, ItemID.LokisPants, ItemID.LokisWings, ItemID.LokisDye] },
                { "SET_RED", [ItemID.RedsHelmet, ItemID.RedsBreastplate, ItemID.RedsLeggings, ItemID.RedsWings, ItemID.RedsYoyo] },
                { "SET_SKIPHS", [ItemID.SkiphsHelm, ItemID.SkiphsShirt, ItemID.SkiphsPants, ItemID.SkiphsWings, ItemID.DevDye] },
                { "SET_WILL", [ItemID.WillsHelmet, ItemID.WillsBreastplate, ItemID.WillsLeggings, ItemID.WillsWings] },
                { "SET_YORAI", [ItemID.Yoraiz0rHead, ItemID.Yoraiz0rShirt, ItemID.Yoraiz0rPants, ItemID.Yoraiz0rDarkness, ItemID.Yoraiz0rWings] },
                { "SET_GROX_THE_GREAT", [ItemID.GroxTheGreatHelm, ItemID.GroxTheGreatArmor, ItemID.GroxTheGreatGreaves, ItemID.GroxTheGreatWings] },
                { "SET_FOODBARBARIAN", [ItemID.FoodBarbarianHelm, ItemID.FoodBarbarianArmor, ItemID.FoodBarbarianGreaves, ItemID.FoodBarbarianWings] },
                { "SET_SAFEMAN", [ItemID.SafemanSunHair, ItemID.SafemanSunDress, ItemID.SafemanDressLeggings, ItemID.SafemanWings] },
                { "SET_GHOSTAR", [ItemID.GhostarSkullPin, ItemID.GhostarShirt, ItemID.GhostarPants, ItemID.GhostarsWings] }
            };

            foreach (var set in DevSets)
                RegisterAchievement(set.Key, ItemOpenCondition.OpenAll(reqs, ItemID.None, set.Value), set.Value.Length > 1, AchievementCategory.Collector);
        }

        private void RegisterExpertItemAchievements(ConditionReqs reqs)
        {
            RegisterAchievement("DEMON_HEART", ItemUseCondition.Use(reqs, ItemID.DemonHeart), AchievementCategory.Collector);
            RegisterAchievement("MINECART_UPGRADE_KIT", ItemUseCondition.Use(reqs, ItemID.MinecartPowerup), AchievementCategory.Collector);
            RegisterAchievement("WITCH_BROOM", BuffAddCondition.Add(reqs, BuffID.WitchBroom), AchievementCategory.Collector);
        }

        private void RegisterMasterRelicAchievements(ConditionReqs reqs)
        {
            Dictionary<string, int> Relics = new()
            {
                { "RELIC_KING_SLIME", ItemID.KingSlimeMasterTrophy },
                { "RELIC_EYE_OF_CTHULHU", ItemID.EyeofCthulhuMasterTrophy },
                { "RELIC_EATER_OF_WORLDS", ItemID.EaterofWorldsMasterTrophy },
                { "RELIC_BRAIN_OF_CTHULHU", ItemID.BrainofCthulhuMasterTrophy },
                { "RELIC_QUEEN_BEE", ItemID.QueenBeeMasterTrophy },
                { "RELIC_SKELETRON", ItemID.SkeletronMasterTrophy },
                { "RELIC_DEERCLOPS", ItemID.DeerclopsMasterTrophy },
                { "RELIC_WALL_OF_FLESH", ItemID.WallofFleshMasterTrophy },
                { "RELIC_QUEEN_SLIME", ItemID.QueenSlimeMasterTrophy },
                { "RELIC_TWINS", ItemID.TwinsMasterTrophy },
                { "RELIC_DESTROYER", ItemID.DestroyerMasterTrophy },
                { "RELIC_SKELETRON_PRIME", ItemID.SkeletronPrimeMasterTrophy },
                { "RELIC_PLANTERA", ItemID.PlanteraMasterTrophy },
                { "RELIC_GOLEM", ItemID.GolemMasterTrophy },
                { "RELIC_EMPRESS_OF_LIGHT", ItemID.FairyQueenMasterTrophy },
                { "RELIC_DUKE_FISHRON", ItemID.DukeFishronMasterTrophy },
                { "RELIC_LUNATIC_CULTIST", ItemID.LunaticCultistMasterTrophy },
                { "RELIC_MOON_LORD", ItemID.MoonLordMasterTrophy },
                { "RELIC_MOURNING_WOOD", ItemID.MourningWoodMasterTrophy },
                { "RELIC_PUMPKING", ItemID.PumpkingMasterTrophy },
                { "RELIC_EVERSCREAM", ItemID.EverscreamMasterTrophy },
                { "RELIC_SANTA-NK1", ItemID.SantankMasterTrophy },
                { "RELIC_ICE_QUEEN", ItemID.IceQueenMasterTrophy },
                { "RELIC_DARK_MAGE_T3", ItemID.DarkMageMasterTrophy },
                { "RELIC_OGRE_T3", ItemID.OgreMasterTrophy },
                { "RELIC_BETSY", ItemID.BetsyMasterTrophy },
                { "RELIC_FLYING_DUTCHMAN", ItemID.FlyingDutchmanMasterTrophy },
                { "RELIC_MARTIAN_SAUCER", ItemID.UFOMasterTrophy }
            };

            foreach (var relic in Relics)
                RegisterAchievement(relic.Key, NpcDropCondition.Drop(reqs, ItemID.None, relic.Value), AchievementCategory.Collector);
        }

        private void RegisterMasterPetAchievements(ConditionReqs reqs)
        {
            Dictionary<string, int> MasterPets = new()
            {
                { "PET_KING_SLIME", BuffID.KingSlimePet },
                { "PET_EYE_OF_CTHULHU", BuffID.EyeOfCthulhuPet },
                { "PET_EATER_OF_WORLDS", BuffID.EaterOfWorldsPet },
                { "PET_BRAIN_OF_CTHULHU", BuffID.BrainOfCthulhuPet },
                { "PET_QUEEN_BEE", BuffID.QueenBeePet },
                { "PET_SKELETRON", BuffID.SkeletronPet },
                { "PET_DEERCLOPS", BuffID.DeerclopsPet },
                { "PET_WALL_OF_FLESH", BuffID.WallOfFleshGoatMount },
                { "PET_QUEEN_SLIME", BuffID.QueenSlimePet },
                { "PET_TWINS", BuffID.TwinsPet },
                { "PET_DESTROYER", BuffID.DestroyerPet },
                { "PET_SKELETRON_PRIME", BuffID.SkeletronPrimePet },
                { "PET_PLANTERA", BuffID.PlanteraPet },
                { "PET_GOLEM", BuffID.GolemPet },
                { "PET_EMPRESS_OF_LIGHT", BuffID.FairyQueenPet },
                { "PET_DUKE_FISHRON", BuffID.DukeFishronPet },
                { "PET_LUNATIC_CULTIST", BuffID.LunaticCultistPet },
                { "PET_MOON_LORD", BuffID.MoonLordPet },
                { "PET_MOURNING_WOOD", BuffID.SpookyWoodMount },
                { "PET_PUMPKING", BuffID.PumpkingPet },
                { "PET_EVERSCREAM", BuffID.EverscreamPet },
                { "PET_SANTA-NK1", BuffID.SantankMount },
                { "PET_ICE_QUEEN", BuffID.IceQueenPet },
                { "PET_DARK_MAGE_T3", BuffID.DarkMageBookMount },
                { "PET_OGRE_T3", BuffID.DD2OgrePet },
                { "PET_BETSY", BuffID.DD2BetsyPet },
                { "PET_FLYING_DUTCHMAN", BuffID.PirateShipMount },
                { "PET_MARTIAN_SAUCER", BuffID.MartianPet }
            };

            foreach (var pet in MasterPets)
                RegisterAchievement(pet.Key, BuffAddCondition.Add(reqs, pet.Value), AchievementCategory.Collector);
        }

        private void RegisterMasterItemAchievements(ConditionReqs reqs)
        {
            RegisterAchievement("RESPLENDENT_DESSERT", ItemCraftCondition.Craft(reqs, ItemID.ResplendentDessert), AchievementCategory.Collector);
        }
    }
}
