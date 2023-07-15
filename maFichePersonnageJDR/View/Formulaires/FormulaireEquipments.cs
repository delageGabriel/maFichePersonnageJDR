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

        /// <summary>
        /// Remplit chaque TabPages du TabControl Armes avec les armes correspondantes.
        /// </summary>
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
