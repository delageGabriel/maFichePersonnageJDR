using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

namespace maFichePersonnageJDR.Classe
{
    class ClassePdf
    {
        private int idPersonnage;

        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }

        public void CreatePersonnagePdf()
        {
            #region Initialisation des variables
            string prenomPersonnage = Controller.PersonnageController.GetPrenomPersonnage(IdPersonnage);
            string nomPersonnage = Controller.PersonnageController.GetNomPersonnage(IdPersonnage);
            string racePersonnage = Controller.PersonnageController.GetRacePersonnage(IdPersonnage);
            int niveauPersonnage = Controller.PersonnageController.GetNiveauPersonnage(IdPersonnage);
            string sexePersonnage = Controller.PersonnageController.GetSexePersonnage(IdPersonnage);
            int experiencePersonnage = Controller.PersonnageController.GetExperiencePersonnage(IdPersonnage);
            string histoirePersonnage = Controller.PersonnageController.GetHistoirePersonnage(IdPersonnage);

            #endregion

            // Créez un document PDF
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("fiche_personnage.pdf", FileMode.Create));

            document.Open();

            //// Ajoutez une image du personnage
            //Image image = Image.GetInstance("image_personnage.png"); // Remplacez "image_personnage.png" par le chemin de votre image
            //image.ScaleToFit(100f, 100f);
            //image.Alignment = Image.ALIGN_TOP;
            //document.Add(image);

            // Ajoutez les informations de base (prénom, nom, race, niveau, sexe)
            AddFormField(document, writer, "Prénom :" + prenomPersonnage, 200f);
            AddFormField(document, writer, "Nom :" + nomPersonnage, 200f);
            AddFormField(document, writer, "Race :" + racePersonnage, 200f);
            AddFormField(document, writer, "Niveau :" + niveauPersonnage, 200f);
            AddFormField(document, writer, "Sexe :" + sexePersonnage, 200f);

            // Ajoutez les points d'expérience
            AddFormField(document, writer, "Points acquis :" + experiencePersonnage, 200f);
            AddFormField(document, writer, "Points à acquérir :", 200f);

            // Ajoutez l'histoire du personnage
            AddFormField(document, writer, "Histoire :" + histoirePersonnage, 400f);

            // Ajoutez la monnaie dans un tableau
            PdfPTable moneyTable = new PdfPTable(3);
            moneyTable.WidthPercentage = 50;
            moneyTable.HorizontalAlignment = 0;
            moneyTable.SpacingBefore = 10f;
            moneyTable.SpacingAfter = 10f;

            // Ajoutez les en-têtes du tableau de monnaie
            moneyTable.AddCell("PO");
            moneyTable.AddCell("PA");
            moneyTable.AddCell("PC");

            // Ajoutez les valeurs de monnaie
            moneyTable.AddCell("10");
            moneyTable.AddCell("20");
            moneyTable.AddCell("5");

            document.Add(moneyTable);

            AddFormField(document, writer, "Caractéristiques et compétences", 200f);

            AddCaracteristiquesTable(document, IdPersonnage);

            AddFormField(document, writer, "Attributs du personnages", 200f);

            // Ajoutez les attributs
            AddAttributesTable(document, IdPersonnage);

            AddFormField(document, writer, "Compétences physiques", 200f);

            AddCompPhysiqueTable(document, IdPersonnage);

            AddFormField(document, writer, "Compétences mentales", 200f);

            AddCompMentalTable(document, IdPersonnage);

            AddFormField(document, writer, "Compétences sociales", 200f);

            AddCompSocialTable(document, IdPersonnage);

            AddFormField(document, writer, "Équipements", 200f);

