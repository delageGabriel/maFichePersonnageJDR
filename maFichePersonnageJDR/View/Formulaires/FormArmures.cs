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
    public partial class FormArmures : Form
    {
        public Dictionary<string, string> ArmureValues { get; set; }
        public FormArmures()
        {
            InitializeComponent();
        }

        private void FormArmures_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> armureValues = ArmureValues;

            lblNomArmure.Text = "Nom : " + armureValues["Nom"];
            lblTailleArmure.Text = "Taille : " + armureValues["Taille"];
            lblTypeArmure.Text = "Type : " + armureValues["Type"];
            lblPrerequisArmure.Text = "Pré-requis : " + armureValues["Prerequis"];
            lblValeurDefensiveArmure.Text = "Valeur défensive : " + armureValues["Defense"];
            lblTranchantValue.Text = armureValues["Tranchant"];
            lblContondantValue.Text = armureValues["Contondant"];
            lblPerforantValue.Text = armureValues["Perforant"];
            lblIgneValue.Text = armureValues["Ignee"];
            lblAquatiqueValue.Text = armureValues["Aquatique"];
            lblCelesteValue.Text = armureValues["Celeste"];
            lblTerrestreValue.Text = armureValues["Terrestre"];
            lblChocValue.Text = armureValues["Choc"];
            lblAcideValue.Text = armureValues["Acide"];
            lblPressionValue.Text = armureValues["Pression"];
            lblPoidsArmure.Text = "Poids : " + armureValues["Poids"];
            lblValeurArmure.Text = "Valeur : " + armureValues["Valeur"];
            lblDexteriteValue.Text = armureValues["Dexterite"];
            lblInitiativeValue.Text = armureValues["Initiative"];
            lblVitesseValue.Text = armureValues["Vitesse"];
            lblFroidValue.Text = armureValues["Froid"];
            lblChaleurValue.Text = armureValues["Chaleur"];
            lblEffetsArmure.Text = "Effets : " + armureValues["Effets"];
            lblCompositionArmure.Text = "Composition : " + armureValues["Composition"];
        }
    }
}
