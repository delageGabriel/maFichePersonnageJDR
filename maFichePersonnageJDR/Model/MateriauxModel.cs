using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class MateriauxModel
    {
        public int IdMateriau { get; set; }
        public string NomMateriau { get; set; }
        public string Categorie { get; set; }
        public string Realisme { get; set; }
        public string Description { get; set; }

        public Dictionary<string, MateriauxModel> GetNameMateriauAndCategorie()
        {
            Dictionary<string, MateriauxModel> materiauxModels = new Dictionary<string, MateriauxModel>();

            try
            {
                SQLiteCommand command = new SQLiteCommand(@"
                    SELECT nom_materiau, categorie
                    FROM MATERIAUX
                    ORDER BY MATERIAUX.categorie DESC;", DatabaseConnection.Instance.GetConnection());

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MateriauxModel materiaux = new MateriauxModel();

                        materiaux.NomMateriau = reader.GetString(0);
                        materiaux.Categorie = reader.GetString(1);

                        materiauxModels.Add(materiaux.NomMateriau, materiaux);
                    }
                }

                return materiauxModels;
            }
            catch
            {
                throw;
            }
        }
    }
}
