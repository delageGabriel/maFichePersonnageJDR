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
    public partial class FormObjets : Form
    {
        public Dictionary<string, string> ObjetValues { get; set; }
        public FormObjets()
        {
            InitializeComponent();
        }

        private void FormObjets_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> objetValues = ObjetValues;

            lblNomObjet.Text = "Nom : " + objetValues["Nom"];
            lblTypeObjet.Text = "Type : " + objetValues["Type"];
            lblConsommableObjet.Text = "Type : " + objetValues["Consommable"];
            lblEffetsObjet.Text = "Type : " + objetValues["Effet"];
            lblPoidsObjet.Text = "Type : " + objetValues["Poids"];
            lblValeurObjet.Text = "Type : " + objetValues["Valeur"];
        }
    }
}
