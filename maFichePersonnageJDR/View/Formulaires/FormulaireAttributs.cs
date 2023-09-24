using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using maFichePersonnageJDR.Classe;
using maFichePersonnageJDR.Controller;

namespace maFichePersonnageJDR.View.Formulaires
{
    public partial class FormulaireAttributs : Form
    {
        private int idDuPersonnage;
        public int IdDuPersonnage { get => idDuPersonnage; set => idDuPersonnage = value; }
        public FormulaireAttributs()
        {
            InitializeComponent();
        }

        private void FormulaireAttributs_Load(object sender, EventArgs e)
        {
            GetAttributs();
            CreateCheckBoxAttribut();
        }

        /// <summary>
        /// Remplit chaque TabPages du TabControl Armes avec les armes correspondantes.
        /// </summary>
        public void GetAttributs()
        {
            Console.WriteLine("########### Classe : FormulaireAttributs; Méthode : GetAttributs; ###########");

            try
            {
                FormulaireAttributs formulaireAttributs = new FormulaireAttributs();
                formulaireAttributs = Controller.AttributsController.GetAttributs(tbControlAttributs, tbPgeAttributs);
            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine("########### FIN Méthode GetAttributs ###########");
        }

        public void linkLabelAttribut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuAttributs formulaireApercuAttributs = new FormulaireApercuAttributs();
            LinkLabel linkLabel = sender as LinkLabel;

            AttributsController.GetApercuAttribut(formulaireApercuAttributs, linkLabel.Text);
            formulaireApercuAttributs.Show();
        }

        /// <summary>
        /// Méthode pour ajouter un attribut à la richtextbox
        /// au clic sur ces dernières
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void checkBox_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            string attribut = AttributsController.GetAttributByName(checkBox.Name.Substring(4));

            if (checkBox.Checked)
            {
                // FR : Devrait ajouter le texte
                // EN : Should append text
                rtbAttributs.AppendText(attribut + Environment.NewLine);
                DisableOrCheckBox(tbPgeAttributs);
            }
            else
            {
                // FR : Récupération de l'index de la ligne à supprimer
                // EN : Retrieve the index of the line to be deleted
                int indexToDelete = Utils.GetLineNumberToDelete(attribut, rtbAttributs);

                // FR : On récupère toutes les lignes sous la forme d'une liste
                // EN : All rows are retrieved in the form of a list
                List<string> lines = new List<string>(rtbAttributs.Lines);

                // FR : On supprime la ligne où l'on a trouvé le texte correspondant
                // EN : On supprime la ligne où l'on a trouvé le texte correspondan
                lines.RemoveAt(indexToDelete);

                // FR : On réattribue les nouvelles lignes à celles de la RichTextBox
                // EN : Reassign the new lines to those in the RichTextBox
                rtbAttributs.Lines = lines.ToArray();
                DisableOrCheckBox(tbPgeAttributs);
            }
        }

        /// <summary>
        /// Créez les checkbox associées aux attributs
        /// </summary>
        public void CreateCheckBoxAttribut()
        {
            int y = 30;

            foreach (object controls in tbPgeAttributs.Controls)
            {
                if (controls is LinkLabel)
                {
                    LinkLabel linkLabel = controls as LinkLabel;

                    CheckBox checkBox = new CheckBox();
                    checkBox.Location = new Point(5, y);
                    checkBox.Name = ("chck" + linkLabel.Name.Substring(6));
                    checkBox.Click += checkBox_Click;

                    tbPgeAttributs.Controls.Add(checkBox);
                    y += 25;
                }
            }
        }

        public int AttributsLimitations(int idPersonnage)
        {
            int nbAttributes = 0;
            int niveauPersonnage = PersonnageController.GetNiveauPersonnage(idPersonnage);

            if (niveauPersonnage <= 3)
                nbAttributes = 2;
            else if (niveauPersonnage > 3 && niveauPersonnage < 6)
                nbAttributes = 3;
            else if (niveauPersonnage > 5 && niveauPersonnage < 7)
                nbAttributes = 4;
            else if (niveauPersonnage > 7 && niveauPersonnage < 9)
                nbAttributes = 6;
            else if (niveauPersonnage > 8 && niveauPersonnage < 13)
                nbAttributes = 7;
            else if (niveauPersonnage > 12 && niveauPersonnage < 14)
                nbAttributes = 8;
            else if (niveauPersonnage > 13 && niveauPersonnage < 15)
                nbAttributes = 9;
            else if (niveauPersonnage > 14 && niveauPersonnage < 17)
                nbAttributes = 11;
            else if (niveauPersonnage > 16 && niveauPersonnage < 18)
                nbAttributes = 12;
            else if (niveauPersonnage > 19)
                nbAttributes = 13;

            return nbAttributes;
        }

        public void DisableOrCheckBox(TabPage page)
        {
            int nbCheckBoxChecked = 0;
            int nbAttributParNiveau = AttributsLimitations(IdDuPersonnage);

            foreach (object controls in page.Controls)
            {
                if (controls is CheckBox)
                {
                    CheckBox checkBox = controls as CheckBox;
                    nbCheckBoxChecked += checkBox.Checked ? 1 : 0;
                }
            }

            if (nbCheckBoxChecked == nbAttributParNiveau)
            {
                foreach (object controls in page.Controls)
                {
                    if (controls is CheckBox)
                    {
                        CheckBox checkBox = controls as CheckBox;
                        checkBox.Enabled = checkBox.Checked ? true : false;
                    }
                }
            }
            else
            {
                foreach (object controls in page.Controls)
                {
                    if (controls is CheckBox)
                    {
                        CheckBox checkBox = controls as CheckBox;
                        checkBox.Enabled = true;
                    }
                }
            }
        }
        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            #region Initialisation des variables
            List<int> listeIdAttributs = new List<int>();
            FormulaireCompetencesCaracteristiques formulaireCompetencesCaracteristiques = new FormulaireCompetencesCaracteristiques();
            #endregion

            try
            {
                // On commence par récupérer l'id de l'attribut
                foreach (string line in rtbAttributs.Lines)
                {
                    string[] substring = line.Split(',');

                    if (substring.Length > 1)
                    {
                        listeIdAttributs.Add(Controller.AttributsController.GetIdAttributByName(substring[0].Substring(5)));
                    }

                }

                foreach (int idAttribut in listeIdAttributs)
                {
                    Controller.AttributsController.AddNewAttributToPersonnage(idAttribut, IdDuPersonnage);
                }

                formulaireCompetencesCaracteristiques.IdDuPersonnage = IdDuPersonnage;
                MessageBox.Show("Attributs sauvegardés");

                formulaireCompetencesCaracteristiques.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
