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
        //private string typeDegatsArmes;
        //private string degatsArmes;
        private string degTranchant;
        private string degContondant;
        private string degPerforant;
        private string degIgnee;
        private string degAquatique;
        private string degCeleste;
        private string degTerrestre;
        private int valeurArme;
        private string descriptionArme;
        private string descriptionCourteArme;
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
        public string DegTranchant { get => degTranchant; set => degTranchant = value; }
        public string DegContondant { get => degContondant; set => degContondant = value; }
        public string DegPerforant { get => degPerforant; set => degPerforant = value; }
        public string DegIgnee { get => degIgnee; set => degIgnee = value; }
        public string DegAquatique { get => degAquatique; set => degAquatique = value; }
        public string DegCeleste { get => degCeleste; set => degCeleste = value; }
        public string DegTerrestre { get => degTerrestre; set => degTerrestre = value; }

        public int ValeurArme { get => valeurArme; set => valeurArme = value; }
        public string DescriptionArme { get => descriptionArme; set => descriptionArme = value; }
        public string DescriptionCourteArme { get => descriptionCourteArme; set => descriptionCourteArme = value; }
        public string SpecialArme { get => specialArme; set => specialArme = value; }

        /// <summary>
        /// Permet d'obtenir la liste de toutes les armes pour un type d'arme
        /// </summary>
        /// <param name="typeArme">le type d'arme</param>
        /// <returns>la liste d'armes</returns>
        public Dictionary<int, ArmesModel> GetListArmesByTypes(string typeArme)
        {
            #region Initialisation variables
            Dictionary<int, ArmesModel> dictionaryArmes = new Dictionary<int, ArmesModel>();
            #endregion

            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT ARMES.id_armes," +
                        " ARMES.type_arme," +
                        " ARMES.nom_arme," +
                        " ARMES.poids_arme," +
                        " ARMES.allonge_arme," +
                        " ARMES.main_arme," +
                        " ARMES.deg_tranchant," +
                        " ARMES.deg_contondant," +
                        " ARMES.deg_perforant," +
                        " ARMES.deg_ignee," +
                        " ARMES.deg_aqua, " +
                        " ARMES.deg_celeste," +
                        " ARMES.deg_terrestre," +
                        " ARMES.valeur_arme," +
                        " ARMES.description_arme," +
                        " ARMES.description_courte_arme," +
                        " ARMES.special_arme " +
                    "FROM ARMES " +
                    "WHERE type_arme = @typeArme", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@typeArme", typeArme);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArmesModel arme = new ArmesModel();

                        int idArme = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        arme.TypeArme = reader.IsDBNull(1) ? "null" : reader.GetString(1);
                        arme.NomArme = reader.IsDBNull(2) ? "null" : reader.GetString(2);
                        arme.PoidsArmes = reader.IsDBNull(3) ? 0.0 : reader.GetDouble(3);
                        arme.AllongeArmes = reader.IsDBNull(4) ? "null" : reader.GetString(4);
                        arme.MainArmes = reader.IsDBNull(5) ? "null" : reader.GetString(5);
                        arme.DegTranchant = reader.IsDBNull(6) ? "null" : reader.GetString(6);
                        arme.DegContondant = reader.IsDBNull(7) ? "null" : reader.GetString(7);
                        arme.DegPerforant = reader.IsDBNull(8) ? "null" : reader.GetString(8);
                        arme.DegIgnee = reader.IsDBNull(9) ? "null" : reader.GetString(9);
                        arme.DegAquatique = reader.IsDBNull(10) ? "null" : reader.GetString(10);
                        arme.DegCeleste = reader.IsDBNull(11) ? "null" : reader.GetString(11);
                        arme.DegTerrestre = reader.IsDBNull(12) ? "null" : reader.GetString(12);
                        arme.ValeurArme = reader.IsDBNull(13) ? 0 : reader.GetInt32(13);
                        arme.DescriptionArme = reader.IsDBNull(14) ? "null" : reader.GetString(14);
                        arme.DescriptionCourteArme = reader.IsDBNull(15) ? "null" : reader.GetString(15);
                        arme.SpecialArme = reader.IsDBNull(16) ? "null" : reader.GetString(16);

                        dictionaryArmes.Add(idArme, arme);
                    }
                }

                return dictionaryArmes;
            }
            catch (Exception e)
            {
                Console.WriteLine("Une erreur s'est produite !" + e.Message);
                throw;
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
            }
        }
        /// <summary>
        /// Permet d'obtenir une arme par rapport à son nom
        /// </summary>
        /// <param name="nomArme"></param>
        /// <returns></returns>
        public static ArmesModel GetArmeByName(string nomArme)
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

                        arme.IdArme = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                        arme.TypeArme = reader.IsDBNull(1) ? "null" : reader.GetString(1);
                        arme.NomArme = reader.IsDBNull(2) ? "null" : reader.GetString(2);
                        arme.PoidsArmes = reader.IsDBNull(3) ? 0.0 : reader.GetDouble(3);
                        arme.AllongeArmes = reader.IsDBNull(4) ? "null" : reader.GetString(4);
                        arme.MainArmes = reader.IsDBNull(5) ? "null" : reader.GetString(5);
                        arme.DegTranchant = reader.IsDBNull(6) ? "null" : reader.GetString(6);
                        arme.DegContondant = reader.IsDBNull(7) ? "null" : reader.GetString(7);
                        arme.DegPerforant = reader.IsDBNull(8) ? "null" : reader.GetString(8);
                        arme.DegIgnee = reader.IsDBNull(9) ? "null" : reader.GetString(9);
                        arme.DegAquatique = reader.IsDBNull(10) ? "null" : reader.GetString(10);
                        arme.DegCeleste = reader.IsDBNull(11) ? "null" : reader.GetString(11);
                        arme.DegTerrestre = reader.IsDBNull(12) ? "null" : reader.GetString(12);
                        arme.ValeurArme = reader.IsDBNull(13) ? 0 : reader.GetInt32(13);
                        arme.DescriptionArme = reader.IsDBNull(14) ? "null" : reader.GetString(14);
                        arme.DescriptionCourteArme = reader.IsDBNull(15) ? "null" : reader.GetString(15);
                        arme.SpecialArme = reader.IsDBNull(16) ? "null" : reader.GetString(16);

                        armeModel = arme;
                    }
                }

                return armeModel;
            }
            catch (Exception e)
            {
                Console.WriteLine("Une erreur s'est produite !" + e.Message);
                throw;
            }
            finally
            {
                DatabaseConnection.Instance.CloseConnection();
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
