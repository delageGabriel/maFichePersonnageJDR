using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class ArmesModel
    {
        /// <summary>
        /// Attributs
        /// </summary>
        private int idArme;
        private string typeArme;
        private string nomArme;
        private double poidsArmes;
        private string allongeArmes;
        private string mainArmes;
        private string typeDegatsArmes;
        private string degatsArmes;
        private int valeurArme;
        private string descriptionArme;

        /// <summary>
        /// Accesseurs et Mutateurs
        /// </summary>
        public int IdArme { get => idArme; set => idArme = value; }
        public string TypeArme { get => typeArme; set => typeArme = value; }
        public string NomArme { get => nomArme; set => nomArme = value; }
        public double PoidsArmes { get => poidsArmes; set => poidsArmes = value; }
        public string AllongeArmes { get => allongeArmes; set => allongeArmes = value; }
        public string MainArmes { get => mainArmes; set => mainArmes = value; }
        public string TypeDegatsArmes { get => typeDegatsArmes; set => typeDegatsArmes = value; }
        public string DegatsArmes { get => degatsArmes; set => degatsArmes = value; }
        public int ValeurArme { get => valeurArme; set => valeurArme = value; }
        public string DescriptionArme { get => descriptionArme; set => descriptionArme = value; }

    }
}
