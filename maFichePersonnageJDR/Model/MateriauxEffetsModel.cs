using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
namespace maFichePersonnageJDR.Model
{
    class MateriauxEffetsModel
    {
        public int IdMateriau { get; set; }
        public int IdEffet { get; set; }
        public int Qualite { get; set; }
        public int Valeur { get; set; }

        public Dictionary<int, List<string>> GetMateriauxEffetsByNameCodeValueAndQuality(int qualite, string nomMateriau)
        {
            Dictionary<int, List<string>> materiauxEffetsList = new Dictionary<int, List<string>>();
            int compteurId = 0;

            try
            {
                SQLiteCommand command = new SQLiteCommand("SELECT m.nom_materiau," +
                    "       r.code," +
                    "       me.valeur," +
                    "       me.qualite " +
                    "FROM MATERIAUX AS m " +
                    "JOIN MATERIAUX_EFFETS AS me" +
                    "  ON me.id_materiau = m.id_materiau " +
                    "JOIN REF_EFFETS AS r" +
                    "  ON me.id_effet = r.id_effet " +
                    "WHERE me.qualite = @qualite" +
                    "  AND m.nom_materiau = @nomMateriau; ", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@qualite", qualite);
                command.Parameters.AddWithValue("@nomMateriau", nomMateriau);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        compteurId++;
                        List<string> listeMateriauxEffets = new List<string>();

                        listeMateriauxEffets.Add(reader.GetString(0));
                        listeMateriauxEffets.Add(reader.GetString(1));
                        listeMateriauxEffets.Add(reader.IsDBNull(2) ? "" : reader.GetValue(2).ToString());
                        listeMateriauxEffets.Add(reader.IsDBNull(3) ? "" : reader.GetValue(3).ToString());

                        materiauxEffetsList.Add(compteurId, listeMateriauxEffets);
                    }
                }

                return materiauxEffetsList;
            }
            catch
            {
                throw;
            }
        }
    }
}
