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

        public string GetArmeTypeByName(string name)
        {
            string typeArme = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT type_arme " +
                    "FROM NEW_ARMES " +
                    "WHERE nom_arme = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        typeArme = reader.GetString(0);
                    }
                }

                return typeArme;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmePrerequisByName(string name)
        {
            string prerequisArme = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT pre_requis_utilisation_arme " +
                    "FROM NEW_ARMES " +
                    "WHERE nom_arme = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        prerequisArme = reader.GetString(0);
                    }
                }

                return prerequisArme;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmeMainsByName(string name)
        {
            string mainsArme = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT mains_arme " +
                    "FROM NEW_ARMES " +
                    "WHERE nom_arme = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mainsArme = reader.GetString(0);
                    }
                }

                return mainsArme;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmePorteeByName(string name)
        {
            string porteeArme = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT portee_arme " +
                    "FROM NEW_ARMES " +
                    "WHERE nom_arme = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        porteeArme = reader.GetString(0);
                    }
                }

                return porteeArme;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmePoidsByName(string name)
        {
            string poidsArme = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT poids_arme " +
                    "FROM NEW_ARMES " +
                    "WHERE nom_arme = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        poidsArme = Convert.ToInt32(reader["poids_arme"]).ToString();
                    }
                }

                return poidsArme;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmeDegatsByName(string name)
        {
            string degatsArme = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT degats_arme " +
                    "FROM NEW_ARMES " +
                    "WHERE nom_arme = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        degatsArme = reader.GetString(0);
                    }
                }

                return degatsArme;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmeJetsDegatsByName(string name)
        {
            string jetDegatArme = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT jet_degats_arme " +
                    "FROM NEW_ARMES " +
                    "WHERE nom_arme = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jetDegatArme = reader.GetString(0);
                    }
                }

                return jetDegatArme;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmeValeurByName(string name)
        {
            string valeurArme = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT valeur_arme " +
                    "FROM NEW_ARMES " +
                    "WHERE nom_arme = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        valeurArme = Convert.ToInt32(reader["valeur_arme"]).ToString();
                    }
                }

                return valeurArme;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetArmeEffetsByName(string name)
        {
            string effetArme = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT effet_arme " +
                    "FROM NEW_ARMES " +
                    "WHERE nom_arme = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        effetArme = reader.GetString(0);
                    }
                }

                return effetArme;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
