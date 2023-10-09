
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
            this.txtSpec = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMgie = new System.Windows.Forms.Panel();
            this.chkAquatique = new System.Windows.Forms.CheckBox();
            this.chkIgnee = new System.Windows.Forms.CheckBox();
            this.chkCeleste = new System.Windows.Forms.CheckBox();
            this.chkTerrestre = new System.Windows.Forms.CheckBox();
            this.chkNature = new System.Windows.Forms.CheckBox();
            this.chkCorrompue = new System.Windows.Forms.CheckBox();
            this.chkDivine = new System.Windows.Forms.CheckBox();
            this.chkNeutre = new System.Windows.Forms.CheckBox();
            this.pnlMgie.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSpec
            // 
            this.txtSpec.Location = new System.Drawing.Point(51, 107);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(193, 20);
            this.txtSpec.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(68, 142);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
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
            this.pnlMgie.Location = new System.Drawing.Point(19, 10);
            this.pnlMgie.Name = "pnlMgie";
            this.pnlMgie.Size = new System.Drawing.Size(258, 91);
            this.pnlMgie.TabIndex = 3;
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
            // FormSpecificationAttributs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 179);
            this.Controls.Add(this.pnlMgie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSpec);
            this.Name = "FormSpecificationAttributs";
            this.Text = "Spécifications";
            this.pnlMgie.ResumeLayout(false);
            this.pnlMgie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpec;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlMgie;
        private System.Windows.Forms.CheckBox chkCeleste;
        private System.Windows.Forms.CheckBox chkIgnee;
        private System.Windows.Forms.CheckBox chkAquatique;
        private System.Windows.Forms.CheckBox chkNeutre;
        private System.Windows.Forms.CheckBox chkDivine;
        private System.Windows.Forms.CheckBox chkCorrompue;
        private System.Windows.Forms.CheckBox chkNature;
        private System.Windows.Forms.CheckBox chkTerrestre;
    }
}