using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maFichePersonnageJDR.Formulaires;
using maFichePersonnageJDR.Classes;
using System.Configuration;

namespace maFichePersonnageJDR.Formulaires
{
    [TypeConverter(typeof(FormConverter))]
    [SettingsSerializeAs(SettingsSerializeAs.String)]
    public partial class FormulaireTalentsEtObjets : Form
    {
        private int htrControlInventaire = 1;
        private int htrControlTalent = 1;

        private List<Armes> lArmes = new List<Armes>();
        public int HtrControlInventaire { get => htrControlInventaire; set => htrControlInventaire = value; }
        public int HtrControlTalent { get => htrControlTalent; set => htrControlTalent = value; }
        internal List<Armes> LArmes { get => lArmes; set => lArmes = value; }

        public FormulaireTalentsEtObjets()
        {
            InitializeComponent();
        }

        private void FormulaireTalentsEtObjets_Load(object sender, EventArgs e)
        {
            GetArmes();
            if (Properties.Settings.Default.Attributs.Contains("Magie Aquatique — magie de l'eau"))
            {
                cbbSortileges.Items.AddRange(new[] { "Manipulation des éléments aquatiques" });
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Ignis — magie du feu"))
            {
                cbbSortileges.Items.AddRange(new[] { "Manipulation des flammes" });
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Céleste: magie du ciel"))
            {
                cbbSortileges.Items.AddRange(new[] { "Manipulation des éléments célestes" });
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Terrestre: magie de la terre"))
            {
                cbbSortileges.Items.AddRange(new[] { "Manipulation des éléments terrestres" });
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Naturelle — magie de la nature"))
            {
                cbbSortileges.Items.AddRange(new[] { "Communication avec les forces naturelles (plantes, animaux, ...)",
                "Invocation d'une chimère (créature connue par le lanceur)",
                "Manipulation du terrain: peut modifier son environnement",
                "Métamorphose: êtres réels et connus par le lanceur"});
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Divine — magie liée aux divinités"))
            {
                cbbSortileges.Items.AddRange(new[] { "Bouclier protecteur: champ protecteur dans un rayon défini",
                "Soins magiques: peut soigner les blessures mais pas repousser les membres",
                "Guérison: maladie, problème état",
                "Bénédiction: soigne des malédictions",
                "Divination: voit un futur proche"});
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Démoniaque — magie liée aux ténèbres"))
            {
                cbbSortileges.Items.AddRange(new[] {"Absorption: PV, Énergie",
                "Nécromancie: ramener des cadavres à la vie, manipulation des os",
                "Malédiction: jette une malédiction à quelqu'un",
                "Contrôle: possession d'une personne, contrôle de volonté"
                });
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Neutre — magie neutre"))
            {
                cbbSortileges.Items.AddRange(new[] {"Modifications corporelles (supersaut, super force, ...) ",
                "Invisibilé",
                "Vision d'aura",
                "Images miroir: (clones, images rémanentes, ...)",
                "Message: connexion mentale, images mentales, ..."
                });
            }
        }

        private void btnAjoutSortilegeAptitude_Click(object sender, EventArgs e)
        { }

        private void btnAjouterSortileges_Click(object sender, EventArgs e)
        {
            Label lblSortilege = new Label();

            gpbSortilegesAptitudes.Controls.Add(lblSortilege);

            lblSortilege.AutoSize = true;
            lblSortilege.Text = (string)cbbSortileges.SelectedItem;
            lblSortilege.Top = HtrControlTalent * 25;
            lblSortilege.Left = 10;

            HtrControlTalent = HtrControlTalent + 1;
            btnAjouterTalents.Top = btnAjouterTalents.Top + 25;
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
        }

        public void GetSettings()
        {
        }

        private void nudNbGlaive_ValueChanged(object sender, EventArgs e)
        {
        }

        private void nudEpeeCourte_ValueChanged(object sender, EventArgs e)
        {
        }

        private void nudFauchon_ValueChanged(object sender, EventArgs e)
        {
        }

        private void nudCaEp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudKodachi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudArbir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudLB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTpeCasques_Click(object sender, EventArgs e)
        {

        }

        public void GetArmes()
        {

        }

        private void chkScrmx_Click(object sender, EventArgs e)
        {
            string strTemp = lblScrmx.Text + " " + lblPdsScrmx.Text + " " + lblPrteScrmx.Text + " " + nudScrmx.Value.ToString() + " " + lblTpeScrmx.Text + " " + lblDgtsScrmx.Text;
            if (chkScrmx.Checked)
            {
                rchTxtIvtaires.Text = strTemp;
            }
            else if (!chkScrmx.Checked)
            {
                if(rchTxtIvtaires.Text.Contains(strTemp) && rchTxtIvtaires.Text.IndexOf(strTemp) == 0)
                {
                    strTemp = "";
                    rchTxtIvtaires.Text = strTemp; 
                }
            }
        }
    }
}
