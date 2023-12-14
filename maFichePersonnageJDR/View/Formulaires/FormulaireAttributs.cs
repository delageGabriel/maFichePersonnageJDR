using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using maFichePersonnageJDR.Classe;
using maFichePersonnageJDR.Controller;

namespace maFichePersonnageJDR.View.Formulaires
{
    public partial class FormulaireAttributs : Form
    {
        private Dictionary<Control, Rectangle> dictionaryControlOriginalSize = new Dictionary<Control, Rectangle>();
        private Dictionary<int, Tuple<string, string, string, string>> dictionaryAttributes = new Dictionary<int, Tuple<string, string, string, string>>();
        private Dictionary<string, string> dictionaryOfSpecificationsAttributes = new Dictionary<string, string>();

        public FormulaireAttributs()
        {
            InitializeComponent();
        }

        private void FormulaireAttributs_Load(object sender, EventArgs e)
        {
            DisplayAttributes();
            dictionaryOfSpecificationsAttributes = AttributsController.GetAttributesWithSpecification();

            dictionaryControlOriginalSize.Add(this, new Rectangle(this.Location, this.Size));
            dictionaryControlOriginalSize.Add(tbControlAttributs, new Rectangle(tbControlAttributs.Location, tbControlAttributs.Size));
            dictionaryControlOriginalSize.Add(rtbAttributs, new Rectangle(rtbAttributs.Location, rtbAttributs.Size));
            dictionaryControlOriginalSize.Add(btnSauvegarder, new Rectangle(btnSauvegarder.Location, btnSauvegarder.Size));

            if (GlobaleVariables.IsEdit)
            {
                EditPersonnageAttributs();
            }
        }

