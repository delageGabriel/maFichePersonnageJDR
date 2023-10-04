using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maFichePersonnageJDR.Formulaires;

namespace maFichePersonnageJDR.View.Formulaires
{
    public partial class FormulaireCompetencesCaracteristiques : Form
    {
        /// <summary>
        /// Champs
        /// </summary>
        private int idDuPersonnage;
        private int compPhysique;
        private int compMentale;
        private int compSociale;
        private string nbFoisPointsMiseAJour;

        /// <summary>
        /// Accesseurs et Mutateurs
        /// </summary>
        public int IdDuPersonnage { get => idDuPersonnage; set => idDuPersonnage = value; }
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

        /// <summary>
        /// Méthodes
        /// </summary>
        public FormulaireCompetencesCaracteristiques()
        {
            InitializeComponent();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            FormulaireEquipments formulaireEquipments = new FormulaireEquipments();

            // Ajout des PV et Energie
            Controller.CompetencesCaracteristiquesController.SavePVAndEnergie(IdDuPersonnage, Convert.ToInt32(nudPV.Value), Convert.ToInt32(nudEnergie.Value));

            // Ajout des caractéristiques
            Controller.CompetencesCaracteristiquesController.SaveCaracteristiques(IdDuPersonnage, Convert.ToInt32(nudPhysique.Value), Convert.ToInt32(nudMental.Value),
                Convert.ToInt32(nudSocial.Value));

            // Ajout des compétences mentales
            Controller.CompetencesCaracteristiquesController.SaveCompetenceMentalPersonnage(idDuPersonnage, Convert.ToInt32(nudCncention.Value), Convert.ToInt32(nudConnGeographiques.Value),
                Convert.ToInt32(nudConnHistoriques.Value), Convert.ToInt32(nudMagiques.Value), Convert.ToInt32(nudConnNatures.Value), Convert.ToInt32(nudConnReligieuses.Value),
                Convert.ToInt32(nudDecryptage.Value), Convert.ToInt32(nudEsprit.Value), Convert.ToInt32(nudExplosifs.Value), Convert.ToInt32(nudMecanique.Value),
                Convert.ToInt32(nudMedecine.Value), Convert.ToInt32(nudMemoire.Value), Convert.ToInt32(nudPerception.Value), Convert.ToInt32(nudVolonte.Value));

            // Ajout des compétences physiques
            Controller.CompetencesCaracteristiquesController.SaveCompetencePhysiquePersonnage(idDuPersonnage, Convert.ToInt32(nudAgilite.Value), Convert.ToInt32(nudArtisanat.Value),
                Convert.ToInt32(nudCrochetage.Value), Convert.ToInt32(nudDiscretion.Value), Convert.ToInt32(nudEqlibre.Value), Convert.ToInt32(nudEscalade.Value),
                Convert.ToInt32(nudEscamotage.Value), Convert.ToInt32(nudForce.Value), Convert.ToInt32(nudFouille.Value), Convert.ToInt32(nudNatation.Value), Convert.ToInt32(nudReflexes.Value),
                Convert.ToInt32(nudVigueur.Value));

            // Ajout des compétences sociales
            Controller.CompetencesCaracteristiquesController.SaveCompetenceSocialPersonnage(idDuPersonnage, Convert.ToInt32(nudBaratinage.Value), Convert.ToInt32(nudCharme.Value),
                Convert.ToInt32(nudCmedie.Value), Convert.ToInt32(nudDiplomatie.Value), Convert.ToInt32(nudDressage.Value), Convert.ToInt32(nudIntimidation.Value),
                Convert.ToInt32(nudMarchandage.Value), Convert.ToInt32(nudPrestance.Value), Convert.ToInt32(nudProvocation.Value));

            formulaireEquipments.IdPersonnage = IdDuPersonnage;
            MessageBox.Show("Compétences et caractéristiques sauvegardées");

            formulaireEquipments.Show();
            this.Close();
        }

        /// <summary>
        /// Permet d'obtenir le nombre de points à répartir entre les pv et l'énergie
        /// </summary>
        public void GetPointsToRepartPvEnergieByNiveau()
        {
            txtPntsPVEnergie.Text = Controller.CompetencesCaracteristiquesController.GetPointPvEnergieRepartition(Controller.PersonnageController.GetNiveauPersonnage(IdDuPersonnage)).ToString();
        }

        /// <summary>
        /// Permet d'obtenir le nombre de points à répartir entre les trois
        /// caractéristiques
        /// </summary>
        public void GetPointsToRepartCaracteristiquesByNiveau()
        {
            txtPntsCaracteristiques.Text = Controller.CompetencesCaracteristiquesController.GetPointCaracteristiquesRepartition(Controller.PersonnageController.GetNiveauPersonnage(IdDuPersonnage)).ToString();
        }

