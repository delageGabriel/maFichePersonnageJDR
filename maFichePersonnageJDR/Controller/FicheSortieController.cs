using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Controller
{
    class FicheSortieController
    {
        /// <summary>
        /// Méthode qui retourne la valeur random à calculer
        /// </summary>
        /// <param name="valeur">la vigueur ou l'esprit du personnage</param>
        /// <returns></returns>
        public static int GetPVEnergiePersonnage(int valeur)
        {
            try
            {
                int deSortie = 0;

                if (valeur <= 0)
                    deSortie = 4;
                else if (valeur <= 5)
                    deSortie = 6;
                else if (valeur <= 10)
                    deSortie = 8;
                else if (valeur <= 15)
                    deSortie = 10;

                return deSortie;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Méthode qui retourne le nombre pv calculé de manière aléatoire
        /// </summary>
        /// <param name="nombreDeDé">nombre de dés à jeter</param>
        /// <param name="valeurRandom">la valeur aléatoire à calculer</param>
        /// <returns></returns>
        public static int CalculPVEnergiePersonnage(int nombreDeDé, int valeurRandom)
        {
            try
            {
                int valeurARetourner = 0;

                for (int i = 0; i < nombreDeDé; i++)
                {
                    Random randomObject = new Random();

                    valeurARetourner += randomObject.Next(valeurRandom);
                }

                return valeurARetourner;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
