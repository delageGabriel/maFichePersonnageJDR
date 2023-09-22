﻿using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class InventaireArmuresPersonnageModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idInventaireArmuresPersonnage;
        private int idArmures;
        private int idPersonnage;
        private int quantite;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdInventaireArmuresPersonnage { get => idInventaireArmuresPersonnage; set => idInventaireArmuresPersonnage = value; }
        public int IdArmures { get => idArmures; set => idArmures = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int Quantite { get => quantite; set => quantite = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idArmure"></param>
        /// <param name="idPersonnage"></param>
        /// <param name="quantite"></param>
        public void SaveInventaireArmuresPersonnage(int idArmure, int idPersonnage, int quantite)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO INVENTAIRE_ARMURES_PERSONNAGES (id_armure, id_personnage, quantite) " +
                    "VALUES ({0}, {1}, {2})", idArmure, idPersonnage, quantite), DatabaseConnection.Instance.GetConnection());

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
        public List<string> GetListNomArmures(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listNomArmures = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT nom_armure " +
                    "FROM ARMURES " +
                    "INNER JOIN INVENTAIRE_ARMURES_PERSONNAGES ON ARMURES.id_armure = INVENTAIRE_ARMURES_PERSONNAGES.id_armure " +
                    "WHERE INVENTAIRE_ARMURES_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmuresPersonnageModel inventaireArmuresPersonnages = new InventaireArmuresPersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["nom_armure"].ToString();
                        listNomArmures.Add(value);
                    }
                }

                return listNomArmures;
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
        public List<string> GetListTypeArmures(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listTypeArmures = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT type_armure " +
                    "FROM ARMURES " +
                    "INNER JOIN INVENTAIRE_ARMURES_PERSONNAGES ON ARMURES.id_armure = INVENTAIRE_ARMURES_PERSONNAGES.id_armure " +
                    "WHERE INVENTAIRE_ARMURES_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmuresPersonnageModel inventaireArmuresPersonnages = new InventaireArmuresPersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["type_armure"].ToString();
                        listTypeArmures.Add(value);
                    }
                }

                return listTypeArmures;
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
        public List<double> GetListPoidsArmures(int idPersonnage)
        {
            #region Initialisation des variables
            List<double> listPoidsArmures = new List<double>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT ARMURES.poids_armure * INVENTAIRE_ARMURES_PERSONNAGES.quantite AS resultat FROM ARMURES INNER JOIN INVENTAIRE_ARMURES_PERSONNAGES ON ARMURES.id_armure = INVENTAIRE_ARMURES_PERSONNAGES.id_armure WHERE INVENTAIRE_ARMURES_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        double value = Convert.ToDouble(reader["resultat"]);
                        listPoidsArmures.Add(value);
                    }
                }

                return listPoidsArmures;
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
        public List<string> GetListValeurArmures(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listValeurArmure = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT valeur_armure " +
                    "FROM ARMURES " +
                    "INNER JOIN INVENTAIRE_ARMURES_PERSONNAGES ON ARMURES.id_armure = INVENTAIRE_ARMURES_PERSONNAGES.id_armure " +
                    "WHERE INVENTAIRE_ARMURES_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmuresPersonnageModel inventaireArmuresPersonnages = new InventaireArmuresPersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["valeur_armure"].ToString();
                        listValeurArmure.Add(value);
                    }
                }

                return listValeurArmure;
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
        public List<string> GetListProtectionArmures(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listProtectionArmure = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT protection_armure " +
                    "FROM ARMURES " +
                    "INNER JOIN INVENTAIRE_ARMURES_PERSONNAGES ON ARMURES.id_armure = INVENTAIRE_ARMURES_PERSONNAGES.id_armure " +
                    "WHERE INVENTAIRE_ARMURES_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmuresPersonnageModel inventaireArmuresPersonnages = new InventaireArmuresPersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["protection_armure"].ToString();
                        listProtectionArmure.Add(value);
                    }
                }

                return listProtectionArmure;
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
        public List<string> GetListBonusArmures(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listBonusArmure = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT bonus_armure " +
                    "FROM ARMURES " +
                    "INNER JOIN INVENTAIRE_ARMURES_PERSONNAGES ON ARMURES.id_armure = INVENTAIRE_ARMURES_PERSONNAGES.id_armure " +
                    "WHERE INVENTAIRE_ARMURES_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmuresPersonnageModel inventaireArmuresPersonnages = new InventaireArmuresPersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["bonus_armure"].ToString();
                        listBonusArmure.Add(value);
                    }
                }

                return listBonusArmure;
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
        public List<string> GetListSpecialArmures(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listSpecialArmure = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT special_armure " +
                    "FROM ARMURES " +
                    "INNER JOIN INVENTAIRE_ARMURES_PERSONNAGES ON ARMURES.id_armure = INVENTAIRE_ARMURES_PERSONNAGES.id_armure " +
                    "WHERE INVENTAIRE_ARMURES_PERSONNAGES.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmuresPersonnageModel inventaireArmuresPersonnages = new InventaireArmuresPersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["special_armure"].ToString();
                        listSpecialArmure.Add(value);
                    }
                }

                return listSpecialArmure;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
