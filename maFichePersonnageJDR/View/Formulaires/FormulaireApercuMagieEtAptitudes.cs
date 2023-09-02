using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maFichePersonnageJDR.View.Formulaires
{
    public partial class FormulaireApercuMagieEtAptitudes : Form
    {
        public FormulaireApercuMagieEtAptitudes()
        {
            InitializeComponent();
        }

        public string TextLblNomMagieAptitude { get => lblTemplateNomMagieAptitude.Text; set => lblTemplateNomMagieAptitude.Text = value; }
        public string TextLblTypeMagieAptitude { get => lblTemplateTypeMagieAptitude.Text; set => lblTemplateTypeMagieAptitude.Text = value; }
        public string TextLblCoutMagieAptitude { get => lblTemplateCoutMagieAptitude.Text; set => lblTemplateCoutMagieAptitude.Text = value; }
        public string TextLblNiveauMagieAptitude { get => lblTemplateNiveauMagieAptitude.Text; set => lblTemplateNiveauMagieAptitude.Text = value; }
        public RichTextBox RchTextBxDescrMagieEtAptitude { get => rTxtBxTemplateDescrMagieAptitude; set => rTxtBxTemplateDescrMagieAptitude = value; }
    }
}
