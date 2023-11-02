using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using maFichePersonnageJDR.Classe;
using maFichePersonnageJDR.View.Formulaires;

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
        public int ExperiencePersonnage { get => Convert.ToInt32(nudExpériencePersonnage.Value); set => nudExpériencePersonnage.Value = value; }
        public string AvatarPersonnage { get => ptbAvatar.ImageLocation; set => ptbAvatar.ImageLocation = value; }
        public string LanguesPersonnage { get => rtbLangues.Text; set => rtbLangues.Text = value; }
        public string HistoirePersonnage { get => rtbHistoire.Text; set => rtbHistoire.Text = value; }

        private int[] tableauBaseRapideExp =
        {
            0,
            2000,
            5325,
            9745,
            15625,
            23450,
            33855,
            47690,
            66095,
            90570,
            123125,
            166420,
            224005,
            300595,
            402455,
            537930,
            718115,
            957760,
            1276485,
            1700390,
            0,
        };

        private int[] tableauBaseNormaleExp =
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

        private int[] tableauBaseLenteExp =
        {
            0,
            4000,
            13975,
            27240,
            44885,
            68350,
            99565,
            141075,
            196285,
            269715,
            367380,
            497270,
            670025,
            899785,
            1205370,
            1611800,
            2152350,
            2871285,
            3827460,
            5099180,
            0
        };

        private Dictionary<Control, Rectangle> dictionaryControlOriginalSize = new Dictionary<Control, Rectangle>();
        private Dictionary<Label, Tuple<Rectangle, float>> dictionaryLabelOriginalSize = new Dictionary<Label, Tuple<Rectangle, float>>();

        public FormulaireInfosGenerales()
        {
            InitializeComponent();
        }

        private void FormulaireInfosGenerales_Load(object sender, EventArgs e)
        {
            dictionaryControlOriginalSize.Add(this, new Rectangle(this.Location, this.Size));

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    dictionaryLabelOriginalSize.Add(ctrl as Label, new Tuple<Rectangle, float>(new Rectangle(ctrl.Location, ctrl.Size), (ctrl as Label).Font.Size));
                }
                else
                {
                    dictionaryControlOriginalSize.Add(ctrl, new Rectangle(ctrl.Location, ctrl.Size));
                }
            }
        }

        /// <summary>
        /// Méthode pour sauvegarder les informations de l'utilisateur
        /// en cliquant sur le bouton sauvegarder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveInfos_Click(object sender, EventArgs e)
        {
            Console.WriteLine("########### Classe : FormulaireInfosGenerales; Méthode : btnSaveInfos_Click; ###########");
            #region Initialisation des variables
            FormulaireAttributs formulaireAttributs = new FormulaireAttributs();
            #endregion

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

                /**
                 * Test PERSONNAGE EXISTE DEJA
                 */
                if (!Controller.PersonnageController.CheckPersonnageExist(NomPersonnage, PrenomPersonnage))
                {
                    MessageBox.Show("Le personnage existe déjà en base !");
                    return;
                }

                // Si tout est bon, on sauvegarde les informations et on créait le personnage
                Controller.PersonnageController.SaveInformationsPersonnage(PrenomPersonnage, NomPersonnage, RacePersonnage, NiveauPersonnage,
                    sexe, ExperiencePersonnage, LanguesPersonnage, AvatarPersonnage, HistoirePersonnage);

                // On récupère l'id du personnage créé
                formulaireAttributs.IdDuPersonnage = Controller.PersonnageController.GetIdPersonnageByNameAndSurname(NomPersonnage,
                    PrenomPersonnage);
                MessageBox.Show("Formulaire sauvegardé !");

                formulaireAttributs.Show();
                this.Close();

            }
            catch (Exception exception)
            {
                throw exception;
            }

            Console.WriteLine("########### FIN Méthode btnSaveInfos_Click ###########");

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
            Bitmap imageRedimensionner = new Bitmap(uneImage, new Size(256, 6));
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
            if (cbbProgressionXp.SelectedItem as string == "Rapide")
            {
                lblPointsRestants.Text = "/" + tableauBaseRapideExp[Convert.ToInt32((sender as NumericUpDown).Value)].ToString();
            }
            else if (cbbProgressionXp.SelectedItem as string == "Normale")
            {
                lblPointsRestants.Text = "/" + tableauBaseNormaleExp[Convert.ToInt32((sender as NumericUpDown).Value)].ToString();
            }
            else if (cbbProgressionXp.SelectedItem as string == "Lente")
            {
                lblPointsRestants.Text = "/" + tableauBaseLenteExp[Convert.ToInt32((sender as NumericUpDown).Value)].ToString();
            }
        }

        private void cbbProgressionXp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem as string == "Rapide")
            {
                lblPointsRestants.Text = "/" + tableauBaseRapideExp[Convert.ToInt32(nudNiveau.Value)].ToString();
            }
            else if ((sender as ComboBox).SelectedItem as string == "Normale")
            {
                lblPointsRestants.Text = "/" + tableauBaseNormaleExp[Convert.ToInt32(nudNiveau.Value)].ToString();
            }
            else if ((sender as ComboBox).SelectedItem as string == "Lente")
            {
                lblPointsRestants.Text = "/" + tableauBaseLenteExp[Convert.ToInt32(nudNiveau.Value)].ToString();
            }
        }

        private void FormulaireInfosGenerales_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Width / dictionaryControlOriginalSize[this].Width;
            float yRatio = (float)this.Height / dictionaryControlOriginalSize[this].Height;

            foreach (KeyValuePair<Label, Tuple<Rectangle, float>> entry in dictionaryLabelOriginalSize)
            {
                Utils.AdjustLabelSizeAndPosition(entry.Key, entry.Value.Item1, entry.Value.Item2, xRatio, yRatio);
            }
            foreach (KeyValuePair<Control, Rectangle> entry in dictionaryControlOriginalSize)
            {
                Utils.AdjustControlSizeAndPosition(entry.Key, entry.Value, xRatio, yRatio);
            }

            this.Refresh();
        }
    }
}
