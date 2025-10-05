using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ID;
using Terraria.ModLoader;
using TerrariaAchievementLib.Achievements;
using TerrariaAchievementLib.Achievements.Conditions;
using WorldAchievements.Achievements.Legendary;

namespace WorldAchievements.Achievements.Zenith
{
    /// <summary>
    /// Zenith seed achievement attributes
    /// </summary>
    public class ZenithAchievements
    {
        /// <summary>
        /// Zenith seed achievement condition requirements
        /// </summary>
        public static readonly ConditionReqs reqs = new(PlayerDiff.Classic, WorldDiff.Classic, SpecialSeed.Zenith);
    }

    public class ZenithKingSlimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithKingSlimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["KING_SLIME"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<LegendaryMartianSaucerAchievement>());
        }
    }

    public class ZenithEyeOfCthulhuAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithEyeOfCthulhuAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["EYE_OF_CTHULHU"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithKingSlimeAchievement>());
        }
    }

    public class ZenithEaterOfWorldsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithEaterOfWorldsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["EATER_OF_WORLDS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithEyeOfCthulhuAchievement>());
        }
    }

    public class ZenithBrainOfCthulhuAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithBrainOfCthulhuAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["BRAIN_OF_CTHULHU"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithEaterOfWorldsAchievement>());
        }
    }

    public class ZenithQueenBeeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithQueenBeeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["QUEEN_BEE"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithBrainOfCthulhuAchievement>());
        }
    }

    public class ZenithSkeletronAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithSkeletronAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["SKELETRON"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithQueenBeeAchievement>());
        }
    }

    public class ZenithDeerclopsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithDeerclopsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["DEERCLOPS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithSkeletronAchievement>());
        }
    }

    public class ZenithWallOfFleshAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithWallOfFleshAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["WALL_OF_FLESH"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithDeerclopsAchievement>());
        }
    }

    public class ZenithQueenSlimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithQueenSlimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["QUEEN_SLIME"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithWallOfFleshAchievement>());
        }
    }

    public class ZenithMechdusaAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithMechdusaAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcDropCondition.Drop(ZenithAchievements.reqs, NPCID.None, ItemID.WaffleIron));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithQueenSlimeAchievement>());
        }
    }

    public class ZenithPlanteraAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithPlanteraAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["PLANTERA"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithMechdusaAchievement>());
        }
    }

    public class ZenithGolemAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithGolemAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["GOLEM"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithPlanteraAchievement>());
        }
    }

    public class ZenithEmpressOfLightAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithEmpressOfLightAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["EMPRESS_OF_LIGHT"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithGolemAchievement>());
        }
    }

    public class ZenithDukeFishronAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithDukeFishronAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["DUKE_FISHRON"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithEmpressOfLightAchievement>());
        }
    }

    public class ZenithLunaticCultistAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithLunaticCultistAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["LUNATIC_CULTIST"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithDukeFishronAchievement>());
        }
    }

    public class ZenithMoonLordAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithMoonLordAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["MOON_LORD"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithLunaticCultistAchievement>());
        }
    }

    public class ZenithMourningWoodAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithMourningWoodAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["MOURNING_WOOD"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithMoonLordAchievement>());
        }
    }

    public class ZenithPumpkingAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithPumpkingAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["PUMPKING"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithMourningWoodAchievement>());
        }
    }

    public class ZenithEverscreamAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithEverscreamAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["EVERSCREAM"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithPumpkingAchievement>());
        }
    }

    public class ZenithSantaNk1Achievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithSantaNk1Achievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["SANTA-NK1"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithEverscreamAchievement>());
        }
    }

    public class ZenithIceQueenAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithIceQueenAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["ICE_QUEEN"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithSantaNk1Achievement>());
        }
    }

    public class ZenithDarkMageT3Achievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithDarkMageT3Achievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, false, AchievementData.DefeatBoss["DARK_MAGE_T3"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithIceQueenAchievement>());
        }
    }

    public class ZenithOgreT3Achievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithOgreT3Achievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, false, AchievementData.DefeatBoss["OGRE_T3"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithDarkMageT3Achievement>());
        }
    }

    public class ZenithBetsyAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithBetsyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["BETSY"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithOgreT3Achievement>());
        }
    }

    public class ZenithFlyingDutchmanAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithFlyingDutchmanAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["FLYING_DUTCHMAN"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithBetsyAchievement>());
        }
    }

    public class ZenithMartianSaucerAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ZenithMartianSaucerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ZenithAchievements.reqs, true, AchievementData.DefeatBoss["MARTIAN_SAUCER"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ZenithFlyingDutchmanAchievement>());
        }
    }
}
