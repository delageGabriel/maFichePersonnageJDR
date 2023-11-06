using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using maFichePersonnageJDR.Controller;

namespace maFichePersonnageJDR.Classe
{
    class ClasseHtml
    {
        private int idPersonnage;

        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }

        public void CreatePersonnageHtml()
        {
            #region Initialisation des variables
            string prenomPersonnage = PersonnageController.GetPrenomPersonnage(IdPersonnage);
            string nomPersonnage = PersonnageController.GetNomPersonnage(IdPersonnage);
            string racePersonnage = PersonnageController.GetRacePersonnage(IdPersonnage);
            int niveauPersonnage = PersonnageController.GetNiveauPersonnage(IdPersonnage);
            string sexePersonnage = PersonnageController.GetSexePersonnage(IdPersonnage);
            int experiencePersonnage = PersonnageController.GetExperiencePersonnage(IdPersonnage);
            short[] dexteriteCaracteristiques = {
                Utils.GetDizaineInteger(CompetencesCaracteristiquesController.GetPhysiquePersonnage(IdPersonnage)),
                Utils.GetDizaineInteger(CompetencesCaracteristiquesController.GetMentalPersonnage(IdPersonnage)),
                Utils.GetDizaineInteger(CompetencesCaracteristiquesController.GetSocialPersonnage(IdPersonnage))
            };
            string htmlTableAttributs = AddAttributesHtml(IdPersonnage);
            string htmlTableCompPhy = AddCompPhysiqueHtml(IdPersonnage, CompetencesCaracteristiquesController.GetPhysiquePersonnage(IdPersonnage));
            string htmlTableCompMen = AddCompMentalHtml(IdPersonnage, CompetencesCaracteristiquesController.GetMentalPersonnage(IdPersonnage));
            string htmlTableCompSoc = AddCompSocialHtml(IdPersonnage, CompetencesCaracteristiquesController.GetSocialPersonnage(IdPersonnage));
            string htmlTableArmePersonnage = AddArmesPersonnage(IdPersonnage);
            string htmlTableArmurePersonnage = AddArmuresPersonnage(IdPersonnage);
            string htmlTableObjetPersonnage = AddObjetsPersonnage(IdPersonnage);
            string htmlTableMagiePersonnage = AddMagiesTable(IdPersonnage);
            string htmlTableAptitudesPersonnage = AddAptitudesTable(IdPersonnage);
            #endregion

            string htmlContent = string.Format(@"
            <h1>Informations générales</h1>
            <table>
                <tbody>
                    <tr>
                        <td>Race :</td>
                        <td>{0}</td>
                        <td>Niveau :</td>
                        <td>{1}</td>
                        <td>Sexe :</td>
                        <td>{2}</td>
                    </tr>
                    <tr>
                        <td>Expérience :</td>
                        <td colspan=""5"">{3}</td>
                    </tr>
                </tbody>
            </table>
            <h2>Attributs</h2>
            <table style=""width: 70 %; border - collapse:collapse; margin: 20px 0; text - align:center"">
                <thead>
                    <tr style=""background - color:#333;color:white"">
                        <th>Nom</th>
                        <th>Description</th>
                        <th>Type</th>
                        <th>Notes</th>
                    </tr>
                </thead>
                <tbody>
                    {4}
                </tbody>
            </table>
            <h2>Monnaie</h2>
            <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                <thead>
                    <tr style=""background - color:#333;color:white"">
                        <th>Nom monnaie</th>
                        <th>Or</th>
                        <th>Argent</th>
                        <th>Cuivre</th>
                    </tr>
                </thead>
                <tbody>
                    <td style=""border:1px solid #dddddd;padding:8px"">Sesterce(s)</td>                    
                    <td style=""border:1px solid #dddddd;padding:8px"">{5}</td>
                    <td style=""border:1px solid #dddddd;padding:8px"">{6}</td>
                    <td style=""border:1px solid #dddddd;padding:8px"">{7}</td>
                </tbody>
            </table>
            <h1>Caractéristiques & Compétences</h1>
            <h2>Caractéristiques</h2>
            <table style=""width: 50 %; border - collapse:collapse; margin: 20px 0; text - align:center"">
                <thead>
                    <tr style=""background-color:#333;color:white"">
                        <th>Type</th>
                        <th>Base</th>
                        <th>Temporaire</th>
                        <th>Total</th>
                    </tr>
                </thead>
                <tbody>
                    <tr style=""color:red"">
                        <tr style=""color:red"">
                        <td style=""border:1px solid #dddddd;padding:8px"">Physique</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{8}</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">0</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{8}</td>
                    </tr>
                    <tr style=""color:blue"">
                        <td style=""border:1px solid #dddddd;padding:8px"">Mental</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{9}</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">0</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{9}</td>
                    </tr>
                    <tr style=""color:green"">
                        <td style=""border:1px solid #dddddd;padding:8px"">Social</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{10}</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">0</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{10}</td>
                    </tr>
                </tbody>
            </table>
            <h2>Dextérité</h2>
            <table>
                <thead>
                    <tr style=""background-color:#333;color:white"">
                        <th>Nom caractéristiques</th>
                        <th>Base</th>
                        <th>Temporaire</th>
                        <th>Caractéristiques</th>
                        <th>Total</th>
                    </tr>
                </thead>
                <tbody>
                    <tr style=""color:red"">
                        <tr style=""color:red"">
                        <td style=""border:1px solid #dddddd;padding:8px"">Physique</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{19}</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">0</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{8}</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{22}</td>
                    </tr>
                    <tr style=""color:blue"">
                        <tr style=""color:blue"">
                        <td style=""border:1px solid #dddddd;padding:8px"">Mental</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{20}</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">0</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{9}</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{23}</td>
                    </tr>
                    <tr style=""color:green"">
                        <tr style=""color:green"">
                        <td style=""border:1px solid #dddddd;padding:8px"">Social</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{21}</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">0</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{10}</td>
                        <td style=""border:1px solid #dddddd;padding:8px"">{24}</td>
                    </tr>
                </tbody>
            </table>
            <h2>Compétences physiques</h2>
            <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                <thead>
                    <tr style=""background-color:#333;color:white"">
                        <th style=""white-space:nowrap"">Nom</th>
                        <th style=""white-space:nowrap"">Base</th>
                        <th style=""white-space:nowrap"">Caractéristique</th>
                        <th style=""white-space:nowrap"">Total</th>
                    </tr>
                </thead>
                <tbody>
                    {11}
                </tbody>
            </table>
            <h2>Compétences mentales</h2>
            <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                <thead>
                    <tr style=""background-color:#333;color:white"">
                        <th style=""white-space:nowrap"">Nom</th>
                        <th style=""white-space:nowrap"">Base</th>
                        <th style=""white-space:nowrap"">Caractéristique</th>
                        <th style=""white-space:nowrap"">Total</th>
                    </tr>
                </thead>
                <tbody>
                    {12}
                </tbody>
            </table>
            <h2>Compétences sociales</h2>
            <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                <thead>
                    <tr style=""background-color:#333;color:white"">
                        <th style=""white-space:nowrap"">Nom</th>
                        <th style=""white-space:nowrap"">Base</th>
                        <th style=""white-space:nowrap"">Caractéristique</th>
                        <th style=""white-space:nowrap"">Total</th>
                    </tr>
                </thead>
                <tbody>
                    {13}
                </tbody>
            </table>
            <h1>Équipements</h1>
            <h2>Armes</h2>
            <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                <thead>
                    <tr style=""background - color:#333;color:white"">
                        <th style=""white-space:nowrap"">Type</th>
                        <th style=""white-space:nowrap"">Nom</th>
                        <th style=""white-space:nowrap"">Poids</th>
                        <th style=""white-space:nowrap"">Allonge</th>
                        <th style=""white-space:nowrap"">Main(s)</th>
                        <th style=""white-space:nowrap"">Type(s) de dégât(s)</th>
                        <th style=""white-space:nowrap"">Dégâts</th>
                        <th style=""white-space:nowrap"">Valeur monétaire</th>
                    </tr>
                </thead>
                <tbody>
                    {14}
                </tbody>
            </table>
            <h2>Armures</h2>
            <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                <thead>
                    <tr style=""background - color:#333;color:white"">
                        <th style=""white-space:nowrap"">Type</th>
                        <th style=""white-space:nowrap"">Nom</th>
                        <th style=""white-space:nowrap"">Poids</th>
                        <th style=""white-space:nowrap"">Valeur monétaire</th>
                        <th style=""white-space:nowrap"">Protection</th>
                        <th style=""white-space:nowrap"">Bonus</th>
                    </tr>
                </thead>
                <tbody>
                    {15}
                </tbody>
            </table>
            <h2>Objets</h2>
            <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                <thead>
                    <tr style=""background - color:#333;color:white"">
                        <th style=""white-space:nowrap"">Type</th>
                        <th style=""white-space:nowrap"">Nom</th>
                        <th style=""white-space:nowrap"">Poids</th>
                        <th style=""white-space:nowrap"">Valeur monétaire</th>
                        <th style=""white-space:nowrap"">Consommable</th>
                    </tr>
                </thead>
                <tbody>
                    {16}
                </tbody>
            </table>
            <h1>Magie(s) & Aptitude(s)</h1>
            <h2>Magie(s)</h2>
            <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                <thead>
                    <tr style=""background - color:#333;color:white"">
                        <th style=""white-space:nowrap"">Type</th>
                        <th style=""white-space:nowrap"">Nom</th>
                        <th style=""white-space:nowrap"">Coût (moyen)</th>
                    </tr>
                </thead>
                <tbody>
                    {17}
                </tbody>
            </table>
            <h2>Aptitude(s)</h2>
            <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                <thead>
                    <tr style=""background - color:#333;color:white"">
                        <th style=""white-space:nowrap"">Type</th>
                        <th style=""white-space:nowrap"">Nom</th>
                        <th style=""white-space:nowrap"">Coût (moyen)</th>
                    </tr>
                </thead>
                <tbody>
                    {18}
                </tbody>
            </table>
            <h1>Notes</h1>
            ",
               racePersonnage,
               niveauPersonnage,
               sexePersonnage,
               experiencePersonnage,
               htmlTableAttributs,
               PersonnageController.GetPieceOrPersonnage(IdPersonnage),
               PersonnageController.GetPieceArgentPersonnage(IdPersonnage),
               PersonnageController.GetPieceCuivrePersonnage(IdPersonnage),
               CompetencesCaracteristiquesController.GetPhysiquePersonnage(IdPersonnage),
               CompetencesCaracteristiquesController.GetMentalPersonnage(IdPersonnage),
               CompetencesCaracteristiquesController.GetSocialPersonnage(IdPersonnage),
               htmlTableCompPhy,
               htmlTableCompMen,
               htmlTableCompSoc,
               htmlTableArmePersonnage,
               htmlTableArmurePersonnage,
               htmlTableObjetPersonnage,
               htmlTableMagiePersonnage,
               htmlTableAptitudesPersonnage,
               dexteriteCaracteristiques[0],
               dexteriteCaracteristiques[1],
               dexteriteCaracteristiques[2],
               CompetencesCaracteristiquesController.GetPhysiquePersonnage(IdPersonnage) + dexteriteCaracteristiques[0],
               CompetencesCaracteristiquesController.GetMentalPersonnage(IdPersonnage) + dexteriteCaracteristiques[1],
               CompetencesCaracteristiquesController.GetSocialPersonnage(IdPersonnage) + dexteriteCaracteristiques[2]
               );

            string cheminDuFichier = string.Format(@"Templates\{0}_{1}.html", prenomPersonnage, nomPersonnage);
            // Écrire le contenu dans le fichier
            File.WriteAllText(cheminDuFichier, htmlContent, Encoding.UTF8);
            Console.WriteLine("Fichier HTML créé avec succès !");
        }

