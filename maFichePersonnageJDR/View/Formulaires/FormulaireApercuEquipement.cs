using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maFichePersonnageJDR.Classe;
using System.Data.SQLite;

namespace maFichePersonnageJDR.View.Formulaires
{
    public partial class FormulaireApercuEquipement : Form
    {
        public FormulaireApercuEquipement()
        {
            InitializeComponent();
        }

        public string TextLblNom { get => lblTemplateNom.Text; set => lblTemplateNom.Text = value; }
        public string TextLblType { get => lblTemplateType.Text; set => lblTemplateType.Text = value; }
        public string TextLblPoids { get => lblTemplatePoids.Text; set => lblTemplatePoids.Text = value; }
        public string TextLblValeur { get => lblTemplateValeur.Text; set => lblTemplateValeur.Text = value; }
        public string TextLblDescription { get => rTxtBxTemplateDescr.Text; set => rTxtBxTemplateDescr.Text = value; }
        public Label TextLblAllonge { get => lblTemplateAllonge; set => lblTemplateAllonge = value; }
        public Label LabelAllonge { get => lblAllongeArme; set => lblAllongeArme = value; }
        public Label TextLblMains { get => lblTemplateMains; set => lblTemplateMains = value; }
        public Label LabelMains { get => lblMainsArmes; set => lblMainsArmes = value; }
        public Label TextLblDegats { get => lblTemplateDegatsArmes; set => lblTemplateDegatsArmes = value; }
        public Label LabelDegats { get => lblDegatsArmes; set => lblDegatsArmes = value; }
        public Label LabelBonus { get => lblBonusArmure; set => lblBonusArmure = value; }
        public Label TextLblBonus { get => lblTemplateBonusArmure; set => lblTemplateBonusArmure = value; }
        public Label LabelProtection { get => lblProtectionArmure; set => lblTemplateProtection = value; }
        public Label TextLblProtection { get => lblTemplateProtection; set => lblTemplateProtection = value; }
        public string TextLblSpecial { get => rTxtBxSpecial.Text; set => rTxtBxSpecial.Text = value; }
    }
}
