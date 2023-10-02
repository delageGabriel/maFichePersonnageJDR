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
        private int idDuPersonnage;

        public int IdDuPersonnage { get => idDuPersonnage; set => idDuPersonnage = value; }
        
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
        }
    }
}
