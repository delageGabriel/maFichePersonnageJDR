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
    }
}
