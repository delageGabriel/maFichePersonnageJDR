using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using maFichePersonnageJDR.Classe;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireInfosGenerales : Form
    {
        int[] tableauBaseNormaleExp = { 0,
            4060,
            5595,
            7711,
            10630,
            14650,
            20185,
            27820,
            38340,
            52840,
            72820,
            100360,
            138310,
            190613,
            262700,
            362042,
            498955,
            687645,
            947692,
            1306080,
            1800000};
        public FormulaireInfosGenerales()
        {
            InitializeComponent();
            
        }

        private void FormulaireInfosGenerales_Load(object sender, EventArgs e)
        {
            double divisionParTroisChargeMax = Properties.Settings.Default.ChargeMax / 3;
            double deuxTierChargeMax = divisionParTroisChargeMax * 2;

            if (Properties.Settings.Default.ChargePortee >= deuxTierChargeMax)
            {
                Properties.Settings.Default.VitesseDepla = 6;
                txtVitesseDeplacement.Text = Properties.Settings.Default.VitesseDepla.ToString() + " m";
            }
            else
            {
                Properties.Settings.Default.VitesseDepla = 9;
                txtVitesseDeplacement.Text = Properties.Settings.Default.VitesseDepla.ToString() + " m";
            }

            if (Properties.Settings.Default.Sexe == "Masculin")
            {
                rdbHomme.Checked = true;
            }
            else if (Properties.Settings.Default.Sexe == "Féminin")
            {
                rdbFemme.Checked = true;
            }
            else
            {
                rdbAutre.Checked = true;
            }

            GetSettings();
        }

        /// <summary>
        /// Méthode pour obtenir les informations entrées par l'utilisateur
        /// </summary>
        public void GetSettings()
        {
            txtBoxPrenom.Text = Properties.Settings.Default.Prenom;
            txtBoxNom.Text = Properties.Settings.Default.Nom;
            TxtBoxRace.Text = Properties.Settings.Default.Race;
            nudNiveau.Value = Properties.Settings.Default.Niveau;
            rtbHistoire.Text = Properties.Settings.Default.Histoire;
            rtbLangues.Text = Properties.Settings.Default.Langues;
            if (!String.IsNullOrEmpty(Properties.Settings.Default.CheminImage))
            {
                ptbAvatar.Image = GetUneImage(Properties.Settings.Default.CheminImage);
            }
            nudOr.Value = Properties.Settings.Default.Or;
            nudArgent.Value = Properties.Settings.Default.Argent;
            nudCuivre.Value = Properties.Settings.Default.Cuivre;
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
            Properties.Settings.Default.Niveau = Convert.ToInt32(nudNiveau.Value);
            if (rdbHomme.Checked == true)
            {
                Properties.Settings.Default.Sexe = "Masculin";
            }
            else if (rdbFemme.Checked == true)
            {
                Properties.Settings.Default.Sexe = "Féminin";
            }
            else
            {
                Properties.Settings.Default.Sexe = "Autre";
            }
            Properties.Settings.Default.Histoire = rtbHistoire.Text;
            Properties.Settings.Default.Langues = rtbLangues.Text;
            Properties.Settings.Default.Or = Convert.ToInt32(nudOr.Value);
            Properties.Settings.Default.Argent = Convert.ToInt32(nudArgent.Value);
            Properties.Settings.Default.Cuivre = Convert.ToInt32(nudCuivre.Value);
            Properties.Settings.Default.Save();
        }

        private void btnAjouterImage_Click(object sender, EventArgs e)
        {
            string pathImg = GetPathImage();
            ptbAvatar.Image = GetUneImage(pathImg);
        }

        public static Bitmap GetUneImage(string cheminDeLImage)
        {
            Bitmap uneImage = new Bitmap(cheminDeLImage);
            Bitmap imageRedimensionner = new Bitmap(uneImage, new Size(256, 256));
            uneImage = imageRedimensionner;

            return uneImage;
        }

        public string GetPathImage()
        {
            string cheminImage = string.Empty;

            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Choisissez votre image";
            opf.Filter = "Tous les formats(*.jpg, *.png, *.bmp)|*.jpg; *.png; *.bmp|JPEG|*.jpg|PNG|*.png|BMP|*.bmp";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                if (!String.IsNullOrEmpty(opf.FileName))
                {
                    cheminImage = opf.FileName;
                    Properties.Settings.Default.CheminImage = cheminImage;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Chemin d'accès non valide !");
                }
            }

            return cheminImage;
        }

        private void btnViderHistoire_Click(object sender, EventArgs e)
        {
            rtbHistoire.Text = rtbHistoire.Text.Remove(0, rtbHistoire.TextLength);
        }

        private void btnViderLangues_Click(object sender, EventArgs e)
        {
            rtbLangues.Text = rtbLangues.Text.Remove(0, rtbLangues.TextLength);
        }

        private void nudNiveau_ValueChanged(object sender, EventArgs e)
        {
            lblPointsRestants.Text = "/" + tableauBaseNormaleExp[Convert.ToInt32(nudNiveau.Value)];

        }
    }
}
