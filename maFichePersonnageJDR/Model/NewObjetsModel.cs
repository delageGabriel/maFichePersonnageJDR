using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Classe;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class NewObjetsModel
    {
        public List<string> GetObjetsNamesByType(string type)
        {
            List<string> namesObjet = new List<string>();
            type = type.Replace(type, "%" + type + "%");

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT nom_objet " +
                    "FROM OBJETS " +
                    "WHERE type_objet LIKE @type;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@type", type);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        namesObjet.Add(reader.GetString(0));
                    }
                }

                return namesObjet;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetObjetTypeByName(string name)
        {
            string objetType = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT type_objet " +
                    "FROM OBJETS " +
                    "WHERE nom_objet = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        objetType = reader.GetString(0);
                    }
                }

                return objetType;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetObjetPoidsByName(string name)
        {
            string objetPoids = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT poids_objet " +
                    "FROM OBJETS " +
                    "WHERE nom_objet = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        objetPoids = Convert.ToDouble(reader["poids_objet"]).ToString();
                    }
                }

                return objetPoids;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetObjetValeurByName(string name)
        {
            string objetValeur = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT valeur_objet " +
                    "FROM OBJETS " +
                    "WHERE nom_objet = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        objetValeur = Convert.ToInt32(reader["valeur_objet"]).ToString();
                    }
                }

                return objetValeur;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetObjetConsommableByName(string name)
        {
            string objetConsommable = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT consommable_objet " +
                    "FROM OBJETS " +
                    "WHERE nom_objet = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        objetConsommable = reader.GetString(0);
                    }
                }

                return objetConsommable;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetObjetEffectByName(string name)
        {
            string objetEffet = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT effet_objet " +
                    "FROM OBJETS " +
                    "WHERE nom_objet = @name;",
                DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        objetEffet = reader.GetString(0);
                    }
                }

                return objetEffet;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
