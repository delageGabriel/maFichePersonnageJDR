using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using maFichePersonnageJDR.Model;
using maFichePersonnageJDR.Formulaires;
using System.Drawing;

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

                if( armesModel != null)
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

                    // Label Poids
                    Label lblPoids = new Label();
                    lblPoids.Name = "lblPoids" + tabPage.Text;
                    lblPoids.Location = new Point(x + lblNom.Width, y);
                    lblPoids.Text = "Poids (kg)";
                    lblPoids.Font = new Font(lblNom.Font, FontStyle.Underline);

                    // Label Quantité
                    Label lblQte = new Label();
                    lblQte.Name = "lblQte" + tabPage.Text;
                    lblQte.Location = new Point(x + (lblNom.Width + lblQte.Width + 10), y);
                    lblQte.Text = "Quantité";
                    lblQte.Font = new Font(lblNom.Font, FontStyle.Underline);

                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblNom);
                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblPoids);
                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblQte);

                    y += 30;

                    /// Pour chaque type d'arme on les ajoute dans les tabpages
                    foreach (ArmesModel armes in armesModels)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Location = new Point(1, y - 5);
                        checkBox.Name = ("chck" + armes.NomArme).Trim();

                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = armes.NomArme;
                        linkLabel.Name = ("lnkLbl" + armes.NomArme).Trim();
                        linkLabel.Location = new Point(x, y);
                        linkLabel.AutoSize = true;
                        linkLabel.LinkClicked += formulaireEquipments.linkLabelArme_LinkClicked;

                        Label label = new Label();
                        label.Name = "lblPds" + armes.PoidsArmes.ToString();
                        label.Location = new Point(x + (linkLabel.Width + 10), y);
                        label.Text = armes.PoidsArmes.ToString();

                        NumericUpDown numericUpDown = new NumericUpDown();
                        numericUpDown.Location = new Point(x + (linkLabel.Width + label.Width + 10), y - 3);
                        numericUpDown.Maximum = 99;
                        numericUpDown.Minimum = 0;
                        numericUpDown.Width = 40;                        

                        controlParent.TabPages[indexOfTabPage].Controls.Add(linkLabel);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(checkBox);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(label);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(numericUpDown);

                        y += 25;
                    }
                }
            }
            catch(Exception e)
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
                    int x = 20;
                    int indexOfTabPage = controlParent.TabPages.IndexOfKey(tabPage.Name);

                    // Label nom
                    Label lblNom = new Label();
                    lblNom.Name = "lblNom" + tabPage.Text;
                    lblNom.Location = new Point(x, y);
                    lblNom.Text = "Nom";
                    lblNom.Font = new Font(lblNom.Font, FontStyle.Underline);

                    // Label Poids
                    Label lblPoids = new Label();
                    lblPoids.Name = "lblPoids" + tabPage.Text;
                    lblPoids.Location = new Point(x + lblNom.Width, y);
                    lblPoids.Text = "Poids (kg)";
                    lblPoids.Font = new Font(lblNom.Font, FontStyle.Underline);

                    // Label Quantité
                    Label lblQte = new Label();
                    lblQte.Name = "lblQte" + tabPage.Text;
                    lblQte.Location = new Point(x + (lblNom.Width + lblQte.Width + 10), y);
                    lblQte.Text = "Quantité";
                    lblQte.Font = new Font(lblNom.Font, FontStyle.Underline);

                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblNom);
                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblPoids);
                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblQte);

                    y += 30;

                    /// Pour chaque type d'arme on les ajoute dans les tabpages
                    foreach (ArmuresModel armure in armuresModels)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Location = new Point(1, y - 5);
                        checkBox.Name = ("chck" + armure.NomArmure).Trim();

                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = armure.NomArmure;
                        linkLabel.Name = ("lnkLbl" + armure.NomArmure).Trim();
                        linkLabel.Location = new Point(x, y);
                        linkLabel.AutoSize = true;
                        linkLabel.LinkClicked += formulaireEquipments.linkLabelArmure_LinkClicked;

                        Label label = new Label();
                        label.Name = "lblPds" + armure.PoidsArmure.ToString();
                        label.Location = new Point(x + (linkLabel.Width + 10), y);
                        label.Text = armure.PoidsArmure.ToString();

                        NumericUpDown numericUpDown = new NumericUpDown();
                        numericUpDown.Location = new Point(x + (linkLabel.Width + label.Width + 10), y - 3);
                        numericUpDown.Maximum = 99;
                        numericUpDown.Minimum = 0;
                        numericUpDown.Width = 40;

                        controlParent.TabPages[indexOfTabPage].Controls.Add(linkLabel);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(checkBox);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(label);
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
                    int x = 20;
                    int indexOfTabPage = controlParent.TabPages.IndexOfKey(tabPage.Name);

                    // Label nom
                    Label lblNom = new Label();
                    lblNom.Name = "lblNom" + tabPage.Text;
                    lblNom.Location = new Point(x, y);
                    lblNom.Text = "Nom";
                    lblNom.Font = new Font(lblNom.Font, FontStyle.Underline);

                    // Label Poids
                    Label lblPoids = new Label();
                    lblPoids.Name = "lblPoids" + tabPage.Text;
                    lblPoids.Location = new Point(x + lblNom.Width, y);
                    lblPoids.Text = "Poids (kg)";
                    lblPoids.Font = new Font(lblNom.Font, FontStyle.Underline);

                    // Label Quantité
                    Label lblQte = new Label();
                    lblQte.Name = "lblQte" + tabPage.Text;
                    lblQte.Location = new Point(x + (lblNom.Width + lblQte.Width + 10), y);
                    lblQte.Text = "Quantité";
                    lblQte.Font = new Font(lblNom.Font, FontStyle.Underline);

                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblNom);
                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblPoids);
                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblQte);

                    y += 30;

                    /// Pour chaque type d'arme on les ajoute dans les tabpages
                    foreach (ObjetsModel objet in objetsModels)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Location = new Point(1, y - 5);
                        checkBox.Name = ("chck" + objet.NomObjet).Trim();

                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = objet.NomObjet;
                        linkLabel.Name = ("lnkLbl" + objet.NomObjet).Trim();
                        linkLabel.Location = new Point(x, y);
                        linkLabel.AutoSize = true;
                        linkLabel.LinkClicked += formulaireEquipments.linkLabelObjet_LinkClicked;

                        Label label = new Label();
                        label.Name = "lblPds" + objet.PoidsObjet.ToString();
                        label.Location = new Point(x + (linkLabel.Width + 10), y);
                        label.Text = objet.PoidsObjet.ToString();

                        NumericUpDown numericUpDown = new NumericUpDown();
                        numericUpDown.Location = new Point(x + (linkLabel.Width + label.Width + 10), y - 3);
                        numericUpDown.Maximum = 99;
                        numericUpDown.Minimum = 0;
                        numericUpDown.Width = 40;

                        controlParent.TabPages[indexOfTabPage].Controls.Add(linkLabel);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(checkBox);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(label);
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
    }
}
