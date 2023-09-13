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
            }
        }

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
    }
}
