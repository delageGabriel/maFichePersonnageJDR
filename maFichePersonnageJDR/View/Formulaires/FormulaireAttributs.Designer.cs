
namespace maFichePersonnageJDR.View.Formulaires
{
    partial class FormulaireAttributs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaireAttributs));
            this.tbControlAttributs = new System.Windows.Forms.TabControl();
            this.tbPgeAttributs = new System.Windows.Forms.TabPage();
            this.rtbAttributs = new System.Windows.Forms.RichTextBox();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.lblNbAttributs = new System.Windows.Forms.Label();
            this.tbControlAttributs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlAttributs
            // 
            this.tbControlAttributs.Controls.Add(this.tbPgeAttributs);
            this.tbControlAttributs.Location = new System.Drawing.Point(12, 23);
            this.tbControlAttributs.Name = "tbControlAttributs";
            this.tbControlAttributs.SelectedIndex = 0;
            this.tbControlAttributs.Size = new System.Drawing.Size(314, 226);
            this.tbControlAttributs.TabIndex = 2;
            // 
            // tbPgeAttributs
            // 
            this.tbPgeAttributs.AutoScroll = true;
            this.tbPgeAttributs.Location = new System.Drawing.Point(4, 22);
            this.tbPgeAttributs.Name = "tbPgeAttributs";
            this.tbPgeAttributs.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgeAttributs.Size = new System.Drawing.Size(306, 200);
            this.tbPgeAttributs.TabIndex = 0;
            this.tbPgeAttributs.Text = "Attributs";
            this.tbPgeAttributs.UseVisualStyleBackColor = true;
            // 
            // rtbAttributs
            // 
            this.rtbAttributs.Enabled = false;
            this.rtbAttributs.Location = new System.Drawing.Point(12, 255);
            this.rtbAttributs.Name = "rtbAttributs";
            this.rtbAttributs.Size = new System.Drawing.Size(310, 91);
            this.rtbAttributs.TabIndex = 3;
            this.rtbAttributs.Text = "";
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(109, 369);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(112, 33);
            this.btnSauvegarder.TabIndex = 4;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // lblNbAttributs
            // 
            this.lblNbAttributs.AutoSize = true;
            this.lblNbAttributs.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbAttributs.Location = new System.Drawing.Point(74, 10);
            this.lblNbAttributs.Name = "lblNbAttributs";
            this.lblNbAttributs.Size = new System.Drawing.Size(224, 21);
            this.lblNbAttributs.TabIndex = 5;
            this.lblNbAttributs.Text = "Vous pouvez choisir 2 attributs";
            // 
            // FormulaireAttributs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 413);
            this.Controls.Add(this.lblNbAttributs);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.rtbAttributs);
            this.Controls.Add(this.tbControlAttributs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormulaireAttributs";
            this.Text = "Attributs";
            this.Load += new System.EventHandler(this.FormulaireAttributs_Load);
            this.Resize += new System.EventHandler(this.FormulaireAttributs_Resize);
            this.tbControlAttributs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tbControlAttributs;
        private System.Windows.Forms.TabPage tbPgeAttributs;
        private System.Windows.Forms.RichTextBox rtbAttributs;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Label lblNbAttributs;
    }
}