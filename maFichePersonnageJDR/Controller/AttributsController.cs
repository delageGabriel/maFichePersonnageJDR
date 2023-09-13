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
    }
}
