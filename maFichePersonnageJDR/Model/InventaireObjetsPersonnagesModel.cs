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

        /// <summary>
        /// Méthode qui permet de supprimer un objet de l'inventaire du personnage
        /// </summary>
        /// <param name="idObjet"></param>
        /// <param name="idPersonnage"></param>
        public void DeleteFromInventairePersonnage(int idObjet, int idPersonnage)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand(string.Format("DELETE FROM INVENTAIRE_OBJETS_PERSONNAGES WHERE id_objets = {0} AND id_personnage = {1}",
                    idObjet, idPersonnage), DatabaseConnection.Instance.GetConnection());

                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Met à jour la quantité d'un objet transporté par un personnage
        /// </summary>
        /// <param name="idObjet"></param>
        /// <param name="idPersonnage"></param>
        /// <param name="nouvelleQte"></param>
        public void UpdateQuantityItems(int idObjet, int idPersonnage, int nouvelleQte)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand("UPDATE INVENTAIRE_OBJETS_PERSONNAGES " +
                    "SET quantite = @nouvelleQuantite " +
                    "WHERE id_objets = @idObjet AND id_personnage = @idPersonnage", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@idObjet", idObjet);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);
                command.Parameters.AddWithValue("@nouvelleQuantite", nouvelleQte);

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Permet de retourner la liste des objets que le personnage porte dans son inventaire
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public List<string> GetObjetsNameQuantityValueInInventaire(int idPersonnage)
        {
            List<string> nomObjets = new List<string>();
            List<string> valeurObjets = new List<string>();
            List<string> quantiteObjets = new List<string>();
            List<string> listToReturn = new List<string>();

            try
            {
                SQLiteCommand command = new SQLiteCommand(string.Format("SELECT OBJETS.nom_objet, INVENTAIRE_OBJETS_PERSONNAGES.quantite, OBJETS.valeur_objet " +
                    "FROM OBJETS " +
                    "INNER JOIN INVENTAIRE_OBJETS_PERSONNAGES ON OBJETS.id_objets = INVENTAIRE_OBJETS_PERSONNAGES.id_objets " +
                    "WHERE INVENTAIRE_OBJETS_PERSONNAGES.id_personnage = @idPersonnage"), DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireObjetsPersonnagesModel inventaireObjetsPersonnages = new InventaireObjetsPersonnagesModel();

                        string name = reader["nom_objet"].ToString();
                        string quantite = reader["quantite"].ToString();
                        string valeur = reader["valeur_objet"].ToString();

                        nomObjets.Add(name);
                        quantiteObjets.Add(quantite);
                        valeurObjets.Add(valeur);
                    }
                }

                for (int i = 0; i < nomObjets.Count; i++)
                {
                    listToReturn.Add(nomObjets[i] + ", " + quantiteObjets[i] + ", " + valeurObjets[i]);
                }

                return listToReturn;
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retourne le poids total d'objets que le personnage a dans son inventaire
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public decimal GetPoidsTotalObjets(int idPersonnage)
        {
            decimal poidsTotal = 0;

            try
            {
                SQLiteCommand command = new SQLiteCommand(string.Format("SELECT SUM(OBJETS.poids_objet * INVENTAIRE_OBJETS_PERSONNAGES.quantite) AS poids_total " +
                    "FROM OBJETS " +
                    "INNER JOIN INVENTAIRE_OBJETS_PERSONNAGES ON OBJETS.id_objets = INVENTAIRE_OBJETS_PERSONNAGES.id_objets " +
                    "WHERE INVENTAIRE_OBJETS_PERSONNAGES.id_personnage = @idPersonnage"), DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using(SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        poidsTotal = Convert.ToDecimal(reader["poids_total"] is DBNull ? 0 : reader["poids_total"]);
                    }
                }

                return poidsTotal;
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
        }
    }
}
