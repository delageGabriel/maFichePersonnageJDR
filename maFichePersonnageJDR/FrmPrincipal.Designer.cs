
namespace maFichePersonnageJDR
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnCreerPersonnage = new System.Windows.Forms.Button();
            this.cbbEditPersonnage = new System.Windows.Forms.ComboBox();
            this.lblEditPersonnage = new System.Windows.Forms.Label();
            this.lblDeletePersonnage = new System.Windows.Forms.Label();
            this.cbbDeletePersonnage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCreerPersonnage
            // 
            this.btnCreerPersonnage.Location = new System.Drawing.Point(55, 12);
            this.btnCreerPersonnage.Name = "btnCreerPersonnage";
            this.btnCreerPersonnage.Size = new System.Drawing.Size(104, 37);
            this.btnCreerPersonnage.TabIndex = 5;
            this.btnCreerPersonnage.Text = "Créer un nouveau \r\npersonnage";
            this.btnCreerPersonnage.UseVisualStyleBackColor = true;
            this.btnCreerPersonnage.Click += new System.EventHandler(this.btnCreerPersonnage_Click);
            // 
            // cbbEditPersonnage
            // 
            this.cbbEditPersonnage.FormattingEnabled = true;
            this.cbbEditPersonnage.Location = new System.Drawing.Point(43, 91);
            this.cbbEditPersonnage.Name = "cbbEditPersonnage";
            this.cbbEditPersonnage.Size = new System.Drawing.Size(127, 21);
            this.cbbEditPersonnage.TabIndex = 6;
            this.cbbEditPersonnage.Text = "Éditer un personnage";
            this.cbbEditPersonnage.SelectedIndexChanged += new System.EventHandler(this.cbbEditPersonnage_SelectedIndexChanged);
            // 
            // lblEditPersonnage
            // 
            this.lblEditPersonnage.AutoSize = true;
            this.lblEditPersonnage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPersonnage.Location = new System.Drawing.Point(51, 71);
            this.lblEditPersonnage.Name = "lblEditPersonnage";
            this.lblEditPersonnage.Size = new System.Drawing.Size(108, 13);
            this.lblEditPersonnage.TabIndex = 7;
            this.lblEditPersonnage.Text = "Éditer un personnage";
            // 
            // lblDeletePersonnage
            // 
            this.lblDeletePersonnage.AutoSize = true;
            this.lblDeletePersonnage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletePersonnage.Location = new System.Drawing.Point(42, 133);
            this.lblDeletePersonnage.Name = "lblDeletePersonnage";
            this.lblDeletePersonnage.Size = new System.Drawing.Size(128, 13);
            this.lblDeletePersonnage.TabIndex = 9;
            this.lblDeletePersonnage.Text = "Supprimer un personnage";
            // 
            // cbbDeletePersonnage
            // 
            this.cbbDeletePersonnage.FormattingEnabled = true;
            this.cbbDeletePersonnage.Location = new System.Drawing.Point(31, 151);
            this.cbbDeletePersonnage.Name = "cbbDeletePersonnage";
            this.cbbDeletePersonnage.Size = new System.Drawing.Size(148, 21);
            this.cbbDeletePersonnage.TabIndex = 8;
            this.cbbDeletePersonnage.Text = "Supprimer un personnage";
            this.cbbDeletePersonnage.SelectedIndexChanged += new System.EventHandler(this.cbbDeletePersonnage_SelectedIndexChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 200);
            this.Controls.Add(this.lblDeletePersonnage);
            this.Controls.Add(this.cbbDeletePersonnage);
            this.Controls.Add(this.lblEditPersonnage);
            this.Controls.Add(this.cbbEditPersonnage);
            this.Controls.Add(this.btnCreerPersonnage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Resize += new System.EventHandler(this.FrmPrincipal_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreerPersonnage;
        private System.Windows.Forms.ComboBox cbbEditPersonnage;
        private System.Windows.Forms.Label lblEditPersonnage;
        private System.Windows.Forms.Label lblDeletePersonnage;
        private System.Windows.Forms.ComboBox cbbDeletePersonnage;
    }
}

