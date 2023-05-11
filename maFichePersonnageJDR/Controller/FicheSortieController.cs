using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Controller
{
    class FicheSortieController
    {
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
            catch(Exception e)
            {
                throw e;
            }
        }

        public static int CalculPVEnergiePersonnage(int nombreDeDé, int valeurRandom)
        {
            int valeurARetourner = 0;

            for(int i = 0; i < nombreDeDé; i++)
            {
                Random randomObject = new Random();

                valeurARetourner += randomObject.Next(valeurRandom);
            }

            return valeurARetourner;
        }
    }
}
