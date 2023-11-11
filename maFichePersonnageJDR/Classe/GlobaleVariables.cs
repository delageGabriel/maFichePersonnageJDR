using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Classe
{
    static class GlobaleVariables
    {
        private static int idPersonnage = 0;
        private static bool isEdit = false;

        public static int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public static bool IsEdit { get => isEdit; set => isEdit = value; }
    }
}
