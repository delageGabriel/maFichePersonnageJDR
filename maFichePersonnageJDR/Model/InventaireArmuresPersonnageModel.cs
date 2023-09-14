using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class InventaireArmuresPersonnageModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idInventaireArmuresPersonnage;
        private int idArmures;
        private int idPersonnage;
        private int quantite;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdInventaireArmuresPersonnage { get => idInventaireArmuresPersonnage; set => idInventaireArmuresPersonnage = value; }
        public int IdArmures { get => idArmures; set => idArmures = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int Quantite { get => quantite; set => quantite = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idArmure"></param>
        /// <param name="idPersonnage"></param>
        /// <param name="quantite"></param>
        public void SaveInventaireArmuresPersonnage(int idArmure, int idPersonnage, int quantite)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO INVENTAIRE_ARMURES_PERSONNAGES (id_armure, id_personnage, quantite) " +
                    "VALUES ({0}, {1}, {2})", idArmure, idPersonnage, quantite), DatabaseConnection.Instance.GetConnection());

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
