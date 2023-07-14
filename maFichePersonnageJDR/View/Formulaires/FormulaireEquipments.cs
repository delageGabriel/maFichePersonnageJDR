using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using maFichePersonnageJDR.Controller;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireEquipments : Form
    {
        public FormulaireEquipments()
        {
            InitializeComponent();
        }

        public void GetArmes()
        {
            Console.WriteLine("Classe : FormulaireEquipments; Méthode : GetArmes;");

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

            Console.WriteLine("FIN Méthode GetArmes");
        }

        private void FormulaireEquipments_Load(object sender, EventArgs e)
        {
            /// On commence par créer nos objets qui vont communiquer avec la base de données                   
            // Connexion
            GetArmes();
        }

        public void linkLabelArme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = sender as LinkLabel;
            TabPage tabPage = linkLabel.Parent as TabPage;

            Process.Start(Path.GetFullPath(string.Format(@"Fiches\Armes\{0}\{1}.docx", tabPage.Text, linkLabel.Text)));
        }
    }
}
