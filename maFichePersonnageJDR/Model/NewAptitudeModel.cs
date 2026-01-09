using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Classe;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class NewAptitudeModel
    {
        public string GetDomaineAptitudeByName(string name)
        {
            string domaineAptitude = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT domaine " +
                    "FROM APTITUDES " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        domaineAptitude = reader.GetString(0);
                    }
                }

                return domaineAptitude;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetTypeAptitudeByName(string name)
        {
            string typeAptitude = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT type " +
                    "FROM APTITUDES " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        typeAptitude = reader.GetString(0);
                    }
                }

                return typeAptitude;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetPorteeAptitudeByName(string name)
        {
            string porteeAptitude = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT portee " +
                    "FROM APTITUDES " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        porteeAptitude = reader.GetString(0);
                    }
                }

                return porteeAptitude;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetDureeAptitudeByName(string name)
        {
            string dureeAptitude = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT duree " +
                    "FROM APTITUDES " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dureeAptitude = reader.GetString(0);
                    }
                }

                return dureeAptitude;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetLimitesUsagesAptitudeByName(string name)
        {
            string limitesUsagesAptitude = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT limite_usage " +
                    "FROM APTITUDES " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        limitesUsagesAptitude = reader.GetString(0);
                    }
                }

                return limitesUsagesAptitude;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetJetSauvegardeAptitudeByName(string name)
        {
            string jetSauvegardeAptitude = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT jet_sauvegarde " +
                    "FROM APTITUDES " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jetSauvegardeAptitude = reader.GetString(0);
                    }
                }

                return jetSauvegardeAptitude;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetEffetsAptitudeByName(string name)
        {
            string effetsAptitude = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT effets " +
                    "FROM APTITUDES " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        effetsAptitude = reader.GetString(0);
                    }
                }

                return effetsAptitude;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
