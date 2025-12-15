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
        /**************************************************
         * 
         * ATTRIBUTS
         * 
         *************************************************/
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

        private int[] pointsCaracteristiques =
        {
            115,
            115,
            115,
            120,
            120,
            120,
            128,
            128,
            128,
            138,
            138,
            138,
            150,
            150,
            150,
            165,
            165,
            165,
            178,
            190
        };

        private int[] pointsCompetencesCorps =
        {
            20,
            27,
            34,
            42,
            49,
            56,
            64,
            71,
            78,
            86,
            93,
            100,
            108,
            115,
            122,
            130,
            137,
            145,
            152,
            160
        };

        private int[] pointsCompetencesEsprit =
        {
            20,
            24,
            28,
            32,
            37,
            41,
            45,
            49,
            53,
            58,
            62,
            66,
            70,
            74,
            79,
            83,
            87,
            91,
            95,
            100
        };

        private int[] pointsCompetencesRelationnel =
        {
            20,
            25,
            30,
            36,
            41,
            46,
            51,
            57,
            62,
            67,
            72,
            78,
            83,
            88,
            93,
            99,
            104,
            109,
            114,
            120
        };
        /// <summary>
        /// Accesseurs et Mutateurs
        /// </summary>
        public string PrenomPersonnage { get => txtBoxPrenom.Text; set => txtBoxPrenom.Text = value; }
        public string NomPersonnage { get => txtBoxNom.Text; set => txtBoxNom.Text = value; }
        public string RacePersonnage { get => TxtBoxRace.Text; set => TxtBoxRace.Text = value; }
        public int NiveauPersonnage { get => Convert.ToInt32(nudNiveau.Value); set => nudNiveau.Value = value; }
        //public int ExperiencePersonnage { get => Convert.ToInt32(nudExpériencePersonnage.Value); set => nudExpériencePersonnage.Value = value; }
        public string HistoirePersonnage { get => rtbHistoire.Text; set => rtbHistoire.Text = value; }

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
            /// Par défaut le personnage est niveau 1, donc on peut déjà faire le calcul.
            CalculRepartitionCaracteristiques();
            CalculRepartitionCompetencesCorps();
            CalculRepartitionCompetencesEsprit();
            CalculRepartitionCompetencesRelationnelles();

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
            numUpDwnPtsVie.Value = 0;
            numUpDwnPtsEnergie.Value = 0;

            /// Même logique avec les caractéristiques.
            numUpDwnPtsCorps.Value = 25;
            numUpDwnPtsEsprit.Value = 25;
            numUpDwnPtsRelationnel.Value = 25;

            /// Même logique...
            foreach(Control ctrl in pnlCompetencesCorps.Controls)
            {
                if (ctrl is NumericUpDown nud)
                {
                    if (nud.Maximum < 0)
                        nud.Maximum = 20;
                    nud.Value = 0;
                }
            }

            /// ...
            foreach(Control ctrl in pnlCompetencesEsprits.Controls)
            {
                if (ctrl is NumericUpDown nud)
                {
                    if (nud.Maximum < 0)
                        nud.Maximum = 20;
                    nud.Value = 0;
                }
            }

            /// ...
            foreach(Control ctrl in pnlCompetencesRelationnelles.Controls)
            {
                if (ctrl is NumericUpDown nud)
                {
                    if (nud.Maximum < 0)
                        nud.Maximum = 20;
                    nud.Value = 0;
                }
            }

            GetPointsVieEnergieByLevelAndSize();
            CalculRepartitionCaracteristiques();
            CalculRepartitionCompetencesCorps();
            CalculRepartitionCompetencesEsprit();
            CalculRepartitionCompetencesRelationnelles();
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
            CalculRepartitionPVEnergie();
        }

        private void numUpDwnPtsEnergie_ValueChanged(object sender, EventArgs e)
        {
            CalculRepartitionPVEnergie();
        }

        private void numUpDwnPtsCorps_ValueChanged(object sender, EventArgs e)
        {
            CalculRepartitionCaracteristiques();
        }

        private void numUpDwnPtsEsprit_ValueChanged(object sender, EventArgs e)
        {
            CalculRepartitionCaracteristiques();
        }

        private void numUpDwnPtsRelationnel_ValueChanged(object sender, EventArgs e)
        {
            CalculRepartitionCaracteristiques();
        }

        private void numUpDwnCompetencesCorps_ValueChanged(object sender, EventArgs e)
        {
            CalculRepartitionCompetencesCorps();
        }
        private void numUpDwnCompetencesEsprit_ValueChanged(object sender, EventArgs e)
        {
            CalculRepartitionCompetencesEsprit();
        }

        private void numUpDwnCompetencesRelationnelles_ValueChanged(object sender, EventArgs e)
        {
            CalculRepartitionCompetencesRelationnelles();
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

            // On remet les valeurs à jour dans les controls du formulaire
            txtBoxPrenom.Text = Controller.PersonnageController.GetPrenomPersonnage(GlobaleVariables.IdPersonnage);
            txtBoxNom.Text = Controller.PersonnageController.GetNomPersonnage(GlobaleVariables.IdPersonnage);
            TxtBoxRace.Text = Controller.PersonnageController.GetRacePersonnage(GlobaleVariables.IdPersonnage);
            nudNiveau.Value = Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage);
            rtbHistoire.Text = Controller.PersonnageController.GetHistoirePersonnage(GlobaleVariables.IdPersonnage);
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
        /// Retourne le nombre de points de caractéristiques à répartir en fonction
        /// du niveau du personnage.
        /// </summary>
        /// <returns>
        /// Nombre de points de caractéristiques à répartir.
        /// </returns>
        private int GetPointsCaracteristiquesByLevel()
        {
            int pointsRepartir = pointsCaracteristiques[(int)nudNiveau.Value - 1]; // -1 pour avoir le bon index du tableau.

            return pointsRepartir;
        }
        /// <summary>
        /// Retourne le nombre de points de compétences de corps à répartir en fonction
        /// du niveau du personnage.
        /// </summary>
        /// <returns>
        /// Nombre de points de compétences de corps à répartir.
        /// </returns>
        private int GetPointsCompetencesCorpsByLevel()
        {
            return pointsCompetencesCorps[(int)nudNiveau.Value - 1];
        }
        /// <summary>
        /// Retourne le nombre de points de compétences d'esprit à répartir en fonction
        /// du niveau du personnage.
        /// </summary>
        /// <returns>
        /// Nombre de points de compétences d'esprit à répartir.
        /// </returns>
        private int GetPointsCompetencesEspritByLevel()
        {
            return pointsCompetencesEsprit[(int)nudNiveau.Value - 1];
        }
        /// <summary>
        /// Retourne le nombre de points de compétences de relationnel à répartir en fonction
        /// du niveau du personnage.
        /// </summary>
        /// <returns>
        /// Nombre de points de compétences de relationnel à répartir.
        /// </returns>
        private int GetPointsCompetencesRelationnelByLevel()
        {
            return pointsCompetencesRelationnel[(int)nudNiveau.Value - 1];
        }

        /// <summary>
        /// Fais le calcul de la répartition des points de vie et énergie et fixe
        /// un maximum aux PV et énergie, une fois les points de répartition à 0,
        /// et mets à jour le nombre de points restants.
        /// </summary>
        private void CalculRepartitionPVEnergie()
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
        /// <summary>
        /// Fais le calcul de la répartition des points de caractéristiques
        /// un maximum aux caractéristiques, une fois les points de répartition à 0,
        /// et mets à jour le nombre de points restants.
        /// </summary>
        private void CalculRepartitionCaracteristiques()
        {
            int valeurPointsCaracteristiques = GetPointsCaracteristiquesByLevel();
            valeurPointsCaracteristiques = valeurPointsCaracteristiques - ((int)numUpDwnPtsCorps.Value + (int)numUpDwnPtsEsprit.Value
                                                                            + (int)numUpDwnPtsRelationnel.Value);
            if (valeurPointsCaracteristiques == 0)
            {
                numUpDwnPtsCorps.Maximum = numUpDwnPtsCorps.Value;
                numUpDwnPtsEsprit.Maximum = numUpDwnPtsEsprit.Value;
                numUpDwnPtsRelationnel.Maximum = numUpDwnPtsRelationnel.Value;
            }
            else
            {
                numUpDwnPtsCorps.Maximum = 70;
                numUpDwnPtsEsprit.Maximum = 70;
                numUpDwnPtsRelationnel.Maximum = 70;
            }

            lblRepartitionCaracteristiques.Text = valeurPointsCaracteristiques.ToString();
        }
        /// <summary>
        /// Fais le calcul de la répartition des points de compétences de corps
        /// mets à jour le maximum une fois les points de répartition à 0,
        /// et mets à jour le nombre de points restants.
        /// </summary>
        private void CalculRepartitionCompetencesCorps()
        {
            int valeurPointsCompetencesCorps = GetPointsCompetencesCorpsByLevel();
            valeurPointsCompetencesCorps = valeurPointsCompetencesCorps - ((int)numUpDwnAgilite.Value + (int)numUpDwnCourse.Value
                                                                            + (int)numUpDwnDiscretion.Value + (int)numUpDwnEquilibre.Value
                                                                            + (int)numUpDwnEscalade.Value + (int)numUpDwnForce.Value
                                                                            + (int)numUpDwnFouilles.Value + (int)numUpDwnLancer.Value
                                                                            + (int)numUpDwnLutte.Value + (int)numUpDwnNatation.Value
                                                                            + (int)numUpDwnReflexes.Value + (int)numUpDwnVigueur.Value);
            if (valeurPointsCompetencesCorps == 0)
            {
                numUpDwnAgilite.Maximum = numUpDwnAgilite.Value;
                numUpDwnCourse.Maximum = numUpDwnCourse.Value;
                numUpDwnDiscretion.Maximum = numUpDwnDiscretion.Value;
                numUpDwnEquilibre.Maximum = numUpDwnEquilibre.Value;
                numUpDwnEscalade.Maximum = numUpDwnEscalade.Value;
                numUpDwnForce.Maximum = numUpDwnForce.Value;
                numUpDwnFouilles.Maximum = numUpDwnFouilles.Value;
                numUpDwnLancer.Maximum = numUpDwnLancer.Value;
                numUpDwnLutte.Maximum = numUpDwnLutte.Value;
                numUpDwnNatation.Maximum = numUpDwnNatation.Value;
                numUpDwnReflexes.Maximum = numUpDwnReflexes.Value;
                numUpDwnVigueur.Maximum = numUpDwnVigueur.Value;
            }
            else
            {
                numUpDwnAgilite.Maximum = 20;
                numUpDwnCourse.Maximum = 20;
                numUpDwnDiscretion.Maximum = 20;
                numUpDwnEquilibre.Maximum = 20;
                numUpDwnEscalade.Maximum = 20;
                numUpDwnForce.Maximum = 20;
                numUpDwnFouilles.Maximum = 20;
                numUpDwnLancer.Maximum = 20;
                numUpDwnLutte.Maximum = 20;
                numUpDwnNatation.Maximum = 20;
                numUpDwnReflexes.Maximum = 20;
                numUpDwnVigueur.Maximum = 20;
            }

            lblRepartitionCompetencesCorps.Text = valeurPointsCompetencesCorps.ToString();
        }
        /// <summary>
        /// Fais le calcul de la répartition des points de compétences d'esprit
        /// mets à jour le maximum une fois les points de répartition à 0,
        /// et mets à jour le nombre de points restants.
        /// </summary>
        private void CalculRepartitionCompetencesEsprit()
        {
            int valeurPointsCompetencesEsprit = GetPointsCompetencesEspritByLevel();
            valeurPointsCompetencesEsprit = valeurPointsCompetencesEsprit - ((int)numUpDwnConcentration.Value + (int)numUpDwnEssence.Value
                                                                            + (int)numUpDwnLogique.Value + (int)numUpDwnMemoire.Value
                                                                            + (int)numUpDwnOrientation.Value + (int)numUpDwnPerception.Value
                                                                            + (int)numUpDwnVolonte.Value);
            if (valeurPointsCompetencesEsprit == 0)
            {
                numUpDwnConcentration.Maximum = numUpDwnConcentration.Value;
                numUpDwnEssence.Maximum = numUpDwnEssence.Value;
                numUpDwnLogique.Maximum = numUpDwnLogique.Value;
                numUpDwnMemoire.Maximum = numUpDwnMemoire.Value;
                numUpDwnOrientation.Maximum = numUpDwnOrientation.Value;
                numUpDwnPerception.Maximum = numUpDwnPerception.Value;
                numUpDwnVolonte.Maximum = numUpDwnVolonte.Value;
            }
            else
            {
                numUpDwnConcentration.Maximum = 20;
                numUpDwnEssence.Maximum = 20;
                numUpDwnLogique.Maximum = 20;
                numUpDwnMemoire.Maximum = 20;
                numUpDwnOrientation.Maximum = 20;
                numUpDwnPerception.Maximum = 20;
                numUpDwnVolonte.Maximum = 20;
            }

            lblPtsRestantsRepartitionsCompetencesEsprit.Text = "Points restants : " + valeurPointsCompetencesEsprit.ToString();
        }
        /// <summary>
        /// Fais le calcul de la répartition des points de compétences de relationnel
        /// mets à jour le maximum une fois les points de répartition à 0,
        /// et mets à jour le nombre de points restants.
        /// </summary>
        private void CalculRepartitionCompetencesRelationnelles()
        {
            int valeurPointsCompetencesRelationnelles = GetPointsCompetencesRelationnelByLevel();
            valeurPointsCompetencesRelationnelles = valeurPointsCompetencesRelationnelles - ((int)numUpDwnApaisement.Value + (int)numUpDwnCharme.Value
                                                                                            + (int)numUpDwnComedie.Value + (int)numUpDwnCommandement.Value
                                                                                            + (int)numUpDwnIntimidation.Value + (int)numUpDwnPerspicacite.Value
                                                                                            + (int)numUpDwnProvocation.Value + (int)numUpDwnTromperie.Value);
            if (valeurPointsCompetencesRelationnelles == 0)
            {
                numUpDwnApaisement.Maximum = numUpDwnApaisement.Value;
                numUpDwnCharme.Maximum = numUpDwnCharme.Value;
                numUpDwnComedie.Maximum = numUpDwnComedie.Value;
                numUpDwnCommandement.Maximum = numUpDwnCommandement.Value;
                numUpDwnIntimidation.Maximum = numUpDwnIntimidation.Value;
                numUpDwnPerspicacite.Maximum = numUpDwnPerspicacite.Value;
                numUpDwnProvocation.Maximum = numUpDwnProvocation.Value;
                numUpDwnTromperie.Maximum = numUpDwnTromperie.Value;
            }
            else
            {
                numUpDwnApaisement.Maximum = 20;
                numUpDwnCharme.Maximum = 20;
                numUpDwnComedie.Maximum = 20;
                numUpDwnCommandement.Maximum = 20;
                numUpDwnIntimidation.Maximum = 20;
                numUpDwnPerspicacite.Maximum = 20;
                numUpDwnProvocation.Maximum = 20;
                numUpDwnTromperie.Maximum = 20;
            }

            lblPtsRestantsRepartitionsCompetencesRelationnelles.Text = "Points restants : " + valeurPointsCompetencesRelationnelles.ToString();
        }
        #endregion
    }
}
