using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class CompetencePhysiquePersonnageModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idCompetencePhysique;
        private int idPersonnage;
        private int agilite;
        private int artisanat;
        private int crochetage;
        private int discretion;
        private int equilibre;
        private int equitation;
        private int escalade;
        private int escamotage;
        private int force;
        private int fouille;
        private int lutte;
        private int natation;
        private int reflexes;
        private int vigueur;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdCompetencePhysique { get => idCompetencePhysique; set => idCompetencePhysique = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int Agilite { get => agilite; set => agilite = value; }
        public int Artisanat { get => artisanat; set => artisanat = value; }
        public int Crochetage { get => crochetage; set => crochetage = value; }
        public int Discretion { get => discretion; set => discretion = value; }
        public int Equilibre { get => equilibre; set => equilibre = value; }
        public int Equitation { get => equitation; set => equitation = value; }
        public int Escalade { get => escalade; set => escalade = value; }
        public int Escamotage { get => escamotage; set => escamotage = value; }
        public int Force { get => force; set => force = value; }
        public int Fouille { get => fouille; set => fouille = value; }
        public int Lutte { get => lutte; set => lutte = value; }
        public int Natation { get => natation; set => natation = value; }
        public int Reflexes { get => reflexes; set => reflexes = value; }
        public int Vigueur { get => vigueur; set => vigueur = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <param name="agilite"></param>
        /// <param name="artisanat"></param>
        /// <param name="crochetage"></param>
        /// <param name="discretion"></param>
        /// <param name="equilibre"></param>
        /// <param name="escalade"></param>
        /// <param name="escamotage"></param>
        /// <param name="force"></param>
        /// <param name="natation"></param>
        /// <param name="reflexes"></param>
        /// <param name="vigueur"></param>
        public void SaveCompetencePhysiquePersonnage(int idPersonnage, int agilite, int artisanat, int crochetage, int discretion, int equilibre, int equitation, 
            int escalade, int escamotage, int force, int fouille, int lutte, int natation, int reflexes, int vigueur)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(
                    "INSERT INTO COMPETENCE_PHYSIQUE_PERSONNAGE (id_personnage, agilite, artisanat, crochetage, discretion, equilibre, equitation, " +
                    "escalade, escamotage, force, fouille, lutte, natation, reflexes, vigueur) " +
                    "VALUES (@idPersonnage, @agilite, @artisanat, @crochetage, @discretion, @equilibre, @equitation, @escalade, @escamotage, @force," +
                    "@fouille, @lutte, @natation, @reflexes, @vigueur)", 
                    DatabaseConnection.Instance.GetConnection());

                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);
                command.Parameters.AddWithValue("@agilite", agilite);
                command.Parameters.AddWithValue("@artisanat", artisanat);
                command.Parameters.AddWithValue("@crochetage", crochetage);
                command.Parameters.AddWithValue("@discretion", discretion);
                command.Parameters.AddWithValue("@equilibre", equilibre);
                command.Parameters.AddWithValue("@equitation", equitation);
                command.Parameters.AddWithValue("@escalade", escalade);
                command.Parameters.AddWithValue("@escamotage", escamotage);
                command.Parameters.AddWithValue("@force", force);
                command.Parameters.AddWithValue("@fouille", fouille);
                command.Parameters.AddWithValue("@lutte", lutte);
                command.Parameters.AddWithValue("@natation", natation);
                command.Parameters.AddWithValue("@reflexes", reflexes);
                command.Parameters.AddWithValue("@vigueur", vigueur);

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int GetForcePersonnage(int idPersonnage)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand("SELECT force " +
                    "FROM COMPETENCE_PHYSIQUE_PERSONNAGE " +
                    "WHERE id_personnage = @idPersonnage", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }

                return 0;
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Méthode qui permet de récupérer toutes les valeurs de chaque caractéristiques physique
        /// du personnage
        /// </summary>
        /// <param name="idPersonnage">id du personnage dont il faut récupérer les valeurs</param>
        /// <returns>CompetencePhysiquePersonnageModel</returns>
        public CompetencePhysiquePersonnageModel GetBasePhysiquePersonnage(int idPersonnage)
        {
            #region Initialisation des variables
            CompetencePhysiquePersonnageModel competencePhysiquePersonnage = new CompetencePhysiquePersonnageModel();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM COMPETENCE_PHYSIQUE_PERSONNAGE " +
                    "WHERE id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CompetencePhysiquePersonnageModel competencePhysique = new CompetencePhysiquePersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        competencePhysique.IdCompetencePhysique = reader.GetInt32(0);
                        competencePhysique.IdPersonnage = reader.GetInt32(1);
                        competencePhysique.Agilite = reader.GetInt32(2);
                        competencePhysique.Artisanat = reader.GetInt32(3);
                        competencePhysique.Crochetage = reader.GetInt32(4);
                        competencePhysique.Discretion = reader.GetInt32(5);
                        competencePhysique.Equilibre = reader.GetInt32(6);
                        competencePhysique.Escalade = reader.GetInt32(7);
                        competencePhysique.Escamotage = reader.GetInt32(8);
                        competencePhysique.Force = reader.GetInt32(9);
                        competencePhysique.Fouille = reader.GetInt32(10);
                        competencePhysique.Natation = reader.GetInt32(11);
                        competencePhysique.Reflexes = reader.GetInt32(12);
                        competencePhysique.Vigueur = reader.GetInt32(13);

                        competencePhysiquePersonnage = competencePhysique;
                    }
                }

                return competencePhysiquePersonnage;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static int GetValueCompetencePhysique(string nomCompetence, int idPersonnage)
        {
            int defautReturn = 0;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand($"SELECT {nomCompetence} " +
                    "FROM COMPETENCE_PHYSIQUE_PERSONNAGE " +
                    "WHERE id_personnage = @id_personnage; ", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);
                command.Parameters.AddWithValue("@nomCompetence", nomCompetence);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine(command.CommandText);

                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }

                return defautReturn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
