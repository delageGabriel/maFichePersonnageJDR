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

        public void linkLabelMagie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuEquipement formulaireApercuEquipement = new FormulaireApercuEquipement();

            LinkLabel linkLabel = sender as LinkLabel;
            TabPage tabPage = linkLabel.Parent as TabPage;

            EquipmentController.GetApercuArmes(formulaireApercuEquipement, linkLabel.Text);
            formulaireApercuEquipement.Show();
        }
    }
}
