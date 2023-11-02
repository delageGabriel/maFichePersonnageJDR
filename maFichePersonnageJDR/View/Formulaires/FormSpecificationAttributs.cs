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
    public partial class FormSpecificationAttributs : Form
    {
        private System.Collections.Generic.Dictionary<Control, Rectangle> dictionaryControlOriginalSize = new System.Collections.Generic.Dictionary<Control, Rectangle>();

        public string UserInput { get; private set; }
        public TextBox TextInput { get => txtSpec; set => txtSpec = value; }
        public Panel PanelMagies { get => pnlMgie; set => pnlMgie = value; }
        public Panel PanelAvantageTerrains { get => pnlAvntgeTerrains; set => pnlAvntgeTerrains = value; }
        public NumericUpDown NumericUpDownPourcentage { get => nudPourcentage; set => nudPourcentage = value; }
        public FormSpecificationAttributs()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            UserInput = txtSpec.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CheckBox_Click(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                txtSpec.Text += (sender as CheckBox).Text + ", ";
            }
            else
            {
                txtSpec.Text = txtSpec.Text.Replace((sender as CheckBox).Text + ", ", string.Empty);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment annuler l'opération ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Vérifier la réponse de l'utilisateur
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nudPourcentage_ValueChanged(object sender, EventArgs e)
        {
            txtSpec.Text = nudPourcentage.Value.ToString();
        }

        private void FormSpecificationAttributs_Load(object sender, EventArgs e)
        {
            dictionaryControlOriginalSize.Add(this, new Rectangle(this.Location, this.Size));
            dictionaryControlOriginalSize.Add(pnlMgie, new Rectangle(pnlMgie.Location, pnlMgie.Size));
            dictionaryControlOriginalSize.Add(pnlAvntgeTerrains, new Rectangle(pnlAvntgeTerrains.Location, pnlAvntgeTerrains.Size));
            dictionaryControlOriginalSize.Add(nudPourcentage, new Rectangle(nudPourcentage.Location, nudPourcentage.Size));
            dictionaryControlOriginalSize.Add(txtSpec, new Rectangle(txtSpec.Location, txtSpec.Size));
            dictionaryControlOriginalSize.Add(btnOk, new Rectangle(btnOk.Location, btnOk.Size));
            dictionaryControlOriginalSize.Add(btnCancel, new Rectangle(btnCancel.Location, btnCancel.Size));

            foreach(Control control in pnlMgie.Controls)
            {
                dictionaryControlOriginalSize.Add(control, new Rectangle(control.Location, control.Size));
            }

            foreach (Control control in pnlAvntgeTerrains.Controls)
            {
                dictionaryControlOriginalSize.Add(control, new Rectangle(control.Location, control.Size));
            }
        }

        private void FormSpecificationAttributs_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Width / dictionaryControlOriginalSize[this].Width;
            float yRatio = (float)this.Height / dictionaryControlOriginalSize[this].Height;

            foreach (System.Collections.Generic.KeyValuePair<Control, Rectangle> entry in dictionaryControlOriginalSize)
            {
                Utils.AdjustControlSizeAndPosition(entry.Key, entry.Value, xRatio, yRatio);
            }
        }
    }
}
