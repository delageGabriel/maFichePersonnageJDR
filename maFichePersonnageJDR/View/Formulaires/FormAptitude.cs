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
    public partial class FormAptitude : Form
    {
        public Dictionary<string, string> AptitudeValues { get; set; }
        public FormAptitude()
        {
            InitializeComponent();
        }

        private void FormAptitude_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> aptitudeValues = AptitudeValues;

            lblNomAptitude.Text = "Nom : " + aptitudeValues["Nom"];
            lblDomaineAptitude.Text = "Domaine : " + aptitudeValues["Domaine"];
            lblTypeAptitude.Text = "Type : " + aptitudeValues["Type"];
            lblPorteeAptitude.Text = "Portée : " + aptitudeValues["Portee"];
            lblDureeAptitude.Text = "Durée : " + aptitudeValues["Duree"];
            lblLimiteUsageAptitude.Text = "Limite(s) d'usage : " + aptitudeValues["Limites"];
            lblJetSauvegardeAptitude.Text = "Jet de sauvegarde : " + aptitudeValues["Sauvegarde"];
            lblEffetsAptitudes.Text = "Effets : " + aptitudeValues["Effets"];
        }
    }
}
