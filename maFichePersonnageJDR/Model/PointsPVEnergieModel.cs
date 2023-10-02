using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class PointsPVEnergieModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idPointCaracteristiquesPersonnage;
        private int nbPointPersonnage;
        private int niveauPersonnage;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdPointCaracteristiquesPersonnage { get => idPointCaracteristiquesPersonnage; set => idPointCaracteristiquesPersonnage = value; }
        public int NbPointPersonnage { get => nbPointPersonnage; set => nbPointPersonnage = value; }
        public int NiveauPersonnage { get => niveauPersonnage; set => niveauPersonnage = value; }

        /// <summary>
        /// Retourne le nombre de points à répartir dans les PV et énergie du personnage
        /// par rapport à son niveau
        /// </summary>
        /// <param name="niveauPersonnage"></param>
        /// <returns></returns>
        public int GetPointsByNiveau(int niveauPersonnage)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT nb_point_personnage FROM POINTS_VIE_ENERGIE WHERE niveau_personnage = @niveau", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@niveau", niveauPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PointsPVEnergieModel pointsPVEnergie = new PointsPVEnergieModel();

                        return pointsPVEnergie.NbPointPersonnage = reader.GetInt32(0);
                    }
                }

                return 12;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
