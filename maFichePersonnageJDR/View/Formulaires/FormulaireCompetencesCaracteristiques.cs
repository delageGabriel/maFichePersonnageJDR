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
        private int compPhysique = 39;
        private int compMentale = 45;
        private int compSociale = 33;

        /// <summary>
        /// Champs des trois type de caractéristiques pour éviter les
        /// valeurs en dur
        /// </summary>
        private enum TypeComp
        {
            Physique,
            Mental,
            Social
        }

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
        private const int pointsPhysique = 5;
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

            // Ajout des PV et Energie
            Controller.CompetencesCaracteristiquesController.SavePVAndEnergie(GlobaleVariables.IdPersonnage, Convert.ToInt32(nudPV.Value), Convert.ToInt32(nudEnergie.Value));

            // Ajout des caractéristiques
            Controller.CompetencesCaracteristiquesController.SaveCaracteristiques(GlobaleVariables.IdPersonnage, Convert.ToInt32(nudPhysique.Value), Convert.ToInt32(nudMental.Value),
                Convert.ToInt32(nudSocial.Value));

            // Ajout des compétences mentales
            Controller.CompetencesCaracteristiquesController.SaveCompetenceMentalPersonnage(GlobaleVariables.IdPersonnage, Convert.ToInt32(nudCncention.Value), Convert.ToInt32(nudConnGeographiques.Value),
                Convert.ToInt32(nudConnHistoriques.Value), Convert.ToInt32(nudMagiques.Value), Convert.ToInt32(nudConnNatures.Value), Convert.ToInt32(nudConnReligieuses.Value),
                Convert.ToInt32(nudDecryptage.Value), Convert.ToInt32(nudEsprit.Value), Convert.ToInt32(nudExplosifs.Value), Convert.ToInt32(nudMecanique.Value),
                Convert.ToInt32(nudMedecine.Value), Convert.ToInt32(nudMemoire.Value), Convert.ToInt32(nudOrientation.Value), Convert.ToInt32(nudPerception.Value), 
                Convert.ToInt32(nudVolonte.Value));

            // Ajout des compétences physiques
            Controller.CompetencesCaracteristiquesController.SaveCompetencePhysiquePersonnage(GlobaleVariables.IdPersonnage, Convert.ToInt32(nudAgilite.Value), Convert.ToInt32(nudArtisanat.Value),
                Convert.ToInt32(nudCrochetage.Value), Convert.ToInt32(nudDiscretion.Value), Convert.ToInt32(nudEqlibre.Value), Convert.ToInt32(nudEquitation.Value), Convert.ToInt32(nudEscalade.Value),
                Convert.ToInt32(nudEscamotage.Value), Convert.ToInt32(nudForce.Value), Convert.ToInt32(nudFouille.Value), Convert.ToInt32(nudNatation.Value), Convert.ToInt32(nudReflexes.Value),
                Convert.ToInt32(nudVigueur.Value));

            // Ajout des compétences sociales
            Controller.CompetencesCaracteristiquesController.SaveCompetenceSocialPersonnage(GlobaleVariables.IdPersonnage, Convert.ToInt32(nudBaratinage.Value), 
                Convert.ToInt32(nudCharme.Value), Convert.ToInt32(nudCmedie.Value), Convert.ToInt32(nudCommandement.Value), Convert.ToInt32(nudDiplomatie.Value), 
                Convert.ToInt32(nudDressage.Value), Convert.ToInt32(nudIntimidation.Value), Convert.ToInt32(nudMarchandage.Value), Convert.ToInt32(nudPrestance.Value), 
                Convert.ToInt32(nudProvocation.Value), Convert.ToInt32(nudRepresentation.Value));

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
            GetPointsToRepartPvEnergieByNiveau();
            GetPointsToRepartCaracteristiquesByNiveau();
            GetMaximumForCaracteristiques();

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

            if (GlobaleVariables.IsEdit)
            {
                EditUpdateCompCarac();
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

            // Le nombre total de point que le personnage peut répartir à son niveau dans les trois
            // caractéristiques
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
            txtPntsCaracteristiques.Text = (totalPoints - ((int)nudPhysique.Value + (int)nudMental.Value + (int)nudSocial.Value)).ToString();

            /// Une fois qu'on a réparti tous les points on affiche les points pour les différentes compétences
            if (nudPhysique.Value == nudPhysique.Maximum && nudMental.Value == nudMental.Maximum && nudSocial.Value == nudSocial.Maximum)
            {
                /// Puis on met à jour les différentes textbox
                txtBxCompPhy.Text = CompPhysique.ToString();
                txtBxCompMen.Text = CompMentale.ToString();
                txtBxComSoc.Text = CompSociale.ToString();

                // On en profite pour afficher les control liés à la répartition des points de
                // compétences si le niveau du personnage est supérieur à 1
                if (Controller.PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage) > 1)
                {
                    GetNbFoisPointsRepartitions();
                    EnableOrDisableTextBoxButtonRepartitionPoints(true);
                }

                EnableNumericUpDownInGroupBox();
            }
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

            MettreAJourMaximumNumericUpDown(gbPhysique, pointsRestants);

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

            MettreAJourMaximumNumericUpDown(gbMental, pointsRestants);

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

            MettreAJourMaximumNumericUpDown(gbSocial, pointsRestants);

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
            foreach (NumericUpDown nud in groupBox.Controls.OfType<NumericUpDown>())
            {
                nud.Maximum = pointsRestants == 0 ? nud.Value : 15;
            }
        }

        /// <summary>
        /// Événement qui permet de mettre à jour chaque TextBox affiliée aux compétences
        /// </summary>
        /// <param name="nbPointsAAjouter"></param>
        /// <param name="compAAjouter"></param>
        private void MettreAJourPointsTotal(int nbPointsAAjouter, TypeComp typeCompetence)
        {
            GroupBox groupBox = new GroupBox();
            int compAdd = 0;

            // On vérifie d'abord qu'on a bien une valeur correct
            if (nbPointsAAjouter <= 0)
            {
                Console.WriteLine("Paramètres invalides");
                return;
            }
            
            /**
             * - PHYSIQUE
             * - SOCIALE
             * - MENTALE
             */
            if (typeCompetence.Equals(TypeComp.Physique))
            {
                // On met à jour le nombre de points dans la compétence physique
                if (competencesMiseAJour.TryGetValue("Physique", out Action<int> miseAJourAction))
                {
                    miseAJourAction(nbPointsAAjouter);
                }

                groupBox = gbPhysique;
                compAdd = CompPhysique;

                // Mise à jour de l'affichage du nombre de points total
                txtBxCompPhy.Text = (CompPhysique - CalculerSommeValeursNumericUpDown(gbPhysique)).ToString();
            }
            else if (typeCompetence.Equals(TypeComp.Social))
            {
                // On met à jour le nombre de points dans la compétence mental
                if (competencesMiseAJour.TryGetValue("Social", out Action<int> miseAJourAction))
                {
                    miseAJourAction(nbPointsAAjouter);
                }

                groupBox = gbSocial;
                compAdd = CompSociale;

                // Mise à jour de l'affichage du nombre de points total
                txtBxComSoc.Text = (CompSociale - CalculerSommeValeursNumericUpDown(gbSocial)).ToString();
            }
            else if (typeCompetence.Equals(TypeComp.Mental))
            {
                // On met à jour le nombre de points dans la compétence mental
                if (competencesMiseAJour.TryGetValue("Mental", out Action<int> miseAJourAction))
                {
                    miseAJourAction(nbPointsAAjouter);
                }

                groupBox = gbMental;
                compAdd = CompMentale;

                // Mise à jour de l'affichage du nombre de points total
                txtBxCompMen.Text = (CompMentale - CalculerSommeValeursNumericUpDown(gbMental)).ToString();
            }
            else
            {
                Console.WriteLine("Compétence non reconnue");
            }

            MettreAJourMaximumNumericUpDown(groupBox, compAdd);
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
            MettreAJourPointsTotal(PointsPhysique, TypeComp.Physique);
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
            MettreAJourPointsTotal(PointsMental, TypeComp.Mental);
            GetNbFoisPointsRepartitions(true);
        }

        private void btnAddPtsSoc_Click(object sender, EventArgs e)
        {
            MettreAJourPointsTotal(PointsSocial, TypeComp.Social);
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

            if (niveauDuPersonnage < 3)
            {
                MaximumCaracteristiquesDefaut = 55;
            }
            else if (niveauDuPersonnage > 3 && niveauDuPersonnage < 9)
            {
                MaximumCaracteristiquesDefaut = 60;
            }
            else if (niveauDuPersonnage > 9 && niveauDuPersonnage < 12)
            {
                MaximumCaracteristiquesDefaut = 65;
            }
            else if (niveauDuPersonnage > 12 && niveauDuPersonnage < 18)
            {
                MaximumCaracteristiquesDefaut = 70;
            }
            else
            {
                MaximumCaracteristiquesDefaut = 75;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void EnableNumericUpDownInGroupBox()
        {
            foreach (Control control in gbPhysique.Controls)
            {
                if (control is NumericUpDown)
                {
                    NumericUpDown numeric = control as NumericUpDown;
                    numeric.Enabled = true;
                }
            }

            foreach (Control control in gbMental.Controls)
            {
                if (control is NumericUpDown)
                {
                    NumericUpDown numeric = control as NumericUpDown;
                    numeric.Enabled = true;
                }
            }

            foreach (Control control in gbSocial.Controls)
            {
                if (control is NumericUpDown)
                {
                    NumericUpDown numeric = control as NumericUpDown;
                    numeric.Enabled = true;
                }
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
            /**
             * PV ET ENERGIE
             */
            nudPV.Value = Controller.CompetencesCaracteristiquesController.GetValuePvEnergie("pv", "nombre_points_pv", GlobaleVariables.IdPersonnage);
            nudEnergie.Value = Controller.CompetencesCaracteristiquesController.GetValuePvEnergie("energie", "nombre_points_energie", GlobaleVariables.IdPersonnage);

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
            nudDecryptage.Value = Controller.CompetencesCaracteristiquesController.GetValueCompetence("Mental", "decryptage", GlobaleVariables.IdPersonnage);
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
                    }
                }
            }
            else
            {
                GlobaleVariables.IsClosedProgrammatically = false;
            }
        }
    }
}
