using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class CreationPersonnageModel
    {
        /// <summary>
        /// Attributs
        /// </summary>
        private int idCreationPersonnage;
        private int idPersonnage;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdCreationPersonnage { get => idCreationPersonnage; set => idCreationPersonnage = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }

        /// <summary>
        /// Créer un nouveau personnage
        /// </summary>
        public void CreatePersonnage(int idPersonnage)
        {
            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO CREATION_PERSONNAGE " +
                    "(id_personnage) " +
                    "VALUES ('{0}')", IdPersonnage), connection);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
