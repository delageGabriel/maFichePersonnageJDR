using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class AptitudesModel
    {
        /// <summary>
        /// Attributs
        /// </summary>
        private int idAptitude;
        private string nomAptitude;
        private string typeAptitude;
        private string descriptionAptitude;
        private int coutAptitude;
        private int niveauAptitude;

        /// <summary>
        /// Accesseurs et Mutateurs
        /// </summary>
        public int IdAptitude { get => idAptitude; set => idAptitude = value; }
        public string NomAptitude { get => nomAptitude; set => nomAptitude = value; }
        public string TypeAptitude { get => typeAptitude; set => typeAptitude = value; }
        public string DescriptionAptitude { get => descriptionAptitude; set => descriptionAptitude = value; }
        public int CoutAptitude { get => coutAptitude; set => coutAptitude = value; }
        public int NiveauAptitude { get => niveauAptitude; set => niveauAptitude = value; }

        /// <summary>
        /// Permet d'obtenir la liste de toutes les armes pour un type d'arme
        /// </summary>
        /// <param name="typeAptitudes">le type d'arme</param>
        /// <returns>la liste d'armes</returns>
        public List<AptitudesModel> GetAptitudesModels(string typeAptitudes)
        {
            #region Initialisation variables
            List<AptitudesModel> AptitudesModels = new List<AptitudesModel>();
            typeAptitudes = typeAptitudes.Replace(typeAptitudes, "%" + typeAptitudes + "%");
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM APTITUDES WHERE type_aptitude LIKE @typeAptitudes", connection);
                command.Parameters.AddWithValue("@typeAptitudes", typeAptitudes);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AptitudesModel aptitude = new AptitudesModel();

                        aptitude.IdAptitude = reader.GetInt32(0);
                        aptitude.NomAptitude = reader.GetString(1);
                        aptitude.TypeAptitude = reader.GetString(2);
                        aptitude.DescriptionAptitude = reader.GetString(3);
                        aptitude.CoutAptitude = reader.GetInt32(4);
                        aptitude.NiveauAptitude = reader.GetInt32(5);

                        AptitudesModels.Add(aptitude);
                    }
                }

                return AptitudesModels;
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
        public AptitudesModel GetAptitudesByName(string nomAptitude)
        {
            AptitudesModel aptitudesModel = new AptitudesModel();

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM APTITUDES WHERE nom_aptitude = @nomAptitude", connection);
                command.Parameters.AddWithValue("@nomAptitude", nomAptitude);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AptitudesModel aptitude = new AptitudesModel();

                        aptitude.IdAptitude = reader.GetInt32(0);
                        aptitude.NomAptitude = reader.GetString(1);
                        aptitude.DescriptionAptitude = reader.GetString(3);
                        aptitude.CoutAptitude = reader.GetInt32(4);
                        aptitude.NiveauAptitude = reader.GetInt32(5);

                        aptitudesModel = aptitude;
                    }
                }

                return aptitudesModel;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
