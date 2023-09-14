using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class InventaireObjetsPersonnagesModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idInventaireObjetsPersonnages;
        private int idObjets;
        private int idPersonnage;
        private int quantite;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdInventaireObjetsPersonnages { get => idInventaireObjetsPersonnages; set => idInventaireObjetsPersonnages = value; }
        public int IdObjets { get => idObjets; set => idObjets = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int Quantite { get => quantite; set => quantite = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idArmure"></param>
        /// <param name="idPersonnage"></param>
        /// <param name="quantite"></param>
        public void SaveInventaireObjetsPersonnage(int idObjets, int idPersonnage, int quantite)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO INVENTAIRE_OBJETS_PERSONNAGES (id_objets, id_personnage, quantite) " +
                    "VALUES ({0}, {1}, {2})", idObjets, idPersonnage, quantite), DatabaseConnection.Instance.GetConnection());

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
