
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
            this.btnAjoutSortilegeAptitude = new System.Windows.Forms.Button();
            this.gpbInventaires = new System.Windows.Forms.GroupBox();
            this.gpbInventaires.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbInventaires
            // 
            this.cbbInventaires.FormattingEnabled = true;
            this.cbbInventaires.Location = new System.Drawing.Point(37, 68);
            this.cbbInventaires.Name = "cbbInventaires";
            this.cbbInventaires.Size = new System.Drawing.Size(121, 21);
            this.cbbInventaires.TabIndex = 1;
            this.cbbInventaires.Text = "Aucune options";
            // 
            // btnAjoutSortilegeAptitude
            // 
            this.btnAjoutSortilegeAptitude.AutoEllipsis = true;
            this.btnAjoutSortilegeAptitude.Location = new System.Drawing.Point(61, 39);
            this.btnAjoutSortilegeAptitude.Name = "btnAjoutSortilegeAptitude";
            this.btnAjoutSortilegeAptitude.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutSortilegeAptitude.TabIndex = 2;
            this.btnAjoutSortilegeAptitude.Text = "Ajouter";
            this.btnAjoutSortilegeAptitude.UseVisualStyleBackColor = true;
            this.btnAjoutSortilegeAptitude.Click += new System.EventHandler(this.btnAjoutSortilegeAptitude_Click);
            // 
            // gpbInventaires
            // 
            this.gpbInventaires.AutoSize = true;
            this.gpbInventaires.BackColor = System.Drawing.SystemColors.Window;
            this.gpbInventaires.Controls.Add(this.btnAjoutSortilegeAptitude);
            this.gpbInventaires.Controls.Add(this.cbbInventaires);
            this.gpbInventaires.Location = new System.Drawing.Point(12, 9);
            this.gpbInventaires.Name = "gpbInventaires";
            this.gpbInventaires.Size = new System.Drawing.Size(200, 100);
            this.gpbInventaires.TabIndex = 3;
            this.gpbInventaires.TabStop = false;
            this.gpbInventaires.Text = "Inventaires";
            // 
            // FormulaireTalentsEtObjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(666, 341);
            this.Controls.Add(this.gpbInventaires);
            this.Name = "FormulaireTalentsEtObjets";
            this.Text = "FormulaireDonsEtObjets";
            this.Load += new System.EventHandler(this.FormulaireTalentsEtObjets_Load);
            this.gpbInventaires.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbInventaires;
        private System.Windows.Forms.Button btnAjoutSortilegeAptitude;
        private System.Windows.Forms.GroupBox gpbInventaires;
    }
}