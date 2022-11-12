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
        private int maxWidth = 1;
        private int indiceArmes = 0;

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
            GetSettings();
            cbbInventaires.Items.AddRange(new[] {"Armes",
                "Armures",
                "Munitions",
                "Objets"}
            );
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
        {
            if (cbbInventaires.Text == "Aucune options")
            {
                MessageBox.Show("Veuillez saisir une option !", "Attention !");
            }
            else if (cbbInventaires.Text == "Armes")
            {
                TextBox txtDynamicNom = new TextBox();
                TextBox txtDynamicPoids = new TextBox();
                TextBox txtDynamicQte = new TextBox();
                ComboBox cbbTypeArmes = new ComboBox();

                cbbTypeArmes.Items.AddRange(new[] { "Tranchante",
                    "Contondante",
                    "Perforant" }
                );

                if (gpbInventaires.Controls == null)
                {
                    gpbInventaires.Controls.Add(txtDynamicNom);
                    gpbInventaires.Controls.Add(txtDynamicPoids);
                    gpbInventaires.Controls.Add(txtDynamicQte);
                    gpbInventaires.Controls.Add(cbbTypeArmes);

                    txtDynamicNom.Top = HtrControlInventaire * 25;
                    txtDynamicPoids.Top = HtrControlInventaire * 25;
                    txtDynamicQte.Top = HtrControlInventaire * 25;
                    cbbTypeArmes.Top = HtrControlInventaire * 25;

                    txtDynamicNom.Left = 10;
                    txtDynamicPoids.Left = 90;
                    txtDynamicQte.Left = 150;
                    cbbTypeArmes.Left = 190;

                    txtDynamicNom.Width = 70;
                    txtDynamicPoids.Width = 50;
                    txtDynamicQte.Width = 30;
                    txtDynamicNom.Text = "Nom";
                    txtDynamicPoids.Text = "Poids";
                    txtDynamicQte.Text = "Qte";

                    HtrControlInventaire = HtrControlInventaire + 1;
                    btnAjoutObjets.Top = btnAjoutObjets.Top + 25;
                    cbbInventaires.Top = cbbInventaires.Top + 25;
                }


            }
            else if (cbbInventaires.Text == "Armures")
            {
                TextBox txtDynamicNom = new TextBox();
                TextBox txtDynamicPoids = new TextBox();
                TextBox txtDynamicQte = new TextBox();
                ComboBox cbbTypeArmure = new ComboBox();

                cbbTypeArmure.Items.AddRange(new[] { "Lourde",
                    "Légère",
                    "Intermédiaire" }
                );

                gpbInventaires.Controls.Add(txtDynamicNom);
                gpbInventaires.Controls.Add(txtDynamicPoids);
                gpbInventaires.Controls.Add(txtDynamicQte);
                gpbInventaires.Controls.Add(cbbTypeArmure);

                txtDynamicNom.Top = HtrControlInventaire * 25;
                txtDynamicPoids.Top = HtrControlInventaire * 25;
                txtDynamicQte.Top = HtrControlInventaire * 25;
                cbbTypeArmure.Top = HtrControlInventaire * 25;

                txtDynamicNom.Left = 10;
                txtDynamicPoids.Left = 90;
                txtDynamicQte.Left = 150;
                cbbTypeArmure.Left = 190;

                txtDynamicNom.Width = 70;
                txtDynamicPoids.Width = 50;
                txtDynamicQte.Width = 30;
                txtDynamicNom.Text = "Nom";
                txtDynamicPoids.Text = "Poids";
                txtDynamicQte.Text = "Qte";

                HtrControlInventaire = HtrControlInventaire + 1;
                btnAjoutObjets.Top = btnAjoutObjets.Top + 25;
                cbbInventaires.Top = cbbInventaires.Top + 25;
            }
            else if (cbbInventaires.Text == "Munitions")
            {
                TextBox txtDynamicNom = new TextBox();
                TextBox txtDynamicPoids = new TextBox();
                TextBox txtDynamicQte = new TextBox();
                ComboBox cbbTypeMunitions = new ComboBox();

                cbbTypeMunitions.Items.AddRange(new[] { "Tranchante",
                    "Contondante",
                    "Perforant",
                    "Spécial" });

                gpbInventaires.Controls.Add(txtDynamicNom);
                gpbInventaires.Controls.Add(txtDynamicPoids);
                gpbInventaires.Controls.Add(txtDynamicQte);
                gpbInventaires.Controls.Add(cbbTypeMunitions);

                txtDynamicNom.Top = HtrControlInventaire * 25;
                txtDynamicPoids.Top = HtrControlInventaire * 25;
                txtDynamicQte.Top = HtrControlInventaire * 25;
                cbbTypeMunitions.Top = HtrControlInventaire * 25;

                txtDynamicNom.Left = 10;
                txtDynamicPoids.Left = 90;
                txtDynamicQte.Left = 150;
                cbbTypeMunitions.Left = 190;

                txtDynamicNom.Width = 70;
                txtDynamicPoids.Width = 50;
                txtDynamicQte.Width = 30;
                txtDynamicNom.Text = "Nom";
                txtDynamicPoids.Text = "Poids";
                txtDynamicQte.Text = "Qte";

                HtrControlInventaire = HtrControlInventaire + 1;
                btnAjoutObjets.Top = btnAjoutObjets.Top + 25;
                cbbInventaires.Top = cbbInventaires.Top + 25;
            }
            else if (cbbInventaires.Text == "Objets")
            {
                TextBox txtDynamicNom = new TextBox();
                TextBox txtDynamicPoids = new TextBox();
                TextBox txtDynamicQte = new TextBox();
                ComboBox cbbEffet = new ComboBox();

                cbbEffet.Items.AddRange(new[] { "Aucun",
                    "Antidote",
                    "Corporel",
                    "Eau",
                    "Feu",
                    "Lumière",
                    "Neutre",
                    "Paralysie",
                    "Poison",
                    "Restauration",
                    "Spirituel",
                    "Ténèbres",
                    "Terre",
                    "Vent"}
                );

                gpbInventaires.Controls.Add(txtDynamicNom);
                gpbInventaires.Controls.Add(txtDynamicPoids);
                gpbInventaires.Controls.Add(txtDynamicQte);
                gpbInventaires.Controls.Add(cbbEffet);

                txtDynamicNom.Top = HtrControlInventaire * 25;
                txtDynamicPoids.Top = HtrControlInventaire * 25;
                txtDynamicQte.Top = HtrControlInventaire * 25;
                cbbEffet.Top = HtrControlInventaire * 25;

                txtDynamicNom.Left = 10;
                txtDynamicPoids.Left = 90;
                txtDynamicQte.Left = 150;
                cbbEffet.Left = 190;

                txtDynamicNom.Width = 70;
                txtDynamicPoids.Width = 50;
                txtDynamicQte.Width = 30;
                txtDynamicNom.Text = "Nom";
                txtDynamicPoids.Text = "Poids";
                txtDynamicQte.Text = "Qte";

                HtrControlInventaire = HtrControlInventaire + 1;
                btnAjoutObjets.Top = btnAjoutObjets.Top + 25;
                cbbInventaires.Top = cbbInventaires.Top + 25;
            }
        }

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
            foreach (Control unControl in gpbInventaires.Controls)
            {

            }
            Properties.Settings.Default.Inventaires = gpbInventaires.Controls.ToString();
            Properties.Settings.Default.Save();
        }

        public void GetSettings()
        {
            gpbInventaires = Properties.Settings.Default.Inventaires;
        }
    }
}
