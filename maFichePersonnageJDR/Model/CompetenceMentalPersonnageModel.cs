﻿using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class CompetenceMentalPersonnageModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idCompetenceMental;
        private int idPersonnage;
        private int concentration;
        private int connaissanceGeographiques;
        private int connaissanceHistoriques;
        private int connaissanceMagiques;
        private int connaissanceNatures;
        private int connaissanceReligieuses;
        private int decryptage;
        private int esprit;
        private int explosifs;
        private int mecanique;
        private int medecine;
        private int memoire;
        private int perception;
        private int volonte;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdCompetenceMental { get => idCompetenceMental; set => idCompetenceMental = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int Concentration { get => concentration; set => concentration = value; }
        public int ConnaissanceGeographiques { get => connaissanceGeographiques; set => connaissanceGeographiques = value; }
        public int ConnaissanceHistoriques { get => connaissanceHistoriques; set => connaissanceHistoriques = value; }
        public int ConnaissanceMagiques { get => connaissanceMagiques; set => connaissanceMagiques = value; }
        public int ConnaissanceNatures { get => connaissanceNatures; set => connaissanceNatures = value; }
        public int ConnaissanceReligieuses { get => connaissanceReligieuses; set => connaissanceReligieuses = value; }
        public int Decryptage { get => decryptage; set => decryptage = value; }
        public int Esprit { get => esprit; set => esprit = value; }
        public int Explosifs { get => explosifs; set => explosifs = value; }
        public int Mecanique { get => mecanique; set => mecanique = value; }
        public int Medecine { get => medecine; set => medecine = value; }
        public int Memoire { get => memoire; set => memoire = value; }
        public int Perception { get => perception; set => perception = value; }
        public int Volonte { get => volonte; set => volonte = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <param name="concentration"></param>
        /// <param name="connGeo"></param>
        /// <param name="connHis"></param>
        /// <param name="connMag"></param>
        /// <param name="connNat"></param>
        /// <param name="connRel"></param>
        /// <param name="decryptage"></param>
        /// <param name="esprit"></param>
        /// <param name="explosifs"></param>
        /// <param name="mecanique"></param>
        /// <param name="medecine"></param>
        /// <param name="memoire"></param>
        /// <param name="perception"></param>
        /// <param name="perspicacite"></param>
        /// <param name="volonte"></param>
        public void SaveCompetenceMentalPersonnage(int idPersonnage, int concentration, int connGeo, int connHis, int connMag, int connNat, int connRel, int decryptage,
            int esprit, int explosifs, int mecanique, int medecine, int memoire, int perception, int volonte)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO COMPETENCE_MENTAL_PERSONNAGE (id_personnage, concentration, connaissance_geographiques, " +
                    "connaissance_historiques, connaissance_magiques, connaissance_natures, connaissance_religieuses, decryptage, esprit, explosifs, mecanique, medecine, " +
                    "memoire, perception, volonte) " +
                    "VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14})", idPersonnage, concentration, connGeo, connHis,
                    connMag, connNat, connRel, decryptage, esprit, explosifs, mecanique, medecine, memoire, perception, volonte), DatabaseConnection.Instance.GetConnection());

                int rowsAffected = command.ExecuteNonQuery();
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
        public CompetenceMentalPersonnageModel GetBaseMentalPersonnage(int idPersonnage)
        {
            #region Initialisation des variables
            CompetenceMentalPersonnageModel competenceMentalPersonnage = new CompetenceMentalPersonnageModel();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM COMPETENCE_MENTAL_PERSONNAGE " +
                    "WHERE id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CompetenceMentalPersonnageModel competenceMental = new CompetenceMentalPersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        competenceMental.IdCompetenceMental = reader.GetInt32(0);
                        competenceMental.Concentration = reader.GetInt32(1);
                        competenceMental.ConnaissanceGeographiques = reader.GetInt32(2);
                        competenceMental.ConnaissanceHistoriques = reader.GetInt32(3);
                        competenceMental.ConnaissanceMagiques = reader.GetInt32(4);
                        competenceMental.ConnaissanceNatures = reader.GetInt32(5);
                        competenceMental.ConnaissanceReligieuses = reader.GetInt32(6);
                        competenceMental.Decryptage = reader.GetInt32(7);
                        competenceMental.Esprit = reader.GetInt32(8);
                        competenceMental.Explosifs = reader.GetInt32(9);
                        competenceMental.Mecanique = reader.GetInt32(10);
                        competenceMental.Medecine = reader.GetInt32(11);
                        competenceMental.Memoire = reader.GetInt32(12);
                        competenceMental.Perception = reader.GetInt32(12);
                        competenceMental.Volonte = reader.GetInt32(12);

                        competenceMentalPersonnage = competenceMental;
                    }
                }

                return competenceMentalPersonnage;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
