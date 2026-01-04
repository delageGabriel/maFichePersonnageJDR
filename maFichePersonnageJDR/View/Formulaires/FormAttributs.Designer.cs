
namespace maFichePersonnageJDR.View.Formulaires
{
    partial class FormAttributs
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
            this.lblEffetsAttribut = new System.Windows.Forms.Label();
            this.lblTypeAttribut = new System.Windows.Forms.Label();
            this.lblNomAttribut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEffetsAttribut
            // 
            this.lblEffetsAttribut.AutoSize = true;
            this.lblEffetsAttribut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffetsAttribut.Location = new System.Drawing.Point(12, 117);
            this.lblEffetsAttribut.Name = "lblEffetsAttribut";
            this.lblEffetsAttribut.Size = new System.Drawing.Size(60, 20);
            this.lblEffetsAttribut.TabIndex = 33;
            this.lblEffetsAttribut.Text = "Effets :";
            // 
            // lblTypeAttribut
            // 
            this.lblTypeAttribut.AutoSize = true;
            this.lblTypeAttribut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeAttribut.Location = new System.Drawing.Point(12, 63);
            this.lblTypeAttribut.Name = "lblTypeAttribut";
            this.lblTypeAttribut.Size = new System.Drawing.Size(51, 20);
            this.lblTypeAttribut.TabIndex = 29;
            this.lblTypeAttribut.Text = "Type :";
            // 
            // lblNomAttribut
            // 
            this.lblNomAttribut.AutoSize = true;
            this.lblNomAttribut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAttribut.Location = new System.Drawing.Point(12, 9);
            this.lblNomAttribut.Name = "lblNomAttribut";
            this.lblNomAttribut.Size = new System.Drawing.Size(50, 20);
            this.lblNomAttribut.TabIndex = 28;
            this.lblNomAttribut.Text = "Nom :";
            // 
            // FormAttributs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 253);
            this.Controls.Add(this.lblEffetsAttribut);
            this.Controls.Add(this.lblTypeAttribut);
            this.Controls.Add(this.lblNomAttribut);
            this.Name = "FormAttributs";
            this.Text = "FormAttributs";
            this.Load += new System.EventHandler(this.FormAttributs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEffetsAttribut;
        private System.Windows.Forms.Label lblTypeAttribut;
        private System.Windows.Forms.Label lblNomAttribut;
    }
}