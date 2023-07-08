
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
            this.btnSoumettreFiche = new System.Windows.Forms.Button();
            this.pbEtatFiche = new System.Windows.Forms.ProgressBar();
            this.btnEquipments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormCompAttri
            // 
            this.btnFormCompAttri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormCompAttri.Location = new System.Drawing.Point(33, 41);
            this.btnFormCompAttri.Name = "btnFormCompAttri";
            this.btnFormCompAttri.Size = new System.Drawing.Size(138, 23);
            this.btnFormCompAttri.TabIndex = 0;
            this.btnFormCompAttri.Text = "Compétences et Attributs";
            this.btnFormCompAttri.UseVisualStyleBackColor = true;
            this.btnFormCompAttri.Click += new System.EventHandler(this.btnFormCompAttri_Click);
            // 
            // btnInfosGenerales
            // 
            this.btnInfosGenerales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfosGenerales.Location = new System.Drawing.Point(33, 12);
            this.btnInfosGenerales.Name = "btnInfosGenerales";
            this.btnInfosGenerales.Size = new System.Drawing.Size(138, 23);
            this.btnInfosGenerales.TabIndex = 1;
            this.btnInfosGenerales.Text = "Informations générales";
            this.btnInfosGenerales.UseVisualStyleBackColor = true;
            this.btnInfosGenerales.Click += new System.EventHandler(this.btnInfosGenerales_Click);
            // 
            // btnTalentEtEquipement
            // 
            this.btnTalentEtEquipement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTalentEtEquipement.Location = new System.Drawing.Point(33, 70);
            this.btnTalentEtEquipement.Name = "btnTalentEtEquipement";
            this.btnTalentEtEquipement.Size = new System.Drawing.Size(138, 23);
            this.btnTalentEtEquipement.TabIndex = 2;
            this.btnTalentEtEquipement.Text = "Talent et Équipement";
            this.btnTalentEtEquipement.UseVisualStyleBackColor = true;
            this.btnTalentEtEquipement.Click += new System.EventHandler(this.btnTalentEtEquipement_Click);
            // 
            // btnSoumettreFiche
            // 
            this.btnSoumettreFiche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoumettreFiche.Location = new System.Drawing.Point(93, 124);
            this.btnSoumettreFiche.Name = "btnSoumettreFiche";
            this.btnSoumettreFiche.Size = new System.Drawing.Size(99, 23);
            this.btnSoumettreFiche.TabIndex = 3;
            this.btnSoumettreFiche.Text = "Soumettre la fiche";
            this.btnSoumettreFiche.UseVisualStyleBackColor = true;
            this.btnSoumettreFiche.Click += new System.EventHandler(this.btnSoumettreFiche_Click);
            // 
            // pbEtatFiche
            // 
            this.pbEtatFiche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEtatFiche.Location = new System.Drawing.Point(33, 161);
            this.pbEtatFiche.Margin = new System.Windows.Forms.Padding(2);
            this.pbEtatFiche.Name = "pbEtatFiche";
            this.pbEtatFiche.Size = new System.Drawing.Size(138, 22);
            this.pbEtatFiche.TabIndex = 4;
            // 
            // btnEquipments
            // 
            this.btnEquipments.Location = new System.Drawing.Point(12, 99);
            this.btnEquipments.Name = "btnEquipments";
            this.btnEquipments.Size = new System.Drawing.Size(75, 23);
            this.btnEquipments.TabIndex = 5;
            this.btnEquipments.Text = "Equipements";
            this.btnEquipments.UseVisualStyleBackColor = true;
            this.btnEquipments.Click += new System.EventHandler(this.btnEquipments_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 200);
            this.Controls.Add(this.btnEquipments);
            this.Controls.Add(this.pbEtatFiche);
            this.Controls.Add(this.btnSoumettreFiche);
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
        private System.Windows.Forms.Button btnSoumettreFiche;
        private System.Windows.Forms.ProgressBar pbEtatFiche;
        private System.Windows.Forms.Button btnEquipments;
    }
}

