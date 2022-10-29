
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
            this.txtPhysique = new System.Windows.Forms.TextBox();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.txtMental = new System.Windows.Forms.TextBox();
            this.lblMental = new System.Windows.Forms.Label();
            this.txtSocial = new System.Windows.Forms.TextBox();
            this.lblSocial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPhysique
            // 
            this.lblPhysique.AutoSize = true;
            this.lblPhysique.Location = new System.Drawing.Point(59, 26);
            this.lblPhysique.Name = "lblPhysique";
            this.lblPhysique.Size = new System.Drawing.Size(50, 13);
            this.lblPhysique.TabIndex = 0;
            this.lblPhysique.Text = "Physique";
            // 
            // txtPhysique
            // 
            this.txtPhysique.Location = new System.Drawing.Point(35, 42);
            this.txtPhysique.Name = "txtPhysique";
            this.txtPhysique.Size = new System.Drawing.Size(100, 20);
            this.txtPhysique.TabIndex = 1;
            this.txtPhysique.TextChanged += new System.EventHandler(this.txtPhysique_TextChanged);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(310, 91);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(75, 23);
            this.btnSauvegarder.TabIndex = 2;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // txtMental
            // 
            this.txtMental.Location = new System.Drawing.Point(35, 91);
            this.txtMental.Name = "txtMental";
            this.txtMental.Size = new System.Drawing.Size(100, 20);
            this.txtMental.TabIndex = 4;
            this.txtMental.TextChanged += new System.EventHandler(this.txtMental_TextChanged);
            // 
            // lblMental
            // 
            this.lblMental.AutoSize = true;
            this.lblMental.Location = new System.Drawing.Point(59, 75);
            this.lblMental.Name = "lblMental";
            this.lblMental.Size = new System.Drawing.Size(39, 13);
            this.lblMental.TabIndex = 3;
            this.lblMental.Text = "Mental";
            // 
            // txtSocial
            // 
            this.txtSocial.Location = new System.Drawing.Point(35, 137);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(100, 20);
            this.txtSocial.TabIndex = 6;
            this.txtSocial.TextChanged += new System.EventHandler(this.txtSocial_TextChanged);
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.Location = new System.Drawing.Point(59, 121);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(36, 13);
            this.lblSocial.TabIndex = 5;
            this.lblSocial.Text = "Social";
            // 
            // FormulaireCompAttri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSocial);
            this.Controls.Add(this.lblSocial);
            this.Controls.Add(this.txtMental);
            this.Controls.Add(this.lblMental);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.txtPhysique);
            this.Controls.Add(this.lblPhysique);
            this.Name = "FormulaireCompAttri";
            this.Text = "FormulaireCompAttri";
            this.Load += new System.EventHandler(this.FormulaireCompAttri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhysique;
        private System.Windows.Forms.TextBox txtPhysique;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.TextBox txtMental;
        private System.Windows.Forms.Label lblMental;
        private System.Windows.Forms.TextBox txtSocial;
        private System.Windows.Forms.Label lblSocial;
    }
}