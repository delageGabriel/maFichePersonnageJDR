
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
            this.btnFormCompAttri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormCompAttri
            // 
            this.btnFormCompAttri.Location = new System.Drawing.Point(295, 53);
            this.btnFormCompAttri.Name = "btnFormCompAttri";
            this.btnFormCompAttri.Size = new System.Drawing.Size(142, 23);
            this.btnFormCompAttri.TabIndex = 0;
            this.btnFormCompAttri.Text = "Compétences et Attributs";
            this.btnFormCompAttri.UseVisualStyleBackColor = true;
            this.btnFormCompAttri.Click += new System.EventHandler(this.btnFormCompAttri_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormCompAttri);
            this.Name = "FrmPrincipal";
            this.Text = "Formulaire Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormCompAttri;
    }
}

