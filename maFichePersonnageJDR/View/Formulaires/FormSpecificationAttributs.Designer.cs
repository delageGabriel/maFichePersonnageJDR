
namespace maFichePersonnageJDR.View.Formulaires
{
    partial class FormSpecificationAttributs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpecificationAttributs));
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMgie = new System.Windows.Forms.Panel();
            this.chkNeutre = new System.Windows.Forms.CheckBox();
            this.chkDivine = new System.Windows.Forms.CheckBox();
            this.chkCorrompue = new System.Windows.Forms.CheckBox();
            this.chkNature = new System.Windows.Forms.CheckBox();
            this.chkTerrestre = new System.Windows.Forms.CheckBox();
            this.chkCeleste = new System.Windows.Forms.CheckBox();
            this.chkIgnee = new System.Windows.Forms.CheckBox();
            this.chkAquatique = new System.Windows.Forms.CheckBox();
            this.pnlPourcentage = new System.Windows.Forms.Panel();
            this.chkCinquante = new System.Windows.Forms.CheckBox();
            this.chkQuaranteCinq = new System.Windows.Forms.CheckBox();
            this.chkQuarante = new System.Windows.Forms.CheckBox();
            this.chkTrenteCinq = new System.Windows.Forms.CheckBox();
            this.chkVingt = new System.Windows.Forms.CheckBox();
            this.chkTrente = new System.Windows.Forms.CheckBox();
            this.chkQuinze = new System.Windows.Forms.CheckBox();
            this.chkVingtCinq = new System.Windows.Forms.CheckBox();
            this.chkDix = new System.Windows.Forms.CheckBox();
            this.nudNombre = new System.Windows.Forms.NumericUpDown();
            this.pnlMgie.SuspendLayout();
            this.pnlPourcentage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(50, 207);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(193, 20);
            this.txtSpec.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(64, 235);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(155, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlMgie
            // 
            this.pnlMgie.BackColor = System.Drawing.Color.White;
            this.pnlMgie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMgie.Controls.Add(this.chkNeutre);
            this.pnlMgie.Controls.Add(this.chkDivine);
            this.pnlMgie.Controls.Add(this.chkCorrompue);
            this.pnlMgie.Controls.Add(this.chkNature);
            this.pnlMgie.Controls.Add(this.chkTerrestre);
            this.pnlMgie.Controls.Add(this.chkCeleste);
            this.pnlMgie.Controls.Add(this.chkIgnee);
            this.pnlMgie.Controls.Add(this.chkAquatique);
            this.pnlMgie.Enabled = false;
            this.pnlMgie.Location = new System.Drawing.Point(19, 10);
            this.pnlMgie.Name = "pnlMgie";
            this.pnlMgie.Size = new System.Drawing.Size(258, 77);
            this.pnlMgie.TabIndex = 3;
            // 
            // chkNeutre
            // 
            this.chkNeutre.AccessibleDescription = "";
            this.chkNeutre.AutoSize = true;
            this.chkNeutre.Location = new System.Drawing.Point(83, 49);
            this.chkNeutre.Name = "chkNeutre";
            this.chkNeutre.Size = new System.Drawing.Size(58, 17);
            this.chkNeutre.TabIndex = 7;
            this.chkNeutre.Text = "Neutre";
            this.chkNeutre.UseVisualStyleBackColor = true;
            this.chkNeutre.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkDivine
            // 
            this.chkDivine.AutoSize = true;
            this.chkDivine.Location = new System.Drawing.Point(3, 49);
            this.chkDivine.Name = "chkDivine";
            this.chkDivine.Size = new System.Drawing.Size(56, 17);
            this.chkDivine.TabIndex = 6;
            this.chkDivine.Text = "Divine";
            this.chkDivine.UseVisualStyleBackColor = true;
            this.chkDivine.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkCorrompue
            // 
            this.chkCorrompue.AccessibleDescription = "";
            this.chkCorrompue.AutoSize = true;
            this.chkCorrompue.Location = new System.Drawing.Point(162, 26);
            this.chkCorrompue.Name = "chkCorrompue";
            this.chkCorrompue.Size = new System.Drawing.Size(77, 17);
            this.chkCorrompue.TabIndex = 5;
            this.chkCorrompue.Text = "Corrompue";
            this.chkCorrompue.UseVisualStyleBackColor = true;
            this.chkCorrompue.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkNature
            // 
            this.chkNature.AccessibleDescription = "";
            this.chkNature.AutoSize = true;
            this.chkNature.Location = new System.Drawing.Point(162, 3);
            this.chkNature.Name = "chkNature";
            this.chkNature.Size = new System.Drawing.Size(58, 17);
            this.chkNature.TabIndex = 4;
            this.chkNature.Text = "Nature";
            this.chkNature.UseVisualStyleBackColor = true;
            this.chkNature.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkTerrestre
            // 
            this.chkTerrestre.AccessibleDescription = "";
            this.chkTerrestre.AutoSize = true;
            this.chkTerrestre.Location = new System.Drawing.Point(83, 26);
            this.chkTerrestre.Name = "chkTerrestre";
            this.chkTerrestre.Size = new System.Drawing.Size(68, 17);
            this.chkTerrestre.TabIndex = 3;
            this.chkTerrestre.Text = "Terrestre";
            this.chkTerrestre.UseVisualStyleBackColor = true;
            this.chkTerrestre.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkCeleste
            // 
            this.chkCeleste.AutoSize = true;
            this.chkCeleste.Location = new System.Drawing.Point(83, 3);
            this.chkCeleste.Name = "chkCeleste";
            this.chkCeleste.Size = new System.Drawing.Size(61, 17);
            this.chkCeleste.TabIndex = 2;
            this.chkCeleste.Text = "Céleste";
            this.chkCeleste.UseVisualStyleBackColor = true;
            this.chkCeleste.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkIgnee
            // 
            this.chkIgnee.AutoSize = true;
            this.chkIgnee.Location = new System.Drawing.Point(3, 26);
            this.chkIgnee.Name = "chkIgnee";
            this.chkIgnee.Size = new System.Drawing.Size(53, 17);
            this.chkIgnee.TabIndex = 1;
            this.chkIgnee.Text = "Ignée";
            this.chkIgnee.UseVisualStyleBackColor = true;
            this.chkIgnee.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkAquatique
            // 
            this.chkAquatique.AutoSize = true;
            this.chkAquatique.Location = new System.Drawing.Point(3, 3);
            this.chkAquatique.Name = "chkAquatique";
            this.chkAquatique.Size = new System.Drawing.Size(74, 17);
            this.chkAquatique.TabIndex = 0;
            this.chkAquatique.Text = "Aquatique";
            this.chkAquatique.UseVisualStyleBackColor = true;
            this.chkAquatique.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // pnlPourcentage
            // 
            this.pnlPourcentage.BackColor = System.Drawing.Color.White;
            this.pnlPourcentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPourcentage.Controls.Add(this.chkCinquante);
            this.pnlPourcentage.Controls.Add(this.chkQuaranteCinq);
            this.pnlPourcentage.Controls.Add(this.chkQuarante);
            this.pnlPourcentage.Controls.Add(this.chkTrenteCinq);
            this.pnlPourcentage.Controls.Add(this.chkVingt);
            this.pnlPourcentage.Controls.Add(this.chkTrente);
            this.pnlPourcentage.Controls.Add(this.chkQuinze);
            this.pnlPourcentage.Controls.Add(this.chkVingtCinq);
            this.pnlPourcentage.Controls.Add(this.chkDix);
            this.pnlPourcentage.Location = new System.Drawing.Point(19, 93);
            this.pnlPourcentage.Name = "pnlPourcentage";
            this.pnlPourcentage.Size = new System.Drawing.Size(258, 77);
            this.pnlPourcentage.TabIndex = 8;
            // 
            // chkCinquante
            // 
            this.chkCinquante.AccessibleDescription = "";
            this.chkCinquante.AutoSize = true;
            this.chkCinquante.Enabled = false;
            this.chkCinquante.Location = new System.Drawing.Point(170, 49);
            this.chkCinquante.Name = "chkCinquante";
            this.chkCinquante.Size = new System.Drawing.Size(38, 17);
            this.chkCinquante.TabIndex = 8;
            this.chkCinquante.Text = "50";
            this.chkCinquante.UseVisualStyleBackColor = true;
            this.chkCinquante.Visible = false;
            this.chkCinquante.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkQuaranteCinq
            // 
            this.chkQuaranteCinq.AccessibleDescription = "";
            this.chkQuaranteCinq.AutoSize = true;
            this.chkQuaranteCinq.Location = new System.Drawing.Point(91, 49);
            this.chkQuaranteCinq.Name = "chkQuaranteCinq";
            this.chkQuaranteCinq.Size = new System.Drawing.Size(38, 17);
            this.chkQuaranteCinq.TabIndex = 7;
            this.chkQuaranteCinq.Text = "45";
            this.chkQuaranteCinq.UseVisualStyleBackColor = true;
            this.chkQuaranteCinq.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkQuarante
            // 
            this.chkQuarante.AutoSize = true;
            this.chkQuarante.Location = new System.Drawing.Point(3, 49);
            this.chkQuarante.Name = "chkQuarante";
            this.chkQuarante.Size = new System.Drawing.Size(38, 17);
            this.chkQuarante.TabIndex = 6;
            this.chkQuarante.Text = "40";
            this.chkQuarante.UseVisualStyleBackColor = true;
            this.chkQuarante.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkTrenteCinq
            // 
            this.chkTrenteCinq.AccessibleDescription = "";
            this.chkTrenteCinq.AutoSize = true;
            this.chkTrenteCinq.Location = new System.Drawing.Point(170, 26);
            this.chkTrenteCinq.Name = "chkTrenteCinq";
            this.chkTrenteCinq.Size = new System.Drawing.Size(38, 17);
            this.chkTrenteCinq.TabIndex = 5;
            this.chkTrenteCinq.Text = "35";
            this.chkTrenteCinq.UseVisualStyleBackColor = true;
            this.chkTrenteCinq.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkVingt
            // 
            this.chkVingt.AccessibleDescription = "";
            this.chkVingt.AutoSize = true;
            this.chkVingt.Location = new System.Drawing.Point(170, 3);
            this.chkVingt.Name = "chkVingt";
            this.chkVingt.Size = new System.Drawing.Size(38, 17);
            this.chkVingt.TabIndex = 4;
            this.chkVingt.Text = "20";
            this.chkVingt.UseVisualStyleBackColor = true;
            this.chkVingt.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkTrente
            // 
            this.chkTrente.AccessibleDescription = "";
            this.chkTrente.AutoSize = true;
            this.chkTrente.Location = new System.Drawing.Point(91, 26);
            this.chkTrente.Name = "chkTrente";
            this.chkTrente.Size = new System.Drawing.Size(38, 17);
            this.chkTrente.TabIndex = 3;
            this.chkTrente.Text = "30";
            this.chkTrente.UseVisualStyleBackColor = true;
            this.chkTrente.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkQuinze
            // 
            this.chkQuinze.AutoSize = true;
            this.chkQuinze.Location = new System.Drawing.Point(91, 3);
            this.chkQuinze.Name = "chkQuinze";
            this.chkQuinze.Size = new System.Drawing.Size(38, 17);
            this.chkQuinze.TabIndex = 2;
            this.chkQuinze.Text = "15";
            this.chkQuinze.UseVisualStyleBackColor = true;
            this.chkQuinze.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkVingtCinq
            // 
            this.chkVingtCinq.AutoSize = true;
            this.chkVingtCinq.Location = new System.Drawing.Point(3, 26);
            this.chkVingtCinq.Name = "chkVingtCinq";
            this.chkVingtCinq.Size = new System.Drawing.Size(38, 17);
            this.chkVingtCinq.TabIndex = 1;
            this.chkVingtCinq.Text = "25";
            this.chkVingtCinq.UseVisualStyleBackColor = true;
            this.chkVingtCinq.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // chkDix
            // 
            this.chkDix.AutoSize = true;
            this.chkDix.Location = new System.Drawing.Point(3, 3);
            this.chkDix.Name = "chkDix";
            this.chkDix.Size = new System.Drawing.Size(38, 17);
            this.chkDix.TabIndex = 0;
            this.chkDix.Text = "10";
            this.chkDix.UseVisualStyleBackColor = true;
            this.chkDix.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // nudNombre
            // 
            this.nudNombre.Enabled = false;
            this.nudNombre.Location = new System.Drawing.Point(19, 176);
            this.nudNombre.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudNombre.Name = "nudNombre";
            this.nudNombre.Size = new System.Drawing.Size(258, 20);
            this.nudNombre.TabIndex = 9;
            this.nudNombre.ValueChanged += new System.EventHandler(this.nudPourcentage_ValueChanged);
            // 
            // FormSpecificationAttributs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(293, 270);
            this.Controls.Add(this.nudNombre);
            this.Controls.Add(this.pnlPourcentage);
            this.Controls.Add(this.pnlMgie);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSpec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSpecificationAttributs";
            this.Text = "Spécifications";
            this.Load += new System.EventHandler(this.FormSpecificationAttributs_Load);
            this.Resize += new System.EventHandler(this.FormSpecificationAttributs_Resize);
            this.pnlMgie.ResumeLayout(false);
            this.pnlMgie.PerformLayout();
            this.pnlPourcentage.ResumeLayout(false);
            this.pnlPourcentage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlMgie;
        private System.Windows.Forms.CheckBox chkCeleste;
        private System.Windows.Forms.CheckBox chkIgnee;
        private System.Windows.Forms.CheckBox chkAquatique;
        private System.Windows.Forms.CheckBox chkNeutre;
        private System.Windows.Forms.CheckBox chkDivine;
        private System.Windows.Forms.CheckBox chkCorrompue;
        private System.Windows.Forms.CheckBox chkNature;
        private System.Windows.Forms.CheckBox chkTerrestre;
        private System.Windows.Forms.Panel pnlPourcentage;
        private System.Windows.Forms.CheckBox chkQuaranteCinq;
        private System.Windows.Forms.CheckBox chkQuarante;
        private System.Windows.Forms.CheckBox chkTrenteCinq;
        private System.Windows.Forms.CheckBox chkVingt;
        private System.Windows.Forms.CheckBox chkTrente;
        private System.Windows.Forms.CheckBox chkQuinze;
        private System.Windows.Forms.CheckBox chkVingtCinq;
        private System.Windows.Forms.CheckBox chkDix;
        private System.Windows.Forms.CheckBox chkCinquante;
        private System.Windows.Forms.NumericUpDown nudNombre;
    }
}