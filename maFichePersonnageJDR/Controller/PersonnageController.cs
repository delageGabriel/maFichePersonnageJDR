using maFichePersonnageJDR.Formulaires;
using maFichePersonnageJDR.Model;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Controller
{
    class PersonnageController
    {
        public static void SaveInformationsPersonnage(string prenomPersonnage, string nomPersonnage, string racePersonnage, int niveauPersonnage,
            string sexePersonnage, int experiencePersonnage, string languesPersonnage, string avatarPersonnage, string histoirePersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode SaveInformationsPersonnage — Personnage créé : Prénom : {0} ###########", prenomPersonnage));

        }
    }
}
