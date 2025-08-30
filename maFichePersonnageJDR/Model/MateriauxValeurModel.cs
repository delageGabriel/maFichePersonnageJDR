using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class MateriauxValeurModel
    {
        public int IdMateriau { get; set; }
        public int Qualite { get; set; }
        public float Valeur { get; set; }

        public string GetValueMateriauByNameAndQuality(int qualite, string nomMateriau)
        {
            string materiauValue = string.Empty;

            try
            {
                SQLiteCommand command = new SQLiteCommand("SELECT mv.valeur " +
                    "FROM MATERIAUX_VALEUR AS mv " +
                    "JOIN MATERIAUX AS m " +
                    "ON m.id_materiau = mv.id_materiau " +
                    "WHERE mv.qualite = @qualite " +
                    "AND m.nom_materiau = @nomMateriau; ", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@qualite", qualite);
                command.Parameters.AddWithValue("@nomMateriau", nomMateriau);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        materiauValue = reader.IsDBNull(0) ? "" : reader.GetValue(0).ToString();
                    }

                }
                return materiauValue;
            }
            catch
            {
                throw;
            }
        }
    }
}
