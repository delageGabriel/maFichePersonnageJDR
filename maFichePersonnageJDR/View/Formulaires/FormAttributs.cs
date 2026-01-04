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
    public partial class FormAttributs : Form
    {
        public Dictionary<string, string> AttributesValues { get; set; }

        public FormAttributs()
        {
            InitializeComponent();
        }

        private void FormAttributs_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> attributeValues = AttributesValues;

            lblNomAttribut.Text = "Nom : " + attributeValues["Nom"];
            lblTypeAttribut.Text = "Type : " + attributeValues["Type"];
            lblEffetsAttribut.Text = "Effets : " + attributeValues["Effet"];
        }
    }
}
