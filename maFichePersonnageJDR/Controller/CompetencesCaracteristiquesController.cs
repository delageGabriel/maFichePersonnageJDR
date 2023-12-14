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
        public static void SaveCompetenceMentalPersonnage(int idPersonnage, int concentration, int connGeo, int connHis, int connMag, int connNat, int connRel,
            int esprit, int explosifs, int mecanique, int medecine, int memoire, int orientation, int perception, int volonte)
        {
            Console.WriteLine(string.Format("########### Méthode SaveCompetenceMentalPersonnage — Personnage créé : idPersonnage : {0} ###########", idPersonnage.ToString()));

            CompetenceMentalPersonnageModel competenceMental = new CompetenceMentalPersonnageModel();

            try
            {
                // On envoie les informations du personnage à sauvegarder
                competenceMental.SaveCompetenceMentalPersonnage(idPersonnage, concentration, connGeo, connHis, connMag, connNat, connRel, esprit, explosifs, mecanique,
                    medecine, memoire, orientation, perception, volonte);
            }
            catch (Exception e)
            {
                throw;
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
        public static void SaveCompetencePhysiquePersonnage(int idPersonnage, int agilite, int artisanat, int crochetage, int discretion, int equilibre, int equitation, 
            int escalade, int escamotage, int force, int fouille, int lutte, int natation, int reflexes, int vigueur)
        {
            Console.WriteLine(string.Format("########### Méthode SaveCompetencePhysiquePersonnage — Personnage créé : idPersonnage : {0} ###########", idPersonnage.ToString()));

            CompetencePhysiquePersonnageModel competencePhysique = new CompetencePhysiquePersonnageModel();

            try
            {
                competencePhysique.SaveCompetencePhysiquePersonnage(idPersonnage, agilite, artisanat, crochetage, discretion, equilibre, equitation,
                    escalade, escamotage, force, fouille, lutte, natation, reflexes, vigueur);
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
        public static void SaveCompetenceSocialPersonnage(int idPersonnage, int baratinage, int charme, int comedie, int commandement, int diplomatie, int dressage, 
            int intimidation, int marchandage, int prestance, int provocation, int representation)
        {
            Console.WriteLine(string.Format("########### Méthode SaveCompetenceSocialPersonnage — Personnage créé : idPersonnage : {0} ###########", idPersonnage.ToString()));

            CompetenceSocialPersonnageModel competenceSocial = new CompetenceSocialPersonnageModel();

            try
            {
                competenceSocial.SaveCompetenceSocialPersonnage(idPersonnage, baratinage, charme, comedie, commandement, diplomatie, dressage, intimidation, 
                    marchandage, prestance, provocation, representation);
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
        public static void SavePVAndEnergie(int idPersonnage, string nombreEnergie, string nombrePV)
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

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return PointsCaracteristiquesPersonnageModel.GetBaseCaracteristiques(idPersonnage).NombrePhysique;
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

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return PointsCaracteristiquesPersonnageModel.GetBaseCaracteristiques(idPersonnage).NombreMental;
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

            try
            {
                // On envoie les informations du personnage à sauvegarder
                return PointsCaracteristiquesPersonnageModel.GetBaseCaracteristiques(idPersonnage).NombreSocial;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Permet d'obtenir les compétences de base du personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public static int[] GetBaseCompetencePhysique(int idPersonnage)
        {
            #region Initialisation des variables
            CompetencePhysiquePersonnageModel competencePhysiquePersonnageModel = new CompetencePhysiquePersonnageModel();
            #endregion

            Console.WriteLine(string.Format("########### Méthode GetBaseCompetencePhysique — Personnage recherchée : ID : {0} ###########", idPersonnage));

            try
            {
                competencePhysiquePersonnageModel = competencePhysiquePersonnageModel.GetBasePhysiquePersonnage(idPersonnage);
                int[] listBaseCompPhy = {
                    competencePhysiquePersonnageModel.Agilite, competencePhysiquePersonnageModel.Artisanat, 
                    competencePhysiquePersonnageModel.Crochetage, competencePhysiquePersonnageModel.Discretion, competencePhysiquePersonnageModel.Equilibre, 
                    competencePhysiquePersonnageModel.Equitation, competencePhysiquePersonnageModel.Escalade, competencePhysiquePersonnageModel.Escamotage,
                    competencePhysiquePersonnageModel.Force, competencePhysiquePersonnageModel.Fouille, competencePhysiquePersonnageModel.Lutte,
                    competencePhysiquePersonnageModel.Natation, competencePhysiquePersonnageModel.Reflexes, competencePhysiquePersonnageModel.Vigueur};

                return listBaseCompPhy;
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
        /// <returns></returns>
        public static int[] GetBaseCompetenceMental(int idPersonnage)
        {
            #region Initialisation des variables
            CompetenceMentalPersonnageModel competenceMentalPersonnageModel = new CompetenceMentalPersonnageModel();
            #endregion

            Console.WriteLine(string.Format("########### Méthode GetBaseCompetenceMental — Personnage recherchée : ID : {0} ###########", idPersonnage));

            try
            {
                competenceMentalPersonnageModel = competenceMentalPersonnageModel.GetBaseMentalPersonnage(idPersonnage);
                int[] listBaseCompMen = {
                    competenceMentalPersonnageModel.Concentration, competenceMentalPersonnageModel.ConnaissanceGeographiques, 
                    competenceMentalPersonnageModel.ConnaissanceHistoriques, competenceMentalPersonnageModel.ConnaissanceMagiques, 
                    competenceMentalPersonnageModel.ConnaissanceNatures, competenceMentalPersonnageModel.ConnaissanceReligieuses,
                    competenceMentalPersonnageModel.Esprit, competenceMentalPersonnageModel.Explosifs, competenceMentalPersonnageModel.Mecanique, 
                    competenceMentalPersonnageModel.Medecine, competenceMentalPersonnageModel.Memoire, competenceMentalPersonnageModel.Orientation, 
                    competenceMentalPersonnageModel.Perception, competenceMentalPersonnageModel.Volonte};

                return listBaseCompMen;
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
        /// <returns></returns>
        public static int[] GetBaseCompetenceSocial(int idPersonnage)
        {
            #region Initialisation des variables
            CompetenceSocialPersonnageModel competenceSocialPersonnageModel = new CompetenceSocialPersonnageModel();
            #endregion

            Console.WriteLine(string.Format("########### Méthode GetBaseCompetenceSocial — Personnage recherchée : ID : {0} ###########", idPersonnage));

            try
            {
                competenceSocialPersonnageModel = competenceSocialPersonnageModel.GetBaseSocialPersonnage(idPersonnage);
                int[] listBaseCompSoc = {
                    competenceSocialPersonnageModel.Baratinage, competenceSocialPersonnageModel.Charme, competenceSocialPersonnageModel.Comedie, 
                    competenceSocialPersonnageModel.Commandement, competenceSocialPersonnageModel.Diplomatie, competenceSocialPersonnageModel.Dressage,
                    competenceSocialPersonnageModel.Intimidation, competenceSocialPersonnageModel.Marchandage, competenceSocialPersonnageModel.Prestance,
                    competenceSocialPersonnageModel.Provocation, competenceSocialPersonnageModel.Representation};

                return listBaseCompSoc;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Permet de savoir combien de points le personnage a à répartir grâce à son niveau
        /// </summary>
        /// <param name="niveauPersonnage"></param>
        /// <returns></returns>
        public static int GetPointPvEnergieRepartition(int niveauPersonnage)
        {
            PointsPVEnergieModel pointsPVEnergie = new PointsPVEnergieModel();

            Console.WriteLine(string.Format("########### Méthode GetPointPvEnergieRepartition — Personnage recherchée : niveau : {0} ###########", niveauPersonnage));

            try
            {
                return pointsPVEnergie.GetPointsByNiveau(niveauPersonnage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Permet de savoir combien de points le personnage a à répartir grâce à son niveau
        /// </summary>
        /// <param name="niveauPersonnage"></param>
        /// <returns></returns>
        public static int GetPointCaracteristiquesRepartition(int niveauPersonnage)
        {
            PointsCaracteristiquesModel pointsCaracteristiques = new PointsCaracteristiquesModel();

            Console.WriteLine(string.Format("########### Méthode GetPointCaracteristiquesRepartition — Personnage recherchée : niveau : {0} ###########", niveauPersonnage));

            try
            {
                return pointsCaracteristiques.GetPointsCaracteristiquesByNiveau(niveauPersonnage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int GetForcePersonnage(int idPersonnage)
        {
            CompetencePhysiquePersonnageModel competencePhysiquePersonnage = new CompetencePhysiquePersonnageModel();

            Console.WriteLine(string.Format("########### Méthode GetForcePersonnage — Personnage recherchée : niveau : {0} ###########", idPersonnage));

            try
            {
                return competencePhysiquePersonnage.GetForcePersonnage(idPersonnage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int GetValueCompetence(string typeCompetence, string nomCompetence, int idPersonnage)
        {
            int defautValue = 0;

            if (typeCompetence == "Physique")
            {
                return CompetencePhysiquePersonnageModel.GetValueCompetencePhysique(nomCompetence, idPersonnage);
            }
            else if (typeCompetence == "Mental")
            {
                return CompetenceMentalPersonnageModel.GetValueCompetenceMental(nomCompetence, idPersonnage);
            }
            else if (typeCompetence == "Social")
            {
                return CompetenceSocialPersonnageModel.GetValueCompetenceSocial(nomCompetence, idPersonnage);
            }
            else
            {
                return defautValue;
            }
        }

        public static string GetValuePvEnergie(string pvOrEnergie, string nomColonne, int idPersonnage)
        {
            string defautValue = "0";

            if (pvOrEnergie == "pv")
            {
                return PointsPVEnergiePersonnageModel.GetValuePVEnergie(nomColonne, idPersonnage);
            }
            else if (pvOrEnergie == "energie")
            {
                return PointsPVEnergiePersonnageModel.GetValuePVEnergie(nomColonne, idPersonnage);
            }
            else
            {
                return defautValue;
            }
        }
    }
}
