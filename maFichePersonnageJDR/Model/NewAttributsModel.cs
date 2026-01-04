using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Classe;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class NewAttributsModel
    {
        public List<string> GetAttributsNamesByType(string type)
        {
            List<string> namesAttribut = new List<string>();
            type = type.Replace(type, "%" + type + "%");

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT nom_attribut " +
                    "FROM ATTRIBUTS " +
                    "WHERE type_attribut LIKE @type;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@type", type);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        namesAttribut.Add(reader.GetString(0));
                    }
                }

                return namesAttribut;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetAttributeTypeByName(string name)
        {
            string attributType = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT type_attribut " +
                    "FROM ATTRIBUTS " +
                    "WHERE nom_attribut = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        attributType = reader.GetString(0);
                    }
                }

                return attributType;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetAttributeEffectByName(string name)
        {
            string attributEffet = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT effet_attribut " +
                    "FROM ATTRIBUTS " +
                    "WHERE nom_attribut = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        attributEffet = reader.GetString(0);
                    }
                }

                return attributEffet;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
