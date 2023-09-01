using maFichePersonnageJDR.Formulaires;
using maFichePersonnageJDR.Model;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Controller
{
    class MagieController
    {
        /// <summary>
        /// Méthode qui se connecte à la base de données pour trouver toutes les armes et les ajouter
        /// à chaque pages du TabControl parent en fonction du type de l'arme
        /// </summary>
        /// <param name="typeMagie">le type de l'arme</param>
        /// <param name="controlParent">le TabControl parent</param>
        /// <param name="tabPage">la page où ajouter toutes les armes</param>
        public static void GetMagiesByType(string typeMagie, TabControl controlParent, TabPage tabPage)
        {
            Console.WriteLine(string.Format("########### Méthode GetMagiesByType — Type de magie : {0} ###########", typeMagie));
            
            FormulaireMagieEtAptitudes formulaireMagieEtAptitudes = new FormulaireMagieEtAptitudes();
            MagieModel magieObjet = new MagieModel();

            try
            {
                List<MagieModel> magieList = magieObjet.GetMagieModels(typeMagie);

                if (magieObjet != null)
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
                    foreach (MagieModel magie in magieList)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Location = new Point(1, y - 5);
                        checkBox.Name = ("chck" + magie.NomMagie).Trim();

                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = magie.NomMagie;
                        linkLabel.Name = ("lnkLbl" + magie.NomMagie).Trim();
                        linkLabel.Location = new Point(x, y);
                        linkLabel.AutoSize = true;
                        linkLabel.LinkClicked += formulaireMagieEtAptitudes.linkLabelMagie_LinkClicked;

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
        public static void GetApercuMagie(FormulaireApercuMagieEtAptitudes formulaire, string nomMagie)
        {
            #region Initialisation des variables
            MagieModel magieModel = new MagieModel();
            #endregion

            try
            {
                // Puis on y ajoute les valeurs de l'arme sélectionnée.
                MagieModel magieToGet = magieModel.GetMagieByName(nomMagie);

                formulaire.TextLblNomMagieAptitude = magieToGet.NomMagie;
                formulaire.TextLblTypeMagieAptitude = magieToGet.TypeMagie;
                formulaire.TextLblCoutMagieAptitude = magieToGet.CoutMagie.ToString();
                formulaire.TextLblNiveauMagieAptitude = magieToGet.NiveauMagie.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Va chercher en base les informations par rapport au nom d'une armure
        /// et les affiche dans un formulaire
        /// </summary>
        /// <param name="formulaire"></param>
        /// <param name="nomArmure"></param>
        public static void GetApercuArmure(FormulaireApercuEquipement formulaire, string nomArmure)
        {
            #region Initialisation des variables
            ArmuresModel armuresModel = new ArmuresModel();
            #endregion

            try
            {
                // On commence par rendre visible les différentes label liés aux armes
                formulaire.LabelProtection.Visible = true;
                formulaire.TextLblProtection.Visible = true;
                formulaire.LabelBonus.Visible = true;
                formulaire.TextLblBonus.Visible = true;

                // Puis on y ajoute les valeurs de l'arme sélectionnée.
                ArmuresModel armureToGet = armuresModel.GetArmureByName(nomArmure);
                formulaire.TextLblNom = armureToGet.NomArmure;
                formulaire.TextLblType = armureToGet.TypeArmure;
                formulaire.TextLblPoids = armureToGet.PoidsArmure.ToString() + " kg";
                formulaire.TextLblValeur = armureToGet.ValeurArmure.ToString();
                formulaire.TextLblDescription = armureToGet.DescriptionArmure;
                formulaire.TextLblProtection.Text = armureToGet.ProtectionArmure;
                formulaire.TextLblBonus.Text = armureToGet.BonusArmure.ToString();
                formulaire.TextLblSpecial = armureToGet.SpecialArmure;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Va chercher en base les informations par rapport au nom d'un objet
        /// et les affiche dans un formulaire
        /// </summary>
        /// <param name="formulaire"></param>
        /// <param name="nomArmure"></param>
        public static void GetApercuObjet(FormulaireApercuEquipement formulaire, string objet)
        {
            #region Initialisation des variables
            ObjetsModel objetsModel = new ObjetsModel();
            #endregion

            try
            {
                // On commence par rendre visible les différentes label liés aux armes
                formulaire.LabelConsommable.Visible = true;
                formulaire.TextLblConsommable.Visible = true;

                // Puis on y ajoute les valeurs de l'arme sélectionnée.
                ObjetsModel objetToGet = objetsModel.GetObjetByName(objet);

                formulaire.TextLblNom = objetToGet.NomObjet;
                formulaire.TextLblType = objetToGet.TypeObjet;
                formulaire.TextLblPoids = objetToGet.PoidsObjet.ToString() + " kg";
                formulaire.TextLblValeur = objetToGet.ValeurObjet.ToString();
                formulaire.TextLblDescription = objetToGet.DescriptionObjet;
                formulaire.TextLblConsommable.Text = objetToGet.ConsommationObjet;
                formulaire.TextLblSpecial = objetToGet.SpecialObjet;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
