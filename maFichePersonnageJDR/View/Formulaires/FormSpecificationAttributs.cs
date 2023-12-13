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
        public Panel PanelPourcentage { get => pnlPourcentage; set => pnlPourcentage = value; }
        public NumericUpDown NudNombre { get => nudNombre; set => nudNombre = value; }
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
            // On veut obtenir le nombre de CheckBox totales cliquables, en fonction du niveau du personnage
            int niveauPersonnage = Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage);
            int limitationMagies = 2;

            if (niveauPersonnage <= 2)
                limitationMagies = 2;
            else if (niveauPersonnage <= 4)
                limitationMagies = 3;
            else if (niveauPersonnage <= 6)
                limitationMagies = 4;
            else if (niveauPersonnage <= 10)
                limitationMagies = 6;
            else if (niveauPersonnage <= 14)
                limitationMagies = 7;
            else
                limitationMagies = 8;
                
            int nbCheckBoxLimitation = (sender as CheckBox).Parent == pnlMgie ? limitationMagies : 1;

            if ((sender as CheckBox).Checked)
            {
                txtSpec.Text += (sender as CheckBox).Text + ", ";
            }
            else
            {
                txtSpec.Text = txtSpec.Text.Replace((sender as CheckBox).Text + ", ", string.Empty);
            }

            CheckedBoxLimitations(nbCheckBoxLimitation, (sender as CheckBox).Parent as Panel);
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
            txtSpec.Text = nudNombre.Value.ToString();
        }

        private void CheckedBoxLimitations(int numberLimitation, Panel panel)
        {
            int nbChckBox = 0;

            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is CheckBox && (ctrl as CheckBox).Checked)
                {
                    nbChckBox++;
                }
            }

            if (nbChckBox == numberLimitation)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is CheckBox && 
                        (control as CheckBox).Checked == false)
                    {
                        CheckBox checkBox = control as CheckBox;
                        checkBox.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is CheckBox &&
                        (control as CheckBox).Checked == false)
                    {
                        CheckBox checkBox = control as CheckBox;
                        checkBox.Enabled = true;
                    }
                }
            }
        }

        private void FormSpecificationAttributs_Load(object sender, EventArgs e)
        {
            dictionaryControlOriginalSize.Add(this, new Rectangle(this.Location, this.Size));
            dictionaryControlOriginalSize.Add(pnlMgie, new Rectangle(pnlMgie.Location, pnlMgie.Size));
            dictionaryControlOriginalSize.Add(pnlPourcentage, new Rectangle(pnlPourcentage.Location, pnlPourcentage.Size));
            dictionaryControlOriginalSize.Add(nudNombre, new Rectangle(nudNombre.Location, nudNombre.Size));
            dictionaryControlOriginalSize.Add(txtSpec, new Rectangle(txtSpec.Location, txtSpec.Size));
            dictionaryControlOriginalSize.Add(btnOk, new Rectangle(btnOk.Location, btnOk.Size));
            dictionaryControlOriginalSize.Add(btnCancel, new Rectangle(btnCancel.Location, btnCancel.Size));

            foreach (Control control in pnlMgie.Controls)
            {
                dictionaryControlOriginalSize.Add(control, new Rectangle(control.Location, control.Size));
            }

            foreach (Control control in pnlPourcentage.Controls)
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
