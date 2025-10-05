using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ID;
using Terraria.ModLoader;
using TerrariaAchievementLib.Achievements.Conditions;
using WorldAchievements.Achievements.Master.Boss;

namespace WorldAchievements.Achievements.Master.Pet
{
    public class Info
    {
        public static readonly Dictionary<string, int> MasterPets = new()
        {
            { "KING_SLIME",       BuffID.KingSlimePet },
            { "EYE_OF_CTHULHU",   BuffID.EyeOfCthulhuPet },
            { "EATER_OF_WORLDS",  BuffID.EaterOfWorldsPet },
            { "BRAIN_OF_CTHULHU", BuffID.BrainOfCthulhuPet },
            { "QUEEN_BEE",        BuffID.QueenBeePet },
            { "SKELETRON",        BuffID.SkeletronPet },
            { "DEERCLOPS",        BuffID.DeerclopsPet },
            { "WALL_OF_FLESH",    BuffID.WallOfFleshGoatMount },
            { "QUEEN_SLIME",      BuffID.QueenSlimePet },
            { "TWINS",            BuffID.TwinsPet },
            { "DESTROYER",        BuffID.DestroyerPet },
            { "SKELETRON_PRIME",  BuffID.SkeletronPrimePet },
            { "PLANTERA",         BuffID.PlanteraPet },
            { "GOLEM",            BuffID.GolemPet },
            { "EMPRESS_OF_LIGHT", BuffID.FairyQueenPet },
            { "DUKE_FISHRON",     BuffID.DukeFishronPet },
            { "LUNATIC_CULTIST",  BuffID.LunaticCultistPet },
            { "MOON_LORD",        BuffID.MoonLordPet },
            { "MOURNING_WOOD",    BuffID.SpookyWoodMount },
            { "PUMPKING",         BuffID.PumpkingPet },
            { "EVERSCREAM",       BuffID.EverscreamPet },
            { "SANTA-NK1",        BuffID.SantankMount },
            { "ICE_QUEEN",        BuffID.IceQueenPet },
            { "DARK_MAGE_T3",     BuffID.DarkMageBookMount },
            { "OGRE_T3",          BuffID.DD2OgrePet },
            { "BETSY",            BuffID.DD2BetsyPet },
            { "FLYING_DUTCHMAN",  BuffID.PirateShipMount },
            { "MARTIAN_SAUCER",   BuffID.MartianPet }
        };
    }

    public class MasterPetKingSlimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetKingSlimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["KING_SLIME"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterMartianSaucerAchievement>());
        }
    }

    public class MasterPetEyeOfCthulhuAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetEyeOfCthulhuAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["EYE_OF_CTHULHU"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetKingSlimeAchievement>());
        }
    }

    public class MasterPetEaterOfWorldsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetEaterOfWorldsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["EATER_OF_WORLDS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetEyeOfCthulhuAchievement>());
        }
    }

    public class MasterPetBrainOfCthulhuAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetBrainOfCthulhuAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["BRAIN_OF_CTHULHU"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetEaterOfWorldsAchievement>());
        }
    }

    public class MasterPetQueenBeeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetQueenBeeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["QUEEN_BEE"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetBrainOfCthulhuAchievement>());
        }
    }

    public class MasterPetSkeletronAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetSkeletronAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["SKELETRON"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetQueenBeeAchievement>());
        }
    }

    public class MasterPetDeerclopsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetDeerclopsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["DEERCLOPS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetSkeletronAchievement>());
        }
    }

    public class MasterPetWallOfFleshAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetWallOfFleshAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["WALL_OF_FLESH"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetDeerclopsAchievement>());
        }
    }

    public class MasterPetQueenSlimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetQueenSlimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["QUEEN_SLIME"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetWallOfFleshAchievement>());
        }
    }

    public class MasterPetTwinsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetTwinsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["TWINS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetQueenSlimeAchievement>());
        }
    }

    public class MasterPetDestroyerAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetDestroyerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["DESTROYER"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetTwinsAchievement>());
        }
    }

    public class MasterPetSkeletronPrimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetSkeletronPrimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["SKELETRON_PRIME"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetDestroyerAchievement>());
        }
    }

    public class MasterPetPlanteraAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetPlanteraAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["PLANTERA"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetSkeletronPrimeAchievement>());
        }
    }

    public class MasterPetGolemAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetGolemAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["GOLEM"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetPlanteraAchievement>());
        }
    }

    public class MasterPetEmpressOfLightAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetEmpressOfLightAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["EMPRESS_OF_LIGHT"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetGolemAchievement>());
        }
    }

    public class MasterPetDukeFishronAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetDukeFishronAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["DUKE_FISHRON"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetEmpressOfLightAchievement>());
        }
    }

    public class MasterPetLunaticCultistAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetLunaticCultistAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["LUNATIC_CULTIST"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetDukeFishronAchievement>());
        }
    }

    public class MasterPetMoonLordAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetMoonLordAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["MOON_LORD"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetLunaticCultistAchievement>());
        }
    }

    public class MasterPetMourningWoodAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetMourningWoodAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["MOURNING_WOOD"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetMoonLordAchievement>());
        }
    }

    public class MasterPetPumpkingAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetPumpkingAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["PUMPKING"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetMourningWoodAchievement>());
        }
    }

    public class MasterPetEverscreamAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetEverscreamAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["EVERSCREAM"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetPumpkingAchievement>());
        }
    }

    public class MasterPetSantaNk1Achievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetSantaNk1Achievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["SANTA-NK1"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetEverscreamAchievement>());
        }
    }

    public class MasterPetIceQueenAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetIceQueenAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["ICE_QUEEN"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetSantaNk1Achievement>());
        }
    }

    public class MasterPetDarkMageT3Achievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetDarkMageT3Achievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["DARK_MAGE_T3"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetIceQueenAchievement>());
        }
    }

    public class MasterPetOgreT3Achievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetOgreT3Achievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["OGRE_T3"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetDarkMageT3Achievement>());
        }
    }

    public class MasterPetBetsyAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetBetsyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["BETSY"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetOgreT3Achievement>());
        }
    }

    public class MasterPetFlyingDutchmanAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetFlyingDutchmanAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["FLYING_DUTCHMAN"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetBetsyAchievement>());
        }
    }

    public class MasterPetMartianSaucerAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPetMartianSaucerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            AddCondition(BuffAddCondition.Add(MasterAchievements.reqs, Info.MasterPets["MARTIAN_SAUCER"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPetFlyingDutchmanAchievement>());
        }
    }
}
