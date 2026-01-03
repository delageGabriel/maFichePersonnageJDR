using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Controller
{
    class ArmesController
    {
        public static List<string> GetArmeNamesByType(string type)
        {
            Console.WriteLine("########### Méthode GetArmeNamesByType ###########");
            NewArmesModel newArmesModel = new NewArmesModel();

            List<string> armesName = newArmesModel.GetArmeNamesByType(type);

            if (armesName != null)
                return armesName;
            else
                return null;
        }

        public static Dictionary<string, string> GetArmeInformationsByName(string name)
        {
            Console.WriteLine("########### Méthode GetArmeNamesByType ###########");
            NewArmesModel newArmesModel = new NewArmesModel();

            Dictionary<string, string> arme = new Dictionary<string, string>
            {
                { "Nom", name },
                { "Type", newArmesModel.GetArmeTypeByName(name) },
                { "Prerequis", newArmesModel.GetArmePrerequisByName(name) },
                { "Mains", newArmesModel.GetArmeMainsByName(name) },
                { "Portee", newArmesModel.GetArmePorteeByName(name) },
                { "Poids", newArmesModel.GetArmePoidsByName(name) },
                { "Degats", newArmesModel.GetArmeDegatsByName(name) },
                { "Jet", newArmesModel.GetArmeJetsDegatsByName(name) },
                { "Valeur", newArmesModel.GetArmeValeurByName(name) },
                { "Effet", newArmesModel.GetArmeEffetsByName(name) }
            };

            return arme;
        }

        public static string GetArmeWeightByName(string name)
        {
            Console.WriteLine("########### Méthode GetArmeNamesByType ###########");
            NewArmesModel newArmesModel = new NewArmesModel();

            return newArmesModel.GetArmePoidsByName(name);
        }
    }
}
