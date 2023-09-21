using maFichePersonnageJDR.Controller;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireMagieEtAptitudes : Form
    {
        private int idPersonnage;

        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public FormulaireMagieEtAptitudes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Remplit chaque TabPages du TabControl Armes avec les armes correspondantes.
        /// </summary>
        public void GetMagies()
        {
            Console.WriteLine("########### Classe : FormulaireMagieEtAptitudes; Méthode : GetMagies; ###########");

            try
            {
                foreach (TabPage page in tbCntlMagie.TabPages)
                {
                    Controller.MagieController.GetMagiesByType(page.Text, tbCntlMagie, page);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine("########### FIN Méthode GetMagies ###########");
        }

        /// <summary>
        /// Remplit chaque TabPages du TabControl Armes avec les armes correspondantes.
        /// </summary>
        public void GetAptitudes()
        {
            Console.WriteLine("########### Classe : FormulaireMagieEtAptitudes; Méthode : GetAptitudes; ###########");

            try
            {
                foreach (TabPage page in tbCntlAptitudes.TabPages)
                {
                    Controller.AptitudesController.GetAptitudesByType(page.Text, tbCntlAptitudes, page);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine("########### FIN Méthode GetMagies ###########");
        }

        /// <summary>
        /// Donne un aperçu de la magie cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void linkLabelMagie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuMagieEtAptitudes formulaireApercuMagieEtAptitudes = new FormulaireApercuMagieEtAptitudes();

            LinkLabel linkLabel = sender as LinkLabel;
            TabPage tabPage = linkLabel.Parent as TabPage;

            MagieController.GetApercuMagie(formulaireApercuMagieEtAptitudes, linkLabel.Text);
            formulaireApercuMagieEtAptitudes.Show();
        }

        /// <summary>
        /// Donne un aperçu de l'aptitude cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void linkLabelAptitude_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuMagieEtAptitudes formulaireApercuMagieEtAptitudes = new FormulaireApercuMagieEtAptitudes();

            LinkLabel linkLabel = sender as LinkLabel;
            TabPage tabPage = linkLabel.Parent as TabPage;

            AptitudesController.GetAptitudeByName(formulaireApercuMagieEtAptitudes, linkLabel.Text, tabPage.Text);
            formulaireApercuMagieEtAptitudes.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormulaireMagieEtAptitudes_Load(object sender, EventArgs e)
        {
            GetMagies();
            GetAptitudes();
            CreateCheckBoxMagie();
            CreateCheckBoxAptitudes();
        }

        /// <summary>
        /// Créer les checkbox magie
        /// </summary>
        public void CreateCheckBoxMagie()
        {
            // On parcourt toute la liste des armes
            foreach (TabPage page in tbCntlMagie.TabPages)
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
                        checkBox.Click += checkBoxMagie_Click;

                        page.Controls.Add(checkBox);
                        y += 25;
                    }
                }
            }
        }

        /// <summary>
        /// Créer les checkbox aptitudes
        /// </summary>
        public void CreateCheckBoxAptitudes()
        {
            // On parcourt toute la liste des armes
            foreach (TabPage page in tbCntlAptitudes.TabPages)
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
                        checkBox.Click += checkBoxAptitude_Click;

                        page.Controls.Add(checkBox);
                        y += 25;
                    }
                }
            }
        }

        /// <summary>
        /// Checkbox pour ajouter ou retirer une arme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void checkBoxMagie_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            string nomMagie = checkBox.Name.Substring(4);
            string magie = MagieController.GetIdMagieByName(nomMagie);

            if (checkBox.Checked)
            {
                // FR : Devrait ajouter le texte
                // EN : Should append text
                rtbMagies.AppendText(magie + Environment.NewLine);
            }
            else
            {

            }
        }

        /// <summary>
        /// Checkbox pour ajouter ou retirer une arme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void checkBoxAptitude_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            string nomAptitude = checkBox.Name.Substring(4);
            string aptitude = AptitudesController.GetIdAptitudeByName(nomAptitude);

            if (checkBox.Checked)
            {
                // FR : Devrait ajouter le texte
                // EN : Should append text
                rtbAptitudes.AppendText(aptitude + Environment.NewLine);
            }
            else
            {

            }
        }

        private void btnFinaliserFiche_Click(object sender, EventArgs e)
        {
            Classe.ClassePdf classePdf = new Classe.ClassePdf();

            // MAGIE
            foreach (string line in rtbMagies.Lines)
            {
                if (!String.IsNullOrEmpty(line))
                {
                    string[] substring = line.Split(';');
                    MagieController.AddNewMagieToPersonnage(Convert.ToInt32(substring[0]),
                    IdPersonnage);
                }
            }

            // APTITUDES
            foreach (string line in rtbAptitudes.Lines)
            {
                if (!String.IsNullOrEmpty(line))
                {
                    string[] substring = line.Split(';');
                    AptitudesController.AddNewAptitudeToPersonnage(Convert.ToInt32(substring[0]),
                    IdPersonnage);
                }
            }

            classePdf.IdPersonnage = IdPersonnage;
        }
    }
}
