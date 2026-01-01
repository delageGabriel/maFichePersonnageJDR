using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Classe;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class SortsModel
    {
        public string GetDomaineSortByName(string name)
        {
            string domaineSort = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT domaine " +
                    "FROM SORTS " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        domaineSort = reader.GetString(0);
                    }
                }

                return domaineSort;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetTypeSortByName(string name)
        {
            string typeSort = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT type " +
                    "FROM SORTS " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        typeSort = reader.GetString(0);
                    }
                }

                return typeSort;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetPorteeSortByName(string name)
        {
            string porteeSort = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT type " +
                    "FROM SORTS " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        porteeSort = reader.GetString(0);
                    }
                }

                return porteeSort;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetDureeSortByName(string name)
        {
            string dureeSort = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT duree " +
                    "FROM SORTS " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dureeSort = reader.GetString(0);
                    }
                }

                return dureeSort;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetLimitesUsageSortByName(string name)
        {
            string limitesUsagesSort = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT limite_usage " +
                    "FROM SORTS " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        limitesUsagesSort = reader.GetString(0);
                    }
                }

                return limitesUsagesSort;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetJetSauvegardeSortByName(string name)
        {
            string jetSauvegardeSort = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT jet_sauvegarde " +
                    "FROM SORTS " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jetSauvegardeSort = reader.GetString(0);
                    }
                }

                return jetSauvegardeSort;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetTempsIncantationSortByName(string name)
        {
            string tempsIncantationSort = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT temps_incantation " +
                    "FROM SORTS " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tempsIncantationSort = reader.GetString(0);
                    }
                }

                return tempsIncantationSort;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetComposantesSortByName(string name)
        {
            string composantesSort = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT composantes " +
                    "FROM SORTS " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        composantesSort = reader.GetString(0);
                    }
                }

                return composantesSort;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetIngredientsSortByName(string name)
        {
            string ingredientsSort = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT ingredients " +
                    "FROM SORTS " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ingredientsSort = reader.GetString(0);
                    }
                }

                return ingredientsSort;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetIntentionsMagiquesSortByName(string name)
        {
            string intentionsMagiquesSort = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT intentions_magiques " +
                    "FROM SORTS " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        intentionsMagiquesSort = reader.GetString(0);
                    }
                }

                return intentionsMagiquesSort;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string GetEffetsSortByName(string name)
        {
            string effetsSort = string.Empty;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT effets " +
                    "FROM SORTS " +
                    "WHERE nom = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        effetsSort = reader.GetString(0);
                    }
                }

                return effetsSort;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
