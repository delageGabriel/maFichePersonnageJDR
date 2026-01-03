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
    public partial class FormArmes : Form
    {
        public Dictionary<string, string> ArmeValues { get; set; }

        public FormArmes()
        {
            InitializeComponent();
        }

        private void FormArmes_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> armeValues = ArmeValues;

            lblNomArme.Text = "Nom : " + armeValues["Nom"];
            lblTypeArme.Text = "Type : " + armeValues["Type"];
            lblPrerequisArme.Text = "Pré-requis : " + armeValues["Prerequis"];
            lblMainsArmes.Text = "Main(s) : " + armeValues["Mains"];
            lblPorteeArme.Text = "Portée : " + armeValues["Portee"];
            lblPoidsArme.Text = "Poids : " + armeValues["Poids"];
            lblDegatsArme.Text = "Dégâts : " + armeValues["Degats"];
            lblJetDegatsArme.Text = "Jet de dégâts : " + armeValues["Jet"];
            lblValeurArme.Text = "Valeur : " + armeValues["Valeur"];
            lblEffetsArme.Text = "Effet : " + armeValues["Effet"];
        }
    }
}
