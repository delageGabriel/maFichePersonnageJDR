using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class AptitudesPersonnageModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idAptitudesPersonnage;
        private int idAptitudes;
        private int idPersonnage;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdAptitudesPersonnage { get => idAptitudesPersonnage; set => idAptitudesPersonnage = value; }
        public int IdAptitudes { get => idAptitudes; set => idAptitudes = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }

        /// <summary>
        /// Méthode qui permet d'associer à un personnage une aptitude
        /// </summary>
        /// <param name="idAptitude"></param>
        /// <param name="idPersonnage"></param>
        public void SaveAptitudePersonnage(int idAptitude, int idPersonnage)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO APTITUDES_PERSONNAGE (id_aptitude, id_personnage) " +
                    "VALUES ({0}, {1})", idAptitude, idPersonnage), DatabaseConnection.Instance.GetConnection());

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne un personnage par son ID
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public List<string> GetListNomAptitude(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listNomAptitude = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT nom_aptitude " +
                    "FROM APTITUDES " +
                    "INNER JOIN APTITUDES_PERSONNAGE ON APTITUDES.id_aptitude = APTITUDES_PERSONNAGE.id_aptitude " +
                    "WHERE APTITUDES_PERSONNAGE.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["nom_aptitude"].ToString();
                        listNomAptitude.Add(value);
                    }
                }

                return listNomAptitude;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne un personnage par son ID
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public List<string> GetListTypeAptitude(int idPersonnage)
        {
            #region Initialisation des variables
            List<string> listTypeAptitude = new List<string>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT type_aptitude " +
                    "FROM APTITUDES " +
                    "INNER JOIN APTITUDES_PERSONNAGE ON APTITUDES.id_aptitude = APTITUDES_PERSONNAGE.id_aptitude " +
                    "WHERE APTITUDES_PERSONNAGE.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        string value = reader["type_aptitude"].ToString();
                        listTypeAptitude.Add(value);
                    }
                }

                return listTypeAptitude;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne un personnage par son ID
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public List<int> GetListCoutAptitude(int idPersonnage)
        {
            #region Initialisation des variables
            List<int> listCoutAptitude = new List<int>();
            #endregion

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT cout_aptitude " +
                    "FROM APTITUDES " +
                    "INNER JOIN APTITUDES_PERSONNAGE ON APTITUDES.id_aptitude = APTITUDES_PERSONNAGE.id_aptitude " +
                    "WHERE APTITUDES_PERSONNAGE.id_personnage = @idPersonnage", connection);
                command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

                        // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                        int value = Convert.ToInt32(reader["cout_aptitude"]);
                        listCoutAptitude.Add(value);
                    }
                }

                return listCoutAptitude;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<string> GetListDescrAptitude(int idPersonnage)
        {
            List<string> listDescrMagie = new List<string>();

            SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

            SQLiteCommand command = new SQLiteCommand("SELECT descr_aptitude " +
                "FROM APTITUDES " +
                "INNER JOIN APTITUDES_PERSONNAGE ON APTITUDES.id_aptitude = APTITUDES_PERSONNAGE.id_aptitude " +
                "WHERE APTITUDES_PERSONNAGE.id_personnage = @idPersonnage", connection);
            command.Parameters.AddWithValue("@idPersonnage", idPersonnage);

            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // On vérifie si une ligne existe déjà avec le nom prénom du personnage
                    string value = reader["descr_aptitude"].ToString();
                    listDescrMagie.Add(value);
                }
            }

            return listDescrMagie;
        }
    }
}
