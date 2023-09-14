using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class InventaireArmesPersonnagesModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idArmesPersonnages;
        private int idArme;
        private int idPersonnage;
        private int quantite;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdArmesPersonnages { get => idArmesPersonnages; set => idArmesPersonnages = value; }
        public int IdArme { get => idArme; set => idArme = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int Quantite { get => quantite; set => quantite = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idArme"></param>
        /// <param name="idPersonnage"></param>
        /// <param name="quantite"></param>
        public void SaveInventaireArmesPersonnage(int idArme, int idPersonnage, int quantite)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO INVENTAIRE_ARMES_PERSONNAGES (id_arme, id_personnage, quantite) " +
                    "VALUES ({0}, {1}, {2})", idArme, idPersonnage, quantite), DatabaseConnection.Instance.GetConnection());

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
