﻿using System;
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
        {}

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
            double dblPoids = 0.8;
            if (nudECuM.Value > 1)
            {
                dblPoids = dblPoids * Convert.ToDouble(nudECuM.Value);
            }
            lblPdsECuM.Text = dblPoids.ToString() + "kg";
        }

        private void nudEpeeCourte_ValueChanged(object sender, EventArgs e)
        {
            double dblPoids = 0.9;
            if (nudEC.Value > 1)
            {
                dblPoids = dblPoids * Convert.ToDouble(nudEC.Value);
            }
            lblPdsEcC.Text = dblPoids.ToString() + "kg";
        }

        private void nudFauchon_ValueChanged(object sender, EventArgs e)
        {
            double dblPoids = 0.9;
            if (nudFauchon.Value > 1)
            { 
                dblPoids = dblPoids * Convert.ToDouble(nudFauchon.Value);
            }
            lblPdsFauchon.Text = dblPoids.ToString() + "kg";
        }

        private void nudBroadsword_ValueChanged(object sender, EventArgs e)
        {
            double dblPoids = 1.1;
            if (nudBroadsword.Value > 1)
            {
                dblPoids = dblPoids * Convert.ToDouble(nudBroadsword.Value);
            }
            lblPdsBroadsword.Text = dblPoids.ToString() + "kg";
        }

        private void nudCutlass_ValueChanged(object sender, EventArgs e)
        {
            double dblPoids = 1.0;
            if (nudSA.Value > 1)
            {
                dblPoids = dblPoids * Convert.ToDouble(nudSA.Value);
            }
            lblPdsSA.Text = dblPoids.ToString() + "kg";
        }

        private void nudRapiere_ValueChanged(object sender, EventArgs e)
        {
            double dblPoids = 1.1;
            if (nudRapiere.Value > 1)
            {
                dblPoids = dblPoids * Convert.ToDouble(nudRapiere.Value);
            }
            lblPdsRapiere.Text = dblPoids.ToString() + "kg";
        }

        private void nudSabre_ValueChanged(object sender, EventArgs e)
        {
            double dblPoids = 1.0;
            if (nudSabre.Value > 1)
            {
                dblPoids = dblPoids * Convert.ToDouble(nudSabre.Value);
            }
            lblPdsSabre.Text = dblPoids.ToString() + "kg";
        }

        private void nudEpeeLongue_ValueChanged(object sender, EventArgs e)
        {
            double dblPoids = 1.8;
            if (nudEL.Value > 1)
            {
                dblPoids = dblPoids * Convert.ToDouble(nudEL.Value);
            }
            lblPdsEL.Text = dblPoids.ToString() + "kg";
        }

        private void nudClaymore_ValueChanged(object sender, EventArgs e)
        {
            double dblPoids = 2.0;
            if (nudClaymore.Value > 1)
            {
                dblPoids = dblPoids * Convert.ToDouble(nudClaymore.Value);
            }
            lblPdsClaymore.Text = dblPoids.ToString() + "kg";
        }

        private void nudFlamberge_ValueChanged(object sender, EventArgs e)
        {
            double dblPoids = 4.0;
            if (nudFlamberge.Value > 1)
            {
                dblPoids = dblPoids * Convert.ToDouble(nudFlamberge.Value);
            }
            lblPdsFlamberge.Text = dblPoids.ToString() + "kg";
        }

        private void nudEspadon_ValueChanged(object sender, EventArgs e)
        {
            double dblPoids = 5.5;
            if (nudEspadon.Value > 1)
            {
                dblPoids = dblPoids * Convert.ToDouble(nudEspadon.Value);
            }
            lblPdsEspadon.Text = dblPoids.ToString() + "kg";
        }

        private void nudJian_ValueChanged(object sender, EventArgs e)
        {
            double dblPoids = 0.6;
            if (nudJian.Value > 1)
            {
                dblPoids = dblPoids * Convert.ToDouble(nudJian.Value);
            }
            lblPoidsJian.Text = dblPoids.ToString() + "kg";
        }

        private void nudDadao_ValueChanged(object sender, EventArgs e)
        {
            double dblPoids = 1.8;
            if (nudDadao.Value > 1)
            {
                dblPoids = dblPoids * Convert.ToDouble(nudDadao.Value);
            }
            lblPoidsDadao.Text = dblPoids.ToString() + "kg";
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
    }
}
