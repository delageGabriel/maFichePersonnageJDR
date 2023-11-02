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
        private string[] lstAttributsCheck = { 
            "Alifère", 
            "Armure naturelle", 
            "Avantage du terrain", 
            "Canaliseur", 
            "Frigifugé", 
            "Gigantisme", 
            "Ignifugé", 
            "Magicien",
            "Porteur de charges lourdes"
        };

        private System.Collections.Generic.Dictionary<Control, Rectangle> dictionaryControlOriginalSize = new System.Collections.Generic.Dictionary<Control, Rectangle>();

        public int IdDuPersonnage { get => idDuPersonnage; set => idDuPersonnage = value; }
        public FormulaireAttributs()
        {
            InitializeComponent();
        }

        private void FormulaireAttributs_Load(object sender, EventArgs e)
        {
            GetAttributs();
            CreateCheckBoxAttribut();
            dictionaryControlOriginalSize.Add(this, new Rectangle(this.Location, this.Size));
            dictionaryControlOriginalSize.Add(tbControlAttributs, new Rectangle(tbControlAttributs.Location, tbControlAttributs.Size));
            dictionaryControlOriginalSize.Add(rtbAttributs, new Rectangle(rtbAttributs.Location, rtbAttributs.Size));
            dictionaryControlOriginalSize.Add(btnSauvegarder, new Rectangle(btnSauvegarder.Location, btnSauvegarder.Size));
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
                if (lstAttributsCheck.Contains(attribut))
                {
                    attribut += AttributesSpecifications(attribut);
                }
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

        /// <summary>
        /// Obtient le nombre d'attributs qu'un personnage peut gagner par niveau
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Permet d'activer ou désactiver les CheckBox attributs
        /// </summary>
        /// <param name="page"></param>
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
            Dictionary<int, string> dictionnaireIdSpecificationsAttribut = new Dictionary<int, string>();
            List<int> listeIdAttributs = new List<int>();
            FormulaireCompetencesCaracteristiques formulaireCompetencesCaracteristiques = new FormulaireCompetencesCaracteristiques();
            int nbCaseCocher = 0;
            string specifications = string.Empty;
            #endregion

            try
            {
                /// On récupère le nombre de CheckBox cochées
                foreach (Control control in tbPgeAttributs.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox checkBox = control as CheckBox;
                        nbCaseCocher += checkBox.Checked ? 1 : 0;
                    }
                }

                /**
                 * Test BON NOMBRE ATTRIBUTS
                 */
                if (nbCaseCocher < AttributsLimitations(IdDuPersonnage))
                {
                    MessageBox.Show(string.Format("Il vous reste {0} à donner à votre personnage", AttributsLimitations(IdDuPersonnage) - nbCaseCocher));
                    return;
                }

                // On commence par récupérer l'id de l'attribut
                foreach (string line in rtbAttributs.Lines)
                {
                    string[] substring = line.Split(';');

                    if (substring.Length > 1)
                    {
                        int idAttribut = AttributsController.GetIdAttributByName(substring[0]);
                        string nomAttribut = substring[1];

                        dictionnaireIdSpecificationsAttribut.Add(idAttribut, nomAttribut);
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(substring[0]))
                        {
                            AttributsController.AddNewAttributToPersonnage(AttributsController.GetIdAttributByName(substring[0]), IdDuPersonnage, "Aucunes");
                        }
                    }
                }

                foreach (var keyValue in dictionnaireIdSpecificationsAttribut)
                {
                    int idAttribut = keyValue.Key;
                    string specificationsAttr = keyValue.Value;
                    AttributsController.AddNewAttributToPersonnage(idAttribut, IdDuPersonnage, specificationsAttr);
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

        private string AttributesSpecifications(string nameAttribut)
        {
            using (FormSpecificationAttributs formSpecification = new FormSpecificationAttributs())
            {

                formSpecification.PanelAvantageTerrains.Enabled = false;
                formSpecification.PanelMagies.Enabled = false;
                formSpecification.NumericUpDownPourcentage.Enabled = false;

                if (nameAttribut == "Magicien")
                {
                    formSpecification.TextInput.Enabled = false;
                    formSpecification.PanelMagies.Enabled = true;
                }
                else if (nameAttribut == "Avantage du terrain")
                {
                    formSpecification.TextInput.Enabled = false;
                    formSpecification.PanelAvantageTerrains.Enabled = true;
                }
                else if (nameAttribut == "Porteur de charges lourdes")
                {
                    formSpecification.TextInput.Enabled = false;
                    formSpecification.NumericUpDownPourcentage.Enabled = true;
                }
                if (formSpecification.ShowDialog() == DialogResult.OK)
                {
                    return "; " + formSpecification.UserInput;
                }
            }

            return string.Empty;
        }

        private void FormulaireAttributs_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Width / dictionaryControlOriginalSize[this].Width;
            float yRatio = (float)this.Height / dictionaryControlOriginalSize[this].Height;

            foreach (System.Collections.Generic.KeyValuePair<Control, Rectangle> entry in dictionaryControlOriginalSize)
            {
                Utils.AdjustControlSizeAndPosition(entry.Key, entry.Value, xRatio, yRatio);
            }
        }
    }
}
