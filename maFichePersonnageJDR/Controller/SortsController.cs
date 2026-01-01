using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Controller
{
    class SortsController
    {
        public static Dictionary<string, string> GetSortInformationsByName(string name)
        {
            Console.WriteLine("########### Méthode GetAptitudeInformationsByName ###########");
            SortsModel sortsModel = new SortsModel();

            Dictionary<string, string> sort = new Dictionary<string, string>
            {
                { "Nom", name },
                { "Domaine", sortsModel.GetDomaineSortByName(name) },
                { "Type", sortsModel.GetTypeSortByName(name) },
                { "Portee", sortsModel.GetPorteeSortByName(name) },
                { "Duree", sortsModel.GetDureeSortByName(name) },
                { "Limites", sortsModel.GetLimitesUsageSortByName(name) },
                { "Sauvegarde", sortsModel.GetJetSauvegardeSortByName(name) },
                { "Incantations", sortsModel.GetTempsIncantationSortByName(name) },
                { "Composantes", sortsModel.GetComposantesSortByName(name) },
                { "Ingredients", sortsModel.GetIngredientsSortByName(name) },
                { "Intentions", sortsModel.GetIntentionsMagiquesSortByName(name) },
                { "Effets", sortsModel.GetEffetsSortByName(name) }
            };

            if (sort != null)
                return sort;
            else
                return null;
        }
    }
}
