using maFichePersonnageJDR.Formulaires;
using maFichePersonnageJDR.Model;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Controller
{
    class EquipmentController
    {
        /// <summary>
        /// Méthode qui se connecte à la base de données pour trouver toutes les armes et les ajouter
        /// à chaque pages du TabControl parent en fonction du type de l'arme
        /// </summary>
        /// <param name="typeArme">le type de l'arme</param>
        /// <param name="controlParent">le TabControl parent</param>
        /// <param name="tabPage">la page où ajouter toutes les armes</param>
        public static void GetArmesByType(string typeArme, TabControl controlParent, TabPage tabPage)
        {
            Console.WriteLine(string.Format("########### Méthode GetArmesByType — Type d'arme : {0} ###########", typeArme));
            FormulaireEquipments formulaireEquipments = new FormulaireEquipments();
            ArmesModel armesModel = new ArmesModel();

            try
            {
                List<ArmesModel> armesModels = armesModel.GetListArmesByTypes(typeArme);

                if (armesModel != null)
                {
                    /// Les coordonnées qui gèrent tout les localisation
                    /// Et l'index de la tabpage
                    int y = 10;
                    int x = 10;
                    int indexOfTabPage = controlParent.TabPages.IndexOfKey(tabPage.Name);

                    // Label nom
                    Label lblNom = new Label();
                    lblNom.Name = "lblNom" + tabPage.Text;
                    lblNom.Location = new Point(x + 25, y);
                    lblNom.Text = "Nom";
                    lblNom.Font = new Font(lblNom.Font, FontStyle.Underline);

                    // Label Quantité
                    Label lblQte = new Label();
                    lblQte.Name = "lblQte" + tabPage.Text;
                    lblQte.Location = new Point(x + (lblNom.Width + 25), y);
                    lblQte.Text = "Quantité";
                    lblQte.Font = new Font(lblNom.Font, FontStyle.Underline);

                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblNom);
                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblQte);

                    y += 30;

                    /// Pour chaque type d'arme on les ajoute dans les tabpages
                    foreach (ArmesModel armes in armesModels)
                    {
                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = armes.NomArme;
                        linkLabel.Name = ("lnkLbl" + armes.NomArme).Trim();
                        linkLabel.Location = new Point(x + 25, y);
                        linkLabel.AutoSize = true;
                        linkLabel.LinkClicked += formulaireEquipments.linkLabelArme_LinkClicked;
                        linkLabel.Tag = armes.NomArme;

                        NumericUpDown numericUpDown = new NumericUpDown();
                        numericUpDown.Location = new Point(x + (linkLabel.Width + 25), y - 3);
                        numericUpDown.Maximum = 99;
                        numericUpDown.Minimum = 0;
                        numericUpDown.Width = 40;
                        numericUpDown.Tag = armes.NomArme;

                        controlParent.TabPages[indexOfTabPage].Controls.Add(linkLabel);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(numericUpDown);

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
        /// Méthode qui se connecte à la base de données pour trouver toutes les armures et les ajouter
        /// à chaque pages du TabControl parent en fonction du type de l'armure
        /// </summary>
        /// <param name="typeArmure"></param>
        /// <param name="controlParent"></param>
        /// <param name="tabPage"></param>
        public static void GetArmuresByType(string typeArmure, TabControl controlParent, TabPage tabPage)
        {
            Console.WriteLine(string.Format("########### Méthode GetArmuresByType — Type d'armure : {0} ###########", typeArmure));

            FormulaireEquipments formulaireEquipments = new FormulaireEquipments();
            ArmuresModel armuresModel = new ArmuresModel();

            try
            {
                List<ArmuresModel> armuresModels = armuresModel.GetListArmuresByTypes(typeArmure);

                if (armuresModels != null)
                {
                    /// Les coordonnées qui gèrent tout les localisation
                    /// Et l'index de la tabpage
                    int y = 10;
                    int x = 10;
                    int indexOfTabPage = controlParent.TabPages.IndexOfKey(tabPage.Name);

                    // Label nom
                    Label lblNom = new Label();
                    lblNom.Name = "lblNom" + tabPage.Text;
                    lblNom.Location = new Point(x + 25, y);
                    lblNom.Text = "Nom";
                    lblNom.Font = new Font(lblNom.Font, FontStyle.Underline);

                    // Label Quantité
                    Label lblQte = new Label();
                    lblQte.Name = "lblQte" + tabPage.Text;
                    lblQte.Location = new Point(x + (lblNom.Width + 30), y);
                    lblQte.Text = "Quantité";
                    lblQte.Font = new Font(lblNom.Font, FontStyle.Underline);

                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblNom);
                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblQte);

                    y += 30;

                    /// Pour chaque type d'arme on les ajoute dans les tabpages
                    foreach (ArmuresModel armure in armuresModels)
                    {
                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = armure.NomArmure;
                        linkLabel.Name = ("lnkLbl" + armure.NomArmure).Trim();
                        linkLabel.Location = new Point(x + 25, y);
                        linkLabel.AutoSize = true;
                        linkLabel.LinkClicked += formulaireEquipments.linkLabelArmure_LinkClicked;

                        NumericUpDown numericUpDown = new NumericUpDown();
                        numericUpDown.Location = new Point(x + (linkLabel.Width + 25), y - 3);
                        numericUpDown.Maximum = 99;
                        numericUpDown.Minimum = 0;
                        numericUpDown.Width = 40;

                        controlParent.TabPages[indexOfTabPage].Controls.Add(linkLabel);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(numericUpDown);

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
        /// Méthode pour obtenir un objet par son type
        /// </summary>
        /// <param name="typeObjet"></param>
        /// <param name="controlParent"></param>
        /// <param name="tabPage"></param>
        public static void GetObjetsByType(string typeObjet, TabControl controlParent, TabPage tabPage)
        {
            Console.WriteLine(string.Format("########### Méthode GetObjetsByType — Type d'objet : {0} ###########", typeObjet));

            FormulaireEquipments formulaireEquipments = new FormulaireEquipments();
            ObjetsModel objetsModel = new ObjetsModel();

            try
            {
                List<ObjetsModel> objetsModels = objetsModel.GetListObjetsByTypes(typeObjet);

                if (objetsModels != null)
                {
                    /// Les coordonnées qui gèrent tout les localisation
                    /// Et l'index de la tabpage
                    int y = 10;
                    int x = 10;
                    int indexOfTabPage = controlParent.TabPages.IndexOfKey(tabPage.Name);

                    // Label nom
                    Label lblNom = new Label();
                    lblNom.Name = "lblNom" + tabPage.Text;
                    lblNom.Location = new Point(x + 25, y);
                    lblNom.Text = "Nom";
                    lblNom.Font = new Font(lblNom.Font, FontStyle.Underline);

                    // Label Quantité
                    Label lblQte = new Label();
                    lblQte.Name = "lblQte" + tabPage.Text;
                    lblQte.Location = new Point(x + (lblNom.Width + 30), y);
                    lblQte.Text = "Quantité";
                    lblQte.Font = new Font(lblNom.Font, FontStyle.Underline);

                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblNom);
                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblQte);

                    y += 30;

                    /// Pour chaque type d'arme on les ajoute dans les tabpages
                    foreach (ObjetsModel objet in objetsModels)
                    {
                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = objet.NomObjet;
                        linkLabel.Name = ("lnkLbl" + objet.NomObjet).Trim();
                        linkLabel.Location = new Point(x + 25, y);
                        linkLabel.AutoSize = true;
                        linkLabel.LinkClicked += formulaireEquipments.linkLabelObjet_LinkClicked;

                        NumericUpDown numericUpDown = new NumericUpDown();
                        numericUpDown.Location = new Point(x + (linkLabel.Width + 25), y - 3);
                        numericUpDown.Maximum = 99;
                        numericUpDown.Minimum = 0;
                        numericUpDown.Width = 40;

                        controlParent.TabPages[indexOfTabPage].Controls.Add(linkLabel);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(numericUpDown);

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
        /// <param name="nomArme">le nom de l'arme à modifier</param>
        public static void GetApercuArmes(FormulaireApercuEquipement formulaire, string nomArme)
        {
            #region Initialisation des variables
            ArmesModel armesModel = new ArmesModel();
            #endregion

            try
            {
                // On commence par rendre visible les différentes label liés aux armes
                formulaire.LabelAllonge.Visible = true;
                formulaire.TextLblAllonge.Visible = true;
                formulaire.LabelMains.Visible = true;
                formulaire.TextLblMains.Visible = true;
                formulaire.TextLblDegats.Visible = true;
                formulaire.LabelDegats.Visible = true;

                // Puis on y ajoute les valeurs de l'arme sélectionnée.
                ArmesModel armeToGet = armesModel.GetArmeByName(nomArme);
                formulaire.TextLblNom = armeToGet.NomArme;
                formulaire.TextLblType = armeToGet.TypeArme;
                formulaire.TextLblPoids = armeToGet.PoidsArmes.ToString() + " kg";
                formulaire.TextLblValeur = armeToGet.ValeurArme.ToString();
                formulaire.TextLblDescription = armeToGet.DescriptionArme;
                formulaire.TextLblAllonge.Text = armeToGet.AllongeArmes;
                formulaire.TextLblMains.Text = armeToGet.MainArmes;
                formulaire.TextLblDegats.Text = armeToGet.DegatsArmes;
                formulaire.TextLblSpecial = armeToGet.SpecialArme;
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

        /// <summary>
        /// Obtenir l'id d'une arme par son nom
        /// </summary>
        /// <param name="nomArme"></param>
        /// <returns></returns>
        public static string GetArmeIdByName(string nomArme)
        {
            #region Initialisation des variables
            ArmesModel armesModel = new ArmesModel();
            #endregion

            try
            {
                ArmesModel armes = armesModel.GetArmeByName(nomArme);
                return armes.IdArme.ToString() + ";";
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Obtenir l'id d'une armure par son nom
        /// </summary>
        /// <param name="nomArmure"></param>
        /// <returns></returns>
        public static string GetArmureByName(string nomArmure)
        {
            #region Initialisation des variables
            ArmuresModel armuresModel = new ArmuresModel();
            #endregion

            try
            {
                ArmuresModel armures = armuresModel.GetArmureByName(nomArmure);
                return armures.IdArmure.ToString() + ";";
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Obtenir l'id d'un objet par son nom
        /// </summary>
        /// <param name="nomObjet"></param>
        /// <returns></returns>
        public static string GetObjetByName(string nomObjet)
        {
            #region Initialisation des variables
            ObjetsModel objetsModel = new ObjetsModel();
            #endregion

            try
            {
                ObjetsModel objets = objetsModel.GetObjetByName(nomObjet);
                return objets.IdObjet.ToString() + ";";
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Ajoute une nouvelle arme à un personnage
        /// </summary>
        /// <param name="idArme"></param>
        /// <param name="idPersonnage"></param>
        /// <param name="quantite"></param>
        public static void AddNewArmeToPersonnage(int idArme, int idPersonnage, int quantite)
        {
            Console.WriteLine(string.Format("########### Méthode AddNewArmeToPersonnage — Arme ajouté au personnage : ID ARME : {0}, " +
                "ID PERSONNAGE : {1} ###########", idArme.ToString(), idPersonnage.ToString()));

            InventaireArmesPersonnagesModel armesPersonnagesModel = new InventaireArmesPersonnagesModel();

            try
            {
                armesPersonnagesModel.SaveInventaireArmesPersonnage(idArme, idPersonnage, quantite);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idArme"></param>
        /// <param name="idPersonnage"></param>
        /// <param name="quantite"></param>
        public static void AddNewArmureToPersonnage(int idArmure, int idPersonnage, int quantite)
        {
            Console.WriteLine(string.Format("########### Méthode AddNewArmeToPersonnage — Armure ajouté au personnage : ID ARMURE : {0}, " +
                "ID PERSONNAGE : {1} ###########", idArmure.ToString(), idPersonnage.ToString()));

            InventaireArmuresPersonnageModel armuresPersonnageModel = new InventaireArmuresPersonnageModel();

            try
            {
                armuresPersonnageModel.SaveInventaireArmuresPersonnage(idArmure, idPersonnage, quantite);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idObjet"></param>
        /// <param name="idPersonnage"></param>
        /// <param name="quantite"></param>
        public static void AddNewObjetToPersonnage(int idObjet, int idPersonnage, int quantite)
        {
            Console.WriteLine(string.Format("########### Méthode AddNewArmeToPersonnage — Armure ajouté au personnage : ID OBJET : {0}, " +
                "ID PERSONNAGE : {1} ###########", idObjet.ToString(), idPersonnage.ToString()));

            InventaireObjetsPersonnagesModel inventaireObjetsPersonnages = new InventaireObjetsPersonnagesModel();

            try
            {
                inventaireObjetsPersonnages.SaveInventaireObjetsPersonnage(idObjet, idPersonnage, quantite);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomArme"></param>
        /// <returns></returns>
        public static int GetIdArmeByName(string nomArme)
        {
            #region Initialisation des variables
            ArmesModel armesModel = new ArmesModel();
            #endregion

            try
            {
                return armesModel.GetArmesIdByName(nomArme);
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
        public static int GetIdArmureByName(string nomArmure)
        {
            #region Initialisation des variables
            ArmuresModel armuresModel = new ArmuresModel();
            #endregion

            try
            {
                return armuresModel.GetArmuresIdByName(nomArmure);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomObjet"></param>
        /// <returns></returns>
        public static int GetIdObjetByName(string nomObjet)
        {
            #region Initialisation des variables
            ObjetsModel objetsModel = new ObjetsModel();
            #endregion

            try
            {
                return objetsModel.GetObjetIdByName(nomObjet);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Pour avoir le prix d'une arme
        /// </summary>
        /// <param name="nomObjet"></param>
        /// <returns></returns>
        public static int GetArmeValueByName(string nomArme)
        {
            #region Initialisation des variables
            ArmesModel armesModel = new ArmesModel();
            #endregion

            try
            {
                ArmesModel armes = armesModel.GetArmeByName(nomArme);
                return armes.ValeurArme;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Pour avoir le prix d'une arme
        /// </summary>
        /// <param name="nomArmure"></param>
        /// <returns></returns>
        public static int GetArmureValueByName(string nomArmure)
        {
            #region Initialisation des variables
            ArmuresModel armuresModel = new ArmuresModel();
            #endregion

            try
            {
                ArmuresModel armures = armuresModel.GetArmureByName(nomArmure);
                return armures.ValeurArmure;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Pour avoir le prix d'une arme
        /// </summary>
        /// <param name="nomArmure"></param>
        /// <returns></returns>
        public static int GetObjetValueByName(string nomObjet)
        {
            #region Initialisation des variables
            ObjetsModel objetsModel = new ObjetsModel();
            #endregion

            try
            {
                ObjetsModel objets = objetsModel.GetObjetByName(nomObjet);
                return objets.ValeurObjet;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Pour avoir le poids d'une arme
        /// </summary>
        /// <param name="nomObjet"></param>
        /// <returns></returns>
        public static double GetArmeWeightByName(string nomArme)
        {
            #region Initialisation des variables
            ArmesModel armesModel = new ArmesModel();
            #endregion

            try
            {
                ArmesModel armes = armesModel.GetArmeByName(nomArme);
                return armes.PoidsArmes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Pour avoir le poids d'une arme
        /// </summary>
        /// <param name="nomObjet"></param>
        /// <returns></returns>
        public static double GetArmureWeightByName(string nomArmure)
        {
            #region Initialisation des variables
            ArmuresModel armuresModel = new ArmuresModel();
            #endregion

            try
            {
                ArmuresModel armures = armuresModel.GetArmureByName(nomArmure);
                return armures.PoidsArmure;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Pour avoir le poids d'une arme
        /// </summary>
        /// <param name="nomObjet"></param>
        /// <returns></returns>
        public static double GetObjetWeightByName(string nomObjet)
        {
            #region Initialisation des variables
            ObjetsModel objetsModel = new ObjetsModel();
            #endregion

            try
            {
                ObjetsModel objets = objetsModel.GetObjetByName(nomObjet);
                return objets.PoidsObjet;
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
        public static List<string> GetListNomArmes(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListNomArmes — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmesPersonnages.GetListNomArmes(idPersonnage);
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
        public static List<string> GetListTypeArmes(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListTypeArmes — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmesPersonnages.GetListTypeArmes(idPersonnage);
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
        public static List<double> GetListPoidsArmes(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListPoidsArmes — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmesPersonnages.GetListPoidsArmes(idPersonnage);
            }
            catch (SQLiteException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static List<string> GetListAllongeArmes(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListAllongeArmes — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmesPersonnages.GetListAllongeArmes(idPersonnage);
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
        public static List<string> GetListMainsArmes(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListMainsArmes — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmesPersonnages.GetListMainsArmes(idPersonnage);
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
        public static List<string> GetListTypeDegatsArmes(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListTypeDegatsArmes — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmesPersonnages.GetListTypeDegatsArmes(idPersonnage);
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
        public static List<string> GetListDegatsArmes(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListDegatsArmes — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmesPersonnages.GetListDegatsArmes(idPersonnage);
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
        public static List<string> GetListValeurArmes(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListValeurArmes — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmesPersonnages.GetListValeurArmes(idPersonnage);
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
        public static List<string> GetListDescriptionArmes(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListDescriptionArmes — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmesPersonnages.GetListDescriptionArmes(idPersonnage);
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
        public static List<string> GetListSpecialArmes(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListSpecialArmes — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmesPersonnagesModel inventaireArmesPersonnages = new InventaireArmesPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmesPersonnages.GetListSpecialArmes(idPersonnage);
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
        public static List<string> GetListNomArmures(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListNomArmure — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmuresPersonnageModel inventaireArmuresPersonnage = new InventaireArmuresPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmuresPersonnage.GetListNomArmures(idPersonnage);
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
        public static List<string> GetListTypeArmures(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListTypeArmures — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmuresPersonnageModel inventaireArmuresPersonnage = new InventaireArmuresPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmuresPersonnage.GetListTypeArmures(idPersonnage);
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
        public static List<double> GetListPoidsArmures(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListPoidsArmures — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmuresPersonnageModel inventaireArmuresPersonnage = new InventaireArmuresPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmuresPersonnage.GetListPoidsArmures(idPersonnage);
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
        public static List<string> GetListValeurArmures(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListValeurArmures — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmuresPersonnageModel inventaireArmuresPersonnage = new InventaireArmuresPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmuresPersonnage.GetListValeurArmures(idPersonnage);
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
        public static List<string> GetListProtectionArmures(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListProtectionArmures — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmuresPersonnageModel inventaireArmuresPersonnage = new InventaireArmuresPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmuresPersonnage.GetListProtectionArmures(idPersonnage);
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
        public static List<string> GetListBonusArmures(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListBonusArmures — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmuresPersonnageModel inventaireArmuresPersonnage = new InventaireArmuresPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmuresPersonnage.GetListBonusArmures(idPersonnage);
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
        public static List<string> GetListSpecialArmures(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListSpecialArmures — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireArmuresPersonnageModel inventaireArmuresPersonnage = new InventaireArmuresPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireArmuresPersonnage.GetListSpecialArmures(idPersonnage);
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
        public static List<string> GetListNomObjets(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListNomObjets — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireObjetsPersonnagesModel inventaireObjetsPersonnages = new InventaireObjetsPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireObjetsPersonnages.GetListNomObjets(idPersonnage);
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
        public static List<double> GetListPoidsObjets(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListPoidsObjets — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireObjetsPersonnagesModel inventaireObjetsPersonnages = new InventaireObjetsPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireObjetsPersonnages.GetListPoidsObjets(idPersonnage);
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
        public static List<string> GetListValeurObjets(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListValeurObjets — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireObjetsPersonnagesModel inventaireObjetsPersonnages = new InventaireObjetsPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireObjetsPersonnages.GetListValeurObjets(idPersonnage);
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
        public static List<string> GetListTypeObjets(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListTypeObjets — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireObjetsPersonnagesModel inventaireObjetsPersonnages = new InventaireObjetsPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireObjetsPersonnages.GetListTypeObjets(idPersonnage);
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
        public static List<string> GetListConsommableObjets(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListConsommableObjets — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireObjetsPersonnagesModel inventaireObjetsPersonnages = new InventaireObjetsPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireObjetsPersonnages.GetListConsommableObjets(idPersonnage);
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
        public static List<string> GetListSpecialObjets(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetListSpecialObjets — Personnage recherchée : ID : {0} ###########", idPersonnage));

            InventaireObjetsPersonnagesModel inventaireObjetsPersonnages = new InventaireObjetsPersonnagesModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return inventaireObjetsPersonnages.GetListSpecialObjets(idPersonnage);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
