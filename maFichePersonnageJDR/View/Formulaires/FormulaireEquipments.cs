using maFichePersonnageJDR.Controller;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireEquipments : Form
    {
        public FormulaireEquipments()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Remplit chaque TabPages du TabControl Armes avec les armes correspondantes.
        /// </summary>
        public void GetArmes()
        {
            Console.WriteLine("########### Classe : FormulaireEquipments; Méthode : GetArmes; ###########");

            try
            {
                foreach (TabPage page in tbCntlArmes.TabPages)
                {
                    Controller.EquipmentController.GetArmesByType(page.Text.Trim('s'), tbCntlArmes, page);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine("########### FIN Méthode GetArmes ###########");
        }

        /// <summary>
        /// Remplit chaque TabPages du TabControl Armures avec les armures correspondantes.
        /// </summary>
        public void GetArmures()
        {
            Console.WriteLine("########### Classe : FormulaireEquipments; Méthode : GetArmures; ###########");

            try
            {
                foreach (TabPage page in tbCntlArmures.TabPages)
                {
                    Controller.EquipmentController.GetArmuresByType(page.Text.Trim('s'), tbCntlArmures, page);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine("########### FIN Méthode GetArmures ###########");
        }

        /// <summary>
        /// Remplit chaque TabPages du TabControl Objets avec les objets correspondantes.
        /// </summary>
        public void GetObjets()
        {
            Console.WriteLine("########### Classe : FormulaireEquipments; Méthode : GetObjets; ###########");

            try
            {
                foreach (TabPage page in tbCntlObjets.TabPages)
                {
                    Controller.EquipmentController.GetObjetsByType(page.Text, tbCntlObjets, page);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine("########### FIN Méthode GetArmures ###########");
        }

        private void FormulaireEquipments_Load(object sender, EventArgs e)
        {
            GetArmes();
            GetArmures();
            GetObjets();
        }

        public void linkLabelArme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuEquipement formulaireApercuEquipement = new FormulaireApercuEquipement();

            LinkLabel linkLabel = sender as LinkLabel;

            EquipmentController.GetApercuArmes(formulaireApercuEquipement, linkLabel.Text);
            formulaireApercuEquipement.Show();
        }

        public void linkLabelArmure_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuEquipement formulaireApercuEquipement = new FormulaireApercuEquipement();
            LinkLabel linkLabel = sender as LinkLabel;

            EquipmentController.GetApercuArmure(formulaireApercuEquipement, linkLabel.Text);
            formulaireApercuEquipement.Show();
        }

        public void linkLabelObjet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuEquipement formulaireApercuEquipement = new FormulaireApercuEquipement();
            LinkLabel linkLabel = sender as LinkLabel;

            EquipmentController.GetApercuObjet(formulaireApercuEquipement, linkLabel.Text);
            formulaireApercuEquipement.Show();
        }
    }
}
