
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

        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }

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
            CheckBox checkBox = sender as CheckBox;
            string nomArme = checkBox.Name.Substring(4);
            string arme = EquipmentController.GetArmeByName(nomArme);
            int qteReturn = QuantityToReturn(nomArme, (TabPage)checkBox.Parent);

            arme += qteReturn.ToString();

            if (checkBox.Checked)
            {
                // FR : Devrait ajouter le texte
                // EN : Should append text
                rTxtBxArmes.AppendText(arme + Environment.NewLine);
                int valeur = int.Parse(lblTotalDepenseArmes.Text) + (EquipmentController.GetArmeValueByName(nomArme) * qteReturn);
                double poids = double.Parse(lblPoidsEnPlusArmes.Text) + (EquipmentController.GetArmeWeightByName(nomArme) * qteReturn);
                lblTotalDepenseArmes.Text = valeur.ToString();
                lblPoidsEnPlusArmes.Text = poids.ToString();
            }
            else
            {
                // FR : On récupère toutes les lignes sous la forme d'une liste
                // EN : All rows are retrieved in the form of a list
                List<string> lines = new List<string>(rTxtBxArmes.Lines);

                // FR : On supprime la ligne où l'on a trouvé le texte correspondant
                // EN : On supprime la ligne où l'on a trouvé le texte correspondan
                lines.Remove(arme);

                // FR : On réattribue les nouvelles lignes à celles de la RichTextBox
                // EN : Reassign the new lines to those in the RichTextBox
                rTxtBxArmes.Lines = lines.ToArray();
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
                rTxtBxArmes.AppendText(armure + Environment.NewLine);
                int valeur = int.Parse(lblTotalDepenseArmures.Text) + (EquipmentController.GetArmureValueByName(nomArmure) * qteReturn);
                double poids = double.Parse(lblPoidsEnPlusArmures.Text) + (EquipmentController.GetArmureWeightByName(nomArmure) * qteReturn);
                lblTotalDepenseArmures.Text = valeur.ToString();
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
                rTxtBxArmes.AppendText(objet + Environment.NewLine);
                int valeur = int.Parse(lblTotalDepenseObjets.Text) + (EquipmentController.GetObjetValueByName(nomObjet) * qteReturn);
                double poids = double.Parse(lblPoidsEnPlusObjets.Text) + (EquipmentController.GetObjetWeightByName(nomObjet) * qteReturn);
                lblTotalDepenseObjets.Text = valeur.ToString();
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
        public int QuantityToReturn(string tagControl, TabPage page)
        {
            // Variable quantité à retourner
            int value = 1;

            try
            {

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

                return value;
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
                // ARMES
                foreach (string line in rTxtBxArmes.Lines)
                {
                    if (!String.IsNullOrEmpty(line))
                    {
                        string[] substring = line.Split(';');
                        EquipmentController.AddNewArmeToPersonnage(Convert.ToInt32(substring[0]),
                        IdPersonnage, Convert.ToInt32(substring[1]));
                    }
                }

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
    }
}
