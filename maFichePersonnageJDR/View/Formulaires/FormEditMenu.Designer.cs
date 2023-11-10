
namespace maFichePersonnageJDR.View.Formulaires
{
    partial class FormEditMenu
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
            this.btnInfosGenerales = new System.Windows.Forms.Button();
            this.btnAttributs = new System.Windows.Forms.Button();
            this.btnCompCarac = new System.Windows.Forms.Button();
            this.btnEquipement = new System.Windows.Forms.Button();
            this.btnMagiesAptitudes = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInfosGenerales
            // 
            this.btnInfosGenerales.Location = new System.Drawing.Point(36, 12);
            this.btnInfosGenerales.Name = "btnInfosGenerales";
            this.btnInfosGenerales.Size = new System.Drawing.Size(126, 23);
            this.btnInfosGenerales.TabIndex = 0;
            this.btnInfosGenerales.Text = "Informations générales";
            this.btnInfosGenerales.UseVisualStyleBackColor = true;
            this.btnInfosGenerales.Click += new System.EventHandler(this.btnInfosGenerales_Click);
            // 
            // btnAttributs
            // 
            this.btnAttributs.Location = new System.Drawing.Point(36, 56);
            this.btnAttributs.Name = "btnAttributs";
            this.btnAttributs.Size = new System.Drawing.Size(126, 23);
            this.btnAttributs.TabIndex = 1;
            this.btnAttributs.Text = "Attributs";
            this.btnAttributs.UseVisualStyleBackColor = true;
            this.btnAttributs.Click += new System.EventHandler(this.btnAttributs_Click);
            // 
            // btnCompCarac
            // 
            this.btnCompCarac.Location = new System.Drawing.Point(36, 106);
            this.btnCompCarac.Name = "btnCompCarac";
            this.btnCompCarac.Size = new System.Drawing.Size(126, 40);
            this.btnCompCarac.TabIndex = 2;
            this.btnCompCarac.Text = "Caractéristiques et Compétences";
            this.btnCompCarac.UseVisualStyleBackColor = true;
            this.btnCompCarac.Click += new System.EventHandler(this.btnCompCarac_Click);
            // 
            // btnEquipement
            // 
            this.btnEquipement.Location = new System.Drawing.Point(36, 171);
            this.btnEquipement.Name = "btnEquipement";
            this.btnEquipement.Size = new System.Drawing.Size(126, 23);
            this.btnEquipement.TabIndex = 3;
            this.btnEquipement.Text = "Équipements";
            this.btnEquipement.UseVisualStyleBackColor = true;
            this.btnEquipement.Click += new System.EventHandler(this.btnEquipement_Click);
            // 
            // btnMagiesAptitudes
            // 
            this.btnMagiesAptitudes.Location = new System.Drawing.Point(36, 222);
            this.btnMagiesAptitudes.Name = "btnMagiesAptitudes";
            this.btnMagiesAptitudes.Size = new System.Drawing.Size(126, 23);
            this.btnMagiesAptitudes.TabIndex = 4;
            this.btnMagiesAptitudes.Text = "Magies et Aptitudes";
            this.btnMagiesAptitudes.UseVisualStyleBackColor = true;
            this.btnMagiesAptitudes.Click += new System.EventHandler(this.btnMagiesAptitudes_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(62, 266);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FormEditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 301);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnMagiesAptitudes);
            this.Controls.Add(this.btnEquipement);
            this.Controls.Add(this.btnCompCarac);
            this.Controls.Add(this.btnAttributs);
            this.Controls.Add(this.btnInfosGenerales);
            this.Name = "FormEditMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfosGenerales;
        private System.Windows.Forms.Button btnAttributs;
        private System.Windows.Forms.Button btnCompCarac;
        private System.Windows.Forms.Button btnEquipement;
        private System.Windows.Forms.Button btnMagiesAptitudes;
        private System.Windows.Forms.Button btnRetour;
    }
}