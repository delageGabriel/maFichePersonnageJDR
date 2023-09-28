
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
            string idArme = EquipmentController.GetArmeIdByName(nomArme);

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
                double poids = double.Parse(lblPoidsEnPlusArmes.Text) - (EquipmentController.GetArmeWeightByName(nomArme) * qteReturn);

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
            string idArme = EquipmentController.GetArmeIdByName(nomArme);

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
                double poids = double.Parse(lblPoidsEnPlusArmes.Text) - (EquipmentController.GetArmeWeightByName(nomArme) * qteReturn);

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
            CheckBox checkBox = sender as CheckBox;
            string nomArmure = checkBox.Name.Substring(4);
            string armure = EquipmentController.GetArmureByName(nomArmure);
            int qteReturn = QuantityToReturn(nomArmure, (TabPage)checkBox.Parent);

            armure += qteReturn.ToString();

            if (checkBox.Checked)
            {
                // FR : Devrait ajouter le texte
                // EN : Should append text
                rTxtBxArmures.AppendText(armure + Environment.NewLine);
                int valeur = int.Parse(lblTotalDepenseArmures.Text) + (EquipmentController.GetArmureValueByName(nomArmure) * qteReturn);
                double poids = double.Parse(lblPoidsEnPlusArmures.Text) + (EquipmentController.GetArmureWeightByName(nomArmure) * qteReturn);

                lblTotalDepenseArmures.Text = Utils.ConvertMoneyWithValue(valeur);
                lblPoidsEnPlusArmures.Text = poids.ToString();
            }
            else
            {
                // FR : Récupération de l'index de la ligne à supprimer
                // EN : Retrieve the index of the line to be deleted
                int indexToDelete = Utils.GetLineNumberToDelete(armure, rTxtBxArmures);

                // FR : On récupère toutes les lignes sous la forme d'une liste
                // EN : All rows are retrieved in the form of a list
                List<string> lines = new List<string>(rTxtBxArmures.Lines);

                // FR : On supprime la ligne où l'on a trouvé le texte correspondant
                // EN : On supprime la ligne où l'on a trouvé le texte correspondan
                lines.Remove(armure);

                // FR : On réattribue les nouvelles lignes à celles de la RichTextBox
                // EN : Reassign the new lines to those in the RichTextBox
                rTxtBxArmures.Lines = lines.ToArray();
            }
        }

        /// <summary>
        /// Checkbox pour ajouter ou retirer une arme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void checkBoxObjet_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            string nomObjet = checkBox.Name.Substring(4);
            string objet = EquipmentController.GetObjetByName(nomObjet);
            int qteReturn = QuantityToReturn(nomObjet, (TabPage)checkBox.Parent);

            objet += qteReturn.ToString();

            if (checkBox.Checked)
            {
                // FR : Devrait ajouter le texte
                // EN : Should append text
                rTxtBxObjets.AppendText(objet + Environment.NewLine);
                int valeur = int.Parse(lblTotalDepenseObjets.Text) + (EquipmentController.GetObjetValueByName(nomObjet) * qteReturn);
                double poids = double.Parse(lblPoidsEnPlusObjets.Text) + (EquipmentController.GetObjetWeightByName(nomObjet) * qteReturn);

                lblTotalDepenseObjets.Text = Utils.ConvertMoneyWithValue(valeur);
                lblPoidsEnPlusObjets.Text = poids.ToString();
            }
            else
            {
                // FR : On récupère toutes les lignes sous la forme d'une liste
                // EN : All rows are retrieved in the form of a list
                List<string> lines = new List<string>(rTxtBxObjets.Lines);

                // FR : On supprime la ligne où l'on a trouvé le texte correspondant
                // EN : On supprime la ligne où l'on a trouvé le texte correspondan
                lines.Remove(objet);

                // FR : On réattribue les nouvelles lignes à celles de la RichTextBox
                // EN : Reassign the new lines to those in the RichTextBox
                rTxtBxObjets.Lines = lines.ToArray();
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

                    CheckBox checkBox = new CheckBox();
                    checkBox.Location = new Point(5 + pnlVendreArme.AutoScrollPosition.X, label.Location.Y + pnlVendreArme.AutoScrollPosition.Y);
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
                    Panel panel = new Panel();

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
            poidsTotal += Controller.EquipmentController.GetPoidsTotalArmeTransportees(IdPersonnage);
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
        /// Méthode pour vérfier s'il y a des armes à acheter et active ou
        /// désactive le bouton acheter en conséquence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbAcheterArmes_TextChanged(object sender, EventArgs e)
        {
            RichTextBox richTextBox = sender as RichTextBox;

            if (richTextBox.Lines.Length > 0)
            {
                btnAcheterArmes.Enabled = true;
            }
            else
            {
                btnAcheterArmes.Enabled = false;
            }
        }

        /// <summary>
        /// Bouton qui permet d'acheter toutes les armes sélectionnées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcheterArmes_Click(object sender, EventArgs e)
        {
            /// On commence par faire la différence et voir si le personnage
            /// a assez d'argent
            int achatArme = Utils.DeleteMoneyValue(lblTotalDepenseArmes.Text);
            int monnaiePersonnage = int.Parse(string.Format("{0}{1}{2}", nudPo.Value.ToString(), nudPa.Value.ToString(), nudPc.Value.ToString()));
            int differenceAchat = monnaiePersonnage - achatArme;

            // Si c'est pas le cas, on lui dit et on sort de la méthode
            if (differenceAchat < 0)
            {
                MessageBox.Show("Pas assez de monnaie !");
                return;
            }

            // Ensuite on parcourt la liste des armes achetées
            // pour les ajouter à l'inventaire d'armes du personnage
            foreach (string line in rTxtBxArmes.Lines)
            {
                if (!String.IsNullOrEmpty(line))
                {
                    string[] substring = line.Split(';');
                    EquipmentController.AddNewArmeToPersonnage(Convert.ToInt32(substring[0]),
                    IdPersonnage, Convert.ToInt32(substring[1]));
                }
            }

            // On met à jour le poids porté par le personnage et son argent
            RepartitionMoneyAfterBuyOrSell(achatArme, monnaiePersonnage, "Buy");

            /// Enfin, on met tous les champs textuels à jour
            // La RichTextBox d'armes
            rtbAcheterArmes.Text = string.Empty;

            // La RichTextBox qui contient les ID à rajouter en base
            rTxtBxArmes.Text = string.Empty;

            // Les labels poids et dépenses monnétaire
            lblTotalDepenseArmes.Text = "0";
            lblPoidsEnPlusArmes.Text = "0";

            ResetTabControl(tbCntlArmes);
            Controller.EquipmentController.GetArmesInInventairePersonnage(pnlVendreArme, IdPersonnage);
            CreateCheckBoxVendreArmes();
        }

        /// <summary>
        /// Répartit la différence entre l'achat et la monnaie que le joueur possédait
        /// </summary>
        /// <param name="price">le prix à payer</param>
        /// <param name="moneyPersonnage">l'argent qu'il détenait</param>
        public void RepartitionMoneyAfterBuyOrSell(int price, int moneyPersonnage, string buyOrSell)
        {
            int moneyToGet = 0;

            if (buyOrSell == "Buy")
                moneyToGet = moneyPersonnage - price;
            else
                moneyToGet = moneyPersonnage + price;


            if (moneyToGet >= 100)
            {
                /*
                 * PLUSIEURS CAS POSSIBLES :
                 * 100.000 PO
                 * 10.000 PO
                 * 1.000 PO
                 * 100 PO
                 */
                if (moneyToGet > 99999)
                {
                    // Décorticage de l'or
                    int valueOrCentaineMillier = (moneyToGet / 100000) % 10;
                    int valueOrDizaineMillier = (moneyToGet / 10000) % 10;
                    int valueOrMillier = (moneyToGet / 1000) % 10;
                    int valueOrCentaine = (moneyToGet / 100) % 10;

                    // Rajout des pièces d'argent et de cuivre
                    int valueArgent = (moneyToGet / 10) % 10;
                    int valueCuivre = moneyToGet % 10;

                    string valueOr = string.Format("{0}{1}{2}{3}", valueOrCentaineMillier, valueOrDizaineMillier, valueOrMillier, valueOrCentaine);

                    nudPo.Value = int.Parse(valueOr);
                    nudPa.Value = valueArgent;
                    nudPc.Value = valueCuivre;
                }
                else if (moneyToGet > 9999)
                {
                    // Décorticage de l'or
                    int valueOrDizaineMillier = (moneyToGet / 10000) % 10;
                    int valueOrMillier = (moneyToGet / 1000) % 10;
                    int valueOrCentaine = (moneyToGet / 100) % 10;

                    // Rajout des pièces d'argent et de cuivre
                    int valueArgent = (moneyToGet / 10) % 10;
                    int valueCuivre = moneyToGet % 10;

                    string valueOr = string.Format("{0}{1}{2}", valueOrDizaineMillier, valueOrMillier, valueOrCentaine);

                    nudPo.Value = int.Parse(valueOr);
                    nudPa.Value = valueArgent;
                    nudPc.Value = valueCuivre;
                }
                else if (moneyToGet > 999)
                {
                    // Décorticage de l'or
                    int valueOrMillier = (moneyToGet / 1000) % 10;
                    int valueOrCentaine = (moneyToGet / 100) % 10;

                    // Rajout des pièces d'argent et de cuivre
                    int valueArgent = (moneyToGet / 10) % 10;
                    int valueCuivre = moneyToGet % 10;

                    string valueOr = string.Format("{0}{1}", valueOrMillier, valueOrCentaine);

                    nudPo.Value = int.Parse(valueOr);
                    nudPa.Value = valueArgent;
                    nudPc.Value = valueCuivre;
                }
                else
                {
                    // Décorticage de l'or
                    int valueOrCentaine = (moneyToGet / 100) % 10;

                    // Rajout des pièces d'argent et de cuivre
                    int valueArgent = (moneyToGet / 10) % 10;
                    int valueCuivre = moneyToGet % 10;

                    nudPo.Value = valueOrCentaine;
                    nudPa.Value = valueArgent;
                    nudPc.Value = valueCuivre;
                }

            }
            else if (moneyToGet >= 10)
            {
                int valueArgent = (moneyToGet / 10) % 10;
                int valueCuivre = moneyToGet % 10;

                nudPa.Value = valueArgent;
                nudPc.Value = valueCuivre;
            }
            else
            {
                int valueCuivre = moneyToGet % 10;

                nudPc.Value = valueCuivre;
            }

            nudPo_ValueChanged(nudPo, EventArgs.Empty);
            nudPa_ValueChanged(nudPa, EventArgs.Empty);
            nudPc_ValueChanged(nudPc, EventArgs.Empty);
        }

        public void ResetTabControl(TabControl controlToReset)
        {
            foreach (TabPage page in controlToReset.TabPages)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlVendreArme_ControlAdded(object sender, ControlEventArgs e)
        {
            Panel panel = sender as Panel;

            if (panel.Controls.Count > 0)
            {
                btnVendreArmes.Enabled = true;
            }
            else
            {
                btnVendreArmes.Enabled = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendreArmes_Click(object sender, EventArgs e)
        {
            /// On commence par faire la différence et voir si le personnage
            /// a assez d'argent
            int achatArme = Utils.DeleteMoneyValue(lblTotalDepenseArmes.Text);
            int monnaiePersonnage = int.Parse(string.Format("{0}{1}{2}", nudPo.Value.ToString(), nudPa.Value.ToString(), nudPc.Value.ToString()));

            foreach (object controls in pnlVendreArme.Controls)
            {
                if (controls is NumericUpDown)
                {
                    NumericUpDown numericUpDown = controls as NumericUpDown;

                    if (numericUpDown.Value >= 1)
                    {
                        EquipmentController.SellArmes(EquipmentController.GetIdArmeByName(numericUpDown.Tag.ToString()), IdPersonnage);
                        Utils.DeleteControlsFromPanelByTag(numericUpDown.Tag.ToString(), pnlVendreArme);
                    }
                }
            }

            // On met à jour le poids porté par le personnage et son argent
            RepartitionMoneyAfterBuyOrSell(achatArme, monnaiePersonnage, "Sell");

            // La RichTextBox qui contient les ID à rajouter en base
            rTxtBxArmes.Text = string.Empty;

            // Les labels poids et dépenses monnétaire
            lblTotalDepenseArmes.Text = "0";
            lblPoidsEnPlusArmes.Text = "0";
        }
    }
}
