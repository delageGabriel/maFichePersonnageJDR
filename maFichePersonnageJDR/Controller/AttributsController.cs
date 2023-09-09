using maFichePersonnageJDR.Formulaires;
using maFichePersonnageJDR.Model;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Controller
{
    class AttributsController
    {
        public static void GetAttributs(TabControl controlParent, TabPage page)
        {
            Console.WriteLine("########### Méthode GetAttributs — ###########");

            FormulaireAttributs formulaireAttributs = new FormulaireAttributs();
            AttributsModel attributsModel = new AttributsModel();

            try
            {
                List<AttributsModel> attributsList = attributsModel.GetListAttributs();

                if (attributsList != null)
                {
                    // Coordonnées qui gèrent la localisation
                    int x = 10;
                    int y = 20;
                    int indexOfTabPage = controlParent.TabPages.IndexOfKey(page.Name);

                    // NOM
                    Label lblNom = new Label();
                    lblNom.Name = "lblNom" + page.Text;
                    lblNom.Location = new Point(x + 25, y);
                    lblNom.Text = "Nom";
                    lblNom.Font = new Font(lblNom.Font, FontStyle.Underline);

                    controlParent.TabPages[indexOfTabPage].Controls.Add(lblNom);

                    y += 30;

                    // On ajoute tous les attributs dans la groupBox
                    foreach(AttributsModel attributs in attributsList)
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Location = new Point(1, y - 5);
                        checkBox.Name = ("chck" + attributs.NomAttribut).Trim();

                        LinkLabel linkLabel = new LinkLabel();
                        linkLabel.Text = attributs.NomAttribut;
                        linkLabel.Name = ("lnkLbl" + attributs.NomAttribut).Trim();
                        linkLabel.Location = new Point(x + 25, y);
                        linkLabel.AutoSize = true;
                        // linkLabel.LinkClicked += fo.linkLabelAptitude_LinkClicked;

                        controlParent.TabPages[indexOfTabPage].Controls.Add(linkLabel);
                        controlParent.TabPages[indexOfTabPage].Controls.Add(checkBox);

                        y += 25;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
