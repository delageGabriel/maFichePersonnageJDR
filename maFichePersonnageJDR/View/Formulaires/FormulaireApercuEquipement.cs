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
        public Label LabelProtection { get => lblProtectionArmure; set => lblProtectionArmure = value; }
        public RichTextBox TextLblProtection { get => rTxtBxProtection; set => rTxtBxProtection = value; }
        public Label LabelConsommable { get => lblConsommable; set => lblConsommable = value; }
        public Label TextLblConsommable { get => lblTemplateConsommable; set => lblTemplateConsommable = value; }
        public string TextLblSpecial { get => rTxtBxSpecial.Text; set => rTxtBxSpecial.Text = value; }

        private Dictionary<Control, Rectangle> dictionaryControlOriginalSize = new Dictionary<Control, Rectangle>();
        private Dictionary<Label, Tuple<Rectangle, float>> dictionaryLabelOriginalSize = new Dictionary<Label, Tuple<Rectangle, float>>();

        private void FormulaireApercuEquipement_Load(object sender, EventArgs e)
        {
            dictionaryControlOriginalSize.Add(this, new Rectangle(this.Location, this.Size));

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    dictionaryLabelOriginalSize.Add(ctrl as Label, new Tuple<Rectangle, float>(new Rectangle(ctrl.Location, ctrl.Size), (ctrl as Label).Font.Size));
                }
                else
                {
                    dictionaryControlOriginalSize.Add(ctrl, new Rectangle(ctrl.Location, ctrl.Size));
                }
            }
        }

        private void FormulaireApercuEquipement_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Width / dictionaryControlOriginalSize[this].Width;
            float yRatio = (float)this.Height / dictionaryControlOriginalSize[this].Height;

            foreach (KeyValuePair<Label, Tuple<Rectangle, float>> entry in dictionaryLabelOriginalSize)
            {
                Utils.AdjustLabelSizeAndPosition(entry.Key, entry.Value.Item1, entry.Value.Item2, xRatio, yRatio);
            }
            foreach (KeyValuePair<Control, Rectangle> entry in dictionaryControlOriginalSize)
            {
                Utils.AdjustControlSizeAndPosition(entry.Key, entry.Value, xRatio, yRatio);
            }

            this.Refresh();
        }
    }
}
