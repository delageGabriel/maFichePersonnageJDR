using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class PointsCaracteristiquesModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idPointsCaracteristiques;
        private int nbPointsCaracteristiques;
        private int niveauPersonnage;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdPointsCaracteristiques { get => idPointsCaracteristiques; set => idPointsCaracteristiques = value; }
        public int NbPointsCaracteristiques { get => nbPointsCaracteristiques; set => nbPointsCaracteristiques = value; }
        public int NiveauPersonnage { get => niveauPersonnage; set => niveauPersonnage = value; }

        /// <summary>
        /// Méthode qui permet de savoir combien de points de caractéristiques le personnage a à répartir
        /// par rapport à son niveau
        /// </summary>
        /// <param name="niveauPersonnage"></param>
        /// <returns></returns>
        public int GetPointsCaracteristiquesByNiveau(int niveauPersonnage)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand("SELECT nb_points_caracteristiques FROM POINTS_CARACTERISTIQUES WHERE niveau_personnage = @niveau",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@niveau", niveauPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }

                return 135;
            }
            catch(SQLiteException ex)
            {
                throw ex;
            }
        }
    }
}
