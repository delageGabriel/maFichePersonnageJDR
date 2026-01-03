using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using maFichePersonnageJDR.Classe;
using maFichePersonnageJDR.View.Formulaires;
using System.Linq;

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

        private int[] pointsCompetencesCombats =
        {
            4,
            4,
            4,
            5,
            5,
            5,
            7,
            7,
            7,
            10,
            10,
            10,
            10,
            12,
            12,
            12,
            13,
            13,
            13,
            16
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

        private int pointsSpecialites = 400;

        private int[] pointsRepartitionsSortsAptitudes =
        {
            25,
            31,
            39,
            48,
            58,
            69,
            81,
            94,
            108,
            123,
            137,
            150,
            162,
            173,
            183,
            192,
            200,
            209,
            219,
            230
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
            CalculRepartitionCompetencesCombats();
            GetAllSpecialites();
            GetClassesSortsAptitudes();
            DisplayArmesName();

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
            foreach (Control ctrl in pnlCompetencesSpeciales.Controls)
            {
                if (ctrl is NumericUpDown nud)
                {
                    if (nud.Maximum < 0)
                        nud.Maximum = 25;
                    nud.Value = 0;
                }
            }

            /// Même logique...
            foreach (Control ctrl in pnlCompetencesCorps.Controls)
            {
                if (ctrl is NumericUpDown nud)
                {
                    if (nud.Maximum < 0)
                        nud.Maximum = 20;
                    nud.Value = 0;
                }
            }

            /// ...
            foreach (Control ctrl in pnlCompetencesEsprits.Controls)
            {
                if (ctrl is NumericUpDown nud)
                {
                    if (nud.Maximum < 0)
                        nud.Maximum = 20;
                    nud.Value = 0;
                }
            }

            /// ...
            foreach (Control ctrl in pnlCompetencesRelationnelles.Controls)
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
            CalculRepartitionCompetencesCombats();
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
            /***
             * PAGE CARACTERISTIQUES COMPETENCES
             */
            /// Simple sécurité pour éviter d'avoir un surplus de points de vie
            /// ou énergie.
            if (numUpDwnPtsVie.Value > 0 || numUpDwnPtsEnergie.Value > 0)
            {
                numUpDwnPtsVie.Value = 0;
                numUpDwnPtsEnergie.Value = 0;
            }
            /// Simple sécurité pour éviter d'avoir un surplus de points de vie
            /// ou énergie.
            numUpDwnPtsVie.Value = 0;
            numUpDwnPtsEnergie.Value = 0;

            /// Même logique avec les caractéristiques.
            numUpDwnPtsCorps.Value = 25;
            numUpDwnPtsEsprit.Value = 25;
            numUpDwnPtsRelationnel.Value = 25;

            /// Même logique...
            foreach (Control ctrl in pnlCompetencesSpeciales.Controls)
            {
                if (ctrl is NumericUpDown nud)
                {
                    if (nud.Maximum < 0)
                        nud.Maximum = 25;
                    nud.Value = 0;
                }
            }

            /// Même logique...
            foreach (Control ctrl in pnlCompetencesCorps.Controls)
            {
                if (ctrl is NumericUpDown nud)
                {
                    if (nud.Maximum < 0)
                        nud.Maximum = 20;
                    nud.Value = 0;
                }
            }

            /// ...
            foreach (Control ctrl in pnlCompetencesEsprits.Controls)
            {
                if (ctrl is NumericUpDown nud)
                {
                    if (nud.Maximum < 0)
                        nud.Maximum = 20;
                    nud.Value = 0;
                }
            }

            /// ...
            foreach (Control ctrl in pnlCompetencesRelationnelles.Controls)
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
            CalculRepartitionCompetencesCombats();

            /***
             * PAGE SORTS ET APTITUDES
             */
            for (int i = 0; i < chkdLstBxJeuxSortsAptitudes.Items.Count; i++)
            {
                chkdLstBxJeuxSortsAptitudes.SetItemChecked(i, false);
            }
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
        private void numUpDwnCompetencesCombat_ValueChanged(object sender, EventArgs e)
        {
            CalculRepartitionCompetencesCombats();
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

        private void numUpDwnSpecialites_ValueChanged(object sender, EventArgs e)
        {
            CalculRepartitionSpecialites();
        }

        private void checkBoxJeuxSortsAptitude_ItemChecked(object sender, ItemCheckEventArgs e)
        {
            int limite = 0;

            /// Si aucune taille n'est sélectionnée on quitte la méthode
            /// avec un message d'alerte pour éviter un bug.
            if (cbBxTaille.SelectedItem == null)
            {
                MessageBox.Show("Veuillez choisir une taille");
                e.NewValue = CheckState.Unchecked;

                return;
            }

            /// Changer la limite en fonction de la taille choisie
            /// pour la créature.
            switch (cbBxTaille.SelectedItem.ToString())
            {
                case "Minuscule":
                    limite = 2;
                    break;
                case "Petit":
                    limite = 3;
                    break;
                case "Moyen":
                    limite = 3;
                    break;
                case "Grand":
                    limite = 4;
                    break;
                case "Très grand":
                    limite = 5;
                    break;
                case "Gigantesque":
                    limite = 6;
                    break;
                default:
                    limite = 0;
                    Console.WriteLine("Pas de bonne taille !");
                    break;
            }

            var checkedListBox = (CheckedListBox)sender;

            // l’item concerné
            string valeur = checkedListBox.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                /// On gère ici les limitations dû à la taille.
                if (lstBxChoixSortsAptitudes.Items.Count == limite)
                {
                    MessageBox.Show("Vous ne pouvez choisir que " + limite.ToString() + " jeux de sorts et aptitudes !");
                    e.NewValue = CheckState.Unchecked;

                    return;
                }
                lstBxChoixSortsAptitudes.Items.Add(valeur);
            }
            else
            {
                lstBxChoixSortsAptitudes.Items.Remove(valeur);
            }
        }
        private void lstBxChoixSortsAptitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxChoixSortsAptitudes.SelectedItem is null)
            {
                Console.WriteLine("Liste des choix vide !");
                return;
            }
            else
            {
                string classeChoice = lstBxChoixSortsAptitudes.SelectedItem.ToString();

                GetTreeSortsAptitudes(classeChoice);
            }
        }
        private void linkLabelAptitudeSort_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = sender as LinkLabel;

            FormAptitude formAptitude = new FormAptitude();
            formAptitude.AptitudeValues = GetAptitude(link.Text);

            /// Si Domaine est vide, le reste doit forcément l'être aussi
            if (formAptitude.AptitudeValues["Domaine"] == string.Empty)
            {
                FormSorts formSorts = new FormSorts();
                formSorts.SortValues = GetSort(link.Text);

                formSorts.Show();
            }
            else
                formAptitude.Show();
        }
        private void btnValiderSortsAptitudesPersonnage_Click(object sender, EventArgs e)
        {
            int niveau = (int)nudNiveau.Value;

            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir ces classes ? Une fois validé, aucun retour en arrière n'est possible.",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                nudRepartitionPointSortsAptitudes.Enabled = true;
                btnValiderRepartitionPointsSortAptitude.Enabled = true;

                double multiplicateur = 0.0;

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
                        multiplicateur = 2;
                        Console.WriteLine("Pas de bonne taille !");
                        break;
                }

                int ptsRepartitionSortsAptitudes = (int)(pointsRepartitionsSortsAptitudes[niveau - 1] * multiplicateur);

                lblPointsRepartitionSortAptitude.Text = "Points restants : " + ptsRepartitionSortsAptitudes.ToString();
                chkdLstBxJeuxSortsAptitudes.Enabled = false;
            }
        }

        private void nudRepartitionPointSortsAptitudes_ValueChanged(object sender, EventArgs e)
        {
            CalculRepartitionPointsClasse();

            int valeurPointsRepartis = (int)nudRepartitionPointSortsAptitudes.Value;
            int seuilUn = int.Parse(lblPtsCmptUn.Text);
            int seuilDeux = int.Parse(lblPtsCmptDeux.Text);
            int seuilTrois = int.Parse(lblPtsCmptTrois.Text);
            int seuilQuatre = int.Parse(lblPtsCmptQuatre.Text);
            int seuilCinq = int.Parse(lblPtsCmptCinq.Text);
            int seuilSix = int.Parse(lblPtsCmptSix.Text);
            int seuilSept = int.Parse(lblPtsCmptSept.Text);
            int seuilHuit = int.Parse(lblPtsCmptHuit.Text);
            int seuilNeuf = int.Parse(lblPtsCmpNeuf.Text);
            int seuilDix = int.Parse(lblPtsCmptDix.Text);

            if (valeurPointsRepartis >= seuilUn)
                lblPtsCmptUn.ForeColor = Color.Green;
            if (valeurPointsRepartis >= seuilDeux)
                lblPtsCmptDeux.ForeColor = Color.Green;
            if (valeurPointsRepartis >= seuilTrois)
                lblPtsCmptTrois.ForeColor = Color.Green;
            if (valeurPointsRepartis >= seuilQuatre)
                lblPtsCmptQuatre.ForeColor = Color.Green;
            if (valeurPointsRepartis >= seuilCinq)
                lblPtsCmptCinq.ForeColor = Color.Green;
            if (valeurPointsRepartis >= seuilSix)
                lblPtsCmptSix.ForeColor = Color.Green;
            if (valeurPointsRepartis >= seuilSept)
                lblPtsCmptSept.ForeColor = Color.Green;
            if (valeurPointsRepartis >= seuilHuit)
                lblPtsCmptHuit.ForeColor = Color.Green;
            if (valeurPointsRepartis >= seuilNeuf)
                lblPtsCmpNeuf.ForeColor = Color.Green;
            if (valeurPointsRepartis >= seuilDix)
                lblPtsCmptDix.ForeColor = Color.Green;
        }

        private void btnValiderRepartitionPointsSortAptitude_Click(object sender, EventArgs e)
        {
            if (lblPtsCmptUn.ForeColor == Color.Green)
            {
                Label labelCompetence = new Label();
                labelCompetence.Text = lnkLblCmptUne.Text;
                flpSortsAptitudesPersonnages.Controls.Add(labelCompetence);
            }
            if (lblPtsCmptDeux.ForeColor == Color.Green)
            {
                Label labelCompetence = new Label();
                labelCompetence.Text = lnkLblCmptDeux.Text;
                flpSortsAptitudesPersonnages.Controls.Add(labelCompetence);
            }
            if (lblPtsCmptTrois.ForeColor == Color.Green)
            {
                Label labelCompetence = new Label();
                labelCompetence.Text = lnkLblCmptTrois.Text;
                flpSortsAptitudesPersonnages.Controls.Add(labelCompetence);
            }
            if (lblPtsCmptQuatre.ForeColor == Color.Green)
            {
                Label labelCompetence = new Label();
                labelCompetence.Text = lnkLblCmptQuatre.Text;
                flpSortsAptitudesPersonnages.Controls.Add(labelCompetence);
            }
            if (lblPtsCmptCinq.ForeColor == Color.Green)
            {
                Label labelCompetence = new Label();
                labelCompetence.Text = lnkLblCmptCinq.Text;
                flpSortsAptitudesPersonnages.Controls.Add(labelCompetence);
            }
            if (lblPtsCmptSix.ForeColor == Color.Green)
            {
                Label labelCompetence = new Label();
                labelCompetence.Text = lnkLblCmptSix.Text;
                flpSortsAptitudesPersonnages.Controls.Add(labelCompetence);
            }
            if (lblPtsCmptSept.ForeColor == Color.Green)
            {
                Label labelCompetence = new Label();
                labelCompetence.Text = lnkLblCmptSept.Text;
                flpSortsAptitudesPersonnages.Controls.Add(labelCompetence);
            }
            if (lblPtsCmptHuit.ForeColor == Color.Green)
            {
                Label labelCompetence = new Label();
                labelCompetence.Text = lnkLblCmptHuit.Text;
                flpSortsAptitudesPersonnages.Controls.Add(labelCompetence);
            }
            if (lblPtsCmpNeuf.ForeColor == Color.Green)
            {
                Label labelCompetence = new Label();
                labelCompetence.Text = lnkLblCmptNeuf.Text;
                flpSortsAptitudesPersonnages.Controls.Add(labelCompetence);
            }
            if (lblPtsCmptDix.ForeColor == Color.Green)
            {
                Label labelCompetence = new Label();
                labelCompetence.Text = lnkLblCmptDix.Text;
                flpSortsAptitudesPersonnages.Controls.Add(labelCompetence);
            }

            /// Mise à jour de l'item sélectionné dans la listBox pour garder le décompte des points
            int index = lstBxChoixSortsAptitudes.SelectedIndex;

            if (index != -1)
            {
                string nom = lstBxChoixSortsAptitudes.SelectedItem.ToString();
                lstBxChoixSortsAptitudes.Items[index] = $"{nom};{nudRepartitionPointSortsAptitudes.Value}";
            }

            nudRepartitionPointSortsAptitudes.Value = 0;
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
        /* PV ET ENERGIE
         */
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
        /* CARACTERISTIQUES
         */
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
        /* COMPETENCES COMBATS
         */
        /// <summary>
        /// Retourne le nombre de points de compétences de relationnelles à répartir en fonction
        /// du niveau du personnage.
        /// </summary>
        /// <returns>
        /// Nombre de points de compétences de relationnelles à répartir.
        /// </returns>
        private int GetPointsCompetencesCombatByLevel()
        {
            return pointsCompetencesCombats[(int)nudNiveau.Value - 1];
        }
        /* COMPETENCES CORPS
         */
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
        /* COMPETENCES ESPRITS
         */
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
        /* COMPETENCES RELATIONNELLES
         */
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
        /* SPECIALITES
         */
        /// <summary>
        /// Retourne toutes les spécialités disponibles à apprendre dans le jeu.
        /// </summary>
        private void GetAllSpecialites()
        {
            string oldName = string.Empty;

            /// On remplit chaque page du controleur
            foreach (TabPage pages in tbCtrlSpecialites.TabPages)
            {
                FlowLayoutPanel flp = pages.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();

                if (flp == null) return;

                // Je veux réinitialiser si on change de page.
                if (oldName != pages.Text)
                {
                    oldName = pages.Text;
                    // x = 10;
                }

                string nomPage = pages.Text;

                Dictionary<int, string> kVPSpecialites = Controller.SpecialitesController.GetSpecialitesByType(nomPage);

                if (kVPSpecialites != null)
                {
                    /// Parcours des valeurs du dictionnaire
                    foreach (string value in kVPSpecialites.Values)
                    {
                        /// Obligé de créer un container pour que ça s'imbrique parfaitement dans le flowlayoutpanel

                        /// PANEL
                        /// 
                        TableLayoutPanel container = new TableLayoutPanel
                        {
                            AutoSize = true,
                            ColumnCount = 2,
                            Tag = value,
                            Name = "pnl" + value
                        };

                        /// LABEL
                        Label labelSpecialite = new Label
                        {
                            Text = value,
                            Tag = value,
                            Name = "lbl" + value,
                            AutoSize = true
                        };

                        container.Controls.Add(labelSpecialite);

                        NumericUpDown numUpDownSpecialite = new NumericUpDown
                        {
                            Minimum = 0,
                            Maximum = 100,
                            Value = 0,
                            Tag = value,
                            Name = "nud" + value,
                            Size = new Size(43, 20)
                        };

                        numUpDownSpecialite.ValueChanged += numUpDwnSpecialites_ValueChanged;

                        container.Controls.Add(numUpDownSpecialite);

                        /// Ajout du panel avec le label et le numericupdown
                        flp.Controls.Add(container);

                        // Incrémentation des coordonnées X et Y
                        // x = numUpDownSpecialite.Right + 20;
                    }
                }
            }
        }
        /// <summary>
        /// Met la liste complète des sorts et aptitudes dans la checkedlistbox des jeux
        /// de sorts et aptitudes
        /// </summary>
        private void GetClassesSortsAptitudes()
        {
            List<string> classes = Controller.ClassesJeuxController.GetClassesNames();

            foreach (string classe in classes)
            {
                chkdLstBxJeuxSortsAptitudes.Items.Add(classe);
            }
        }
        /// <summary>
        /// Permets d'obtenir toutes les aptitudes et/ou sorts d'une classe
        /// ainsi que leur seuil de point à chaque niveau.
        /// </summary>
        /// <param name="name">
        /// Le nom de la classe dont il faut récupérer l'arbre.
        /// </param>
        private void GetTreeSortsAptitudes(string name)
        {
            string[] parts = name.Split(';');

            Dictionary<int, Controller.ClassesJeux> dictionaryClassesJeu = Controller.ClassesJeuxController.GetAptitudeOrSortSkillTree(parts[0]);

            var indexZero = dictionaryClassesJeu[0];
            var indexUn = dictionaryClassesJeu[1];
            var indexDeux = dictionaryClassesJeu[2];
            var indexTrois = dictionaryClassesJeu[3];
            var indexQuatre = dictionaryClassesJeu[4];
            var indexCinq = dictionaryClassesJeu[5];
            var indexSix = dictionaryClassesJeu[6];
            var indexSept = dictionaryClassesJeu[7];
            var indexHuit = dictionaryClassesJeu[8];
            var indexNeuf = dictionaryClassesJeu[9];

            lnkLblCmptUne.Text = indexZero.Nom;
            lblPtsCmptUn.Text = indexZero.Seuil.ToString();

            lnkLblCmptDeux.Text = indexUn.Nom;
            lblPtsCmptDeux.Text = indexUn.Seuil.ToString();

            lnkLblCmptTrois.Text = indexDeux.Nom;
            lblPtsCmptTrois.Text = indexDeux.Seuil.ToString();

            lnkLblCmptQuatre.Text = indexTrois.Nom;
            lblPtsCmptQuatre.Text = indexTrois.Seuil.ToString();

            lnkLblCmptCinq.Text = indexQuatre.Nom;
            lblPtsCmptCinq.Text = indexQuatre.Seuil.ToString();

            lnkLblCmptSix.Text = indexCinq.Nom;
            lblPtsCmptSix.Text = indexCinq.Seuil.ToString();

            lnkLblCmptSept.Text = indexSix.Nom;
            lblPtsCmptSept.Text = indexSix.Seuil.ToString();

            lnkLblCmptHuit.Text = indexSept.Nom;
            lblPtsCmptHuit.Text = indexSept.Seuil.ToString();

            lnkLblCmptNeuf.Text = indexHuit.Nom;
            lblPtsCmpNeuf.Text = indexHuit.Seuil.ToString();

            lnkLblCmptDix.Text = indexNeuf.Nom;
            lblPtsCmptDix.Text = indexNeuf.Seuil.ToString();
        }
        private Dictionary<string, string> GetAptitude(string name)
        {
            return Controller.NewAptitudesController.GetAptitudeInformationsByName(name);
        }
        private Dictionary<string, string> GetSort(string name)
        {
            return Controller.SortsController.GetSortInformationsByName(name);
        }
        /* PV ET ENERGIE
         */
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
        /* CARACTERISTIQUES
         */
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
        /* COMPETENCES COMBATS
         */
        /// <summary>
        /// Fais le calcul de la répartition des points de compétences de corps
        /// mets à jour le maximum une fois les points de répartition à 0,
        /// et mets à jour le nombre de points restants.
        /// </summary>
        private void CalculRepartitionCompetencesCombats()
        {
            int valeurPointsCompetencesCombat = GetPointsCompetencesCombatByLevel();
            valeurPointsCompetencesCombat = valeurPointsCompetencesCombat - ((int)numUpDwnDexterite.Value + (int)numUpDwnInitiative.Value
                                                                            + (int)numUpDwnDeplacement.Value);

            if (valeurPointsCompetencesCombat == 0)
            {
                numUpDwnDexterite.Maximum = numUpDwnDexterite.Value;
                numUpDwnInitiative.Maximum = numUpDwnInitiative.Value;
                numUpDwnDeplacement.Maximum = numUpDwnDeplacement.Value;
            }
            else
            {
                numUpDwnDexterite.Maximum = 25;
                numUpDwnInitiative.Maximum = 25;
                numUpDwnDeplacement.Maximum = 25;
            }

            lblPtsRestantsRepartitionsCompetencesSpeciales.Text = "Points restants : " + valeurPointsCompetencesCombat.ToString();
        }
        /* COMPETENCES CORPS
         */
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
        /* COMPETENCES ESPRIT
         */
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
        /* COMPETENCES RELATIONNELLES
         */
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

        private void CalculRepartitionSpecialites()
        {
            int valeurPointsSpecialites = pointsSpecialites;
            int count = 0;

            foreach (TabPage pages in tbCtrlSpecialites.TabPages)
            {
                /// Je récupère le FlowLayoutPanel de la page sinon impossible
                /// d'accéder aux NumericUpDown
                FlowLayoutPanel flpPage = (FlowLayoutPanel)pages.Controls[0];

                Console.WriteLine("ENTREE DANS LA PREMIERE BOUCLE POUR PARCOURIR LES PAGES");

                foreach (Control ctrl in flpPage.Controls)
                {
                    Console.WriteLine("ENTREE DANS BOUCLE DE VERIFICATION DES CONTROLS");

                    /// Pareil, je ne peux pas accéder aux NumericUpDown
                    /// sans passer par les TableLayoutPanel
                    if (ctrl is TableLayoutPanel tlp)
                    {
                        foreach (Control control in tlp.Controls)
                        {
                            Console.WriteLine("ENTREE DANS BOUCLE LORSQU'ON A TROUVE UN NUMERICUPDOWN");

                            if (control is NumericUpDown nud)
                                count += (int)nud.Value;
                        }
                    }
                }
            }

            valeurPointsSpecialites = valeurPointsSpecialites - count;

            /// Même logique de déplacement dans les boucles appliquée ici
            /// sinon je n'ai pas accès aux NumericUpDown
            if (valeurPointsSpecialites == 0)
            {
                foreach (TabPage pages in tbCtrlSpecialites.TabPages)
                {
                    /// Je récupère le FlowLayoutPanel de la page sinon impossible
                    /// d'accéder aux NumericUpDown
                    FlowLayoutPanel flpPage = (FlowLayoutPanel)pages.Controls[0];

                    foreach (Control ctrl in flpPage.Controls)
                    {

                        /// Pareil, je ne peux pas accéder aux NumericUpDown
                        /// sans passer par les TableLayoutPanel
                        if (ctrl is TableLayoutPanel tlp)
                        {
                            foreach (Control control in tlp.Controls)
                            {

                                if (control is NumericUpDown nud)
                                {
                                    nud.Maximum = nud.Value;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (TabPage pages in tbCtrlSpecialites.TabPages)
                {
                    /// Je récupère le FlowLayoutPanel de la page sinon impossible
                    /// d'accéder aux NumericUpDown
                    FlowLayoutPanel flpPage = (FlowLayoutPanel)pages.Controls[0];

                    foreach (Control ctrl in flpPage.Controls)
                    {

                        /// Pareil, je ne peux pas accéder aux NumericUpDown
                        /// sans passer par les TableLayoutPanel
                        if (ctrl is TableLayoutPanel tlp)
                        {
                            foreach (Control control in tlp.Controls)
                            {

                                if (control is NumericUpDown nud)
                                {
                                    nud.Maximum = 100;
                                }
                            }
                        }
                    }
                }
            }

            lblPtsRepartitionSpecialites.Text = "Points restants à répartir : " + valeurPointsSpecialites;
        }

        private void CalculRepartitionPointsClasse()
        {
            int niveau = (int)nudNiveau.Value;
            double multiplicateur = 0.0;

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
                    multiplicateur = 2;
                    Console.WriteLine("Pas de bonne taille !");
                    break;
            }

            int ptsRepartitionSortsAptitudes = (int)(pointsRepartitionsSortsAptitudes[niveau - 1] * multiplicateur);

            int valeurPointsRestants = ptsRepartitionSortsAptitudes - ((int)nudRepartitionPointSortsAptitudes.Value);

            lblPointsRepartitionSortAptitude.Text = "Points restants : " + valeurPointsRestants.ToString();
        }

        private void DisplayArmesName()
        {
            foreach (TabPage page in tbCtrlArmes.TabPages)
            {
                string pageText = page.Text;

                List<string> nameArme = Controller.ArmesController.GetArmeNamesByType(pageText);

                FlowLayoutPanel flp = page.Controls
                    .OfType<FlowLayoutPanel>()
                    .First();

                foreach (string name in nameArme)
                {
                    flp.Controls.Add(CreateArmeRow(name));
                }
            }
        }

        /// <summary>
        /// Créer dynamiquement un Panel dans lequel sont stockés
        /// toutes les données pour acheter ou se renseigner sur une arme.
        /// </summary>
        /// <param name="nomArme">
        /// Le nom de l'arme dont il faut se renseigner ou acheter
        /// </param>
        /// <returns>
        /// Le panel avec toutes les informations de l'arme.
        /// </returns>
        private FlowLayoutPanel CreateArmeRow(string nomArme)
        {
            /// Création des Controls
            /// 
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Height = 28,
                Width = 500,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Padding = new Padding(5, 2, 5, 2)
            };

            LinkLabel link = new LinkLabel
            {
                Text = nomArme,
                AutoSize = true
            };

            NumericUpDown nud = new NumericUpDown
            {
                Width = 45,
                Minimum = 0,
                Maximum = 99
            };

            Button btn = new Button
            {
                Text = "Acheter",
                AutoSize = true
            };

            /// Association des données
            /// 
            link.Tag = nomArme;
            btn.Tag = nud;

            /// Events
            /// 
            link.LinkClicked += (sender, e) =>
            {
                FormArmes formArmes = new FormArmes();

                formArmes.ArmeValues = Controller.ArmesController.GetArmeInformationsByName(nomArme);

                formArmes.Show();
            };

            btn.Click += (sender, e) =>
            {
                int poids = int.Parse(Controller.ArmesController.GetArmeWeightByName(nomArme));
                int qte = (int)nud.Value;

                if (qte <= 0)
                {
                    MessageBox.Show("Veuillez sélectionner une quantité supérieure à 0");
                    return;
                }
                else
                {
                    chkLBxArmesInventaire.Items.Add(nomArme + ";" + qte);
                }
            };

            /// Ajout des Controls dans le Panel
            /// et return
            /// 
            panel.Controls.Add(link);
            panel.Controls.Add(nud);
            panel.Controls.Add(btn);

            return panel;
        }
        #endregion
    }
}
