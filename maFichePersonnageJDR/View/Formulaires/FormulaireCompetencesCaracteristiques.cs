using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maFichePersonnageJDR.Classe;
using maFichePersonnageJDR.Formulaires;

namespace maFichePersonnageJDR.View.Formulaires
{
    public partial class FormulaireCompetencesCaracteristiques : Form
    {
        /// <summary>
        /// Champs des points à répartir dans les trois type compétences
        /// </summary>
        private int compPhysique = 42;
        private int compMentale = 42;
        private int compSociale = 33;

        /// <summary>
        /// Champs du nombre de fois que le l'utilisateur peut
        /// ajouter des points de compétences dans un des trois types
        /// et le maximum qu'on peut répartir dans une caractéristique
        /// au niveau du personnage
        /// </summary>
        private string nbFoisPointsMiseAJour;
        private int maximumCaracteristiquesDefaut;

        /// <summary>
        /// Champs du nombre de points qu'on peut ajouter dans chaque
        /// compétences une fois le niveau suivant atteint
        /// </summary>
        private const int pointsPhysique = 6;
        private const int pointsMental = 6;
        private const int pointsSocial = 4;

        /// <summary>
        /// Stockage des controls du formulaire
        /// </summary>
        private Dictionary<Control, Rectangle> dictionaryControlOriginalSize = new Dictionary<Control, Rectangle>();
        private Dictionary<Label, Tuple<Rectangle, float>> dictionaryLabelOriginalSize = new Dictionary<Label, Tuple<Rectangle, float>>();

        /// <summary>
        /// 
        /// </summary>
        private Dictionary<string, Action<int>> competencesMiseAJour;

        /// <summary>
        /// Accesseurs et Mutateurs
        /// </summary>
        public int CompPhysique
        {
            get => compPhysique;
            set
            {
                compPhysique = value;
            }
        }
        public int CompMentale
        {
            get => compMentale;
            set
            {
                compMentale = value;
            }
        }
        public int CompSociale
        {
            get => compSociale; set
            {
                compSociale = value;
            }
        }

        public string NbFoisPointsMiseAJour
        {
            get => nbFoisPointsMiseAJour;
            set
            {
                if (nbFoisPointsMiseAJour != value)
                {
                    nbFoisPointsMiseAJour = value;
                }

            }
        }

        public int MaximumCaracteristiquesDefaut
        {
            get => maximumCaracteristiquesDefaut;
            set
            {
                if (maximumCaracteristiquesDefaut != value)
                {
                    maximumCaracteristiquesDefaut = value;
                }
            }
        }

        public static int PointsPhysique => pointsPhysique;

        public static int PointsMental => pointsMental;

        public static int PointsSocial => pointsSocial;

