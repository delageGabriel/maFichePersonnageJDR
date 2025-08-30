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
    class MateriauxEffetsController
    {
        public static Dictionary<int, List<string>> GetMateriauxEffectsByNameAndQuality(int qualite, string nomMateriau)
        {
            Console.WriteLine(string.Format("########### Méthode GetMateriauxEffectsByNameAndQuality ###########"));
            MateriauxEffetsModel materiauxEffetsModel = new MateriauxEffetsModel();

            Dictionary<int, List<string>> dictionnairesMateriauxEffets = materiauxEffetsModel.GetMateriauxEffetsByNameCodeValueAndQuality(qualite, nomMateriau);

            if (dictionnairesMateriauxEffets != null)
                return dictionnairesMateriauxEffets;
            else
            {
                Console.WriteLine("Dictionnaire Vide !");
                return null;
            }
        }
    }
}
