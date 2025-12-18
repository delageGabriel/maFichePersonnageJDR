using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Classe;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class SpecialitesModel
    {
        /// <summary>
        /// ATTRIBUTS
        /// </summary>
        public int IdSpecialites { get; set; }
        public string NomSpecialites { get; set; }
        public string DescriptionSpecialites { get; set; }

        public Dictionary<int, string> GetNameSpecialitesModels(string typeSpecialites)
        {
            Dictionary<int, string> SpecialitesModel = new Dictionary<int, string>();
            typeSpecialites = typeSpecialites.Replace(typeSpecialites, "%" + typeSpecialites + "%");

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand("SELECT id_specialites, nom_specialites, effet_specialites FROM SPECIALITES WHERE type_specialites LIKE @typeSpecialites", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@typeSpecialites", typeSpecialites);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SpecialitesModel specialites = new SpecialitesModel();

                        specialites.IdSpecialites = reader.GetInt32(0);
                        specialites.NomSpecialites = reader.GetString(1);
                        specialites.DescriptionSpecialites = reader.GetString(2);

                        SpecialitesModel.Add(specialites.IdSpecialites, specialites.NomSpecialites);
                    }
                }

                return SpecialitesModel;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
