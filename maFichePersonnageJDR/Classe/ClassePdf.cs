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
            // Créez un document PDF
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("fiche_personnage.pdf", FileMode.Create));

            document.Open();

            // Ajoutez une image du personnage
            Image image = Image.GetInstance("image_personnage.png"); // Remplacez "image_personnage.png" par le chemin de votre image
            image.ScaleToFit(100f, 100f);
            image.Alignment = Image.ALIGN_TOP;
            document.Add(image);

            // Ajoutez les informations de base (prénom, nom, race, niveau, sexe)
            AddFormField(document, writer, "Prénom :", 200f);
            AddFormField(document, writer, "Nom :", 200f);
            AddFormField(document, writer, "Race :", 200f);
            AddFormField(document, writer, "Niveau :", 200f);
            AddFormField(document, writer, "Sexe :", 200f);

            // Ajoutez les points d'expérience
            AddFormField(document, writer, "Points acquis :", 200f);
            AddFormField(document, writer, "Points à acquérir :", 200f);

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

            // Ajoutez l'histoire du personnage
            AddFormField(document, writer, "Histoire :", 400f);

            // Ajoutez les attributs
            AddAttributesTable(document);

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

        static void AddAttributesTable(Document document)
        {
            PdfPTable attributesTable = new PdfPTable(4);
            attributesTable.WidthPercentage = 100;
            attributesTable.HorizontalAlignment = 0;
            attributesTable.SpacingBefore = 10f;
            attributesTable.SpacingAfter = 10f;

            string[] attributes = { "Force", "Intelligence", "Charisme" };

            attributesTable.AddCell("Nom");
            attributesTable.AddCell("Description");
            attributesTable.AddCell("Type");
            attributesTable.AddCell("Note");

            foreach (var attribute in attributes)
            {
                attributesTable.AddCell(attribute);
                attributesTable.AddCell("Description " + attribute);
                attributesTable.AddCell("Type " + attribute);
                attributesTable.AddCell("Note " + attribute);
            }

            document.Add(attributesTable);
        }
    }
}
