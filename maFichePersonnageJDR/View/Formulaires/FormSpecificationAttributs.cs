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
        public string UserInput { get; private set; }
        public TextBox TextInput { get => txtSpec; set => txtSpec = value; }
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
    }
}