        /// <summary>
        /// Méthodes
        /// </summary>
        public FormulaireCompetencesCaracteristiques()
        {
            InitializeComponent();

            // Initialisation du dictionnaire
            competencesMiseAJour = new Dictionary<string, Action<int>>
            {
                { "Physique", (points) => {CompPhysique += points; txtBxCompPhy.Text = CompPhysique.ToString(); } },
                { "Mental", (points) => {CompMentale += points; txtBxCompMen.Text = CompMentale.ToString(); } },
                { "Social", (points) => {CompSociale += points; txtBxComSoc.Text = CompSociale.ToString(); } }
            };
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            /**
             * Test PV&Energie
             */
            if (int.Parse(txtPntsPVEnergie.Text) > 0)
            {
                MessageBox.Show("Il vous reste des points à répartir dans vos PV ou votre énergie");
                return;
            }

            /**
             * Test CARACTERISTIQUES
             */
            if (int.Parse(txtPntsCaracteristiques.Text) > 0)
            {
                MessageBox.Show("Il vous reste des points à répartir dans vos caractéristiques");
                return;
            }

            /**
             * Test COMP&PHY
             */
            if (int.Parse(txtBxCompPhy.Text) > 0)
            {
                MessageBox.Show("Il vous reste des points à répartir dans vos compétences physiques");
                return;
            }

            /**
             * Test COMP&MEN
             */
            if (int.Parse(txtBxCompMen.Text) > 0)
            {
                MessageBox.Show("Il vous reste des points à répartir dans vos compétences mentales");
                return;
            }

            /**
             * Test COMP&SOC
             */
            if (int.Parse(txtBxComSoc.Text) > 0)
            {
                MessageBox.Show("Il vous reste des points à répartir dans vos compétences sociales");
                return;
            }

            FormulaireEquipments formulaireEquipments = new FormulaireEquipments();

            // Ajout des caractéristiques
            Controller.CompetencesCaracteristiquesController.SaveCaracteristiques(GlobaleVariables.IdPersonnage, Convert.ToInt32(nudPhysique.Value), Convert.ToInt32(nudMental.Value),
                Convert.ToInt32(nudSocial.Value));

            // Ajout des compétences mentales
            Controller.CompetencesCaracteristiquesController.SaveCompetenceMentalPersonnage(GlobaleVariables.IdPersonnage, Convert.ToInt32(nudCncention.Value), Convert.ToInt32(nudConnGeographiques.Value),
                Convert.ToInt32(nudConnHistoriques.Value), Convert.ToInt32(nudMagiques.Value), Convert.ToInt32(nudConnNatures.Value), Convert.ToInt32(nudConnReligieuses.Value),
                Convert.ToInt32(nudEsprit.Value), Convert.ToInt32(nudExplosifs.Value), Convert.ToInt32(nudMecanique.Value), Convert.ToInt32(nudMedecine.Value),
                Convert.ToInt32(nudMemoire.Value), Convert.ToInt32(nudOrientation.Value), Convert.ToInt32(nudPerception.Value), Convert.ToInt32(nudVolonte.Value));

            // Ajout des compétences physiques
            Controller.CompetencesCaracteristiquesController.SaveCompetencePhysiquePersonnage(GlobaleVariables.IdPersonnage, Convert.ToInt32(nudAgilite.Value), 
                Convert.ToInt32(nudArtisanat.Value), Convert.ToInt32(nudCrochetage.Value), Convert.ToInt32(nudDiscretion.Value), Convert.ToInt32(nudEqlibre.Value), 
                Convert.ToInt32(nudEquitation.Value), Convert.ToInt32(nudEscalade.Value), Convert.ToInt32(nudEscamotage.Value), Convert.ToInt32(nudForce.Value), 
                Convert.ToInt32(nudFouille.Value), Convert.ToInt32(nudLutte.Value), Convert.ToInt32(nudNatation.Value), Convert.ToInt32(nudReflexes.Value), 
                Convert.ToInt32(nudVigueur.Value));

            // Ajout des compétences sociales
            Controller.CompetencesCaracteristiquesController.SaveCompetenceSocialPersonnage(GlobaleVariables.IdPersonnage, Convert.ToInt32(nudBaratinage.Value),
                Convert.ToInt32(nudCharme.Value), Convert.ToInt32(nudCmedie.Value), Convert.ToInt32(nudCommandement.Value), Convert.ToInt32(nudDiplomatie.Value),
                Convert.ToInt32(nudDressage.Value), Convert.ToInt32(nudIntimidation.Value), Convert.ToInt32(nudMarchandage.Value), Convert.ToInt32(nudPrestance.Value),
                Convert.ToInt32(nudProvocation.Value), Convert.ToInt32(nudRepresentation.Value));

            // Ajout des PV et Energie
            Controller.CompetencesCaracteristiquesController.SavePVAndEnergie(
                GlobaleVariables.IdPersonnage, nudPV.Value.ToString() +
                CalculPointsVieEnergieSupplementaire(Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "vigueur", GlobaleVariables.IdPersonnage)),
                nudEnergie.Value.ToString() +
                CalculPointsVieEnergieSupplementaire(Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "esprit", GlobaleVariables.IdPersonnage)));

