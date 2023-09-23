using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class InventaireObjetsPersonnagesModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idInventaireObjetsPersonnages;
        private int idObjets;
        private int idPersonnage;
        private int quantite;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdInventaireObjetsPersonnages { get => idInventaireObjetsPersonnages; set => idInventaireObjetsPersonnages = value; }
        public int IdObjets { get => idObjets; set => idObjets = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int Quantite { get => quantite; set => quantite = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idArmure"></param>
        /// <param name="idPersonnage"></param>
        /// <param name="quantite"></param>
        public void SaveInventaireObjetsPersonnage(int idObjets, int idPersonnage, int quantite)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO INVENTAIRE_OBJETS_PERSONNAGES (id_objets, id_personnage, quantite) " +
                    "VALUES ({0}, {1}, {2})", idObjets, idPersonnage, quantite), DatabaseConnection.Instance.GetConnection());

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
        public List<string> GetListNomObjets(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listNomObjets = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT nom_objet " +
                    "FROM OBJETS " +
                    "INNER JOIN INVENTAIRE_OBJETS_PERSONNAGES ON OBJETS.id_objets = INVENTAIRE_OBJETS_PERSONNAGES.id_objets " +
                    "WHERE INVENTAIRE_OBJETS_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["nom_objet"].ToString();
                        listNomObjets.Add(value);
                    }
                }

                return listNomObjets;
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
        public List<double> GetListPoidsObjets(int idPersonnage)
        {
            #region Initialisation des variables
            List<double> listPoidsObjets = new List<double>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT OBJETS.poids_objet * INVENTAIRE_OBJETS_PERSONNAGES.quantite AS resultat FROM OBJETS INNER JOIN INVENTAIRE_OBJETS_PERSONNAGES ON OBJETS.id_objets = INVENTAIRE_OBJETS_PERSONNAGES.id_objets WHERE INVENTAIRE_OBJETS_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        double value = Convert.ToDouble(reader["resultat"]);
                        listPoidsObjets.Add(value);
                    }
                }

                return listPoidsObjets;
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
        public List<string> GetListValeurObjets(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listValeurObjets = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT valeur_objet " +
                    "FROM OBJETS " +
                    "INNER JOIN INVENTAIRE_OBJETS_PERSONNAGES ON OBJETS.id_objets = INVENTAIRE_OBJETS_PERSONNAGES.id_objets " +
                    "WHERE INVENTAIRE_OBJETS_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["valeur_objet"].ToString();
                        listValeurObjets.Add(value);
                    }
                }

                return listValeurObjets;
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
        public List<string> GetListTypeObjets(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listTypeObjets = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT type_objet " +
                    "FROM OBJETS " +
                    "INNER JOIN INVENTAIRE_OBJETS_PERSONNAGES ON OBJETS.id_objets = INVENTAIRE_OBJETS_PERSONNAGES.id_objets " +
                    "WHERE INVENTAIRE_OBJETS_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["type_objet"].ToString();
                        listTypeObjets.Add(value);
                    }
                }

                return listTypeObjets;
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
        public List<string> GetListConsommableObjets(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listConsommableObjets = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT consommable_objet " +
                    "FROM OBJETS " +
                    "INNER JOIN INVENTAIRE_OBJETS_PERSONNAGES ON OBJETS.id_objets = INVENTAIRE_OBJETS_PERSONNAGES.id_objets " +
                    "WHERE INVENTAIRE_OBJETS_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["consommable_objet"].ToString();
                        listConsommableObjets.Add(value);
                    }
                }

                return listConsommableObjets;
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
        public List<string> GetListSpecialObjets(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listSpecialObjets = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT special_objet " +
                    "FROM OBJETS " +
                    "INNER JOIN INVENTAIRE_OBJETS_PERSONNAGES ON OBJETS.id_objets = INVENTAIRE_OBJETS_PERSONNAGES.id_objets " +
                    "WHERE INVENTAIRE_OBJETS_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["special_objet"].ToString();
                        listSpecialObjets.Add(value);
                    }
                }

                return listSpecialObjets;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
