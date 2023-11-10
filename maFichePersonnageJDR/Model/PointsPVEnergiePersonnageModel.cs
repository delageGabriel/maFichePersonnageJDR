﻿using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class PointsPVEnergiePersonnageModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idPointsCaracteristiquesPersonnage;
        private int idPersonnage;
        private int nombrePV;
        private int nombreEnergie;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdPointsCaracteristiquesPersonnage { get => idPointsCaracteristiquesPersonnage; set => idPointsCaracteristiquesPersonnage = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int NombrePV { get => nombrePV; set => nombrePV = value; }
        public int NombreEnergie { get => nombreEnergie; set => nombreEnergie = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <param name="nombrePV"></param>
        /// <param name="nombreEnergie"></param>
        public void SavePVEnergiePersonnage(int idPersonnage, int nombrePV, int nombreEnergie)
        {
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO POINTS_PV_ENERGIE_PERSONNAGE (id_personnage, nombre_points_energie, nombre_points_pv) " +
                    "VALUES ({0}, {1}, {2})", idPersonnage, nombreEnergie, nombrePV), DatabaseConnection.Instance.GetConnection());

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static int GetValuePVEnergie(string nomColonne, int idPersonnage)
        {
            int defautValue = 0;

            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand($"SELECT {nomColonne} FROM POINTS_PV_ENERGIE_PERSONNAGE " +
                    "WHERE id_personnage = @id_personnage", connection);
                command.Parameters.AddWithValue("@id_personnage", idPersonnage);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }

                return defautValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
