using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maFichePersonnageJDR.Formulaires;

namespace maFichePersonnageJDR
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFormCompAttri_Click(object sender, EventArgs e)
        {
            FormulaireCompAttri frmCA = new FormulaireCompAttri();
            frmCA.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInfosGenerales_Click(object sender, EventArgs e)
        {
            FormulaireInfosGenerales frmIG = new FormulaireInfosGenerales();
            frmIG.Show();
        }

        private void btnTalentEtEquipement_Click(object sender, EventArgs e)
        {
            FormulaireTalentsEtObjets frmTO = new FormulaireTalentsEtObjets();
            frmTO.Show();
        }
    }
}
