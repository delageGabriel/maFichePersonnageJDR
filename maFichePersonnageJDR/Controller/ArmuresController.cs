using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Controller
{
    class ArmuresController
    {
        public static List<string> GetArmureNamesByType(string type)
        {
            Console.WriteLine("########### Méthode GetArmureNamesByType ###########");
            NewArmuresModel newArmuresModel = new NewArmuresModel();

            List<string> armuresNames = newArmuresModel.GetArmureNamesByType(type);

            if (armuresNames != null)
                return armuresNames;
            else
                return null;
        }

        public static Dictionary<string, string> GetArmureInformationsByName(string name)
        {
            Console.WriteLine("########### Méthode GetArmureInformationsByName ###########");
            NewArmuresModel newArmuresModel = new NewArmuresModel();

            Dictionary<string, string> armure = new Dictionary<string, string>
            {
                { "Nom", name },
                { "Taille", newArmuresModel.GetArmureSizeByName(name) },
                { "Type", newArmuresModel.GetArmureTypeByName(name) },
                { "Prerequis", newArmuresModel.GetArmurePrerequisByName(name) },
                { "Defense", newArmuresModel.GetArmureDefenseValueByName(name) },
                { "Tranchant", newArmuresModel.GetArmureTranchantReductionValueByName(name) },
                { "Contondant", newArmuresModel.GetArmureContondantReductionValueByName(name) },
                { "Perforant", newArmuresModel.GetArmurePerforantReductionValueByName(name) },
                { "Ignee", newArmuresModel.GetArmureIgneeReductionValueByName(name) },
                { "Aquatique", newArmuresModel.GetArmureAquatiqueReductionValueByName(name) },
                { "Celeste", newArmuresModel.GetArmureCelesteReductionValueByName(name) },
                { "Terrestre", newArmuresModel.GetArmureTerrestreReductionValueByName(name) },
                { "Choc", newArmuresModel.GetArmureChocReductionValueByName(name) },
                { "Acide", newArmuresModel.GetArmureAcideReductionValueByName(name) },
                { "Pression", newArmuresModel.GetArmurePressionReductionValueByName(name) },
                { "Poids", newArmuresModel.GetArmureWeightValueByName(name) },
                { "Valeur", newArmuresModel.GetArmureValueByName(name) },
                { "Dexterite", newArmuresModel.GetArmureDexteriteBonusByName(name) },
                { "Initiative", newArmuresModel.GetArmureInitiativeBonusByName(name) },
                { "Vitesse", newArmuresModel.GetArmureVitesseBonusByName(name) },
                { "Froid", newArmuresModel.GetArmureFroidBonusByName(name) },
                { "Chaleur", newArmuresModel.GetArmureChaleurBonusByName(name) },
                { "Effets", newArmuresModel.GetArmureEffectByName(name) },
                { "Composition", newArmuresModel.GetArmureCompositionByName(name) }
            };

            return armure;
        }
        public static string GetArmureWeightByName(string name)
        {
            Console.WriteLine("########### Méthode GetArmureWeightByName ###########");
            NewArmuresModel newArmuresModel = new NewArmuresModel();

            return newArmuresModel.GetArmureWeightValueByName(name);
        }
    }
}