        /// <summary>
        /// Méthode qui retourne sous la forme d'un tableau html les attributs
        /// d'un personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        private string AddAttributesHtml(int idPersonnage)
        {
            string attributesPersonnages = string.Empty;

            #region Initialisation des variables
            List<string> nomsAttribut = Controller.AttributsController.GetListNomAttributs(idPersonnage);
            List<string> descriptionsAttribut = Controller.AttributsController.GetListDescriptionAttributs(idPersonnage);
            List<string> typesAttribut = Controller.AttributsController.GetListTypeAttributs(idPersonnage);
            List<string> notesAttributs = Controller.AttributsController.GetListNoteAttributs(idPersonnage);
            #endregion

            // Pour chaque attribut on créait une ligne dans le tableau
            for (int i = 0; i < nomsAttribut.Count; i++)
            {
                attributesPersonnages += "\n" +
                    $"  <tr >" +
                    $"      <td style=\"border:1px solid #dddddd;padding:8px;white-space:nowrap\">{nomsAttribut[i]}</td>" +
                    $"      <td style=\"border:1px solid #dddddd;padding:8px;white-space:nowrap\">{descriptionsAttribut[i]}</td>" +
                    $"      <td style=\"border:1px solid #dddddd;padding:8px;white-space:nowrap\">{typesAttribut[i]}</td>" +
                    $"      <td style=\"border:1px solid #dddddd;padding:8px;white-space:nowrap\">{notesAttributs[i]}</td>" +
                    $"  </tr>";
            }

            return attributesPersonnages;
        }