            MessageBox.Show("Compétences et caractéristiques sauvegardées");
            GlobaleVariables.IsClosedProgrammatically = true;
            formulaireEquipments.Show();
            this.Close();
        }

        /// <summary>
        /// Permet d'obtenir le nombre de points à répartir entre les pv et l'énergie
        /// </summary>
        public void GetPointsToRepartPvEnergieByNiveau()
        {
            int maximum = Controller.CompetencesCaracteristiquesController.GetPointPvEnergieRepartition(Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage));
            txtPntsPVEnergie.Text = maximum.ToString();
            nudPV.Maximum = maximum;
            nudEnergie.Maximum = maximum;
        }

        /// <summary>
        /// Permet d'obtenir le nombre de points à répartir entre les trois
        /// caractéristiques
        /// </summary>
        public void GetPointsToRepartCaracteristiquesByNiveau()
        {
            txtPntsCaracteristiques.Text = Controller.CompetencesCaracteristiquesController.GetPointCaracteristiquesRepartition(Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage)).ToString();
        }

        private void FormulaireCompetencesCaracteristiques_Load(object sender, EventArgs e)
        {
            // Chargement des points à répartir pour PvEnergie et Caractéristiques en fonction du niveau
            GetPointsToRepartPvEnergieByNiveau();
            GetPointsToRepartCaracteristiquesByNiveau();
            GetMaximumForCaracteristiques();

            // Initialisation du dictionnaire pour gérer la taille et l'emplacement originaux des contrôles
            dictionaryControlOriginalSize.Add(this, new Rectangle(this.Location, this.Size));

            // Parcours de tous les contrôles pour sauvegarder leur taille et position initiales
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    // Pour les labels, sauvegarde également la taille de la police
                    dictionaryLabelOriginalSize.Add(ctrl as Label, new Tuple<Rectangle, float>(new Rectangle(ctrl.Location, ctrl.Size), (ctrl as Label).Font.Size));
                }
                else
                {
                    dictionaryControlOriginalSize.Add(ctrl, new Rectangle(ctrl.Location, ctrl.Size));
                }
            }

            /**
             * Activation ou désactivation des contrôles de répartition des points en fonction du niveau du personnage
             */
            foreach (Control control in pnlPvEnergie.Controls)
            {
                dictionaryControlOriginalSize.Add(control, new Rectangle(control.Location, control.Size));
            }

            foreach (Control control in pnlCaracteristiques.Controls)
            {
                dictionaryControlOriginalSize.Add(control, new Rectangle(control.Location, control.Size));
            }

            foreach (Control control in gbPhysique.Controls)
            {
                dictionaryControlOriginalSize.Add(control, new Rectangle(control.Location, control.Size));
            }

            foreach (Control control in gbMental.Controls)
            {
                dictionaryControlOriginalSize.Add(control, new Rectangle(control.Location, control.Size));
            }

            foreach (Control control in gbSocial.Controls)
            {
                dictionaryControlOriginalSize.Add(control, new Rectangle(control.Location, control.Size));
            }

            // Traitement conditionnel si le formulaire est en mode édition
            if (GlobaleVariables.IsEdit)
            {
                EditUpdateCompCarac();
            }
            else
            {
                // Configuration initiale des champs de texte avec les valeurs par défaut
                txtBxCompPhy.Text = CompPhysique.ToString();
                txtBxCompMen.Text = CompMentale.ToString();
                txtBxComSoc.Text = CompSociale.ToString();
            }

            // Activation ou désactivation des contrôles de répartition des points en fonction du niveau du personnage
            if (Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage) > 1)
            {
                string[] lblSplited = lblNbRepartitionComp.Text.Split(':');
                string newStringLabelNbRepartComp = $"{lblSplited[0]}: {Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage) - 1}";
                lblNbRepartitionComp.Text = newStringLabelNbRepartComp;

                EnableOrDisableTextBoxButtonRepartitionPoints(true);
            }
        }

        /// <summary>
        /// Événement qui permet de gérer le nombre de points à répartir dans les Numeric
        /// PV et Énergie ainsi que le maximum pouvant être attribué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudPVEnergie_ValueChanged(object sender, EventArgs e)
        {
            // Récupérer la valeur actuelle des points de vie et d'énergie
            int pointsPV = (int)nudPV.Value;
            int pointsEnergie = (int)nudEnergie.Value;

            // Calculer le total des points disponibles
            int totalPoints = Controller.CompetencesCaracteristiquesController.GetPointPvEnergieRepartition(Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage));

            // Calculer le nombre de points disponibles pour l'autre attribut
            int pointsRestantsPV = totalPoints - pointsEnergie;
            int pointsRestantsEnergie = totalPoints - pointsPV;

            // Mettre à jour la valeur maximale des deux contrôles NumericUpDown
            nudPV.Maximum = pointsRestantsPV;
            nudEnergie.Maximum = pointsRestantsEnergie;

            txtPntsPVEnergie.Text = (totalPoints - ((int)nudPV.Value + (int)nudEnergie.Value)).ToString();
        }

        /// <summary>
        /// Événement qui permet de gérer le nombre de points à répartir dans les Numeric
        /// caractéristiques ainsi que le maximum pouvant être attribué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudPhyMenSoc_ValueChanged(object sender, EventArgs e)
        {
            /// Récupération des valeurs de chaque NumericUpDown caractéristiques
            int pointsPhy = (int)nudPhysique.Value;
            int pointsMen = (int)nudMental.Value;
            int pointsSoc = (int)nudSocial.Value;
            int sommePoints = pointsPhy + pointsMen + pointsSoc;

            // Obtention du total de points à répartir
            int totalPoints = Controller.CompetencesCaracteristiquesController.GetPointCaracteristiquesRepartition(Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage));

            /// Calcul des points restants à répartir dans chaque caractéristique
            int pointsRestantsPhy = totalPoints - (pointsMen + pointsSoc);
            int pointsRestantsMen = totalPoints - (pointsPhy + pointsSoc);
            int pointsRestantsSoc = totalPoints - (pointsMen + pointsPhy);

            /// Mise à jour du maximum de point à répartir en fonction 
            nudPhysique.Maximum = totalPoints - ((int)nudPhysique.Value + (int)nudMental.Value + (int)nudSocial.Value) > 0 ? MaximumCaracteristiquesDefaut : pointsRestantsPhy;
            nudMental.Maximum = totalPoints - ((int)nudPhysique.Value + (int)nudMental.Value + (int)nudSocial.Value) > 0 ? MaximumCaracteristiquesDefaut : pointsRestantsMen;
            nudSocial.Maximum = totalPoints - ((int)nudPhysique.Value + (int)nudMental.Value + (int)nudSocial.Value) > 0 ? MaximumCaracteristiquesDefaut : pointsRestantsSoc;

            // Mise à jour du nombre de points restants total à répartir dans les trois caractéristiques
            txtPntsCaracteristiques.Text = (totalPoints - sommePoints).ToString();
        }

        /// <summary>
        /// Événement qui gère la répartition des points de compétences physique à répartir ainsi que leur maximum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudCompPhy_ValueChanged(object sender, EventArgs e)
        {
            int sommeDesValeurs = CalculerSommeValeursNumericUpDown(gbPhysique);

            int pointsRestants = CompPhysique - sommeDesValeurs;

            // Et ensuite on met à jour la TextBox des points à répartir
            txtBxCompPhy.Text = pointsRestants.ToString();
        }

        /// <summary>
        /// Événement qui gère la répartition des points de compétences mentale à répartir ainsi que leur maximum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudCompMen_ValueChanged(object sender, EventArgs e)
        {
            int sommeDesValeurs = CalculerSommeValeursNumericUpDown(gbMental);

            int pointsRestants = CompMentale - sommeDesValeurs;

            txtBxCompMen.Text = pointsRestants.ToString();
        }

        /// <summary>
        /// Événement qui gère la répartition des points de compétences sociale à répartir ainsi que leur maximum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudCompSoc_ValueChanged(object sender, EventArgs e)
        {
            int sommeDesValeurs = CalculerSommeValeursNumericUpDown(gbSocial);

            int pointsRestants = CompSociale - sommeDesValeurs;

            txtBxComSoc.Text = pointsRestants.ToString();
        }

        /// <summary>
        /// Permet de calculer la somme des valeurs de chaque NumericUpDown
        /// présents dans une GroupBox
        /// </summary>
        /// <param name="groupBox">GroupBox qui contient les NumericUpDown</param>
        /// <returns>La  somme de chaque NumericUpDown</returns>
        private int CalculerSommeValeursNumericUpDown(GroupBox groupBox)
        {
            return groupBox.Controls
                .OfType<NumericUpDown>()
                .Sum(nud => (int)nud.Value);
        }

        /// <summary>
        /// Permet de mettre à jour le maximum de tous les NumericUpDown enfants d'une GroupBox parent
        /// </summary>
        /// <param name="groupBox">La GroupBox qui contient les NumericUpDown</param>
        /// <param name="pointsRestants">Les points qu'ils restent à répartir</param>
        private void MettreAJourMaximumNumericUpDown(GroupBox groupBox, int pointsRestants)
        {
            int maximumNud = GetMaximumDefautNumericUpDown();

            foreach (NumericUpDown nud in groupBox.Controls.OfType<NumericUpDown>())
            {
                nud.Maximum = pointsRestants == 0 ? nud.Value : maximumNud;
            }
        }

        /// <summary>
        /// Permet d'indiquer combien de fois encore le personnage peut ajouter des points de compétences dans
        /// une de ces trois compétences majeures
        /// </summary>
        private void GetNbFoisPointsRepartitions(bool retirePoint = false)
        {
            // On récupère le nombre de fois à répartir
            string[] subsplit = lblNbRepartitionComp.Text.Split(':');

            if (retirePoint)
            {
                int nbMoinsUn = int.Parse(subsplit[1]);
                NbFoisPointsMiseAJour = subsplit[0] + ": " + (nbMoinsUn - 1).ToString();

                if (nbMoinsUn - 1 == 0)
                {
                    EnableOrDisableTextBoxButtonRepartitionPoints(false);
                }
            }
            else
            {
                NbFoisPointsMiseAJour = subsplit[0] + ": " + (Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage) - 1).ToString();
            }

            lblNbRepartitionComp.Text = NbFoisPointsMiseAJour;
        }

        /// <summary>
        /// Événément qui permet d'ajouter des points dans le total de points
        /// de compétences physique à répartir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPtsPhy_Click(object sender, EventArgs e)
        {
            txtBxCompPhy.Text = (int.Parse(txtBxCompPhy.Text) + PointsPhysique).ToString();
            CompPhysique += PointsPhysique;
            GetNbFoisPointsRepartitions(true);
        }

        /// <summary>
        /// Événément qui permet d'ajouter des points dans le total de points
        /// de compétences mentale à répartir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPtsMen_Click(object sender, EventArgs e)
        {
            txtBxCompMen.Text = (int.Parse(txtBxCompMen.Text) + PointsMental).ToString();
            CompMentale += PointsMental;
            GetNbFoisPointsRepartitions(true);
        }

        private void btnAddPtsSoc_Click(object sender, EventArgs e)
        {
            txtBxComSoc.Text = (int.Parse(txtBxComSoc.Text) + PointsSocial).ToString();
            CompSociale += PointsSocial;
            GetNbFoisPointsRepartitions(true);
        }

        /// <summary>
        /// Permet de savoir si on affiche ou cache les contrôles pour modifier le nombre de points de compétences
        /// maximales
        /// </summary>
        /// <param name="isEnable"></param>
        private void EnableOrDisableTextBoxButtonRepartitionPoints(bool isEnable)
        {
            if (isEnable)
            {
                btnAddPtsPhy.Visible = true;
                btnAddPtsPhy.Enabled = true;

                btnAddPtsMen.Visible = true;
                btnAddPtsMen.Enabled = true;

                btnAddPtsSoc.Visible = true;
                btnAddPtsSoc.Enabled = true;

                lblNbRepartitionComp.Visible = true;
            }
            else
            {
                btnAddPtsPhy.Visible = false;
                btnAddPtsPhy.Enabled = false;

                btnAddPtsMen.Visible = false;
                btnAddPtsMen.Enabled = false;

                btnAddPtsSoc.Visible = false;
                btnAddPtsSoc.Enabled = false;

                lblNbRepartitionComp.Visible = false;
            }
        }

        /// <summary>
        /// Obtient le maximum à mettre dans trois caractéristiques en fonction
        /// du niveau
        /// </summary>
        private void GetMaximumForCaracteristiques()
        {
            int niveauDuPersonnage = Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage);

            if (niveauDuPersonnage <= 3)
            {
                MaximumCaracteristiquesDefaut = 55;
            }
            else if (niveauDuPersonnage <= 9)
            {
                MaximumCaracteristiquesDefaut = 60;
            }
            else if (niveauDuPersonnage <= 12)
            {
                MaximumCaracteristiquesDefaut = 65;
            }
            else if (niveauDuPersonnage <= 18)
            {
                MaximumCaracteristiquesDefaut = 70;
            }
            else
            {
                MaximumCaracteristiquesDefaut = 75;
            }
        }

        private int GetMaximumDefautNumericUpDown()
        {
            int niveauPersonnage = Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage);

            if (niveauPersonnage <= 5)
            {
                return 15;
            }
            else if (niveauPersonnage <= 12)
            {
                return 18;
            }
            else
            {
                return 20;
            }
        }

        /// <summary>
        /// Permet de redimensionner le formulaire et ses controls enfants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormulaireCompetencesCaracteristiques_Resize(object sender, EventArgs e)
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

        private void EditUpdateCompCarac()
        {
            string[] splitPv = Controller.CompetencesCaracteristiquesController.GetValuePvEnergie("pv", "nombre_points_pv", GlobaleVariables.IdPersonnage).Split('+');
            string[] splitEnrgie = Controller.CompetencesCaracteristiquesController.GetValuePvEnergie("energie", "nombre_points_energie", GlobaleVariables.IdPersonnage).Split('+');
            /**
             * PV ET ENERGIE
             */
            nudPV.Value = decimal.Parse(splitPv[0]);
            nudEnergie.Value = decimal.Parse(splitEnrgie[0]);

            /**
             * CARACTERISTIQUE
             */
            nudPhysique.Value = Controller.CompetencesCaracteristiquesController.GetPhysiquePersonnage(GlobaleVariables.IdPersonnage);
            nudMental.Value = Controller.CompetencesCaracteristiquesController.GetMentalPersonnage(GlobaleVariables.IdPersonnage);
            nudSocial.Value = Controller.CompetencesCaracteristiquesController.GetSocialPersonnage(GlobaleVariables.IdPersonnage);
            /**
             * COMP PHYSIQUE
             */
            nudAgilite.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "agilite", GlobaleVariables.IdPersonnage);
            nudArtisanat.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "artisanat", GlobaleVariables.IdPersonnage);
            nudCrochetage.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "crochetage", GlobaleVariables.IdPersonnage);
            nudDiscretion.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "discretion", GlobaleVariables.IdPersonnage);
            nudEqlibre.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "equilibre", GlobaleVariables.IdPersonnage);
            nudEquitation.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "equitation", GlobaleVariables.IdPersonnage);
            nudEscalade.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "escalade", GlobaleVariables.IdPersonnage);
            nudEscamotage.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "escamotage", GlobaleVariables.IdPersonnage);
            nudForce.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "escamotage", GlobaleVariables.IdPersonnage);
            nudFouille.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "fouille", GlobaleVariables.IdPersonnage);
            nudNatation.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "natation", GlobaleVariables.IdPersonnage);
            nudReflexes.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "reflexes", GlobaleVariables.IdPersonnage);
            nudVigueur.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Physique", "vigueur", GlobaleVariables.IdPersonnage);
            /**
             * COMP MENTAL
             */
            nudCncention.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "concentration", GlobaleVariables.IdPersonnage);
            nudConnGeographiques.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "connaissance_geographiques", GlobaleVariables.IdPersonnage);
            nudConnHistoriques.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "connaissance_historiques", GlobaleVariables.IdPersonnage);
            nudMagiques.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "connaissance_magiques", GlobaleVariables.IdPersonnage);
            nudConnNatures.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "connaissance_natures", GlobaleVariables.IdPersonnage);
            nudConnReligieuses.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "connaissance_religieuses", GlobaleVariables.IdPersonnage);
            nudEsprit.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "esprit", GlobaleVariables.IdPersonnage);
            nudExplosifs.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "explosifs", GlobaleVariables.IdPersonnage);
            nudMecanique.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "mecanique", GlobaleVariables.IdPersonnage);
            nudMedecine.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "medecine", GlobaleVariables.IdPersonnage);
            nudMemoire.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "memoire", GlobaleVariables.IdPersonnage);
            nudOrientation.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "orientation", GlobaleVariables.IdPersonnage);
            nudPerception.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "perception", GlobaleVariables.IdPersonnage);
            nudVolonte.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "volonte", GlobaleVariables.IdPersonnage);
            /**
             * COMP SOCIAL
             */
            nudBaratinage.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Social", "baratinage", GlobaleVariables.IdPersonnage);
            nudCharme.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Social", "charme", GlobaleVariables.IdPersonnage);
            nudCmedie.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Social", "comedie", GlobaleVariables.IdPersonnage);
            nudCommandement.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Social", "commandement", GlobaleVariables.IdPersonnage);
            nudDiplomatie.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Social", "diplomatie", GlobaleVariables.IdPersonnage);
            nudDressage.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Social", "dressage", GlobaleVariables.IdPersonnage);
            nudIntimidation.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Social", "intimidation", GlobaleVariables.IdPersonnage);
            nudMarchandage.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Social", "marchandage", GlobaleVariables.IdPersonnage);
            nudPrestance.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Social", "prestance", GlobaleVariables.IdPersonnage);
            nudProvocation.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Social", "provocation", GlobaleVariables.IdPersonnage);
            nudRepresentation.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Social", "representation", GlobaleVariables.IdPersonnage);
        }

        private void FormulaireCompetencesCaracteristiques_FormClosing(object sender, FormClosingEventArgs e)
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
                        Controller.PersonnageController.DeleteRowPersonnage(GlobaleVariables.IdPersonnage);
                    }
                }
            }
            else
            {
                GlobaleVariables.IsClosedProgrammatically = false;
            }
        }

        private void txtBxCompPhy_TextChanged(object sender, EventArgs e)
        {
            int pointsTextBox = int.Parse((sender as TextBox).Text);

            MettreAJourMaximumNumericUpDown(gbPhysique, pointsTextBox);
        }

        private void txtBxCompMen_TextChanged(object sender, EventArgs e)
        {
            int pointsTextBox = int.Parse((sender as TextBox).Text);

            MettreAJourMaximumNumericUpDown(gbMental, pointsTextBox);
        }

        private void txtBxComSoc_TextChanged(object sender, EventArgs e)
        {
            int pointsTextBox = int.Parse((sender as TextBox).Text);

            MettreAJourMaximumNumericUpDown(gbSocial, pointsTextBox);
        }

        private string CalculPointsVieEnergieSupplementaire(int valueComp)
        {
            int valueResult = 0;

            // Cas ou le personnage a son niveau supérieur à 1
            if (Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage) > 1)
            {
                int drawNumber = Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage) - 1;
                int facesDe = 0;
                int countValueDiceDraw = 0;

                // On cherche le nombre de face du dé à lancer 
                // par rapport à la valeur de sa compétence
                if (valueComp <= 0)
                {
                    facesDe = 4;
                }
                else if (valueComp <= 5)
                {
                    facesDe = 6;
                }
                else if (valueComp <= 10)
                {
                    facesDe = 8;
                }
                else if (valueComp <= 15)
                {
                    facesDe = 10;
                }
                else
                {
                    facesDe = 12;
                }

                // On effectue le lancer n fois par rapport au niveau du personnage
                for (int i = 0; i < drawNumber; i++)
                {
                    Random random = new Random();
                    countValueDiceDraw += random.Next(1, facesDe);
                }

                valueResult += (valueComp / 3) + countValueDiceDraw;
            }
            else
            {
                // Dans le cas où le personnage est bien niveau 1 et que sa compétence
                // est bien supérieur à 0, on lui ajoute des points.
                if (valueComp > 0)
                {
                    valueResult += (valueComp / 3);
                }
            }

            return "+" + valueResult.ToString();
        }
    }
}
