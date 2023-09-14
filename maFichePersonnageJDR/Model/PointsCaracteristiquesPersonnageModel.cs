﻿using maFichePersonnageJDR.Classe;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Model
{
    class PointsCaracteristiquesPersonnageModel
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idPointsCaracteristiquesPersonnage;
        private int idPersonnage;
        private int nombrePhysique;
        private int nombreMental;
        private int nombreSocial;

        /// <summary>
        /// Accesseurs et mutateurs
        /// </summary>
        public int IdPointsCaracteristiquesPersonnage { get => idPointsCaracteristiquesPersonnage; set => idPointsCaracteristiquesPersonnage = value; }
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public int NombrePhysique { get => nombrePhysique; set => nombrePhysique = value; }
        public int NombreMental { get => nombreMental; set => nombreMental = value; }
        public int NombreSocial { get => nombreSocial; set => nombreSocial = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <param name="nombrePhysique"></param>
        /// <param name="nombreMental"></param>
        /// <param name="nombreSocial"></param>
        public void SaveCaracteristiquesPersonnage(int idPersonnage, int nombrePhysique, int nombreMental, int nombreSocial)
        {
            try
            {
                SQLiteConnection connection = DatabaseConnection.Instance.GetConnection();
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("INSERT INTO POINTS_CARACTERISTIQUES_PERSONNAGE (id_personnage, nombre_physique, nombre_mental, " +
                    "nombre_social) " +
                    "VALUES ({0}, {1}, {2}, {3})", idPersonnage, nombrePhysique, nombreMental, nombreSocial), connection);

                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
