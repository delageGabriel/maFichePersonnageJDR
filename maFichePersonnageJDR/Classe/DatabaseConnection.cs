using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace maFichePersonnageJDR.Classe
{
    class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private SQLiteConnection connection;

        private DatabaseConnection()
        {
            connection = new SQLiteConnection(@"Data Source =BDD\20221227_base_fiche_perso.db; Version = 3;");
            connection.Open();
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DatabaseConnection();
                }

                return instance;
            }
        }

        public SQLiteConnection GetConnection()
        {
            return connection;
        }

        public void CloseConnection()
        {
            connection.Close();
            connection = null;
            instance = null;
        }
    }
}