        private void FormulaireCompetencesCaracteristiques_Load(object sender, EventArgs e)
        {
            GetPointsToRepartPvEnergieByNiveau();
            GetPointsToRepartCaracteristiquesByNiveau();
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
            int totalPoints = Controller.CompetencesCaracteristiquesController.GetPointPvEnergieRepartition(Controller.PersonnageController.GetNiveauPersonnage(IdDuPersonnage));

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
            int pointsPhy = (int)nudPhysique.Value;
            int pointsMen = (int)nudMental.Value;
            int pointsSoc = (int)nudSocial.Value;

            int totalPoints = Controller.CompetencesCaracteristiquesController.GetPointCaracteristiquesRepartition(Controller.PersonnageController.GetNiveauPersonnage(IdDuPersonnage));

            int pointsRestantsPhy = totalPoints - (pointsMen + pointsSoc);
            int pointsRestantsMen = totalPoints - (pointsPhy + pointsSoc);
            int pointsRestantsSoc = totalPoints - (pointsMen + pointsPhy);

            nudPhysique.Maximum = pointsRestantsPhy;
            nudMental.Maximum = pointsRestantsMen;
            nudSocial.Maximum = pointsRestantsSoc;

            txtPntsCaracteristiques.Text = (totalPoints - ((int)nudPhysique.Value + (int)nudMental.Value + (int)nudSocial.Value)).ToString();

            if (nudPhysique.Value == nudPhysique.Maximum && nudMental.Value == nudMental.Maximum && nudSocial.Value == nudSocial.Maximum)
            {
                int dizainePhys = pointsPhy / 10; // Récupérer la dizaine
                int dizaineMent = pointsMen / 10;
                int dizaineSoc = pointsSoc / 10;

                int pointsPhys = dizainePhys + 36; // Ajouter la dizaine aux points correspondants
                int pointsMent = dizaineMent + 42;
                int pointsSoci = dizaineSoc + 22;

                /// On attribue aux propriétés leurs nouveaux points
                CompPhysique = pointsPhys;
                CompMentale = pointsMent;
                CompSociale = pointsSoci;

                /// Puis on met à jour les différentes textbox
                txtBxCompPhy.Text = CompPhysique.ToString();
                txtBxCompMen.Text = CompMentale.ToString();
                txtBxComSoc.Text = CompSociale.ToString();

                // On en profite pour afficher les control liés à la répartition des points de
                // compétences si le niveau du personnage est supérieur à 1
                if (Controller.PersonnageController.GetNiveauPersonnage(IdDuPersonnage) > 1)
                {
                    GetNbFoisPointsRepartitions();
                    EnableOrDisableTextBoxButtonRepartitionPoints(true);
                }
            }
        }

        /// <summary>
        /// Événement qui gère la répartition des points de compétences physique à répartir ainsi que leur maximum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudCompPhy_ValueChanged(object sender, EventArgs e)
        {
            /// On commence par récupérer les valeurs de chaque NumericUpDown
            int agilite = (int)nudAgilite.Value;
            int artisanat = (int)nudArtisanat.Value;
            int crochetage = (int)nudCrochetage.Value;
            int discretion = (int)nudDiscretion.Value;
            int equilibre = (int)nudEqlibre.Value;
            int escalade = (int)nudEscalade.Value;
            int escamotage = (int)nudEscamotage.Value;
            int force = (int)nudForce.Value;
            int fouille = (int)nudFouille.Value;
            int natation = (int)nudNatation.Value;
            int reflexes = (int)nudReflexes.Value;
            int vigueur = (int)nudVigueur.Value;

            // Le nombre de point total à répartir
            int totalPoints = CompPhysique;

            // Les points qu'il reste à répartir
            int pointsRestants = totalPoints - (agilite + artisanat + crochetage + discretion + equilibre + escalade + escamotage + force + fouille + natation +
                reflexes + vigueur);

            /// On vérifie s'il reste des points à attribuer, si ce n'est pas le cas
            /// on pose le maximum de chaque NumericUpDown par rapport à sa valeur
            /// Sinon le maximum = 15
            if (pointsRestants == 0)
            {
                foreach (Control control in gbPhysique.Controls)
                {
                    if (control is NumericUpDown)
                    {
                        NumericUpDown numeric = control as NumericUpDown;
                        numeric.Maximum = numeric.Value;
                    }
                }
            }
            else
            {
                foreach (Control control in gbPhysique.Controls)
                {
                    if (control is NumericUpDown)
                    {
                        NumericUpDown numeric = control as NumericUpDown;
                        numeric.Maximum = 15;
                    }
                }
            }

            // Et ensuite on met à jour la TextBox des points à répartir
            txtBxCompPhy.Text = pointsRestants.ToString();
        }

