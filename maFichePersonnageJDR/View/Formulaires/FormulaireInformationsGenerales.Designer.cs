
namespace maFichePersonnageJDR.Formulaires
{
    partial class FormulaireInfosGenerales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel pnlAttributs;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaireInfosGenerales));
            this.rtbAttributs = new System.Windows.Forms.RichTextBox();
            this.cbbTrier = new System.Windows.Forms.ComboBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.TxtBoxRace = new System.Windows.Forms.TextBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblNiveau = new System.Windows.Forms.Label();
            this.rtbHistoire = new System.Windows.Forms.RichTextBox();
            this.lblHistoire = new System.Windows.Forms.Label();
            this.lblLangages = new System.Windows.Forms.Label();
            this.btnSaveInfos = new System.Windows.Forms.Button();
            this.nudNiveau = new System.Windows.Forms.NumericUpDown();
            this.tabCtrlGeneral = new System.Windows.Forms.TabControl();
            this.tabPgeInfosGenerales = new System.Windows.Forms.TabPage();
            this.pnlInfosGenerales = new System.Windows.Forms.Panel();
            this.lblSexe = new System.Windows.Forms.Label();
            this.txtBxLanguesParlees = new System.Windows.Forms.TextBox();
            this.tabPgeAttributs = new System.Windows.Forms.TabPage();
            this.tabPgeCaracteristiquesCompetences = new System.Windows.Forms.TabPage();
            this.pnlCaracteristiques = new System.Windows.Forms.Panel();
            this.pnlPointsVieEnergie = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtBxSexe = new System.Windows.Forms.TextBox();
            this.cbBxTaille = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAttributsPersonnalites = new System.Windows.Forms.Panel();
            this.btnEffacerHistoire = new System.Windows.Forms.Button();
            this.btnEffacerDescription = new System.Windows.Forms.Button();
            this.rchTxtBxDescriptionPhysique = new System.Windows.Forms.RichTextBox();
            this.lblDescriptionPhysique = new System.Windows.Forms.Label();
            this.tbCtrlAttribut = new System.Windows.Forms.TabControl();
            this.tbPgeCombat = new System.Windows.Forms.TabPage();
            this.tbPgeSurvie = new System.Windows.Forms.TabPage();
            this.tbPgeMobiliteExploration = new System.Windows.Forms.TabPage();
            this.tbPgeSociaux = new System.Windows.Forms.TabPage();
            this.tbPgeMystiquesOccultes = new System.Windows.Forms.TabPage();
            this.tbPgeTechniquesArtisanaux = new System.Windows.Forms.TabPage();
            this.rchTxtBxAttributsSelectionnes = new System.Windows.Forms.RichTextBox();
            this.lblAttributs = new System.Windows.Forms.Label();
            this.lblObjectifs = new System.Windows.Forms.Label();
            this.txtBxObjctfMineurs = new System.Windows.Forms.TextBox();
            this.txtBxObjctfMoyens = new System.Windows.Forms.TextBox();
            this.txtBxObjctfMajeurs = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtBxObjectif = new System.Windows.Forms.TextBox();
            this.lblQualites = new System.Windows.Forms.Label();
            this.txtBxQualites = new System.Windows.Forms.TextBox();
            this.txtBxDefauts = new System.Windows.Forms.TextBox();
            this.lblDefauts = new System.Windows.Forms.Label();
            this.txtBxPeurs = new System.Windows.Forms.TextBox();
            this.lblPeurs = new System.Windows.Forms.Label();
            pnlAttributs = new System.Windows.Forms.Panel();
            pnlAttributs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNiveau)).BeginInit();
            this.tabCtrlGeneral.SuspendLayout();
            this.tabPgeInfosGenerales.SuspendLayout();
            this.pnlInfosGenerales.SuspendLayout();
            this.tabPgeAttributs.SuspendLayout();
            this.tabPgeCaracteristiquesCompetences.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlAttributsPersonnalites.SuspendLayout();
            this.tbCtrlAttribut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAttributs
            // 
            pnlAttributs.BackColor = System.Drawing.SystemColors.Control;
            pnlAttributs.Controls.Add(this.rtbAttributs);
            pnlAttributs.Controls.Add(this.cbbTrier);
            pnlAttributs.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlAttributs.ForeColor = System.Drawing.SystemColors.ControlText;
            pnlAttributs.Location = new System.Drawing.Point(3, 3);
            pnlAttributs.Name = "pnlAttributs";
            pnlAttributs.Size = new System.Drawing.Size(766, 533);
            pnlAttributs.TabIndex = 6;
            // 
            // rtbAttributs
            // 
            this.rtbAttributs.Enabled = false;
            this.rtbAttributs.Location = new System.Drawing.Point(5, 228);
            this.rtbAttributs.Name = "rtbAttributs";
            this.rtbAttributs.Size = new System.Drawing.Size(310, 91);
            this.rtbAttributs.TabIndex = 5;
            this.rtbAttributs.Text = "";
            // 
            // cbbTrier
            // 
            this.cbbTrier.FormattingEnabled = true;
            this.cbbTrier.Items.AddRange(new object[] {
            "Ordre alphabétique(A-Z)",
            "Type(s)",
            "Défaut"});
            this.cbbTrier.Location = new System.Drawing.Point(376, 88);
            this.cbbTrier.Name = "cbbTrier";
            this.cbbTrier.Size = new System.Drawing.Size(121, 21);
            this.cbbTrier.TabIndex = 4;
            this.cbbTrier.Text = "Trier par:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrenom.Location = new System.Drawing.Point(15, 9);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(15, 29);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(81, 20);
            this.txtBoxPrenom.TabIndex = 1;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(119, 29);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(81, 20);
            this.txtBoxNom.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(119, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // TxtBoxRace
            // 
            this.TxtBoxRace.Location = new System.Drawing.Point(223, 29);
            this.TxtBoxRace.Name = "TxtBoxRace";
            this.TxtBoxRace.Size = new System.Drawing.Size(81, 20);
            this.TxtBoxRace.TabIndex = 5;
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRace.Location = new System.Drawing.Point(223, 9);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(41, 17);
            this.lblRace.TabIndex = 6;
            this.lblRace.Text = "Race";
            // 
            // lblNiveau
            // 
            this.lblNiveau.AutoSize = true;
            this.lblNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiveau.Location = new System.Drawing.Point(575, 9);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(52, 17);
            this.lblNiveau.TabIndex = 9;
            this.lblNiveau.Text = "Niveau";
            this.lblNiveau.Click += new System.EventHandler(this.lblNiveau_Click);
            // 
            // rtbHistoire
            // 
            this.rtbHistoire.AccessibleDescription = "";
            this.rtbHistoire.Location = new System.Drawing.Point(15, 93);
            this.rtbHistoire.MaxLength = 500;
            this.rtbHistoire.Name = "rtbHistoire";
            this.rtbHistoire.Size = new System.Drawing.Size(351, 79);
            this.rtbHistoire.TabIndex = 16;
            this.rtbHistoire.Text = "500 caractères maximum.";
            // 
            // lblHistoire
            // 
            this.lblHistoire.AutoSize = true;
            this.lblHistoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoire.Location = new System.Drawing.Point(15, 69);
            this.lblHistoire.Name = "lblHistoire";
            this.lblHistoire.Size = new System.Drawing.Size(63, 20);
            this.lblHistoire.TabIndex = 18;
            this.lblHistoire.Text = "Histoire";
            // 
            // lblLangages
            // 
            this.lblLangages.AutoSize = true;
            this.lblLangages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLangages.Location = new System.Drawing.Point(15, 8);
            this.lblLangages.Name = "lblLangages";
            this.lblLangages.Size = new System.Drawing.Size(127, 20);
            this.lblLangages.TabIndex = 19;
            this.lblLangages.Text = "Langues parlées";
            // 
            // btnSaveInfos
            // 
            this.btnSaveInfos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveInfos.Location = new System.Drawing.Point(0, 652);
            this.btnSaveInfos.Name = "btnSaveInfos";
            this.btnSaveInfos.Size = new System.Drawing.Size(780, 50);
            this.btnSaveInfos.TabIndex = 24;
            this.btnSaveInfos.Text = "Sauvegarder";
            this.btnSaveInfos.UseVisualStyleBackColor = true;
            this.btnSaveInfos.Click += new System.EventHandler(this.btnSaveInfos_Click);
            // 
            // nudNiveau
            // 
            this.nudNiveau.Location = new System.Drawing.Point(575, 29);
            this.nudNiveau.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNiveau.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNiveau.Name = "nudNiveau";
            this.nudNiveau.Size = new System.Drawing.Size(43, 20);
            this.nudNiveau.TabIndex = 40;
            this.nudNiveau.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNiveau.ValueChanged += new System.EventHandler(this.nudNiveau_ValueChanged);
            // 
            // tabCtrlGeneral
            // 
            this.tabCtrlGeneral.Controls.Add(this.tabPgeInfosGenerales);
            this.tabCtrlGeneral.Controls.Add(this.tabPgeAttributs);
            this.tabCtrlGeneral.Controls.Add(this.tabPgeCaracteristiquesCompetences);
            this.tabCtrlGeneral.Controls.Add(this.tabPage2);
            this.tabCtrlGeneral.Controls.Add(this.tabPage3);
            this.tabCtrlGeneral.Location = new System.Drawing.Point(0, 89);
            this.tabCtrlGeneral.Name = "tabCtrlGeneral";
            this.tabCtrlGeneral.SelectedIndex = 0;
            this.tabCtrlGeneral.Size = new System.Drawing.Size(780, 565);
            this.tabCtrlGeneral.TabIndex = 47;
            // 
            // tabPgeInfosGenerales
            // 
            this.tabPgeInfosGenerales.Controls.Add(this.pnlAttributsPersonnalites);
            this.tabPgeInfosGenerales.Controls.Add(this.pnlInfosGenerales);
            this.tabPgeInfosGenerales.Location = new System.Drawing.Point(4, 22);
            this.tabPgeInfosGenerales.Name = "tabPgeInfosGenerales";
            this.tabPgeInfosGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgeInfosGenerales.Size = new System.Drawing.Size(772, 539);
            this.tabPgeInfosGenerales.TabIndex = 0;
            this.tabPgeInfosGenerales.Text = "Informations générales";
            this.tabPgeInfosGenerales.UseVisualStyleBackColor = true;
            // 
            // pnlInfosGenerales
            // 
            this.pnlInfosGenerales.BackColor = System.Drawing.SystemColors.Control;
            this.pnlInfosGenerales.Controls.Add(this.textBox1);
            this.pnlInfosGenerales.Controls.Add(this.textBox2);
            this.pnlInfosGenerales.Controls.Add(this.txtBxObjectif);
            this.pnlInfosGenerales.Controls.Add(this.txtBxObjctfMajeurs);
            this.pnlInfosGenerales.Controls.Add(this.txtBxObjctfMoyens);
            this.pnlInfosGenerales.Controls.Add(this.txtBxObjctfMineurs);
            this.pnlInfosGenerales.Controls.Add(this.lblObjectifs);
            this.pnlInfosGenerales.Controls.Add(this.btnEffacerDescription);
            this.pnlInfosGenerales.Controls.Add(this.rchTxtBxDescriptionPhysique);
            this.pnlInfosGenerales.Controls.Add(this.lblDescriptionPhysique);
            this.pnlInfosGenerales.Controls.Add(this.btnEffacerHistoire);
            this.pnlInfosGenerales.Controls.Add(this.txtBxLanguesParlees);
            this.pnlInfosGenerales.Controls.Add(this.rtbHistoire);
            this.pnlInfosGenerales.Controls.Add(this.lblHistoire);
            this.pnlInfosGenerales.Controls.Add(this.lblLangages);
            this.pnlInfosGenerales.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInfosGenerales.Location = new System.Drawing.Point(3, 3);
            this.pnlInfosGenerales.Name = "pnlInfosGenerales";
            this.pnlInfosGenerales.Size = new System.Drawing.Size(384, 533);
            this.pnlInfosGenerales.TabIndex = 2;
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexe.Location = new System.Drawing.Point(327, 9);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(39, 17);
            this.lblSexe.TabIndex = 42;
            this.lblSexe.Text = "Sexe";
            // 
            // txtBxLanguesParlees
            // 
            this.txtBxLanguesParlees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxLanguesParlees.Location = new System.Drawing.Point(15, 31);
            this.txtBxLanguesParlees.Name = "txtBxLanguesParlees";
            this.txtBxLanguesParlees.Size = new System.Drawing.Size(351, 23);
            this.txtBxLanguesParlees.TabIndex = 41;
            // 
            // tabPgeAttributs
            // 
            this.tabPgeAttributs.Controls.Add(pnlAttributs);
            this.tabPgeAttributs.Location = new System.Drawing.Point(4, 22);
            this.tabPgeAttributs.Name = "tabPgeAttributs";
            this.tabPgeAttributs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgeAttributs.Size = new System.Drawing.Size(772, 539);
            this.tabPgeAttributs.TabIndex = 1;
            this.tabPgeAttributs.Text = "Attributs";
            this.tabPgeAttributs.UseVisualStyleBackColor = true;
            // 
            // tabPgeCaracteristiquesCompetences
            // 
            this.tabPgeCaracteristiquesCompetences.Controls.Add(this.pnlCaracteristiques);
            this.tabPgeCaracteristiquesCompetences.Controls.Add(this.pnlPointsVieEnergie);
            this.tabPgeCaracteristiquesCompetences.Location = new System.Drawing.Point(4, 22);
            this.tabPgeCaracteristiquesCompetences.Name = "tabPgeCaracteristiquesCompetences";
            this.tabPgeCaracteristiquesCompetences.Size = new System.Drawing.Size(772, 628);
            this.tabPgeCaracteristiquesCompetences.TabIndex = 2;
            this.tabPgeCaracteristiquesCompetences.Text = "Caractéristiques & Compétences";
            this.tabPgeCaracteristiquesCompetences.UseVisualStyleBackColor = true;
            // 
            // pnlCaracteristiques
            // 
            this.pnlCaracteristiques.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCaracteristiques.Location = new System.Drawing.Point(157, 160);
            this.pnlCaracteristiques.Name = "pnlCaracteristiques";
            this.pnlCaracteristiques.Size = new System.Drawing.Size(200, 100);
            this.pnlCaracteristiques.TabIndex = 1;
            // 
            // pnlPointsVieEnergie
            // 
            this.pnlPointsVieEnergie.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPointsVieEnergie.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPointsVieEnergie.Location = new System.Drawing.Point(0, 0);
            this.pnlPointsVieEnergie.Name = "pnlPointsVieEnergie";
            this.pnlPointsVieEnergie.Size = new System.Drawing.Size(772, 100);
            this.pnlPointsVieEnergie.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(772, 628);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(772, 628);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.cbBxTaille);
            this.pnlHeader.Controls.Add(this.txtBxSexe);
            this.pnlHeader.Controls.Add(this.nudNiveau);
            this.pnlHeader.Controls.Add(this.txtBoxPrenom);
            this.pnlHeader.Controls.Add(this.lblPrenom);
            this.pnlHeader.Controls.Add(this.txtBoxNom);
            this.pnlHeader.Controls.Add(this.lblSexe);
            this.pnlHeader.Controls.Add(this.lblNom);
            this.pnlHeader.Controls.Add(this.lblRace);
            this.pnlHeader.Controls.Add(this.TxtBoxRace);
            this.pnlHeader.Controls.Add(this.lblNiveau);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(780, 108);
            this.pnlHeader.TabIndex = 48;
            // 
            // txtBxSexe
            // 
            this.txtBxSexe.Location = new System.Drawing.Point(327, 29);
            this.txtBxSexe.Name = "txtBxSexe";
            this.txtBxSexe.Size = new System.Drawing.Size(81, 20);
            this.txtBxSexe.TabIndex = 43;
            // 
            // cbBxTaille
            // 
            this.cbBxTaille.FormattingEnabled = true;
            this.cbBxTaille.Items.AddRange(new object[] {
            "Minuscule",
            "Petit",
            "Moyen",
            "Grand",
            "Très grand",
            "Gigantesque"});
            this.cbBxTaille.Location = new System.Drawing.Point(431, 28);
            this.cbBxTaille.Name = "cbBxTaille";
            this.cbBxTaille.Size = new System.Drawing.Size(121, 21);
            this.cbBxTaille.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Taille";
            // 
            // pnlAttributsPersonnalites
            // 
            this.pnlAttributsPersonnalites.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAttributsPersonnalites.Controls.Add(this.txtBxPeurs);
            this.pnlAttributsPersonnalites.Controls.Add(this.lblPeurs);
            this.pnlAttributsPersonnalites.Controls.Add(this.txtBxDefauts);
            this.pnlAttributsPersonnalites.Controls.Add(this.lblDefauts);
            this.pnlAttributsPersonnalites.Controls.Add(this.txtBxQualites);
            this.pnlAttributsPersonnalites.Controls.Add(this.lblQualites);
            this.pnlAttributsPersonnalites.Controls.Add(this.lblAttributs);
            this.pnlAttributsPersonnalites.Controls.Add(this.rchTxtBxAttributsSelectionnes);
            this.pnlAttributsPersonnalites.Controls.Add(this.tbCtrlAttribut);
            this.pnlAttributsPersonnalites.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAttributsPersonnalites.Location = new System.Drawing.Point(385, 3);
            this.pnlAttributsPersonnalites.Name = "pnlAttributsPersonnalites";
            this.pnlAttributsPersonnalites.Size = new System.Drawing.Size(384, 533);
            this.pnlAttributsPersonnalites.TabIndex = 42;
            // 
            // btnEffacerHistoire
            // 
            this.btnEffacerHistoire.Location = new System.Drawing.Point(15, 176);
            this.btnEffacerHistoire.Name = "btnEffacerHistoire";
            this.btnEffacerHistoire.Size = new System.Drawing.Size(75, 23);
            this.btnEffacerHistoire.TabIndex = 42;
            this.btnEffacerHistoire.Text = "Effacer";
            this.btnEffacerHistoire.UseVisualStyleBackColor = true;
            // 
            // btnEffacerDescription
            // 
            this.btnEffacerDescription.Location = new System.Drawing.Point(11, 320);
            this.btnEffacerDescription.Name = "btnEffacerDescription";
            this.btnEffacerDescription.Size = new System.Drawing.Size(75, 23);
            this.btnEffacerDescription.TabIndex = 45;
            this.btnEffacerDescription.Text = "Effacer";
            this.btnEffacerDescription.UseVisualStyleBackColor = true;
            // 
            // rchTxtBxDescriptionPhysique
            // 
            this.rchTxtBxDescriptionPhysique.AccessibleDescription = "";
            this.rchTxtBxDescriptionPhysique.Location = new System.Drawing.Point(11, 237);
            this.rchTxtBxDescriptionPhysique.MaxLength = 500;
            this.rchTxtBxDescriptionPhysique.Name = "rchTxtBxDescriptionPhysique";
            this.rchTxtBxDescriptionPhysique.Size = new System.Drawing.Size(351, 79);
            this.rchTxtBxDescriptionPhysique.TabIndex = 43;
            this.rchTxtBxDescriptionPhysique.Text = "500 caractères maximum.";
            // 
            // lblDescriptionPhysique
            // 
            this.lblDescriptionPhysique.AutoSize = true;
            this.lblDescriptionPhysique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionPhysique.Location = new System.Drawing.Point(11, 213);
            this.lblDescriptionPhysique.Name = "lblDescriptionPhysique";
            this.lblDescriptionPhysique.Size = new System.Drawing.Size(156, 20);
            this.lblDescriptionPhysique.TabIndex = 44;
            this.lblDescriptionPhysique.Text = "Description physique";
            // 
            // tbCtrlAttribut
            // 
            this.tbCtrlAttribut.Controls.Add(this.tbPgeCombat);
            this.tbCtrlAttribut.Controls.Add(this.tbPgeSurvie);
            this.tbCtrlAttribut.Controls.Add(this.tbPgeMobiliteExploration);
            this.tbCtrlAttribut.Controls.Add(this.tbPgeSociaux);
            this.tbCtrlAttribut.Controls.Add(this.tbPgeMystiquesOccultes);
            this.tbCtrlAttribut.Controls.Add(this.tbPgeTechniquesArtisanaux);
            this.tbCtrlAttribut.Location = new System.Drawing.Point(21, 31);
            this.tbCtrlAttribut.Name = "tbCtrlAttribut";
            this.tbCtrlAttribut.SelectedIndex = 0;
            this.tbCtrlAttribut.Size = new System.Drawing.Size(345, 191);
            this.tbCtrlAttribut.TabIndex = 4;
            // 
            // tbPgeCombat
            // 
            this.tbPgeCombat.AutoScroll = true;
            this.tbPgeCombat.BackColor = System.Drawing.Color.White;
            this.tbPgeCombat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPgeCombat.Location = new System.Drawing.Point(4, 22);
            this.tbPgeCombat.Name = "tbPgeCombat";
            this.tbPgeCombat.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgeCombat.Size = new System.Drawing.Size(337, 165);
            this.tbPgeCombat.TabIndex = 0;
            this.tbPgeCombat.Text = "Combat";
            // 
            // tbPgeSurvie
            // 
            this.tbPgeSurvie.Location = new System.Drawing.Point(4, 22);
            this.tbPgeSurvie.Name = "tbPgeSurvie";
            this.tbPgeSurvie.Size = new System.Drawing.Size(337, 200);
            this.tbPgeSurvie.TabIndex = 1;
            this.tbPgeSurvie.Text = "Survie";
            this.tbPgeSurvie.UseVisualStyleBackColor = true;
            // 
            // tbPgeMobiliteExploration
            // 
            this.tbPgeMobiliteExploration.Location = new System.Drawing.Point(4, 22);
            this.tbPgeMobiliteExploration.Name = "tbPgeMobiliteExploration";
            this.tbPgeMobiliteExploration.Size = new System.Drawing.Size(337, 200);
            this.tbPgeMobiliteExploration.TabIndex = 2;
            this.tbPgeMobiliteExploration.Text = "Mobilité & Exploration";
            this.tbPgeMobiliteExploration.UseVisualStyleBackColor = true;
            // 
            // tbPgeSociaux
            // 
            this.tbPgeSociaux.Location = new System.Drawing.Point(4, 22);
            this.tbPgeSociaux.Name = "tbPgeSociaux";
            this.tbPgeSociaux.Size = new System.Drawing.Size(337, 200);
            this.tbPgeSociaux.TabIndex = 3;
            this.tbPgeSociaux.Text = "Sociaux";
            this.tbPgeSociaux.UseVisualStyleBackColor = true;
            // 
            // tbPgeMystiquesOccultes
            // 
            this.tbPgeMystiquesOccultes.Location = new System.Drawing.Point(4, 22);
            this.tbPgeMystiquesOccultes.Name = "tbPgeMystiquesOccultes";
            this.tbPgeMystiquesOccultes.Size = new System.Drawing.Size(337, 200);
            this.tbPgeMystiquesOccultes.TabIndex = 4;
            this.tbPgeMystiquesOccultes.Text = "Mystiques & Occultes";
            this.tbPgeMystiquesOccultes.UseVisualStyleBackColor = true;
            // 
            // tbPgeTechniquesArtisanaux
            // 
            this.tbPgeTechniquesArtisanaux.Location = new System.Drawing.Point(4, 22);
            this.tbPgeTechniquesArtisanaux.Name = "tbPgeTechniquesArtisanaux";
            this.tbPgeTechniquesArtisanaux.Size = new System.Drawing.Size(337, 200);
            this.tbPgeTechniquesArtisanaux.TabIndex = 5;
            this.tbPgeTechniquesArtisanaux.Text = "Techniques & artisanaux";
            this.tbPgeTechniquesArtisanaux.UseVisualStyleBackColor = true;
            // 
            // rchTxtBxAttributsSelectionnes
            // 
            this.rchTxtBxAttributsSelectionnes.AccessibleDescription = "";
            this.rchTxtBxAttributsSelectionnes.Location = new System.Drawing.Point(21, 237);
            this.rchTxtBxAttributsSelectionnes.MaxLength = 500;
            this.rchTxtBxAttributsSelectionnes.Name = "rchTxtBxAttributsSelectionnes";
            this.rchTxtBxAttributsSelectionnes.Size = new System.Drawing.Size(345, 79);
            this.rchTxtBxAttributsSelectionnes.TabIndex = 46;
            this.rchTxtBxAttributsSelectionnes.Text = "";
            // 
            // lblAttributs
            // 
            this.lblAttributs.AutoSize = true;
            this.lblAttributs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttributs.Location = new System.Drawing.Point(21, 8);
            this.lblAttributs.Name = "lblAttributs";
            this.lblAttributs.Size = new System.Drawing.Size(69, 20);
            this.lblAttributs.TabIndex = 46;
            this.lblAttributs.Text = "Attributs";
            // 
            // lblObjectifs
            // 
            this.lblObjectifs.AutoSize = true;
            this.lblObjectifs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjectifs.Location = new System.Drawing.Point(11, 357);
            this.lblObjectifs.Name = "lblObjectifs";
            this.lblObjectifs.Size = new System.Drawing.Size(71, 20);
            this.lblObjectifs.TabIndex = 46;
            this.lblObjectifs.Text = "Objectifs";
            // 
            // txtBxObjctfMineurs
            // 
            this.txtBxObjctfMineurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxObjctfMineurs.Location = new System.Drawing.Point(11, 380);
            this.txtBxObjctfMineurs.Name = "txtBxObjctfMineurs";
            this.txtBxObjctfMineurs.Size = new System.Drawing.Size(114, 23);
            this.txtBxObjctfMineurs.TabIndex = 46;
            this.txtBxObjctfMineurs.Text = "Mineur";
            this.txtBxObjctfMineurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxObjctfMoyens
            // 
            this.txtBxObjctfMoyens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxObjctfMoyens.Location = new System.Drawing.Point(124, 380);
            this.txtBxObjctfMoyens.Name = "txtBxObjctfMoyens";
            this.txtBxObjctfMoyens.Size = new System.Drawing.Size(114, 23);
            this.txtBxObjctfMoyens.TabIndex = 47;
            this.txtBxObjctfMoyens.Text = "Moyen";
            this.txtBxObjctfMoyens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxObjctfMajeurs
            // 
            this.txtBxObjctfMajeurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxObjctfMajeurs.Location = new System.Drawing.Point(237, 380);
            this.txtBxObjctfMajeurs.Name = "txtBxObjctfMajeurs";
            this.txtBxObjctfMajeurs.Size = new System.Drawing.Size(114, 23);
            this.txtBxObjctfMajeurs.TabIndex = 48;
            this.txtBxObjctfMajeurs.Text = "Majeur";
            this.txtBxObjctfMajeurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(237, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 23);
            this.textBox1.TabIndex = 51;
            this.textBox1.Text = "Majeur";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(124, 402);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 23);
            this.textBox2.TabIndex = 50;
            this.textBox2.Text = "Moyen";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBxObjectif
            // 
            this.txtBxObjectif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxObjectif.Location = new System.Drawing.Point(11, 402);
            this.txtBxObjectif.Name = "txtBxObjectif";
            this.txtBxObjectif.Size = new System.Drawing.Size(114, 23);
            this.txtBxObjectif.TabIndex = 49;
            this.txtBxObjectif.Text = "Mineur";
            this.txtBxObjectif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQualites
            // 
            this.lblQualites.AutoSize = true;
            this.lblQualites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualites.Location = new System.Drawing.Point(21, 323);
            this.lblQualites.Name = "lblQualites";
            this.lblQualites.Size = new System.Drawing.Size(67, 20);
            this.lblQualites.TabIndex = 52;
            this.lblQualites.Text = "Qualités";
            // 
            // txtBxQualites
            // 
            this.txtBxQualites.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxQualites.Location = new System.Drawing.Point(21, 349);
            this.txtBxQualites.Name = "txtBxQualites";
            this.txtBxQualites.Size = new System.Drawing.Size(345, 23);
            this.txtBxQualites.TabIndex = 52;
            // 
            // txtBxDefauts
            // 
            this.txtBxDefauts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxDefauts.Location = new System.Drawing.Point(21, 404);
            this.txtBxDefauts.Name = "txtBxDefauts";
            this.txtBxDefauts.Size = new System.Drawing.Size(345, 23);
            this.txtBxDefauts.TabIndex = 53;
            // 
            // lblDefauts
            // 
            this.lblDefauts.AutoSize = true;
            this.lblDefauts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefauts.Location = new System.Drawing.Point(21, 378);
            this.lblDefauts.Name = "lblDefauts";
            this.lblDefauts.Size = new System.Drawing.Size(66, 20);
            this.lblDefauts.TabIndex = 54;
            this.lblDefauts.Text = "Défauts";
            // 
            // txtBxPeurs
            // 
            this.txtBxPeurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPeurs.Location = new System.Drawing.Point(21, 459);
            this.txtBxPeurs.Name = "txtBxPeurs";
            this.txtBxPeurs.Size = new System.Drawing.Size(345, 23);
            this.txtBxPeurs.TabIndex = 55;
            // 
            // lblPeurs
            // 
            this.lblPeurs.AutoSize = true;
            this.lblPeurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeurs.Location = new System.Drawing.Point(21, 433);
            this.lblPeurs.Name = "lblPeurs";
            this.lblPeurs.Size = new System.Drawing.Size(50, 20);
            this.lblPeurs.TabIndex = 56;
            this.lblPeurs.Text = "Peurs";
            // 
            // FormulaireInfosGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 702);
            this.Controls.Add(this.btnSaveInfos);
            this.Controls.Add(this.tabCtrlGeneral);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormulaireInfosGenerales";
            this.Text = "Informations générales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormulaireInfosGenerales_FormClosing);
            this.Load += new System.EventHandler(this.FormulaireInfosGenerales_Load);
            this.Resize += new System.EventHandler(this.FormulaireInfosGenerales_Resize);
            pnlAttributs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNiveau)).EndInit();
            this.tabCtrlGeneral.ResumeLayout(false);
            this.tabPgeInfosGenerales.ResumeLayout(false);
            this.pnlInfosGenerales.ResumeLayout(false);
            this.pnlInfosGenerales.PerformLayout();
            this.tabPgeAttributs.ResumeLayout(false);
            this.tabPgeCaracteristiquesCompetences.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlAttributsPersonnalites.ResumeLayout(false);
            this.pnlAttributsPersonnalites.PerformLayout();
            this.tbCtrlAttribut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox TxtBoxRace;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.RichTextBox rtbHistoire;
        private System.Windows.Forms.Label lblHistoire;
        private System.Windows.Forms.Label lblLangages;
        private System.Windows.Forms.Button btnSaveInfos;
        private System.Windows.Forms.NumericUpDown nudNiveau;
        private System.Windows.Forms.TabControl tabCtrlGeneral;
        private System.Windows.Forms.TabPage tabPgeInfosGenerales;
        private System.Windows.Forms.Panel pnlInfosGenerales;
        private System.Windows.Forms.TextBox txtBxLanguesParlees;
        private System.Windows.Forms.TabPage tabPgeAttributs;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.ComboBox cbbTrier;
        private System.Windows.Forms.RichTextBox rtbAttributs;
        private System.Windows.Forms.TabPage tabPgeCaracteristiquesCompetences;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnlCaracteristiques;
        private System.Windows.Forms.Panel pnlPointsVieEnergie;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBxTaille;
        private System.Windows.Forms.TextBox txtBxSexe;
        private System.Windows.Forms.Panel pnlAttributsPersonnalites;
        private System.Windows.Forms.TabControl tbCtrlAttribut;
        private System.Windows.Forms.TabPage tbPgeCombat;
        private System.Windows.Forms.TabPage tbPgeSurvie;
        private System.Windows.Forms.TabPage tbPgeMobiliteExploration;
        private System.Windows.Forms.TabPage tbPgeSociaux;
        private System.Windows.Forms.TabPage tbPgeMystiquesOccultes;
        private System.Windows.Forms.TabPage tbPgeTechniquesArtisanaux;
        private System.Windows.Forms.Button btnEffacerDescription;
        private System.Windows.Forms.RichTextBox rchTxtBxDescriptionPhysique;
        private System.Windows.Forms.Label lblDescriptionPhysique;
        private System.Windows.Forms.Button btnEffacerHistoire;
        private System.Windows.Forms.Label lblAttributs;
        private System.Windows.Forms.RichTextBox rchTxtBxAttributsSelectionnes;
        private System.Windows.Forms.Label lblObjectifs;
        private System.Windows.Forms.TextBox txtBxQualites;
        private System.Windows.Forms.Label lblQualites;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtBxObjectif;
        private System.Windows.Forms.TextBox txtBxObjctfMajeurs;
        private System.Windows.Forms.TextBox txtBxObjctfMoyens;
        private System.Windows.Forms.TextBox txtBxObjctfMineurs;
        private System.Windows.Forms.TextBox txtBxDefauts;
        private System.Windows.Forms.Label lblDefauts;
        private System.Windows.Forms.TextBox txtBxPeurs;
        private System.Windows.Forms.Label lblPeurs;
    }
}