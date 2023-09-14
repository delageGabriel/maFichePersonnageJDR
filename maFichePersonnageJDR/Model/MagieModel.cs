using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class MagieModel
    {
        /// <summary>
        /// Attributs
        /// </summary>
        private int idMagie;
        private string nomMagie;
        private string typeMagie;
        private string descriptionMagie;
        private int coutMagie;
        private int niveauMagie;


        /// <summary>
        /// Accesseurs et Mutateurs
        /// </summary>
        public int IdMagie { get => idMagie; set => idMagie = value; }
        public string NomMagie { get => nomMagie; set => nomMagie = value; }
        public string TypeMagie { get => typeMagie; set => typeMagie = value; }
        public string DescriptionMagie { get => descriptionMagie; set => descriptionMagie = value; }
        public int CoutMagie { get => coutMagie; set => coutMagie = value; }
        public int NiveauMagie { get => niveauMagie; set => niveauMagie = value; }

        /// <summary>
        /// Permet d'obtenir la liste de toutes les armes pour un type d'arme
        /// </summary>
        /// <param name="typeMagie">le type d'arme</param>
        /// <returns>la liste d'armes</returns>
        public List<MagieModel> GetMagieModels(string typeMagie)
        {
            #region Initialisation variables
            List<MagieModel> magieModels = new List<MagieModel>();
            #endregion

            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM MAGIE WHERE type_magie = @typeMagie", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@typeMagie", typeMagie);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MagieModel magie = new MagieModel();

                        magie.IdMagie = reader.GetInt32(0);
                        magie.NomMagie = reader.GetString(1);
                        magie.TypeMagie = reader.GetString(2);
                        magie.DescriptionMagie = reader.GetString(3);
                        magie.CoutMagie = reader.GetInt32(4);
                        magie.NiveauMagie = reader.GetInt32(5);

                        magieModels.Add(magie);
                    }
                }

                return magieModels;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Permet d'obtenir une arme par rapport à son nom
        /// </summary>
        /// <param name="nomMagie"></param>
        /// <returns></returns>
        public MagieModel GetMagieByName(string nomMagie)
        {
            MagieModel magieModel = new MagieModel();

            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM MAGIE WHERE nom_magie = @nomMagie", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@nomMagie", nomMagie);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MagieModel magie = new MagieModel();

                        magie.IdMagie = reader.GetInt32(0);
                        magie.NomMagie = reader.GetString(1);
                        magie.TypeMagie = reader.GetString(2);
                        magie.DescriptionMagie = reader.GetString(3);
                        magie.CoutMagie = reader.GetInt32(4);
                        magie.NiveauMagie = reader.GetInt32(5);

                        magieModel = magie;
                    }
                }

                return magieModel;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
