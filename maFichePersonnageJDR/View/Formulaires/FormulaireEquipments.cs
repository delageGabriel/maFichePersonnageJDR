using System.Linq;
using maFichePersonnageJDR.Classe;
using maFichePersonnageJDR.Controller;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireEquipments : Form
    {
        private int idPersonnage;
        private decimal quantiteOr;
        private decimal quantiteArgent;
        private decimal quantiteCuivre;

        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public decimal QuantiteOr
        {
            get => quantiteOr;
            set
            {
                quantiteOr = value;
                MettreAJourPoidsTotal();
            }
        }
        public decimal QuantiteArgent
        {
            get => quantiteArgent;
            set
            {
                quantiteArgent = value;
                MettreAJourPoidsTotal();
            }
        }
        public decimal QuantiteCuivre
        {
            get => quantiteCuivre;
            set
            {
                quantiteCuivre = value;
                MettreAJourPoidsTotal();
            }
        }

        public FormulaireEquipments()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Remplit chaque TabPages du TabControl Armes avec les armes correspondantes.
        /// </summary>
        public void GetArmes()
        {
            Console.WriteLine("########### Classe : FormulaireEquipments; Méthode : GetArmes; ###########");

            try
            {
                foreach (TabPage page in tbCntlArmes.TabPages)
                {
                    Controller.EquipmentController.GetArmesByType(page.Text.Trim('s'), tbCntlArmes, page);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine("########### FIN Méthode GetArmes ###########");
        }

        /// <summary>
        /// Remplit chaque TabPages du TabControl Armures avec les armures correspondantes.
        /// </summary>
        public void GetArmures()
        {
            Console.WriteLine("########### Classe : FormulaireEquipments; Méthode : GetArmures; ###########");

            try
            {
                foreach (TabPage page in tbCntlArmures.TabPages)
                {
                    Controller.EquipmentController.GetArmuresByType(page.Text.Trim('s'), tbCntlArmures, page);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine("########### FIN Méthode GetArmures ###########");
        }

        /// <summary>
        /// Remplit chaque TabPages du TabControl Objets avec les objets correspondantes.
        /// </summary>
        public void GetObjets()
        {
            Console.WriteLine("########### Classe : FormulaireEquipments; Méthode : GetObjets; ###########");

            try
            {
                foreach (TabPage page in tbCntlObjets.TabPages)
                {
                    Controller.EquipmentController.GetObjetsByType(page.Text, tbCntlObjets, page);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine("########### FIN Méthode GetArmures ###########");
        }

        private void FormulaireEquipments_Load(object sender, EventArgs e)
        {
            GetArmes();
            GetArmures();
            GetObjets();
            CreateCheckBoxArmes();
            CreateCheckBoxArmures();
            CreateCheckBoxObjet();
        }

        public void linkLabelArme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuEquipement formulaireApercuEquipement = new FormulaireApercuEquipement();

            LinkLabel linkLabel = sender as LinkLabel;

            EquipmentController.GetApercuArmes(formulaireApercuEquipement, linkLabel.Text);
            formulaireApercuEquipement.Show();
        }

        public void linkLabelArmure_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuEquipement formulaireApercuEquipement = new FormulaireApercuEquipement();
            LinkLabel linkLabel = sender as LinkLabel;

            EquipmentController.GetApercuArmure(formulaireApercuEquipement, linkLabel.Text);
            formulaireApercuEquipement.Show();
        }

        public void linkLabelObjet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuEquipement formulaireApercuEquipement = new FormulaireApercuEquipement();
            LinkLabel linkLabel = sender as LinkLabel;

            EquipmentController.GetApercuObjet(formulaireApercuEquipement, linkLabel.Text);
            formulaireApercuEquipement.Show();
        }

        /// <summary>
        /// Checkbox pour ajouter ou retirer une arme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void checkBoxArme_Click(object sender, EventArgs e)
        {
            #region Initialisation des variables
            CheckBox checkBox = sender as CheckBox;
            string nomArme = checkBox.Name.Substring(4);
            string idArme = EquipmentController.GetArmeIdToSaveInInventaire(nomArme);

            int qteReturn = QuantityToReturn(nomArme, checkBox.Parent);
            #endregion

            // On rajoute la quantité à passer dans l'inventaire
            idArme += qteReturn.ToString();

            if (checkBox.Checked)
            {
                try
                {
                    int valeur = Utils.DeleteMoneyValue(lblTotalDepenseArmes.Text) + (EquipmentController.GetArmeValueByName(nomArme) * qteReturn);
                    decimal poids = decimal.Parse(lblPoidsEnPlusArmes.Text) + Convert.ToDecimal(EquipmentController.GetArmeWeightByName(nomArme) * qteReturn);
                    rTxtBxArmes.AppendText(idArme + Environment.NewLine);

                    lblTotalDepenseArmes.Text = Utils.ConvertMoneyWithValue(valeur);
                    lblPoidsEnPlusArmes.Text = poids.ToString();

                    rtbAcheterArmes.AppendText(nomArme + ", Quantité:" + qteReturn + Environment.NewLine);
                    NumericToReturn(nomArme, checkBox.Parent).Enabled = false;
                }
                catch (System.FormatException ex)
                {
                    // Gérez l'exception ici (par exemple, en l'enregistrant dans un journal)
                    Console.WriteLine("Erreur de format : " + ex.Message);
                }
            }
            else
            {
                int valeur = Utils.DeleteMoneyValue(lblTotalDepenseArmes.Text) - (EquipmentController.GetArmeValueByName(nomArme) * qteReturn);
                decimal poids = decimal.Parse(lblPoidsEnPlusArmes.Text) - Convert.ToDecimal(EquipmentController.GetArmeWeightByName(nomArme) * qteReturn);

                lblTotalDepenseArmes.Text = Utils.ConvertMoneyWithValue(valeur);
                lblPoidsEnPlusArmes.Text = poids.ToString();

                // FR : Récupération de l'index de la ligne à supprimer
                // EN : Retrieve the index of the line to be deleted
                int indexToDelete = Utils.GetLineNumberToDelete(idArme, rTxtBxArmes);
                int indexToDeleteApercuArme = Utils.GetLineNumberToDelete(nomArme, rtbAcheterArmes);

                // FR : On récupère toutes les lignes sous la forme d'une liste
                // EN : All rows are retrieved in the form of a list
                List<string> lines = new List<string>(rTxtBxArmes.Lines);
                List<string> linesApercuArmes = new List<string>(rtbAcheterArmes.Lines);

                // FR : On supprime la ligne où l'on a trouvé le texte correspondant
                // EN : On supprime la ligne où l'on a trouvé le texte correspondan
                lines.RemoveAt(indexToDelete);
                linesApercuArmes.RemoveAt(indexToDeleteApercuArme);

                // FR : On réattribue les nouvelles lignes à celles de la RichTextBox
                // EN : Reassign the new lines to those in the RichTextBox
                rTxtBxArmes.Lines = lines.ToArray();
                rtbAcheterArmes.Lines = linesApercuArmes.ToArray();
                NumericToReturn(nomArme, checkBox.Parent).Enabled = true;
            }
        }

        /// <summary>
        /// Checkbox pour ajouter ou retirer une arme
        /// à vendre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void checkBoxVendreArme_Click(object sender, EventArgs e)
        {
            #region Initialisation des variables
            CheckBox checkBox = sender as CheckBox;
            string nomArme = checkBox.Name.Substring(4);
            string idArme = EquipmentController.GetArmeIdToSaveInInventaire(nomArme);

            int qteReturn = QuantityToReturn(nomArme, checkBox.Parent);
            #endregion

            // On rajoute la quantité à passer dans l'inventaire
            idArme += qteReturn.ToString();

            if (checkBox.Checked)
            {
                try
                {
                    int valeur = Utils.DeleteMoneyValue(lblTotalDepenseArmes.Text) + (EquipmentController.GetArmeValueByName(nomArme) * qteReturn);
                    double poids = double.Parse(lblPoidsEnPlusArmes.Text) + (EquipmentController.GetArmeWeightByName(nomArme) * qteReturn);
                    rTxtBxArmes.AppendText(idArme + Environment.NewLine);

                    lblTotalDepenseArmes.Text = Utils.ConvertMoneyWithValue(valeur);
                    lblPoidsEnPlusArmes.Text = poids.ToString();

                    NumericToReturn(nomArme, checkBox.Parent).Enabled = false;
                }
                catch (System.FormatException ex)
                {
                    // Gérez l'exception ici (par exemple, en l'enregistrant dans un journal)
                    Console.WriteLine("Erreur de format : " + ex.Message);
                }
            }
            else
            {
                int valeur = Utils.DeleteMoneyValue(lblTotalDepenseArmes.Text) - (EquipmentController.GetArmeValueByName(nomArme) * qteReturn);
                decimal poids = decimal.Parse(lblPoidsEnPlusArmes.Text) - Convert.ToDecimal(EquipmentController.GetArmeWeightByName(nomArme) * qteReturn);

                lblTotalDepenseArmes.Text = Utils.ConvertMoneyWithValue(valeur);
                lblPoidsEnPlusArmes.Text = poids.ToString();

                // FR : Récupération de l'index de la ligne à supprimer
                // EN : Retrieve the index of the line to be deleted
                int indexToDelete = Utils.GetLineNumberToDelete(idArme, rTxtBxArmes);

                // FR : On récupère toutes les lignes sous la forme d'une liste
                // EN : All rows are retrieved in the form of a list
                List<string> lines = new List<string>(rTxtBxArmes.Lines);

                // FR : On supprime la ligne où l'on a trouvé le texte correspondant
                // EN : On supprime la ligne où l'on a trouvé le texte correspondan
                lines.RemoveAt(indexToDelete);

                // FR : On réattribue les nouvelles lignes à celles de la RichTextBox
                // EN : Reassign the new lines to those in the RichTextBox
                rTxtBxArmes.Lines = lines.ToArray();
                NumericToReturn(nomArme, checkBox.Parent).Enabled = true;
            }
        }

        /// <summary>
        /// Checkbox pour ajouter ou retirer une arme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void checkBoxArmure_Click(object sender, EventArgs e)
        {
            #region Initialisation des variables
            CheckBox checkBox = sender as CheckBox;
            string nomArmure = checkBox.Name.Substring(4);
            string armure = EquipmentController.GetArmureToSaveInInventaire(nomArmure);

            int qteReturn = QuantityToReturn(nomArmure, checkBox.Parent);
            #endregion

            armure += qteReturn.ToString();

            if (checkBox.Checked)
            {
                try
                {

                    int valeur = Utils.DeleteMoneyValue(lblTotalDepenseArmures.Text) + (EquipmentController.GetArmureValueByName(nomArmure) * qteReturn);
                    decimal poids = decimal.Parse(lblPoidsEnPlusArmures.Text) + Convert.ToDecimal((EquipmentController.GetArmureWeightByName(nomArmure) * qteReturn));
                    rTxtBxArmures.AppendText(armure + Environment.NewLine);

                    lblTotalDepenseArmures.Text = Utils.ConvertMoneyWithValue(valeur);
                    lblPoidsEnPlusArmures.Text = poids.ToString();

                    rtbAcheterArmures.AppendText(nomArmure + ",  Quantité:" + qteReturn + Environment.NewLine);
                    NumericToReturn(nomArmure, checkBox.Parent).Enabled = false;
                }
                catch (System.FormatException ex)
                {
                    // Gérez l'exception ici (par exemple, en l'enregistrant dans un journal)
                    Console.WriteLine("Erreur de format : " + ex.Message);
                }
            }
            else
            {
                int valeur = Utils.DeleteMoneyValue(lblTotalDepenseArmures.Text) - (EquipmentController.GetArmureValueByName(nomArmure) * qteReturn);
                decimal poids = decimal.Parse(lblPoidsEnPlusArmures.Text) - Convert.ToDecimal(EquipmentController.GetArmureWeightByName(nomArmure) * qteReturn);

                lblTotalDepenseArmures.Text = Utils.ConvertMoneyWithValue(valeur);
                lblPoidsEnPlusArmures.Text = poids.ToString();

                // FR : Récupération de l'index de la ligne à supprimer
                // EN : Retrieve the index of the line to be deleted
                int indexToDelete = Utils.GetLineNumberToDelete(armure, rTxtBxArmures);
                int indexToDeleteApercuArme = Utils.GetLineNumberToDelete(nomArmure, rtbAcheterArmures);

                // FR : On récupère toutes les lignes sous la forme d'une liste
                // EN : All rows are retrieved in the form of a list
                List<string> lines = new List<string>(rTxtBxArmures.Lines);
                List<string> linesApercuArmures = new List<string>(rtbAcheterArmures.Lines);

                // FR : On supprime la ligne où l'on a trouvé le texte correspondant
                // EN : On supprime la ligne où l'on a trouvé le texte correspondan
                lines.RemoveAt(indexToDelete);
                linesApercuArmures.RemoveAt(indexToDeleteApercuArme);

                // FR : On réattribue les nouvelles lignes à celles de la RichTextBox
                // EN : Reassign the new lines to those in the RichTextBox
                rTxtBxArmures.Lines = lines.ToArray();
                rtbAcheterArmures.Lines = linesApercuArmures.ToArray();
                NumericToReturn(nomArmure, checkBox.Parent).Enabled = true;
            }
        }

        /// <summary>
        /// Checkbox pour ajouter ou retirer une arme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void checkBoxVendreArmure_Click(object sender, EventArgs e)
        {
            #region Initialisation des variables
            CheckBox checkBox = sender as CheckBox;
            string nomArmure = checkBox.Name.Substring(4);
            string armure = EquipmentController.GetArmureToSaveInInventaire(nomArmure);

            int qteReturn = QuantityToReturn(nomArmure, checkBox.Parent);
            #endregion

            armure += qteReturn.ToString();

            if (checkBox.Checked)
            {
                try
                {

                    int valeur = Utils.DeleteMoneyValue(lblTotalDepenseArmures.Text) + (EquipmentController.GetArmureValueByName(nomArmure) * qteReturn);
                    decimal poids = decimal.Parse(lblPoidsEnPlusArmures.Text) + Convert.ToDecimal((EquipmentController.GetArmureWeightByName(nomArmure) * qteReturn));
                    rTxtBxArmures.AppendText(armure + Environment.NewLine);

                    lblTotalDepenseArmures.Text = Utils.ConvertMoneyWithValue(valeur);
                    lblPoidsEnPlusArmures.Text = poids.ToString();

                    NumericToReturn(nomArmure, checkBox.Parent).Enabled = false;
                }
                catch (System.FormatException ex)
                {
                    // Gérez l'exception ici (par exemple, en l'enregistrant dans un journal)
                    Console.WriteLine("Erreur de format : " + ex.Message);
                }
            }
            else
            {
                int valeur = Utils.DeleteMoneyValue(lblTotalDepenseArmures.Text) - (EquipmentController.GetArmureValueByName(nomArmure) * qteReturn);
                decimal poids = decimal.Parse(lblPoidsEnPlusArmures.Text) - Convert.ToDecimal((EquipmentController.GetArmureWeightByName(nomArmure) * qteReturn));

                lblTotalDepenseArmures.Text = Utils.ConvertMoneyWithValue(valeur);
                lblPoidsEnPlusArmures.Text = poids.ToString();

                // FR : Récupération de l'index de la ligne à supprimer
                // EN : Retrieve the index of the line to be deleted
                int indexToDelete = Utils.GetLineNumberToDelete(armure, rTxtBxArmures);

                // FR : On récupère toutes les lignes sous la forme d'une liste
                // EN : All rows are retrieved in the form of a list
                List<string> lines = new List<string>(rTxtBxArmures.Lines);

                // FR : On supprime la ligne où l'on a trouvé le texte correspondant
                // EN : On supprime la ligne où l'on a trouvé le texte correspondan
                lines.RemoveAt(indexToDelete);

                // FR : On réattribue les nouvelles lignes à celles de la RichTextBox
                // EN : Reassign the new lines to those in the RichTextBox
                rTxtBxArmures.Lines = lines.ToArray();
                NumericToReturn(nomArmure, checkBox.Parent).Enabled = true;
            }
        }

        /// <summary>
        /// Checkbox pour ajouter ou retirer une arme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void checkBoxObjet_Click(object sender, EventArgs e)
        {
            #region Initialisation des variables
            CheckBox checkBox = sender as CheckBox;
            string nomObjet = checkBox.Name.Substring(4);
            string idObjet = EquipmentController.GetObjetToSaveInInventaire(nomObjet);

            int qteReturn = QuantityToReturn(nomObjet, (TabPage)checkBox.Parent);
            #endregion

            idObjet += qteReturn.ToString();

            if (checkBox.Checked)
            {
                int valeur = Utils.DeleteMoneyValue(lblTotalDepenseObjets.Text) + (EquipmentController.GetObjetValueByName(nomObjet) * qteReturn);
                decimal poids = decimal.Parse(lblPoidsEnPlusObjets.Text) + Convert.ToDecimal(EquipmentController.GetObjetWeightByName(nomObjet) * qteReturn);
                rTxtBxObjets.AppendText(idObjet + Environment.NewLine);

                lblTotalDepenseObjets.Text = Utils.ConvertMoneyWithValue(valeur);
                lblPoidsEnPlusObjets.Text = poids.ToString();

                rtbAcheterObjets.AppendText(nomObjet + ", Quantité:" + qteReturn + Environment.NewLine);
                NumericToReturn(nomObjet, checkBox.Parent).Enabled = false;
            }
            else
            {
                int valeur = Utils.DeleteMoneyValue(lblTotalDepenseObjets.Text) - (EquipmentController.GetObjetValueByName(nomObjet) * qteReturn);
                decimal poids = decimal.Parse(lblPoidsEnPlusObjets.Text) - Convert.ToDecimal(EquipmentController.GetObjetWeightByName(nomObjet) * qteReturn);

                lblTotalDepenseObjets.Text = Utils.ConvertMoneyWithValue(valeur);
                lblPoidsEnPlusObjets.Text = poids.ToString();

                int indexToDelete = Utils.GetLineNumberToDelete(idObjet, rTxtBxObjets);
                int indexToDeleteApercuObjet = Utils.GetLineNumberToDelete(nomObjet, rTxtBxObjets);

                // FR : On récupère toutes les lignes sous la forme d'une liste
                // EN : All rows are retrieved in the form of a list
                List<string> lines = new List<string>(rTxtBxObjets.Lines);
                List<string> linesApercuObjets = new List<string>(rtbAcheterObjets.Lines);

                // FR : On supprime la ligne où l'on a trouvé le texte correspondant
                // EN : On supprime la ligne où l'on a trouvé le texte correspondan
                lines.RemoveAt(indexToDelete);
                linesApercuObjets.RemoveAt(indexToDeleteApercuObjet);

                // FR : On réattribue les nouvelles lignes à celles de la RichTextBox
                // EN : Reassign the new lines to those in the RichTextBox
                rTxtBxObjets.Lines = lines.ToArray();
                rtbAcheterObjets.Lines = linesApercuObjets.ToArray();
                NumericToReturn(nomObjet, checkBox.Parent).Enabled = true;
            }
        }

        /// <summary>
        /// Checkbox pour ajouter ou retirer une arme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void checkBoxVendreObjet_Click(object sender, EventArgs e)
        {
            #region Initialisation des variables
            CheckBox checkBox = sender as CheckBox;
            string nomObjet = checkBox.Name.Substring(4);
            string idObjet = EquipmentController.GetObjetToSaveInInventaire(nomObjet);

            int qteReturn = QuantityToReturn(nomObjet, checkBox.Parent);
            #endregion

            idObjet += qteReturn.ToString();

            if (checkBox.Checked)
            {
                int valeur = Utils.DeleteMoneyValue(lblTotalDepenseObjets.Text) + (EquipmentController.GetObjetValueByName(nomObjet) * qteReturn);
                decimal poids = decimal.Parse(lblPoidsEnPlusObjets.Text) + Convert.ToDecimal(EquipmentController.GetObjetWeightByName(nomObjet) * qteReturn);
                rTxtBxObjets.AppendText(idObjet + Environment.NewLine);

                lblTotalDepenseObjets.Text = Utils.ConvertMoneyWithValue(valeur);
                lblPoidsEnPlusObjets.Text = poids.ToString();

                NumericToReturn(nomObjet, checkBox.Parent).Enabled = false;
            }
            else
            {
                int valeur = Utils.DeleteMoneyValue(lblTotalDepenseObjets.Text) - (EquipmentController.GetObjetValueByName(nomObjet) * qteReturn);
                decimal poids = decimal.Parse(lblPoidsEnPlusObjets.Text) - Convert.ToDecimal(EquipmentController.GetObjetWeightByName(nomObjet) * qteReturn);

                lblTotalDepenseObjets.Text = Utils.ConvertMoneyWithValue(valeur);
                lblPoidsEnPlusObjets.Text = poids.ToString();

                int indexToDelete = Utils.GetLineNumberToDelete(idObjet, rTxtBxObjets);

                // FR : On récupère toutes les lignes sous la forme d'une liste
                // EN : All rows are retrieved in the form of a list
                List<string> lines = new List<string>(rTxtBxObjets.Lines);

                // FR : On supprime la ligne où l'on a trouvé le texte correspondant
                // EN : On supprime la ligne où l'on a trouvé le texte correspondan
                lines.RemoveAt(indexToDelete);

                // FR : On réattribue les nouvelles lignes à celles de la RichTextBox
                // EN : Reassign the new lines to those in the RichTextBox
                rTxtBxObjets.Lines = lines.ToArray();
                NumericToReturn(nomObjet, checkBox.Parent).Enabled = true;
            }
        }

        /// <summary>
        /// Créez les checkbox associées aux attributs
        /// </summary>
        public void CreateCheckBoxArmes()
        {
            // On parcourt toute la liste des armes
            foreach (TabPage page in tbCntlArmes.TabPages)
            {
                int y = 35;

                // A chaque linklabel on ajoute une checkbox
                foreach (object controls in page.Controls)
                {
                    if (controls is LinkLabel)
                    {
                        LinkLabel linkLabel = controls as LinkLabel;

                        CheckBox checkBox = new CheckBox();
                        checkBox.Location = new Point(5, y);
                        checkBox.Name = ("chck" + linkLabel.Name.Substring(6));
                        checkBox.Click += checkBoxArme_Click;

                        page.Controls.Add(checkBox);
                        y += 25;
                    }
                }
            }
        }

        /// <summary>
        /// Créez les checkbox associées aux attributs
        /// </summary>
        public void CreateCheckBoxVendreArmes()
        {
            // A chaque linklabel on ajoute une checkbox
            foreach (object controls in pnlVendreArme.Controls)
            {
                if (controls is Label)
                {
                    Label label = controls as Label;
                    int hauteurTexteLabel = TextRenderer.MeasureText(label.Text, label.Font).Height;

                    CheckBox checkBox = new CheckBox();
                    checkBox.Top = label.Top + (hauteurTexteLabel - checkBox.Height) / 2;
                    checkBox.Left = 5;
                    checkBox.Name = ("chck" + label.Tag.ToString());
                    checkBox.Click += checkBoxVendreArme_Click;
                    checkBox.Tag = label.Tag.ToString();

                    pnlVendreArme.Controls.Add(checkBox);
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public void CreateCheckBoxArmures()
        {
            // On parcourt toute la liste des armes
            foreach (TabPage page in tbCntlArmures.TabPages)
            {
                int y = 35;

                // A chaque linklabel on ajoute une checkbox
                foreach (object controls in page.Controls)
                {
                    if (controls is LinkLabel)
                    {
                        LinkLabel linkLabel = controls as LinkLabel;

                        CheckBox checkBox = new CheckBox();
                        checkBox.Location = new Point(5, y);
                        checkBox.Name = ("chck" + linkLabel.Name.Substring(6));
                        checkBox.Click += checkBoxArmure_Click;

                        page.Controls.Add(checkBox);
                        y += 25;
                    }
                }
            }
        }

        /// <summary>
        /// Créez les checkbox associées aux attributs
        /// </summary>
        public void CreateCheckBoxVendreArmures()
        {
            // A chaque linklabel on ajoute une checkbox
            foreach (object controls in pnlVendreArmure.Controls)
            {
                if (controls is Label)
                {
                    Label label = controls as Label;
                    int hauteurTexteLabel = TextRenderer.MeasureText(label.Text, label.Font).Height;

                    CheckBox checkBox = new CheckBox();
                    checkBox.Top = label.Top + (hauteurTexteLabel - checkBox.Height) / 2;
                    checkBox.Left = 5;
                    checkBox.Name = ("chck" + label.Tag.ToString());
                    checkBox.Click += checkBoxVendreArmure_Click;
                    checkBox.Tag = label.Tag.ToString();

                    pnlVendreArmure.Controls.Add(checkBox);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void CreateCheckBoxObjet()
        {
            // On parcourt toute la liste des armes
            foreach (TabPage page in tbCntlObjets.TabPages)
            {
                int y = 35;

                // A chaque linklabel on ajoute une checkbox
                foreach (object controls in page.Controls)
                {
                    if (controls is LinkLabel)
                    {
                        LinkLabel linkLabel = controls as LinkLabel;

                        CheckBox checkBox = new CheckBox();
                        checkBox.Location = new Point(5, y);
                        checkBox.Name = ("chck" + linkLabel.Name.Substring(6));
                        checkBox.Click += checkBoxObjet_Click;

                        page.Controls.Add(checkBox);
                        y += 25;
                    }
                }
            }
        }

        /// <summary>
        /// Créez les checkbox pour vendre les objets
        /// </summary>
        public void CreateCheckBoxVendreObjets()
        {
            foreach (object controls in pnlVendreObjet.Controls)
            {
                if (controls is Label)
                {
                    Label label = controls as Label;
                    int hauteurTexteLabel = TextRenderer.MeasureText(label.Text, label.Font).Height;

                    CheckBox checkBox = new CheckBox();
                    checkBox.Top = label.Top + (hauteurTexteLabel - checkBox.Height) / 2;
                    checkBox.Left = 5;
                    checkBox.Name = ("chck" + label.Tag.ToString());
                    checkBox.Click += checkBoxVendreObjet_Click;
                    checkBox.Tag = label.Tag.ToString();

                    pnlVendreObjet.Controls.Add(checkBox);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tagControl">le tag qui permet d'identifier</param>
        /// <param name="page"></param>
        /// <returns></returns>
        public int QuantityToReturn(string tagControl, object parent)
        {
            // Variable quantité à retourner
            int value = 1;

            try
            {
                if (parent is TabPage)
                {
                    TabPage page = parent as TabPage;
                    // CAS TabPage
                    foreach (object control in page.Controls)
                    {
                        if (control is NumericUpDown)
                        {
                            NumericUpDown nudToCheck = control as NumericUpDown;

                            if ((string)nudToCheck.Tag == tagControl)
                            {
                                value = Convert.ToInt32(nudToCheck.Value);
                            }
                        }
                    }
                }
                else
                {
                    Panel panel = parent as Panel;
                    // CAS Panel

                    foreach (object control in panel.Controls)
                    {
                        if (control is NumericUpDown)
                        {
                            NumericUpDown nudToCheck = control as NumericUpDown;

                            if ((string)nudToCheck.Tag == tagControl)
                            {
                                value = Convert.ToInt32(nudToCheck.Value);
                            }
                        }
                    }
                }

                return value;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne un numericUpDown recherché
        /// </summary>
        /// <param name="tagControl">Le tag du numeric à chercher</param>
        /// <param name="page">la page dans laquelle il se trouve</param>
        /// <returns></returns>
        public NumericUpDown NumericToReturn(string tagControl, object parent)
        {
            NumericUpDown numericUpDown = new NumericUpDown();

            try
            {
                /*
                 * CAS TabPage
                 */
                if (parent is TabPage)
                {
                    TabPage page = parent as TabPage;

                    foreach (object control in page.Controls)
                    {
                        if (control is NumericUpDown)
                        {
                            NumericUpDown nudToCheck = control as NumericUpDown;

                            if ((string)nudToCheck.Tag == tagControl)
                            {
                                numericUpDown = nudToCheck;
                            }
                        }
                    }
                }
                /*
                 * CAS Panel
                 */
                else
                {
                    Panel panel = parent as Panel;

                    foreach (object control in panel.Controls)
                    {
                        if (control is NumericUpDown)
                        {
                            NumericUpDown nudToCheck = control as NumericUpDown;

                            if ((string)nudToCheck.Tag == tagControl)
                            {
                                numericUpDown = nudToCheck;
                            }
                        }
                    }
                }

                return numericUpDown;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            #region Initialisation des variables
            FormulaireMagieEtAptitudes formulaireMagieEtAptitudes = new FormulaireMagieEtAptitudes();
            #endregion

            try
            {
                // ARMURES
                foreach (string line in rTxtBxArmures.Lines)
                {
                    if (!String.IsNullOrEmpty(line))
                    {
                        string[] substring = line.Split(';');
                        EquipmentController.AddNewArmureToPersonnage(Convert.ToInt32(substring[0]),
                        IdPersonnage, Convert.ToInt32(substring[1]));
                    }

                }

                // OBJETS
                foreach (string line in rTxtBxObjets.Lines)
                {
                    if (!String.IsNullOrEmpty(line))
                    {
                        string[] substring = line.Split(';');
                        EquipmentController.AddNewObjetToPersonnage(Convert.ToInt32(substring[0]),
                        IdPersonnage, Convert.ToInt32(substring[1]));
                    }
                }

                formulaireMagieEtAptitudes.IdPersonnage = IdPersonnage;
                MessageBox.Show("Équipement sauvegardé !");
                formulaireMagieEtAptitudes.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void nudPo_ValueChanged(object sender, EventArgs e)
        {
            QuantiteOr = nudPo.Value;
        }

        private void nudPa_ValueChanged(object sender, EventArgs e)
        {
            QuantiteArgent = nudPa.Value;
        }

        private void nudPc_ValueChanged(object sender, EventArgs e)
        {
            QuantiteCuivre = nudPc.Value;
        }

        /// <summary>
        /// Met à jour le poids total de pièces transportées par le personnage 
        /// </summary>
        private void MettreAJourPoidsTotal()
        {
            decimal poidsTotal = (QuantiteOr * 0.115m) + (QuantiteArgent * 0.0783m) + (QuantiteCuivre * 0.0402m);
            poidsTotal += Controller.EquipmentController.GetPoidsTotalArmeTransportees(IdPersonnage) +
                EquipmentController.GetPoidsTotalArmureTransportees(IdPersonnage) + EquipmentController.GetPoidsTotalObjetTransportees(IdPersonnage);
            lblChrgPrtePersonnage.Text = poidsTotal.ToString("0.##") + " kg";
        }

        /// <summary>
        /// Met à jour le poids total transporté par le personnage après achat
        /// </summary>
        /// <param name="poidsAjouter"></param>
        public void MettreAJourPoidsTotal(decimal poidsAjouter, string buyOrSell)
        {
            string[] characters = { " ", "k", "g" };
            decimal poidsTotal = 0;

            if (buyOrSell == "Buy")
            {
                poidsTotal = decimal.Parse(Utils.DeleteCharacterFromString(lblChrgPrtePersonnage.Text, characters)) + poidsAjouter;
            }
            else
            {
                poidsTotal = decimal.Parse(Utils.DeleteCharacterFromString(lblChrgPrtePersonnage.Text, characters)) - poidsAjouter;
            }

            lblChrgPrtePersonnage.Text = poidsTotal.ToString("0.##") + " kg";
        }

        /// <summary>
        /// Événement pour vérifier si les trois RichTextBox pour activer ou désactiver les boutons acheter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbAcheterEquipement_TextChanged(object sender, EventArgs e)
        {
            string tagControl = (sender as RichTextBox).Tag as string;
            Button boutonAcheterActiver = new Button();

            if (tagControl == "Armes")
            {
                boutonAcheterActiver = btnAcheterArmes;
            }
            else if (tagControl == "Armures")
            {
                boutonAcheterActiver = btnAcheterArmures;
            }
            else if (tagControl == "Objets")
            {
                boutonAcheterActiver = btnAcheterObjets;
            }

            boutonAcheterActiver.Enabled = (sender as RichTextBox).Lines.Length > 0 ? true : false;
        }

        /// <summary>
        /// Événement qui gère l'achat d'équipement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcheter_Click(object sender, EventArgs e)
        {
            #region Initialisation des variables
            // PRIMITIFS
            string tagButton = (sender as Button).Tag as string;
            int achat = 0;
            int monnaiePersonnage = int.Parse(string.Format("{0}{1}{2}", nudPo.Value.ToString(), nudPa.Value.ToString(), nudPc.Value.ToString()));

            // COMPLEXES
            List<string> listeEquipementPersonnage = new List<string>();
            Func<int, List<string>> GetEquipmentInInventairePersonnage = null;
            Func<int, string> GetEquipementNameById = null;
            Func<int, int, int> GetQuantityEquipment = null;
            Action<int, int, int> UpdateEquipmentQuantity = null;
            Action<int, int, int> AddNewEquipmentToInventairePersonnage = null;
            Action<Panel, int> GetEquipmentsInInventairePersonnageToCreateControl = null;
            Action CreateCheckBoxVendre = null;
            RichTextBox rTxtBxEquipments = new RichTextBox();
            RichTextBox rtbAcheterEquipement = new RichTextBox();
            Panel panelVendreEquipement = new Panel();
            Label lblTotalDepenseEquipement = new Label();
            Label lblPoidsEnPlusEquipment = new Label();
            TabControl tabControlEquipment = new TabControl();
            #endregion

            /**
             * #### ~ ARMES ~ ####
             */
            if (tagButton == "Armes")
            {
                lblTotalDepenseEquipement = lblTotalDepenseArmes;
                lblPoidsEnPlusEquipment = lblPoidsEnPlusArmes;
                panelVendreEquipement = pnlVendreArme;
                rTxtBxEquipments = rTxtBxArmes;
                rtbAcheterEquipement = rtbAcheterArmes;
                tabControlEquipment = tbCntlArmes;
                GetEquipmentInInventairePersonnage = EquipmentController.GetArmesInInventairePersonnage;
                GetEquipementNameById = EquipmentController.GetArmeNameById;
                GetQuantityEquipment = EquipmentController.GetQuantityArme;
                UpdateEquipmentQuantity = EquipmentController.UpdateArmesQuantity;
                AddNewEquipmentToInventairePersonnage = EquipmentController.AddNewArmeToPersonnage;
                GetEquipmentsInInventairePersonnageToCreateControl = EquipmentController.GetArmesInInventairePersonnageToCreateControl;
                CreateCheckBoxVendre = CreateCheckBoxVendreArmes;
            }
            /**
             * #### ~ ARMURES ~ ####
             */
            else if (tagButton == "Armures")
            {
                lblTotalDepenseEquipement = lblTotalDepenseArmures;
                lblPoidsEnPlusEquipment = lblPoidsEnPlusArmures;
                panelVendreEquipement = pnlVendreArmure;
                rTxtBxEquipments = rTxtBxArmures;
                rtbAcheterEquipement = rtbAcheterArmures;
                tabControlEquipment = tbCntlArmures;
                GetEquipmentInInventairePersonnage = EquipmentController.GetArmuresInInventairePersonnage;
                GetEquipementNameById = EquipmentController.GetArmureNameById;
                GetQuantityEquipment = EquipmentController.GetQuantityArmure;
                UpdateEquipmentQuantity = EquipmentController.UpdateArmuresQuantity;
                AddNewEquipmentToInventairePersonnage = EquipmentController.AddNewArmureToPersonnage;
                GetEquipmentsInInventairePersonnageToCreateControl = EquipmentController.GetArmuresInInventairePersonnageToCreateControl;
                CreateCheckBoxVendre = CreateCheckBoxVendreArmures;
            }
            /**
             * #### ~ OBJETS ~ ####
             */
            else if (tagButton == "Objets")
            {
                lblTotalDepenseEquipement = lblTotalDepenseObjets;
                lblPoidsEnPlusEquipment = lblPoidsEnPlusObjets;
                panelVendreEquipement = pnlVendreObjet;
                rTxtBxEquipments = rTxtBxObjets;
                rtbAcheterEquipement = rtbAcheterObjets;
                tabControlEquipment = tbCntlObjets;
                GetEquipmentInInventairePersonnage = EquipmentController.GetObjetsInInventairePersonnage;
                GetEquipementNameById = EquipmentController.GetObjetNameById;
                GetQuantityEquipment = EquipmentController.GetQuantityObjet;
                UpdateEquipmentQuantity = EquipmentController.UpdateObjetsQuantity;
                AddNewEquipmentToInventairePersonnage = EquipmentController.AddNewObjetToPersonnage;
                GetEquipmentsInInventairePersonnageToCreateControl = EquipmentController.GetObjetsInInventairePersonnageToCreateControls;
                CreateCheckBoxVendre = CreateCheckBoxVendreObjets;
            }

            achat = Utils.DeleteMoneyValue(lblTotalDepenseEquipement.Text);
            int differenceAchat = monnaiePersonnage - achat;
            if (GetEquipmentInInventairePersonnage != null)
            {
                listeEquipementPersonnage = GetEquipmentInInventairePersonnage(IdPersonnage);
            }
            else
            {
                throw new Exception("GetEquipmentInInventairePersonnage a été null");
            }

            if (panelVendreEquipement.Controls.Count > 0)
                panelVendreEquipement.Controls.Clear();

            // Si c'est pas le cas, on lui dit et on sort de la méthode
            if (differenceAchat < 0)
            {
                MessageBox.Show("Pas assez de monnaie !");

                if (GetEquipmentsInInventairePersonnageToCreateControl != null)
                {
                    GetEquipmentsInInventairePersonnageToCreateControl(panelVendreEquipement, IdPersonnage);
                }
                else
                {
                    throw new Exception("GetEquipmentsInInventairePersonnageToCreateControl est null");
                }

                if (CreateCheckBoxVendre != null)
                {
                    CreateCheckBoxVendre();
                }

                return;
            }

            // Ensuite on parcourt la liste des armes achetées
            // pour les ajouter à l'inventaire d'armes du personnage
            foreach (string line in rTxtBxEquipments.Lines)
            {
                if (!String.IsNullOrEmpty(line))
                {
                    string[] substring = line.Split(';');
                    int idArme = int.Parse(substring[0]);
                    string nomArme = string.Empty;

                    if (GetEquipementNameById != null)
                    {
                        nomArme = GetEquipementNameById(idArme);
                    }
                    else
                    {
                        throw new Exception("GetEquipementNameById est null");
                    }

                    /// Si le personnage a déjà cette arme dans son inventaire, on préférera incrémenter la quantité
                    /// plutôt que de rajouter la même arme
                    if (listeEquipementPersonnage != null && listeEquipementPersonnage.Any(arme => arme.Contains(nomArme)))
                    {
                        int nouvelleQte = 0;

                        if (GetQuantityEquipment != null)
                        {
                            nouvelleQte = GetQuantityEquipment(idArme, IdPersonnage);
                        }
                        else
                        {
                            throw new Exception("GetQuantityEquipment est null");
                        }

                        foreach (TabPage page in tabControlEquipment.TabPages)
                        {
                            foreach (Control control in page.Controls)
                            {
                                if ((string)control.Tag == nomArme && control is NumericUpDown)
                                {
                                    nouvelleQte += Convert.ToInt32((control as NumericUpDown).Value);
                                    goto SortieDesBoucles; // Utilisation de goto pour sortir des deux boucles
                                }
                            }
                        }

                    SortieDesBoucles: // On sort de la boucle directement après avoir trouvé le bon numericUpDown

                        if (UpdateEquipmentQuantity != null)
                        {
                            UpdateEquipmentQuantity(idArme, IdPersonnage, nouvelleQte);
                        }
                        else
                        {
                            throw new Exception("UpdateEquipmentQuantity est null");
                        }
                    }
                    else
                    {
                        if (AddNewEquipmentToInventairePersonnage != null)
                        {
                            AddNewEquipmentToInventairePersonnage(idArme, IdPersonnage, Convert.ToInt32(substring[1]));
                        }
                        else
                        {
                            throw new Exception("AddNewEquipmentToInventairePersonnage est null");
                        }
                    }
                }
            }

            /// Enfin, on met tous les champs textuels à jour
            // La RichTextBox d'armes
            rtbAcheterEquipement.Text = string.Empty;

            // La RichTextBox qui contient les ID à rajouter en base
            rTxtBxEquipments.Text = string.Empty;

            // Les labels poids et dépenses monnétaire
            lblTotalDepenseEquipement.Text = "0";
            lblPoidsEnPlusEquipment.Text = "0";

            ResetControlParent(tabControlEquipment);

            if (GetEquipmentsInInventairePersonnageToCreateControl != null)
            {
                GetEquipmentsInInventairePersonnageToCreateControl(panelVendreEquipement, IdPersonnage);
            }
            else
            {
                throw new Exception("GetEquipmentsInInventairePersonnageToCreateControl est null");
            }

            if (CreateCheckBoxVendre != null)
            {
                CreateCheckBoxVendre();
            }
            else
            {
                throw new Exception("CreateCheckBoxVendre est null");
            }
            // On met à jour le poids porté par le personnage et son argent
            RepartitionMoneyAfterBuyOrSell(achat, monnaiePersonnage, "Buy");
        }

        /// <summary>
        /// Répartit la différence entre l'achat et la monnaie que le joueur possédait
        /// </summary>
        /// <param name="price">le prix à payer</param>
        /// <param name="moneyPersonnage">l'argent qu'il détenait</param>
        public void RepartitionMoneyAfterBuyOrSell(int price, int moneyPersonnage, string buyOrSell)
        {
            int moneyToGet = (buyOrSell == "Buy") ? (moneyPersonnage - price) : (moneyPersonnage + price);

            nudPo.Value = moneyToGet / 100;
            nudPa.Value = (moneyToGet % 100) / 10;
            nudPc.Value = moneyToGet % 10;
        }

        /// <summary>
        /// Méthode pour réinitialiser les CheckBox et les NumericUpDown
        /// De tous les TabControl pour avoir leur valeur par défaut
        /// Après l'achat
        /// </summary>
        /// <param name="controlToReset"></param>
        public void ResetControlParent(object controlToReset)
        {
            /**
             * Cas Acheter (dans un TabControl)
             */
            if (controlToReset is TabControl)
            {
                TabControl tabControl = controlToReset as TabControl;

                foreach (TabPage page in tabControl.TabPages)
                {
                    foreach (object controls in page.Controls)
                    {
                        if (controls is CheckBox)
                        {
                            CheckBox checkBox = controls as CheckBox;
                            checkBox.Checked = false;
                        }
                        else if (controls is NumericUpDown)
                        {
                            NumericUpDown numericUpDown = controls as NumericUpDown;
                            numericUpDown.Value = 1;
                            numericUpDown.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                Panel panel = controlToReset as Panel;

                foreach (Control control in panel.Controls)
                {
                    if (control is CheckBox && (control as CheckBox).Checked)
                    {
                        CheckBox checkBox = control as CheckBox;
                        checkBox.Checked = false;
                    }
                    else if (control is NumericUpDown && (control as NumericUpDown).Value > 0)
                    {
                        NumericUpDown numericUpDown = control as NumericUpDown;
                        numericUpDown.Value = 1;
                        numericUpDown.Enabled = true;
                    }
                }
            }
        }

        /// <summary>
        /// Événement pour vérifier si les trois Panel pour activer ou désactiver les boutons vendre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlVendreEquipment_ControlAdded(object sender, ControlEventArgs e)
        {
            string tagControl = (sender as Panel).Tag as string;
            Button boutonVendreActiver = new Button();

            if (tagControl == "Armes")
            {
                boutonVendreActiver = btnVendreArmes;
            }
            else if (tagControl == "Armures")
            {
                boutonVendreActiver = btnVendreArmures;
            }
            else if (tagControl == "Objets")
            {
                boutonVendreActiver = btnVendreObjets;
            }

            boutonVendreActiver.Enabled = (sender as Panel).Controls.Count > 0 ? true : false;
        }
        /// <summary>
        /// Événement qui gère la vente d'équipement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendre_Click(object sender, EventArgs e)
        {
            #region Initialisation des variables
            // Primitifs
            string tagButton = (sender as Button).Tag as string;
            int achat = 0;
            int idEquipment = 0;
            int monnaiePersonnage = int.Parse(string.Format("{0}{1}{2}", nudPo.Value.ToString(), nudPa.Value.ToString(), nudPc.Value.ToString()));

            // Complexes
            Action<int, int> SellEquipment = null;
            Action<int, int, int> UpdateEquipment = null;
            Func<string, int> GetIdEquipmentByName = null;
            List<Control> controlsToDelete = new List<Control>();
            Panel panelTemplate = new Panel();
            RichTextBox rtxBxEquipment = new RichTextBox();
            Label lblTotalDepenseEquipment = new Label();
            Label lblTotalPoidsEnPlusEquipment = new Label();
            #endregion

            /**
             * #### ~~ ARMES ~~ ####
             */
            if (tagButton == "Armes")
            {
                // Toutes les variables prennent les informations pour les armes
                achat = Utils.DeleteMoneyValue(lblTotalDepenseArmes.Text);
                panelTemplate = pnlVendreArme;
                SellEquipment = EquipmentController.SellArmes;
                GetIdEquipmentByName = EquipmentController.GetIdArmeByName;
                UpdateEquipment = EquipmentController.UpdateArmesQuantity;
                rtxBxEquipment = rTxtBxArmes;
                lblTotalDepenseEquipment = lblTotalDepenseArmes;
                lblTotalPoidsEnPlusEquipment = lblPoidsEnPlusArmes;
            }
            /**
             * #### ~~ ARMURES ~~ ####
             */
            else if (tagButton == "Armures")
            {
                // Toutes les variables prennent les informations pour les armures
                achat = Utils.DeleteMoneyValue(lblTotalDepenseArmures.Text);
                panelTemplate = pnlVendreArmure;
                SellEquipment = EquipmentController.SellArmures;
                GetIdEquipmentByName = EquipmentController.GetIdArmureByName;
                UpdateEquipment = EquipmentController.UpdateArmuresQuantity;
                rtxBxEquipment = rTxtBxArmures;
                lblTotalDepenseEquipment = lblTotalDepenseArmures;
                lblTotalPoidsEnPlusEquipment = lblPoidsEnPlusArmures;
            }
            /**
             * #### ~~ OBJETS ~~ ####
             */
            else if (tagButton == "Objets")
            {
                // Toutes les variables prennent les informations pour les objets
                achat = Utils.DeleteMoneyValue(lblTotalDepenseObjets.Text);
                panelTemplate = pnlVendreObjet;
                SellEquipment = EquipmentController.SellObjets;
                GetIdEquipmentByName = EquipmentController.GetIdObjetByName;
                UpdateEquipment = EquipmentController.UpdateObjetsQuantity;
                rtxBxEquipment = rTxtBxObjets;
                lblTotalDepenseEquipment = lblTotalDepenseObjets;
                lblTotalPoidsEnPlusEquipment = lblPoidsEnPlusObjets;
            }

            foreach (Control controls in panelTemplate.Controls)
            {
                // on cherche les NumericUpDown associés à cet équipement et on vérifie qu'on vend bien
                // un équipement
                if (controls is NumericUpDown)
                {
                    NumericUpDown numericUpDown = controls as NumericUpDown;

                    if (GetIdEquipmentByName != null)
                    {
                        idEquipment = GetIdEquipmentByName(numericUpDown.Tag.ToString());
                    }
                    else
                    {
                        throw new Exception("GetIdEquipmentByName a été null !");
                    }

                    // Retrouve la CheckBox associé au tag pour s'assurer qu'elle soit cochée
                    CheckBox checkBox = FindCheckBoxInControlByTag(panelTemplate, numericUpDown.Tag.ToString());

                    if (numericUpDown.Value == numericUpDown.Maximum && checkBox.Checked)
                    {
                        if (SellEquipment != null)
                        {
                            SellEquipment(idEquipment, IdPersonnage);
                            controlsToDelete.Add(numericUpDown);
                        }
                        else
                        {
                            throw new Exception("SellEquipment a été null !");
                        }
                    }
                    else if (numericUpDown.Value < numericUpDown.Maximum && checkBox.Checked)
                    {
                        int nouvelleQteMax = Convert.ToInt32(numericUpDown.Maximum - numericUpDown.Value);

                        if (UpdateEquipment != null)
                        {
                            UpdateEquipment(idEquipment, IdPersonnage, nouvelleQteMax);
                        }
                        else
                        {
                            throw new Exception("UpdateEquipment a été null !");
                        }

                        ResetControlParent(panelTemplate);
                        numericUpDown.Maximum = nouvelleQteMax;
                    }
                }
            }

            // Supprimer les contrôles après l'itération principale
            foreach (Control control in controlsToDelete)
            {
                Utils.DeleteControlsFromPanelByTag(control.Tag?.ToString(), panelTemplate);
            }

            // On met à jour le poids porté par le personnage et son argent
            RepartitionMoneyAfterBuyOrSell(achat, monnaiePersonnage, "Sell");

            // La RichTextBox qui contient les ID à rajouter en base
            rtxBxEquipment.Text = string.Empty;

            // Les labels poids et dépenses monnétaire
            lblTotalDepenseEquipment.Text = "0";
            lblTotalPoidsEnPlusEquipment.Text = "0";
        }

        private CheckBox FindCheckBoxInControlByTag(object controlParent, string tag)
        {
            CheckBox checkBox = new CheckBox();

            if (controlParent is Panel)
            {
                checkBox = (controlParent as Panel).Controls.OfType<CheckBox>().Where(check => check.Tag as string == tag).FirstOrDefault();
            }

            return checkBox;
        }
    }
}
