
namespace maFichePersonnageJDR.View.Formulaires
{
    partial class FormObjets
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
            this.lblEffetsObjet = new System.Windows.Forms.Label();
            this.lblPoidsObjet = new System.Windows.Forms.Label();
            this.lblValeurObjet = new System.Windows.Forms.Label();
            this.lblConsommableObjet = new System.Windows.Forms.Label();
            this.lblTypeObjet = new System.Windows.Forms.Label();
            this.lblNomObjet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEffetsObjet
            // 
            this.lblEffetsObjet.AutoSize = true;
            this.lblEffetsObjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffetsObjet.Location = new System.Drawing.Point(12, 294);
            this.lblEffetsObjet.Name = "lblEffetsObjet";
            this.lblEffetsObjet.Size = new System.Drawing.Size(60, 20);
            this.lblEffetsObjet.TabIndex = 27;
            this.lblEffetsObjet.Text = "Effets :";
            // 
            // lblPoidsObjet
            // 
            this.lblPoidsObjet.AutoSize = true;
            this.lblPoidsObjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoidsObjet.Location = new System.Drawing.Point(12, 180);
            this.lblPoidsObjet.Name = "lblPoidsObjet";
            this.lblPoidsObjet.Size = new System.Drawing.Size(56, 20);
            this.lblPoidsObjet.TabIndex = 26;
            this.lblPoidsObjet.Text = "Poids :";
            // 
            // lblValeurObjet
            // 
            this.lblValeurObjet.AutoSize = true;
            this.lblValeurObjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValeurObjet.Location = new System.Drawing.Point(12, 237);
            this.lblValeurObjet.Name = "lblValeurObjet";
            this.lblValeurObjet.Size = new System.Drawing.Size(63, 20);
            this.lblValeurObjet.TabIndex = 25;
            this.lblValeurObjet.Text = "Valeur :";
            // 
            // lblConsommableObjet
            // 
            this.lblConsommableObjet.AutoSize = true;
            this.lblConsommableObjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsommableObjet.Location = new System.Drawing.Point(12, 123);
            this.lblConsommableObjet.Name = "lblConsommableObjet";
            this.lblConsommableObjet.Size = new System.Drawing.Size(119, 20);
            this.lblConsommableObjet.TabIndex = 23;
            this.lblConsommableObjet.Text = "Consommable :";
            // 
            // lblTypeObjet
            // 
            this.lblTypeObjet.AutoSize = true;
            this.lblTypeObjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeObjet.Location = new System.Drawing.Point(12, 66);
            this.lblTypeObjet.Name = "lblTypeObjet";
            this.lblTypeObjet.Size = new System.Drawing.Size(51, 20);
            this.lblTypeObjet.TabIndex = 22;
            this.lblTypeObjet.Text = "Type :";
            // 
            // lblNomObjet
            // 
            this.lblNomObjet.AutoSize = true;
            this.lblNomObjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomObjet.Location = new System.Drawing.Point(12, 9);
            this.lblNomObjet.Name = "lblNomObjet";
            this.lblNomObjet.Size = new System.Drawing.Size(50, 20);
            this.lblNomObjet.TabIndex = 20;
            this.lblNomObjet.Text = "Nom :";
            // 
            // FormObjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 387);
            this.Controls.Add(this.lblEffetsObjet);
            this.Controls.Add(this.lblPoidsObjet);
            this.Controls.Add(this.lblValeurObjet);
            this.Controls.Add(this.lblConsommableObjet);
            this.Controls.Add(this.lblTypeObjet);
            this.Controls.Add(this.lblNomObjet);
            this.Name = "FormObjets";
            this.Text = "FormObjets";
            this.Load += new System.EventHandler(this.FormObjets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEffetsObjet;
        private System.Windows.Forms.Label lblPoidsObjet;
        private System.Windows.Forms.Label lblValeurObjet;
        private System.Windows.Forms.Label lblConsommableObjet;
        private System.Windows.Forms.Label lblTypeObjet;
        private System.Windows.Forms.Label lblNomObjet;
    }
}