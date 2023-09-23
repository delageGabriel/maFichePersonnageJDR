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
        public static FormulaireAttributs GetAttributs(TabControl controlParent, TabPage page)
        {
            Console.WriteLine("########### Méthode GetAttributs — ###########");

            FormulaireAttributs formulaireAttributs = new FormulaireAttributs();
            AttributsModel attributsModel = new AttributsModel();
            List<CheckBox> checkBoxes = new List<CheckBox>();

            try
            {
                List<AttributsModel> attributsList = attributsModel.GetListAttributs();

                if (attributsList != null)
                {
                    // Coordonnées qui gèrent la localisation
                    int x = 10;
                    int y = 5;
                    int indexOfTabPage = controlParent.TabPages.IndexOfKey(page.Name);

                    // NOM
                    Label lblNom = new Label();
                    lblNom.Name = "lblNom" + page.Text;
                    lblNom.Location = new Point(x + 25, y);
                    lblNom.Text = "Nom";
                    lblNom.Font = new Font(lblNom.Font, FontStyle.Underline);

                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblNom);

                    y += 30;

                    // On ajoute tous les attributs dans la groupBox
                    foreach (AttributsModel attributs in attributsList)
                    {
                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = attributs.NomAttribut;
                        linkLabel.Name = ("lnkLbl" + attributs.NomAttribut).Trim();
                        linkLabel.Location = new Point(x + 25, y);
                        linkLabel.AutoSize = true;
                        linkLabel.LinkClicked += formulaireAttributs.linkLabelAttribut_LinkClicked;

                        controlParent.TabPages[indexOfTabPage].Controls.Add(linkLabel);

                        y += 25;
                    }
                }

                return formulaireAttributs;
            }
            catch (Exception e)
            {
                throw e;
            }
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
                return "Nom: " + attributsToGet.NomAttribut + ", " + "Description: " + attributsToGet.DescriptionAttribut + ", " + "Type: " + attributsToGet.TypeAttribut + ", " + "Notes: " + attributsToGet.NoteAttribut;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    
        /// <summary>
        /// Permet d'ajouter un nouvelle attribut à un personnage
        /// </summary>
        /// <param name="idAttribut"></param>
        /// <param name="idPersonnage"></param>
        public static void AddNewAttributToPersonnage(int idAttribut, int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode AddNewAttributToPersonnage — Attribut ajouté au personnage : ID ATTRIBUT : {0}, " +
                "ID PERSONNAGE : {1} ###########", idAttribut.ToString(), idPersonnage.ToString()));

            AttributsPersonnageModel attributsPersonnageModel = new AttributsPersonnageModel();

            try
            {
                attributsPersonnageModel.AddAttributToPersonnage(idAttribut, idPersonnage);
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
    }
}
