using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maFichePersonnageJDR.Controller;
using maFichePersonnageJDR.View.Formulaires;

namespace maFichePersonnageJDR.View.Formulaires
{
    public partial class FormulaireAttributs : Form
    {
        public FormulaireAttributs()
        {
            InitializeComponent();
        }

        private void FormulaireAttributs_Load(object sender, EventArgs e)
        {
            GetAttributs();
        }

        /// <summary>
        /// Remplit chaque TabPages du TabControl Armes avec les armes correspondantes.
        /// </summary>
        public void GetAttributs()
        {
            Console.WriteLine("########### Classe : FormulaireAttributs; Méthode : GetAttributs; ###########");

            try
            {
                Controller.AttributsController.GetAttributs(tbControlAttributs, tbPgeAttributs);
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
    }
}
