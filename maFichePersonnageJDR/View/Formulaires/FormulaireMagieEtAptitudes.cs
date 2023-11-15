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
        private Dictionary<Control, Rectangle> dictionaryControlOriginalSize = new Dictionary<Control, Rectangle>();
        private Dictionary<Label, Tuple<Rectangle, float>> dictionaryLabelOriginalSize = new Dictionary<Label, Tuple<Rectangle, float>>();
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

            if (GlobaleVariables.IsEdit)
            {
                EditPersonnageMagieAptitudes();
            }

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

            if (checkBox.Checked)
            {
                rtbMagies.Text += rtbMagies.Lines.Length > 0 ? Environment.NewLine + nomMagie : nomMagie;
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

            if (checkBox.Checked)
            {
                // FR : Devrait ajouter le texte
                // EN : Should append text
                rtbAptitudes.Text += rtbAptitudes.Lines.Length > 0 ? Environment.NewLine + nomAptitude : nomAptitude;
                DisableOrCheckBox(tbCntlAptitudes, tbCntlMagie);
            }
            else
            {
                DisableOrCheckBox(tbCntlAptitudes, tbCntlMagie);
            }
        }

        public void DisableOrCheckBox(TabControl tbControlAptitudes, TabControl tbControlMagies)
        {
            int nbCheckBoxChecked = 0;
            int nbAttributParNiveau = MagieAptitudesLimitationByLevel(GlobaleVariables.IdPersonnage);

            /// Parcours des aptitudes
            foreach (TabPage page in tbControlAptitudes.TabPages)
            {
                foreach (CheckBox checkBox in page.Controls.OfType<CheckBox>())
                {
                    nbCheckBoxChecked += checkBox.Checked ? 1 : 0;
                }
            }

            /// Parcours des magies
            foreach (TabPage page in tbControlMagies.TabPages)
            {
                foreach (CheckBox checkBox in page.Controls.OfType<CheckBox>())
                {
                    nbCheckBoxChecked += checkBox.Checked ? 1 : 0;
                }
            }

            if (nbCheckBoxChecked == nbAttributParNiveau)
            {
                /// Parcours des aptitudes
                foreach (TabPage page in tbControlAptitudes.TabPages)
                {
                    foreach (CheckBox checkBox in page.Controls.OfType<CheckBox>())
                    {
                        checkBox.Enabled = checkBox.Checked ? true : false;
                    }
                }

                /// Parcours des magies
                foreach (TabPage page in tbControlMagies.TabPages)
                {
                    foreach (CheckBox checkBox in page.Controls.OfType<CheckBox>())
                    {
                        checkBox.Enabled = checkBox.Checked ? true : false;
                    }
                }
            }
            else
            {
                /// Parcours des aptitudes
                foreach (TabPage page in tbControlAptitudes.TabPages)
                {
                    foreach (CheckBox checkBox in page.Controls.OfType<CheckBox>())
                    {
                        checkBox.Enabled = true;
                    }
                }

                /// Parcours des magies
                foreach (TabPage page in tbControlMagies.TabPages)
                {
                    foreach (CheckBox checkBox in page.Controls.OfType<CheckBox>())
                    {
                        checkBox.Enabled = true;
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
            if (niveauPersonnage <= 2)
            {
                return 2;
            }
            else if (niveauPersonnage <= 4)
            {
                return 3;
            }
            else if (niveauPersonnage == 5)
            {
                return 4;
            }
            else if (niveauPersonnage == 6)
            {
                return 6;
            }
            else if (niveauPersonnage <= 8)
            {
                return 8;
            }
            else if (niveauPersonnage <= 10)
            {
                return 9;
            }
            else if (niveauPersonnage <= 12)
            {
                return 10;
            }
            else if (niveauPersonnage == 13)
            {
                return 12;
            }
            else if (niveauPersonnage == 14)
            {
                return 13;
            }
            else if (niveauPersonnage <= 16)
            {
                return 14;
            }
            else if (niveauPersonnage <= 18)
            {
                return 16;
            }
            else if (niveauPersonnage == 19)
            {
                return 18;
            }
            else
            {
                return 20;
            }
        }

        private void btnFinaliserFiche_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();

            //ClassePdf classePdf = new ClassePdf();
            ClasseHtml classeHtml = new ClasseHtml();

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

            if (nbCheckBoxCochee < MagieAptitudesLimitationByLevel(PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage)))
            {
                MessageBox.Show(string.Format("Il vous reste {0} à attribuer au personnage !", MagieAptitudesLimitationByLevel(PersonnageController.GetNiveauPersonnage(GlobaleVariables.IdPersonnage) - nbCheckBoxCochee)));
                return;
            }

            // MAGIE
            foreach (string line in rtbMagies.Lines)
            {
                if (!String.IsNullOrEmpty(line))
                {
                    MagieController.AddNewMagieToPersonnage(MagieController.GetIdMagieByName(line),
                    GlobaleVariables.IdPersonnage);
                }
            }

            // APTITUDES
            foreach (string line in rtbAptitudes.Lines)
            {
                if (!String.IsNullOrEmpty(line))
                {
                    string[] substring = line.Split(';');
                    AptitudesController.AddNewAptitudeToPersonnage(AptitudesController.GetIdAptitudeByName(Utils.DeleteCharacterFromString(line, "\n", " ")),
                    GlobaleVariables.IdPersonnage);
                }
            }

            // Format PDF
            //classePdf.GlobaleVariables.idPersonnage = GlobaleVariables.idPersonnage;
            //classePdf.CreatePersonnagePdf(pbComplétionExportationFiche);

            // Format HTML pour forge
            classeHtml.CreatePersonnageHtml();
            frmPrincipal.Refresh();
            frmPrincipal.Show();
            GlobaleVariables.IdPersonnage = 0;
            GlobaleVariables.IsClosedProgrammatically = true;
            this.Close();
            DatabaseConnection.Instance.CloseConnection();
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

        private void EditPersonnageMagieAptitudes()
        {
            string[] magiesPersonnage = MagieController.GetListNomMagie(GlobaleVariables.IdPersonnage).ToArray();
            string[] aptitudesPersonnage = AptitudesController.GetListNomAptitude(GlobaleVariables.IdPersonnage).ToArray();

            if (magiesPersonnage.Length > 0)
            {
                for (int i = 0; i < magiesPersonnage.Length; i++)
                {
                    string nomCheckbox = "chck" + magiesPersonnage[i];

                    foreach (TabPage page in tbCntlMagie.TabPages)
                    {
                        foreach (CheckBox checkBox in page.Controls.OfType<CheckBox>())
                        {
                            if (checkBox.Name == nomCheckbox)
                            {
                                checkBox.Checked = true;
                                checkBox.Enabled = false;
                            }
                        }
                    }

                    rtbMagies.Text += magiesPersonnage[i] + "\n";
                }
            }

            if (aptitudesPersonnage.Length > 0)
            {
                for (int i = 0; i < magiesPersonnage.Length; i++)
                {
                    string nomCheckbox = "chck" + aptitudesPersonnage[i];

                    foreach (TabPage page in tbCntlAptitudes.TabPages)
                    {
                        foreach (CheckBox checkBox in page.Controls.OfType<CheckBox>())
                        {
                            if (checkBox.Name == nomCheckbox)
                            {
                                checkBox.Checked = true;
                                checkBox.Enabled = false;
                            }
                        }
                    }

                    rtbAptitudes.Text += aptitudesPersonnage[i] + "\n";
                }
            }

            DisableOrCheckBox(tbCntlAptitudes, tbCntlMagie);
        }

        private void FormulaireMagieEtAptitudes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!GlobaleVariables.IsClosedProgrammatically)
            {
                string msg = GlobaleVariables.IsEdit ? "Voulez-vous annuler l'édition du personnage ?" : "Voulez-vous annuler la création du personnage ?";
                DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Vérifier la réponse de l'utilisateur
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (GlobaleVariables.IsEdit)
                    {
                        FormEditMenu formEditMenu = new FormEditMenu();
                        formEditMenu.Show();
                    }
                    else
                    {
                        FrmPrincipal frmPrincipal = new FrmPrincipal();
                        frmPrincipal.Show();
                    }
                }
            }
            else
            {
                GlobaleVariables.IsClosedProgrammatically = false;
            }
        }
    }
}
