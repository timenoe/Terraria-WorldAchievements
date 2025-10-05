using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ModLoader;
using TerrariaAchievementLib.Achievements;
using TerrariaAchievementLib.Achievements.Conditions;
using WorldAchievements.Achievements.Master.Items;

namespace WorldAchievements.Achievements.Legendary
{
    /// <summary>
    /// Expert achievement attributes
    /// </summary>
    public class LegendaryAchievements
    {
        /// <summary>
        /// Expert achievement condition requirements
        /// </summary>
        public static readonly ConditionReqs reqs = new(PlayerDiff.Classic, WorldDiff.Master, SpecialSeed.Worthy);
    }

    public class LegendaryKingSlimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryKingSlimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["KING_SLIME"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<MasterResplendentDessertAchievement>());
        }
    }

    public class LegendaryEyeOfCthulhuAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryEyeOfCthulhuAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["EYE_OF_CTHULHU"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryKingSlimeAchievement>());
        }
    }

    public class LegendaryEaterOfWorldsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryEaterOfWorldsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["EATER_OF_WORLDS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryEyeOfCthulhuAchievement>());
        }
    }

    public class LegendaryBrainOfCthulhuAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryBrainOfCthulhuAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["BRAIN_OF_CTHULHU"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryEaterOfWorldsAchievement>());
        }
    }

    public class LegendaryQueenBeeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryQueenBeeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["QUEEN_BEE"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryBrainOfCthulhuAchievement>());
        }
    }

    public class LegendarySkeletronAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendarySkeletronAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["SKELETRON"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryQueenBeeAchievement>());
        }
    }

    public class LegendaryDeerclopsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryDeerclopsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["DEERCLOPS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendarySkeletronAchievement>());
        }
    }

    public class LegendaryWallOfFleshAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryWallOfFleshAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["WALL_OF_FLESH"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryDeerclopsAchievement>());
        }
    }

    public class LegendaryQueenSlimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryQueenSlimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["QUEEN_SLIME"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryWallOfFleshAchievement>());
        }
    }

    public class LegendaryTwinsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryTwinsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["TWINS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryQueenSlimeAchievement>());
        }
    }

    public class LegendaryDestroyerAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryDestroyerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["DESTROYER"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryTwinsAchievement>());
        }
    }

    public class LegendarySkeletronPrimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendarySkeletronPrimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["SKELETRON_PRIME"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryDestroyerAchievement>());
        }
    }

    public class LegendaryPlanteraAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryPlanteraAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["PLANTERA"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendarySkeletronPrimeAchievement>());
        }
    }

    public class LegendaryGolemAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryGolemAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["GOLEM"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryPlanteraAchievement>());
        }
    }

    public class LegendaryEmpressOfLightAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryEmpressOfLightAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["EMPRESS_OF_LIGHT"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryGolemAchievement>());
        }
    }

    public class LegendaryDukeFishronAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryDukeFishronAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["DUKE_FISHRON"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryEmpressOfLightAchievement>());
        }
    }

    public class LegendaryLunaticCultistAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryLunaticCultistAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["LUNATIC_CULTIST"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryDukeFishronAchievement>());
        }
    }

    public class LegendaryMoonLordAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryMoonLordAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["MOON_LORD"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryLunaticCultistAchievement>());
        }
    }

    public class LegendaryMourningWoodAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryMourningWoodAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["MOURNING_WOOD"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryMoonLordAchievement>());
        }
    }

    public class LegendaryPumpkingAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryPumpkingAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["PUMPKING"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryMourningWoodAchievement>());
        }
    }

    public class LegendaryEverscreamAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryEverscreamAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["EVERSCREAM"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryPumpkingAchievement>());
        }
    }

    public class LegendarySantaNk1Achievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendarySantaNk1Achievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["SANTA-NK1"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryEverscreamAchievement>());
        }
    }

    public class LegendaryIceQueenAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryIceQueenAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["ICE_QUEEN"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendarySantaNk1Achievement>());
        }
    }

    public class LegendaryDarkMageT3Achievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryDarkMageT3Achievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, false, AchievementData.DefeatBoss["DARK_MAGE_T3"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryIceQueenAchievement>());
        }
    }

    public class LegendaryOgreT3Achievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryOgreT3Achievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, false, AchievementData.DefeatBoss["OGRE_T3"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryDarkMageT3Achievement>());
        }
    }

    public class LegendaryBetsyAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryBetsyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["BETSY"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryOgreT3Achievement>());
        }
    }

    public class LegendaryFlyingDutchmanAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryFlyingDutchmanAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["FLYING_DUTCHMAN"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryBetsyAchievement>());
        }
    }

    public class LegendaryMartianSaucerAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/LegendaryMartianSaucerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(LegendaryAchievements.reqs, true, AchievementData.DefeatBoss["MARTIAN_SAUCER"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryFlyingDutchmanAchievement>());
        }
    }
}
