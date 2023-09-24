
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
            this.btnCreerPersonnage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreerPersonnage
            // 
            this.btnCreerPersonnage.Location = new System.Drawing.Point(69, 12);
            this.btnCreerPersonnage.Name = "btnCreerPersonnage";
            this.btnCreerPersonnage.Size = new System.Drawing.Size(104, 37);
            this.btnCreerPersonnage.TabIndex = 5;
            this.btnCreerPersonnage.Text = "Créer un nouveau \r\npersonnage";
            this.btnCreerPersonnage.UseVisualStyleBackColor = true;
            this.btnCreerPersonnage.Click += new System.EventHandler(this.btnCreerPersonnage_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 200);
            this.Controls.Add(this.btnCreerPersonnage);
            this.Name = "FrmPrincipal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreerPersonnage;
    }
}