        /// <summary>
        /// Remplit chaque TabPages du TabControl Armes avec les armes correspondantes.
        /// </summary>
        public void DisplayAttributes()
        {
            Console.WriteLine("########### Classe : FormulaireAttributs; Méthode : DisplayAttributes; ###########");
            dictionaryAttributes = AttributsController.GetAttributes();

            // Coordonnées contrôles
            int initialX = 10;
            int initialY = 10;
            int x = initialX;
            int y = initialY;

            int decalageY = 30;
            char lettreCheck = ' ';
            string tagTemp = string.Empty;

            // CAS TRI A-Z
            if (cbbTrier.SelectedIndex == 0)
            {
                var dictionaryTrie = dictionaryAttributes.OrderBy(kvp => kvp.Value.Item1);

                foreach (KeyValuePair<int, Tuple<string, string, string, string>> item in dictionaryTrie)
                {
                    string premiereValeur = item.Value.Item1;
                    char premiereLettre = premiereValeur[0];

                    // Réinitialisation du Y si on change de page
                    if (lettreCheck != premiereLettre)
                    {
                        y = initialY;
                        lettreCheck = premiereLettre;
                    }

                    string tabPageName = "page" + premiereLettre.ToString().ToUpper();
                    TabPage pageCorrespondante = tbControlAttributs.TabPages[tabPageName];

                    if (pageCorrespondante != null)
                    {
                        // Création d'une CheckBox
                        CheckBox checkBox = new CheckBox
                        {
                            Name = "chck" + premiereValeur,
                            Location = new Point(x, y),
                            Width = 20,
                            Tag = premiereValeur,
                            Checked = CheckIfAttributeIsInRichTextBox(premiereValeur),
                            Enabled = GlobaleVariables.IsEdit ? false : true
                        };

                        checkBox.Click += checkBox_Click;

                        pageCorrespondante.Controls.Add(checkBox);

                        x += checkBox.Width;
                        y += 5;

                        LinkLabel linkLabel = new LinkLabel
                        {
                            Name = "lnkLbl" + premiereValeur,
                            Location = new Point(x, y),
                            Text = premiereValeur,
                            Tag = premiereValeur,
                            AutoSize = true
                        };

                        linkLabel.LinkClicked += linkLabelAttribut_LinkClicked;

                        pageCorrespondante.Controls.Add(linkLabel);

                        x = initialX;
                        y += decalageY;
                    }
                }
            }
            else if (cbbTrier.SelectedIndex == 1)
            {
                var dictionaryTrie = dictionaryAttributes.OrderBy(kvp => kvp.Value.Item3).ThenBy(kvp => kvp.Value.Item1);

                foreach (KeyValuePair<int, Tuple<string, string, string, string>> item in dictionaryTrie)
                {
                    string premiereValeur = item.Value.Item1;
                    string pageTag = item.Value.Item3;

                    // Réinitialisation du Y si on change de page
                    if (tagTemp != pageTag)
                    {
                        y = initialY;
                        tagTemp = pageTag;
                    }

                    string tabPageName = "page" + pageTag.ToString().ToUpper();
                    TabPage pageCorrespondante = tbControlAttributs.TabPages[tabPageName];

                    if (pageCorrespondante != null)
                    {
                        // Création d'une CheckBox
                        CheckBox checkBox = new CheckBox
                        {
                            Name = "chck" + premiereValeur,
                            Location = new Point(x, y),
                            Width = 20,
                            Tag = premiereValeur,
                            Checked = CheckIfAttributeIsInRichTextBox(premiereValeur),
                            Enabled = GlobaleVariables.IsEdit ? false : true
                        };

                        checkBox.Click += checkBox_Click;

                        pageCorrespondante.Controls.Add(checkBox);

                        x += checkBox.Width;
                        y += 5;

                        LinkLabel linkLabel = new LinkLabel
                        {
                            Name = "lnkLbl" + premiereValeur,
                            Location = new Point(x, y),
                            Text = premiereValeur,
                            Tag = premiereValeur,
                            AutoSize = true
                        };

                        linkLabel.LinkClicked += linkLabelAttribut_LinkClicked;

                        pageCorrespondante.Controls.Add(linkLabel);

                        x = initialX;
                        y += decalageY;
                    }
                }
            }
            else
            {
                tbControlAttributs.TabPages.Clear();

                TabPage tabPage = new TabPage
                {
                    Text = "Attributs",
                    Name = "Attributs",
                    AutoScroll = true,
                    BackColor = Color.White
                };

                tbControlAttributs.TabPages.Add(tabPage);

                foreach (KeyValuePair<int, Tuple<string, string, string, string>> item in dictionaryAttributes)
                {
                    string premiereValeur = item.Value.Item1;

                    TabPage pageCorrespondante = tbControlAttributs.TabPages["Attributs"];

                    if (pageCorrespondante != null)
                    {
                        // Création d'une CheckBox
                        CheckBox checkBox = new CheckBox
                        {
                            Name = "chck" + premiereValeur,
                            Location = new Point(x, y),
                            Width = 20,
                            Tag = premiereValeur,
                            Checked = CheckIfAttributeIsInRichTextBox(premiereValeur),
                            Enabled = GlobaleVariables.IsEdit ? false : true
                        };

                        checkBox.Click += checkBox_Click;

                        pageCorrespondante.Controls.Add(checkBox);

                        x += checkBox.Width;
                        y += 5;

                        LinkLabel linkLabel = new LinkLabel
                        {
                            Name = "lnkLbl" + premiereValeur,
                            Location = new Point(x, y),
                            Text = premiereValeur,
                            Tag = premiereValeur,
                            AutoSize = true
                        };

                        linkLabel.LinkClicked += linkLabelAttribut_LinkClicked;

                        pageCorrespondante.Controls.Add(linkLabel);

                        x = initialX;
                        y += decalageY;
                    }
                }
            }

            EnableOrDisableCheckBoxes();
            Console.WriteLine("########### FIN Méthode GetAttributs ###########");
        }

        /// <summary>
        /// Permet d'afficher dans un autre formulaire, les différentes informations
        /// d'un attribut sur lequel l'utilisateur a cliqué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void linkLabelAttribut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormulaireApercuAttributs formulaireApercuAttributs = new FormulaireApercuAttributs();
            LinkLabel linkLabel = sender as LinkLabel;

            AttributsController.GetApercuAttribut(formulaireApercuAttributs, linkLabel.Text);
            formulaireApercuAttributs.Show();
        }

