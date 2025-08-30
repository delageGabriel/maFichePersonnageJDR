using maFichePersonnageJDR.Classe;
using maFichePersonnageJDR.Formulaires;
using maFichePersonnageJDR.Model;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Controller
{
    class MateriauxPoidsController
    {
        public static string GetWeightByNameAndQuality(int qualite, string nomMateriau)
        {
            Console.WriteLine(string.Format("########### CLASSE : MateriauxPoidsController ; Méthode : GetWeightByNameAndQuality ###########"));
            MateriauPoidsModel materiauPoidsModel = new MateriauPoidsModel();

            string materiauPoids = materiauPoidsModel.GetWeightMateriauByNameAndQuality(qualite, nomMateriau);

            if (materiauPoids != null)
                return materiauPoids;
            else
            {
                Console.WriteLine("Valeur Vide !");
                return null;
            }
        }
    }
}
