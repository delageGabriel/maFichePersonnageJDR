using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Classe;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Model
{
    class ClassesJeuxModel
    {
        public int IdAptitudes { get; set; }
        public string Classe { get; set; }
        public int Niveau { get; set; }
        public string Nom { get; set; }
        public int Seuil { get; set; }

        public List<string> GetNameClasse()
        {
            List<string> classesSortsAptitudes = new List<string>();

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT DISTINCT classe " +
                    "FROM JEUX_SORTS_APTITUDES " +
                    "ORDER BY classe ASC; ", 
                    DatabaseConnection.Instance.GetConnection());

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClassesJeuxModel classesJeux = new ClassesJeuxModel();

                        classesJeux.Classe = reader.GetString(0);

                        classesSortsAptitudes.Add(classesJeux.Classe);
                    }
                }

                return classesSortsAptitudes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<string> GetNameAptitudeSortByClasseName(string name)
        {
            List<string> classesSortsAptitudes = new List<string>();

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT nom " +
                    "FROM JEUX_SORTS_APTITUDES " +
                    "WHERE classe = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClassesJeuxModel classesJeux = new ClassesJeuxModel();

                        classesJeux.Nom = reader.GetString(0);

                        classesSortsAptitudes.Add(classesJeux.Nom);
                    }
                }

                return classesSortsAptitudes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<int> GetSeuilAptitudeSortByClasseName(string name)
        {
            List<int> classesSortsAptitudes = new List<int>();

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();

                SQLiteCommand command = new SQLiteCommand(
                    "SELECT seuil " +
                    "FROM JEUX_SORTS_APTITUDES " +
                    "WHERE classe = @name; ",
                    DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@name", name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClassesJeuxModel classesJeux = new ClassesJeuxModel();

                        classesJeux.Seuil = reader.GetInt32(0);

                        classesSortsAptitudes.Add(classesJeux.Seuil);
                    }
                }

                return classesSortsAptitudes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
