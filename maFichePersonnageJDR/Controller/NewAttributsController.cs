using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Controller
{
    class NewAttributsController
    {
        public static List<string> GetAttributesNameByType(string type)
        {
            Console.WriteLine("########### Méthode GetAttributesNameByType ###########");
            NewAttributsModel newAttributsModel = new NewAttributsModel();

            List<string> attributesName = newAttributsModel.GetAttributsNamesByType(type);

            if (attributesName != null)
                return attributesName;
            else
                return null;
        }

        public static Dictionary<string, string> GetAttributesInformationsByName(string name)
        {
            Console.WriteLine("########### Méthode GetAttributesNameByType ###########");
            NewAttributsModel newAttributsModel = new NewAttributsModel();

            Dictionary<string, string> attribut = new Dictionary<string, string>
            {
                { "Nom", name },
                { "Effet", newAttributsModel.GetAttributeEffectByName(name) },
                { "Type", newAttributsModel.GetAttributeTypeByName(name) }
            };

            return attribut;
        }

        public static string GetAttributeEffectByName(string name)
        {
            Console.WriteLine("########### Méthode GetAttributesNameByType ###########");
            NewAttributsModel newAttributsModel = new NewAttributsModel();

            return newAttributsModel.GetAttributeEffectByName(name);
        }

        public static string GetAttributeTypeByName(string name)
        {
            Console.WriteLine("########### Méthode GetAttributeTypeByName ###########");
            NewAttributsModel newAttributsModel = new NewAttributsModel();

            return newAttributsModel.GetAttributeTypeByName(name);
        }
    }
}
