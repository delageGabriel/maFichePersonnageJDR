
namespace maFichePersonnageJDR.Formulaires
{
    partial class FormulaireTalentsEtObjets
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
            this.gpbInventaires = new System.Windows.Forms.GroupBox();
            this.gpbSortilegesAptitudes = new System.Windows.Forms.GroupBox();
            this.cbbSortileges = new System.Windows.Forms.ComboBox();
            this.btnAjouterTalents = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.lblNomInventaire = new System.Windows.Forms.Label();
            this.lblPorteeInventaire = new System.Windows.Forms.Label();
            this.lblPoidsInventaire = new System.Windows.Forms.Label();
            this.lblNombreInventaire = new System.Windows.Forms.Label();
            this.lblTypeInventaire = new System.Windows.Forms.Label();
            this.lblDegatsInventaire = new System.Windows.Forms.Label();
            this.lblGlaive = new System.Windows.Forms.Label();
            this.lblGlaivePoids = new System.Windows.Forms.Label();
            this.lblGlaivePortee = new System.Windows.Forms.Label();
            this.gpbInventaires.SuspendLayout();
            this.gpbSortilegesAptitudes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInventaires
            // 
            this.gpbInventaires.AutoSize = true;
            this.gpbInventaires.BackColor = System.Drawing.SystemColors.Window;
            this.gpbInventaires.Controls.Add(this.lblGlaivePortee);
            this.gpbInventaires.Controls.Add(this.lblGlaivePoids);
            this.gpbInventaires.Controls.Add(this.lblGlaive);
            this.gpbInventaires.Controls.Add(this.lblDegatsInventaire);
            this.gpbInventaires.Controls.Add(this.lblTypeInventaire);
            this.gpbInventaires.Controls.Add(this.lblNombreInventaire);
            this.gpbInventaires.Controls.Add(this.lblPoidsInventaire);
            this.gpbInventaires.Controls.Add(this.lblPorteeInventaire);
            this.gpbInventaires.Controls.Add(this.lblNomInventaire);
            this.gpbInventaires.Location = new System.Drawing.Point(12, 22);
            this.gpbInventaires.Name = "gpbInventaires";
            this.gpbInventaires.Size = new System.Drawing.Size(431, 345);
            this.gpbInventaires.TabIndex = 3;
            this.gpbInventaires.TabStop = false;
            this.gpbInventaires.Text = "Inventaires";
            // 
            // gpbSortilegesAptitudes
            // 
            this.gpbSortilegesAptitudes.AutoSize = true;
            this.gpbSortilegesAptitudes.BackColor = System.Drawing.SystemColors.Window;
            this.gpbSortilegesAptitudes.Controls.Add(this.cbbSortileges);
            this.gpbSortilegesAptitudes.Controls.Add(this.btnAjouterTalents);
            this.gpbSortilegesAptitudes.Location = new System.Drawing.Point(613, 41);
            this.gpbSortilegesAptitudes.Name = "gpbSortilegesAptitudes";
            this.gpbSortilegesAptitudes.Size = new System.Drawing.Size(200, 110);
            this.gpbSortilegesAptitudes.TabIndex = 4;
            this.gpbSortilegesAptitudes.TabStop = false;
            this.gpbSortilegesAptitudes.Text = "Talents";
            // 
            // cbbSortileges
            // 
            this.cbbSortileges.DropDownWidth = 200;
            this.cbbSortileges.FormattingEnabled = true;
            this.cbbSortileges.Location = new System.Drawing.Point(64, 41);
            this.cbbSortileges.Name = "cbbSortileges";
            this.cbbSortileges.Size = new System.Drawing.Size(82, 21);
            this.cbbSortileges.TabIndex = 1;
            this.cbbSortileges.Text = "Sortilèges";
            // 
            // btnAjouterTalents
            // 
            this.btnAjouterTalents.Location = new System.Drawing.Point(64, 68);
            this.btnAjouterTalents.Name = "btnAjouterTalents";
            this.btnAjouterTalents.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterTalents.TabIndex = 0;
            this.btnAjouterTalents.Text = "Ajouter";
            this.btnAjouterTalents.UseVisualStyleBackColor = true;
            this.btnAjouterTalents.Click += new System.EventHandler(this.btnAjouterSortileges_Click);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(498, 12);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(75, 23);
            this.btnSauvegarder.TabIndex = 5;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // lblNomInventaire
            // 
            this.lblNomInventaire.AutoSize = true;
            this.lblNomInventaire.Location = new System.Drawing.Point(17, 19);
            this.lblNomInventaire.Name = "lblNomInventaire";
            this.lblNomInventaire.Size = new System.Drawing.Size(29, 13);
            this.lblNomInventaire.TabIndex = 0;
            this.lblNomInventaire.Text = "Nom";
            // 
            // lblPorteeInventaire
            // 
            this.lblPorteeInventaire.AutoSize = true;
            this.lblPorteeInventaire.Location = new System.Drawing.Point(132, 19);
            this.lblPorteeInventaire.Name = "lblPorteeInventaire";
            this.lblPorteeInventaire.Size = new System.Drawing.Size(38, 13);
            this.lblPorteeInventaire.TabIndex = 1;
            this.lblPorteeInventaire.Text = "Portée";
            // 
            // lblPoidsInventaire
            // 
            this.lblPoidsInventaire.AutoSize = true;
            this.lblPoidsInventaire.Location = new System.Drawing.Point(72, 19);
            this.lblPoidsInventaire.Name = "lblPoidsInventaire";
            this.lblPoidsInventaire.Size = new System.Drawing.Size(33, 13);
            this.lblPoidsInventaire.TabIndex = 2;
            this.lblPoidsInventaire.Text = "Poids";
            // 
            // lblNombreInventaire
            // 
            this.lblNombreInventaire.AutoSize = true;
            this.lblNombreInventaire.Location = new System.Drawing.Point(193, 19);
            this.lblNombreInventaire.Name = "lblNombreInventaire";
            this.lblNombreInventaire.Size = new System.Drawing.Size(44, 13);
            this.lblNombreInventaire.TabIndex = 3;
            this.lblNombreInventaire.Text = "Nombre";
            // 
            // lblTypeInventaire
            // 
            this.lblTypeInventaire.AutoSize = true;
            this.lblTypeInventaire.Location = new System.Drawing.Point(259, 19);
            this.lblTypeInventaire.Name = "lblTypeInventaire";
            this.lblTypeInventaire.Size = new System.Drawing.Size(31, 13);
            this.lblTypeInventaire.TabIndex = 4;
            this.lblTypeInventaire.Text = "Type";
            // 
            // lblDegatsInventaire
            // 
            this.lblDegatsInventaire.AutoSize = true;
            this.lblDegatsInventaire.Location = new System.Drawing.Point(316, 19);
            this.lblDegatsInventaire.Name = "lblDegatsInventaire";
            this.lblDegatsInventaire.Size = new System.Drawing.Size(41, 13);
            this.lblDegatsInventaire.TabIndex = 5;
            this.lblDegatsInventaire.Text = "Dégâts";
            // 
            // lblGlaive
            // 
            this.lblGlaive.AutoSize = true;
            this.lblGlaive.Location = new System.Drawing.Point(13, 41);
            this.lblGlaive.Name = "lblGlaive";
            this.lblGlaive.Size = new System.Drawing.Size(37, 13);
            this.lblGlaive.TabIndex = 6;
            this.lblGlaive.Text = "Glaive";
            // 
            // lblGlaivePoids
            // 
            this.lblGlaivePoids.AutoSize = true;
            this.lblGlaivePoids.Location = new System.Drawing.Point(71, 41);
            this.lblGlaivePoids.Name = "lblGlaivePoids";
            this.lblGlaivePoids.Size = new System.Drawing.Size(34, 13);
            this.lblGlaivePoids.TabIndex = 7;
            this.lblGlaivePoids.Text = "1.0kg";
            // 
            // lblGlaivePortee
            // 
            this.lblGlaivePortee.AutoSize = true;
            this.lblGlaivePortee.Location = new System.Drawing.Point(136, 41);
            this.lblGlaivePortee.Name = "lblGlaivePortee";
            this.lblGlaivePortee.Size = new System.Drawing.Size(24, 13);
            this.lblGlaivePortee.TabIndex = 8;
            this.lblGlaivePortee.Text = "1 m";
            // 
            // FormulaireTalentsEtObjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(848, 393);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.gpbSortilegesAptitudes);
            this.Controls.Add(this.gpbInventaires);
            this.Name = "FormulaireTalentsEtObjets";
            this.Text = "FormulaireDonsEtObjets";
            this.Load += new System.EventHandler(this.FormulaireTalentsEtObjets_Load);
            this.gpbInventaires.ResumeLayout(false);
            this.gpbInventaires.PerformLayout();
            this.gpbSortilegesAptitudes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbInventaires;
        private System.Windows.Forms.GroupBox gpbSortilegesAptitudes;
        private System.Windows.Forms.ComboBox cbbSortileges;
        private System.Windows.Forms.Button btnAjouterTalents;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Label lblPorteeInventaire;
        private System.Windows.Forms.Label lblNomInventaire;
        private System.Windows.Forms.Label lblNombreInventaire;
        private System.Windows.Forms.Label lblPoidsInventaire;
        private System.Windows.Forms.Label lblGlaive;
        private System.Windows.Forms.Label lblDegatsInventaire;
        private System.Windows.Forms.Label lblTypeInventaire;
        private System.Windows.Forms.Label lblGlaivePortee;
        private System.Windows.Forms.Label lblGlaivePoids;
    }
}