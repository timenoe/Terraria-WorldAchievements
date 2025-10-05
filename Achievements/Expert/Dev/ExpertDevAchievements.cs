using System.Collections.Generic;
using Terraria.Achievements;
using Terraria.ID;
using Terraria.ModLoader;
using TerrariaAchievementLib.Achievements;
using TerrariaAchievementLib.Achievements.Conditions;
using WorldAchievements.Achievements.Expert.Boss;

namespace WorldAchievements.Achievements.Expert.Dev
{
    public class Info
    {
        public static readonly Dictionary<string, int[]> DevSets = new()
        {
            { "AARON",          [ItemID.AaronsHelmet, ItemID.AaronsBreastplate, ItemID.AaronsLeggings] },
            { "ARKHALIS",       [ItemID.ArkhalisHat, ItemID.ArkhalisShirt, ItemID.ArkhalisPants, ItemID.ArkhalisWings, ItemID.Arkhalis] },
            { "CENX",           [ItemID.CenxsTiara, ItemID.CenxsBreastplate, ItemID.CenxsLeggings, ItemID.CenxsWings] },
            { "CENX_DRESS",     [ItemID.CenxsTiara, ItemID.CenxsDress, ItemID.CenxsDressPants, ItemID.CenxsWings] },
            { "CROWNO",         [ItemID.CrownosMask, ItemID.CrownosBreastplate, ItemID.CrownosLeggings, ItemID.CrownosWings] },
            { "DTOWN",          [ItemID.DTownsHelmet, ItemID.DTownsBreastplate, ItemID.DTownsLeggings, ItemID.DTownsWings] },
            { "JIM",            [ItemID.JimsHelmet, ItemID.JimsBreastplate, ItemID.JimsLeggings, ItemID.JimsWings] },
            { "LAZURE",         [ItemID.BejeweledValkyrieHead, ItemID.BejeweledValkyrieBody, ItemID.BejeweledValkyrieWing, ItemID.ValkyrieYoyo] },
            { "LEINFOR",        [ItemID.LeinforsHat, ItemID.LeinforsShirt, ItemID.LeinforsPants, ItemID.LeinforsAccessory, ItemID.LeinforsWings] },
            { "LOKI",           [ItemID.LokisHelm, ItemID.LokisShirt, ItemID.LokisPants, ItemID.LokisWings, ItemID.LokisDye] },
            { "RED",            [ItemID.RedsHelmet, ItemID.RedsBreastplate, ItemID.RedsLeggings, ItemID.RedsWings, ItemID.RedsYoyo] },
            { "SKIPHS",         [ItemID.SkiphsHelm, ItemID.SkiphsShirt, ItemID.SkiphsPants, ItemID.SkiphsWings, ItemID.DevDye] },
            { "WILL",           [ItemID.WillsHelmet, ItemID.WillsBreastplate, ItemID.WillsLeggings, ItemID.WillsWings] },
            { "YORAI",          [ItemID.Yoraiz0rHead, ItemID.Yoraiz0rShirt, ItemID.Yoraiz0rPants, ItemID.Yoraiz0rDarkness, ItemID.Yoraiz0rWings] },
            { "GROX_THE_GREAT", [ItemID.GroxTheGreatHelm, ItemID.GroxTheGreatArmor, ItemID.GroxTheGreatGreaves, ItemID.GroxTheGreatWings] },
            { "FOODBARBARIAN",  [ItemID.FoodBarbarianHelm, ItemID.FoodBarbarianArmor, ItemID.FoodBarbarianGreaves, ItemID.FoodBarbarianWings] },
            { "SAFEMAN",        [ItemID.SafemanSunHair, ItemID.SafemanSunDress, ItemID.SafemanDressLeggings, ItemID.SafemanWings] },
            { "GHOSTAR",        [ItemID.GhostarSkullPin, ItemID.GhostarShirt, ItemID.GhostarPants, ItemID.GhostarsWings] }
        };
    }

    public class ExpertSetAaronAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetAaronAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["AARON"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertBetsyAchievement>());
        }
    }

    public class ExpertSetArkhalisAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetArkhalisAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["ARKHALIS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetAaronAchievement>());
        }
    }

    public class ExpertSetCenxAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetCenxAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["CENX"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetArkhalisAchievement>());
        }
    }

    public class ExpertSetCenxDressAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetCenxDressAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["CENX_DRESS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetCenxAchievement>());
        }
    }

    public class ExpertSetCrownoAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetCrownoAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["CROWNO"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetCenxDressAchievement>());
        }
    }

    public class ExpertSetDTownAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetDTownAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["DTOWN"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetCrownoAchievement>());
        }
    }

    public class ExpertSetJimAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetJimAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["JIM"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetDTownAchievement>());
        }
    }

    public class ExpertSetLazureAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetLazureAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["LAZURE"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetJimAchievement>());
        }
    }

    public class ExpertSetLeinforAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetLeinforAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["LEINFOR"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetLazureAchievement>());
        }
    }

    public class ExpertSetLokiAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetLokiAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["LOKI"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetLeinforAchievement>());
        }
    }

    public class ExpertSetRedAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetRedAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["RED"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetLokiAchievement>());
        }
    }

    public class ExpertSetSkiphsAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetSkiphsAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["SKIPHS"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetRedAchievement>());
        }
    }

    public class ExpertSetWillAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetWillAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["WILL"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetSkiphsAchievement>());
        }
    }

    public class ExpertSetYoraiAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetYoraiAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["YORAI"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetWillAchievement>());
        }
    }

    public class ExpertSetGroxTheGreatAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetGroxTheGreatAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["GROX_THE_GREAT"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetYoraiAchievement>());
        }
    }

    public class ExpertSetFoodbarbarianAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetFoodbarbarianAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["FOODBARBARIAN"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetGroxTheGreatAchievement>());
        }
    }

    public class ExpertSetSafemanAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetSafemanAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["SAFEMAN"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetFoodbarbarianAchievement>());
        }
    }

    public class ExpertSetGhostarAchievement : ModAchievement
    {
        public override string TextureName => "WorldAchievements/Assets/ExpertSetGhostarAchievement";

        public override void SetStaticDefaults()
        {
            Achievement.SetCategory(AchievementCategory.Collector);

            ConditionHelper.AddConditions(this, ItemOpenCondition.OpenAll(ExpertAchievements.reqs, ItemID.None, Info.DevSets["GHOSTAR"]));
        }

        public override IEnumerable<Position> GetModdedConstraints()
        {
            yield return new After(ModContent.GetInstance<ExpertSetSafemanAchievement>());
        }
    }
}
