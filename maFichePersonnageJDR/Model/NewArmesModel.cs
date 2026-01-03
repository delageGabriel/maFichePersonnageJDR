using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Classe;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class NewArmesModel
    {
        public List<string> GetArmeNamesByType(string type)
        {
            List<string> namesArme = new List<string>();
            type = type.Replace(type, "%" + type + "%");

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT nom_arme " +
                    "FROM NEW_ARMES " +
                    "WHERE type_arme LIKE @type;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@type", type);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        namesArme.Add(reader.GetString(0));
                    }
                }

                return namesArme;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
