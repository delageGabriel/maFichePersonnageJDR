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

        /// <summary>
        /// Accesseurs et Mutateurs
        /// </summary>
        public string PrenomPersonnage { get => txtBoxPrenom.Text; set => txtBoxPrenom.Text = value; }
        public string NomPersonnage { get => txtBoxNom.Text; set => txtBoxNom.Text = value; }
        public string RacePersonnage { get => TxtBoxRace.Text; set => TxtBoxRace.Text = value; }
        public int NiveauPersonnage { get => Convert.ToInt32(nudNiveau.Value); set => nudNiveau.Value = value; }
        public string HommePersonnage { get => rdbHomme.Text; set => rdbHomme.Text = value; }
        public string FemmePersonnage { get => rdbFemme.Text; set => rdbFemme.Text = value; }
        public string AutrePersonnage { get => rdbAutre.Text; set => rdbAutre.Text = value; }
        public int ExperiencePersonnage { get => int.Parse(txtPointsXp.Text); set => txtPointsXp.Text = value.ToString(); }
        public string AvatarPersonnage { get => ptbAvatar.ImageLocation; set => ptbAvatar.ImageLocation = value; }
        public string LanguesPersonnage { get => rtbLangues.Text; set => rtbLangues.Text = value; }
        public string HistoirePersonnage { get => rtbHistoire.Text; set => rtbHistoire.Text = value; }

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
            //if (!String.IsNullOrEmpty(Properties.Settings.Default.CheminImage))
            //{
            //    ptbAvatar.Image = GetUneImage(Properties.Settings.Default.CheminImage);
            //}
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
            //Properties.Settings.Default.Prenom = txtBoxPrenom.Text;
            //Properties.Settings.Default.Nom = txtBoxNom.Text;
            //Properties.Settings.Default.Race = TxtBoxRace.Text;
            //Properties.Settings.Default.Niveau = Convert.ToInt32(nudNiveau.Value);
            //if (rdbHomme.Checked == true)
            //{
            //    Properties.Settings.Default.Sexe = "Masculin";
            //}
            //else if (rdbFemme.Checked == true)
            //{
            //    Properties.Settings.Default.Sexe = "Féminin";
            //}
            //else
            //{
            //    Properties.Settings.Default.Sexe = "Autre";
            //}
            //Properties.Settings.Default.Histoire = rtbHistoire.Text;
            //Properties.Settings.Default.Langues = rtbLangues.Text;
            //Properties.Settings.Default.PointsExp = Int32.Parse(txtPointsXp.Text);
            //Properties.Settings.Default.Save();

            Console.WriteLine("########### Classe : FormulaireInfosGenerales; Méthode : btnSaveInfos_Click; ###########");

            try
            {
                string sexe = "";

                /**
                 * Test du PRENOM
                 */
                if (String.IsNullOrEmpty(txtBoxPrenom.Text))
                {
                    MessageBox.Show("Le champ « Prénom » doit être rempli !");
                    return;
                }

                /**
                 * Test du NOM
                 */
                if (String.IsNullOrEmpty(txtBoxNom.Text))
                {
                    MessageBox.Show("Le champ « Nom » doit être rempli !");
                    return;
                }

                /**
                 * Test RACE
                 */
                if (String.IsNullOrEmpty(TxtBoxRace.Text))
                {
                    MessageBox.Show("Le champ « Race » doit être rempli !");
                    return;
                }

                /**
                 * Test SEXE
                 */
                if (rdbHomme.Checked == true)
                {
                    sexe = HommePersonnage;
                }
                else if (rdbFemme.Checked == true)
                {
                    sexe = FemmePersonnage;
                }
                else if (rdbAutre.Checked == true)
                {
                    sexe = AutrePersonnage;
                }
                else
                {
                    MessageBox.Show("Veuillez cocher un sexe pour le personnage !");
                    return;
                }

                /**
                 * Test LANGUES
                 */
                if (String.IsNullOrEmpty(rtbLangues.Text))
                {
                    MessageBox.Show("Le champ « Langues » doit être rempli !");
                    return;
                }

                // Si tout est bon, on sauvegarde les informations et on créait le personnage
                Controller.PersonnageController.SaveInformationsPersonnage(PrenomPersonnage, NomPersonnage, RacePersonnage, NiveauPersonnage,
                    sexe, ExperiencePersonnage, LanguesPersonnage, AvatarPersonnage, HistoirePersonnage);
            }
            catch (Exception exception)
            {
                throw exception;
            }

            Console.WriteLine("########### FIN Méthode btnSaveInfos_Click ###########");

            MessageBox.Show("Formulaire sauvegardé !");
        }

        private void btnAjouterImage_Click(object sender, EventArgs e)
        {
            string pathImg = GetPathImage();
            ptbAvatar.Image = GetUneImage(pathImg);
        }

        public static Bitmap GetUneImage(string cheminDeLImage)
        {
            string cheminImageARecuperer = !String.IsNullOrEmpty(cheminDeLImage) ? cheminDeLImage : Path.GetFullPath(@"Images\roto.png");
            Bitmap uneImage = new Bitmap(cheminImageARecuperer);
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
