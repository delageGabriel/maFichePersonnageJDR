using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using maFichePersonnageJDR.Classe;

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
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM ARMES WHERE type_arme = @typeArme", connection);
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
    }
}
