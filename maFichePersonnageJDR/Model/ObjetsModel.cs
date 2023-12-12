﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using maFichePersonnageJDR.Classe;

namespace maFichePersonnageJDR.Model
{
    class ObjetsModel
    {
        /// <summary>
        /// Attributs
        /// </summary>
        private int idObjet;
        private string nomObjet;
        private double poidsObjet;
        private int valeurObjet;
        private string descriptionObjet;
        private string descriptionCourteObjet;
        private string typeObjet;
        private string consommableObjet;
        private string specialObjet;

        /// <summary>
        /// Accesseurs et Mutateurs
        /// </summary>
        public int IdObjet { get => idObjet; set => idObjet = value; }
        public string NomObjet { get => nomObjet; set => nomObjet = value; }
        public double PoidsObjet { get => poidsObjet; set => poidsObjet = value; }
        public int ValeurObjet { get => valeurObjet; set => valeurObjet = value; }
        public string DescriptionObjet { get => descriptionObjet; set => descriptionObjet = value; }
        public string DescriptionCourteObjet { get => descriptionCourteObjet; set => descriptionCourteObjet = value; }
        public string TypeObjet { get => typeObjet; set => typeObjet = value; }
        public string ConsommationObjet { get => consommableObjet; set => consommableObjet = value; }
        public string SpecialObjet { get => specialObjet; set => specialObjet = value; }
        public List<ObjetsModel> GetListObjetsByTypes(string typeObjet)
        {
            #region Initialisation variables
            List<ObjetsModel> objetsModels = new List<ObjetsModel>();
            #endregion

            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM OBJETS WHERE type_objet = @typeObjet", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@typeObjet", typeObjet);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ObjetsModel objetsModel = new ObjetsModel();

                        objetsModel.IdObjet = reader.GetInt32(0);
                        objetsModel.NomObjet = reader.GetString(1);
                        objetsModel.PoidsObjet = reader.GetDouble(2);
                        objetsModel.ValeurObjet = reader.GetInt32(3);
                        objetsModel.DescriptionObjet = reader.GetString(4);
                        objetsModel.DescriptionCourteObjet = reader.GetString(5);
                        objetsModel.TypeObjet = reader.GetString(6);
                        objetsModel.ConsommationObjet = reader.GetString(7);
                        objetsModel.SpecialObjet = reader.GetString(8);

                        objetsModels.Add(objetsModel);
                    }
                }

                return objetsModels;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Permet d'obtenir une armure par rapport à son nom
        /// </summary>
        /// <param name="nomObjet"></param>
        /// <returns></returns>
        public ObjetsModel GetObjetByName(string nomObjet)
        {
            ObjetsModel objetModel = new ObjetsModel();
            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM OBJETS WHERE nom_objet = @nomObjet", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@nomObjet", nomObjet);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ObjetsModel objet = new ObjetsModel();

                        objet.IdObjet = reader.GetInt32(0);
                        objet.NomObjet = reader.GetString(1);
                        objet.PoidsObjet = reader.GetDouble(2);
                        objet.ValeurObjet = reader.GetInt32(3);
                        objet.DescriptionObjet = reader.GetString(4);
                        objet.TypeObjet = reader.GetString(5);
                        objet.ConsommationObjet = reader.GetString(6);
                        objet.SpecialObjet = reader.GetString(7);

                        objetModel = objet;
                    }
                }

                return objetModel;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomArmure"></param>
        /// <returns></returns>
        public int GetObjetIdByName(string nomObjet)
        {
            int idObjet = 0;

            try
            {
                // Commande
                SQLiteCommand command = new SQLiteCommand(string.Format("SELECT id_objets FROM OBJETS WHERE nom_objet = '{0}'", nomObjet), DatabaseConnection.Instance.GetConnection());

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idObjet = reader.GetInt32(0);
                    }
                }

                return idObjet;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne le nom de l'arme par son id
        /// </summary>
        /// <param name="idArme"></param>
        /// <returns></returns>
        public string GetObjetNameById(int idObjet)
        {
            string nomObjet = string.Empty;

            try
            {
                SQLiteCommand command = new SQLiteCommand("SELECT nom_objet " +
                    "FROM OBJETS " +
                    "WHERE id_objets = @idObjet", DatabaseConnection.Instance.GetConnection());
                command.Parameters.AddWithValue("@idObjet", idObjet);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArmuresModel armure = new ArmuresModel();

                        nomObjet = reader.GetString(0);
                    }
                }

                return nomObjet;
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }
        }
    }
}
