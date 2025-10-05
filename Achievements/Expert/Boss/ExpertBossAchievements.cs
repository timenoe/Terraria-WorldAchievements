using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ModLoader;
using TerrariaAchievementLib.Achievements;
using TerrariaAchievementLib.Achievements.Conditions;

namespace WorldAchievements.Achievements.Expert.Boss
{
    public class ExpertKingSlimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertKingSlimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["KING_SLIME"]));
        }
    }

    public class ExpertEyeOfCthulhuAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertEyeOfCthulhuAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["EYE_OF_CTHULHU"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertKingSlimeAchievement>());
        }
    }

    public class ExpertEaterOfWorldsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertEaterOfWorldsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["EATER_OF_WORLDS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertEyeOfCthulhuAchievement>());
        }
    }

    public class ExpertBrainOfCthulhuAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertBrainOfCthulhuAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["BRAIN_OF_CTHULHU"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertEaterOfWorldsAchievement>());
        }
    }

    public class ExpertQueenBeeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertQueenBeeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["QUEEN_BEE"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertBrainOfCthulhuAchievement>());
        }
    }

    public class ExpertSkeletronAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSkeletronAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["SKELETRON"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertQueenBeeAchievement>());
        }
    }

    public class ExpertDeerclopsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertDeerclopsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["DEERCLOPS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSkeletronAchievement>());
        }
    }

    public class ExpertWallOfFleshAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertWallOfFleshAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["WALL_OF_FLESH"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertDeerclopsAchievement>());
        }
    }

    public class ExpertQueenSlimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertQueenSlimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["QUEEN_SLIME"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertWallOfFleshAchievement>());
        }
    }

    public class ExpertTwinsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertTwinsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["TWINS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertQueenSlimeAchievement>());
        }
    }

    public class ExpertDestroyerAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertDestroyerAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["DESTROYER"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertTwinsAchievement>());
        }
    }

    public class ExpertSkeletronPrimeAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSkeletronPrimeAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["SKELETRON_PRIME"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertDestroyerAchievement>());
        }
    }

    public class ExpertPlanteraAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertPlanteraAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["PLANTERA"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSkeletronPrimeAchievement>());
        }
    }

    public class ExpertGolemAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertGolemAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["GOLEM"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertPlanteraAchievement>());
        }
    }

    public class ExpertEmpressOfLightAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertEmpressOfLightAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["EMPRESS_OF_LIGHT"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertGolemAchievement>());
        }
    }

    public class ExpertDukeFishronAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertDukeFishronAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["DUKE_FISHRON"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertEmpressOfLightAchievement>());
        }
    }

    public class ExpertMoonLordAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertMoonLordAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["MOON_LORD"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertDukeFishronAchievement>());
        }
    }

    public class ExpertBetsyAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertBetsyAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Slayer);

            AddCondition(NpcKillCondition.KillAny(ExpertAchievements.reqs, true, AchievementData.DefeatBoss["BETSY"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertMoonLordAchievement>());
        }
    }
}
