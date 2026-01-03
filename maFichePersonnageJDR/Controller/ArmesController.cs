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
    }
}
