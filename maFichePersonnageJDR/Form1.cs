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

namespace maFichePersonnageJDR
{
    public partial class FrmPrincipal : Form
    {
        private Document documentPdf = new Document();
        public string cheminTemplate = Path.GetFullPath(@"C:\Users\Utilisateur\source\repos\maFichePersonnageJDR\maFichePersonnageJDR\Templates\template_fiche_personnage.docx");
        public string cheminPdf = Path.GetFullPath(@"C:\Users\Utilisateur\source\repos\maFichePersonnageJDR\maFichePersonnageJDR\Templates\template_fiche.pdf");
        public string cheminDocx = Path.GetFullPath(@"C:\Users\Utilisateur\source\repos\maFichePersonnageJDR\maFichePersonnageJDR\Templates\template_fiche.docx");

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

            Section section = documentPdf.Sections[0];
            Paragraph paragraphe
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeNomPrenom = paragraphe.AppendText(Properties.Settings.Default.Nom + " " + Properties.Settings.Default.Prenom);
            rangeNomPrenom.CharacterFormat.FontSize = 20;
            paragraphe = section.AddParagraph();

            TextRange rangeSexe = paragraphe.AppendText("Sexe : " + Properties.Settings.Default.Sexe);
            rangeSexe.CharacterFormat.FontSize = 16;
            paragraphe = section.AddParagraph();

            TextRange rangeRace = paragraphe.AppendText("Race : " + Properties.Settings.Default.Race);
            rangeRace.CharacterFormat.FontSize = 16;
            paragraphe = section.AddParagraph();

            TextRange rangeNiveau = paragraphe.AppendText("Niveau : " + Properties.Settings.Default.Niveau);
            rangeNiveau.CharacterFormat.FontSize = 16;
            paragraphe = section.AddParagraph();

            TextRange rangeHistoire = paragraphe.AppendText("Histoire : \n" + Properties.Settings.Default.Histoire);
            rangeHistoire.CharacterFormat.FontSize = 12;
            paragraphe = section.AddParagraph();

            TextRange rangeLangues = paragraphe.AppendText("Langue(s) parlée(s) : \n" + Properties.Settings.Default.Langues);
            rangeLangues.CharacterFormat.FontSize = 12;
            paragraphe = section.AddParagraph();

            TextRange rangeChargeVitesse = paragraphe.AppendText(Properties.Settings.Default.ChargeMax + " " + Properties.Settings.Default.VitesseDepla);
            rangeChargeVitesse.CharacterFormat.FontSize = 12;
            paragraphe = section.AddParagraph();

            TextRange rangeMonnaie = paragraphe.AppendText("Argent possédé : " +
                                                            Properties.Settings.Default.Or + "PO, "
                                                            + Properties.Settings.Default.Argent + "PA, "
                                                            + Properties.Settings.Default.Cuivre + "PC");
            rangeMonnaie.CharacterFormat.FontSize = 12;
            paragraphe = section.AddParagraph();

            #region tableau_pv_energie
            string[] enTete = { "PV", "Énergie" };
            string[] donnees = { Properties.Settings.Default.PV, Properties.Settings.Default.Energie };
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

