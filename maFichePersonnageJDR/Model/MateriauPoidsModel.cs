using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class MateriauPoidsModel
    {
        public string GetWeightMateriauByNameAndQuality(int qualite, string nomMateriau)
        {
            string materiauWeight = string.Empty;

            try
            {
                SQLiteCommand command = new SQLiteCommand("SELECT mp.poids " +
                    "FROM MATERIAUX_POIDS AS mp " +
                    "JOIN MATERIAUX AS m " +
                    "ON m.id_materiau = mp.id_materiau " +
                    "WHERE mp.qualite = @qualite " +
                    "AND m.nom_materiau = @nomMateriau; ", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@qualite", qualite);
                command.Parameters.AddWithValue("@nomMateriau", nomMateriau);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        materiauWeight = reader.IsDBNull(0) ? "" : reader.GetValue(0).ToString();
                    }
                }
                return materiauWeight;
            }
            catch
            {
                throw;
            }
        }
    }
}
