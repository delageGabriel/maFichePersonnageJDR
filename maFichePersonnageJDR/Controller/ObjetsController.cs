using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Controller
{
    class ObjetsController
    {
        public static List<string> GetObjetNameByType(string type)
        {
            Console.WriteLine("########### Méthode GetObjetNameByType ###########");
            NewObjetsModel objetsModel = new NewObjetsModel();

            List<string> objetsName = objetsModel.GetObjetsNamesByType(type);

            if (objetsName != null)
                return objetsName;
            else
                return null;
        }
        public static Dictionary<string, string> GetObjetInformationsByName(string name)
        {
            Console.WriteLine("########### Méthode GetObjetInformationsByName ###########");
            NewObjetsModel newObjetsModel = new NewObjetsModel();

            Dictionary<string, string> objet = new Dictionary<string, string>
            {
                { "Nom", name },
                { "Type", newObjetsModel.GetObjetPoidsByName(name) },
                { "Consommable", newObjetsModel.GetObjetConsommableByName(name) },
                { "Effet", newObjetsModel.GetObjetEffectByName(name) },
                { "Poids", newObjetsModel.GetObjetPoidsByName(name) },
                { "Valeur", newObjetsModel.GetObjetValeurByName(name) }
            };

            return objet;
        }
        public static string GetObjetWeightByName(string name)
        {
            Console.WriteLine("########### Méthode GetObjetWeightByName ###########");
            NewObjetsModel newObjetsModel = new NewObjetsModel();

            return newObjetsModel.GetObjetPoidsByName(name);
        }
    }
}
