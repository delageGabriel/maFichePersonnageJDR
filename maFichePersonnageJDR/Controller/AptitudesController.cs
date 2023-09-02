using maFichePersonnageJDR.Formulaires;
using maFichePersonnageJDR.Model;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Controller
{
    class AptitudesController
    {
        /// <summary>
        /// Méthode qui se connecte à la base de données pour trouver toutes les armes et les ajouter
        /// à chaque pages du TabControl parent en fonction du type de l'arme
        /// </summary>
        /// <param name="typeAptitude">le type de l'arme</param>
        /// <param name="controlParent">le TabControl parent</param>
        /// <param name="tabPage">la page où ajouter toutes les armes</param>
        public static void GetAptitudesByType(string typeAptitude, TabControl controlParent, TabPage tabPage)
        {
            Console.WriteLine(string.Format("########### Méthode GetAptitudesByType — Type d'aptitudes : {0} ###########", typeAptitude));

            FormulaireMagieEtAptitudes formulaireMagieEtAptitudes = new FormulaireMagieEtAptitudes();
            AptitudesModel aptitudeModel = new AptitudesModel();

            try
            {
                List<AptitudesModel> aptitudesList = aptitudeModel.GetAptitudesModels(typeAptitude);

                if (aptitudeModel != null)
                {
                    /// Les coordonnées qui gèrent tout les localisation
                    /// Et l'index de la tabpage
                    int y = 10;
                    int x = 20;
                    int indexOfTabPage = controlParent.TabPages.IndexOfKey(tabPage.Name);

                    // Label nom
                    Label lblNom = new Label();
                    lblNom.Name = "lblNom" + tabPage.Text;
                    lblNom.Location = new Point(x, y);
                    lblNom.Text = "Nom";
                    lblNom.Font = new Font(lblNom.Font, FontStyle.Underline);

                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblNom);

                    y += 30;

                    /// Pour chaque type d'arme on les ajoute dans les tabpages
                    foreach (AptitudesModel aptitude in aptitudesList)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Location = new Point(1, y - 5);
                        checkBox.Name = ("chck" + aptitude.NomAptitude).Trim();

                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = aptitude.NomAptitude;
                        linkLabel.Name = ("lnkLbl" + aptitude.NomAptitude).Trim();
                        linkLabel.Location = new Point(x, y);
                        linkLabel.AutoSize = true;
                        linkLabel.LinkClicked += formulaireMagieEtAptitudes.linkLabelAptitude_LinkClicked;

                        controlParent.TabPages[indexOfTabPage].Controls.Add(linkLabel);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(checkBox);

                        y += 25;
                    }
                }
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
        /// <param name="nomMagie">le nom de l'arme à modifier</param>
        public static void GetAptitudeByName(FormulaireApercuMagieEtAptitudes formulaire, string nomAptitude, string typeAptitude)
        {
            #region Initialisation des variables
            AptitudesModel aptitudeModel = new AptitudesModel();
            #endregion

            try
            {
                // Puis on y ajoute les valeurs de l'arme sélectionnée.
                AptitudesModel aptitudeToGet = aptitudeModel.GetAptitudesByName(nomAptitude);

                formulaire.TextLblNomMagieAptitude = aptitudeToGet.NomAptitude;
                formulaire.TextLblTypeMagieAptitude = typeAptitude;
                formulaire.TextLblCoutMagieAptitude = aptitudeToGet.CoutAptitude.ToString();
                formulaire.TextLblNiveauMagieAptitude = aptitudeToGet.NiveauAptitude.ToString();
                formulaire.RchTextBxDescrMagieEtAptitude.Text = aptitudeToGet.DescriptionAptitude;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
