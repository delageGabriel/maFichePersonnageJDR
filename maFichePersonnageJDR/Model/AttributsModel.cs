using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class AttributsModel
    {
        /// <summary>
        /// Attributs
        /// </summary>
        private int idAttribut;
        private string nomAttribut;
        private string descriptionAttribut;
        private string typeAttribut;
        private string noteAttribut;

        /// <summary>
        /// Accesseurs et Mutateurs
        /// </summary>
        public int IdAttribut { get => idAttribut; set => idAttribut = value; }
        public string NomAttribut { get => nomAttribut; set => nomAttribut = value; }
        public string DescriptionAttribut { get => descriptionAttribut; set => descriptionAttribut = value; }
        public string TypeAttribut { get => typeAttribut; set => typeAttribut = value; }
        public string NoteAttribut { get => noteAttribut; set => noteAttribut = value; }

        /// <summary>
        /// Obtient la liste de tous les attributs
        /// </summary>
        /// <returns></returns>
        public List<AttributsModel> GetListAttributs()
        {
            #region Initialisation des variables
            List<AttributsModel> attributsModels = new List<AttributsModel>();
            #endregion

            try
            {
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM ATTRIBUTS", DatabaseConnection.Instance.GetConnection());

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AttributsModel attributs = new AttributsModel();

                        attributs.IdAttribut = reader.GetInt32(0);
                        attributs.NomAttribut = reader.GetString(1);
                        attributs.DescriptionAttribut = reader.GetString(2);
                        attributs.TypeAttribut = reader.GetString(3);
                        attributs.NoteAttribut = reader.GetString(4);

                        attributsModels.Add(attributs);
                    }
                }

                return attributsModels;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Permet de récupérer les informations de l'attribut sélectionné
        /// pour en avoir l'aperçu
        /// </summary>
        /// <param name="nomAttribut">Le nom de l'attribut sélectionné</param>
        /// <returns></returns>
        public AttributsModel GetAttributByName(string nomAttribut)
        {
            AttributsModel attributsModel = new AttributsModel();
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM ATTRIBUTS WHERE nom_attribut = @nomAttribut", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@nomAttribut", nomAttribut);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AttributsModel attributs = new AttributsModel();

                        attributs.IdAttribut = reader.GetInt32(0);
                        attributs.NomAttribut = reader.GetString(1);                        
                        attributs.DescriptionAttribut = reader.GetString(2);
                        attributs.TypeAttribut = reader.GetString(3);
                        attributs.NoteAttribut = reader.GetString(4);

                        attributsModel = attributs;
                    }
                }

                return attributsModel;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Permet de récupérer les informations de l'attribut sélectionné
        /// pour en avoir l'aperçu
        /// </summary>
        /// <param name="nomAttribut">Le nom de l'attribut sélectionné</param>
        /// <returns></returns>
        public int GetAttributsIdByName(string nomAttribut)
        {
            int idAttribut = 0;

            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM ATTRIBUTS WHERE nom_attribut = @nomAttribut", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@nomAttribut", nomAttribut);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        AttributsModel attributs = new AttributsModel();

                        idAttribut = reader.GetInt32(0);
                    }
                }

                return idAttribut;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
