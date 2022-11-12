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
    public partial class FormulaireInfosGenerales : Form
    {
        public FormulaireInfosGenerales()
        {
            InitializeComponent();
        }

        private void FormulaireInfosGenerales_Load(object sender, EventArgs e)
        {
            GetSettings();
            if (Properties.Settings.Default.Sexe == "Homme")
            {
                rdbHomme.Checked = true;
            }
            else if (Properties.Settings.Default.Sexe == "Femme")
            {
                rdbFemme.Checked = true;
            }
            else
            {
                rdbAutre.Checked = true;
            }
        }

        /// <summary>
        /// Méthode pour obtenir les informations entrées par l'utilisateur
        /// </summary>
        public void GetSettings()
        {
            txtBoxPrenom.Text = Properties.Settings.Default.Prenom;
            txtBoxNom.Text = Properties.Settings.Default.Nom;
            TxtBoxRace.Text = Properties.Settings.Default.Race;
            txtBoxNiveau.Text = Properties.Settings.Default.Niveau;
            rtbHistoire.Text = Properties.Settings.Default.Histoire;
            rtbLangues.Text = Properties.Settings.Default.Langues;
            txtBoxCharge.Text = Properties.Settings.Default.ChargeMax;
            txtVitesse.Text = Properties.Settings.Default.VitesseDepla;
            txtPO.Text = Properties.Settings.Default.Or;
            txtPA.Text = Properties.Settings.Default.Argent;
            txtPC.Text = Properties.Settings.Default.Cuivre;
        }

        /// <summary>
        /// Méthode pour sauvegarder les informations de l'utilisateur
        /// en cliquant sur le bouton sauvegarder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveInfos_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Prenom = txtBoxPrenom.Text;
            Properties.Settings.Default.Nom = txtBoxNom.Text;
            Properties.Settings.Default.Race = TxtBoxRace.Text;
            Properties.Settings.Default.Niveau = txtBoxNiveau.Text;
            if (rdbHomme.Checked == true)
            {
                Properties.Settings.Default.Sexe = "Homme";
            }
            else if (rdbFemme.Checked == true)
            {
                Properties.Settings.Default.Sexe = "Femme";
            }
            else
            {
                Properties.Settings.Default.Sexe = "Autre";
            }
            Properties.Settings.Default.Histoire = rtbHistoire.Text;
            Properties.Settings.Default.Langues = rtbLangues.Text;
            Properties.Settings.Default.ChargeMax = txtBoxCharge.Text;
            Properties.Settings.Default.VitesseDepla = txtVitesse.Text;
            Properties.Settings.Default.Or = txtPO.Text;
            Properties.Settings.Default.Argent = txtPA.Text;
            Properties.Settings.Default.Cuivre = txtPC.Text;
            Properties.Settings.Default.Save();
        }
    }
}
