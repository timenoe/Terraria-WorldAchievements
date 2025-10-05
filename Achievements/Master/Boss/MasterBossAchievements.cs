using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ModLoader;
using TerrariaAchievementLib.Achievements;
using TerrariaAchievementLib.Achievements.Conditions;
using WorldAchievements.Achievements.Expert.Items;

namespace WorldAchievements.Achievements.Master.Boss
{
    public class MasterKingSlimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterKingSlimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["KING_SLIME"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertWitchBroomAchievement>());
        }
    }

    public class MasterEyeOfCthulhuAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterEyeOfCthulhuAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["EYE_OF_CTHULHU"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterKingSlimeAchievement>());
        }
    }

    public class MasterEaterOfWorldsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterEaterOfWorldsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["EATER_OF_WORLDS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterEyeOfCthulhuAchievement>());
        }
    }

    public class MasterBrainOfCthulhuAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterBrainOfCthulhuAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["BRAIN_OF_CTHULHU"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterEaterOfWorldsAchievement>());
        }
    }

    public class MasterQueenBeeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterQueenBeeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["QUEEN_BEE"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterBrainOfCthulhuAchievement>());
        }
    }

    public class MasterSkeletronAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterSkeletronAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["SKELETRON"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterQueenBeeAchievement>());
        }
    }

    public class MasterDeerclopsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterDeerclopsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["DEERCLOPS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterSkeletronAchievement>());
        }
    }

    public class MasterWallOfFleshAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterWallOfFleshAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["WALL_OF_FLESH"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterDeerclopsAchievement>());
        }
    }

    public class MasterQueenSlimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterQueenSlimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["QUEEN_SLIME"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterWallOfFleshAchievement>());
        }
    }

    public class MasterTwinsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterTwinsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["TWINS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterQueenSlimeAchievement>());
        }
    }

    public class MasterDestroyerAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterDestroyerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["DESTROYER"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterTwinsAchievement>());
        }
    }

    public class MasterSkeletronPrimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterSkeletronPrimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["SKELETRON_PRIME"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterDestroyerAchievement>());
        }
    }

    public class MasterPlanteraAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPlanteraAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["PLANTERA"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterSkeletronPrimeAchievement>());
        }
    }

    public class MasterGolemAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterGolemAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["GOLEM"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPlanteraAchievement>());
        }
    }

    public class MasterEmpressOfLightAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterEmpressOfLightAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["EMPRESS_OF_LIGHT"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterGolemAchievement>());
        }
    }

    public class MasterDukeFishronAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterDukeFishronAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["DUKE_FISHRON"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterEmpressOfLightAchievement>());
        }
    }

    public class MasterLunaticCultistAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterLunaticCultistAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["LUNATIC_CULTIST"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterDukeFishronAchievement>());
        }
    }

    public class MasterMoonLordAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterMoonLordAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["MOON_LORD"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterLunaticCultistAchievement>());
        }
    }

    public class MasterMourningWoodAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterMourningWoodAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["MOURNING_WOOD"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterMoonLordAchievement>());
        }
    }

    public class MasterPumpkingAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterPumpkingAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["PUMPKING"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterMourningWoodAchievement>());
        }
    }

    public class MasterEverscreamAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterEverscreamAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["EVERSCREAM"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterPumpkingAchievement>());
        }
    }

    public class MasterSantaNk1Achievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterSantaNk1Achievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["SANTA-NK1"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterEverscreamAchievement>());
        }
    }

    public class MasterIceQueenAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterIceQueenAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["ICE_QUEEN"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterSantaNk1Achievement>());
        }
    }

    public class MasterDarkMageT3Achievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterDarkMageT3Achievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, false, AchievementData.DefeatBoss["DARK_MAGE_T3"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterIceQueenAchievement>());
        }
    }

    public class MasterOgreT3Achievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterOgreT3Achievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, false, AchievementData.DefeatBoss["OGRE_T3"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterDarkMageT3Achievement>());
        }
    }

    public class MasterBetsyAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterBetsyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["BETSY"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterOgreT3Achievement>());
        }
    }

    public class MasterFlyingDutchmanAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterFlyingDutchmanAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["FLYING_DUTCHMAN"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterBetsyAchievement>());
        }
    }

    public class MasterMartianSaucerAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/MasterMartianSaucerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(MasterAchievements.reqs, true, AchievementData.DefeatBoss["MARTIAN_SAUCER"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterFlyingDutchmanAchievement>());
        }
    }
}
