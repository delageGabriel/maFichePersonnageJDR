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
        public int Natation { get => natation; set => natation = value; }
        public int Reflexes { get => reflexes; set => reflexes = value; }
        public int Vigueur { get => vigueur; set => vigueur = value; }

        public void SaveCompetencePhysiquePersonnage(int idPersonnage, int agilite, int artisanat, int crochetage, int discretion, int equilibre, int escalade, int escamotage,
            int force, int natation, int reflexes, int vigueur)
        {
            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO COMPETENCE_PHYSIQUE_PERSONNAGE (id_personnage, agilite, artisanat, " +
                    "crochetage, discretion, equilibre, escalade, escamotage, force, natation, reflexes, vigueur) " +
                    "VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11})", idPersonnage, agilite, artisanat, crochetage,
                    discretion, equilibre, escalade, escamotage, force, natation, reflexes, vigueur), connection);

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
