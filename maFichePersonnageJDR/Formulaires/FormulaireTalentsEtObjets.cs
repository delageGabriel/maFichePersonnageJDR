using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireTalentsEtObjets : Form
    {
        public int leftControl = 1;

        public FormulaireTalentsEtObjets()
        {
            InitializeComponent();
        }

        private void FormulaireTalentsEtObjets_Load(object sender, EventArgs e)
        {
            cbbInventaires.Items.AddRange(new[] {"Armes",
                "Armures", 
                "Munitions", 
                "Objets"});
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
                    "Perforant" });

                gpbInventaires.Controls.Add(txtDynamicNom);
                gpbInventaires.Controls.Add(txtDynamicPoids);
                gpbInventaires.Controls.Add(txtDynamicQte);
                gpbInventaires.Controls.Add(cbbTypeArmes);

                txtDynamicNom.Top = leftControl * 25;
                txtDynamicPoids.Top = leftControl * 25;
                txtDynamicQte.Top = leftControl * 25;
                cbbTypeArmes.Top = leftControl * 25;

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

                leftControl = leftControl + 1;
                btnAjoutSortilegeAptitude.Top = btnAjoutSortilegeAptitude.Top + 25;
                cbbInventaires.Top = cbbInventaires.Top + 25;

            }
            else if (cbbInventaires.Text == "Armures")
            {
                TextBox txtDynamicNom = new TextBox();
                TextBox txtDynamicPoids = new TextBox();
                TextBox txtDynamicQte = new TextBox();
                ComboBox cbbTypeArmure = new ComboBox();

                cbbTypeArmure.Items.AddRange(new[] { "Lourde", 
                    "Légère", 
                    "Intermédiaire" });

                gpbInventaires.Controls.Add(txtDynamicNom);
                gpbInventaires.Controls.Add(txtDynamicPoids);
                gpbInventaires.Controls.Add(txtDynamicQte);
                gpbInventaires.Controls.Add(cbbTypeArmure);

                txtDynamicNom.Top = leftControl * 25;
                txtDynamicPoids.Top = leftControl * 25;
                txtDynamicQte.Top = leftControl * 25;
                cbbTypeArmure.Top = leftControl * 25;

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

                leftControl = leftControl + 1;
                btnAjoutSortilegeAptitude.Top = btnAjoutSortilegeAptitude.Top + 25;
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

                txtDynamicNom.Top = leftControl * 25;
                txtDynamicPoids.Top = leftControl * 25;
                txtDynamicQte.Top = leftControl * 25;
                cbbTypeMunitions.Top = leftControl * 25;

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

                leftControl = leftControl + 1;
                btnAjoutSortilegeAptitude.Top = btnAjoutSortilegeAptitude.Top + 25;
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
                    "Vent"});

                gpbInventaires.Controls.Add(txtDynamicNom);
                gpbInventaires.Controls.Add(txtDynamicPoids);
                gpbInventaires.Controls.Add(txtDynamicQte);
                gpbInventaires.Controls.Add(cbbEffet);

                txtDynamicNom.Top = leftControl * 25;
                txtDynamicPoids.Top = leftControl * 25;
                txtDynamicQte.Top = leftControl * 25;
                cbbEffet.Top = leftControl * 25;

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

                leftControl = leftControl + 1;
                btnAjoutSortilegeAptitude.Top = btnAjoutSortilegeAptitude.Top + 25;
                cbbInventaires.Top = cbbInventaires.Top + 25;
            }
        }


    }
}
