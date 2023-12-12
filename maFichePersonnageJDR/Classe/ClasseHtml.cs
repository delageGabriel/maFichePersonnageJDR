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
        public void CreatePersonnageHtml()
        {
            #region Initialisation des variables
            string prenomPersonnage = PersonnageController.GetPrenomPersonnage(GlobaleVariables.IdPersonnage);
            string nomPersonnage = PersonnageController.GetNomPersonnage(GlobaleVariables.IdPersonnage);
            string racePersonnage = PersonnageController.GetRacePersonnage(GlobaleVariables.IdPersonnage);
            int niveauPersonnage = PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage);
            string sexePersonnage = PersonnageController.GetSexePersonnage(GlobaleVariables.IdPersonnage);
            string languePersonnage = PersonnageController.GetLanguesPersonnage(GlobaleVariables.IdPersonnage);
            int experiencePersonnage = PersonnageController.GetExperiencePersonnage(GlobaleVariables.IdPersonnage);
            int esquivePersonnage = (CompetencesCaracteristiquesController.GetValueCompetence("Physique", "agilite", GlobaleVariables.IdPersonnage) + CompetencesCaracteristiquesController.GetValueCompetence("Physique", "reflexes", GlobaleVariables.IdPersonnage)) / 3;
            int resistanceMental = (CompetencesCaracteristiquesController.GetValueCompetence("Mental", "esprit", GlobaleVariables.IdPersonnage) + CompetencesCaracteristiquesController.GetValueCompetence("Mental", "volonte", GlobaleVariables.IdPersonnage)) / 3;
            string initiativePersonnage = GetInitiativePersonnage(CompetencesCaracteristiquesController.GetValueCompetence("Physique", "agilite", GlobaleVariables.IdPersonnage));
            short[] dexteriteCaracteristiques = {
                Utils.GetDizaineInteger(CompetencesCaracteristiquesController.GetPhysiquePersonnage(GlobaleVariables.IdPersonnage)),
                Utils.GetDizaineInteger(CompetencesCaracteristiquesController.GetMentalPersonnage(GlobaleVariables.IdPersonnage)),
                Utils.GetDizaineInteger(CompetencesCaracteristiquesController.GetSocialPersonnage(GlobaleVariables.IdPersonnage))
            };
            string htmlTableAttributs = AddAttributesHtml(GlobaleVariables.IdPersonnage);
            string htmlTableCompPhy = AddCompPhysiqueHtml(GlobaleVariables.IdPersonnage, CompetencesCaracteristiquesController.GetPhysiquePersonnage(GlobaleVariables.IdPersonnage));
            string htmlTableCompMen = AddCompMentalHtml(GlobaleVariables.IdPersonnage, CompetencesCaracteristiquesController.GetMentalPersonnage(GlobaleVariables.IdPersonnage));
            string htmlTableCompSoc = AddCompSocialHtml(GlobaleVariables.IdPersonnage, CompetencesCaracteristiquesController.GetSocialPersonnage(GlobaleVariables.IdPersonnage));
            string htmlTableArmePersonnage = AddArmesPersonnage(GlobaleVariables.IdPersonnage);
            string htmlTableArmurePersonnage = AddArmuresPersonnage(GlobaleVariables.IdPersonnage);
            string htmlTableObjetPersonnage = AddObjetsPersonnage(GlobaleVariables.IdPersonnage);
            string htmlTableMagiePersonnage = AddMagiesTable(GlobaleVariables.IdPersonnage);
            string htmlTableAptitudesPersonnage = AddAptitudesTable(GlobaleVariables.IdPersonnage);
            #endregion

            string htmlContent = string.Format(@"
            <details style=""border:1px solid #aaa;border-radius:4px;padding:0.5em 0.5em 0"">
                <summary style=""font-weight:bold;font-size:x-large;margin:-0.5em -0.5em 0;padding:0.5em"">
                    <strong>
                        <p>Informations générales</p>
                    </strong>
                </summary>
                <table>
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th>Race</th>
                            <th>Niveau</th>
                            <th>Sexe</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr style=""border:1px solid #dddddd;padding:8px;text-align:center;"">
                            <td>{0}</td>
                            <td>{1}</td>
                            <td>{2}</td>
                        </tr>
                    </tbody>
                </table>
                <h2>Expérience du personnage</h2>
                <table>
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th>Point(s) acquis</th>
                            <th>Niveau suivant</th>
                            <th>Progression</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr style=""border:1px solid #dddddd;padding:8px;text-align:center;"">
                            <td>{3}</td>
                            <td>{4}</td>
                            <td>{5}</td>
                        </tr>
                    </tbody>
                </table>
                <h2>Langue(s)</h2>
                <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th>Langues</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr style=""border:1px solid #dddddd;padding:8px;text-align:center;"">
                            <td>{6}</td>
                        </tr>
                    </tbody>
                </table>
                <h2>Attributs</h2>
                <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th>Nom</th>
                            <th>Description</th>
                            <th>Type</th>
                            <th>Notes</th>
                        </tr>
                    </thead>
                    <tbody>{7}
                    </tbody>
                </table>
                <h2>Monnaie</h2>
                <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th>Nom monnaie</th>
                            <th>Or</th>
                            <th>Argent</th>
                            <th>Cuivre</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr style=""border:1px solid #dddddd;padding:8px;text-align:center;"">
                            <td>Sesterce(s)</td>
                            <td>{8}</td>
                            <td>{9}</td>
                            <td>{10}</td>
                        </tr>
                    </tbody>
                </table>
            </details>
            <details style=""border:1px solid #aaa;border-radius:4px;padding:0.5em 0.5em 0"">
                <summary style=""font-weight:bold;font-size:x-large;margin:-0.5em -0.5em 0;padding:0.5em"">
                    <strong>
                        <p>Caractéristiques & Compétences</p>
                    </strong>
                </summary>
                <h2>Caractéristiques</h2>
                <table style=""width:50%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th>Type</th>
                            <th>Base</th>
                            <th>Temporaire</th>
                            <th>Total</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr style=""color:darkred"">
                            <td style=""border:1px solid #dddddd;padding:8px"">Physique</td>
                            <td style=""border:1px solid #dddddd;padding:8px"">{11}</td>
                            <td style=""border:1px solid #dddddd;padding:8px"">0</td>
                            <td style=""border:1px solid #dddddd;padding:8px"">{11}</td>
                        </tr>
                        <tr style=""color:blue"">
                            <td style=""border:1px solid #dddddd;padding:8px"">Mental</td>
                            <td style=""border:1px solid #dddddd;padding:8px"">{12}</td>
                            <td style=""border:1px solid #dddddd;padding:8px"">0</td>
                            <td style=""border:1px solid #dddddd;padding:8px"">{12}</td>
                        </tr>
                        <tr style=""color:green"">
                            <td style=""border:1px solid #dddddd;padding:8px"">Social</td>
                            <td style=""border:1px solid #dddddd;padding:8px"">{13}</td>
                            <td style=""border:1px solid #dddddd;padding:8px"">0</td>
                            <td style=""border:1px solid #dddddd;padding:8px"">{13}</td>
                        </tr>
                    </tbody>
                </table>
                <h2>Dextérité</h2>
                <table>
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th>Nom caractéristiques</th>
                            <th>Base</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr style=""color:darkred"">
                            <td style=""border:1px solid #dddddd;padding:8px;text-align:center;"">Physique</td>
                            <td style=""border:1px solid #dddddd;padding:8px;text-align:center;"">{14}</td>
                        </tr>
                        <tr style=""color:blue"">
                            <td style=""border:1px solid #dddddd;padding:8px;text-align:center;"">Mental</td>
                            <td style=""border:1px solid #dddddd;padding:8px;text-align:center;"">{15}</td>
                        </tr>
                        <tr style=""color:green"">
                            <td style=""border:1px solid #dddddd;padding:8px;text-align:center;"">Social</td>
                            <td style=""border:1px solid #dddddd;padding:8px;text-align:center;"">{16}</td>
                        </tr>
                    </tbody>
                </table>
                <h2>Compétences spéciales</h2>                    
                <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th>Esquive</th>
                            <th>Résistance mentale</th>
                            <th>Initiative</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td style=""border:1px solid #dddddd;padding:8px;text-align:center;"">{17}</td>
                            <td style=""border:1px solid #dddddd;padding:8px;text-align:center;"">{18}</td>
                            <td style=""border:1px solid #dddddd;padding:8px;text-align:center;"">[[/r 1d{19} # Jet d'initiative]]</td> 
                        </tr>
                    </tbody>
                </table>
                <h2>Compétences physiques</h2>
                <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th style=""white-space:nowrap"">Nom</th>
                            <th style=""white-space:nowrap"">Base</th>
                        </tr>
                    </thead>
                    <tbody>{20}
                    </tbody>
                </table>
                <h2>Compétences mentales</h2>
                <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th style=""white-space:nowrap"">Nom</th>
                            <th style=""white-space:nowrap"">Base</th>
                        </tr>
                    </thead>
                    <tbody>{21}
                    </tbody>
                </table>
                <h2>Compétences sociales</h2>
                <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th style=""white-space:nowrap"">Nom</th>
                            <th style=""white-space:nowrap"">Base</th>
                        </tr>
                    </thead>
                    <tbody>{22}
                    </tbody>
                </table>
            </details>
            <details style=""border:1px solid #aaa;border-radius:4px;padding:0.5em 0.5em 0"">
                <summary style=""font-weight:bold;font-size:x-large;margin:-0.5em -0.5em 0;padding:0.5em"">
                    <strong>
                        <p>Équipement(s)</p>
                    </strong>
                </summary>
                <h2>Armes</h2>
                <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background - color:#333;color:white"">
                            <th style=""white-space:nowrap"">Type</th>
                            <th style=""white-space:nowrap"">Nom</th>
                            <th style=""white-space:nowrap"">Poids(kg)</th>
                            <th style=""white-space:nowrap"">Allonge</th>
                            <th style=""white-space:nowrap"">Main(s)</th>
                            <th style=""white-space:nowrap"">Type(s) de dégât(s)</th>
                            <th style=""white-space:nowrap"">Dégâts</th>
                            <th style=""white-space:nowrap"">Valeur monétaire</th>
                            <th style=""white-space:nowrap"">Spécial</th>
                            <th style=""white-space:nowrap"">Quantité</th>
                        </tr>
                    </thead>
                    <tbody>{23}
                    </tbody>
                </table>
                <h2>Armures</h2>
                <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background - color:#333;color:white"">
                            <th style=""white-space:nowrap"">Type</th>
                            <th style=""white-space:nowrap"">Nom</th>
                            <th style=""white-space:nowrap"">Poids(kg)</th>
                            <th style=""white-space:nowrap"">Valeur monétaire</th>
                            <th style=""white-space:nowrap"">Protection</th>
                            <th style=""white-space:nowrap"">Spécial</th>
                            <th style=""white-space:nowrap"">Quantité</th>
                        </tr>
                    </thead>
                    <tbody>{24}
                    </tbody>
                </table>
                <h2>Objets</h2>
                <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th style=""white-space:nowrap"">Type</th>
                            <th style=""white-space:nowrap"">Nom</th>
                            <th style=""white-space:nowrap"">Poids(kg)</th>
                            <th style=""white-space:nowrap"">Valeur monétaire</th>
                            <th style=""white-space:nowrap"">Consommable</th>
                            <th style=""white-space:nowrap"">Spécial</th>
                            <th style=""white-space:nowrap"">Quantité</th>
                        </tr>
                    </thead>
                    <tbody>{25}
                    </tbody>
                </table>
                <h2>Poids</h2>
                <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th style=""white-space:nowrap"">Poids transporté(kg)</th>
                            <th style=""white-space:nowrap"">Poids maximal(kg)</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr style=""border:1px solid #dddddd;padding:8px;text-align:center;"">
                            <td>{26}</td>
                            <td>{27}</td>
                        </tr>
                    </tbody>
                </table>
            </details>
            <details style=""border:1px solid #aaa;border-radius:4px;padding:0.5em 0.5em 0"">
                <summary style=""font-weight:bold;font-size:x-large;margin:-0.5em -0.5em 0;padding:0.5em"">
                    <strong>
                        <p>Magie(s) & Aptitude(s)</p>
                    </strong>
                </summary>
                <h2>Magie(s)</h2>
                <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background-color:#333;color:white"">
                            <th style=""white-space:nowrap"">Type</th>
                            <th style=""white-space:nowrap"">Nom</th>
                            <th style=""white-space:nowrap"">Coût (moyen)</th>
                            <th style=""white-space:nowrap"">Description</th>
                        </tr>
                    </thead>
                    <tbody>{28}
                    </tbody>
                </table>
                <h2>Aptitude(s)</h2>
                <table style=""width:70%;border-collapse:collapse;margin:20px 0;text-align:center"">
                    <thead>
                        <tr style=""background - color:#333;color:white"">
                            <th style=""white-space:nowrap"">Type</th>
                            <th style=""white-space:nowrap"">Nom</th>
                            <th style=""white-space:nowrap"">Coût (moyen)</th>
                            <th style=""white-space:nowrap"">Description</th>
                        </tr>
                    </thead>
                    <tbody>{29}
                    </tbody>
                </table>
            </details>
            <h1>Notes</h1>
            ",
               racePersonnage,
               niveauPersonnage,
               sexePersonnage,
               experiencePersonnage,
               PersonnageController.GetNiveauSuivantPersonnage(GlobaleVariables.IdPersonnage),
               PersonnageController.GetCourbeProgressionPersonnage(GlobaleVariables.IdPersonnage),
               languePersonnage,
               htmlTableAttributs,
               PersonnageController.GetPieceOrPersonnage(GlobaleVariables.IdPersonnage),
               PersonnageController.GetPieceArgentPersonnage(GlobaleVariables.IdPersonnage),
               PersonnageController.GetPieceCuivrePersonnage(GlobaleVariables.IdPersonnage),
               CompetencesCaracteristiquesController.GetPhysiquePersonnage(GlobaleVariables.IdPersonnage),
               CompetencesCaracteristiquesController.GetMentalPersonnage(GlobaleVariables.IdPersonnage),
               CompetencesCaracteristiquesController.GetSocialPersonnage(GlobaleVariables.IdPersonnage),
               dexteriteCaracteristiques[0],
               dexteriteCaracteristiques[1],
               dexteriteCaracteristiques[2],
               esquivePersonnage,
               resistanceMental,
               initiativePersonnage,
               htmlTableCompPhy,
               htmlTableCompMen,
               htmlTableCompSoc,
               htmlTableArmePersonnage,
               htmlTableArmurePersonnage,
               htmlTableObjetPersonnage,
               PersonnageController.GetChargePortee(GlobaleVariables.IdPersonnage),
               PersonnageController.GetChargeTotale(GlobaleVariables.IdPersonnage),
               htmlTableMagiePersonnage,
               htmlTableAptitudesPersonnage
               );

            string cheminDuFichier = string.Format(@"Templates\{0}_{1}.html", prenomPersonnage, nomPersonnage);
            string folderPath = Path.GetDirectoryName(cheminDuFichier);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

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
                attributesPersonnages += 
                    $"                      \n<tr>\n" +
                    $"                          <td style=\"border:1px solid #dddddd;padding:8px;white-space:nowrap\">{nomsAttribut[i]}</td>\n" +
                    $"                          <td style=\"border:1px solid #dddddd;padding:8px;white-space:nowrap\">{descriptionsAttribut[i]}</td>\n" +
                    $"                          <td style=\"border:1px solid #dddddd;padding:8px;white-space:nowrap\">{typesAttribut[i]}</td>\n" +
                    $"                          <td style=\"border:1px solid #dddddd;padding:8px;white-space:nowrap\">{notesAttributs[i]}</td>\n" +
                    $"                      </tr>\n";
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
            string[] listeCompPhy = { "Agilité", "Artisanat", "Crochetage", "Discrétion", "Équilibre","Équitation", "Escalade", "Escamotage", "Force", "Fouille", 
                "Lutte", "Natation", "Réflexes", "Vigueur" };

            #endregion

            for (int i = 0; i < listeCompPhy.Length; i++)
            {
                compPhyPersonnage +=
                    $"                      \n<tr style=\"color:darkred\">\n" +
                    $"                          <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{listeCompPhy[i]}</td>\n" +
                    $"                          <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{baseCompPhys[i]}</td>\n" +
                    $"                      </tr>\n";
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
                "Connaissance natures", "Connaissance religieuses", "Esprit", "Explosifs", "Mécanique", "Médecine", "Mémoire", "Orientation",
                "Perception", "Volonté" };

            #endregion

            for (int i = 0; i < listeCompMen.Length; i++)
            {
                compMenPersonnage += 
                    $"                      \n<tr style=\"color:blue\">\n" +
                    $"                          <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{listeCompMen[i]}</td>\n" +
                    $"                          <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{baseCompMen[i]}</td>\n" +
                    $"                      </tr>\n";
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
            string[] listeCompSoc = { "Baratinage", "Charme", "Comédie", "Commandement", "Diplomatie", "Dressage", "Intimidation", "Marchandage",
                "Prestance", "Provocation", "Représentation"};

            #endregion

            for (int i = 0; i < listeCompSoc.Length; i++)
            {
                compSocPersonnage +=
                    $"                      \n<tr style=\"color:green\">\n" +
                    $"                          <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{listeCompSoc[i]}</td>\n" +
                    $"                          <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{baseCompSoc[i]}</td>\n" +
                    $"                      </tr>\n";
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
            List<string> specialArmes = Controller.EquipmentController.GetListSpecialArmes(idPersonnage);
            List<int> quantities = Controller.EquipmentController.GetListQuantityArmes(idPersonnage);
            #endregion

            for (int i = 0; i < typesArmes.Count; i++)
            {
                tableArmeHtmlPersonnage +=
                    $"                          \n<tr>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{typesArmes[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{nomArmes[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{poidsArmes[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{allongeArmes[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{mainsArmes[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{typesDegatsArmes[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">[[/r {degatsArmes[i]}]]</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{valeurArmes[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">[[/r 0 #{specialArmes[i]}]]</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{quantities[i]}</td>\n" +
                    $"                          </tr>\n";
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
            List<string> specialsArmures = Controller.EquipmentController.GetListSpecialArmures(idPersonnage);
            List<int> quantities = Controller.EquipmentController.GetListQuantityArmures(idPersonnage);
            #endregion

            for (int i = 0; i < typesArmures.Count; i++)
            {
                tableArmureHtmlPersonnage +=
                    $"                          \n<tr>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{typesArmures[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{nomArmures[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{poidsArmures[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{valeurArmures[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{protectionsArmures[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">[[/r 0 #{specialsArmures[i]}]]</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{quantities[i]}</td>\n" +
                    $"                          </tr>\n";
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
            List<string> specialObjets = Controller.EquipmentController.GetListSpecialObjets(idPersonnage);
            List<int> quantiteObjets = Controller.EquipmentController.GetListQuantityItems(idPersonnage);
            #endregion

            for (int i = 0; i < typesObjets.Count; i++)
            {
                tableObjetsHtml +=
                    $"                          \n<tr>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{typesObjets[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{nomsObjets[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{poidsObjets[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{valeursObjets[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{consommablesObjets[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">[[/r 0 #{specialObjets[i]}]]</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{quantiteObjets[i]}</td>\n" +
                    $"                          </tr>\n";
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
            List<string> typesMagies = Controller.MagieController.GetListTypeMagie(idPersonnage);
            List<string> nomsMagies = Controller.MagieController.GetListNomMagie(idPersonnage);
            List<int> coutsMagies = Controller.MagieController.GetListCoutMagie(idPersonnage);
            List<string> descrMagies = Controller.MagieController.GetListDescrMagie(idPersonnage);
            #endregion

            for (int i = 0; i < typesMagies.Count; i++)
            {
                tableMagiesHtml +=
                    $"                          \n<tr>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{typesMagies[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{nomsMagies[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{coutsMagies[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">[[/r 0 #{descrMagies[i]}]]</td>\n" +
                    $"                          </tr>\n";
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
            List<string> descrAptitudes = Controller.AptitudesController.GetListDescrAptitude(idPersonnage);
            #endregion

            for (int i = 0; i < typesAptitudes.Count; i++)
            {
                tableAptitudesHtml +=
                    $"                          \n<tr>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{typesAptitudes[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{nomsAptitudes[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">{coutsAptitudes[i]}</td>\n" +
                    $"                              <td style=\"border: 1px solid #dddddd;padding:8px;white-space:nowrap\">[[/r 0 #{descrAptitudes[i]}]]</td>\n" +
                    $"                          </tr>\n";
            }

            return tableAptitudesHtml;
        }

        private string GetInitiativePersonnage(int valueAgilite)
        {
            if (valueAgilite >= 0 && valueAgilite < 5)
            {
                return "4";
            }
            else if (valueAgilite > 4 && valueAgilite < 10)
            {
                return "6";
            }
            else if (valueAgilite > 9 && valueAgilite < 15)
            {
                return "8";
            }
            else if (valueAgilite > 14 && valueAgilite < 20)
            {
                return "10";
            }
            else
            {
                return "12";
            }
        }
    }
}
