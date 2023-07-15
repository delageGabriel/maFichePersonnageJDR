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
        private int valeurArmure;
        private string protectionArmure;
        private string typeArmure;
        private string descriptionArmure;
        private string specialArmure;

        /// <summary>
        /// Accesseurs et Mutateurs
        /// </summary>
        public int IdArmure { get => idArmure; set => idArmure = value; }
        public string NomArmure { get => nomArmure; set => nomArmure = value; }
        public double PoidsArmure { get => poidsArmure; set => poidsArmure = value; }
        public int ValeurArmure { get => valeurArmure; set => valeurArmure = value; }
        public string ProtectionArmure { get => protectionArmure; set => protectionArmure = value; }
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
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM ARMURES WHERE type_armure = @typeArmure", connection);
                command.Parameters.AddWithValue("@typeArmure", typeArmure);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArmuresModel armureModel = new ArmuresModel();

                        armureModel.IdArmure = reader.GetInt32(0);
                        armureModel.NomArmure = reader.GetString(1);
                        armureModel.PoidsArmure = reader.GetDouble(2);
                        armureModel.ValeurArmure = reader.GetInt32(3);
                        armureModel.ProtectionArmure = reader.GetString(4);
                        armureModel.TypeArmure = reader.GetString(5);
                        armureModel.DescriptionArmure = reader.GetString(6);
                        armureModel.SpecialArmure = reader.GetString(7);

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
    }
}