        private void nudCompMen_ValueChanged(object sender, EventArgs e)
        {
            int concentration = (int)nudCncention.Value;
            int connGeo = (int)nudConnGeographiques.Value;
            int connHis = (int)nudConnHistoriques.Value;
            int connMag = (int)nudMagiques.Value;
            int connNat = (int)nudConnNatures.Value;
            int connRel = (int)nudConnReligieuses.Value;
            int decryptage = (int)nudDecryptage.Value;
            int esprit = (int)nudEsprit.Value;
            int explosifs = (int)nudExplosifs.Value;
            int mecanique = (int)nudMecanique.Value;
            int medecine = (int)nudMedecine.Value;
            int memoire = (int)nudMemoire.Value;
            int perception = (int)nudPerception.Value;
            int volonte = (int)nudVolonte.Value;

            int totalPoints = CompMentale;

            int pointsRestants = totalPoints - (concentration + connGeo + connHis + connMag + connNat + connRel + decryptage + esprit + explosifs + mecanique +
                medecine + memoire + perception + volonte);

            /// On vérifie s'il reste des points à attribuer, si ce n'est pas le cas
            /// on pose le maximum de chaque NumericUpDown par rapport à sa valeur
            /// Sinon le maximum = 15
            if (pointsRestants == 0)
            {
                foreach (Control control in gbMental.Controls)
                {
                    if (control is NumericUpDown)
                    {
                        NumericUpDown numeric = control as NumericUpDown;
                        numeric.Maximum = numeric.Value;
                    }
                }
            }
            else
            {
                foreach (Control control in gbMental.Controls)
                {
                    if (control is NumericUpDown)
                    {
                        NumericUpDown numeric = control as NumericUpDown;
                        numeric.Maximum = 15;
                    }
                }
            }

            txtBxCompMen.Text = pointsRestants.ToString();
        }

        private void nudCompSoc_ValueChanged(object sender, EventArgs e)
        {
            int baratinage = (int)nudBaratinage.Value;
            int charme = (int)nudCharme.Value;
            int comedie = (int)nudCmedie.Value;
            int diplomatie = (int)nudDiplomatie.Value;
            int dressage = (int)nudDressage.Value;
            int intimidation = (int)nudIntimidation.Value;
            int marchandage = (int)nudMarchandage.Value;
            int prestance = (int)nudPrestance.Value;
            int provocation = (int)nudProvocation.Value;

            int totalPoints = CompSociale;

            int pointsRestants = totalPoints - (baratinage + charme + comedie + diplomatie + dressage + intimidation + marchandage + prestance + provocation);

            /// On vérifie s'il reste des points à attribuer, si ce n'est pas le cas
            /// on pose le maximum de chaque NumericUpDown par rapport à sa valeur
            /// Sinon le maximum = 15
            if (pointsRestants == 0)
            {
                foreach (Control control in gbSocial.Controls)
                {
                    if (control is NumericUpDown)
                    {
                        NumericUpDown numeric = control as NumericUpDown;
                        numeric.Maximum = numeric.Value;
                    }
                }
            }
            else
            {
                foreach (Control control in gbSocial.Controls)
                {
                    if (control is NumericUpDown)
                    {
                        NumericUpDown numeric = control as NumericUpDown;
                        numeric.Maximum = 15;
                    }
                }
            }

            txtBxComSoc.Text = pointsRestants.ToString();
        }

        /// <summary>
        /// Événement qui permet de mettre à jour chaque TextBox affiliée aux compétences
        /// </summary>
        /// <param name="nbPointsAAjouter"></param>
        /// <param name="compAAjouter"></param>
        private void MettreAJourPointsTotal(int nbPointsAAjouter, string compAAjouter)
        {
            /// Si nos paramètres ne sont pas vide, on cherche à rajouter les points de compétences supplémentaires
            if (nbPointsAAjouter > 0 && !String.IsNullOrEmpty(compAAjouter))
            {
                switch (compAAjouter)
                {
                    case "Physique":
                        CompPhysique += nbPointsAAjouter;
                        txtBxCompPhy.Text = CompPhysique.ToString();
                        break;
                    case "Mental":
                        CompMentale += nbPointsAAjouter;
                        txtBxCompMen.Text = CompMentale.ToString();
                        break;
                    case "Social":
                        CompSociale += nbPointsAAjouter;
                        txtBxComSoc.Text = CompSociale.ToString();
                        break;
                    default:
                        Console.WriteLine("Aucune des trois propositions");
                        break;
                }
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
                NbFoisPointsMiseAJour = subsplit[0] + ": " + (Controller.PersonnageController.GetNiveauPersonnage(IdDuPersonnage) - 1).ToString();
            }

            lblNbRepartitionComp.Text = NbFoisPointsMiseAJour;
        }

        private void btnAddPtsPhy_Click(object sender, EventArgs e)
        {
            MettreAJourPointsTotal(4, "Physique");
            GetNbFoisPointsRepartitions(true);
        }

        private void btnAddPtsMen_Click(object sender, EventArgs e)
        {
            MettreAJourPointsTotal(6, "Mental");
            GetNbFoisPointsRepartitions(true);
        }

        private void btnAddPtsSoc_Click(object sender, EventArgs e)
        {
            MettreAJourPointsTotal(3, "Social");
            GetNbFoisPointsRepartitions(true);
        }

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
    }
}
