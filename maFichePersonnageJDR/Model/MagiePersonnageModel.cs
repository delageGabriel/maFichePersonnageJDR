using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class MagiePersonnageModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idMagiePersonnage;
        private int idMagie;
        private int idPersonnage;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdMagiePersonnage { get => idMagiePersonnage; set => idMagiePersonnage = value; }
        public int IdMagie { get => idMagie; set => idMagie = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }

        /// <summary>
        /// Méthode qui permet d'associer à un personnage une magie
        /// </summary>
        /// <param name="idMagie"></param>
        /// <param name="idPersonnage"></param>
        public void SaveMagiePersonnage(int idMagie, int idPersonnage)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO MAGIE_PERSONNAGE (id_magie, id_personnage) " +
                    "VALUES ({0}, {1})", idMagie, idPersonnage), DatabaseConnection.Instance.GetConnection());

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne un personnage par son ID
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public List<string> GetListNomMagie(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listNomMagie = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT nom_magie " +
                    "FROM MAGIE " +
                    "INNER JOIN MAGIE_PERSONNAGE ON MAGIE.id_magie = MAGIE_PERSONNAGE.id_magie " +
                    "WHERE MAGIE_PERSONNAGE.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["nom_magie"].ToString();
                        listNomMagie.Add(value);
                    }
                }

                return listNomMagie;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne un personnage par son ID
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public List<string> GetListTypeMagie(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listTypeMagie = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT type_magie " +
                    "FROM MAGIE " +
                    "INNER JOIN MAGIE_PERSONNAGE ON MAGIE.id_magie = MAGIE_PERSONNAGE.id_magie " +
                    "WHERE MAGIE_PERSONNAGE.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["type_magie"].ToString();
                        listTypeMagie.Add(value);
                    }
                }

                return listTypeMagie;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne un personnage par son ID
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public List<int> GetListCoutMagie(int idPersonnage)
        {
            #region Initialisation des variables
            List<int> listCoutMagie = new List<int>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT cout_magie " +
                    "FROM MAGIE " +
                    "INNER JOIN MAGIE_PERSONNAGE ON MAGIE.id_magie = MAGIE_PERSONNAGE.id_magie " +
                    "WHERE MAGIE_PERSONNAGE.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        int value = Convert.ToInt32(reader["cout_magie"]);
                        listCoutMagie.Add(value);
                    }
                }

                return listCoutMagie;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
