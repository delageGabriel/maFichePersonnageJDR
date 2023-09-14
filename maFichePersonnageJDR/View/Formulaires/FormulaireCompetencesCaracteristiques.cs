using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Ajout des PV et Energie
            Controller.CompetencesCaracteristiquesController.SavePVAndEnergie(IdDuPersonnage, Convert.ToInt32(nudPV.Value), Convert.ToInt32(nudEnergie.Value));
            
            // Ajout des caractéristiques
            Controller.CompetencesCaracteristiquesController.SaveCaracteristiques(IdDuPersonnage, Convert.ToInt32(nudPhysique.Value), Convert.ToInt32(nudMental.Value), 
                Convert.ToInt32(nudSocial.Value));
            
            // Ajout des compétences mentales
            Controller.CompetencesCaracteristiquesController.SaveCompetenceMentalPersonnage(idDuPersonnage, Convert.ToInt32(nudCncention.Value), Convert.ToInt32(nudConnGeographiques.Value),
                Convert.ToInt32(nudConnHistoriques.Value), Convert.ToInt32(nudMagiques.Value), Convert.ToInt32(nudConnNatures.Value), Convert.ToInt32(nudConnReligieuses.Value),
                Convert.ToInt32(nudDecryptage.Value), Convert.ToInt32(nudEsprit.Value), Convert.ToInt32(nudExplosifs.Value), Convert.ToInt32(nudMecanique.Value),
                Convert.ToInt32(nudMedecine.Value), Convert.ToInt32(nudMemoire.Value), Convert.ToInt32(nudPerception.Value), Convert.ToInt32(nudPerspicacite.Value),
                Convert.ToInt32(nudVolonte.Value));

            // Ajout des compétences physiques
            Controller.CompetencesCaracteristiquesController.SaveCompetencePhysiquePersonnage(idDuPersonnage, Convert.ToInt32(nudAgilite.Value), Convert.ToInt32(nudArtisanat.Value), 
                Convert.ToInt32(nudCrochetage.Value), Convert.ToInt32(nudDiscretion.Value), Convert.ToInt32(nudEqlibre.Value), Convert.ToInt32(nudEscalade.Value), 
                Convert.ToInt32(nudEscamotage.Value), Convert.ToInt32(nudForce.Value), Convert.ToInt32(nudNatation.Value), Convert.ToInt32(nudReflexes.Value), 
                Convert.ToInt32(nudVigueur.Value));

            // Ajout des compétences sociales
            Controller.CompetencesCaracteristiquesController.SaveCompetenceSocialPersonnage(idDuPersonnage, Convert.ToInt32(nudBaratinage.Value), Convert.ToInt32(nudCharme.Value),
                Convert.ToInt32(nudCmedie.Value), Convert.ToInt32(nudDiplomatie.Value), Convert.ToInt32(nudDressage.Value), Convert.ToInt32(nudIntimidation.Value),
                Convert.ToInt32(nudMarchandage.Value), Convert.ToInt32(nudPrestance.Value), Convert.ToInt32(nudProvocation.Value));
        }
    }
}
