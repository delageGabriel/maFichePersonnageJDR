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
using System.IO;
using Spire.Doc;
using Spire.Doc.Fields;
using Spire.Doc.Documents;
using maFichePersonnageJDR.Classe;
namespace maFichePersonnageJDR
{
    public partial class FrmPrincipal : Form
    {
        private Document documentPdf = new Document();
        public string cheminTemplate = Path.GetFullPath(@"C:\Users\Utilisateur\source\repos\maFichePersonnageJDR\maFichePersonnageJDR\Templates\template_fiche_personnage.docx");
        public string cheminPdf = Path.GetFullPath(@"C:\Users\Utilisateur\source\repos\maFichePersonnageJDR\maFichePersonnageJDR\Templates\template_fiche.pdf");
        public string cheminDocx = Path.GetFullPath(@"C:\Users\Utilisateur\source\repos\maFichePersonnageJDR\maFichePersonnageJDR\Templates\template_fiche.docx");
        public ClasseImage imgAvatar = new ClasseImage();
        public Document DocumentPdf { get => documentPdf; set => documentPdf = value; }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFormCompAttri_Click(object sender, EventArgs e)
        {
            FormulaireCompAttri frmCA = new FormulaireCompAttri();
            frmCA.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnInfosGenerales_Click(object sender, EventArgs e)
        {
            FormulaireInfosGenerales frmIG = new FormulaireInfosGenerales();
            frmIG.Show();
        }

        private void btnTalentEtEquipement_Click(object sender, EventArgs e)
        {
            FormulaireTalentsEtObjets frmTO = new FormulaireTalentsEtObjets();
            frmTO.Show();
        }

        private void btnSoumettreFiche_Click(object sender, EventArgs e)
        {
            documentPdf.LoadFromFile(cheminTemplate);

            Image imageAvtar = imgAvatar.GetUneImage(Properties.Settings.Default.CheminImage);
            Section section = documentPdf.Sections[0];

            Paragraph paragrapheNomPrenom = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeNomPrenom = paragrapheNomPrenom.AppendText(Properties.Settings.Default.Prenom + " " + Properties.Settings.Default.Nom);
            rangeNomPrenom.CharacterFormat.FontSize = 20;
            paragrapheNomPrenom.AppendBreak(BreakType.LineBreak);

            DocPicture imageAEnvoye = paragrapheNomPrenom.AppendPicture(imageAvtar);
            imageAEnvoye.TextWrappingStyle = TextWrappingStyle.Square;
            imageAEnvoye.HorizontalPosition = 300.0F;
            imageAEnvoye.VerticalPosition = 0.0F;

            Paragraph paragrapheSexe
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeSexe = paragrapheSexe.AppendText("Sexe : " + Properties.Settings.Default.Sexe);
            rangeSexe.CharacterFormat.FontSize = 16;
            paragrapheSexe.AppendBreak(BreakType.LineBreak);

            Paragraph paragrapheRace
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeRace = paragrapheRace.AppendText("Race : " + Properties.Settings.Default.Race);
            rangeRace.CharacterFormat.FontSize = 16;
            paragrapheRace.AppendBreak(BreakType.LineBreak);

            Paragraph paragrapheNiveau
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeNiveau = paragrapheNiveau.AppendText("Niveau : " + Properties.Settings.Default.Niveau);
            rangeNiveau.CharacterFormat.FontSize = 16;
            paragrapheNiveau.AppendBreak(BreakType.LineBreak);

            Paragraph paragrapheHistoire
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeHistoireTitre = paragrapheHistoire.AppendText("Histoire : ");
            TextRange rangeHistoire = paragrapheHistoire.AppendText(Properties.Settings.Default.Histoire);
            paragrapheHistoire.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
            rangeHistoireTitre.CharacterFormat.FontSize = 14;
            rangeHistoireTitre.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            rangeHistoire.CharacterFormat.FontSize = 12;
            paragrapheHistoire.AppendBreak(BreakType.LineBreak);

            Paragraph paragrapheLangues
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeLanguesTitre = paragrapheLangues.AppendText("Langue(s) parlée(s) : \n");
            TextRange rangeLangues = paragrapheLangues.AppendText(Properties.Settings.Default.Langues);
            rangeLanguesTitre.CharacterFormat.FontSize = 14;
            rangeLanguesTitre.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            rangeLangues.CharacterFormat.FontSize = 12;
            paragrapheLangues.AppendBreak(BreakType.LineBreak);
            
            Paragraph paragrapheChargeVitesse
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeChargeVitesse = paragrapheChargeVitesse.AppendText("Charge maximum : " +
                Properties.Settings.Default.ChargeMax + ", Vitesse de déplacement : " + Properties.Settings.Default.VitesseDepla);
            rangeChargeVitesse.CharacterFormat.FontSize = 12;
            paragrapheChargeVitesse.AppendBreak(BreakType.LineBreak);

            Paragraph paragrapheMonnaie
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeMonnaie = paragrapheMonnaie.AppendText("Argent possédé : " +
                                                            Properties.Settings.Default.Or + "PO, "
                                                            + Properties.Settings.Default.Argent + "PA, "
                                                            + Properties.Settings.Default.Cuivre + "PC");
            rangeMonnaie.CharacterFormat.FontSize = 12;
            paragrapheMonnaie.AppendBreak(BreakType.LineBreak);
            
            #region tableau_pv_energie
            string[] enTete = { "PV", "Énergie" };
            string[] donnees = { Properties.Settings.Default.PV.ToString(), Properties.Settings.Default.Energie.ToString() };
            Spire.Doc.Table table = section.AddTable(true);
            table.ResetCells(donnees.Length, enTete.Length);
            TableRow row = table.Rows[0];
            TableRow rowDeux = table.Rows[1];
            row.IsHeader = true;
            row.Height = 20;    //unit: point, 1point = 0.3528 mm

            for (int i = 0; i < enTete.Length; i++)
            {
                row.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph p = row.Cells[i].AddParagraph();
                p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                TextRange txtRange = p.AppendText(enTete[i]);
                txtRange.CharacterFormat.Bold = true;
            }
            for (int j = 0; j < donnees.Length; j++)
            {
                rowDeux.Cells[j].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph pDeux = rowDeux.Cells[j].AddParagraph();
                pDeux.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                TextRange txtRange = pDeux.AppendText(donnees[j]);
                txtRange.CharacterFormat.Bold = true;
            }
            #endregion

            Paragraph paragrapheVide = section.AddParagraph();

            #region tableau_caracteristiques
            string[] enTeteCaracteristiques = { "Physique", "Mental", "Social" };
            string[] donneesCaracteristiques = { Properties.Settings.Default.Physique.ToString(), 
                Properties.Settings.Default.Mental.ToString(), 
                Properties.Settings.Default.Social.ToString() };
            Spire.Doc.Table tableCaracteristiques = section.AddTable(true);
            tableCaracteristiques.ResetCells(2, enTeteCaracteristiques.Length);
            TableRow rowCaracteristiques = tableCaracteristiques.Rows[0];
            TableRow rowDeuxCaracteristiques = tableCaracteristiques.Rows[1];
            rowCaracteristiques.IsHeader = true;
            rowCaracteristiques.Height = 20;    //unit: point, 1point = 0.3528 mm

            for (int x = 0; x < enTeteCaracteristiques.Length; x++)
            {
                rowCaracteristiques.Cells[x].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph pCaracteristiques = rowCaracteristiques.Cells[x].AddParagraph();
                pCaracteristiques.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                TextRange txtRange = pCaracteristiques.AppendText(enTeteCaracteristiques[x]);
                txtRange.CharacterFormat.Bold = true;
            }
            for (int y = 0; y < donneesCaracteristiques.Length; y++)
            {
                rowDeuxCaracteristiques.Cells[y].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph p = rowDeuxCaracteristiques.Cells[y].AddParagraph();
                p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                TextRange txtRange = p.AppendText(donneesCaracteristiques[y]);
                txtRange.CharacterFormat.Bold = true;
            }
            #endregion

            #region caracteristiques
            Paragraph paragraphCaracteristique = section.AddParagraph();
            TextRange rangeAdresse = paragraphCaracteristique.AppendText("Adresse : " + Properties.Settings.Default.Dexterite);
            TextRange rangeExplosifs = paragraphCaracteristique.AppendText("\t\t\t\tExplosifs : " + Properties.Settings.Default.Explosifs + "\n");
            TextRange rangeAgilite = paragraphCaracteristique.AppendText("Agilité : " + Properties.Settings.Default.Agilité);
            TextRange rangeForce = paragraphCaracteristique.AppendText("\t\t\t\tForce : " + Properties.Settings.Default.Force + "\n");
            TextRange rangeAnimale = paragraphCaracteristique.AppendText("Animale : " + Properties.Settings.Default.Dressage);
            TextRange rangeIntimidation = paragraphCaracteristique.AppendText("\t\t\t\tIntimidation : " + Properties.Settings.Default.Intimidation + "\n");
            TextRange rangeArtisanat = paragraphCaracteristique.AppendText("Artisanat : " + Properties.Settings.Default.Artisanat);
            TextRange rangeLangages = paragraphCaracteristique.AppendText("\t\t\t\tLangages : " + Properties.Settings.Default.Decryptage + "\n");
            TextRange rangeBotanique = paragraphCaracteristique.AppendText("Botanique : " + Properties.Settings.Default.ConnNature);
            TextRange rangeMécanique = paragraphCaracteristique.AppendText("\t\t\t\tMécanique : " + Properties.Settings.Default.Mecanique + "\n");
            TextRange rangeCharme = paragraphCaracteristique.AppendText("\t\t\t\tCharme : " + Properties.Settings.Default.Charme + "\n");
            TextRange rangeCnGeo = paragraphCaracteristique.AppendText("Connaissances géographiques : " + Properties.Settings.Default.ConnGeographiques);
            TextRange rangeMedecine = paragraphCaracteristique.AppendText("\tMédecine : " + Properties.Settings.Default.Medecine + "\n");
            TextRange rangeCnHist = paragraphCaracteristique.AppendText("Connaissances historiques : " + Properties.Settings.Default.ConnHistoriques);
            TextRange rangeNatation = paragraphCaracteristique.AppendText("\t\tNatation : " + Properties.Settings.Default.Natation + "\n");
            TextRange rangeCnMag = paragraphCaracteristique.AppendText("Connaissances magiques : " + Properties.Settings.Default.ConnMagiques);
            TextRange rangePerception = paragraphCaracteristique.AppendText("\t\tPerception : " + Properties.Settings.Default.Perception + "\n");
            TextRange rangeCnReg = paragraphCaracteristique.AppendText("Connaissances religieuses : " + Properties.Settings.Default.ConnReligieuses);
            TextRange rangePerspicacite = paragraphCaracteristique.AppendText("\t\tPerspicacité : " + Properties.Settings.Default.Perspicacité + "\n");
            TextRange rangeCrochetage = paragraphCaracteristique.AppendText("Crochetage : " + Properties.Settings.Default.Crochetage);
            TextRange rangePersuasion = paragraphCaracteristique.AppendText("\t\t\t\tPersuasion : " + Properties.Settings.Default.Persuasion + "\n");
            TextRange rangeDiplomatie = paragraphCaracteristique.AppendText("Diplomatie : " + Properties.Settings.Default.Diplomatie);
            TextRange rangePsyche = paragraphCaracteristique.AppendText("\t\t\t\tPsyché : " + Properties.Settings.Default.Esprit + "\n");
            TextRange rangeDiscretion = paragraphCaracteristique.AppendText("Discrétion : " + Properties.Settings.Default.Discretion);
            TextRange rangeReflexes = paragraphCaracteristique.AppendText("\t\t\t\tRéflexes : " + Properties.Settings.Default.Reflexes + "\n");
            TextRange rangeEndurance = paragraphCaracteristique.AppendText("Endurance : " + Properties.Settings.Default.Endurance);
            TextRange rangeVigueur = paragraphCaracteristique.AppendText("\t\t\t\tVigueur : " + Properties.Settings.Default.Vigueur + "\n");
            TextRange rangeEscalade = paragraphCaracteristique.AppendText("Escalade : " + Properties.Settings.Default.Escalade);
            TextRange rangeVolonte = paragraphCaracteristique.AppendText("\t\t\t\tVolonté : " + Properties.Settings.Default.Volonte + "\n");
            #endregion

            Paragraph paragraphAttribut = section.AddParagraph();
            TextRange rangeAttributTitre = paragraphAttribut.AppendText("Attributs : \n");
            TextRange rangeAttributs = paragraphAttribut.AppendText(Properties.Settings.Default.Attributs);
            rangeAttributTitre.CharacterFormat.FontSize = 14;
            rangeAttributTitre.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            paragraphAttribut.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
            paragraphAttribut.AppendBreak(BreakType.LineBreak);

            Paragraph paragraphObjets = section.AddParagraph();
            TextRange rangeObjetsTitre = paragraphObjets.AppendText("Inventaires : \n");
            TextRange rangeObjets = paragraphObjets.AppendText(Properties.Settings.Default.Inventaires);
            rangeObjetsTitre.CharacterFormat.FontSize = 14;
            rangeObjetsTitre.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            paragraphObjets.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;
            paragraphObjets.AppendBreak(BreakType.LineBreak);

            Paragraph paragraphSortileges = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeSortilegesTitres = paragraphObjets.AppendText("Sortilèges : \n");
            TextRange rangeSortileges = paragraphObjets.AppendText(Properties.Settings.Default.Sortilèges);
            rangeSortilegesTitres.CharacterFormat.FontSize = 14;
            rangeSortilegesTitres.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            paragraphSortileges.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Justify;

            // Enregistrer le fichier doc.  
            documentPdf.SaveToFile(cheminDocx, FileFormat.Docx);
            // Convertir en PDF  
            documentPdf.SaveToFile(cheminPdf, FileFormat.PDF);
            MessageBox.Show("Toutes les tâches sont terminées.", "Traitement des documents", MessageBoxButtons.OK, MessageBoxIcon.Information);
            documentPdf.Close();
        }
    }
}