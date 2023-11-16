using maFichePersonnageJDR.Formulaires;
using maFichePersonnageJDR.Model;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Controller
{
    class AttributsController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, Tuple<string, string, string, string>> GetAttributes()
        {
            Console.WriteLine("########### DEBUT Méthode AttributsController.GetAttributs — ###########");
            
            Dictionary<int, Tuple<string, string, string, string>> dictionaryAttributes = new Dictionary<int, Tuple<string, string, string, string>>();
            List<AttributsModel> attributsModels = AttributsModel.GetListAttributs();

            foreach (AttributsModel attributs in attributsModels)
            {
                dictionaryAttributes.Add(attributs.IdAttribut, Tuple.Create(attributs.NomAttribut, attributs.DescriptionAttribut, attributs.TypeAttribut, attributs.NoteAttribut));
            }
            
            Console.WriteLine("########### FIN Méthode AttributsController.GetAttributs — ###########");

            return dictionaryAttributes;
        }

        /// <summary>
        /// Va chercher en base les informations par rapport au nom d'une arme
        /// et les affiche dans un formulaire
        /// </summary>
        /// <param name="formulaire">le formulaire à sauvegarder</param>
        /// <param name="nomAttribut">le nom de l'arme à modifier</param>
        public static void GetApercuAttribut(FormulaireApercuAttributs formulaire, string nomAttribut)
        {
            #region Initialisation des variables
            AttributsModel attributsModel = new AttributsModel();
            #endregion

            try
            {
                // Puis on y ajoute les valeurs de l'arme sélectionnée.
                AttributsModel attributToGet = attributsModel.GetAttributByName(nomAttribut);
                formulaire.TextLblNom = attributToGet.NomAttribut;
                formulaire.TextLblType = attributToGet.TypeAttribut;
                formulaire.TextLblDescription = attributToGet.DescriptionAttribut;
                formulaire.TextLblNote = attributToGet.NoteAttribut;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Méthode qui permet d'avoir toutes les informations d'un attribut par
        /// rapport à son nom
        /// </summary>
        /// <param name="nomAttribut"></param>
        /// <returns></returns>
        public static string GetAttributByName(string nomAttribut)
        {
            #region Initialisation des variables
            AttributsModel attributsModel = new AttributsModel();
            #endregion

            try
            {
                AttributsModel attributsToGet = attributsModel.GetAttributByName(nomAttribut);
                return attributsToGet.NomAttribut;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Dictionary<string, string> GetAttributesWithSpecification()
        {
            return AttributsModel.GetAttributesWithSpecifications();
        }
        /// <summary>
        /// Permet d'ajouter un nouvelle attribut à un personnage
        /// </summary>
        /// <param name="idAttribut"></param>
        /// <param name="idPersonnage"></param>
        public static void AddNewAttributToPersonnage(int idAttribut, int idPersonnage, string specifications)
        {
            Console.WriteLine(string.Format("########### Méthode AddNewAttributToPersonnage — Attribut ajouté au personnage : ID ATTRIBUT : {0}, " +
                "ID PERSONNAGE : {1} ###########", idAttribut.ToString(), idPersonnage.ToString()));

            AttributsPersonnageModel attributsPersonnageModel = new AttributsPersonnageModel();

            try
            {
                attributsPersonnageModel.AddAttributToPersonnage(idAttribut, idPersonnage, specifications);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Permet d'obtenir l'id d'un attribut par rapport à son nom
        /// </summary>
        /// <param name="nomAttribut"></param>
        /// <returns></returns>
        public static int GetIdAttributByName(string nomAttribut)
        {
            #region Initialisation des variables
            AttributsModel attributsModel = new AttributsModel();
            #endregion

            try
            {
                return attributsModel.GetAttributsIdByName(nomAttribut);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static List<string> GetListNomAttributs(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListNomAttributs — Personnage recherchée : ID : {0} ###########", idPersonnage));

            AttributsPersonnageModel attributsPersonnageModel = new AttributsPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return attributsPersonnageModel.GetListeNomAttributsPersonnage(idPersonnage);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<string> GetListDescriptionAttributs(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListDescriptionAttributs — Personnage recherchée : ID : {0} ###########", idPersonnage));

            AttributsPersonnageModel attributsPersonnageModel = new AttributsPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return attributsPersonnageModel.GetListeDescriptionAttributsPersonnage(idPersonnage);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<string> GetListTypeAttributs(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListTypeAttributs — Personnage recherchée : ID : {0} ###########", idPersonnage));

            AttributsPersonnageModel attributsPersonnageModel = new AttributsPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return attributsPersonnageModel.GetListeTypeAttributsPersonnage(idPersonnage);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<string> GetListNoteAttributs(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListNoteAttributs — Personnage recherchée : ID : {0} ###########", idPersonnage));

            AttributsPersonnageModel attributsPersonnageModel = new AttributsPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return attributsPersonnageModel.GetListeNotesAttributsPersonnage(idPersonnage);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static string GetPourcentagePorteurChargesLourdes(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListNoteAttributs — Personnage recherchée : ID : {0} ###########", idPersonnage));

            AttributsPersonnageModel attributsPersonnageModel = new AttributsPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return attributsPersonnageModel.GetPourcentagePorteurChargerLourde(idPersonnage);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool CheckIfPersonnageHaveAttribut(int idPersonnage, int idAttribut)
        {
            Console.WriteLine(string.Format("########### Méthode CheckIfPersonnageHaveAttribut — Personnage recherchée : ID : {0} ###########", idPersonnage));

            AttributsPersonnageModel attributsPersonnageModel = new AttributsPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return attributsPersonnageModel.CheckIfPersonnageHaveAttribut(idPersonnage, idAttribut);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
