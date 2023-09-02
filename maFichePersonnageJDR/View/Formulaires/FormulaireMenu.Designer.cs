
namespace maFichePersonnageJDR.View.Formulaires
{
    partial class FormulaireMenu
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
            this.btnInformationsGenerales = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnMagieAptitudes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInformationsGenerales
            // 
            this.btnInformationsGenerales.Location = new System.Drawing.Point(64, 12);
            this.btnInformationsGenerales.Name = "btnInformationsGenerales";
            this.btnInformationsGenerales.Size = new System.Drawing.Size(153, 23);
            this.btnInformationsGenerales.TabIndex = 0;
            this.btnInformationsGenerales.Text = "Informations générales";
            this.btnInformationsGenerales.UseVisualStyleBackColor = true;
            this.btnInformationsGenerales.Click += new System.EventHandler(this.btnInformationsGenerales_Click);
            // 
            // btnEquipment
            // 
            this.btnEquipment.Location = new System.Drawing.Point(30, 52);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnEquipment.TabIndex = 1;
            this.btnEquipment.Text = "Équipements";
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnMagieAptitudes
            // 
            this.btnMagieAptitudes.Location = new System.Drawing.Point(157, 52);
            this.btnMagieAptitudes.Name = "btnMagieAptitudes";
            this.btnMagieAptitudes.Size = new System.Drawing.Size(118, 23);
            this.btnMagieAptitudes.TabIndex = 2;
            this.btnMagieAptitudes.Text = "Magies et Aptitudes";
            this.btnMagieAptitudes.UseVisualStyleBackColor = true;
            this.btnMagieAptitudes.Click += new System.EventHandler(this.btnMagieAptitudes_Click);
            // 
            // FormulaireMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.btnMagieAptitudes);
            this.Controls.Add(this.btnEquipment);
            this.Controls.Add(this.btnInformationsGenerales);
            this.Name = "FormulaireMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInformationsGenerales;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnMagieAptitudes;
    }
}