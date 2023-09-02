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
        private string languesPersonnages;
        private string avatarPersonnage;
        private string histoirePersonnage;

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
        public string LanguesPersonnages { get => languesPersonnages; set => languesPersonnages = value; }
        public string AvatarPersonnage { get => avatarPersonnage; set => avatarPersonnage = value; }
        public string HistoirePersonnage { get => histoirePersonnage; set => histoirePersonnage = value; }

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
            string sexePersonnage, int experiencePersonnage, string languesPersonnage, string avatarPersonnage, string histoirePersonnage)
        {
            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("INSERT INTO PERSONNAGE (prenom_personnage, nom_personnage, race_personnage, niveau_personnage," +
                    "sexe_personnage, experience_personnage, langues_personnage, avatar_personnage, histoire_personnage)" +
                    "VALUES (@prenomPersonnage," +
                    "@nomPersonnage," +
                    "@racePersonnage," +
                    "@niveauPersonnage," +
                    "@sexePersonnage," +
                    "@experiencePersonnage," +
                    "@languesPersonnage," +
                    "@avatarPersonnage," +
                    "@histoirePersonnage)", connection);

                command.Parameters.AddWithValue("@prenomPersonnage", prenomPersonnage);
                command.Parameters.AddWithValue("@nomPersonnage", nomPersonnage);
                command.Parameters.AddWithValue("@racePersonnage", racePersonnage);
                command.Parameters.AddWithValue("@niveauPersonnage", niveauPersonnage);
                command.Parameters.AddWithValue("@sexePersonnage", sexePersonnage);
                command.Parameters.AddWithValue("@experiencePersonnage", experiencePersonnage);
                command.Parameters.AddWithValue("@languesPersonnage", languesPersonnage);
                command.Parameters.AddWithValue("@avatarPersonnage", avatarPersonnage);
                command.Parameters.AddWithValue("@histoirePersonnage", histoirePersonnage);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
