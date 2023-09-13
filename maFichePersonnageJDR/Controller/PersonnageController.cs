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
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        public static void CreatePersonnage(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode CreatePersonnage — Personnage créé : idPersonnage : {0} ###########", idPersonnage.ToString()));

            CreationPersonnageModel personnageToCreate = new CreationPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                personnageToCreate.CreatePersonnage(idPersonnage);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

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
                return personnageToSave.GetIdByNameAndSurname(prenomPersonnage, nomPersonnage);               
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
    }
}
