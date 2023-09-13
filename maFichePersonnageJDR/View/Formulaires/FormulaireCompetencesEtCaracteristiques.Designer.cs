
namespace maFichePersonnageJDR.Formulaires
{
    partial class FormulaireCompAttri
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
            this.lblPhysique = new System.Windows.Forms.Label();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.lblMental = new System.Windows.Forms.Label();
            this.lblSocial = new System.Windows.Forms.Label();
            this.grpbCompetences = new System.Windows.Forms.GroupBox();
            this.nudDexterite = new System.Windows.Forms.NumericUpDown();
            this.lblDexterite = new System.Windows.Forms.Label();
            this.lblPV = new System.Windows.Forms.Label();
            this.lblEnergie = new System.Windows.Forms.Label();
            this.lblPntsRepartitionCompetences = new System.Windows.Forms.Label();
            this.txtPntsPhysique = new System.Windows.Forms.TextBox();
            this.txtPntsMental = new System.Windows.Forms.TextBox();
            this.txtPntsSocial = new System.Windows.Forms.TextBox();
            this.lblRepartPhysique = new System.Windows.Forms.Label();
            this.lblRepartMental = new System.Windows.Forms.Label();
            this.lblRepartSocial = new System.Windows.Forms.Label();
            this.txtPntsCaracteristiques = new System.Windows.Forms.TextBox();
            this.lblPntsRepartitionCaracteristiques = new System.Windows.Forms.Label();
            this.txtPntsPVEnergie = new System.Windows.Forms.TextBox();
            this.lblPntsRepartitionPVEnergie = new System.Windows.Forms.Label();
            this.nudPV = new System.Windows.Forms.NumericUpDown();
            this.nudEnergie = new System.Windows.Forms.NumericUpDown();
            this.nudPhysique = new System.Windows.Forms.NumericUpDown();
            this.nudMental = new System.Windows.Forms.NumericUpDown();
            this.nudSocial = new System.Windows.Forms.NumericUpDown();
            this.btnReinitialiserCompetences = new System.Windows.Forms.Button();
            this.grpbCompetences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDexterite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnergie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhysique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSocial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPhysique
            // 
            this.lblPhysique.AutoSize = true;
            this.lblPhysique.Location = new System.Drawing.Point(52, 77);
            this.lblPhysique.Name = "lblPhysique";
            this.lblPhysique.Size = new System.Drawing.Size(50, 13);
            this.lblPhysique.TabIndex = 0;
            this.lblPhysique.Text = "Physique";
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(275, 454);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(333, 41);
            this.btnSauvegarder.TabIndex = 2;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // lblMental
            // 
            this.lblMental.AutoSize = true;
            this.lblMental.Location = new System.Drawing.Point(116, 77);
            this.lblMental.Name = "lblMental";
            this.lblMental.Size = new System.Drawing.Size(39, 13);
            this.lblMental.TabIndex = 3;
            this.lblMental.Text = "Mental";
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.Location = new System.Drawing.Point(180, 77);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(36, 13);
            this.lblSocial.TabIndex = 5;
            this.lblSocial.Text = "Social";
            // 
            // grpbCompetences
            // 
            this.grpbCompetences.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpbCompetences.Controls.Add(this.nudDexterite);
            this.grpbCompetences.Controls.Add(this.lblDexterite);
            this.grpbCompetences.Location = new System.Drawing.Point(266, 12);
            this.grpbCompetences.Name = "grpbCompetences";
            this.grpbCompetences.Size = new System.Drawing.Size(490, 372);
            this.grpbCompetences.TabIndex = 7;
            this.grpbCompetences.TabStop = false;
            this.grpbCompetences.Text = "Compétences";
            // 
            // nudDexterite
            // 
            this.nudDexterite.Enabled = false;
            this.nudDexterite.Location = new System.Drawing.Point(285, 25);
            this.nudDexterite.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudDexterite.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudDexterite.Name = "nudDexterite";
            this.nudDexterite.Size = new System.Drawing.Size(41, 20);
            this.nudDexterite.TabIndex = 14;
            this.nudDexterite.Tag = "Autre";
            this.nudDexterite.ThousandsSeparator = true;
            this.nudDexterite.ValueChanged += new System.EventHandler(this.numericUpDownValeurChangeCompetencesPhysique_ValueChanged);
            // 
            // lblDexterite
            // 
            this.lblDexterite.AutoSize = true;
            this.lblDexterite.Location = new System.Drawing.Point(212, 27);
            this.lblDexterite.Name = "lblDexterite";
            this.lblDexterite.Size = new System.Drawing.Size(49, 13);
            this.lblDexterite.TabIndex = 32;
            this.lblDexterite.Text = "Dextérité";
            // 
            // lblPV
            // 
            this.lblPV.AutoSize = true;
            this.lblPV.Location = new System.Drawing.Point(34, 12);
            this.lblPV.Name = "lblPV";
            this.lblPV.Size = new System.Drawing.Size(68, 13);
            this.lblPV.TabIndex = 8;
            this.lblPV.Text = "Points de vie";
            // 
            // lblEnergie
            // 
            this.lblEnergie.AutoSize = true;
            this.lblEnergie.Location = new System.Drawing.Point(173, 12);
            this.lblEnergie.Name = "lblEnergie";
            this.lblEnergie.Size = new System.Drawing.Size(43, 13);
            this.lblEnergie.TabIndex = 9;
            this.lblEnergie.Text = "Énergie";
            // 
            // lblPntsRepartitionCompetences
            // 
            this.lblPntsRepartitionCompetences.AutoSize = true;
            this.lblPntsRepartitionCompetences.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPntsRepartitionCompetences.Location = new System.Drawing.Point(263, 414);
            this.lblPntsRepartitionCompetences.Name = "lblPntsRepartitionCompetences";
            this.lblPntsRepartitionCompetences.Size = new System.Drawing.Size(80, 13);
            this.lblPntsRepartitionCompetences.TabIndex = 17;
            this.lblPntsRepartitionCompetences.Text = "Points à répartir";
            this.lblPntsRepartitionCompetences.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPntsPhysique
            // 
            this.txtPntsPhysique.Enabled = false;
            this.txtPntsPhysique.Location = new System.Drawing.Point(349, 411);
            this.txtPntsPhysique.Name = "txtPntsPhysique";
            this.txtPntsPhysique.Size = new System.Drawing.Size(26, 20);
            this.txtPntsPhysique.TabIndex = 18;
            this.txtPntsPhysique.Text = "55";
            // 
            // txtPntsMental
            // 
            this.txtPntsMental.Enabled = false;
            this.txtPntsMental.Location = new System.Drawing.Point(408, 411);
            this.txtPntsMental.Name = "txtPntsMental";
            this.txtPntsMental.Size = new System.Drawing.Size(26, 20);
            this.txtPntsMental.TabIndex = 19;
            this.txtPntsMental.Text = "75";
            // 
            // txtPntsSocial
            // 
            this.txtPntsSocial.Enabled = false;
            this.txtPntsSocial.Location = new System.Drawing.Point(465, 411);
            this.txtPntsSocial.Name = "txtPntsSocial";
            this.txtPntsSocial.Size = new System.Drawing.Size(26, 20);
            this.txtPntsSocial.TabIndex = 20;
            this.txtPntsSocial.Text = "45";
            // 
            // lblRepartPhysique
            // 
            this.lblRepartPhysique.AutoSize = true;
            this.lblRepartPhysique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepartPhysique.Location = new System.Drawing.Point(339, 387);
            this.lblRepartPhysique.Name = "lblRepartPhysique";
            this.lblRepartPhysique.Size = new System.Drawing.Size(50, 13);
            this.lblRepartPhysique.TabIndex = 21;
            this.lblRepartPhysique.Text = "Physique";
            this.lblRepartPhysique.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRepartMental
            // 
            this.lblRepartMental.AutoSize = true;
            this.lblRepartMental.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepartMental.Location = new System.Drawing.Point(405, 387);
            this.lblRepartMental.Name = "lblRepartMental";
            this.lblRepartMental.Size = new System.Drawing.Size(39, 13);
            this.lblRepartMental.TabIndex = 22;
            this.lblRepartMental.Text = "Mental";
            this.lblRepartMental.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRepartSocial
            // 
            this.lblRepartSocial.AutoSize = true;
            this.lblRepartSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepartSocial.Location = new System.Drawing.Point(462, 387);
            this.lblRepartSocial.Name = "lblRepartSocial";
            this.lblRepartSocial.Size = new System.Drawing.Size(36, 13);
            this.lblRepartSocial.TabIndex = 23;
            this.lblRepartSocial.Text = "Social";
            this.lblRepartSocial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPntsCaracteristiques
            // 
            this.txtPntsCaracteristiques.Enabled = false;
            this.txtPntsCaracteristiques.Location = new System.Drawing.Point(131, 120);
            this.txtPntsCaracteristiques.Name = "txtPntsCaracteristiques";
            this.txtPntsCaracteristiques.Size = new System.Drawing.Size(26, 20);
            this.txtPntsCaracteristiques.TabIndex = 25;
            // 
            // lblPntsRepartitionCaracteristiques
            // 
            this.lblPntsRepartitionCaracteristiques.AutoSize = true;
            this.lblPntsRepartitionCaracteristiques.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPntsRepartitionCaracteristiques.Location = new System.Drawing.Point(45, 123);
            this.lblPntsRepartitionCaracteristiques.Name = "lblPntsRepartitionCaracteristiques";
            this.lblPntsRepartitionCaracteristiques.Size = new System.Drawing.Size(80, 13);
            this.lblPntsRepartitionCaracteristiques.TabIndex = 24;
            this.lblPntsRepartitionCaracteristiques.Text = "Points à répartir";
            this.lblPntsRepartitionCaracteristiques.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPntsPVEnergie
            // 
            this.txtPntsPVEnergie.Enabled = false;
            this.txtPntsPVEnergie.Location = new System.Drawing.Point(131, 51);
            this.txtPntsPVEnergie.Name = "txtPntsPVEnergie";
            this.txtPntsPVEnergie.Size = new System.Drawing.Size(26, 20);
            this.txtPntsPVEnergie.TabIndex = 27;
            // 
            // lblPntsRepartitionPVEnergie
            // 
            this.lblPntsRepartitionPVEnergie.AutoSize = true;
            this.lblPntsRepartitionPVEnergie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPntsRepartitionPVEnergie.Location = new System.Drawing.Point(45, 54);
            this.lblPntsRepartitionPVEnergie.Name = "lblPntsRepartitionPVEnergie";
            this.lblPntsRepartitionPVEnergie.Size = new System.Drawing.Size(80, 13);
            this.lblPntsRepartitionPVEnergie.TabIndex = 26;
            this.lblPntsRepartitionPVEnergie.Text = "Points à répartir";
            this.lblPntsRepartitionPVEnergie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudPV
            // 
            this.nudPV.Location = new System.Drawing.Point(44, 32);
            this.nudPV.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudPV.Name = "nudPV";
            this.nudPV.ReadOnly = true;
            this.nudPV.Size = new System.Drawing.Size(47, 20);
            this.nudPV.TabIndex = 28;
            this.nudPV.Tag = "PV";
            this.nudPV.ValueChanged += new System.EventHandler(this.numericUpDownValeurChangePVEnergie_ValueChanged);
            // 
            // nudEnergie
            // 
            this.nudEnergie.Location = new System.Drawing.Point(176, 32);
            this.nudEnergie.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudEnergie.Name = "nudEnergie";
            this.nudEnergie.ReadOnly = true;
            this.nudEnergie.Size = new System.Drawing.Size(47, 20);
            this.nudEnergie.TabIndex = 29;
            this.nudEnergie.Tag = "Energie";
            this.nudEnergie.ValueChanged += new System.EventHandler(this.numericUpDownValeurChangePVEnergie_ValueChanged);
            // 
            // nudPhysique
            // 
            this.nudPhysique.Location = new System.Drawing.Point(55, 93);
            this.nudPhysique.Name = "nudPhysique";
            this.nudPhysique.ReadOnly = true;
            this.nudPhysique.Size = new System.Drawing.Size(47, 20);
            this.nudPhysique.TabIndex = 30;
            this.nudPhysique.Tag = "Physique";
            this.nudPhysique.ValueChanged += new System.EventHandler(this.numericUpDownValeurChangeCaracteristiques_ValueChanged);
            // 
            // nudMental
            // 
            this.nudMental.Location = new System.Drawing.Point(112, 93);
            this.nudMental.Name = "nudMental";
            this.nudMental.ReadOnly = true;
            this.nudMental.Size = new System.Drawing.Size(47, 20);
            this.nudMental.TabIndex = 31;
            this.nudMental.Tag = "Mental";
            this.nudMental.ValueChanged += new System.EventHandler(this.numericUpDownValeurChangeCaracteristiques_ValueChanged);
            // 
            // nudSocial
            // 
            this.nudSocial.Location = new System.Drawing.Point(176, 93);
            this.nudSocial.Name = "nudSocial";
            this.nudSocial.ReadOnly = true;
            this.nudSocial.Size = new System.Drawing.Size(47, 20);
            this.nudSocial.TabIndex = 32;
            this.nudSocial.Tag = "Social";
            this.nudSocial.ValueChanged += new System.EventHandler(this.numericUpDownValeurChangeCaracteristiques_ValueChanged);
            // 
            // btnReinitialiserCompetences
            // 
            this.btnReinitialiserCompetences.Location = new System.Drawing.Point(533, 408);
            this.btnReinitialiserCompetences.Name = "btnReinitialiserCompetences";
            this.btnReinitialiserCompetences.Size = new System.Drawing.Size(75, 23);
            this.btnReinitialiserCompetences.TabIndex = 33;
            this.btnReinitialiserCompetences.Text = "Réinitialiser";
            this.btnReinitialiserCompetences.UseVisualStyleBackColor = true;
            this.btnReinitialiserCompetences.Click += new System.EventHandler(this.btnReinitialiserCompetences_Click);
            // 
            // FormulaireCompAttri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 507);
            this.Controls.Add(this.btnReinitialiserCompetences);
            this.Controls.Add(this.nudSocial);
            this.Controls.Add(this.nudMental);
            this.Controls.Add(this.nudPhysique);
            this.Controls.Add(this.nudEnergie);
            this.Controls.Add(this.nudPV);
            this.Controls.Add(this.txtPntsPVEnergie);
            this.Controls.Add(this.lblPntsRepartitionPVEnergie);
            this.Controls.Add(this.txtPntsCaracteristiques);
            this.Controls.Add(this.lblPntsRepartitionCaracteristiques);
            this.Controls.Add(this.lblRepartSocial);
            this.Controls.Add(this.lblRepartMental);
            this.Controls.Add(this.lblRepartPhysique);
            this.Controls.Add(this.txtPntsSocial);
            this.Controls.Add(this.txtPntsMental);
            this.Controls.Add(this.txtPntsPhysique);
            this.Controls.Add(this.lblPntsRepartitionCompetences);
            this.Controls.Add(this.lblEnergie);
            this.Controls.Add(this.lblPV);
            this.Controls.Add(this.grpbCompetences);
            this.Controls.Add(this.lblSocial);
            this.Controls.Add(this.lblMental);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.lblPhysique);
            this.Name = "FormulaireCompAttri";
            this.Text = "FormulaireCompAttri";
            this.Load += new System.EventHandler(this.FormulaireCompAttri_Load);
            this.grpbCompetences.ResumeLayout(false);
            this.grpbCompetences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDexterite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnergie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhysique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSocial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhysique;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Label lblMental;
        private System.Windows.Forms.Label lblSocial;
        private System.Windows.Forms.GroupBox grpbCompetences;
        private System.Windows.Forms.NumericUpDown nudDexterite;
        private System.Windows.Forms.Label lblDexterite;
        private System.Windows.Forms.Label lblPV;
        private System.Windows.Forms.Label lblEnergie;
        private System.Windows.Forms.Label lblPntsRepartitionCompetences;
        private System.Windows.Forms.TextBox txtPntsPhysique;
        private System.Windows.Forms.TextBox txtPntsMental;
        private System.Windows.Forms.TextBox txtPntsSocial;
        private System.Windows.Forms.Label lblRepartPhysique;
        private System.Windows.Forms.Label lblRepartMental;
        private System.Windows.Forms.Label lblRepartSocial;
        private System.Windows.Forms.TextBox txtPntsCaracteristiques;
        private System.Windows.Forms.Label lblPntsRepartitionCaracteristiques;
        private System.Windows.Forms.TextBox txtPntsPVEnergie;
        private System.Windows.Forms.Label lblPntsRepartitionPVEnergie;
        private System.Windows.Forms.NumericUpDown nudPV;
        private System.Windows.Forms.NumericUpDown nudEnergie;
        private System.Windows.Forms.NumericUpDown nudPhysique;
        private System.Windows.Forms.NumericUpDown nudMental;
        private System.Windows.Forms.NumericUpDown nudSocial;
        private System.Windows.Forms.Button btnReinitialiserCompetences;
    }
}