        /// <summary>
        /// Gère le clic sur une CheckBox pour ajouter ou retirer dynamiquement 
        /// l'attribut correspondant de la RichTextBox
        /// </summary>
        /// <param name="sender">L'objet CheckBox qui a déclenché l'événement de clic.</param>
        /// <param name="e">Les arguments de l'événement de clic.</param>
        public void checkBox_Click(object sender, EventArgs e)
        {
            // Récupère la CheckBox qui a été cliquée
            CheckBox checkBox = sender as CheckBox;

            // Obtient le nom de l'attribut à partir du nom de la CheckBox
            string attribut = AttributsController.GetAttributByName(checkBox.Name.Substring(4));

            // Si la CheckBox est cochée
            if (checkBox.Checked)
            {
                // Vérifie si l'attribut est déjà présent dans la RichTextBox
                if (dictionaryOfSpecificationsAttributes.ContainsKey(attribut))
                {
                    string specificationAttribute = AttributesSpecifications(attribut);

                    if (!String.IsNullOrEmpty(specificationAttribute))
                    {
                        attribut += specificationAttribute;
                    }
                    else
                    {
                        checkBox.Checked = false;
                        return;
                    }
                }

                // Ajoute l'attribut à la RichTextBox, en commençant par une nouvelle ligne si nécessaire
                rtbAttributs.Text += rtbAttributs.Lines.Length > 0 ? Environment.NewLine + attribut : attribut;
                // Active ou désactive les CheckBox en fonction de la sélection
                EnableOrDisableCheckBoxes();
            }
            else
            {
                // Obtient l'index de la ligne contenant l'attribut à supprimer
                int indexToDelete = Utils.GetLineNumberToDelete(attribut, rtbAttributs);

                // Copie les lignes actuelles de la RichTextBox dans une liste
                List<string> lines = new List<string>(rtbAttributs.Lines);

                // Supprime la ligne contenant l'attribut à partir de la liste
                lines.RemoveAt(indexToDelete);

                // Met à jour le contenu de la RichTextBox avec les lignes modifiées
                rtbAttributs.Lines = lines.ToArray();

                // Active ou désactive les CheckBox en fonction de la sélection
                EnableOrDisableCheckBoxes();
            }
        }

        /// <summary>
        /// Détermine le nombre d'attributs qu'un personnage peut encore
        /// s'attribuer
        /// </summary>
        /// <param name="idPersonnage"></param>
        /// <returns></returns>
        public int MaxAttributesByLevel(int idPersonnage)
        {
            int nbAttributes = 0;
            int niveauPersonnage = PersonnageController.GetNiveauPersonnage(idPersonnage);

            if (niveauPersonnage <= 3)
                nbAttributes = 2;
            else if (niveauPersonnage <= 5)
                nbAttributes = 3;
            else if (niveauPersonnage <= 6)
                nbAttributes = 4;
            else if (niveauPersonnage <= 8)
                nbAttributes = 6;
            else if (niveauPersonnage <= 12)
                nbAttributes = 7;
            else if (niveauPersonnage <= 13)
                nbAttributes = 8;
            else if (niveauPersonnage <= 14)
                nbAttributes = 9;
            else if (niveauPersonnage <= 16)
                nbAttributes = 11;
            else if (niveauPersonnage <= 17)
                nbAttributes = 12;
            else if (niveauPersonnage > 19)
                nbAttributes = 13;

            return nbAttributes;
        }

        /// <summary>
        /// Permet d'activer ou désactiver les CheckBox attributs
        /// </summary>
        /// <param name="page"></param>
        private void EnableOrDisableCheckBoxes()
        {
            int nbLignesRichTextBox = rtbAttributs.Lines.Length;
            int nbAttributParNiveau = MaxAttributesByLevel(GlobaleVariables.IdPersonnage);

            bool enableOrDisableCheckBoxes = nbLignesRichTextBox < nbAttributParNiveau;

            foreach (TabPage page in tbControlAttributs.TabPages)
            {
                foreach (CheckBox checkBox in page.Controls.OfType<CheckBox>())
                {
                    if (!checkBox.Checked)
                    {
                        checkBox.Enabled = enableOrDisableCheckBoxes;
                    }
                }
            }
        }

