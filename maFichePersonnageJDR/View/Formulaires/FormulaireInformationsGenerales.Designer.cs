
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaireInfosGenerales));
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.TxtBoxRace = new System.Windows.Forms.TextBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.rdbHomme = new System.Windows.Forms.RadioButton();
            this.rdbFemme = new System.Windows.Forms.RadioButton();
            this.lblNiveau = new System.Windows.Forms.Label();
            this.rdbAutre = new System.Windows.Forms.RadioButton();
            this.rtbHistoire = new System.Windows.Forms.RichTextBox();
            this.rtbLangues = new System.Windows.Forms.RichTextBox();
            this.lblHistoire = new System.Windows.Forms.Label();
            this.lblLangages = new System.Windows.Forms.Label();
            this.btnSaveInfos = new System.Windows.Forms.Button();
            this.btnAjouterImage = new System.Windows.Forms.Button();
            this.btnViderHistoire = new System.Windows.Forms.Button();
            this.nudNiveau = new System.Windows.Forms.NumericUpDown();
            this.lblPointsRestants = new System.Windows.Forms.Label();
            this.lblPtsXpTotal = new System.Windows.Forms.Label();
            this.nudExpériencePersonnage = new System.Windows.Forms.NumericUpDown();
            this.cbbProgressionXp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNiveau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpériencePersonnage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrenom.Location = new System.Drawing.Point(21, 13);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(24, 28);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(68, 20);
            this.txtBoxPrenom.TabIndex = 1;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(117, 28);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(68, 20);
            this.txtBoxNom.TabIndex = 3;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(114, 13);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ptbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbAvatar.Location = new System.Drawing.Point(502, 13);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(256, 256);
            this.ptbAvatar.TabIndex = 4;
            this.ptbAvatar.TabStop = false;
            // 
            // TxtBoxRace
            // 
            this.TxtBoxRace.Location = new System.Drawing.Point(210, 28);
            this.TxtBoxRace.Name = "TxtBoxRace";
            this.TxtBoxRace.Size = new System.Drawing.Size(65, 20);
            this.TxtBoxRace.TabIndex = 5;
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(207, 13);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 6;
            this.lblRace.Text = "Race";
            // 
            // rdbHomme
            // 
            this.rdbHomme.AutoSize = true;
            this.rdbHomme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbHomme.Location = new System.Drawing.Point(416, 29);
            this.rdbHomme.Name = "rdbHomme";
            this.rdbHomme.Size = new System.Drawing.Size(73, 18);
            this.rdbHomme.TabIndex = 7;
            this.rdbHomme.TabStop = true;
            this.rdbHomme.Text = "Masculin";
            this.rdbHomme.UseVisualStyleBackColor = true;
            // 
            // rdbFemme
            // 
            this.rdbFemme.AutoSize = true;
            this.rdbFemme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbFemme.Location = new System.Drawing.Point(416, 53);
            this.rdbFemme.Name = "rdbFemme";
            this.rdbFemme.Size = new System.Drawing.Size(67, 18);
            this.rdbFemme.TabIndex = 8;
            this.rdbFemme.TabStop = true;
            this.rdbFemme.Text = "Féminin";
            this.rdbFemme.UseVisualStyleBackColor = true;
            // 
            // lblNiveau
            // 
            this.lblNiveau.AutoSize = true;
            this.lblNiveau.Location = new System.Drawing.Point(313, 13);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(41, 13);
            this.lblNiveau.TabIndex = 9;
            this.lblNiveau.Text = "Niveau";
            // 
            // rdbAutre
            // 
            this.rdbAutre.AutoSize = true;
            this.rdbAutre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbAutre.Location = new System.Drawing.Point(416, 77);
            this.rdbAutre.Name = "rdbAutre";
            this.rdbAutre.Size = new System.Drawing.Size(56, 18);
            this.rdbAutre.TabIndex = 15;
            this.rdbAutre.TabStop = true;
            this.rdbAutre.Text = "Autre";
            this.rdbAutre.UseVisualStyleBackColor = true;
            // 
            // rtbHistoire
            // 
            this.rtbHistoire.AccessibleDescription = "";
            this.rtbHistoire.Location = new System.Drawing.Point(12, 125);
            this.rtbHistoire.MaxLength = 500;
            this.rtbHistoire.Name = "rtbHistoire";
            this.rtbHistoire.Size = new System.Drawing.Size(444, 80);
            this.rtbHistoire.TabIndex = 16;
            this.rtbHistoire.Text = "500 caractères maximum.";
            // 
            // rtbLangues
            // 
            this.rtbLangues.Location = new System.Drawing.Point(12, 272);
            this.rtbLangues.Name = "rtbLangues";
            this.rtbLangues.Size = new System.Drawing.Size(445, 81);
            this.rtbLangues.TabIndex = 17;
            this.rtbLangues.Text = "";
            // 
            // lblHistoire
            // 
            this.lblHistoire.AutoSize = true;
            this.lblHistoire.Location = new System.Drawing.Point(194, 109);
            this.lblHistoire.Name = "lblHistoire";
            this.lblHistoire.Size = new System.Drawing.Size(42, 13);
            this.lblHistoire.TabIndex = 18;
            this.lblHistoire.Text = "Histoire";
            // 
            // lblLangages
            // 
            this.lblLangages.AutoSize = true;
            this.lblLangages.Location = new System.Drawing.Point(195, 256);
            this.lblLangages.Name = "lblLangages";
            this.lblLangages.Size = new System.Drawing.Size(48, 13);
            this.lblLangages.TabIndex = 19;
            this.lblLangages.Text = "Langues";
            // 
            // btnSaveInfos
            // 
            this.btnSaveInfos.Location = new System.Drawing.Point(502, 313);
            this.btnSaveInfos.Name = "btnSaveInfos";
            this.btnSaveInfos.Size = new System.Drawing.Size(256, 40);
            this.btnSaveInfos.TabIndex = 24;
            this.btnSaveInfos.Text = "Sauvegarder";
            this.btnSaveInfos.UseVisualStyleBackColor = true;
            this.btnSaveInfos.Click += new System.EventHandler(this.btnSaveInfos_Click);
            // 
            // btnAjouterImage
            // 
            this.btnAjouterImage.Location = new System.Drawing.Point(578, 275);
            this.btnAjouterImage.Name = "btnAjouterImage";
            this.btnAjouterImage.Size = new System.Drawing.Size(109, 23);
            this.btnAjouterImage.TabIndex = 29;
            this.btnAjouterImage.Text = "Ajouter image";
            this.btnAjouterImage.UseVisualStyleBackColor = true;
            this.btnAjouterImage.Click += new System.EventHandler(this.btnAjouterImage_Click);
            // 
            // btnViderHistoire
            // 
            this.btnViderHistoire.Location = new System.Drawing.Point(176, 211);
            this.btnViderHistoire.Name = "btnViderHistoire";
            this.btnViderHistoire.Size = new System.Drawing.Size(109, 23);
            this.btnViderHistoire.TabIndex = 30;
            this.btnViderHistoire.Text = "Vider";
            this.btnViderHistoire.UseVisualStyleBackColor = true;
            this.btnViderHistoire.Click += new System.EventHandler(this.btnViderHistoire_Click);
            // 
            // nudNiveau
            // 
            this.nudNiveau.Location = new System.Drawing.Point(316, 29);
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
            // lblPointsRestants
            // 
            this.lblPointsRestants.AutoSize = true;
            this.lblPointsRestants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointsRestants.Location = new System.Drawing.Point(221, 79);
            this.lblPointsRestants.Name = "lblPointsRestants";
            this.lblPointsRestants.Size = new System.Drawing.Size(20, 17);
            this.lblPointsRestants.TabIndex = 41;
            this.lblPointsRestants.Text = "/0";
            // 
            // lblPtsXpTotal
            // 
            this.lblPtsXpTotal.AutoSize = true;
            this.lblPtsXpTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPtsXpTotal.Location = new System.Drawing.Point(10, 78);
            this.lblPtsXpTotal.Name = "lblPtsXpTotal";
            this.lblPtsXpTotal.Size = new System.Drawing.Size(121, 15);
            this.lblPtsXpTotal.TabIndex = 43;
            this.lblPtsXpTotal.Text = "Points d\'expérience :";
            // 
            // nudExpériencePersonnage
            // 
            this.nudExpériencePersonnage.Location = new System.Drawing.Point(137, 78);
            this.nudExpériencePersonnage.Maximum = new decimal(new int[] {
            5099180,
            0,
            0,
            0});
            this.nudExpériencePersonnage.Name = "nudExpériencePersonnage";
            this.nudExpériencePersonnage.Size = new System.Drawing.Size(79, 20);
            this.nudExpériencePersonnage.TabIndex = 44;
            // 
            // cbbProgressionXp
            // 
            this.cbbProgressionXp.FormattingEnabled = true;
            this.cbbProgressionXp.Items.AddRange(new object[] {
            "Rapide",
            "Normale",
            "Lente"});
            this.cbbProgressionXp.Location = new System.Drawing.Point(293, 78);
            this.cbbProgressionXp.Name = "cbbProgressionXp";
            this.cbbProgressionXp.Size = new System.Drawing.Size(86, 21);
            this.cbbProgressionXp.TabIndex = 46;
            this.cbbProgressionXp.Text = "Progression";
            this.cbbProgressionXp.SelectedIndexChanged += new System.EventHandler(this.cbbProgressionXp_SelectedIndexChanged);
            // 
            // FormulaireInfosGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 367);
            this.Controls.Add(this.cbbProgressionXp);
            this.Controls.Add(this.nudExpériencePersonnage);
            this.Controls.Add(this.lblPtsXpTotal);
            this.Controls.Add(this.lblPointsRestants);
            this.Controls.Add(this.nudNiveau);
            this.Controls.Add(this.btnViderHistoire);
            this.Controls.Add(this.btnAjouterImage);
            this.Controls.Add(this.btnSaveInfos);
            this.Controls.Add(this.lblLangages);
            this.Controls.Add(this.lblHistoire);
            this.Controls.Add(this.rtbLangues);
            this.Controls.Add(this.rtbHistoire);
            this.Controls.Add(this.rdbAutre);
            this.Controls.Add(this.lblNiveau);
            this.Controls.Add(this.rdbFemme);
            this.Controls.Add(this.rdbHomme);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.TxtBoxRace);
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtBoxPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormulaireInfosGenerales";
            this.Text = "Informations générales";
            this.Load += new System.EventHandler(this.FormulaireInfosGenerales_Load);
            this.Resize += new System.EventHandler(this.FormulaireInfosGenerales_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNiveau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpériencePersonnage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.TextBox TxtBoxRace;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.RadioButton rdbHomme;
        private System.Windows.Forms.RadioButton rdbFemme;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.RadioButton rdbAutre;
        private System.Windows.Forms.RichTextBox rtbHistoire;
        private System.Windows.Forms.RichTextBox rtbLangues;
        private System.Windows.Forms.Label lblHistoire;
        private System.Windows.Forms.Label lblLangages;
        private System.Windows.Forms.Button btnSaveInfos;
        private System.Windows.Forms.Button btnAjouterImage;
        private System.Windows.Forms.Button btnViderHistoire;
        private System.Windows.Forms.NumericUpDown nudNiveau;
        private System.Windows.Forms.Label lblPointsRestants;
        private System.Windows.Forms.Label lblPtsXpTotal;
        private System.Windows.Forms.NumericUpDown nudExpériencePersonnage;
        private System.Windows.Forms.ComboBox cbbProgressionXp;
    }
}