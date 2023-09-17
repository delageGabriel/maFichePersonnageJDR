using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using maFichePersonnageJDR.Classe;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class ArmuresModel
    {
        /// <summary>
        /// Attributs
        /// </summary>
        private int idArmure;
        private string nomArmure;
        private double poidsArmure;
        private string valeurArmure;
        private string protectionArmure;
        private string bonusArmure;
        private string typeArmure;
        private string descriptionArmure;
        private string specialArmure;

        /// <summary>
        /// Accesseurs et Mutateurs
        /// </summary>
        public int IdArmure { get => idArmure; set => idArmure = value; }
        public string NomArmure { get => nomArmure; set => nomArmure = value; }
        public double PoidsArmure { get => poidsArmure; set => poidsArmure = value; }
        public string ValeurArmure { get => valeurArmure; set => valeurArmure = value; }
        public string ProtectionArmure { get => protectionArmure; set => protectionArmure = value; }
        public string BonusArmure { get => bonusArmure; set => bonusArmure = value; }
        public string TypeArmure { get => typeArmure; set => typeArmure = value; }
        public string DescriptionArmure { get => descriptionArmure; set => descriptionArmure = value; }
        public string SpecialArmure { get => specialArmure; set => specialArmure = value; }

        public List<ArmuresModel> GetListArmuresByTypes(string typeArmure)
        {
            #region Initialisation variables
            List<ArmuresModel> armuresModels = new List<ArmuresModel>();
            #endregion

            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM ARMURES WHERE type_armure = @typeArmure ORDER BY nom_armure ASC", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@typeArmure", typeArmure);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArmuresModel armureModel = new ArmuresModel();

                        armureModel.IdArmure = reader.GetInt32(0);
                        armureModel.TypeArmure = reader.GetString(1);
                        armureModel.NomArmure = reader.GetString(2);
                        armureModel.PoidsArmure = reader.GetDouble(3);
                        armureModel.ValeurArmure = reader.GetString(4);
                        armureModel.ProtectionArmure = reader.GetString(5);
                        armureModel.BonusArmure = reader.GetString(6);
                        armureModel.DescriptionArmure = reader.GetString(7);
                        armureModel.SpecialArmure = reader.GetString(8);

                        armuresModels.Add(armureModel);
                    }
                }

                return armuresModels;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Permet d'obtenir une armure par rapport à son nom
        /// </summary>
        /// <param name="nomArmure"></param>
        /// <returns></returns>
        public ArmuresModel GetArmureByName(string nomArmure)
        {
            ArmuresModel armureModel = new ArmuresModel();
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM ARMURES WHERE nom_armure = @nomArmure", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@nomArmure", nomArmure);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArmuresModel armure = new ArmuresModel();

                        armure.IdArmure = reader.GetInt32(0);
                        armure.TypeArmure = reader.GetString(1);
                        armure.NomArmure = reader.GetString(2);
                        armure.PoidsArmure = reader.GetDouble(3);
                        armure.ValeurArmure = reader.GetString(4);
                        armure.ProtectionArmure = reader.GetString(5);
                        armure.BonusArmure = reader.GetString(6);
                        armure.DescriptionArmure = reader.GetString(7);
                        armure.SpecialArmure = reader.GetString(8);

                        armureModel = armure;
                    }
                }

                return armureModel;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomArmure"></param>
        /// <returns></returns>
        public int GetArmuresIdByName(string nomArmure)
        {
            int idArmure = 0;

            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("SELECT id_armure FROM ARMES WHERE nom_armure = '{0}'", nomArmure), DatabaseConnection.Instance.GetConnection());

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idArmure = reader.GetInt32(0);
                    }
                }

                return idArmure;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
