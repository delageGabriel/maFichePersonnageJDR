using maFichePersonnageJDR.Controller;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireMagieEtAptitudes : Form
    {
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
        public void linkLabelMagie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuMagieEtAptitudes formulaireApercuMagieEtAptitudes = new FormulaireApercuMagieEtAptitudes();

            LinkLabel linkLabel = sender as LinkLabel;
            TabPage tabPage = linkLabel.Parent as TabPage;

            MagieController.GetApercuMagie(formulaireApercuMagieEtAptitudes, linkLabel.Text);
            formulaireApercuMagieEtAptitudes.Show();
        }

        private void FormulaireMagieEtAptitudes_Load(object sender, EventArgs e)
        {
            GetMagies();
        }
    }
}
