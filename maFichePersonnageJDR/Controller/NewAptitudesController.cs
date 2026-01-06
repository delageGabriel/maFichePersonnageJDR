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

        public static string GetAptitudeDomaineByName(string name)
        {
            Console.WriteLine("########### Méthode GetAptitudeDomaineByName ###########");
            NewAptitudeModel aptModel = new NewAptitudeModel();

            return aptModel.GetDomaineAptitudeByName(name);
        }
        public static string GetAptitudeTypeByName(string name)
        {
            Console.WriteLine("########### Méthode GetAptitudeTypeByName ###########");
            NewAptitudeModel aptModel = new NewAptitudeModel();

            return aptModel.GetTypeAptitudeByName(name);
        }
        public static string GetAptitudePorteeByName(string name)
        {
            Console.WriteLine("########### Méthode GetAptitudePorteeByName ###########");
            NewAptitudeModel aptModel = new NewAptitudeModel();

            return aptModel.GetPorteeAptitudeByName(name);
        }
        public static string GetAptitudeDureeByName(string name)
        {
            Console.WriteLine("########### Méthode GetAptitudeDureeByName ###########");
            NewAptitudeModel aptModel = new NewAptitudeModel();

            return aptModel.GetDureeAptitudeByName(name);
        }
        public static string GetLimitesUsagesAptitudeByName(string name)
        {
            Console.WriteLine("########### Méthode GetLimitesUsagesAptitudeByName ###########");
            NewAptitudeModel aptModel = new NewAptitudeModel();

            return aptModel.GetLimitesUsagesAptitudeByName(name);
        }
        public static string GetJetSauvegardeAptitudeByName(string name)
        {
            Console.WriteLine("########### Méthode GetJetSauvegardeAptitudeByName ###########");
            NewAptitudeModel aptModel = new NewAptitudeModel();

            return aptModel.GetJetSauvegardeAptitudeByName(name);
        }
        public static string GetEffetsAptitudeByName(string name)
        {
            Console.WriteLine("########### Méthode GetEffetsAptitudeByName ###########");
            NewAptitudeModel aptModel = new NewAptitudeModel();

            return aptModel.GetEffetsAptitudeByName(name);
        }
    }
}
