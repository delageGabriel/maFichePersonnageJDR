
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
            this.btnInfosGenerales = new System.Windows.Forms.Button();
            this.btnTalentEtEquipement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormCompAttri
            // 
            this.btnFormCompAttri.Location = new System.Drawing.Point(39, 12);
            this.btnFormCompAttri.Name = "btnFormCompAttri";
            this.btnFormCompAttri.Size = new System.Drawing.Size(142, 23);
            this.btnFormCompAttri.TabIndex = 0;
            this.btnFormCompAttri.Text = "Compétences et Attributs";
            this.btnFormCompAttri.UseVisualStyleBackColor = true;
            this.btnFormCompAttri.Click += new System.EventHandler(this.btnFormCompAttri_Click);
            // 
            // btnInfosGenerales
            // 
            this.btnInfosGenerales.Location = new System.Drawing.Point(39, 64);
            this.btnInfosGenerales.Name = "btnInfosGenerales";
            this.btnInfosGenerales.Size = new System.Drawing.Size(142, 23);
            this.btnInfosGenerales.TabIndex = 1;
            this.btnInfosGenerales.Text = "Informations générales";
            this.btnInfosGenerales.UseVisualStyleBackColor = true;
            this.btnInfosGenerales.Click += new System.EventHandler(this.btnInfosGenerales_Click);
            // 
            // btnTalentEtEquipement
            // 
            this.btnTalentEtEquipement.Location = new System.Drawing.Point(39, 116);
            this.btnTalentEtEquipement.Name = "btnTalentEtEquipement";
            this.btnTalentEtEquipement.Size = new System.Drawing.Size(142, 23);
            this.btnTalentEtEquipement.TabIndex = 2;
            this.btnTalentEtEquipement.Text = "Talent et Équipement";
            this.btnTalentEtEquipement.UseVisualStyleBackColor = true;
            this.btnTalentEtEquipement.Click += new System.EventHandler(this.btnTalentEtEquipement_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 151);
            this.Controls.Add(this.btnTalentEtEquipement);
            this.Controls.Add(this.btnInfosGenerales);
            this.Controls.Add(this.btnFormCompAttri);
            this.Name = "FrmPrincipal";
            this.Text = "Formulaire Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormCompAttri;
        private System.Windows.Forms.Button btnInfosGenerales;
        private System.Windows.Forms.Button btnTalentEtEquipement;
    }
}

