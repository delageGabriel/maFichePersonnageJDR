using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Classes
{
    class Armes
    {
        private string nom;
        private int poids;
        private int qte;
        private string type;

        public Armes(string nom, int poids, int qte, string type)
        {
            this.nom = nom;
            this.poids = poids;
            this.qte = qte;
            this.type = type;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Poids { get => poids; set => poids = value; }
        public int Qte { get => qte; set => qte = value; }
        public string Type { get => type; set => type = value; }
    }
}
