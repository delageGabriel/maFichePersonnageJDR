using maFichePersonnageJDR.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Controller
{
    class CompetencesCaracteristiquesController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <param name="concentration"></param>
        /// <param name="connGeo"></param>
        /// <param name="connHis"></param>
        /// <param name="connMag"></param>
        /// <param name="connNat"></param>
        /// <param name="connRel"></param>
        /// <param name="decryptage"></param>
        /// <param name="esprit"></param>
        /// <param name="explosifs"></param>
        /// <param name="mecanique"></param>
        /// <param name="medecine"></param>
        /// <param name="memoire"></param>
        /// <param name="perception"></param>
        /// <param name="perspicacite"></param>
        /// <param name="volonte"></param>
        public static void SaveCompetenceMentalPersonnage(int idPersonnage, int concentration, int connGeo, int connHis, int connMag, int connNat, int connRel, int decryptage,
            int esprit, int explosifs, int mecanique, int medecine, int memoire, int perception, int volonte)
        {
            Console.WriteLine(string.Format("########### Méthode SaveCompetenceMentalPersonnage — Personnage créé : idPersonnage : {0} ###########", idPersonnage.ToString()));

            CompetenceMentalPersonnageModel competenceMental = new CompetenceMentalPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                competenceMental.SaveCompetenceMentalPersonnage(idPersonnage, concentration, connGeo, connHis, connMag, connNat, connRel, decryptage, esprit, explosifs, mecanique,
                    medecine, memoire, perception, volonte);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <param name="agilite"></param>
        /// <param name="artisanat"></param>
        /// <param name="crochetage"></param>
        /// <param name="discretion"></param>
        /// <param name="equilibre"></param>
        /// <param name="escalade"></param>
        /// <param name="escamotage"></param>
        /// <param name="force"></param>
        /// <param name="natation"></param>
        /// <param name="reflexes"></param>
        /// <param name="vigueur"></param>
        public static void SaveCompetencePhysiquePersonnage(int idPersonnage, int agilite, int artisanat, int crochetage, int discretion, int equilibre, int escalade, 
            int escamotage, int force, int fouille, int natation, int reflexes, int vigueur)
        {
            Console.WriteLine(string.Format("########### Méthode SaveCompetencePhysiquePersonnage — Personnage créé : idPersonnage : {0} ###########", idPersonnage.ToString()));

            CompetencePhysiquePersonnageModel competencePhysique = new CompetencePhysiquePersonnageModel();

            try
            {
                competencePhysique.SaveCompetencePhysiquePersonnage(idPersonnage, agilite, artisanat, crochetage, discretion, equilibre, 
                    escalade, escamotage, force, fouille, natation, reflexes, vigueur);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <param name="baratinage"></param>
        /// <param name="charme"></param>
        /// <param name="comedie"></param>
        /// <param name="diplomatie"></param>
        /// <param name="dressage"></param>
        /// <param name="intimidation"></param>
        /// <param name="marchandage"></param>
        /// <param name="prestance"></param>
        /// <param name="provocation"></param>
        public static void SaveCompetenceSocialPersonnage(int idPersonnage, int baratinage, int charme, int comedie, int diplomatie, int dressage, int intimidation, int marchandage,
            int prestance, int provocation)
        {
            Console.WriteLine(string.Format("########### Méthode SaveCompetencePhysiquePersonnage — Personnage créé : idPersonnage : {0} ###########", idPersonnage.ToString()));

            CompetenceSocialPersonnageModel competenceSocial = new CompetenceSocialPersonnageModel();

            try
            {
                competenceSocial.SaveCompetenceSocialPersonnage(idPersonnage, baratinage, charme, comedie, diplomatie, dressage, intimidation, marchandage, prestance, provocation);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <param name="nombrePV"></param>
        /// <param name="nombreEnergie"></param>
        public static void SaveCaracteristiques(int idPersonnage, int nombrePhysique, int nombreMental, int nombreSocial)
        {
            Console.WriteLine(string.Format("########### Méthode SaveCaracteristiques — Personnage créé : idPersonnage : {0} ###########", idPersonnage.ToString()));

            PointsCaracteristiquesPersonnageModel caracteristiquesPersonnageModel = new PointsCaracteristiquesPersonnageModel();

            try
            {
                caracteristiquesPersonnageModel.SaveCaracteristiquesPersonnage(idPersonnage, nombrePhysique, nombreMental, nombreSocial);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <param name="nombreEnergie"></param>
        /// <param name="nombrePV"></param>
        public static void SavePVAndEnergie(int idPersonnage, int nombreEnergie, int nombrePV)
        {
            Console.WriteLine(string.Format("########### Méthode SavePVAndEnergie — Personnage créé : idPersonnage : {0} ###########", idPersonnage.ToString()));

            PointsPVEnergiePersonnageModel pointsPVEnergiePersonnageModel = new PointsPVEnergiePersonnageModel();

            try
            {
                pointsPVEnergiePersonnageModel.SavePVEnergiePersonnage(idPersonnage, nombreEnergie, nombrePV);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne les points en physique du personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static int GetPhysiquePersonnage(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetPhysiquePersonnage — Personnage recherchée : ID : {0} ###########", idPersonnage));

            PointsCaracteristiquesPersonnageModel pointsCaracteristiquesPersonnage = new PointsCaracteristiquesPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return pointsCaracteristiquesPersonnage.GetBaseCaracteristiques(idPersonnage).NombrePhysique;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne les points en mental du personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static int GetMentalPersonnage(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetMentalPersonnage — Personnage recherchée : ID : {0} ###########", idPersonnage));

            PointsCaracteristiquesPersonnageModel pointsCaracteristiquesPersonnage = new PointsCaracteristiquesPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return pointsCaracteristiquesPersonnage.GetBaseCaracteristiques(idPersonnage).NombreMental;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Retourne les points en mental du personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static int GetSocialPersonnage(int idPersonnage)
        {
            Console.WriteLine(string.Format("########### Méthode GetSocialPersonnage — Personnage recherchée : ID : {0} ###########", idPersonnage));

            PointsCaracteristiquesPersonnageModel pointsCaracteristiquesPersonnage = new PointsCaracteristiquesPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return pointsCaracteristiquesPersonnage.GetBaseCaracteristiques(idPersonnage).NombreSocial;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static int[] GetBaseCompetencePhysique(int idPersonnage)
        {
            #region Initialisation des variables
            CompetencePhysiquePersonnageModel competencePhysiquePersonnageModel = new CompetencePhysiquePersonnageModel();
            #endregion

            Console.WriteLine(string.Format("########### Méthode GetBaseCompetencePhysique — Personnage recherchée : ID : {0} ###########", idPersonnage));

            try
            {
                competencePhysiquePersonnageModel = competencePhysiquePersonnageModel.GetBasePhysiquePersonnage(idPersonnage);
                int[] listBaseCompPhy = {competencePhysiquePersonnageModel.Agilite, competencePhysiquePersonnageModel.Artisanat, competencePhysiquePersonnageModel.Crochetage,
                competencePhysiquePersonnageModel.Discretion, competencePhysiquePersonnageModel.Equilibre, competencePhysiquePersonnageModel.Escalade, competencePhysiquePersonnageModel.Escamotage,
                competencePhysiquePersonnageModel.Force, competencePhysiquePersonnageModel.Fouille, competencePhysiquePersonnageModel.Natation, competencePhysiquePersonnageModel.Reflexes,
                competencePhysiquePersonnageModel.Vigueur};

                return listBaseCompPhy;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
