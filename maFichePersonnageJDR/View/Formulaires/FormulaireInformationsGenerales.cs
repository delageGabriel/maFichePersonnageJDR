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
        //public int ExperiencePersonnage { get => Convert.ToInt32(nudExpériencePersonnage.Value); set => nudExpériencePersonnage.Value = value; }
        public string HistoirePersonnage { get => rtbHistoire.Text; set => rtbHistoire.Text = value; }

        private int[] pointsPvEnergie =
        {
            22,
            27,
            33,
            40,
            48,
            57,
            67,
            78,
            90,
            103,
            117,
            131,
            145,
            158,
            170,
            181,
            191,
            200,
            208,
            215
        };

        private Dictionary<Control, Rectangle> dictionaryControlOriginalSize = new Dictionary<Control, Rectangle>();
        private Dictionary<Label, Tuple<Rectangle, float>> dictionaryLabelOriginalSize = new Dictionary<Label, Tuple<Rectangle, float>>();

        public FormulaireInfosGenerales()
        {
            InitializeComponent();
        }

        #region EVENEMENTS
        /***********************************************
         * 
         * EVENEMENTS
         * 
         **********************************************/
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

            // Cas où l'on edit un personnage existant
            if (GlobaleVariables.IsEdit)
            {
                EditPersonnage();
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
            FormEditMenu formEditMenu = new FormEditMenu();
            FormulaireAttributs formulaireAttributs = new FormulaireAttributs();
            #endregion

            try
            {
                if (GlobaleVariables.IsEdit)
                {
                    //string niveauSuivant = Utils.DeleteCharacterFromString(lblPointsRestants.Text, "/");

                    // Mise à jour du niveau du personnage
                    if (nudNiveau.Value != Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage))
                    {
                        Controller.PersonnageController.SetValueField("niveau_personnage", GlobaleVariables.IdPersonnage, nudNiveau.Value);
                    }

                    // Mise à jour du nombre de points à atteindre pour le niveau suivant du personnage
                    //if (int.Parse(niveauSuivant) != Controller.PersonnageController.GetNiveauSuivantPersonnage(GlobaleVariables.IdPersonnage))
                    //{
                    //    Controller.PersonnageController.SetValueField("niveau_suivant_personnage", GlobaleVariables.IdPersonnage, niveauSuivant);
                    //}

                    // Mise à jour du nombre de points d'expérience acquis par le personnage
                    //if (nudExpériencePersonnage.Value != Controller.PersonnageController.GetExperiencePersonnage(GlobaleVariables.IdPersonnage))
                    //{
                    //    Controller.PersonnageController.SetValueField("experience_personnage", GlobaleVariables.IdPersonnage, nudExpériencePersonnage.Value);
                    //}

                    // Mise à jour l'histoire du personnage
                    if (rtbHistoire.Text != Controller.PersonnageController.GetHistoirePersonnage(GlobaleVariables.IdPersonnage))
                    {
                        Controller.PersonnageController.SetValueField("histoire_personnage", GlobaleVariables.IdPersonnage, rtbHistoire.Text);
                    }

                    // Mise à jour des langues parlées par le personnage
                    //if (rtbLangues.Text != Controller.PersonnageController.GetLanguesPersonnage(GlobaleVariables.IdPersonnage))
                    //{
                    //    Controller.PersonnageController.SetValueField("langues_personnage", GlobaleVariables.IdPersonnage, rtbLangues.Text);
                    //}

                    formEditMenu.Show();
                }
                else
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
                     * Test PERSONNAGE EXISTE DEJA
                     */
                    if (!Controller.PersonnageController.CheckPersonnageExist(NomPersonnage, PrenomPersonnage))
                    {
                        MessageBox.Show("Le personnage existe déjà en base !");
                        return;
                    }

                    // Si tout est bon, on sauvegarde les informations et on créait le personnage
                    //Controller.PersonnageController.SaveInformationsPersonnage(PrenomPersonnage, NomPersonnage, RacePersonnage, NiveauPersonnage,
                    //    sexe, HistoirePersonnage);

                    GlobaleVariables.IdPersonnage = Controller.PersonnageController.GetIdPersonnageByNameAndSurname(NomPersonnage,
                        PrenomPersonnage);

                    formulaireAttributs.Show();
                }

                MessageBox.Show("Formulaire sauvegardé !");
                GlobaleVariables.IsClosedProgrammatically = true;
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
        }

        /// <summary>
        /// Vide la RichTextBoxHistoire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViderHistoire_Click(object sender, EventArgs e)
        {
            rtbHistoire.Text = rtbHistoire.Text.Remove(0, rtbHistoire.TextLength);
        }

        private void nudNiveau_ValueChanged(object sender, EventArgs e)
        {
            /// Simple sécurité pour éviter d'avoir un surplus de points de vie
            /// ou énergie.
            if (numUpDwnPtsVie.Value > 0 || numUpDwnPtsEnergie.Value > 0)
            {
                numUpDwnPtsVie.Value = 0;
                numUpDwnPtsEnergie.Value = 0;
            }

            GetPointsVieEnergieByLevelAndSize();
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
        private void cbBxTaille_SelectedIndexChanged(object sender, EventArgs e)
        {
            /// Simple sécurité pour éviter d'avoir un surplus de points de vie
            /// ou énergie.
            if (numUpDwnPtsVie.Value > 0 || numUpDwnPtsEnergie.Value > 0)
            {
                numUpDwnPtsVie.Value = 0;
                numUpDwnPtsEnergie.Value = 0;
            }

            GetPointsVieEnergieByLevelAndSize();
        }

        private void numUpDwnPtsVie_ValueChanged(object sender, EventArgs e)
        {
            CalculPVEnergie();
        }

        private void numUpDwnPtsEnergie_ValueChanged(object sender, EventArgs e)
        {
            CalculPVEnergie();
        }

        private void FormulaireInfosGenerales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!GlobaleVariables.IsClosedProgrammatically)
            {
                string msg = GlobaleVariables.IsEdit ? "Voulez-vous annuler l'édition du personnage ?" : "Voulez-vous annuler la création du personnage ?";
                DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Vérifier la réponse de l'utilisateur
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (GlobaleVariables.IsEdit)
                    {
                        FormEditMenu formEditMenu = new FormEditMenu();
                        formEditMenu.Show();
                    }
                    else
                    {
                        FrmPrincipal frmPrincipal = new FrmPrincipal();
                        frmPrincipal.Show();
                    }
                }
            }
            else
            {
                GlobaleVariables.IsClosedProgrammatically = false;
            }
        }
        #endregion

        #region METHODES
        /********************************************
         * 
         * METHODES
         * 
         *******************************************/
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

        /// <summary>
        /// Méthode qui assigne les valeurs pour un personnage déjà existant
        /// </summary>
        private void EditPersonnage()
        {
            string sexe = Controller.PersonnageController.GetSexePersonnage(GlobaleVariables.IdPersonnage);

            // On bloque les controls qui changerait des informations trop importante
            txtBoxPrenom.Enabled = false;
            txtBoxNom.Enabled = false;
            TxtBoxRace.Enabled = false;
            //rdbHomme.Enabled = false;
            //rdbFemme.Enabled = false;
            //rdbAutre.Enabled = false;
            //cbbProgressionXp.Enabled = false;

            // On remet les valeurs à jour dans les controls du formulaire
            txtBoxPrenom.Text = Controller.PersonnageController.GetPrenomPersonnage(GlobaleVariables.IdPersonnage);
            txtBoxNom.Text = Controller.PersonnageController.GetNomPersonnage(GlobaleVariables.IdPersonnage);
            TxtBoxRace.Text = Controller.PersonnageController.GetRacePersonnage(GlobaleVariables.IdPersonnage);
            nudNiveau.Value = Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage);
            //cbbProgressionXp.SelectedItem = Controller.PersonnageController.GetCourbeProgressionPersonnage(GlobaleVariables.IdPersonnage);
            rtbHistoire.Text = Controller.PersonnageController.GetHistoirePersonnage(GlobaleVariables.IdPersonnage);
            //rtbLangues.Text = Controller.PersonnageController.GetLanguesPersonnage(GlobaleVariables.IdPersonnage);
        }

        /// <summary>
        /// Gère le nombre de points total à répartir, entre les points de vie et énergie
        /// en fonction du niveau et de la taille de la créature.
        /// </summary>
        private int GetPointsVieEnergieByLevelAndSize()
        {
            int niveau = (int)nudNiveau.Value;
            double multiplicateur = 0.0;

            /// Si aucune taille n'est sélectionnée on quitte la méthode
            /// avec un message d'alerte pour éviter un bug.
            if (cbBxTaille.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une taille");
                return 0;
            }

            /// Changer le multiplicateur en fonction de la taille choisie
            /// pour la créature.
            switch (cbBxTaille.SelectedItem.ToString())
            {
                case "Minuscule":
                    multiplicateur = 0.6;
                    break;
                case "Petit":
                    multiplicateur = 1;
                    break;
                case "Moyen":
                    multiplicateur = 1;
                    break;
                case "Grand":
                    multiplicateur = 1.5;
                    break;
                case "Très grand":
                    multiplicateur = 2;
                    break;
                case "Gigantesque":
                    multiplicateur = 3;
                    break;
                default:
                    multiplicateur = 1;
                    break;
            }

            int resultat = (int)(pointsPvEnergie[niveau - 1] * multiplicateur);

            lblRepartitionPvEnergie.Text = resultat.ToString();

            return resultat;
        }
        /// <summary>
        /// Fais le calcul de la répartition des points de vie et énergie et fixe
        /// un maximum aux PV et énergie, une fois les points de répartition à 0
        /// </summary>
        private void CalculPVEnergie()
        {
            /// Récupération du nombre de points à répartir en fonction du niveau et de la taille,
            /// puis le nombre de points restants à répartir
            int valeurPointsPvEnergie = GetPointsVieEnergieByLevelAndSize();
            valeurPointsPvEnergie = valeurPointsPvEnergie - ((int)numUpDwnPtsVie.Value + (int)numUpDwnPtsEnergie.Value);

            /// On fixe le maximum ici en fonction du nombre de points restants
            if (valeurPointsPvEnergie == 0)
            {
                numUpDwnPtsVie.Maximum = numUpDwnPtsVie.Value;
                numUpDwnPtsEnergie.Maximum = numUpDwnPtsEnergie.Value;
            }
            else
            {
                numUpDwnPtsVie.Maximum = 999;
                numUpDwnPtsEnergie.Maximum = 999;
            }

            lblRepartitionPvEnergie.Text = valeurPointsPvEnergie.ToString(); // On ré-affiche les points restants à répartir.
        }
        #endregion
    }
}
