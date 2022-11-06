
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
            this.cbbInventaires = new System.Windows.Forms.ComboBox();
            this.btnAjoutObjets = new System.Windows.Forms.Button();
            this.gpbInventaires = new System.Windows.Forms.GroupBox();
            this.gpbSortilegesAptitudes = new System.Windows.Forms.GroupBox();
            this.cbbSortileges = new System.Windows.Forms.ComboBox();
            this.btnAjouterTalents = new System.Windows.Forms.Button();
            this.gpbInventaires.SuspendLayout();
            this.gpbSortilegesAptitudes.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbInventaires
            // 
            this.cbbInventaires.FormattingEnabled = true;
            this.cbbInventaires.Location = new System.Drawing.Point(47, 68);
            this.cbbInventaires.Name = "cbbInventaires";
            this.cbbInventaires.Size = new System.Drawing.Size(99, 21);
            this.cbbInventaires.TabIndex = 1;
            this.cbbInventaires.Text = "Aucune options";
            // 
            // btnAjoutObjets
            // 
            this.btnAjoutObjets.AutoEllipsis = true;
            this.btnAjoutObjets.Location = new System.Drawing.Point(61, 39);
            this.btnAjoutObjets.Name = "btnAjoutObjets";
            this.btnAjoutObjets.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutObjets.TabIndex = 2;
            this.btnAjoutObjets.Text = "Ajouter";
            this.btnAjoutObjets.UseVisualStyleBackColor = true;
            this.btnAjoutObjets.Click += new System.EventHandler(this.btnAjoutSortilegeAptitude_Click);
            // 
            // gpbInventaires
            // 
            this.gpbInventaires.AutoSize = true;
            this.gpbInventaires.BackColor = System.Drawing.SystemColors.Window;
            this.gpbInventaires.Controls.Add(this.btnAjoutObjets);
            this.gpbInventaires.Controls.Add(this.cbbInventaires);
            this.gpbInventaires.Location = new System.Drawing.Point(12, 9);
            this.gpbInventaires.Name = "gpbInventaires";
            this.gpbInventaires.Size = new System.Drawing.Size(200, 108);
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
            this.gpbSortilegesAptitudes.Location = new System.Drawing.Point(366, 9);
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
            // FormulaireTalentsEtObjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(621, 341);
            this.Controls.Add(this.gpbSortilegesAptitudes);
            this.Controls.Add(this.gpbInventaires);
            this.Name = "FormulaireTalentsEtObjets";
            this.Text = "FormulaireDonsEtObjets";
            this.Load += new System.EventHandler(this.FormulaireTalentsEtObjets_Load);
            this.gpbInventaires.ResumeLayout(false);
            this.gpbSortilegesAptitudes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbInventaires;
        private System.Windows.Forms.Button btnAjoutObjets;
        private System.Windows.Forms.GroupBox gpbInventaires;
        private System.Windows.Forms.GroupBox gpbSortilegesAptitudes;
        private System.Windows.Forms.ComboBox cbbSortileges;
        private System.Windows.Forms.Button btnAjouterTalents;
    }
}