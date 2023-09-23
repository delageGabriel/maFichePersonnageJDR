using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class PointsCaracteristiquesPersonnageModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idPointsCaracteristiquesPersonnage;
        private int idPersonnage;
        private int nombrePhysique;
        private int nombreMental;
        private int nombreSocial;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdPointsCaracteristiquesPersonnage { get => idPointsCaracteristiquesPersonnage; set => idPointsCaracteristiquesPersonnage = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int NombrePhysique { get => nombrePhysique; set => nombrePhysique = value; }
        public int NombreMental { get => nombreMental; set => nombreMental = value; }
        public int NombreSocial { get => nombreSocial; set => nombreSocial = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <param name="nombrePhysique"></param>
        /// <param name="nombreMental"></param>
        /// <param name="nombreSocial"></param>
        public void SaveCaracteristiquesPersonnage(int idPersonnage, int nombrePhysique, int nombreMental, int nombreSocial)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO POINTS_CARACTERISTIQUES_PERSONNAGE " +
                    "(id_personnage, nombre_physique, nombre_mental, nombre_social) " +
                    "VALUES ({0}, {1}, {2}, {3})", idPersonnage, nombrePhysique, nombreMental, nombreSocial), DatabaseConnection.Instance.GetConnection());

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public PointsCaracteristiquesPersonnageModel GetBaseCaracteristiques(int idPersonnage)
        {
            #region Initialisation des variables
            PointsCaracteristiquesPersonnageModel physiqueToReturn = new PointsCaracteristiquesPersonnageModel();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM POINTS_CARACTERISTIQUES_PERSONNAGE WHERE id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PointsCaracteristiquesPersonnageModel physiquePersonnageModel = new PointsCaracteristiquesPersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        physiquePersonnageModel.IdPointsCaracteristiquesPersonnage = reader.GetInt32(0);
                        physiquePersonnageModel.IdPersonnage = reader.GetInt32(1);
                        physiquePersonnageModel.NombrePhysique = reader.GetInt32(2);
                        physiquePersonnageModel.NombreMental = reader.GetInt32(3);
                        physiquePersonnageModel.NombreSocial = reader.GetInt32(4);

                        physiqueToReturn = physiquePersonnageModel;
                    }
                }

                return physiqueToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
