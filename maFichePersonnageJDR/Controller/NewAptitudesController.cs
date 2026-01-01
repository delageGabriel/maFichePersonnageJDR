using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Controller
{
    class NewAptitudesController
    {
        public static Dictionary<string, string> GetAptitudeInformationsByName(string name)
        {
            Console.WriteLine("########### Méthode GetAptitudeInformationsByName ###########");
            NewAptitudeModel aptModel = new NewAptitudeModel();

            Dictionary<string, string> aptitude = new Dictionary<string, string>
            {
                {"Nom", name},
                {"Domaine", aptModel.GetDomaineAptitudeByName(name) },
                {"Type",  aptModel.GetTypeAptitudeByName(name)},
                {"Portee",  aptModel.GetPorteeAptitudeByName(name)},
                {"Duree", aptModel.GetDureeAptitudeByName(name)},
                {"Limites", aptModel.GetLimitesUsagesAptitudeByName(name)},
                {"Sauvegarde", aptModel.GetJetSauvegardeAptitudeByName(name)},
                {"Effets",  aptModel.GetEffetsAptitudeByName(name)}
            };

            if (aptitude != null)
                return aptitude;
            else
                return null;
        }
    }
}
