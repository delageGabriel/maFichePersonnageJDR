
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
            this.tbControlAttributs = new System.Windows.Forms.TabControl();
            this.tbPgeAttributs = new System.Windows.Forms.TabPage();
            this.rtbAttributs = new System.Windows.Forms.RichTextBox();
            this.tbControlAttributs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlAttributs
            // 
            this.tbControlAttributs.Controls.Add(this.tbPgeAttributs);
            this.tbControlAttributs.Location = new System.Drawing.Point(12, 12);
            this.tbControlAttributs.Name = "tbControlAttributs";
            this.tbControlAttributs.SelectedIndex = 0;
            this.tbControlAttributs.Size = new System.Drawing.Size(180, 426);
            this.tbControlAttributs.TabIndex = 2;
            // 
            // tbPgeAttributs
            // 
            this.tbPgeAttributs.AutoScroll = true;
            this.tbPgeAttributs.Location = new System.Drawing.Point(4, 22);
            this.tbPgeAttributs.Name = "tbPgeAttributs";
            this.tbPgeAttributs.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgeAttributs.Size = new System.Drawing.Size(172, 400);
            this.tbPgeAttributs.TabIndex = 0;
            this.tbPgeAttributs.Text = "Attributs";
            this.tbPgeAttributs.UseVisualStyleBackColor = true;
            // 
            // rtbAttributs
            // 
            this.rtbAttributs.Location = new System.Drawing.Point(198, 34);
            this.rtbAttributs.Name = "rtbAttributs";
            this.rtbAttributs.Size = new System.Drawing.Size(333, 96);
            this.rtbAttributs.TabIndex = 3;
            this.rtbAttributs.Text = "";
            // 
            // FormulaireAttributs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.rtbAttributs);
            this.Controls.Add(this.tbControlAttributs);
            this.Name = "FormulaireAttributs";
            this.Text = "Attributs";
            this.Load += new System.EventHandler(this.FormulaireAttributs_Load);
            this.tbControlAttributs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbControlAttributs;
        private System.Windows.Forms.TabPage tbPgeAttributs;
        private System.Windows.Forms.RichTextBox rtbAttributs;
    }
}