        private bool CheckIfAttributeIsInRichTextBox(string strInLine)
        {
            foreach (string ligne in rtbAttributs.Lines)
            {
                if (ligne.Contains(strInLine))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Permet de sauvegarder les informations du formulaire dans la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            #region Initialisation des variables
            Dictionary<int, Tuple<string, string>> dictionnaireIdSpecificationsAttribut = new Dictionary<int, Tuple<string, string>>();
            FormulaireCompetencesCaracteristiques formulaireCompetencesCaracteristiques = new FormulaireCompetencesCaracteristiques();
            int nbCaseCocher = 0;
            #endregion

            try
            {
                /// On récupère le nombre de CheckBox cochées
                foreach (TabPage pages in tbControlAttributs.TabPages)
                {
                    foreach (CheckBox checkBox in pages.Controls.OfType<CheckBox>())
                    {
                        nbCaseCocher += checkBox.Checked ? 1 : 0;
                    }
                }

                /**
                 * Test BON NOMBRE ATTRIBUTS
                 */
                if (nbCaseCocher < MaxAttributesByLevel(GlobaleVariables.IdPersonnage))
                {
                    MessageBox.Show(string.Format("Il vous reste {0} à donner à votre personnage", MaxAttributesByLevel(GlobaleVariables.IdPersonnage) - nbCaseCocher));
                    return;
                }

                foreach (string line in rtbAttributs.Lines)
                {
                    string[] lineSplited = line.Split(':');
                    int idAttribut = AttributsController.GetIdAttributByName(lineSplited[0]);

                    if (lineSplited.Length > 1)
                        dictionnaireIdSpecificationsAttribut.Add(idAttribut, Tuple.Create(lineSplited[0], lineSplited[1]));
                    else
                        dictionnaireIdSpecificationsAttribut.Add(idAttribut, Tuple.Create(lineSplited[0], string.Empty));
                }

                // On sauvegarde chaque attribut en base
                foreach (var keyValue in dictionnaireIdSpecificationsAttribut)
                {
                    int idAttribut = keyValue.Key;
                    string nameAttribut = keyValue.Value.Item1;
                    string specificationsAttr = keyValue.Value.Item2;

                    if (!AttributsController.CheckIfPersonnageHaveAttribut(GlobaleVariables.IdPersonnage, idAttribut))
                    {
                        AttributsController.AddNewAttributToPersonnage(idAttribut, GlobaleVariables.IdPersonnage, specificationsAttr);
                    }
                }

                MessageBox.Show("Attributs sauvegardés");
                GlobaleVariables.IsClosedProgrammatically = true;

                if (GlobaleVariables.IsEdit)
                {
                    FormEditMenu formEditMenu = new FormEditMenu();
                    formEditMenu.Show();
                }
                else
                {
                    formulaireCompetencesCaracteristiques.Show();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Permet de spécifier une information liée à un attribut coché
        /// </summary>
        /// <param name="nameAttribut">Le nom de l'attribut à spécifier.</param>
        /// <returns>Une chaîne de caractères spécifiant l'information liée à l'attribut.</returns>
        private string AttributesSpecifications(string nameAttribut)
        {
            // Modèles de motifs de recherche utilisés pour la manipulation de texte
            string patternI = @"\bi\b";
            string patternX = @"\bx\b";

            // Crée une nouvelle instance du formulaire de spécification d'attributs
            using (FormSpecificationAttributs formSpecification = new FormSpecificationAttributs())
            {
                // Désactive certains éléments du formulaire par défaut
                formSpecification.PanelPourcentage.Enabled = false;
                formSpecification.PanelMagies.Enabled = false;
                formSpecification.NudNombre.Enabled = false;

                // Effectue des actions spécifiques en fonction du nom de l'attribut
                switch (nameAttribut)
                {
                    case "Apnée prolongée":
                        formSpecification.TextInput.Enabled = false;
                        formSpecification.NudNombre.Enabled = true;
                        break;
                    case "Armure naturelle":
                        formSpecification.TextInput.Enabled = false;
                        formSpecification.NudNombre.Enabled = true;
                        break;
                    case "Canaliseur":
                        patternX = @"x(?=%)";
                        formSpecification.TextInput.Enabled = false;
                        formSpecification.PanelPourcentage.Enabled = true;
                        break;
                    case "Coagulation":
                        break;
                    case "Etoile montante":
                        break;
                    case "Hyperesthésie":
                        patternX = @"x(?=%)";
                        formSpecification.TextInput.Enabled = false;
                        formSpecification.PanelPourcentage.Enabled = true;
                        break;
                    case "Immuno-maladie":
                        patternX = @"x(?=%)";
                        formSpecification.TextInput.Enabled = false;
                        formSpecification.PanelPourcentage.Enabled = true;
                        break;
                    case "Magicien":
                        formSpecification.TextInput.Enabled = false;
                        formSpecification.PanelMagies.Enabled = true;
                        break;
                    case "Mithridatisation":
                        patternX = @"x(?=%)";
                        formSpecification.TextInput.Enabled = false;
                        formSpecification.PanelPourcentage.Enabled = true;
                        break;
                    case "Porteur de charges lourdes":
                        formSpecification.TextInput.Enabled = false;
                        formSpecification.NudNombre.Enabled = true;
                        break;
                    case "Sac d'énergie":
                        patternX = @"x(?=%)";
                        formSpecification.TextInput.Enabled = false;
                        formSpecification.PanelPourcentage.Enabled = true;
                        break;
                    case "Tolérance au froid":
                        patternX = @"(?<=-)x";
                        formSpecification.TextInput.Enabled = false;
                        formSpecification.NudNombre.Enabled = true;
                        break;
                    case "Tolérance à la chaleur":
                        patternX = @"(?<=-)x";
                        formSpecification.TextInput.Enabled = false;
                        formSpecification.NudNombre.Enabled = true;
                        break;
                    default:
                        break;
                }

                // Affiche le formulaire de spécification et attend la réponse de l'utilisateur
                if (formSpecification.ShowDialog() == DialogResult.OK)
                {
                    if (nameAttribut == "Porteur de charges lourdes")
                        GlobaleVariables.PoidsPorteurChargeLibre = formSpecification.UserInput;
                    // Obtient la valeur actuelle de l'attribut depuis le dictionnaire
                    string valueKey = string.Empty;
                    dictionaryOfSpecificationsAttributes.TryGetValue(nameAttribut, out valueKey);

                    // Effectue des remplacements de motifs dans la valeur de l'attribut
                    valueKey = Regex.Replace(valueKey, patternI, PersonnageController.GetPrenomPersonnage(GlobaleVariables.IdPersonnage));
                    valueKey = Regex.Replace(valueKey, patternX, formSpecification.UserInput);

                    // Retourne la chaîne de caractères spécifiant l'information de l'attribut
                    return ": " + valueKey;
                }
                else
                {
                    // Si l'utilisateur annule la spécification, retourne une chaîne vide
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Permet de mettre à jour la taille du formulaire
        /// ainsi que de ses controls enfants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormulaireAttributs_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Width / dictionaryControlOriginalSize[this].Width;
            float yRatio = (float)this.Height / dictionaryControlOriginalSize[this].Height;

            foreach (System.Collections.Generic.KeyValuePair<Control, Rectangle> entry in dictionaryControlOriginalSize)
            {
                Utils.AdjustControlSizeAndPosition(entry.Key, entry.Value, xRatio, yRatio);
            }
        }

        /// <summary>
        /// Permet de cocher et d'ajouter dès que le formulaire est ouvert, les attributs que le personnage possède déjà.
        /// </summary>
        private void EditPersonnageAttributs()
        {
            string[] attributes = AttributsController.GetListNomAttributs(GlobaleVariables.IdPersonnage).ToArray();

            foreach (TabPage page in tbControlAttributs.TabPages)
            {
                foreach (CheckBox checkBox in page.Controls.OfType<CheckBox>())
                {
                    if (attributes.Contains(checkBox.Tag))
                    {
                        checkBox.Enabled = false;
                        checkBox.Checked = true;

                        rtbAttributs.Text += rtbAttributs.Lines.Length > 0 ? Environment.NewLine + checkBox.Tag.ToString() : checkBox.Tag.ToString();
                    }
                }
            }

            EnableOrDisableCheckBoxes();
        }

        /// <summary>
        /// Événement qui gère le cas de figure en fonction du tri choisi
        /// par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbTrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<TabPage> pages = new List<TabPage>();

            tbControlAttributs.TabPages.Clear();

            // Tri (A-Z)
            if ((sender as ComboBox).SelectedIndex == 0)
            {
                for (char letter = 'A'; letter <= 'Z'; letter++)
                {
                    TabPage tabPage = new TabPage
                    {
                        Text = letter.ToString(),
                        Name = "page" + letter,
                        AutoScroll = true,
                        BackColor = Color.White
                    };

                    pages.Add(tabPage);
                }

                tbControlAttributs.TabPages.AddRange(pages.ToArray());
            }
            // Tri Type
            else if ((sender as ComboBox).SelectedIndex == 1)
            {
                TabPage pagePhysique = new TabPage();
                pagePhysique.Text = "Physique";
                pagePhysique.Name = "pagePhysique";
                pagePhysique.AutoScroll = true;
                pagePhysique.BackColor = Color.White;

                TabPage pageMental = new TabPage();
                pageMental.Text = "Mental";
                pageMental.Name = "pageMental";
                pageMental.AutoScroll = true;
                pageMental.BackColor = Color.White;

                TabPage pageSocial = new TabPage();
                pageSocial.Text = "Social";
                pageSocial.Name = "pageSocial";
                pageSocial.AutoScroll = true;
                pageSocial.BackColor = Color.White;

                TabPage[] pagesType = { pagePhysique, pageMental, pageSocial };

                tbControlAttributs.TabPages.AddRange(pagesType);
            }
            // DEFAUT
            else
            {
                TabPage tabPage = new TabPage
                {
                    Text = "Attributs",
                    Name = "Attributs",
                    AutoScroll = true,
                    BackColor = Color.White
                };

                tbControlAttributs.TabPages.Add(tabPage);
            }

            DisplayAttributes();
        }


        /// <summary>
        /// Événement qui gère la fermeture du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormulaireAttributs_FormClosing(object sender, FormClosingEventArgs e)
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
                        PersonnageController.DeleteRowPersonnage(GlobaleVariables.IdPersonnage);
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