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
    public partial class FormulaireApercuAttributs : Form
    {
        public FormulaireApercuAttributs()
        {
            InitializeComponent();
        }

        public string TextLblNom { get => lblTemplateNomAttribut.Text; set => lblTemplateNomAttribut.Text = value; }
        public string TextLblType { get => lblTemplateTypeAttribut.Text; set => lblTemplateTypeAttribut.Text = value; }
        public string TextLblDescription { get => rTxtBxTemplateDescrAttribut.Text; set => rTxtBxTemplateDescrAttribut.Text = value; }
        public string TextLblNote { get => rTxtBxNotesAttributs.Text; set => rTxtBxNotesAttributs.Text = value; }
    }
}