        /// <summary>
        /// Méthode qui retourne sous la forme d'un tableau html les compétences physiques
        /// d'un personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        private string AddCompPhysiqueHtml(int idPersonnage, int caracteristiquePhysiquePersonnage)
        {
            string compPhyPersonnage = string.Empty;

            #region Initialisation des variables
            int[] baseCompPhys = Controller.CompetencesCaracteristiquesController.GetBaseCompetencePhysique(idPersonnage);
            string[] listeCompPhy = { "Agilité", "Artisanat", "Crochetage", "Discrétion", "Équilibre", "Escalade", "Escamotage", "Force", "Fouille", "Natation", "Réflexes", "Vigueur" };

            #endregion

            for (int i = 0; i < listeCompPhy.Length; i++)
            {
                compPhyPersonnage += "\n" +
                    $"  <tr style=\"color:red\">" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{listeCompPhy[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{baseCompPhys[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{caracteristiquePhysiquePersonnage}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{baseCompPhys[i] + caracteristiquePhysiquePersonnage}</td>" +
                    $"  </tr>";
            }

            return compPhyPersonnage;
        }

        /// <summary>
        /// Méthode qui retourne sous la forme d'un tableau html les compétences mentales
        /// d'un personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        private string AddCompMentalHtml(int idPersonnage, int caracteristiqueMental)
        {
            string compMenPersonnage = string.Empty;

            #region Initialisation des variables
            int[] baseCompMen = Controller.CompetencesCaracteristiquesController.GetBaseCompetenceMental(idPersonnage);
            string[] listeCompMen = { "Concentration", "Connaissance géographiques", "Connaissance historiques", "Connaissance magiques",
                "Connaissance natures", "Connaissance religieuses", "Décryptage", "Esprit", "Explosifs", "Mécanique", "Médecine", "Mémoire", "Perception", "Volonté" };

            #endregion

            for (int i = 0; i < listeCompMen.Length; i++)
            {
                compMenPersonnage += "\n" +
                    $"  <tr style=\"color:blue\">" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{listeCompMen[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{baseCompMen[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{caracteristiqueMental}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{baseCompMen[i] + caracteristiqueMental}</td>" +
                    $"  </tr>";
            }

            return compMenPersonnage;
        }

        /// <summary>
        /// Méthode qui retourne sous forme d'un tableau html les compétences sociales
        /// d'un personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        private string AddCompSocialHtml(int idPersonnage, int caracteristiqueSocial)
        {
            string compSocPersonnage = string.Empty;

            #region Initialisation des variables
            int[] baseCompSoc = Controller.CompetencesCaracteristiquesController.GetBaseCompetenceSocial(idPersonnage);
            string[] listeCompSoc = { "Baratinage", "Charme", "Comédie", "Diplomatie", "Dressage", "Intimidation", "Marchandage",
                "Prestance", "Provocation"};

            #endregion

            for (int i = 0; i < listeCompSoc.Length; i++)
            {
                compSocPersonnage += "\n" +
                    $"  <tr style=\"color:green\">" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{listeCompSoc[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{baseCompSoc[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{caracteristiqueSocial}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{baseCompSoc[i] + caracteristiqueSocial}</td>" +
                    $"  </tr>";
            }

            return compSocPersonnage;
        }

        /// <summary>
        /// Méthode qui retourne sous forme d'un tableau html les armes
        /// d'un personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        private string AddArmesPersonnage(int idPersonnage)
        {
            string tableArmeHtmlPersonnage = string.Empty;

            #region Initialisation des variables
            List<string> typesArmes = Controller.EquipmentController.GetListTypeArmes(idPersonnage);
            List<string> nomArmes = Controller.EquipmentController.GetListNomArmes(idPersonnage);
            List<double> poidsArmes = Controller.EquipmentController.GetListPoidsArmes(idPersonnage);
            List<string> allongeArmes = Controller.EquipmentController.GetListAllongeArmes(idPersonnage);
            List<string> mainsArmes = Controller.EquipmentController.GetListMainsArmes(idPersonnage);
            List<string> typesDegatsArmes = Controller.EquipmentController.GetListTypeDegatsArmes(idPersonnage);
            List<string> degatsArmes = Controller.EquipmentController.GetListDegatsArmes(idPersonnage);
            List<string> valeurArmes = Controller.EquipmentController.GetListValeurArmes(idPersonnage);
            #endregion

            for (int i = 0; i < typesArmes.Count; i++)
            {
                tableArmeHtmlPersonnage += "\n" +
                    $"  <tr>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{typesArmes[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{nomArmes[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{poidsArmes[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{allongeArmes[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{mainsArmes[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{typesDegatsArmes[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{degatsArmes[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{valeurArmes[i]}</td>" +
                    $"  </tr>";
            }

            return tableArmeHtmlPersonnage;
        }

        /// <summary>
        /// Méthode qui retourne sous forme d'un tableau html les armures
        /// d'un personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        private string AddArmuresPersonnage(int idPersonnage)
        {
            string tableArmureHtmlPersonnage = string.Empty;

            #region Initialisation des variables
            List<string> typesArmures = Controller.EquipmentController.GetListTypeArmures(idPersonnage);
            List<string> nomArmures = Controller.EquipmentController.GetListNomArmures(idPersonnage);
            List<double> poidsArmures = Controller.EquipmentController.GetListPoidsArmures(idPersonnage);
            List<string> valeurArmures = Controller.EquipmentController.GetListValeurArmures(idPersonnage);
            List<string> protectionsArmures = Controller.EquipmentController.GetListProtectionArmures(idPersonnage);
            List<string> bonusArmures = Controller.EquipmentController.GetListBonusArmures(idPersonnage);
            List<string> specialsArmures = Controller.EquipmentController.GetListSpecialArmures(idPersonnage);
            #endregion

            for (int i = 0; i < typesArmures.Count; i++)
            {
                tableArmureHtmlPersonnage += "\n" +
                    $"  <tr>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{typesArmures[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{nomArmures[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{poidsArmures[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{valeurArmures[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{protectionsArmures[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{bonusArmures[i]}</td>" +
                    $"  </tr>";
            }

            return tableArmureHtmlPersonnage;
        }

        /// <summary>
        /// Méthode qui retourne sous forme d'un tableau html les objets
        /// d'un personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        private string AddObjetsPersonnage(int idPersonnage)
        {
            string tableObjetsHtml = string.Empty;

            #region Initialisation des variables
            List<string> typesObjets = Controller.EquipmentController.GetListTypeObjets(idPersonnage);
            List<string> nomsObjets = Controller.EquipmentController.GetListNomObjets(idPersonnage);
            List<double> poidsObjets = Controller.EquipmentController.GetListPoidsObjets(idPersonnage);
            List<string> valeursObjets = Controller.EquipmentController.GetListValeurObjets(idPersonnage);
            List<string> consommablesObjets = Controller.EquipmentController.GetListConsommableObjets(idPersonnage);
            #endregion

            for (int i = 0; i < typesObjets.Count; i++)
            {
                tableObjetsHtml += "\n" +
                    $"  <tr>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{typesObjets[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{nomsObjets[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{poidsObjets[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{valeursObjets[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{consommablesObjets[i]}</td>" +
                    $"  </tr>";
            }

            return tableObjetsHtml;
        }

        /// <summary>
        /// Méthode qui retourne sous forme d'un tableau html les magies
        /// d'un personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        private string AddMagiesTable(int idPersonnage)
        {
            string tableMagiesHtml = string.Empty;

            #region Initialisation des variables
            List<string> typesMagies = Controller.MagieController.GetListNomMagie(idPersonnage);
            List<string> nomsMagies = Controller.MagieController.GetListTypeMagie(idPersonnage);
            List<int> coutsMagies = Controller.MagieController.GetListCoutMagie(idPersonnage);
            #endregion

            for (int i = 0; i < typesMagies.Count; i++)
            {
                tableMagiesHtml += "\n" +
                    $"  <tr>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{typesMagies[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{nomsMagies[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{coutsMagies[i]}</td>" +
                    $"  </tr>";
            }

            return tableMagiesHtml;
        }

        /// <summary>
        /// Méthode qui retourne sous forme d'un tableau html les aptitudes
        /// d'un personnage
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        private string AddAptitudesTable(int idPersonnage)
        {
            string tableAptitudesHtml = string.Empty;

            #region Initialisation des variables
            List<string> typesAptitudes = Controller.AptitudesController.GetListTypeAptitude(idPersonnage);
            List<string> nomsAptitudes = Controller.AptitudesController.GetListNomAptitude(idPersonnage);
            List<int> coutsAptitudes = Controller.AptitudesController.GetListCoutAptitude(idPersonnage);
            #endregion

            for (int i = 0; i < typesAptitudes.Count; i++)
            {
                tableAptitudesHtml += "\n" +
                    $"  <tr>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{typesAptitudes[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{nomsAptitudes[i]}</td>" +
                    $"      <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{coutsAptitudes[i]}</td>" +
                    $"  </tr>";
            }

            return tableAptitudesHtml;
        }
    }
}
