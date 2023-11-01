using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maFichePersonnageJDR.Formulaires;
using System.IO;
using maFichePersonnageJDR.Classe;
using maFichePersonnageJDR.Controller;
using System.Windows;
using maFichePersonnageJDR.View.Formulaires;

namespace maFichePersonnageJDR
{
    public partial class FrmPrincipal : Form
    {
        private Size originalFormSize;
        private Size originalButtonSize;

        public string cheminTemplate = Path.GetFullPath(@"Templates\template_fiche_personnage.docx");
        public string cheminPdf = Path.GetFullPath(@"Templates\template_fiche.pdf");
        public string cheminDocx = Path.GetFullPath(@"Templates\template_fiche.docx");
        public ClasseImage imgAvatar = new ClasseImage();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Mémorisez la taille originale du formulaire et du bouton au chargement
            originalFormSize = this.Size;
            originalButtonSize = btnCreerPersonnage.Size;
        }

        private void btnInfosGenerales_Click(object sender, EventArgs e)
        {
            FormulaireInfosGenerales frmIG = new FormulaireInfosGenerales();
            frmIG.Show();
        }


        private void btnCreerPersonnage_Click(object sender, EventArgs e)
        {
            //int testCentaine = (2078 / 100) % 100;
            //int testdizaine = (2078 / 10) % 10;
            //int testUnite = 2078 % 10;
            FormulaireInfosGenerales formulaireMenu = new FormulaireInfosGenerales();
            formulaireMenu.Show();
        }

        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;

            // Ajustez la taille du bouton en fonction du rapport de redimensionnement du formulaire
            btnCreerPersonnage.Size = new Size((int)(originalButtonSize.Width * xRatio), (int)(originalButtonSize.Height * yRatio));

            // Si vous voulez garder le bouton centré après le redimensionnement :
            btnCreerPersonnage.Left = (this.ClientSize.Width - btnCreerPersonnage.Width) / 2;
        }
    }
}