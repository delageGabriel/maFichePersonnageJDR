using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class AttributsPersonnageModel
    {
        /// <summary>
        /// champs
        /// </summary>
        private int idAttributsPersonnage;
        private int idAttribut;
        private int idPersonnage;

        /// <summary>
        /// accesseurs et mutateurs
        /// </summary>
        public int IdAttributsPersonnage { get => idAttributsPersonnage; set => idAttributsPersonnage = value; }
        public int IdAttribut { get => idAttribut; set => idAttribut = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }

        /// <summary>
        /// Ajouter un nouvel attribut au personnage
        /// </summary>
        /// <param name="idAttribut">l'id de l'attribut à ajouter</param>
        /// <param name="idPersonnage">l'id du personnage à qui on ajoute l'attribut</param>
        public void AddAttributToPersonnage(int idAttribut, int idPersonnage)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO ATTRIBUTS_PERSONNAGE " +
                    "(id_attribut, id_personnage) " +
                    "VALUES ('{0}','{1}')", idAttribut, idPersonnage), DatabaseConnection.Instance.GetConnection());

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
