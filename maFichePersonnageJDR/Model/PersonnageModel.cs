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
        /// Retourne un personnage par son ID
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public PersonnageModel GetPersonnage(int idPersonnage)
        {
            #region Initialisation des variables
            PersonnageModel personnageToReturn = new PersonnageModel();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM PERSONNAGE WHERE id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PersonnageModel personnageModel = new PersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        personnageModel.IdPersonnage = reader.GetInt32(0);
                        personnageModel.PrenomPersonnage = reader.GetString(1);
                        personnageModel.NomPersonnage = reader.GetString(2);
                        personnageModel.RacePersonnage = reader.GetString(3);
                        personnageModel.NiveauPersonnage = reader.GetInt32(4);
                        personnageModel.SexePersonnage = reader.GetString(5);
                        personnageModel.ExperiencePersonnage = reader.GetInt32(6);
                        personnageModel.CourbeProgressionPersonnage = reader.GetString(7);
                        personnageModel.LanguesPersonnages = reader.GetString(8);
                        personnageModel.AvatarPersonnage = reader.GetString(9);
                        personnageModel.HistoirePersonnage = reader.GetString(10);
                        personnageModel.ChargePorteePersonnage = reader.GetDecimal(11);
                        personnageModel.ChargeTotalePersonnage = reader.GetDecimal(12);

                        personnageToReturn = personnageModel;
                    }
                }

                return personnageToReturn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

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
    }
}
