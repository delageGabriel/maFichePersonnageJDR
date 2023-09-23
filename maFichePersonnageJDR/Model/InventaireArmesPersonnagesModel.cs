using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class InventaireArmesPersonnagesModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idArmesPersonnages;
        private int idArme;
        private int idPersonnage;
        private int quantite;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdArmesPersonnages { get => idArmesPersonnages; set => idArmesPersonnages = value; }
        public int IdArme { get => idArme; set => idArme = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int Quantite { get => quantite; set => quantite = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idArme"></param>
        /// <param name="idPersonnage"></param>
        /// <param name="quantite"></param>
        public void SaveInventaireArmesPersonnage(int idArme, int idPersonnage, int quantite)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO INVENTAIRE_ARMES_PERSONNAGES (id_arme, id_personnage, quantite) " +
                    "VALUES ({0}, {1}, {2})", idArme, idPersonnage, quantite), DatabaseConnection.Instance.GetConnection());

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
        public List<string> GetListNomArmes(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listNomArmes = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT nom_arme " +
                    "FROM ARMES " +
                    "INNER JOIN INVENTAIRE_ARMES_PERSONNAGES ON ARMES.id_armes = INVENTAIRE_ARMES_PERSONNAGES.id_arme " +
                    "WHERE INVENTAIRE_ARMES_PERSONNAGES.id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["nom_arme"].ToString();
                        listNomArmes.Add(value);
                    }
                }

                return listNomArmes;
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
        public List<string> GetListTypeArmes(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listTypeArmes = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT type_arme " +
                    "FROM ARMES " +
                    "INNER JOIN INVENTAIRE_ARMES_PERSONNAGES ON ARMES.id_armes = INVENTAIRE_ARMES_PERSONNAGES.id_arme " +
                    "WHERE INVENTAIRE_ARMES_PERSONNAGES.id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["type_arme"].ToString();
                        listTypeArmes.Add(value);
                    }
                }

                return listTypeArmes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public List<double> GetListPoidsArmes(int idPersonnage)
        {
            #region Initialisation des variables
            List<double> listPoidsArmes = new List<double>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT ARMES.poids_arme * INVENTAIRE_ARMES_PERSONNAGES.quantite AS resultat FROM ARMES INNER JOIN INVENTAIRE_ARMES_PERSONNAGES ON ARMES.id_armes = INVENTAIRE_ARMES_PERSONNAGES.id_arme WHERE INVENTAIRE_ARMES_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        double value = Convert.ToDouble(reader["resultat"]);
                        listPoidsArmes.Add(value);
                    }
                }

                return listPoidsArmes;
            }
            catch (SQLiteException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne un personnage par son ID
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public List<string> GetListAllongeArmes(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listAllongeArmes = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT allonge_arme " +
                    "FROM ARMES " +
                    "INNER JOIN INVENTAIRE_ARMES_PERSONNAGES ON ARMES.id_armes = INVENTAIRE_ARMES_PERSONNAGES.id_arme " +
                    "WHERE INVENTAIRE_ARMES_PERSONNAGES.id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["allonge_arme"].ToString();
                        listAllongeArmes.Add(value);
                    }
                }

                return listAllongeArmes;
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
        public List<string> GetListMainsArmes(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listMainsArmes = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT main_arme " +
                    "FROM ARMES " +
                    "INNER JOIN INVENTAIRE_ARMES_PERSONNAGES ON ARMES.id_armes = INVENTAIRE_ARMES_PERSONNAGES.id_arme " +
                    "WHERE INVENTAIRE_ARMES_PERSONNAGES.id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["main_arme"].ToString();
                        listMainsArmes.Add(value);
                    }
                }

                return listMainsArmes;
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
        public List<string> GetListTypeDegatsArmes(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listTypeDegatsArmes = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT type_degats_arme " +
                    "FROM ARMES " +
                    "INNER JOIN INVENTAIRE_ARMES_PERSONNAGES ON ARMES.id_armes = INVENTAIRE_ARMES_PERSONNAGES.id_arme " +
                    "WHERE INVENTAIRE_ARMES_PERSONNAGES.id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["type_degats_arme"].ToString();
                        listTypeDegatsArmes.Add(value);
                    }
                }

                return listTypeDegatsArmes;
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
        public List<string> GetListDegatsArmes(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listDegatsArmes = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT degats_arme " +
                    "FROM ARMES " +
                    "INNER JOIN INVENTAIRE_ARMES_PERSONNAGES ON ARMES.id_armes = INVENTAIRE_ARMES_PERSONNAGES.id_arme " +
                    "WHERE INVENTAIRE_ARMES_PERSONNAGES.id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["degats_arme"].ToString();
                        listDegatsArmes.Add(value);
                    }
                }

                return listDegatsArmes;
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
        public List<string> GetListValeurArmes(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listValeurArmes = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT valeur_arme " +
                    "FROM ARMES " +
                    "INNER JOIN INVENTAIRE_ARMES_PERSONNAGES ON ARMES.id_armes = INVENTAIRE_ARMES_PERSONNAGES.id_arme " +
                    "WHERE INVENTAIRE_ARMES_PERSONNAGES.id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["valeur_arme"].ToString();
                        listValeurArmes.Add(value);
                    }
                }

                return listValeurArmes;
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
        public List<string> GetListDescriptionArmes(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listDescriptionArmes = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT description_arme " +
                    "FROM ARMES " +
                    "INNER JOIN INVENTAIRE_ARMES_PERSONNAGES ON ARMES.id_armes = INVENTAIRE_ARMES_PERSONNAGES.id_arme " +
                    "WHERE INVENTAIRE_ARMES_PERSONNAGES.id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["description_arme"].ToString();
                        listDescriptionArmes.Add(value);
                    }
                }

                return listDescriptionArmes;
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
        public List<string> GetListSpecialArmes(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listSpecialArmes = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT special_arme " +
                    "FROM ARMES " +
                    "INNER JOIN INVENTAIRE_ARMES_PERSONNAGES ON ARMES.id_armes = INVENTAIRE_ARMES_PERSONNAGES.id_arme " +
                    "WHERE INVENTAIRE_ARMES_PERSONNAGES.id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["special_arme"].ToString();
                        listSpecialArmes.Add(value);
                    }
                }

                return listSpecialArmes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
