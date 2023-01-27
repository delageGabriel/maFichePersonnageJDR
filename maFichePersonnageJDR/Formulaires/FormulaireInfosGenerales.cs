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
        int[] tableauBaseNormaleExp =
        {
            0,
            3000,
            9650,
            18490,
            30255,
            45900,
            66710,
            94385,
            131190,
            180145,
            245250,
            331845,
            447015,
            600190,
            803915,
            1074865,
            1435235,
            1914520,
            2551975,
            3399785,
            0
        };
        public FormulaireInfosGenerales()
        {
            InitializeComponent();

        }

        private void FormulaireInfosGenerales_Load(object sender, EventArgs e)
        {
            lblPointsRestants.Text = "/" + tableauBaseNormaleExp[Properties.Settings.Default.Niveau].ToString();
            Properties.Settings.Default.VitesseDepla = 9;
            txtVitesseDeplacement.Text = Properties.Settings.Default.VitesseDepla.ToString() + " m";

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
            txtPointsXp.Text = Properties.Settings.Default.PointsExp.ToString();
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
            Properties.Settings.Default.PointsExp = Int32.Parse(txtPointsXp.Text);
            Properties.Settings.Default.Save();
            MessageBox.Show("Formulaire sauvegardé !");
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
            else
            {
                cheminImage = Path.GetFullPath(@"Images\roto.png");
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
