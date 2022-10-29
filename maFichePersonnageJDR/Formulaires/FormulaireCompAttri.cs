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
    public partial class FormulaireCompAttri : Form
    {

        public FormulaireCompAttri()
        {
            InitializeComponent();
        }

        public void GetSettings()
        {
            txtBoxPV.Text = Properties.Settings.Default.PV;
            txtBoxEnrgie.Text = Properties.Settings.Default.Energie;
            txtPhysique.Text = Properties.Settings.Default.Physique;
            txtMental.Text = Properties.Settings.Default.Mental;
            txtSocial.Text = Properties.Settings.Default.Social;
            nudAdresse.Value = Properties.Settings.Default.Adresse;
            nudAgilite.Value = Properties.Settings.Default.Agilité;
            nudAnmale.Value = Properties.Settings.Default.Animale;
            nudArtisanat.Value = Properties.Settings.Default.Artisanat;
            nudBotanique.Value = Properties.Settings.Default.Botanique;
            nudConnGeographiques.Value = Properties.Settings.Default.ConnGeographiques;
            nudConnHistoriques.Value = Properties.Settings.Default.ConnHistoriques;
            nudMagiques.Value = Properties.Settings.Default.ConnMagiques;
            nudConnReligieuses.Value = Properties.Settings.Default.ConnReligieuses;
            nudCrochetage.Value = Properties.Settings.Default.Crochetage;
            nudDiplomatie.Value = Properties.Settings.Default.Diplomatie;
            nudEscalade.Value = Properties.Settings.Default.Escalade;
            nudExplosifs.Value = Properties.Settings.Default.Explosifs;
            nudForce.Value = Properties.Settings.Default.Force;
            nudIntimidation.Value = Properties.Settings.Default.Intimidation;
            nudLangages.Value = Properties.Settings.Default.Langages;
            nudMecanique.Value = Properties.Settings.Default.Mecanique;
            nudMedecine.Value = Properties.Settings.Default.Medecine;
            nudNatation.Value = Properties.Settings.Default.Natation;
            nudPerception.Value = Properties.Settings.Default.Perception;
            nudPerspicacite.Value = Properties.Settings.Default.Perspicacité;
            nudPersuasion.Value = Properties.Settings.Default.Persuasion;
            nudPsyche.Value = Properties.Settings.Default.Psyche;
            nudReflexes.Value = Properties.Settings.Default.Reflexes;
            nudVigueur.Value = Properties.Settings.Default.Vigueur;
            nudVolonte.Value = Properties.Settings.Default.Volonte;
        }
        private void FormulaireCompAttri_Load(object sender, EventArgs e)
        {
            GetSettings();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PV = txtBoxPV.Text;
            Properties.Settings.Default.Energie = txtBoxEnrgie.Text;
            Properties.Settings.Default.Physique = txtPhysique.Text;
            Properties.Settings.Default.Mental = txtMental.Text;
            Properties.Settings.Default.Social = txtSocial.Text;
            Properties.Settings.Default.Adresse = Convert.ToInt32(nudAdresse.Value);
            Properties.Settings.Default.Agilité = Convert.ToInt32(nudAgilite.Value);
            Properties.Settings.Default.Animale = Convert.ToInt32(nudAnmale.Value);
            Properties.Settings.Default.Artisanat = Convert.ToInt32(nudArtisanat.Value);
            Properties.Settings.Default.Botanique = Convert.ToInt32(nudBotanique.Value);
            Properties.Settings.Default.ConnGeographiques = Convert.ToInt32(nudConnGeographiques.Value);
            Properties.Settings.Default.ConnHistoriques = Convert.ToInt32(nudConnHistoriques.Value);
            Properties.Settings.Default.ConnMagiques = Convert.ToInt32(nudMagiques.Value);
            Properties.Settings.Default.ConnReligieuses = Convert.ToInt32(nudConnReligieuses.Value);
            Properties.Settings.Default.Crochetage = Convert.ToInt32(nudCrochetage.Value);
            Properties.Settings.Default.Diplomatie = Convert.ToInt32(nudDiplomatie.Value);
            Properties.Settings.Default.Escalade = Convert.ToInt32(nudEscalade.Value);
            Properties.Settings.Default.Explosifs = Convert.ToInt32(nudExplosifs.Value);
            Properties.Settings.Default.Force = Convert.ToInt32(nudForce.Value);
            Properties.Settings.Default.Intimidation = Convert.ToInt32(nudIntimidation.Value);
            Properties.Settings.Default.Langages = Convert.ToInt32(nudLangages.Value);
            Properties.Settings.Default.Mecanique = Convert.ToInt32(nudMecanique.Value);
            Properties.Settings.Default.Medecine = Convert.ToInt32(nudMedecine.Value);
            Properties.Settings.Default.Natation = Convert.ToInt32(nudNatation.Value);
            Properties.Settings.Default.Perception = Convert.ToInt32(nudPerception.Value);
            Properties.Settings.Default.Perspicacité = Convert.ToInt32(nudPerspicacite.Value);
            Properties.Settings.Default.Persuasion = Convert.ToInt32(nudPersuasion.Value);
            Properties.Settings.Default.Psyche = Convert.ToInt32(nudPsyche.Value);
            Properties.Settings.Default.Reflexes = Convert.ToInt32(nudReflexes.Value);
            Properties.Settings.Default.Vigueur = Convert.ToInt32(nudVigueur.Value);
            Properties.Settings.Default.Volonte = Convert.ToInt32(nudVolonte.Value);
            Properties.Settings.Default.Save();
        }

        private void txtPhysique_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMental_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSocial_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
