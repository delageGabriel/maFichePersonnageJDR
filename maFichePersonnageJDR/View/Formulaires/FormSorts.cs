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
    public partial class FormSorts : Form
    {
        public Dictionary<string, string> SortValues { get; set; }
        public FormSorts()
        {
            InitializeComponent();
        }

        private void FormSorts_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> sortValues = SortValues;

            lblNomSort.Text = "Nom : " + sortValues["Nom"];
            lblDomaineSort.Text = "Domaine : " + sortValues["Domaine"];
            lblTypeSort.Text = "Type : " + sortValues["Type"];
            lblPorteeSort.Text = "Portée : " + sortValues["Portee"];
            lblDureeSort.Text = "Durée : " + sortValues["Duree"];
            lblLimiteUsageSort.Text = "Limite(s) d'usage : " + sortValues["Limites"];
            lblJetSauvegardeSort.Text = "Jet de sauvegarde : " + sortValues["Sauvegarde"];
            lblTempsIncantationSort.Text = "Temps d'incantation : " + sortValues["Incantations"];
            lblComposantesSort.Text = "Composantes : " + sortValues["Composantes"];
            lblIngredientsSort.Text = "Ingrédients : " + sortValues["Ingredients"];
            lblIntentionsMagiquesSort.Text = "Intentions magiques : " + sortValues["Intentions"];
            lblEffetsSort.Text = "Effets : " + sortValues["Effets"];
        }
    }
}
