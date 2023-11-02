using maFichePersonnageJDR.Classe;
using maFichePersonnageJDR.Controller;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireMagieEtAptitudes : Form
    {
        private int idPersonnage;

        private Dictionary<Control, Rectangle> dictionaryControlOriginalSize = new Dictionary<Control, Rectangle>();
        private Dictionary<Label, Tuple<Rectangle, float>> dictionaryLabelOriginalSize = new Dictionary<Label, Tuple<Rectangle, float>>();
        public int IdPersonnage { get => idPersonnage; set => idPersonnage = value; }
        public FormulaireMagieEtAptitudes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Remplit chaque TabPages du TabControl Armes avec les armes correspondantes.
        /// </summary>
        public void GetMagies()
        {
            Console.WriteLine("########### Classe : FormulaireMagieEtAptitudes; Méthode : GetMagies; ###########");

            try
            {
                foreach (TabPage page in tbCntlMagie.TabPages)
                {
                    Controller.MagieController.GetMagiesByType(page.Text, tbCntlMagie, page);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine("########### FIN Méthode GetMagies ###########");
        }

        /// <summary>
        /// Remplit chaque TabPages du TabControl Armes avec les armes correspondantes.
        /// </summary>
        public void GetAptitudes()
        {
            Console.WriteLine("########### Classe : FormulaireMagieEtAptitudes; Méthode : GetAptitudes; ###########");

            try
            {
                foreach (TabPage page in tbCntlAptitudes.TabPages)
                {
                    Controller.AptitudesController.GetAptitudesByType(page.Text, tbCntlAptitudes, page);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            Console.WriteLine("########### FIN Méthode GetMagies ###########");
        }

        /// <summary>
        /// Donne un aperçu de la magie cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void linkLabelMagie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuMagieEtAptitudes formulaireApercuMagieEtAptitudes = new FormulaireApercuMagieEtAptitudes();

            LinkLabel linkLabel = sender as LinkLabel;
            TabPage tabPage = linkLabel.Parent as TabPage;

            MagieController.GetApercuMagie(formulaireApercuMagieEtAptitudes, linkLabel.Text);
            formulaireApercuMagieEtAptitudes.Show();
        }

        /// <summary>
        /// Donne un aperçu de l'aptitude cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void linkLabelAptitude_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuMagieEtAptitudes formulaireApercuMagieEtAptitudes = new FormulaireApercuMagieEtAptitudes();

            LinkLabel linkLabel = sender as LinkLabel;
            TabPage tabPage = linkLabel.Parent as TabPage;

            AptitudesController.GetAptitudeByName(formulaireApercuMagieEtAptitudes, linkLabel.Text, tabPage.Text);
            formulaireApercuMagieEtAptitudes.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormulaireMagieEtAptitudes_Load(object sender, EventArgs e)
        {
            GetMagies();
            GetAptitudes();
            CreateCheckBoxMagie();
            CreateCheckBoxAptitudes();

            dictionaryControlOriginalSize.Add(this, new Rectangle(this.Location, this.Size));

            /// Chaque control en dehors des panel et TabControl
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    dictionaryLabelOriginalSize.Add(ctrl as Label, new Tuple<Rectangle, float>(new Rectangle(ctrl.Location, ctrl.Size), (ctrl as Label).Font.Size));
                }
                else
                {
                    dictionaryControlOriginalSize.Add(ctrl, new Rectangle(ctrl.Location, ctrl.Size));
                }
            }

            /// TabControl Aptitudes
            foreach (TabPage tabPage in tbCntlAptitudes.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is Label)
                    {
                        dictionaryLabelOriginalSize.Add(control as Label, new Tuple<Rectangle, float>(new Rectangle(control.Location, control.Size),
                            (control as Label).Font.Size));
                    }
                    else
                    {
                        dictionaryControlOriginalSize.Add(control, new Rectangle(control.Location, control.Size));
                    }
                }
            }

            /// TabControl Magies
            foreach (TabPage tabPage in tbCntlMagie.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is Label)
                    {
                        dictionaryLabelOriginalSize.Add(control as Label, new Tuple<Rectangle, float>(new Rectangle(control.Location, control.Size),
                            (control as Label).Font.Size));
                    }
                    else
                    {
                        dictionaryControlOriginalSize.Add(control, new Rectangle(control.Location, control.Size));
                    }
                }
            }
        }

        /// <summary>
        /// Créer les checkbox magie
        /// </summary>
        public void CreateCheckBoxMagie()
        {
            // On parcourt toute la liste des armes
            foreach (TabPage page in tbCntlMagie.TabPages)
            {
                int y = 35;

                // A chaque linklabel on ajoute une checkbox
                foreach (object controls in page.Controls)
                {
                    if (controls is LinkLabel)
                    {
                        LinkLabel linkLabel = controls as LinkLabel;

                        CheckBox checkBox = new CheckBox();
                        checkBox.Location = new Point(5, y);
                        checkBox.Name = ("chck" + linkLabel.Name.Substring(6));
                        checkBox.Click += checkBoxMagie_Click;

                        page.Controls.Add(checkBox);
                        y += 25;
                    }
                }
            }
        }

        /// <summary>
        /// Créer les checkbox aptitudes
        /// </summary>
        public void CreateCheckBoxAptitudes()
        {
            // On parcourt toute la liste des armes
            foreach (TabPage page in tbCntlAptitudes.TabPages)
            {
                int y = 35;

                // A chaque linklabel on ajoute une checkbox
                foreach (object controls in page.Controls)
                {
                    if (controls is LinkLabel)
                    {
                        LinkLabel linkLabel = controls as LinkLabel;

                        CheckBox checkBox = new CheckBox();
                        checkBox.Location = new Point(5, y);
                        checkBox.Name = ("chck" + linkLabel.Name.Substring(6));
                        checkBox.Click += checkBoxAptitude_Click;

                        page.Controls.Add(checkBox);
                        y += 25;
                    }
                }
            }
        }

        /// <summary>
        /// Checkbox pour ajouter ou retirer une arme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void checkBoxMagie_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            string nomMagie = checkBox.Name.Substring(4);
            string magie = MagieController.GetIdMagieByName(nomMagie);

            if (checkBox.Checked)
            {
                // FR : Devrait ajouter le texte
                // EN : Should append text
                rtbMagies.AppendText(magie + Environment.NewLine);
                DisableOrCheckBox(tbCntlAptitudes, tbCntlMagie);
            }
            else
            {
                DisableOrCheckBox(tbCntlAptitudes, tbCntlMagie);
            }
        }

        /// <summary>
        /// Checkbox pour ajouter ou retirer une arme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void checkBoxAptitude_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            string nomAptitude = checkBox.Name.Substring(4);
            string aptitude = AptitudesController.GetIdAptitudeByName(nomAptitude);

            if (checkBox.Checked)
            {
                // FR : Devrait ajouter le texte
                // EN : Should append text
                rtbAptitudes.AppendText(aptitude + Environment.NewLine);
                DisableOrCheckBox(tbCntlAptitudes, tbCntlMagie);
            }
            else
            {
                DisableOrCheckBox(tbCntlAptitudes, tbCntlMagie);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public int MagiesEtAptitudesLimitations(int idPersonnage)
        {
            int nbMagieAptitude = 0;
            int niveauPersonnage = PersonnageController.GetNiveauPersonnage(idPersonnage);

            if (niveauPersonnage <= 3)
                nbMagieAptitude = 2;
            else if (niveauPersonnage > 2 && niveauPersonnage < 4)
                nbMagieAptitude = 3;
            else if (niveauPersonnage > 3 && niveauPersonnage < 5)
                nbMagieAptitude = 4;
            else if (niveauPersonnage > 4 && niveauPersonnage < 6)
                nbMagieAptitude = 6;
            else if (niveauPersonnage > 5 && niveauPersonnage < 7)
                nbMagieAptitude = 8;
            else if (niveauPersonnage > 6 && niveauPersonnage < 9)
                nbMagieAptitude = 9;
            else if (niveauPersonnage > 8 && niveauPersonnage < 10)
                nbMagieAptitude = 10;
            else if (niveauPersonnage > 9 && niveauPersonnage < 12)
                nbMagieAptitude = 12;
            else if (niveauPersonnage > 11 && niveauPersonnage < 14)
                nbMagieAptitude = 13;
            else if (niveauPersonnage > 13 && niveauPersonnage < 15)
                nbMagieAptitude = 14;
            else if (niveauPersonnage > 14 && niveauPersonnage < 17)
                nbMagieAptitude = 16;
            else if (niveauPersonnage > 16 && niveauPersonnage < 19)
                nbMagieAptitude = 17;
            else if (niveauPersonnage > 18 && niveauPersonnage < 20)
                nbMagieAptitude = 18;
            else if (niveauPersonnage > 19)
                nbMagieAptitude = 20;

            return nbMagieAptitude;
        }

        public void DisableOrCheckBox(TabControl tbControlAptitudes, TabControl tbControlMagies)
        {
            int nbCheckBoxChecked = 0;
            int nbAttributParNiveau = MagiesEtAptitudesLimitations(IdPersonnage);

            /// Parcours des aptitudes
            foreach (TabPage page in tbControlAptitudes.TabPages)
            {
                foreach (object controls in page.Controls)
                {
                    if (controls is CheckBox)
                    {
                        CheckBox checkBox = controls as CheckBox;
                        nbCheckBoxChecked += checkBox.Checked ? 1 : 0;
                    }
                }
            }

            /// Parcours des magies
            foreach (TabPage page in tbControlMagies.TabPages)
            {
                foreach (object controls in page.Controls)
                {
                    if (controls is CheckBox)
                    {
                        CheckBox checkBox = controls as CheckBox;
                        nbCheckBoxChecked += checkBox.Checked ? 1 : 0;
                    }
                }
            }

            if (nbCheckBoxChecked == nbAttributParNiveau)
            {
                /// Parcours des aptitudes
                foreach (TabPage page in tbControlAptitudes.TabPages)
                {
                    foreach (object controls in page.Controls)
                    {
                        if (controls is CheckBox)
                        {
                            CheckBox checkBox = controls as CheckBox;
                            checkBox.Enabled = checkBox.Checked ? true : false;
                        }
                    }
                }

                /// Parcours des magies
                foreach (TabPage page in tbControlMagies.TabPages)
                {
                    foreach (object controls in page.Controls)
                    {
                        if (controls is CheckBox)
                        {
                            CheckBox checkBox = controls as CheckBox;
                            checkBox.Enabled = checkBox.Checked ? true : false;
                        }
                    }
                }
            }
            else
            {
                /// Parcours des aptitudes
                foreach (TabPage page in tbControlAptitudes.TabPages)
                {
                    foreach (object controls in page.Controls)
                    {
                        if (controls is CheckBox)
                        {
                            CheckBox checkBox = controls as CheckBox;
                            checkBox.Enabled = true;
                        }
                    }
                }

                /// Parcours des magies
                foreach (TabPage page in tbControlMagies.TabPages)
                {
                    foreach (object controls in page.Controls)
                    {
                        if (controls is CheckBox)
                        {
                            CheckBox checkBox = controls as CheckBox;
                            checkBox.Enabled = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Permet de savoir combien d'aptitude et/ou de magie
        /// le personnage peut encore répartir
        /// </summary>
        /// <param name="niveauPersonnage"></param>
        /// <returns></returns>
        private int MagieAptitudesLimitationByLevel(int niveauPersonnage)
        {
            int nbMagieAptitude = 0;

            if (niveauPersonnage < 3)
                nbMagieAptitude = 2;
            else if (niveauPersonnage > 3 && niveauPersonnage < 4)
                nbMagieAptitude = 3;
            else if (niveauPersonnage > 4 && niveauPersonnage < 5)
                nbMagieAptitude = 4;
            else if (niveauPersonnage > 4 && niveauPersonnage < 6)
                nbMagieAptitude = 6;
            else if (niveauPersonnage > 5 && niveauPersonnage < 7)
                nbMagieAptitude = 8;
            else if (niveauPersonnage > 6 && niveauPersonnage < 9)
                nbMagieAptitude = 9;
            else if (niveauPersonnage > 8 && niveauPersonnage < 10)
                nbMagieAptitude = 10;
            else if (niveauPersonnage > 9 && niveauPersonnage < 12)
                nbMagieAptitude = 12;
            else if (niveauPersonnage > 11 && niveauPersonnage < 14)
                nbMagieAptitude = 13;
            else if (niveauPersonnage > 13 && niveauPersonnage < 15)
                nbMagieAptitude = 14;
            else if (niveauPersonnage > 14 && niveauPersonnage < 17)
                nbMagieAptitude = 16;
            else if (niveauPersonnage > 16 && niveauPersonnage < 19)
                nbMagieAptitude = 17;
            else if (niveauPersonnage > 18 && niveauPersonnage < 20)
                nbMagieAptitude = 18;
            else
                nbMagieAptitude = 20;

            return nbMagieAptitude;
        }

        private void btnFinaliserFiche_Click(object sender, EventArgs e)
        {
            Classe.ClassePdf classePdf = new Classe.ClassePdf();
            int nbCheckBoxCochee = 0;

            foreach (TabPage pageMagie in tbCntlMagie.TabPages)
            {
                foreach (Control controls in pageMagie.Controls)
                {
                    if (controls is CheckBox && (controls as CheckBox).Checked)
                        nbCheckBoxCochee += 1;
                }
            }

            foreach (TabPage pageAptitude in tbCntlAptitudes.TabPages)
            {
                foreach (Control control in pageAptitude.Controls)
                {
                    if (control is CheckBox && (control as CheckBox).Checked)
                        nbCheckBoxCochee += 1;
                }
            }

            if (nbCheckBoxCochee < MagieAptitudesLimitationByLevel(PersonnageController.GetNiveauPersonnage(IdPersonnage)))
            {
                MessageBox.Show(string.Format("Il vous reste {0} à attribuer au personnage !", MagieAptitudesLimitationByLevel(PersonnageController.GetNiveauPersonnage(IdPersonnage) - nbCheckBoxCochee)));
                return;
            }

            // MAGIE
            foreach (string line in rtbMagies.Lines)
            {
                if (!String.IsNullOrEmpty(line))
                {
                    string[] substring = line.Split(';');
                    MagieController.AddNewMagieToPersonnage(Convert.ToInt32(substring[0]),
                    IdPersonnage);
                }
            }

            // APTITUDES
            foreach (string line in rtbAptitudes.Lines)
            {
                if (!String.IsNullOrEmpty(line))
                {
                    string[] substring = line.Split(';');
                    AptitudesController.AddNewAptitudeToPersonnage(Convert.ToInt32(substring[0]),
                    IdPersonnage);
                }
            }

            classePdf.IdPersonnage = IdPersonnage;
            classePdf.CreatePersonnagePdf(pbComplétionExportationFiche);
            this.Close();
        }

        private void FormulaireMagieEtAptitudes_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Width / dictionaryControlOriginalSize[this].Width;
            float yRatio = (float)this.Height / dictionaryControlOriginalSize[this].Height;

            foreach (KeyValuePair<Label, Tuple<Rectangle, float>> entry in dictionaryLabelOriginalSize)
            {
                Utils.AdjustLabelSizeAndPosition(entry.Key, entry.Value.Item1, entry.Value.Item2, xRatio, yRatio);
            }
            foreach (KeyValuePair<Control, Rectangle> entry in dictionaryControlOriginalSize)
            {
                Utils.AdjustControlSizeAndPosition(entry.Key, entry.Value, xRatio, yRatio);
            }

            this.Refresh();
        }
    }
}
