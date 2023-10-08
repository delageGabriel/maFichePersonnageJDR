using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class ArmesModel
    {
        /// <summary>
        /// Attributs
        /// </summary>
        private int idArme;
        private string typeArme;
        private string nomArme;
        private double poidsArmes;
        private string allongeArmes;
        private string mainArmes;
        private string typeDegatsArmes;
        private string degatsArmes;
        private int valeurArme;
        private string descriptionArme;
        private string specialArme;

        /// <summary>
        /// Accesseurs et Mutateurs
        /// </summary>
        public int IdArme { get => idArme; set => idArme = value; }
        public string TypeArme { get => typeArme; set => typeArme = value; }
        public string NomArme { get => nomArme; set => nomArme = value; }
        public double PoidsArmes { get => poidsArmes; set => poidsArmes = value; }
        public string AllongeArmes { get => allongeArmes; set => allongeArmes = value; }
        public string MainArmes { get => mainArmes; set => mainArmes = value; }
        public string TypeDegatsArmes { get => typeDegatsArmes; set => typeDegatsArmes = value; }
        public string DegatsArmes { get => degatsArmes; set => degatsArmes = value; }
        public int ValeurArme { get => valeurArme; set => valeurArme = value; }
        public string DescriptionArme { get => descriptionArme; set => descriptionArme = value; }
        public string SpecialArme { get => specialArme; set => specialArme = value; }

        /// <summary>
        /// Permet d'obtenir la liste de toutes les armes pour un type d'arme
        /// </summary>
        /// <param name="typeArme">le type d'arme</param>
        /// <returns>la liste d'armes</returns>
        public List<ArmesModel> GetListArmesByTypes(string typeArme)
        {
            #region Initialisation variables
            List<ArmesModel> armesModels = new List<ArmesModel>();
            #endregion

            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM ARMES WHERE type_arme = @typeArme", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@typeArme", typeArme);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArmesModel armeModel = new ArmesModel();

                        armeModel.IdArme = reader.GetInt32(0);
                        armeModel.TypeArme = reader.GetString(1);
                        armeModel.NomArme = reader.GetString(2);
                        armeModel.PoidsArmes = reader.GetDouble(3);
                        armeModel.AllongeArmes = reader.GetString(4);
                        armeModel.MainArmes = reader.GetString(5);
                        armeModel.TypeDegatsArmes = reader.GetString(6);
                        armeModel.DegatsArmes = reader.GetString(7);
                        armeModel.ValeurArme = reader.GetInt32(8);
                        armeModel.DescriptionArme = reader.GetString(9);
                        armeModel.SpecialArme = reader.GetString(10);

                        armesModels.Add(armeModel);
                    }
                }

                return armesModels;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Permet d'obtenir une arme par rapport à son nom
        /// </summary>
        /// <param name="nomArme"></param>
        /// <returns></returns>
        public ArmesModel GetArmeByName(string nomArme)
        {
            ArmesModel armeModel = new ArmesModel();
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM ARMES WHERE nom_arme = @nomArme", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@nomArme", nomArme);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArmesModel arme = new ArmesModel();

                        arme.IdArme = reader.GetInt32(0);
                        arme.TypeArme = reader.GetString(1);
                        arme.NomArme = reader.GetString(2);
                        arme.PoidsArmes = reader.GetDouble(3);
                        arme.AllongeArmes = reader.GetString(4);
                        arme.MainArmes = reader.GetString(5);
                        arme.TypeDegatsArmes = reader.GetString(6);
                        arme.DegatsArmes = reader.GetString(7);
                        arme.ValeurArme = reader.GetInt32(8);
                        arme.DescriptionArme = reader.GetString(9);
                        arme.SpecialArme = reader.GetString(10);

                        armeModel = arme;
                    }
                }

                return armeModel;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomArme"></param>
        /// <returns></returns>
        public int GetArmesIdByName(string nomArme)
        {
            int idArme = 0;

            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("SELECT id_armes FROM ARMES WHERE nom_arme = '{0}'", nomArme), DatabaseConnection.Instance.GetConnection());

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArmesModel armes = new ArmesModel();

                        idArme = reader.GetInt32(0);
                    }

                }

                return idArme;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne le nom de l'arme par son id
        /// </summary>
        /// <param name="idArme"></param>
        /// <returns></returns>
        public string GetArmeNameById(int idArme)
        {
            string nomArme = string.Empty;

            try
            {
                SQLiteCommand command = new SQLiteCommand("SELECT nom_arme " +
                    "FROM ARMES " +
                    "WHERE id_armes = @idArme", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@idArme", idArme);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArmesModel armes = new ArmesModel();

                        nomArme = reader.GetString(0);
                    }
                }

                return nomArme;
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
        }
    }
}