            #region tableau_caracteristiques
            string[] enTeteCaracteristiques = { "Physique", "Mental", "Social" };
            string[] donneesCaracteristiques = { Properties.Settings.Default.Physique, Properties.Settings.Default.Mental, Properties.Settings.Default.Social };
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
            TextRange rangeAdresse = paragraphCaracteristique.AppendText("\tAdresse : " + Properties.Settings.Default.Adresse);
            TextRange rangeExplosifs = paragraphCaracteristique.AppendText("\t\t\t\tExplosifs : " + Properties.Settings.Default.Explosifs + "\n");
            TextRange rangeAgilite = paragraphCaracteristique.AppendText("\tAgilité : " + Properties.Settings.Default.Agilité);
            TextRange rangeForce = paragraphCaracteristique.AppendText("\t\t\t\tForce : " + Properties.Settings.Default.Force + "\n");
            TextRange rangeAnimale = paragraphCaracteristique.AppendText("\tAnimale : " + Properties.Settings.Default.Animale);
            TextRange rangeIntimidation = paragraphCaracteristique.AppendText("\t\t\t\tIntimidation : " + Properties.Settings.Default.Intimidation + "\n");
            TextRange rangeArtisanat = paragraphCaracteristique.AppendText("\tArtisanat : " + Properties.Settings.Default.Artisanat);
            TextRange rangeLangages = paragraphCaracteristique.AppendText("\t\t\t\tLangages : " + Properties.Settings.Default.Langages + "\n");
            TextRange rangeBotanique = paragraphCaracteristique.AppendText("\tBotanique : " + Properties.Settings.Default.Botanique);
            TextRange rangeMécanique = paragraphCaracteristique.AppendText("\t\t\t\tMécanique : " + Properties.Settings.Default.Mecanique + "\n");
            TextRange rangeCnGeo = paragraphCaracteristique.AppendText("\tConnaissances géographiques : " + Properties.Settings.Default.ConnGeographiques);
            TextRange rangeMedecine = paragraphCaracteristique.AppendText("\tMédecine : " + Properties.Settings.Default.Medecine + "\n");
            TextRange rangeCnHist = paragraphCaracteristique.AppendText("\tConnaissances historiques : " + Properties.Settings.Default.ConnHistoriques);
            TextRange rangeNatation = paragraphCaracteristique.AppendText("\t\tNatation : " + Properties.Settings.Default.Natation + "\n");
            TextRange rangeCnMag = paragraphCaracteristique.AppendText("\tConnaissances magiques : " + Properties.Settings.Default.ConnMagiques);
            TextRange rangePerception = paragraphCaracteristique.AppendText("\t\tPerception : " + Properties.Settings.Default.Perception + "\n");
            TextRange rangeCnReg = paragraphCaracteristique.AppendText("\tConnaissances religieuse : " + Properties.Settings.Default.ConnReligieuses);
            TextRange rangePerspicacite = paragraphCaracteristique.AppendText("\t\tPerspicacité : " + Properties.Settings.Default.Perspicacité + "\n");
            TextRange rangeCrochetage = paragraphCaracteristique.AppendText("\tCrochetage : " + Properties.Settings.Default.Crochetage);
            TextRange rangePersuasion = paragraphCaracteristique.AppendText("\t\t\t\tPersuasion : " + Properties.Settings.Default.Persuasion + "\n");
            TextRange rangeDiplomatie = paragraphCaracteristique.AppendText("\tDiplomatie : " + Properties.Settings.Default.Diplomatie);
            TextRange rangePsyche = paragraphCaracteristique.AppendText("\t\t\t\tPsyché : " + Properties.Settings.Default.Psyche + "\n");
            TextRange rangeDiscretion = paragraphCaracteristique.AppendText("\tDiscrétion : " + Properties.Settings.Default.Discretion);
            TextRange rangeReflexes = paragraphCaracteristique.AppendText("\t\t\t\tRéflexes : " + Properties.Settings.Default.Reflexes + "\n");
            TextRange rangeEndurance = paragraphCaracteristique.AppendText("\tEndurance : " + Properties.Settings.Default.Endurance);
            TextRange rangeVigueur = paragraphCaracteristique.AppendText("\t\t\t\tVigueur : " + Properties.Settings.Default.Vigueur + "\n");
            TextRange rangeEscalade = paragraphCaracteristique.AppendText("\tEscalade : " + Properties.Settings.Default.Escalade);
            TextRange rangeVolonte = paragraphCaracteristique.AppendText("\t\t\t\tVolonté : " + Properties.Settings.Default.Volonte + "\n");
            #endregion

            Paragraph paragraphAttribut = section.AddParagraph();
            TextRange rangeAttributs = paragraphAttribut.AppendText("Attributs : \n" +
                                                                    Properties.Settings.Default.Attributs);
            Paragraph paragraphObjets = section.AddParagraph();
            TextRange rangeObjets = paragraphObjets.AppendText("Inventaires : \n" +
                                                                Properties.Settings.Default.Inventaires);
            Paragraph paragraphSortileges = section.AddParagraph();
            TextRange rangeSortileges = paragraphObjets.AppendText("Sortilèges : \n" +
                                                                Properties.Settings.Default.Sortilèges);
            // Enregistrer le fichier doc.  
            documentPdf.SaveToFile(cheminDocx, FileFormat.Docx);
            // Convertir en PDF  
            documentPdf.SaveToFile(cheminPdf, FileFormat.PDF);
            MessageBox.Show("Toutes les tâches sont terminées.", "Traitement des documents", MessageBoxButtons.OK, MessageBoxIcon.Information);
            documentPdf.Close();
        }
    }
}