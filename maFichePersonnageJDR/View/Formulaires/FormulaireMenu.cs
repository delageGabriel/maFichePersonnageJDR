using maFichePersonnageJDR.Formulaires;
using System;
using System.Windows.Forms;

namespace maFichePersonnageJDR.View.Formulaires
{
    public partial class FormulaireMenu : Form
    {
        public FormulaireMenu()
        {
            InitializeComponent();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            FormulaireEquipments frmEquipment = new FormulaireEquipments();
            frmEquipment.Show();
        }

        private void btnMagieAptitudes_Click(object sender, EventArgs e)
        {
            FormulaireMagieEtAptitudes frmMagieEtAptitudes = new FormulaireMagieEtAptitudes();
            frmMagieEtAptitudes.Show();
        }

        private void btnInformationsGenerales_Click(object sender, EventArgs e)
        {
            FormulaireInfosGenerales frmIG = new FormulaireInfosGenerales();
            frmIG.Show();
        }
    }
}
