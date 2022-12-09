using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Classe
{
    class GlobalesVariable
    {
        private const double pdsScrasamax = 0.55;

        private const double pdsEpeeCourte = 0.35;
        
        private const double pdsEpeeLongue = 1.5;

        private const double pdsGlaive = 0.6;

        private const double pdsLatte = 0.5;
        
        private const double pdsSabreCourbe = 0.45;
        public static double PdsScrasamax => pdsScrasamax;

        public static double PdsEpeeCourte => pdsEpeeCourte;

        public static double PdsEpeeLongue => pdsEpeeLongue;

        public static double PdsGlaive => pdsGlaive;

        public static double PdsLatte => pdsLatte;

        public static double PdsSabreCourbe => pdsSabreCourbe;
    }
}
