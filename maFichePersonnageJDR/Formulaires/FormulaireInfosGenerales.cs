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
            txtVitesse.Text = "9 m";
            if (Convert.ToInt32(Properties.Settings.Default.Force) > 0)
            {
                int calculCharge = Convert.ToInt32((25 + (Convert.ToInt32(Properties.Settings.Default.Force) * 25)) / 2.205);
                txtBoxCharge.Text = calculCharge.ToString() + "kg";
            }
            else
            {
                int calculCharge = 30;
                txtBoxCharge.Text = calculCharge.ToString() + "kg";
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
            if (!String.IsNullOrEmpty(Properties.Settings.Default.CheminImage))
            {
                ptbAvatar.Image = GetUneImage(Properties.Settings.Default.CheminImage);
            }
            txtPO.Text = Properties.Settings.Default.Or;
            txtPA.Text = Properties.Settings.Default.Argent;
            txtPC.Text = Properties.Settings.Default.Cuivre;
            Properties.Settings.Default.ChargeMax = txtBoxCharge.Text;
            Properties.Settings.Default.VitesseDepla = txtVitesse.Text;
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
            Properties.Settings.Default.ChargeMax = txtBoxCharge.Text;
            Properties.Settings.Default.VitesseDepla = txtVitesse.Text;
            Properties.Settings.Default.Or = txtPO.Text;
            Properties.Settings.Default.Argent = txtPA.Text;
            Properties.Settings.Default.Cuivre = txtPC.Text;
            txtBoxCharge.Text = Properties.Settings.Default.ChargeMax;
            txtVitesse.Text = Properties.Settings.Default.VitesseDepla;
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
    }
}
