using maFichePersonnageJDR.Formulaires;
using maFichePersonnageJDR.Model;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Controller
{
    class PersonnageController
    {

        /// <summary>
        /// Méthode qui permet de sauvegarder les informations générales d'un personnage
        /// </summary>
        /// <param name="prenomPersonnage"></param>
        /// <param name="nomPersonnage"></param>
        /// <param name="racePersonnage"></param>
        /// <param name="niveauPersonnage"></param>
        /// <param name="sexePersonnage"></param>
        /// <param name="experiencePersonnage"></param>
        /// <param name="languesPersonnage"></param>
        /// <param name="avatarPersonnage"></param>
        /// <param name="histoirePersonnage"></param>
        public static void SaveInformationsPersonnage(string prenomPersonnage, string nomPersonnage, string racePersonnage, int niveauPersonnage,
            string sexePersonnage, int experiencePersonnage, string languesPersonnage, string avatarPersonnage, string histoirePersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode SaveInformationsPersonnage — Personnage créé : Prénom : {0} ###########", prenomPersonnage));

            PersonnageModel personnageToSave = new PersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                personnageToSave.SaveInformationsPersonnage(prenomPersonnage, nomPersonnage, racePersonnage, niveauPersonnage, sexePersonnage, experiencePersonnage,
                    languesPersonnage, avatarPersonnage, histoirePersonnage);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void SaveBoursePersonnage(int idPersonnage, int pieceOr, int pieceArgent, int pieceCuivre)
        {
            Console.WriteLine(string.Format("########### Méthode SaveBoursePersonnage — ID Personnage : {0} ###########", idPersonnage));

            BoursePersonnageModel boursePersonnage = new BoursePersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                boursePersonnage.SaveMonnaiePersonnage(idPersonnage, pieceOr, pieceArgent, pieceCuivre);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomPersonnage"></param>
        /// <param name="prenomPersonnage"></param>
        /// <returns></returns>
        public static int GetIdPersonnageByNameAndSurname(string nomPersonnage, string prenomPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetIdPersonnageByNameAndSurname — Personnage recherchée : Prénom : {0}; Nom : {1} ###########", prenomPersonnage, nomPersonnage));

            PersonnageModel personnageToSave = new PersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return personnageToSave.GetIdByNameAndSurname(nomPersonnage, prenomPersonnage);               
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// On vérifie en base si le personnage existe déjà
        /// </summary>
        /// <param name="nomPersonnage"></param>
        /// <param name="prenomPersonnage"></param>
        /// <returns></returns>
        public static bool CheckPersonnageExist(string nomPersonnage, string prenomPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode CheckPersonnageExist — Personnage recherchée : Prénom : {0}; Nom : {1} ###########", prenomPersonnage, nomPersonnage));

            PersonnageModel personnageToCheck = new PersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return personnageToCheck.CheckIfPersonnageExist(nomPersonnage, prenomPersonnage);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne le prénom du personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static string GetPrenomPersonnage(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetPrenomPersonnage — Personnage recherchée : ID : {0} ###########", idPersonnage));

            PersonnageModel personnagePrenom = new PersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return personnagePrenom.GetPersonnage(idPersonnage).PrenomPersonnage;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne le nom du personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static string GetNomPersonnage(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetNomPersonnage — Personnage recherchée : ID : {0} ###########", idPersonnage));

            PersonnageModel personnagePrenom = new PersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return personnagePrenom.GetPersonnage(idPersonnage).NomPersonnage;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne la race du personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static string GetRacePersonnage(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetRacePersonnage — Personnage recherchée : ID : {0} ###########", idPersonnage));

            PersonnageModel personnagePrenom = new PersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return personnagePrenom.GetPersonnage(idPersonnage).RacePersonnage;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne le niveau du personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static int GetNiveauPersonnage(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetNiveauPersonnage — Personnage recherchée : ID : {0} ###########", idPersonnage));

            PersonnageModel personnagePrenom = new PersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return personnagePrenom.GetPersonnage(idPersonnage).NiveauPersonnage;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne le sexe du personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static string GetSexePersonnage(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetSexePersonnage — Personnage recherchée : ID : {0} ###########", idPersonnage));

            PersonnageModel personnagePrenom = new PersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return personnagePrenom.GetPersonnage(idPersonnage).SexePersonnage;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne le sexe du personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static int GetExperiencePersonnage(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetExperiencePersonnage — Personnage recherchée : ID : {0} ###########", idPersonnage));

            PersonnageModel personnagePrenom = new PersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return personnagePrenom.GetPersonnage(idPersonnage).ExperiencePersonnage;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne les langues du personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static string GetLanguesPersonnage(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetLanguesPersonnage — Personnage recherchée : ID : {0} ###########", idPersonnage));

            PersonnageModel personnagePrenom = new PersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return personnagePrenom.GetPersonnage(idPersonnage).LanguesPersonnages;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne l'histoire du personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static string GetHistoirePersonnage(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetHistoirePersonnage — Personnage recherchée : ID : {0} ###########", idPersonnage));

            PersonnageModel personnagePrenom = new PersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return personnagePrenom.GetPersonnage(idPersonnage).HistoirePersonnage;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
