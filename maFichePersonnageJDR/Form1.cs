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
using maFichePersonnageJDR.Controller;
using System.Windows;

namespace maFichePersonnageJDR
{
    public partial class FrmPrincipal : Form
    {
        private Document documentPdf = new Document();
        public string cheminTemplate = Path.GetFullPath(@"Templates\template_fiche_personnage.docx");
        public string cheminPdf = Path.GetFullPath(@"Templates\template_fiche.pdf");
        public string cheminDocx = Path.GetFullPath(@"Templates\template_fiche.docx");
        public ClasseImage imgAvatar = new ClasseImage();
        public Document DocumentPdf { get => documentPdf; set => documentPdf = value; }
        int[] tableauBaseNormaleExp = { 0,
            3000,
            9650,
            18490,
            30255,
            45900,
            66710,
            94385,
            131190,
            180145,
            245250,
            331845,
            447015,
            600190,
            803915,
            1074865,
            1435235,
            1914520,
            2551975,
            3399785
        };
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public bool PairOuImpair(int chiffre)
        {
            bool retour = false;

            int[] tableauPair = new int[]{0,
                2,
                4,
                6,
                8,
                10,
                12,
                14,
                16,
                18,
                20,
                22,
                24,
                26,
                28,
                30,
                32,
                34,
                36,
                38,
                40,
                42,
                44,
                46,
                48,
                50,
                52,
                54,
                56,
                58,
                60,
                62,
                64,
                66,
                68,
                70,
                72,
                74,
                76,
                78,
                80
            };

            int[] tableauImpair = new int[]{
                1,
                3,
                5,
                7,
                9,
                11,
                13,
                15,
                17,
                19,
                21,
                23,
                25,
                27,
                29,
                31,
                33,
                35,
                37,
                39,
                41,
                43,
                45,
                47,
                49,
                51,
                53,
                55,
                57,
                59,
                61,
                63,
                65,
                67,
                69,
                71,
                73,
                75,
                77,
                79,
                81
            };

            for (int i = 0; i < tableauPair.Length; i++)
            {
                if (tableauPair[i].Equals(chiffre))
                {
                    retour = true;
                    break;
                }
            }
            for (int i = 0; i < tableauImpair.Length; i++)
            {
                if (tableauImpair[i].Equals(chiffre))
                {
                    retour = false;
                    break;
                }
            }
            return retour;
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
            pbEtatFiche.Value = 0;
            
            int nbPv = Properties.Settings.Default.PV + (Properties.Settings.Default.Vigueur / 3);
            int nbEnergie = Properties.Settings.Default.Energie + (Properties.Settings.Default.Esprit / 3);
            int niveauPersonnage = Properties.Settings.Default.Niveau;

            // Calcul supplémentaire des pv et de l'énergie si le personnage n'est pas niveau 1
            if(niveauPersonnage > 1)
            {
                int nbDes = niveauPersonnage - 1;
                int valeurPV = FicheSortieController.GetPVEnergiePersonnage(Properties.Settings.Default.Vigueur);
                int valeurEnergie = FicheSortieController.GetPVEnergiePersonnage(Properties.Settings.Default.Esprit);

                nbPv += FicheSortieController.CalculPVEnergiePersonnage(nbDes, valeurPV);
                nbEnergie += FicheSortieController.CalculPVEnergiePersonnage(nbDes, valeurEnergie);
            }
            
            documentPdf.LoadFromFile(cheminTemplate);

            #region general
            Image imageAvtar = imgAvatar.GetUneImage(Properties.Settings.Default.CheminImage);
            Section section = documentPdf.Sections[0];

            Paragraph paragrapheNomPrenom = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeNomPrenom = paragrapheNomPrenom.AppendText(Properties.Settings.Default.Prenom + " " + Properties.Settings.Default.Nom);
            rangeNomPrenom.CharacterFormat.FontSize = 24;
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
            rangeHistoireTitre.CharacterFormat.FontSize = 14;
            rangeHistoireTitre.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            rangeHistoire.CharacterFormat.FontSize = 12;
            paragrapheHistoire.AppendBreak(BreakType.LineBreak);

            Paragraph paragrapheLangues
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeLanguesTitre = paragrapheLangues.AppendText("Langue(s) : \n");
            TextRange rangeLangues = paragrapheLangues.AppendText(Properties.Settings.Default.Langues);
            rangeLanguesTitre.CharacterFormat.FontSize = 14;
            rangeLanguesTitre.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;
            rangeLangues.CharacterFormat.FontSize = 12;
            paragrapheLangues.AppendBreak(BreakType.LineBreak);

            Paragraph paragrapheChargeVitesse
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeChargeVitesse = paragrapheChargeVitesse.AppendText("Charge : " +
                Properties.Settings.Default.ChargePortee + "/" + Properties.Settings.Default.ChargeMax + " kg"
                + ", Vitesse de déplacement : " + Properties.Settings.Default.VitesseDepla + " m");
            rangeChargeVitesse.CharacterFormat.FontSize = 12;
            paragrapheChargeVitesse.AppendBreak(BreakType.LineBreak);

            Paragraph paragrapheMonnaie
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeMonnaie = paragrapheMonnaie.AppendText("Argent possédé : " +
                                                            Properties.Settings.Default.Or + " PO, "
                                                            + Properties.Settings.Default.Argent + " PA, "
                                                            + Properties.Settings.Default.Cuivre + " PC");
            rangeMonnaie.CharacterFormat.FontSize = 12;
            paragrapheMonnaie.AppendBreak(BreakType.LineBreak);

            Paragraph paragrapheExperience
                = section.Paragraphs.Count > 0 ? section.Paragraphs[0] : section.AddParagraph();
            TextRange rangeExp = paragrapheExperience.AppendText("Points d'expérience : "
                + Properties.Settings.Default.PointsExp.ToString() + "/"
                + tableauBaseNormaleExp[Properties.Settings.Default.Niveau].ToString());

            rangeMonnaie.CharacterFormat.FontSize = 12;
            paragrapheExperience.AppendBreak(BreakType.LineBreak);
            #endregion

            pbEtatFiche.Value += 25;
            #region tableau_pv_energie
            string[] enTete = { "PV", "Énergie" };
            string[] donnees = { nbPv.ToString(), nbEnergie.ToString() };
            Spire.Doc.Table table = section.AddTable(true);
            table.ResetCells(donnees.Length, enTete.Length);
            TableRow row = table.Rows[0];
            TableRow rowDeux = table.Rows[1];
            row.IsHeader = true;
            row.Height = 10;    //unit: point, 1point = 0.3528 mm

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
            Spire.Doc.Table headerTableCaracteristique = section.AddTable(true);
            headerTableCaracteristique.ResetCells(1, 1);

            TableRow rowHeaderCaracteristique = headerTableCaracteristique.Rows[0];

            rowHeaderCaracteristique.Height = 20;

            rowHeaderCaracteristique.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            Paragraph pHeaderCaracteristique = rowHeaderCaracteristique.Cells[0].AddParagraph();
            pHeaderCaracteristique.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
            TextRange txtRangeHeaderCaracteristiques = pHeaderCaracteristique.AppendText("Caractéristiques");
            txtRangeHeaderCaracteristiques.CharacterFormat.FontSize = 20f;
            txtRangeHeaderCaracteristiques.CharacterFormat.Bold = true;

            string[] enTeteCaracteristiques = { "Physique", "Mental", "Social" };
            string[] donneesCaracteristiques = { Properties.Settings.Default.Physique.ToString(),
                Properties.Settings.Default.Mental.ToString(),
                Properties.Settings.Default.Social.ToString() };
            Spire.Doc.Table tableCaracteristiques = section.AddTable(true);
            tableCaracteristiques.ResetCells(2, enTeteCaracteristiques.Length);
            TableRow rowCaracteristiques = tableCaracteristiques.Rows[0];
            TableRow rowDeuxCaracteristiques = tableCaracteristiques.Rows[1];
            rowCaracteristiques.IsHeader = true;
            rowCaracteristiques.Height = 10;    //unit: point, 1point = 0.3528 mm

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
            pbEtatFiche.Value += 25;
            Paragraph paragrapheVideDeux = section.AddParagraph();

            #region competences
            int nbLigne = 12;
            int nbColonnes = 6;
            string[] nomsCompetences = {
                "Agilité",
                "Artisanat",
                "Baratinage",
                "Charme",
                "Comédie",
                "Concentration",
                "Conn. Géographiques",
                "Conn. Historiques",
                "Conn. Magiques",
                "Conn. Natures",
                "Conn. Religieuses",
                "Crochetage",
                "Décryptage",
                "Dextérité",
                "Diplomatie",
                "Discrétion",
                "Dressage",
                "Équilibre",
                "Escalade",
                "Esprit",
                "Escamotage",
                "Explosifs",
                "Force",
                "Intimidation",
                "Marchandage",
                "Mécanique",
                "Médecine",
                "Mémoire",
                "Natation",
                "Perception",
                "Perspicacité",
                "Prestance",
                "Provocation",
                "Réflexes",
                "Vigueur",
                "Volonté"
            };
            string[] pointsCompetences = {
                Properties.Settings.Default.Agilité.ToString(),
                Properties.Settings.Default.Artisanat.ToString(),
                Properties.Settings.Default.Baratinage.ToString(),
                Properties.Settings.Default.Charme.ToString(),
                Properties.Settings.Default.Comédie.ToString(),
                Properties.Settings.Default.Concentration.ToString(),
                Properties.Settings.Default.ConnGeographiques.ToString(),
                Properties.Settings.Default.ConnHistoriques.ToString(),
                Properties.Settings.Default.ConnMagiques.ToString(),
                Properties.Settings.Default.ConnNature.ToString(),
                Properties.Settings.Default.ConnReligieuses.ToString(),
                Properties.Settings.Default.Crochetage.ToString(),
                Properties.Settings.Default.Decryptage.ToString(),
                Properties.Settings.Default.Dexterite.ToString(),
                Properties.Settings.Default.Diplomatie.ToString(),
                Properties.Settings.Default.Discretion.ToString(),
                Properties.Settings.Default.Dressage.ToString(),
                Properties.Settings.Default.Equilibre.ToString(),
                Properties.Settings.Default.Escalade.ToString(),
                Properties.Settings.Default.Esprit.ToString(),
                Properties.Settings.Default.Escamotage.ToString(),
                Properties.Settings.Default.Explosifs.ToString(),
                Properties.Settings.Default.Force.ToString(),
                Properties.Settings.Default.Intimidation.ToString(),
                Properties.Settings.Default.Marchandage.ToString(),
                Properties.Settings.Default.Mecanique.ToString(),
                Properties.Settings.Default.Medecine.ToString(),
                Properties.Settings.Default.Memoire.ToString(),
                Properties.Settings.Default.Natation.ToString(),
                Properties.Settings.Default.Perception.ToString(),
                Properties.Settings.Default.Perspicacité.ToString(),
                Properties.Settings.Default.Prestance.ToString(),
                Properties.Settings.Default.Provocation.ToString(),
                Properties.Settings.Default.Reflexes.ToString(),
                Properties.Settings.Default.Vigueur.ToString(),
                Properties.Settings.Default.Volonte.ToString(),
            };
            Spire.Doc.Table headerTableCompetence = section.AddTable(true);
            Spire.Doc.Table tableCompetences = section.AddTable(true);
            headerTableCompetence.ResetCells(1, 1);
            tableCompetences.ResetCells(nbLigne, nbColonnes);

            TableRow rowHeaderCompetence = headerTableCompetence.Rows[0];
            TableRow rowCompetences = tableCompetences.Rows[0];

            rowHeaderCompetence.Height = 20;
            rowCompetences.Height = 12;    //unit: point, 1point = 0.3528 mm

            rowHeaderCompetence.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            Paragraph pHeaderCompetences = rowHeaderCompetence.Cells[0].AddParagraph();
            pHeaderCompetences.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
            TextRange txtRangeHeaderCompetences = pHeaderCompetences.AppendText("Compétences");
            txtRangeHeaderCompetences.CharacterFormat.FontSize = 20f;
            txtRangeHeaderCompetences.CharacterFormat.Bold = true;

            int cpt = 0;
            int cptNom = 0;
            int cptPoints = 0;
            int indiceNbLigne = 0;
            int indice = 0;

            while (cpt < (nomsCompetences.Length + pointsCompetences.Length) - 2)
            {
                if (indiceNbLigne > tableCompetences.Rows.Count - 1)
                    break;
                TableRow tableRow = tableCompetences.Rows[indiceNbLigne];
                while (indice < 6)
                {
                    if (!PairOuImpair(cpt))
                    {
                        if (cptPoints > pointsCompetences.Length - 1)
                        {
                            cpt++;
                            break;
                        }
                        tableRow.Cells[indice].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        Paragraph p = tableRow.Cells[indice].AddParagraph();
                        p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        TextRange txtRange = p.AppendText(pointsCompetences[cptPoints]);
                        cpt++;
                        cptPoints++;
                        indice++;
                    }
                    else if (PairOuImpair(cpt))
                    {
                        if (cptNom > nomsCompetences.Length - 1)
                        {
                            cpt++;
                            break;
                        }
                        tableRow.Cells[indice].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        Paragraph p = tableRow.Cells[indice].AddParagraph();
                        p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                        TextRange txtRange = p.AppendText(nomsCompetences[cptNom]);
                        txtRange.CharacterFormat.Bold = true;
                        cpt++;
                        cptNom++;
                        indice++;
                    }
                    else
                    {
                        indiceNbLigne++;
                    }
                }
                indiceNbLigne++;
                indice = 0;
            }
            #endregion

            Paragraph paragrapheVideTrois = section.AddParagraph();

            #region attribut
            Spire.Doc.Table headerTableAttribut = section.AddTable(true);
            Spire.Doc.Table tableAttribut = section.AddTable(true);
            headerTableAttribut.ResetCells(1, 1);
            tableAttribut.ResetCells(1, 1);

            TableRow rowHeaderAttribut = headerTableAttribut.Rows[0];
            TableRow rowAttribut = tableAttribut.Rows[0];

            rowHeaderAttribut.Height = 20;

            rowHeaderAttribut.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            Paragraph pHeaderAttribut = rowHeaderAttribut.Cells[0].AddParagraph();
            pHeaderAttribut.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
            TextRange txtRangeHeaderAttribut = pHeaderAttribut.AppendText("Attributs");
            txtRangeHeaderAttribut.CharacterFormat.FontSize = 20f;
            txtRangeHeaderAttribut.CharacterFormat.Bold = true;

            Paragraph paragraphAttribut = rowAttribut.Cells[0].AddParagraph();
            TextRange rangeAttributs = paragraphAttribut.AppendText(Properties.Settings.Default.Attributs);

            #endregion
            pbEtatFiche.Value += 25;
            Paragraph paragrapheVideQuatre = section.AddParagraph();

            #region inventaire
            string[] inventairePersonnage = Properties.Settings.Default.Inventaires.Split('\n');

            Spire.Doc.Table headerTableInventaire = section.AddTable(true);
            Spire.Doc.Table tableInventaire = section.AddTable(true);
            headerTableInventaire.ResetCells(1, 6);
            tableInventaire.ResetCells(inventairePersonnage.Length, 6);

            TableRow rowHeaderInventaire = headerTableInventaire.Rows[0];
            TableRow rowInventaire = tableInventaire.Rows[0];

            rowHeaderInventaire.Height = 20;

            rowHeaderInventaire.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            Paragraph pHeaderInventaire = rowHeaderInventaire.Cells[0].AddParagraph();
            pHeaderInventaire.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
            TextRange txtRangeHeaderInventaire = pHeaderInventaire.AppendText("Inventaire");
            txtRangeHeaderInventaire.CharacterFormat.FontSize = 20f;
            txtRangeHeaderInventaire.CharacterFormat.Bold = true;

            Paragraph paragraphInventaire = rowInventaire.Cells[0].AddParagraph();
            TextRange rangeInventaire = paragraphInventaire.AppendText(Properties.Settings.Default.Inventaires);


            #endregion

            Paragraph paragrapheVideCinq = section.AddParagraph();

            #region sortileges

            Spire.Doc.Table headerTableSortileges = section.AddTable(true);
            Spire.Doc.Table tableSortileges = section.AddTable(true);
            headerTableSortileges.ResetCells(1, 1);
            tableSortileges.ResetCells(1, 1);

            TableRow rowHeaderSortileges = headerTableSortileges.Rows[0];
            TableRow rowSortileges = tableSortileges.Rows[0];

            rowHeaderSortileges.Height = 20;

            rowHeaderSortileges.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            Paragraph pHeaderSortileges = rowHeaderSortileges.Cells[0].AddParagraph();
            pHeaderSortileges.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
            TextRange txtRangeHeaderSortileges = pHeaderSortileges.AppendText("Sortilèges & Aptitudes");
            txtRangeHeaderSortileges.CharacterFormat.FontSize = 20f;
            txtRangeHeaderSortileges.CharacterFormat.Bold = true;

            Paragraph paragraphSortileges = rowSortileges.Cells[0].AddParagraph();
            TextRange rangeSortileges = paragraphSortileges.AppendText(Properties.Settings.Default.Sortilèges);
            #endregion

            // Enregistrer le fichier doc.  
            documentPdf.SaveToFile(cheminDocx, FileFormat.Docx);
            // Convertir en PDF  
            documentPdf.SaveToFile(cheminPdf, FileFormat.PDF);
            pbEtatFiche.Value += 25;
            MessageBox.Show("Toutes les tâches sont terminées.", "Traitement des documents", MessageBoxButtons.OK, MessageBoxIcon.Information);
            documentPdf.Close();
        }

        private void btnEquipments_Click(object sender, EventArgs e)
        {
            FormulaireEquipments frmEquipment = new FormulaireEquipments();
            frmEquipment.Show();
        }
    }
}