            AddArmesTable(document, IdPersonnage);
            // Fermez le document
            document.Close();
            Console.WriteLine("Fiche de personnage créée avec succès !");
        }

        static void AddFormField(Document document, PdfWriter writer, string label, float width)
        {
            Paragraph p = new Paragraph(label);
            p.Add(new Chunk(new VerticalPositionMark()));
            document.Add(p);

            TextField field = new TextField(writer, new Rectangle(0, 0, width, 20), label);
            writer.AddAnnotation(field.GetTextField());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="idPersonnage"></param>
        static void AddCaracteristiquesTable(Document document, int idPersonnage)
        {
            #region Initialisation des variables
            int basePhysiquePersonnage = Controller.CompetencesCaracteristiquesController.GetPhysiquePersonnage(idPersonnage);
            int baseMentalPersonnage = Controller.CompetencesCaracteristiquesController.GetMentalPersonnage(idPersonnage);
            int baseSocialPersonnage = Controller.CompetencesCaracteristiquesController.GetSocialPersonnage(idPersonnage);
            #endregion

            // Ajoutez la monnaie dans un tableau
            PdfPTable caracteristiquesTable = new PdfPTable(4);
            caracteristiquesTable.WidthPercentage = 50;
            caracteristiquesTable.HorizontalAlignment = 0;
            caracteristiquesTable.SpacingBefore = 10f;
            caracteristiquesTable.SpacingAfter = 10f;

            // Ajoutez les en-têtes du tableau de caractéristiques
            caracteristiquesTable.AddCell("Type");
            caracteristiquesTable.AddCell("Base");
            caracteristiquesTable.AddCell("Temporaire");
            caracteristiquesTable.AddCell("Total");

            // Ajout Physique
            caracteristiquesTable.AddCell("Physique");
            caracteristiquesTable.AddCell(basePhysiquePersonnage.ToString());
            caracteristiquesTable.AddCell("");
            caracteristiquesTable.AddCell(basePhysiquePersonnage.ToString());

            // Ajout Mental
            caracteristiquesTable.AddCell("Mental");
            caracteristiquesTable.AddCell(baseMentalPersonnage.ToString());
            caracteristiquesTable.AddCell("");
            caracteristiquesTable.AddCell(baseMentalPersonnage.ToString());

            // Ajout Social
            caracteristiquesTable.AddCell("Social");
            caracteristiquesTable.AddCell(baseSocialPersonnage.ToString());
            caracteristiquesTable.AddCell("");
            caracteristiquesTable.AddCell(baseSocialPersonnage.ToString());

            document.Add(caracteristiquesTable);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="idPersonnage"></param>
        static void AddAttributesTable(Document document, int idPersonnage)
        {
            #region Initialisation des variables
            List<string> nomsAttribut = Controller.AttributsController.GetListNomAttributs(idPersonnage);
            List<string> descriptionsAttribut = Controller.AttributsController.GetListDescriptionAttributs(idPersonnage);
            List<string> typesAttribut = Controller.AttributsController.GetListTypeAttributs(idPersonnage);
            List<string> notesAttributs = Controller.AttributsController.GetListNoteAttributs(idPersonnage);
            #endregion

            PdfPTable attributesTable = new PdfPTable(4);
            attributesTable.WidthPercentage = 100;
            attributesTable.HorizontalAlignment = 0;
            attributesTable.SpacingBefore = 10f;
            attributesTable.SpacingAfter = 10f;

            attributesTable.AddCell("Nom");
            attributesTable.AddCell("Description");
            attributesTable.AddCell("Type");
            attributesTable.AddCell("Note");

            for (int i = 0; i < nomsAttribut.Count; i++)
            {
                attributesTable.AddCell(nomsAttribut[i]);
                attributesTable.AddCell(descriptionsAttribut[i]);
                attributesTable.AddCell(typesAttribut[i]);
                attributesTable.AddCell(notesAttributs[i]);
            }

            document.Add(attributesTable);
        }

        static void AddCompPhysiqueTable(Document document, int idPersonnage)
        {
            #region Initialisation des variables
            int[] baseCompPhys = Controller.CompetencesCaracteristiquesController.GetBaseCompetencePhysique(idPersonnage);
            string[] listeCompPhy = { "Agilité", "Artisanat", "Crochetage", "Discrétion", "Équilibre", "Escalade", "Escamotage", "Force", "Fouille", "Natation", "Réflexes", "Vigueur" };

            #endregion

            PdfPTable compPhyTable = new PdfPTable(4);
            compPhyTable.WidthPercentage = 100;
            compPhyTable.HorizontalAlignment = 0;
            compPhyTable.SpacingBefore = 10f;
            compPhyTable.SpacingAfter = 10f;

            compPhyTable.AddCell("Nom");
            compPhyTable.AddCell("Base");
            compPhyTable.AddCell("Temporaire");
            compPhyTable.AddCell("Total");

            for (int i = 0; i < listeCompPhy.Length; i++)
            {
                compPhyTable.AddCell(listeCompPhy[i]);
                compPhyTable.AddCell(baseCompPhys[i].ToString());
                compPhyTable.AddCell("");
                compPhyTable.AddCell(baseCompPhys[i].ToString());
            }

            document.Add(compPhyTable);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="idPersonnage"></param>
        static void AddCompMentalTable(Document document, int idPersonnage)
        {
            #region Initialisation des variables
            int[] baseCompMen = Controller.CompetencesCaracteristiquesController.GetBaseCompetenceMental(idPersonnage);
            string[] listeCompMen = { "Concentration", "Connaissance géographiques", "Connaissance historiques", "Connaissance magiques", 
                "Connaissance natures", "Connaissance religieuses", "Décryptage", "Esprit", "Explosifs", "Mécanique", "Médecine", "Mémoire", "Perception", "Volonté" };

            #endregion

            PdfPTable compMenTable = new PdfPTable(4);
            compMenTable.WidthPercentage = 100;
            compMenTable.HorizontalAlignment = 0;
            compMenTable.SpacingBefore = 10f;
            compMenTable.SpacingAfter = 10f;

            compMenTable.AddCell("Nom");
            compMenTable.AddCell("Base");
            compMenTable.AddCell("Temporaire");
            compMenTable.AddCell("Total");

            for (int i = 0; i < listeCompMen.Length; i++)
            {
                compMenTable.AddCell(listeCompMen[i]);
                compMenTable.AddCell(baseCompMen[i].ToString());
                compMenTable.AddCell("");
                compMenTable.AddCell(baseCompMen[i].ToString());
            }

            document.Add(compMenTable);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="idPersonnage"></param>
        static void AddCompSocialTable(Document document, int idPersonnage)
        {
            #region Initialisation des variables
            int[] baseCompSoc = Controller.CompetencesCaracteristiquesController.GetBaseCompetenceSocial(idPersonnage);
            string[] listeCompSoc = { "Baratinage", "Charme", "Comédie", "Diplomatie", "Dressage", "Intimidation", "Marchandage", 
                "Prestance", "Provocation"};

            #endregion

            PdfPTable compSocTable = new PdfPTable(4);
            compSocTable.WidthPercentage = 100;
            compSocTable.HorizontalAlignment = 0;
            compSocTable.SpacingBefore = 10f;
            compSocTable.SpacingAfter = 10f;

            compSocTable.AddCell("Nom");
            compSocTable.AddCell("Base");
            compSocTable.AddCell("Temporaire");
            compSocTable.AddCell("Total");

            for (int i = 0; i < listeCompSoc.Length; i++)
            {
                compSocTable.AddCell(listeCompSoc[i]);
                compSocTable.AddCell(baseCompSoc[i].ToString());
                compSocTable.AddCell("");
                compSocTable.AddCell(baseCompSoc[i].ToString());
            }

            document.Add(compSocTable);
        }

        static void AddArmesTable(Document document, int idPersonnage)
        {
            #region Initialisation des variables
            List<string> typesArmes = Controller.EquipmentController.GetListTypeArmes(idPersonnage);
            List<string> nomArmes = Controller.EquipmentController.GetListNomArmes(idPersonnage);
            List<double> poidsArmes = Controller.EquipmentController.GetListPoidsArmes(idPersonnage);
            List<string> allongeArmes = Controller.EquipmentController.GetListAllongeArmes(idPersonnage);
            List<string> mainsArmes = Controller.EquipmentController.GetListMainsArmes(idPersonnage);
            List<string> typesDegatsArmes = Controller.EquipmentController.GetListTypeDegatsArmes(idPersonnage);
            List<string> degatsArmes = Controller.EquipmentController.GetListDegatsArmes(idPersonnage);
            List<string> valeurArmes = Controller.EquipmentController.GetListValeurArmes(idPersonnage);
            List<string> descriptionsArmes = Controller.EquipmentController.GetListDescriptionArmes(idPersonnage);
            List<string> specialsArmes = Controller.EquipmentController.GetListSpecialArmes(idPersonnage);
            #endregion

            PdfPTable armesTable = new PdfPTable(4);
            armesTable.WidthPercentage = 100;
            armesTable.HorizontalAlignment = 0;
            armesTable.SpacingBefore = 10f;
            armesTable.SpacingAfter = 10f;

            armesTable.AddCell("Type");
            armesTable.AddCell("Nom");
            armesTable.AddCell("Poids");
            armesTable.AddCell("Allonge");
            armesTable.AddCell("Main(s)");
            armesTable.AddCell("Type(s) de dégâts");
            armesTable.AddCell("Dégâts");
            armesTable.AddCell("Valeur");
            armesTable.AddCell("Description");
            armesTable.AddCell("Spécial");

            for (int i = 0; i < typesArmes.Count; i++)
            {
                armesTable.AddCell(typesArmes[i]);
                armesTable.AddCell(nomArmes[i]);
                armesTable.AddCell(poidsArmes[i].ToString());
                armesTable.AddCell(allongeArmes[i]);
                armesTable.AddCell(mainsArmes[i]);
                armesTable.AddCell(typesDegatsArmes[i]);
                armesTable.AddCell(degatsArmes[i]);
                armesTable.AddCell(valeurArmes[i]);
                armesTable.AddCell(descriptionsArmes[i]);
                armesTable.AddCell(specialsArmes[i]);
            }

            document.Add(armesTable);
        }
    }
}
