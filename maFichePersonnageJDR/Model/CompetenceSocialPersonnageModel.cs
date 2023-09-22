using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class CompetenceSocialPersonnageModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idCompetenceSocial;
        private int idPersonnage;
        private int baratinage;
        private int charme;
        private int comedie;
        private int diplomatie;
        private int dressage;
        private int intimidation;
        private int marchandage;
        private int prestance;
        private int provocation;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdCompetenceSocial { get => idCompetenceSocial; set => idCompetenceSocial = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int Baratinage { get => baratinage; set => baratinage = value; }
        public int Charme { get => charme; set => charme = value; }
        public int Comedie { get => comedie; set => comedie = value; }
        public int Diplomatie { get => diplomatie; set => diplomatie = value; }
        public int Dressage { get => dressage; set => dressage = value; }
        public int Intimidation { get => intimidation; set => intimidation = value; }
        public int Marchandage { get => marchandage; set => marchandage = value; }
        public int Prestance { get => prestance; set => prestance = value; }
        public int Provocation { get => provocation; set => provocation = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <param name="baratinage"></param>
        /// <param name="charme"></param>
        /// <param name="comedie"></param>
        /// <param name="diplomatie"></param>
        /// <param name="dressage"></param>
        /// <param name="intimidation"></param>
        /// <param name="marchandage"></param>
        /// <param name="prestance"></param>
        /// <param name="provocation"></param>
        public void SaveCompetenceSocialPersonnage(int idPersonnage, int baratinage, int charme, int comedie, int diplomatie, int dressage, int intimidation, int marchandage,
            int prestance, int provocation)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO COMPETENCE_SOCIAL_PERSONNAGE (id_personnage, baratinage, charme, " +
                    "comedie, diplomatie, dressage, intimidation, marchandage, prestance, provocation) " +
                    "VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", idPersonnage, baratinage, charme, comedie,
                    diplomatie, dressage, intimidation, marchandage, prestance, provocation), DatabaseConnection.Instance.GetConnection());

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
        public CompetenceSocialPersonnageModel GetBaseSocialPersonnage(int idPersonnage)
        {
            #region Initialisation des variables
            CompetenceSocialPersonnageModel competenceSocialPersonnage = new CompetenceSocialPersonnageModel();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM COMPETENCE_SOCIAL_PERSONNAGE " +
                    "WHERE id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CompetenceSocialPersonnageModel competenceSocial = new CompetenceSocialPersonnageModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        competenceSocial.IdCompetenceSocial = reader.GetInt32(0);
                        competenceSocial.Baratinage = reader.GetInt32(1);
                        competenceSocial.Charme = reader.GetInt32(2);
                        competenceSocial.Comedie = reader.GetInt32(3);
                        competenceSocial.Diplomatie = reader.GetInt32(4);
                        competenceSocial.Dressage = reader.GetInt32(5);
                        competenceSocial.Intimidation = reader.GetInt32(6);
                        competenceSocial.Marchandage = reader.GetInt32(7);
                        competenceSocial.Prestance = reader.GetInt32(8);
                        competenceSocial.Provocation = reader.GetInt32(9);

                        competenceSocialPersonnage = competenceSocial;
                    }
                }

                return competenceSocialPersonnage;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
