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
            cbbEditPersonnage.Items.AddRange(PersonnageController.GetListPersonnage());
            cbbDeletePersonnage.Items.AddRange(PersonnageController.GetListPersonnage());
            // Mémorisez la taille originale du formulaire et du bouton au chargement
            originalFormSize = this.Size;
            originalButtonSize = btnCreerPersonnage.Size;
        }

        private void btnCreerPersonnage_Click(object sender, EventArgs e)
        {
            FormulaireInfosGenerales formulaireMenu = new FormulaireInfosGenerales();
            formulaireMenu.Show();
            this.Hide();
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

        /// <summary>
        /// Méthode qui permet d'éditer les informations d'un personnage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbEditPersonnage_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormEditMenu formEditMenu = new FormEditMenu();

            // On passe en mode Edit et on récupère l'id du personnage à éditer
            GlobaleVariables.isEdit = true;
            string[] substring = cbbEditPersonnage.SelectedItem.ToString().Split(' ');
            GlobaleVariables.idPersonnage = PersonnageController.GetIdPersonnageByNameAndSurname(substring[1], substring[0]);

            // On passe sur le form edit menu en cachant le form principal
            this.Hide();
            formEditMenu.Show();
        }

        private void cbbDeletePersonnage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDeletePersonnage.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce Personnage ?\n Toutes les données qui lui sont liées seront supprimées " +
                    "également et vous ne pourrez plus éditer le personnage (vous aurez toujours sa fiche).", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Vérifier la réponse de l'utilisateur
                if (result == DialogResult.Yes)
                {
                    string[] substring = cbbDeletePersonnage.SelectedItem.ToString().Split(' ');
                    PersonnageController.DeleteRowPersonnageByPrenomAndNom(substring[0], substring[1]);

                    // Update ComboboxDelete & Edit
                    UpdateComboBoxes();
                }
            }
        }

        public void UpdateComboBoxes()
        {
            // Delete
            cbbDeletePersonnage.Refresh();
            cbbDeletePersonnage.Items.Clear();
            cbbDeletePersonnage.Items.AddRange(PersonnageController.GetListPersonnage());

            // Edit
            cbbEditPersonnage.Refresh();
            cbbEditPersonnage.Items.Clear();
            cbbEditPersonnage.Items.AddRange(PersonnageController.GetListPersonnage());
        }
    }
}