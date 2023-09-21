using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class MagiePersonnageModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idMagiePersonnage;
        private int idMagie;
        private int idPersonnage;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdMagiePersonnage { get => idMagiePersonnage; set => idMagiePersonnage = value; }
        public int IdMagie { get => idMagie; set => idMagie = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }

        /// <summary>
        /// Méthode qui permet d'associer à un personnage une magie
        /// </summary>
        /// <param name="idMagie"></param>
        /// <param name="idPersonnage"></param>
        public void SaveMagiePersonnage(int idMagie, int idPersonnage)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO MAGIE_PERSONNAGE (id_magie, id_personnage) " +
                    "VALUES ({0}, {1})", idMagie, idPersonnage), DatabaseConnection.Instance.GetConnection());

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
