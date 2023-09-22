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
        private int escalade;
        private int escamotage;
        private int force;
        private int fouille;
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
        public int Escalade { get => escalade; set => escalade = value; }
        public int Escamotage { get => escamotage; set => escamotage = value; }
        public int Force { get => force; set => force = value; }
        public int Fouille { get => force; set => force = value; }
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
        public void SaveCompetencePhysiquePersonnage(int idPersonnage, int agilite, int artisanat, int crochetage, int discretion, int equilibre, int escalade, int escamotage,
            int force, int fouille, int natation, int reflexes, int vigueur)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO COMPETENCE_PHYSIQUE_PERSONNAGE (id_personnage, agilite, artisanat, " +
                    "crochetage, discretion, equilibre, escalade, escamotage, force, fouille, natation, reflexes, vigueur) " +
                    "VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12})", idPersonnage, agilite, artisanat, crochetage,
                    discretion, equilibre, escalade, escamotage, force, fouille, natation, reflexes, vigueur), DatabaseConnection.Instance.GetConnection());

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

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
                        competencePhysique.Agilite = reader.GetInt32(1);
                        competencePhysique.Artisanat = reader.GetInt32(2);
                        competencePhysique.Crochetage = reader.GetInt32(3);
                        competencePhysique.Discretion = reader.GetInt32(4);
                        competencePhysique.Equilibre = reader.GetInt32(5);
                        competencePhysique.Escalade = reader.GetInt32(6);
                        competencePhysique.Escamotage = reader.GetInt32(7);
                        competencePhysique.Force = reader.GetInt32(8);
                        competencePhysique.Fouille = reader.GetInt32(9);
                        competencePhysique.Natation = reader.GetInt32(10);
                        competencePhysique.Reflexes = reader.GetInt32(11);
                        competencePhysique.Vigueur = reader.GetInt32(12);

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
    }
}
