using maFichePersonnageJDR.Classe;
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

        private Dictionary<Control, Rectangle> dictionaryControlOriginalSize = new Dictionary<Control, Rectangle>();
        private Dictionary<Label, Tuple<Rectangle, float>> dictionaryLabelOriginalSize = new Dictionary<Label, Tuple<Rectangle, float>>();

        private void FormulaireApercuMagieEtAptitudes_Load(object sender, EventArgs e)
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

        private void FormulaireApercuMagieEtAptitudes_Resize(object sender, EventArgs e)
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
