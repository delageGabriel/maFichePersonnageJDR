using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class AttributsPersonnageModel
    {
        /// <summary>
        /// champs
        /// </summary>
        private int idAttributsPersonnage;
        private int idAttribut;
        private int idPersonnage;
        private string specifications;

        /// <summary>
        /// accesseurs et mutateurs
        /// </summary>
        public int IdAttributsPersonnage { get => idAttributsPersonnage; set => idAttributsPersonnage = value; }
        public int IdAttribut { get => idAttribut; set => idAttribut = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public string Specifications { get => specifications; set => specifications = value; }
        /// <summary>
        /// Ajouter un nouvel attribut au personnage
        /// </summary>
        /// <param name="idAttribut">l'id de l'attribut à ajouter</param>
        /// <param name="idPersonnage">l'id du personnage à qui on ajoute l'attribut</param>
        public void AddAttributToPersonnage(int idAttribut, int idPersonnage, string specifications)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("INSERT INTO ATTRIBUTS_PERSONNAGE (id_attribut, id_personnage, specifications) " +
                    "VALUES (@idAttribut, @idPersonnage, @specifications)",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@idAttribut", idAttribut);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);
                command.Parameters.AddWithValue("@specifications", specifications);

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
        public List<string> GetListeNomAttributsPersonnage(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listeNomAttributsPersonnage = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT nom_attribut FROM ATTRIBUTS " +
                    "INNER JOIN ATTRIBUTS_PERSONNAGE ON ATTRIBUTS.id_attribut = ATTRIBUTS_PERSONNAGE.id_attribut " +
                    "WHERE ATTRIBUTS_PERSONNAGE.id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AttributsPersonnageModel attributsPersonnageModel = new AttributsPersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["nom_attribut"].ToString();
                        listeNomAttributsPersonnage.Add(value);
                    }
                }

                return listeNomAttributsPersonnage;
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
        public List<string> GetListeDescriptionAttributsPersonnage(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listeDescriptionAttributsPersonnage = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT description_attribut FROM ATTRIBUTS " +
                    "INNER JOIN ATTRIBUTS_PERSONNAGE ON ATTRIBUTS.id_attribut = ATTRIBUTS_PERSONNAGE.id_attribut " +
                    "WHERE ATTRIBUTS_PERSONNAGE.id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AttributsPersonnageModel attributsPersonnageModel = new AttributsPersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["description_attribut"].ToString();
                        listeDescriptionAttributsPersonnage.Add(value);
                    }
                }

                return listeDescriptionAttributsPersonnage;
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
        public List<string> GetListeTypeAttributsPersonnage(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listeTypeAttributsPersonnage = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT type_attribut FROM ATTRIBUTS " +
                    "INNER JOIN ATTRIBUTS_PERSONNAGE ON ATTRIBUTS.id_attribut = ATTRIBUTS_PERSONNAGE.id_attribut " +
                    "WHERE ATTRIBUTS_PERSONNAGE.id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AttributsPersonnageModel attributsPersonnageModel = new AttributsPersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["type_attribut"].ToString();
                        listeTypeAttributsPersonnage.Add(value);
                    }
                }

                return listeTypeAttributsPersonnage;
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
        public List<string> GetListSpecificationsAttributsPersonnage(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listeTypeAttributsPersonnage = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT specifications " +
                    "FROM ATTRIBUTS_PERSONNAGE " +
                    "WHERE ATTRIBUTS_PERSONNAGE.id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AttributsPersonnageModel attributsPersonnageModel = new AttributsPersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["specifications"].ToString();
                        listeTypeAttributsPersonnage.Add(value);
                    }
                }

                return listeTypeAttributsPersonnage;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetPourcentagePorteurChargerLourde(int idPersonnage)
        {
            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT specifications " +
                    "FROM ATTRIBUTS_PERSONNAGE " +
                    "WHERE ATTRIBUTS_PERSONNAGE.id_personnage = @idPersonnage " +
                    "AND id_attribut = 18", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }

                return null;
            }
            catch (SQLiteException e)
            {
                throw e;
            }
        }

        public bool CheckIfPersonnageHaveAttribut(int idPersonnage, int idAttribut)
        {
            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT COUNT(id_attribut) " +
                    "FROM ATTRIBUTS_PERSONNAGE " +
                    "WHERE ATTRIBUTS_PERSONNAGE.id_personnage = @idPersonnage AND ATTRIBUTS_PERSONNAGE.id_attribut = @idAttribut", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);
                command.Parameters.AddWithValue("@idAttribut", idAttribut);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0) > 0;
                    }
                }

                return false;
            }
            catch (SQLiteException e)
            {
                throw e;
            }
        }
    }
}
