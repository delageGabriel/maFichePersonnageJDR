using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using maFichePersonnageJDR.Model;
using maFichePersonnageJDR.Formulaires;
using System.Drawing;

namespace maFichePersonnageJDR.Controller
{
    class EquipmentController
    {
        public static void GetArmesByType(string typeArme, TabControl controlParent, TabPage tabPage)
        {
            Console.WriteLine(string.Format("Méthode GetArmes — Type d'arme : {0}", typeArme));
            FormulaireEquipments formulaireEquipments = new FormulaireEquipments();
            ArmesModel armesModel = new ArmesModel();

            try
            {
                List<ArmesModel> armesModels = armesModel.GetListArmesByTypes(typeArme);

                if( armesModel != null)
                {
                    /// Les coordonnées qui gèrent tout les localisation
                    /// Et l'index de la tabpage
                    int y = 10;
                    int x = 20;
                    int indexOfTabPage = controlParent.TabPages.IndexOfKey(tabPage.Name);

                    // Label nom
                    Label lblNom = new Label();
                    lblNom.Name = "lblNom" + tabPage.Text;
                    lblNom.Location = new Point(x, y);
                    lblNom.Text = "Nom";
                    lblNom.Font = new Font(lblNom.Font, FontStyle.Underline);

                    // Label Poids
                    Label lblPoids = new Label();
                    lblPoids.Name = "lblPoids" + tabPage.Text;
                    lblPoids.Location = new Point(x + lblNom.Width, y);
                    lblPoids.Text = "Poids (kg)";
                    lblPoids.Font = new Font(lblNom.Font, FontStyle.Underline);

                    // Label Quantité
                    Label lblQte = new Label();
                    lblQte.Name = "lblQte" + tabPage.Text;
                    lblQte.Location = new Point(x + (lblNom.Width + lblQte.Width + 10), y);
                    lblQte.Text = "Quantité";
                    lblQte.Font = new Font(lblNom.Font, FontStyle.Underline);

                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblNom);
                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblPoids);
                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblQte);

                    y += 30;

                    /// Pour chaque type d'arme on les ajoute dans les tabpages
                    foreach (ArmesModel armes in armesModels)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Location = new Point(1, y - 5);
                        checkBox.Name = ("chck" + armes.NomArme).Trim();

                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = armes.NomArme;
                        linkLabel.Name = ("lnkLbl" + armes.NomArme).Trim();
                        linkLabel.Location = new Point(x, y);
                        linkLabel.AutoSize = true;
                        linkLabel.LinkClicked += formulaireEquipments.linkLabelArme_LinkClicked;

                        Label label = new Label();
                        label.Name = "lblPds" + armes.PoidsArmes.ToString();
                        label.Location = new Point(x + (linkLabel.Width + 10), y);
                        label.Text = armes.PoidsArmes.ToString();

                        NumericUpDown numericUpDown = new NumericUpDown();
                        numericUpDown.Location = new Point(x + (linkLabel.Width + label.Width + 10), y - 3);
                        numericUpDown.Maximum = 99;
                        numericUpDown.Minimum = 0;
                        numericUpDown.Width = 40;                        

                        controlParent.TabPages[indexOfTabPage].Controls.Add(linkLabel);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(checkBox);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(label);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(numericUpDown);

                        y += 25;
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
