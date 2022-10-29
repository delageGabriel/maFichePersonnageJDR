using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireCompAttri : Form
    {

        public FormulaireCompAttri()
        {
            InitializeComponent();
        }

        public void GetSettings()
        {
            txtPhysique.Text = Properties.Settings.Default.Physique;
            txtMental.Text = Properties.Settings.Default.Mental;
            txtSocial.Text = Properties.Settings.Default.Social;
        }
        private void FormulaireCompAttri_Load(object sender, EventArgs e)
        {
            GetSettings();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Physique = txtPhysique.Text;
            Properties.Settings.Default.Mental = txtMental.Text;
            Properties.Settings.Default.Social = txtSocial.Text;
            Properties.Settings.Default.Save();
        }

        private void txtPhysique_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMental_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSocial_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
