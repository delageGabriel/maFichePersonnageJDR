using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class PersonnageModel
    {
        /// <summary>
        /// Attributs
        /// </summary>
        private int idPersonnage;
        private string prenomPersonnage;
        private string nomPersonnage;
        private string racePersonnage;
        private int niveauPersonnage;
        private string sexePersonnage;
        private int experiencePersonnage;
        private string courbeProgressionPersonnage;
        private int niveauSuivantPersonnage;
        private string languesPersonnages;
        private string avatarPersonnage;
        private string histoirePersonnage;
        private decimal chargePorteePersonnage;
        private decimal chargeTotalePersonnage;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public string PrenomPersonnage { get => prenomPersonnage; set => prenomPersonnage = value; }
        public string NomPersonnage { get => nomPersonnage; set => nomPersonnage = value; }
        public string RacePersonnage { get => racePersonnage; set => racePersonnage = value; }
        public int NiveauPersonnage { get => niveauPersonnage; set => niveauPersonnage = value; }
        public string SexePersonnage { get => sexePersonnage; set => sexePersonnage = value; }
        public int ExperiencePersonnage { get => experiencePersonnage; set => experiencePersonnage = value; }
        public string CourbeProgressionPersonnage { get => courbeProgressionPersonnage; set => courbeProgressionPersonnage = value; }
        public int NiveauSuivantPersonnage { get => niveauSuivantPersonnage; set => niveauSuivantPersonnage = value; }
        public string LanguesPersonnages { get => languesPersonnages; set => languesPersonnages = value; }
        public string AvatarPersonnage { get => avatarPersonnage; set => avatarPersonnage = value; }
        public string HistoirePersonnage { get => histoirePersonnage; set => histoirePersonnage = value; }
        public decimal ChargePorteePersonnage { get => chargePorteePersonnage; set => chargePorteePersonnage = value; }
        public decimal ChargeTotalePersonnage { get => chargeTotalePersonnage; set => chargeTotalePersonnage = value; }

        /// <summary>
        /// Méthode qui permet de sauvegarder en base les informations d'un personnage
        /// </summary>
        /// <param name="prenomPersonnage"></param>
        /// <param name="nomPersonnage"></param>
        /// <param name="racePersonnage"></param>
        /// <param name="niveauPersonnage"></param>
        /// <param name="sexePersonnage"></param>
        /// <param name="experiencePersonnage"></param>
        /// <param name="languesPersonnage"></param>
        /// <param name="avatarPersonnage"></param>
        /// <param name="histoirePersonnage"></param>
        public void SaveInformationsPersonnage(string prenomPersonnage, string nomPersonnage, string racePersonnage, int niveauPersonnage,
            string sexePersonnage, int experiencePersonnage, string courbeExperiencePersonnage, int niveauSuivantPersonnage,
            string languesPersonnage, string avatarPersonnage, string histoirePersonnage)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("INSERT INTO PERSONNAGE (prenom_personnage, nom_personnage, race_personnage, " +
                    "niveau_personnage, sexe_personnage, experience_personnage, courbe_progression_personnage, niveau_suivant_personnage, langues_personnage, " +
                    "avatar_personnage, histoire_personnage, charge_portee_personnage, charge_totale_personnage) " +
                    "VALUES (@prenomPersonnage, @nomPersonnage, @racePersonnage, @niveauPersonnage, @sexePersonnage, @experiencePersonnage, @courbeExperiencePersonnage," +
                    "@niveauSuivantPersonnage, @languesPersonnage, @avatarPersonnage, @histoirePersonnage, 0, 0)",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@prenomPersonnage", prenomPersonnage);
                command.Parameters.AddWithValue("@nomPersonnage", nomPersonnage);
                command.Parameters.AddWithValue("@racePersonnage", racePersonnage);
                command.Parameters.AddWithValue("@niveauPersonnage", niveauPersonnage);
                command.Parameters.AddWithValue("@sexePersonnage", sexePersonnage);
                command.Parameters.AddWithValue("@experiencePersonnage", experiencePersonnage);
                command.Parameters.AddWithValue("@courbeExperiencePersonnage", courbeExperiencePersonnage);
                command.Parameters.AddWithValue("@niveauSuivantPersonnage", niveauSuivantPersonnage);
                command.Parameters.AddWithValue("@languesPersonnage", languesPersonnage);
                command.Parameters.AddWithValue("@avatarPersonnage", avatarPersonnage);
                command.Parameters.AddWithValue("@histoirePersonnage", histoirePersonnage);

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                // Gérez ici les exceptions liées à SQLite
                // Affichez ou enregistrez le message d'erreur pour le débogage
                Console.WriteLine("Erreur SQLite : " + ex.Message);
                throw; // Vous pouvez choisir de relancer l'exception ou de la gérer ici selon vos besoins
            }
        }

        public int GetIdByNameAndSurname(string nomPersonnage, string prenomPersonnage)
        {
            #region Initialisation des variables
            int idDuPersonnage = 0;
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT id_personnage FROM PERSONNAGE WHERE nom_personnage = @nomPersonnage AND " +
                    "prenom_personnage = @prenomPersonnage", connection);
                command.Parameters.AddWithValue("@prenomPersonnage", prenomPersonnage);
                command.Parameters.AddWithValue("@nomPersonnage", nomPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PersonnageModel personnageModel = new PersonnageModel();

                        personnageModel.IdPersonnage = reader.GetInt32(0);

                        idDuPersonnage = personnageModel.IdPersonnage;
                    }
                }

                return idDuPersonnage;
            }
            catch (SQLiteException ex)
            {
                // Gérez ici les exceptions liées à SQLite
                // Affichez ou enregistrez le message d'erreur pour le débogage
                Console.WriteLine("Erreur SQLite : " + ex.Message);
                throw; // Vous pouvez choisir de relancer l'exception ou de la gérer ici selon vos besoins
            }
        }

        /// <summary>
        /// On vérifie en base si le personnage existe déjà
        /// </summary>
        /// <param name="nomPersonnage"></param>
        /// <param name="prenomPersonnage"></param>
        /// <returns></returns>
        public bool CheckIfPersonnageExist(string nomPersonnage, string prenomPersonnage)
        {
            #region Initialisation des variables
            bool personnageExiste = false;
            #endregion

            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT COUNT(*) FROM PERSONNAGE WHERE nom_personnage = @nomPersonnage " +
                    "AND prenom_personnage = @prenomPersonnage", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@prenomPersonnage", prenomPersonnage);
                command.Parameters.AddWithValue("@nomPersonnage", nomPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PersonnageModel personnageModel = new PersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        personnageExiste = reader.GetInt32(0) <= 0;
                    }
                }

                return personnageExiste;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Obtenir la valeur d'une colonne donnée en paramètre
        /// pour un personnage
        /// </summary>
        /// <param name="nomColonne"></param>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static object GetValueFieldPersonnage(string nomColonne, int idPersonnage)
        {
            int defautReturn = 0;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand($"SELECT {nomColonne} " +
                    "FROM PERSONNAGE " +
                    "WHERE id_personnage = @id_personnage; ", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine(command.CommandText);

                    while (reader.Read())
                    {
                        return reader.GetValue(0);
                    }
                }

                return defautReturn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Permet de mettre à jour un champ dans la table PERSONNAGE
        /// </summary>
        /// <param name="nomColonne"></param>
        /// <param name="idPersonnage"></param>
        /// <param name="newValue"></param>
        public static void SetValueFieldPersonnage(string nomColonne, int idPersonnage, object newValue)
        {
            try
            {
                if (!String.IsNullOrEmpty(nomColonne))
                {
                    // Commande
                    SQLiteCommand command = new SQLiteCommand("UPDATE PERSONNAGE " +
                        $"SET {nomColonne} = @newValue " +
                        $"WHERE id_personnage = @idPersonnage",
                        DatabaseConnection.Instance.GetConnection());

                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
        }

        public static void DeleteRowPersonnage(int idPersonnage)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("DELETE FROM PERSONNAGE WHERE id_personnage = @idPersonnage",
                    DatabaseConnection.Instance.GetConnection());

                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
        }

        public static void DeleteRowPersonnageByPrenomAndNom(string prenomPersonnage, string nomPersonnage)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("DELETE FROM PERSONNAGE WHERE prenom_personnage = @prenomPersonnage AND nom_personnage = @nomPersonnage",
                    DatabaseConnection.Instance.GetConnection());

                command.Parameters.AddWithValue("@prenomPersonnage", prenomPersonnage);
                command.Parameters.AddWithValue("@nomPersonnage", nomPersonnage);

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
        }

        public static List<object> GetListPersonnage()
        {
            List<object> ListPersonnage = new List<object>();

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand($"SELECT prenom_personnage, nom_personnage " +
                    "FROM PERSONNAGE", connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine(command.CommandText);

                    while (reader.Read())
                    {
                        string prenom = reader["prenom_personnage"].ToString();
                        string nom = reader["nom_personnage"].ToString();

                        ListPersonnage.Add(prenom + " " + nom);
                    }
                }

                return ListPersonnage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
