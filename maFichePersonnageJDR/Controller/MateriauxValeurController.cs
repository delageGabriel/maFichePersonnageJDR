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
    class MateriauxValeurController
    {
        public static string GetValueMateriauByNameAndQuality(int qualite, string nomMateriau)
        {
            Console.WriteLine(string.Format("########### CLASSE : MateriauxValeurController ; Méthode GetMateriauxEffectsByNameAndQuality ###########"));
            MateriauxValeurModel materiauxValeurModel = new MateriauxValeurModel();

            string materiauxValeur = materiauxValeurModel.GetValueMateriauByNameAndQuality(qualite, nomMateriau);

            if (materiauxValeur != null)
                return materiauxValeur;
            else
            {
                Console.WriteLine("Valeur Vide !");
                return null;
            }
        }
    }
}
