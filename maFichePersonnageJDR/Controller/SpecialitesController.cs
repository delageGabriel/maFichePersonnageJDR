using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using maFichePersonnageJDR.Formulaires;
using maFichePersonnageJDR.Model;
using maFichePersonnageJDR.View.Formulaires;

namespace maFichePersonnageJDR.Controller
{
    class SpecialitesController
    {
        public static Dictionary<int, string> GetSpecialitesByType(string typeSpecialites)
        {
            Console.WriteLine(string.Format("########### Méthode GetSpecialitesByType — Type de spécialités : {0} ###########", typeSpecialites));

            SpecialitesModel specialitesModel = new SpecialitesModel();

            try
            {
                Dictionary<int, string> dictionarySpecialites = specialitesModel.GetNameSpecialitesModels(typeSpecialites);

                if (specialitesModel != null)
                {
                    return dictionarySpecialites;
                }
                else
                {
                    Console.WriteLine("Dictionnaire vide !");
                    return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
