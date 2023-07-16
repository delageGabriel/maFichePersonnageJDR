using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using maFichePersonnageJDR.Classe;

namespace maFichePersonnageJDR.Model
{
    class ObjetsModel
    {
        /// <summary>
        /// Attributs
        /// </summary>
        private int idObjet;
        private string nomObjet;
        private double poidsObjet;
        private string tailleObjet;
        private int valeurObjet;
        private string descriptionObjet;
        private string typeObjet;
        private string durabiliteObjet;

        /// <summary>
        /// Accesseurs et Mutateurs
        /// </summary>
        public int IdObjet { get => idObjet; set => idObjet = value; }
        public string NomObjet { get => nomObjet; set => nomObjet = value; }
        public double PoidsObjet { get => poidsObjet; set => poidsObjet = value; }
        public string TailleObjet { get => tailleObjet; set => tailleObjet = value; }
        public int ValeurObjet { get => valeurObjet; set => valeurObjet = value; }
        public string DescriptionObjet { get => descriptionObjet; set => descriptionObjet = value; }
        public string TypeObjet { get => typeObjet; set => typeObjet = value; }
        public string DurabiliteObjet { get => durabiliteObjet; set => durabiliteObjet = value; }

        public List<ObjetsModel> GetListObjetsByTypes(string typeObjet)
        {
            #region Initialisation variables
            List<ObjetsModel> objetsModels = new List<ObjetsModel>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM OBJETS WHERE typeObjet = @typeObjet", connection);
                command.Parameters.AddWithValue("@typeObjet", typeObjet);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ObjetsModel objetsModel = new ObjetsModel();

                        objetsModel.IdObjet = reader.GetInt32(0);
                        objetsModel.NomObjet = reader.GetString(1);
                        objetsModel.PoidsObjet = reader.GetDouble(2);
                        objetsModel.TailleObjet = reader.GetString(3);
                        objetsModel.ValeurObjet = reader.GetInt32(4);
                        objetsModel.DescriptionObjet = reader.GetString(5);
                        objetsModel.TypeObjet = reader.GetString(6);
                        objetsModel.DurabiliteObjet = reader.GetString(7);

                        objetsModels.Add(objetsModel);
                    }
                }

                return objetsModels;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
