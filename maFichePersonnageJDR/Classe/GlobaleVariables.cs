using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using maFichePersonnageJDR.View;

namespace maFichePersonnageJDR.Classe
{
    public class GlobaleVariables
    {
        /// <summary>
        /// Champs
        /// </summary>
        private static int idPersonnage = 0;
        private static bool isEdit = false;
        private static bool isClosedProgrammatically = false;
        private static string poidsPorteurChargeLibre = "0";
        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public static int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public static bool IsEdit { get => isEdit; set => isEdit = value; }
        public static bool IsClosedProgrammatically { get => isClosedProgrammatically; set => isClosedProgrammatically = value; }
        public static string PoidsPorteurChargeLibre { get => poidsPorteurChargeLibre; set => poidsPorteurChargeLibre = value; }
    }
}
