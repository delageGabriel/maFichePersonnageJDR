using System.Linq;
using maFichePersonnageJDR.Classe;
using maFichePersonnageJDR.Controller;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace maFichePersonnageJDR.View.Formulaires
{
    public partial class FrmCreationArmure : Form
    {
        private int valeurFirstMateriau = 0;
        private int valeurSecondMateriau = 0;
        private int valeurThirdMateriau = 0;

        private string[,] tableauAverageMateriauEffect = new string[22, 3]; // Tableau de 22 lignes et 3 colonnes
        private string[] listTextBoxPreview;
        private string[] previewNextImprovementArmor = new string[22];

        /// Création d'un tableau qui contiendra les valeurs des résistances et bonus de l'armure toute
        /// en une fois, afin qu'il serve aussi à afficher la preview.
        private string[] valuesResistancesBonusArmor = new string[21];

        public FrmCreationArmure()
        {
            InitializeComponent();
            GetTextInTextBoxMateriauPreview();
        }

        private void GetTextInTextBoxMateriauPreview()
        {
            listTextBoxPreview = new[]
            {
                txtBxTranchant.Text,
                txtBxContondant.Text,
                txtBxPerforant.Text,
                txtBxIgnee.Text,
                txtBxAquatique.Text,
                txtBxCeleste.Text,
                txtBxTerrestre.Text,
                txtBxPoison.Text,
                txtBxParalysie.Text,
                txtBxMaledictions.Text,
                txtBxSaignement.Text,
                txtBxChoc.Text,
                txtBxAcide.Text,
                txtBxMaladies.Text,
                txtBxChute.Text,
                txtBxPression.Text,
                txtBxChaleur.Text,
                txtBxFroid.Text,
                txtBxBonusInitiative.Text,
                txtBxDeplacement.Text,
                txtBxValeur.Text, // index 20
                txtBxPoids.Text,
            };
        }

        /// <summary>
        /// Retourne le nombre de colonnes actives dans le tableau
        /// "tableauAverageMateriauEffect".
        /// </summary>
        /// <returns>
        /// Nombre de colonnes actives dans le tableau.
        /// </returns>
        private List<int> GetActiveColumnsForAverage()
        {
            int cols = tableauAverageMateriauEffect.GetLength(1); // ex. 3

            // 1 Recherche des colonnes non vides qui ont bien un nom de matériau en première ligne.
            List<int> activeCols = new List<int>();
            for (int c = 0; c < cols; c++)
            {
                if (!string.IsNullOrWhiteSpace(tableauAverageMateriauEffect[0, c]))
                    activeCols.Add(c);
            }

            return activeCols;
        }
        private void FrmCreationArmure_Load(object sender, EventArgs e)
        {
            cmbBxQualiteMateriau.SelectedIndex = 2; // Valeur par défaut de la ComboBox pour éviter d'éventuels bugs.
            GetAllMateriauxByCategorie();
        }
        /// <summary>
        /// Obtenir tous les matériaux en les triant par leur catégorie,
        /// pour les inclure dans les différentes ListBox du Control TabControl.
        /// </summary>
        public void GetAllMateriauxByCategorie()
        {
            Console.WriteLine("########### Classe : FrmCreationArmure; Méthode : GetAllMateriauxByCategorie; ###########");

            try
            {
                Dictionary<string, Model.MateriauxModel> dictionnaireMateriauxCateg = MateriauxController.GetAllMateriauNameAndCategorie();

                if (dictionnaireMateriauxCateg != null)
                {
                    foreach (var materiaux in dictionnaireMateriauxCateg.Values)
                    {
                        if (materiaux.Categorie == "Transformé")
                            lstBxTransformes.Items.Add(materiaux.NomMateriau);
                        else if (materiaux.Categorie == "Métaux")
                            lstBxMetaux.Items.Add(materiaux.NomMateriau);
                        else if (materiaux.Categorie == "Minerai")
                            lstBxMinerais.Items.Add(materiaux.NomMateriau);
                        else if (materiaux.Categorie == "Animal")
                            lstBxAnimaux.Items.Add(materiaux.NomMateriau);
                        else
                        {
                            Console.WriteLine(string.Format("Catégorie de matériau non reconnue ! Catégorie de matériau en question : {0}"), materiaux.Categorie);
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Retourne la valeur brute du matériau sélectionné, sans tenir compte de la
        /// conversion en pièce d'or, argent, cuivre.
        /// </summary>
        /// <param name="qualite">
        /// Qualité du matériau dont on cherche la valeur.
        /// </param>
        /// <param name="nomMateriau">
        /// Nom du matériau dont on cherche la valeur.
        /// </param>
        /// <returns>
        /// Valeur du matériau en string, pour un nom et une qualité donnée.
        /// </returns>
        public string GetValueMateriauByNameAndQuality(int qualite, string nomMateriau)
        {
            try
            {
                return MateriauxValeurController.GetValueMateriauByNameAndQuality(qualite, nomMateriau);
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Retourne le poids du matériau sélectionné.
        /// </summary>
        /// <param name="qualite">
        /// Qualité du matériau dont on cherche la valeur.
        /// </param>
        /// <param name="nomMateriau">
        /// Nom du matériau dont on cherche la valeur.
        /// </param>
        /// <returns>
        /// Poids du matériau en string, pour un nom et une qualité donnée.
        /// </returns>
        public string GetWeightMateriauByNameAndQuality(int qualite, string nomMateriau)
        {
            try
            {
                return MateriauxPoidsController.GetWeightByNameAndQuality(qualite, nomMateriau);
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Obtient les effets du matériau sélectionné pour mettre à jour
        /// chaque TextBox dans le panel de la composition de l'armure.
        /// </summary>
        /// <param name="qualite">
        /// Qualité du matériau dont on cherche la valeur.
        /// </param>
        /// <param name="nomMateriau">
        /// Nom du matériau dont on cherche la valeur.
        /// </param>
        public void GetMateriauxEffectsByNameAndQuality(int qualite, string nomMateriau)
        {
            Console.WriteLine("########### Classe : FrmCreationArmure; Méthode : GetAllMateriauxByCategorie; ###########");

            try
            {
                Dictionary<int, List<string>> dictionaryMateriaux = MateriauxEffetsController.GetMateriauxEffectsByNameAndQuality(qualite, nomMateriau);

                if (dictionaryMateriaux != null)
                {
                    foreach (List<string> materiau in dictionaryMateriaux.Values)
                    {
                        if (materiau.Contains("tranchant"))
                            txtBxTranchant.Text = materiau[2];
                        else if (materiau.Contains("contondant"))
                            txtBxContondant.Text = materiau[2];
                        else if (materiau.Contains("perforant"))
                            txtBxPerforant.Text = materiau[2];
                        else if (materiau.Contains("ignee"))
                            txtBxIgnee.Text = materiau[2];
                        else if (materiau.Contains("aquatique"))
                            txtBxAquatique.Text = materiau[2];
                        else if (materiau.Contains("celeste"))
                            txtBxCeleste.Text = materiau[2];
                        else if (materiau.Contains("terrestre"))
                            txtBxTerrestre.Text = materiau[2];
                        else if (materiau.Contains("poisons"))
                            txtBxPoison.Text = materiau[2];
                        else if (materiau.Contains("paralysie"))
                            txtBxParalysie.Text = materiau[2];
                        else if (materiau.Contains("maledictions"))
                            txtBxMaledictions.Text = materiau[2];
                        else if (materiau.Contains("saignement"))
                            txtBxSaignement.Text = materiau[2];
                        else if (materiau.Contains("choc"))
                            txtBxChoc.Text = materiau[2];
                        else if (materiau.Contains("maladies"))
                            txtBxMaladies.Text = materiau[2];
                        else if (materiau.Contains("acide"))
                            txtBxAcide.Text = materiau[2];
                        else if (materiau.Contains("chute"))
                            txtBxChute.Text = materiau[2];
                        else if (materiau.Contains("chaleur"))
                            txtBxChaleur.Text = materiau[2];
                        else if (materiau.Contains("froid"))
                            txtBxFroid.Text = materiau[2];
                        else if (materiau.Contains("initiative"))
                            txtBxBonusInitiative.Text = materiau[2];
                        else if (materiau.Contains("vitesse"))
                            txtBxDeplacement.Text = materiau[2];
                        else if (materiau.Contains("pression"))
                            txtBxPression.Text = materiau[2];
                        else
                        {
                            Console.WriteLine(string.Format("Effet du matériau non reconnu ! Matériau : {0}", materiau[2]));
                        }

                        txtBxValeur.Text = GetValueMateriauByNameAndQuality(qualite, nomMateriau);
                        txtBxPoids.Text = GetWeightMateriauByNameAndQuality(qualite, nomMateriau);
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void lstBxTransformes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxTaille.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner la taille de l'armure avant de choisir un matériau.");
                return;
            }
            // Eviter que le SelectedIndexChanged de chaque ListBox se lance après nettoyage de la liste, et créer un bug.
            ListBox lb = (ListBox)sender;
            if (!lb.Focus()) return;

            DisableOtherSelectedIndex(lstBxMetaux, lstBxMinerais, lstBxAnimaux);
            int qualite = Convert.ToInt32(cmbBxQualiteMateriau.SelectedItem);
            ListBox nomMateriau = (ListBox)sender;

            GetMateriauxEffectsByNameAndQuality(qualite, nomMateriau.SelectedItem.ToString());
            GetTextInTextBoxMateriauPreview();

            // Mettre à jour la preview des valeurs de résistances et bonus de l'armure avec
            // l'ajout de ce matériau.
            UpdateResistancesBonusArmorInformations();
        }

        private void lstBxMetaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxTaille.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner la taille de l'armure avant de choisir un matériau.");
                return;
            }
            // Eviter que le SelectedIndexChanged de chaque ListBox se lance après nettoyage de la liste, et créer un bug.
            ListBox lb = (ListBox)sender;
            if (!lb.Focus()) return;

            DisableOtherSelectedIndex(lstBxTransformes, lstBxMinerais, lstBxAnimaux);
            int qualite = Convert.ToInt32(cmbBxQualiteMateriau.SelectedItem);
            ListBox nomMateriau = (ListBox)sender;

            GetMateriauxEffectsByNameAndQuality(qualite, nomMateriau.SelectedItem.ToString());
            GetTextInTextBoxMateriauPreview();

            // Mettre à jour la preview des valeurs de résistances et bonus de l'armure avec
            // l'ajout de ce matériau.
            UpdateResistancesBonusArmorInformations();
        }

        private void lstBxMinerais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxTaille.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner la taille de l'armure avant de choisir un matériau.");
                return;
            }
            // Eviter que le SelectedIndexChanged de chaque ListBox se lance après nettoyage de la liste, et créer un bug.
            ListBox lb = (ListBox)sender;
            if (!lb.Focus()) return;

            DisableOtherSelectedIndex(lstBxTransformes, lstBxMetaux, lstBxAnimaux);
            int qualite = Convert.ToInt32(cmbBxQualiteMateriau.SelectedItem);
            ListBox nomMateriau = (ListBox)sender;

            GetMateriauxEffectsByNameAndQuality(qualite, nomMateriau.SelectedItem.ToString());
            GetTextInTextBoxMateriauPreview();

            // Mettre à jour la preview des valeurs de résistances et bonus de l'armure avec
            // l'ajout de ce matériau.
            UpdateResistancesBonusArmorInformations();
        }

        private void lstBxAnimaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxTaille.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner la taille de l'armure avant de choisir un matériau.");
                return;
            }
            // Eviter que le SelectedIndexChanged de chaque ListBox se lance après nettoyage de la liste, et créer un bug.
            ListBox lb = (ListBox)sender;
            if (!lb.Focus()) return;

            DisableOtherSelectedIndex(lstBxTransformes, lstBxMetaux, lstBxMinerais);
            int qualite = Convert.ToInt32(cmbBxQualiteMateriau.SelectedItem);
            ListBox nomMateriau = (ListBox)sender;

            GetMateriauxEffectsByNameAndQuality(qualite, nomMateriau.SelectedItem.ToString());
            GetTextInTextBoxMateriauPreview();

            // Mettre à jour la preview des valeurs de résistances et bonus de l'armure avec
            // l'ajout de ce matériau.
            UpdateResistancesBonusArmorInformations();
        }

        /// <summary>
        /// Choisir la qualité du matériau, pour l'ajout et pour voir ses informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBxQualiteMateriau_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cbbQualite = (ComboBox)sender;
            int qualite = Convert.ToInt32(cbbQualite.SelectedItem);
            string nomMateriau = string.Empty;

            if (lstBxTransformes.SelectedItem != null)
                nomMateriau = lstBxTransformes.SelectedItem.ToString();
            else if (lstBxMetaux.SelectedItem != null)
                nomMateriau = lstBxMetaux.SelectedItem.ToString();
            else if (lstBxMinerais.SelectedItem != null)
                nomMateriau = lstBxMinerais.SelectedItem.ToString();
            else if (lstBxAnimaux.SelectedItem != null)
                nomMateriau = lstBxAnimaux.SelectedItem.ToString();

            GetMateriauxEffectsByNameAndQuality(qualite, nomMateriau);
            GetTextInTextBoxMateriauPreview();
        }

        /// <summary>
        /// Désélectionne les sélections des autres ListBox pour éviter des bugs
        /// sur le tableau des résistances.
        /// </summary>
        /// <param name="listBoxes">
        /// Les ListBox dont il faut désélectionner l'item.
        /// </param>
        private void DisableOtherSelectedIndex(params ListBox[] listBoxes)
        {
            foreach (ListBox listBox in listBoxes)
            {
                listBox.ClearSelected();
            }
        }

        /// <summary>
        /// Ajout des matériaux dans la CheckListBox pour connaître la composition de l'armure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterMateriau_Click(object sender, EventArgs e)
        {
            // Au moins un matériau doit être sélectionné pour l'ajouter.
            if (lstBxTransformes.SelectedItem != null ||
                lstBxMetaux.SelectedItem != null ||
                lstBxMinerais.SelectedItem != null ||
                lstBxAnimaux.SelectedItem != null)
            {
                // 1 Récupération de la qualité via la combobox et du nom via l'item de la listbox sélectionné
                int qualite = Convert.ToInt32(cmbBxQualiteMateriau.SelectedItem);
                string nomMateriau = string.Empty;

                if (lstBxTransformes.SelectedItem != null)
                    nomMateriau = lstBxTransformes.SelectedItem.ToString();
                else if (lstBxMetaux.SelectedItem != null)
                    nomMateriau = lstBxMetaux.SelectedItem.ToString();
                else if (lstBxMinerais.SelectedItem != null)
                    nomMateriau = lstBxMinerais.SelectedItem.ToString();
                else if (lstBxAnimaux.SelectedItem != null)
                    nomMateriau = lstBxAnimaux.SelectedItem.ToString();

                // 2 Vérification qu'on puisse toujours ajouter un matériau avant de poursuivre
                if (chkLstBxCompositionArmure.Items.Count == 3)
                    MessageBox.Show("Il y a déjà trois matériaux dans la fabrication de l'armure !");
                else
                {
                    // 3 Demander confirmation à l'utilisateur de l'ajout du matériau et sa qualité
                    var result = MessageBox.Show(
                    this,
                    string.Format("Voulez-vous ajouter le matériau {0} de qualité {1} à la fabrication ? ", nomMateriau, qualite.ToString()),
                    "Confirmation",
                    MessageBoxButtons.YesNo
                    );

                    if (result == DialogResult.Yes)
                    {
                        chkLstBxCompositionArmure.Items.Add(string.Format("{0};qualité {1}", nomMateriau, qualite));

                        // 4 Assignation des valeurs de chacun des matériaux
                        if (chkLstBxCompositionArmure.Items.Count == 1)
                            valeurFirstMateriau = Convert.ToInt32(GetValueMateriauByNameAndQuality(qualite, nomMateriau));
                        else if (chkLstBxCompositionArmure.Items.Count == 2)
                            valeurSecondMateriau = Convert.ToInt32(GetValueMateriauByNameAndQuality(qualite, nomMateriau));
                        else if (chkLstBxCompositionArmure.Items.Count == 3)
                            valeurThirdMateriau = Convert.ToInt32(GetValueMateriauByNameAndQuality(qualite, nomMateriau));

                        // 5 Mise à jour du coût total de l'armure
                        UpdateCoutArmure();

                        // 6 Mise à jour des données des résistances de l'armure complète
                        AddMateriauEffectInTableau(qualite, nomMateriau);
                        UpdateTextBoxesPerPlan();

                        // 7 On vide les TextBox de preview
                        CleanAllPreviewTextBox();
                    }

                }
            }
            else
                MessageBox.Show("Veuillez sélectionner un matériau !");
        }

        private void btnRetirerMateriau_Click(object sender, EventArgs e)
        {

            // Sécurité en cas de bug, si le bouton est activé malgré qu'il n'y ait rien de coché
            if (chkLstBxCompositionArmure.CheckedIndices.Count != 1)
            {
                MessageBox.Show("Veuillez cocher un matériau à retirer.");
                return;
            }

            if (chkLstBxCompositionArmure.CheckedItems.Count == 1)
            {

                int index = chkLstBxCompositionArmure.CheckedIndices[0];

                // 1 Retirer l'élément coché.
                string chkBx = chkLstBxCompositionArmure.CheckedItems[0].ToString();
                string[] nomMateriau = chkBx.Split(';');
                chkLstBxCompositionArmure.Items.Remove(chkBx);
                btnRetirerMateriau.Enabled = false;

                // 2 Décaler les valeurs pour être à jour.
                switch (index)
                {
                    case 0:
                        valeurFirstMateriau = valeurSecondMateriau;
                        valeurSecondMateriau = valeurThirdMateriau;
                        valeurThirdMateriau = 0;
                        break;
                    case 1:
                        valeurSecondMateriau = valeurThirdMateriau;
                        valeurThirdMateriau = 0;
                        break;
                    case 2:
                        valeurThirdMateriau = 0;
                        break;
                }

                // 3 Mise à jour du coût total de l'armure
                UpdateCoutArmure();

                // 4 Mise à jour des données des résistances de l'armure complète
                RemoveMateriauEffectInTableau(nomMateriau[0]);
                UpdateTextBoxesPerPlan();
            }
        }

        /// <summary>
        /// Utilisation de l'événement pour empêcher le cochage de plusieurs CheckBox
        /// et activer/désactiver le bouton qui permet de retirer les matériaux.
        /// simultanéments.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkLstBxCompositionArmure_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /// Empêcher qu'il y ait plusieurs CheckBox cochés.
            CheckedListBox checkedList = (CheckedListBox)sender;

            // 1) Bloquer une 2e coche
            if (e.NewValue == CheckState.Checked)
            {
                if (checkedList.CheckedItems.Count > 0)
                {
                    e.NewValue = CheckState.Unchecked;
                    MessageBox.Show("Il faut sélectionner un matériau à la fois !");
                }
            }

            // 2) Calculer le nombre COCHÉ APRÈS l'action courante
            int nombreCase = 0;
            if (e.NewValue == CheckState.Checked)
                nombreCase = 1;
            else if (e.NewValue == CheckState.Unchecked && checkedList.GetItemChecked(e.Index))
                nombreCase = -1;

            int newCount = checkedList.CheckedItems.Count + nombreCase;
            // 3) Activer/désactiver le bouton
            btnRetirerMateriau.Enabled = newCount == 1;
        }
        /// <summary>
        /// Mets à jour le label du coût de l'armure, en fonction : du nombre de matériau dans la composition,
        /// du matériau et de sa qualité.
        /// </summary>
        private void UpdateCoutArmure()
        {
            int coutTotalArmure = valeurFirstMateriau + valeurSecondMateriau + valeurThirdMateriau;

            if (cmbBxTaille.SelectedIndex == 0)
                coutTotalArmure = Convert.ToInt32(coutTotalArmure * 0.5);
            else if (cmbBxTaille.SelectedIndex == 1)
                coutTotalArmure = Convert.ToInt32(coutTotalArmure * 0.8);
            else if (cmbBxTaille.SelectedIndex == 2)
                coutTotalArmure = Convert.ToInt32(coutTotalArmure * 1);
            else if (cmbBxTaille.SelectedIndex == 3)
                coutTotalArmure = Convert.ToInt32(coutTotalArmure * 2);
            else if (cmbBxTaille.SelectedIndex == 4)
                coutTotalArmure = Convert.ToInt32(coutTotalArmure * 3);
            else if (cmbBxTaille.SelectedIndex == 5)
                coutTotalArmure = Convert.ToInt32(coutTotalArmure * 4);

            lblNombreCoutArmure.Text = Utils.ConvertMoneyWithValue(coutTotalArmure);
        }
        /// <summary>
        /// En fonction de la taille choisit, le prix (et le poids) n'est pas le même.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBxTaille_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCoutArmure();
        }

        /// <summary>
        /// Ajoute les effets du matériau dans le tableau de la classe prévu à cet effet
        /// grâce à son nom et sa qualité.
        /// </summary>
        /// <param name="qualite">
        /// Qualité du matériau.
        /// </param>
        /// <param name="nomMateriau">
        /// Nom du matériau
        /// </param>
        private void AddMateriauEffectInTableau(int qualite, string nomMateriau)
        {
            try
            {
                Dictionary<int, List<string>> dictionaryMateriaux = MateriauxEffetsController.GetMateriauxEffectsByNameAndQuality(qualite, nomMateriau);

                if (dictionaryMateriaux != null)
                {
                    // 0 Ajout du nom du matériau pour retrouver la colonne à nettoyer en cas de suppression
                    tableauAverageMateriauEffect[0, chkLstBxCompositionArmure.Items.Count - 1] = nomMateriau; // ligne 0

                    foreach (List<string> materiau in dictionaryMateriaux.Values)
                    {
                        if (materiau.Contains("tranchant"))
                            tableauAverageMateriauEffect[1, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ligne 1, colonne = nombre d'objets dans la CheckedListBox.
                        else if (materiau.Contains("contondant"))
                            tableauAverageMateriauEffect[2, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ligne 2, ....
                        else if (materiau.Contains("perforant"))
                            tableauAverageMateriauEffect[3, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ligne 3, ....
                        else if (materiau.Contains("ignee"))
                            tableauAverageMateriauEffect[4, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ligne 4, ....
                        else if (materiau.Contains("aquatique"))
                            tableauAverageMateriauEffect[5, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ligne 5, ....
                        else if (materiau.Contains("celeste"))
                            tableauAverageMateriauEffect[6, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("terrestre"))
                            tableauAverageMateriauEffect[7, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("poisons"))
                            tableauAverageMateriauEffect[8, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("paralysie"))
                            tableauAverageMateriauEffect[9, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("maledictions"))
                            tableauAverageMateriauEffect[10, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("saignement"))
                            tableauAverageMateriauEffect[11, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("choc"))
                            tableauAverageMateriauEffect[12, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("acide"))
                            tableauAverageMateriauEffect[13, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("maladies"))
                            tableauAverageMateriauEffect[14, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("chute"))
                            tableauAverageMateriauEffect[15, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("chaleur"))
                            tableauAverageMateriauEffect[16, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("froid"))
                            tableauAverageMateriauEffect[17, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("initiative"))
                            tableauAverageMateriauEffect[18, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("vitesse"))
                            tableauAverageMateriauEffect[19, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else if (materiau.Contains("pression"))
                            tableauAverageMateriauEffect[20, chkLstBxCompositionArmure.Items.Count - 1] = materiau[2]; // ....
                        else
                        {
                            Console.WriteLine(string.Format("Effet du matériau non reconnu ! Matériau : {0}", materiau[2]));
                        }

                        tableauAverageMateriauEffect[21, chkLstBxCompositionArmure.Items.Count - 1] = GetWeightMateriauByNameAndQuality(qualite, nomMateriau);
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Supprime une colonne, et décale si besoin la dernière colonne du tableau
        /// pour remplacer celle qui vient d'être supprimée.
        /// </summary>
        /// <param name="nomMateriau">
        /// Le nom du matériau dont il faut supprimer la colonne. Ça va servir d'identifiant.
        /// </param>
        public void RemoveMateriauEffectInTableau(string nomMateriau)
        {
            int cols = tableauAverageMateriauEffect.GetLength(1); // Nombre de colonne
            int rows = tableauAverageMateriauEffect.GetLength(0); // Nombre de lignes

            // 1 Chercher la colonne
            int indexColonne = -1;
            for (int c = 0; c < cols; c++)
            {
                var cell = tableauAverageMateriauEffect[0, c];
                if (!string.IsNullOrWhiteSpace(cell) &&
                    string.Equals(cell.Trim(), nomMateriau.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    indexColonne = c;
                    break; // On s'arrête au premier match

                }
            }

            if (indexColonne == -1)
            {
                Console.WriteLine("Index de colonne non trouvé !");
                return; // pas trouvé : rien à faire (ou lève une exception si tu préfères)
            }

            // 2 Décaler à gauche à partir de la colonne supprimée
            for (int r = 0; r < rows; r++)
            {
                if (indexColonne == 0)
                {
                    tableauAverageMateriauEffect[r, indexColonne] = tableauAverageMateriauEffect[r, indexColonne + 1]; // La 2e colonne est décalée vers la 1ere.

                    if (tableauAverageMateriauEffect[r, indexColonne + 2] != string.Empty)
                        tableauAverageMateriauEffect[r, indexColonne + 1] = tableauAverageMateriauEffect[r, indexColonne + 2]; // La 3e colonne est décalée dans la deuxième.
                    else
                    {
                        tableauAverageMateriauEffect[r, indexColonne] = tableauAverageMateriauEffect[r, indexColonne + 1]; // La 2e colonne (précédemment 3e) est décalée vers la 1ere.
                        tableauAverageMateriauEffect[r, 1] = string.Empty; // Suppression de l'ultime colonne du tableau.
                    }

                }
                else if (indexColonne == 1)
                    tableauAverageMateriauEffect[r, indexColonne] = tableauAverageMateriauEffect[r, indexColonne + 1]; // La 3e colonne est décalée dans la deuxième.

                tableauAverageMateriauEffect[r, 2] = string.Empty; // Suppression de la dernière colonne qui dégage peu importe la colonne décalée.
            }
        }

        /// <summary>
        /// Mets à jour les TextBox contenant les caractéristiques finales de l'armure,
        /// et fait une moyenne s'il y a plusieurs matériaux dans la composition.
        /// </summary>
        private void UpdateTextBoxesPerPlan()
        {
            // 1 Recherche des colonnes non vides qui ont bien un nom de matériau en première ligne.
            List<int> activeCols = GetActiveColumnsForAverage(); // ex. 3

            if (activeCols.Count == 0)
            {
                // Vider toutes les TextBox

                // Tranchant
                txtTranchantModificationRecapitulatif.Text = string.Empty;
                // Contondant
                txtContondantModificationRecapitulatif.Text = string.Empty;
                // Perorant
                txtPerforantModificationRecapitulation.Text = string.Empty;
                // Ignée
                txtIgneeModificationRecapitulation.Text = string.Empty;
                // Aquatique
                txtAquatiqueModificationRecapitulatif.Text = string.Empty;
                // Céleste
                txtCelesteModificationRecapitulatif.Text = string.Empty;
                // Terrestre
                txtTerrestreModificationRecapitulatif.Text = string.Empty;
                // Poison
                txtPoisonModificationRecapitulatif.Text = string.Empty;
                // Paralysie
                txtParalysieModificationRecapitulatif.Text = string.Empty;
                // Malédictions
                txtMaledictionsModificationRecapitulatif.Text = string.Empty;
                // Saignement
                txtSaignementModificationRecapitulatif.Text = string.Empty;
                // Choc
                txtChocModificationRecapitulatif.Text = string.Empty;
                // Acide
                txtAcideModificationRecapitulatif.Text = string.Empty;
                // Maladies
                txtMaladiesModificationRecapitulatif.Text = string.Empty;
                // Chute
                txtChuteModificationRecapitulatif.Text = string.Empty;
                // Chaleur
                txtChaleurModificationRecapitulatif.Text = string.Empty;
                // Froid
                txtFroidModificationRecapitulatif.Text = string.Empty;
                // Initiative
                txtInitiativeModificationRecapitulatif.Text = string.Empty;
                // Vitesse
                txtVitesseModificationRecapitulatif.Text = string.Empty;
                // Pression
                txtPressionModificationRecapitulatif.Text = string.Empty;
                // Poids
                txtBxPoidsFinal.Text = string.Empty;
            }
            else if (activeCols.Count == 1)
            {
                // Tranchant
                txtTranchantModificationRecapitulatif.Text = tableauAverageMateriauEffect[1, activeCols[0]].ToString();
                // Contondant
                txtContondantModificationRecapitulatif.Text = tableauAverageMateriauEffect[2, activeCols[0]].ToString();
                // Perorant
                txtPerforantModificationRecapitulation.Text = tableauAverageMateriauEffect[3, activeCols[0]].ToString();
                // Ignée
                txtIgneeModificationRecapitulation.Text = tableauAverageMateriauEffect[4, activeCols[0]].ToString();
                // Aquatique
                txtAquatiqueModificationRecapitulatif.Text = tableauAverageMateriauEffect[5, activeCols[0]].ToString();
                // Céleste
                txtCelesteModificationRecapitulatif.Text = tableauAverageMateriauEffect[6, activeCols[0]].ToString();
                // Terrestre
                txtTerrestreModificationRecapitulatif.Text = tableauAverageMateriauEffect[7, activeCols[0]].ToString();
                // Poison
                txtPoisonModificationRecapitulatif.Text = tableauAverageMateriauEffect[8, activeCols[0]].ToString();
                // Paralysie
                txtParalysieModificationRecapitulatif.Text = tableauAverageMateriauEffect[9, activeCols[0]].ToString();
                // Malédictions
                txtMaledictionsModificationRecapitulatif.Text = tableauAverageMateriauEffect[10, activeCols[0]].ToString();
                // Saignement
                txtSaignementModificationRecapitulatif.Text = tableauAverageMateriauEffect[11, activeCols[0]].ToString();
                // Choc
                txtChocModificationRecapitulatif.Text = tableauAverageMateriauEffect[12, activeCols[0]].ToString();
                // Acide
                txtAcideModificationRecapitulatif.Text = tableauAverageMateriauEffect[13, activeCols[0]].ToString();
                // Maladies
                txtMaladiesModificationRecapitulatif.Text = tableauAverageMateriauEffect[14, activeCols[0]].ToString();
                // Chute
                txtChuteModificationRecapitulatif.Text = tableauAverageMateriauEffect[15, activeCols[0]].ToString();
                // Chaleur
                txtChaleurModificationRecapitulatif.Text = tableauAverageMateriauEffect[16, activeCols[0]].ToString();
                // Froid
                txtFroidModificationRecapitulatif.Text = tableauAverageMateriauEffect[17, activeCols[0]].ToString();
                // Initiative
                txtInitiativeModificationRecapitulatif.Text = tableauAverageMateriauEffect[18, activeCols[0]].ToString();
                // Vitesse
                txtVitesseModificationRecapitulatif.Text = tableauAverageMateriauEffect[19, activeCols[0]].ToString();
                // Pression
                txtPressionModificationRecapitulatif.Text = tableauAverageMateriauEffect[20, activeCols[0]].ToString();
                // Poids
                txtBxPoidsFinal.Text = tableauAverageMateriauEffect[21, activeCols[0]].ToString();
            }
            else if (activeCols.Count == 2)
            {
                // Tranchant
                txtTranchantModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[1, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[1, 1]),
                    null,
                    false).ToString();
                // Contondant
                txtContondantModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[2, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[2, 1]),
                    null,
                    false).ToString();
                // Perforant
                txtPerforantModificationRecapitulation.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[3, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[3, 1]),
                    null,
                    false).ToString();
                // Ignée
                txtIgneeModificationRecapitulation.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[4, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[4, 1]),
                    null,
                    false).ToString();
                // Aquatique
                txtAquatiqueModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[5, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[5, 1]),
                    null,
                    false).ToString();
                // Céleste
                txtCelesteModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[6, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[6, 1]),
                    null,
                    false).ToString();
                // Terrestre
                txtTerrestreModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[7, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[7, 1]),
                    null,
                    false).ToString();
                // Poison
                txtPoisonModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[8, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[8, 1]),
                    null,
                    false).ToString();
                // Paralysie
                txtParalysieModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[9, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[9, 1]),
                    null,
                    false).ToString();
                // Malédictions
                txtMaledictionsModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[10, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[10, 1]),
                    null,
                    false).ToString();
                // Saignements
                txtSaignementModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[11, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[11, 1]),
                    null,
                    false).ToString();
                // Choc
                txtChocModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[12, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[12, 1]),
                    null,
                    false).ToString();
                // Acide
                txtAcideModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[13, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[13, 1]),
                    null,
                    false).ToString();
                // Maladies
                txtMaladiesModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[14, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[14, 1]),
                    null,
                    false).ToString();
                // Chute
                txtChuteModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[15, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[15, 1]),
                    null,
                    false).ToString();
                // Chaleur
                txtChaleurModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[16, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[16, 1]),
                    null,
                    true).ToString();
                // Froid
                txtFroidModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[17, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[17, 1]),
                    null,
                    false).ToString();
                // Initiative
                txtInitiativeModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[18, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[18, 1]),
                    null,
                    true).ToString();
                // Vitesse
                txtVitesseModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[19, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[19, 1]),
                    null,
                    true).ToString();
                // Pression
                txtPressionModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[20, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[20, 1]),
                    null,
                    false).ToString();
                // Poids
                txtBxPoidsFinal.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToDecimal(tableauAverageMateriauEffect[21, 0]),
                    Convert.ToDecimal(tableauAverageMateriauEffect[21, 1]),
                    null,
                    true).ToString("0.##");
            }
            else if (activeCols.Count == 3)
            {
                // Tranchant
                txtTranchantModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[1, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[1, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[1, 2]),
                    false).ToString();
                // Contondant
                txtContondantModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[2, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[2, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[2, 2]),
                    false).ToString();
                // Perforant
                txtPerforantModificationRecapitulation.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[3, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[3, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[3, 2]),
                    false).ToString();
                // Ignée
                txtIgneeModificationRecapitulation.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[4, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[4, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[4, 2]),
                    false).ToString();
                // Aquatique
                txtAquatiqueModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[5, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[5, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[5, 2]),
                    false).ToString();
                // Céleste
                txtCelesteModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[6, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[6, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[6, 2]),
                    false).ToString();
                // Terrestre
                txtTerrestreModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[7, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[7, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[7, 2]),
                    false).ToString();
                // Poison
                txtPoisonModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[8, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[8, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[8, 2]),
                    false).ToString();
                // Paralysie
                txtParalysieModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[9, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[9, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[9, 2]),
                    false).ToString();
                // Malédictions
                txtMaledictionsModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[10, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[10, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[10, 2]),
                    false).ToString();
                // Saignements
                txtSaignementModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[11, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[11, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[11, 2]),
                    false).ToString();
                // Choc
                txtChocModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[12, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[12, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[12, 2]),
                    false).ToString();
                // Acide
                txtAcideModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[13, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[13, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[13, 2]),
                    false).ToString();
                // Maladies
                txtMaladiesModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[14, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[14, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[14, 2]),
                    false).ToString();
                // Chute
                txtChuteModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[15, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[15, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[15, 2]),
                    false).ToString();
                // Chaleur
                txtChaleurModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[16, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[16, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[16, 2]),
                    true).ToString();
                // Froid
                txtFroidModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[17, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[17, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[17, 2]),
                    false).ToString();
                // Initiative
                txtInitiativeModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[18, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[18, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[18, 2]),
                    true).ToString();
                // Vitesse
                txtVitesseModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[19, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[19, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[19, 2]),
                    true).ToString();
                // Pression
                txtPressionModificationRecapitulatif.Text = Utils.AverageEffectValueMaterials(
                    Convert.ToInt32(tableauAverageMateriauEffect[20, 0]),
                    Convert.ToInt32(tableauAverageMateriauEffect[20, 1]),
                    Convert.ToInt32(tableauAverageMateriauEffect[20, 2]),
                    false).ToString();
                // Poids
                txtBxPoidsFinal.Text = Utils.AverageEffectValueMaterials(
                   Convert.ToDecimal(tableauAverageMateriauEffect[21, 0]),
                   Convert.ToDecimal(tableauAverageMateriauEffect[21, 1]),
                   Convert.ToDecimal(tableauAverageMateriauEffect[21, 2]),
                   true).ToString("0.##");
            }
        }

        /// <summary>
        /// Vider toutes les TextBox de preview des matériaux
        /// </summary>
        private void CleanAllPreviewTextBox()
        {
            txtBxTranchant.Text = string.Empty;
            txtBxContondant.Text = string.Empty;
            txtBxPerforant.Text = string.Empty;
            txtBxIgnee.Text = string.Empty;
            txtBxAquatique.Text = string.Empty;
            txtBxCeleste.Text = string.Empty;
            txtBxTerrestre.Text = string.Empty;
            txtBxPoison.Text = string.Empty;
            txtBxParalysie.Text = string.Empty;
            txtBxMaledictions.Text = string.Empty;
            txtBxSaignement.Text = string.Empty;
            txtBxChoc.Text = string.Empty;
            txtBxAcide.Text = string.Empty;
            txtBxMaladies.Text = string.Empty;
            txtBxChute.Text = string.Empty;
            txtBxPression.Text = string.Empty;
            txtBxChaleur.Text = string.Empty;
            txtBxFroid.Text = string.Empty;
            txtBxBonusInitiative.Text = string.Empty;
            txtBxDeplacement.Text = string.Empty;
            txtBxValeur.Text = string.Empty;
            txtBxPoids.Text = string.Empty;
        }

        private void UpdateResistancesBonusArmorInformations()
        {
            bool bestValue = false; // savoir si la nouvelle valeur est meilleure que la suivante. False par défaut.

            /// 1) Ajouter dans le tableau les valeurs de résistance de l'armure par
            /// rapport au matériau coché.

            // PAS DE MATERIAU
            if (chkLstBxCompositionArmure.Items.Count == 0)
            {
                for (int i = 0; i < listTextBoxPreview.Length; i++)
                {
                    if (i == 21)
                        valuesResistancesBonusArmor[i - 1] = listTextBoxPreview[i];
                    if (i != 20 && i != 21)
                        valuesResistancesBonusArmor[i] = listTextBoxPreview[i];

                    /// 2) Comparer les valeurs du tableau si on ajoute le materiau sélectionné avec les valeurs des matériaux 
                    /// déjà présents dans la composition de l'armure. Et si jamais la nouvelle valeur est meilleure que celle
                    /// actuelle, l'indiquer via un changement de couleur.
                    /// 
                    UpdateUITextBoxesPreviewArmorValues(i, true); // La valeur sera toujours meilleure, parce qu'il n'y a pas de matériau.
                }
            }
            // UN MATERIAU
            else if (chkLstBxCompositionArmure.Items.Count == 1)
            {
                /// Je prends la longueur du tableau "listTextBoxPreview" en référence car elle fait le pont
                /// entre le tableau "valuesResistancesBonusArmor" et "tableauAverageMateriauEffect". C'est très
                /// important de le notifier, car les indices utilisés seront basés sur ceux de ce tableau.
                for (int i = 0; i < listTextBoxPreview.Length; i++)
                {
                    // Index où la valeur doit être supérieure.
                    bool indexCheck = i == 16 || i == 18 || i == 19;

                    /// Je vérifie que l'index correspond au poids en premier, vu que c'est la seule exception
                    /// avec une valeur décimale.
                    if (i == 21)
                    {
                        /// Dans le cas du poids, je fais un -1 pour ne pas être hors de l'index du
                        /// tableau "valuesResistancesBonusArmor" ; pour les tableaux "tableauAverageMateriauEffect"
                        /// et "listTextBoxPreview" inutile, car leur index est bon.
                        valuesResistancesBonusArmor[i - 1] = Utils.AverageEffectValueMaterials(
                           Convert.ToDecimal(tableauAverageMateriauEffect[i, 0]),
                           Convert.ToDecimal(listTextBoxPreview[i]),
                           null,
                           true).ToString("0.##");

                        decimal lastValue = Convert.ToDecimal(tableauAverageMateriauEffect[i, 0]);

                        /// Pour la même raison que plus haut, je décrémente "valuesResistancesBonusArmor"
                        /// afin d'éviter d'être hors index.
                        bestValue = Convert.ToDecimal(valuesResistancesBonusArmor[i - 1]) < lastValue;

                        /// 2) Comparer les valeurs du tableau si on ajoute le materiau sélectionné avec les valeurs des matériaux 
                        /// déjà présents dans la composition de l'armure. Et si jamais la nouvelle valeur est meilleure que celle
                        /// actuelle, l'indiquer via un changement de couleur.
                        /// 
                        UpdateUITextBoxesPreviewArmorValues(i, bestValue); // On décrémente de 1, sinon toutes les valeurs seront décalées.

                        continue; // Je rajoute cette condition, car nous arrivons à la fin du tableau. Inutile d'aller plus loin.
                    }
                    /// L'indice de la pression dans le tableau "tableauAverageMateriauEffect" correspond à l'indice 15
                    /// et il sert de marquage clair dans la synchronisation des données des différents tableaux.
                    if (i < 15)
                    {
                        valuesResistancesBonusArmor[i] = Utils.AverageEffectValueMaterials(
                            Convert.ToInt32(tableauAverageMateriauEffect[i + 1, 0]), /// J'incrémente la valeur de l'index, car la ligne 0 correspond à un string pur
                            Convert.ToInt32(listTextBoxPreview[i]),
                            null,
                            indexCheck).ToString();

                        int lastValue = Convert.ToInt32(tableauAverageMateriauEffect[i + 1, 0]); /// Incrémentation pour la même raison que plus haut

                        bestValue = Convert.ToInt32(valuesResistancesBonusArmor[i]) < lastValue;

                        /// 2) Comparer les valeurs du tableau si on ajoute le materiau sélectionné avec les valeurs des matériaux 
                        /// déjà présents dans la composition de l'armure. Et si jamais la nouvelle valeur est meilleure que celle
                        /// actuelle, l'indiquer via un changement de couleur.
                        /// 
                        UpdateUITextBoxesPreviewArmorValues(i, bestValue);
                    }
                    else if (i == 15) // Case "pression" dans "listTextBoxPreview"
                    {
                        valuesResistancesBonusArmor[i] = Utils.AverageEffectValueMaterials(
                            Convert.ToInt32(tableauAverageMateriauEffect[20, 0]), /// Dans le tableau "tableauAverageMateriauEffect" la ligne 20 correspond à la pression.
                            Convert.ToInt32(listTextBoxPreview[i]),
                            null,
                            indexCheck).ToString();

                        /// Encore une fois, je récupère la valeur de la pression à partir de la ligne 20
                        /// Puisque c'est là où elle réside.
                        int lastValue = Convert.ToInt32(tableauAverageMateriauEffect[20, 0]);

                        bestValue = Convert.ToInt32(valuesResistancesBonusArmor[i]) < lastValue;

                        /// 2) Comparer les valeurs du tableau si on ajoute le materiau sélectionné avec les valeurs des matériaux 
                        /// déjà présents dans la composition de l'armure. Et si jamais la nouvelle valeur est meilleure que celle
                        /// actuelle, l'indiquer via un changement de couleur.
                        /// 
                        UpdateUITextBoxesPreviewArmorValues(i, bestValue);
                    }
                    else
                    {
                        /// L'indice 20 correspond à la valeur dans le tableau "listTextBoxPreview", or, 
                        /// cette donnée là ne nous intéresse pas, donc elle saute.
                        if (i == 20)
                            continue;
                        else
                        {
                            /// Plus besoin d'incrémenter ou de décrémenter quoique soit, après l'indice de la pression
                            /// les indices des différents tableaux se synchronisent.
                            valuesResistancesBonusArmor[i] = Utils.AverageEffectValueMaterials(
                            Convert.ToInt32(tableauAverageMateriauEffect[i, 0]),
                            Convert.ToInt32(listTextBoxPreview[i]),
                            null,
                            indexCheck).ToString();

                            int lastValue = Convert.ToInt32(tableauAverageMateriauEffect[i, 0]);

                            bestValue = Convert.ToInt32(valuesResistancesBonusArmor[i]) < lastValue;

                            /// 2) Comparer les valeurs du tableau si on ajoute le materiau sélectionné avec les valeurs des matériaux 
                            /// déjà présents dans la composition de l'armure. Et si jamais la nouvelle valeur est meilleure que celle
                            /// actuelle, l'indiquer via un changement de couleur.
                            /// 
                            UpdateUITextBoxesPreviewArmorValues(i, bestValue);
                        }
                    }
                }
            }
            // DEUX MATERIAUX
            else if (chkLstBxCompositionArmure.Items.Count == 2)
            {
                /// Tout comme la boucle avec un seul matériau, j'incrémente pour éviter un bug 
                /// avec le nom du matériau qui est en dur dans le tableau "tableauAverageMateriauEffect"
                for (int i = 0; i < listTextBoxPreview.Length; i++)
                {
                    // Index où la valeur doit être supérieure. Même processus que plus haut.
                    bool indexCheck = i == 16 || i == 18 || i == 19;

                    /// Je vérifie que l'index correspond au poids en premier, vu que c'est la seule exception
                    /// avec une valeur décimale.
                    if (i == 21)
                    {
                        /// L'index 1 étant bon pour les tableaux "listTextBoxPreview" et "tableauAverageMateriauEffect"
                        /// je décrémente uniquement pour "valuesResistancesBonusArmor" afin d'éviter d'être en dehors
                        /// du range du tableau.
                        valuesResistancesBonusArmor[i - 1] = Utils.AverageEffectValueMaterials(
                           Convert.ToDecimal(tableauAverageMateriauEffect[i, 0]),
                           Convert.ToDecimal(tableauAverageMateriauEffect[i, 1]),
                           Convert.ToDecimal(listTextBoxPreview[i]),
                           true).ToString("0.##");

                        decimal lastValue = Utils.AverageEffectValueMaterials(
                           Convert.ToDecimal(tableauAverageMateriauEffect[i, 0]),
                           Convert.ToDecimal(listTextBoxPreview[i]),
                           null,
                           true);

                        bestValue = Convert.ToDecimal(valuesResistancesBonusArmor[i - 1]) < lastValue;

                        /// 2) Comparer les valeurs du tableau si on ajoute le materiau sélectionné avec les valeurs des matériaux 
                        /// déjà présents dans la composition de l'armure. Et si jamais la nouvelle valeur est meilleure que celle
                        /// actuelle, l'indiquer via un changement de couleur.
                        /// 
                        UpdateUITextBoxesPreviewArmorValues(i, bestValue);

                        continue; // Je rajoute cette condition, car nous arrivons à la fin du tableau. Inutile d'aller plus loin.
                    }
                    /// L'indice de la pression dans le tableau "tableauAverageMateriauEffect" correspond à l'indice 15
                    /// et il sert de marquage clair dans la synchronisation des données des différents tableaux.
                    if (i < 15)
                    {
                        valuesResistancesBonusArmor[i] = Utils.AverageEffectValueMaterials(
                            Convert.ToInt32(tableauAverageMateriauEffect[i + 1, 0]),
                            Convert.ToInt32(tableauAverageMateriauEffect[i + 1, 1]),
                            Convert.ToInt32(listTextBoxPreview[i]),
                            indexCheck).ToString();

                        int lastValue = Convert.ToInt32(tableauAverageMateriauEffect[i + 1, 0]); /// Incrémentation pour la même raison que plus haut

                        bestValue = Convert.ToInt32(valuesResistancesBonusArmor[i]) < lastValue;

                        /// 2) Comparer les valeurs du tableau si on ajoute le materiau sélectionné avec les valeurs des matériaux 
                        /// déjà présents dans la composition de l'armure. Et si jamais la nouvelle valeur est meilleure que celle
                        /// actuelle, l'indiquer via un changement de couleur.
                        /// 
                        UpdateUITextBoxesPreviewArmorValues(i, bestValue);
                    }
                    else if (i == 15) // Case "pression" dans "listTextBoxPreview"
                    {
                        valuesResistancesBonusArmor[i] = Utils.AverageEffectValueMaterials(
                            Convert.ToInt32(tableauAverageMateriauEffect[20, 0]), /// Dans le tableau "tableauAverageMateriauEffect" la ligne 20 correspond à la pression.
                            Convert.ToInt32(tableauAverageMateriauEffect[20, 1]), /// Dans le tableau "tableauAverageMateriauEffect" la ligne 20 correspond à la pression.
                            Convert.ToInt32(listTextBoxPreview[i]),
                            indexCheck).ToString();

                        /// Encore une fois, je récupère la valeur de la pression à partir de la ligne 20
                        /// Puisque c'est là où elle réside.
                        int lastValue = Convert.ToInt32(tableauAverageMateriauEffect[20, 0]);

                        bestValue = Convert.ToInt32(valuesResistancesBonusArmor[i]) < lastValue;

                        /// 2) Comparer les valeurs du tableau si on ajoute le materiau sélectionné avec les valeurs des matériaux 
                        /// déjà présents dans la composition de l'armure. Et si jamais la nouvelle valeur est meilleure que celle
                        /// actuelle, l'indiquer via un changement de couleur.
                        /// 
                        UpdateUITextBoxesPreviewArmorValues(i, bestValue);
                    }
                    else
                    {
                        /// L'indice 20 correspond à la valeur dans le tableau "listTextBoxPreview", or, 
                        /// cette donnée là ne nous intéresse pas, donc elle saute.
                        if (i == 20)
                            continue;
                        else
                        {
                            /// Plus besoin d'incrémenter ou de décrémenter quoique soit, après l'indice de la pression
                            /// les indices des différents tableaux se synchronisent.
                            valuesResistancesBonusArmor[i] = Utils.AverageEffectValueMaterials(
                            Convert.ToInt32(tableauAverageMateriauEffect[i, 0]),
                            Convert.ToInt32(tableauAverageMateriauEffect[i, 1]),
                            Convert.ToInt32(listTextBoxPreview[i]),
                            indexCheck).ToString();

                            int lastValue = Convert.ToInt32(tableauAverageMateriauEffect[i, 0]);

                            bestValue = Convert.ToInt32(valuesResistancesBonusArmor[i]) < lastValue;

                            /// 2) Comparer les valeurs du tableau si on ajoute le materiau sélectionné avec les valeurs des matériaux 
                            /// déjà présents dans la composition de l'armure. Et si jamais la nouvelle valeur est meilleure que celle
                            /// actuelle, l'indiquer via un changement de couleur.
                            /// 
                            UpdateUITextBoxesPreviewArmorValues(i, bestValue);
                        }
                    }
                }
            }

        }

        private void UpdateUITextBoxesPreviewArmorValues(int i, bool bestValue)
        {
            switch (i)
            {
                case 0:
                    txtTranchantModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtTranchantModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 1:
                    txtContondantModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtContondantModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 2:
                    txtPerforantModificationRecapitulation.Text = valuesResistancesBonusArmor[i];
                    txtPerforantModificationRecapitulation.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 3:
                    txtIgneeModificationRecapitulation.Text = valuesResistancesBonusArmor[i];
                    txtIgneeModificationRecapitulation.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 4:
                    txtAquatiqueModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtAquatiqueModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 5:
                    txtCelesteModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtCelesteModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 6:
                    txtTerrestreModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtTerrestreModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 7:
                    txtPoisonModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtPoisonModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 8:
                    txtParalysieModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtParalysieModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 9:
                    txtMaledictionsModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtMaledictionsModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 10:
                    txtSaignementModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtSaignementModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 11:
                    txtChocModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtChocModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 12:
                    txtAcideModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtAcideModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 13:
                    txtMaladiesModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtMaladiesModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 14:
                    txtChuteModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtChuteModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 15:
                    txtPressionModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtPressionModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 16:
                    txtChaleurModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtChaleurModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 17:
                    txtFroidModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtFroidModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 18:
                    txtInitiativeModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtInitiativeModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 19:
                    txtVitesseModificationRecapitulatif.Text = valuesResistancesBonusArmor[i];
                    txtVitesseModificationRecapitulatif.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                case 21:
                    txtBxPoidsFinal.Text = valuesResistancesBonusArmor[i - 1];
                    txtBxPoidsFinal.ForeColor = bestValue ? Color.Blue : Color.Red;
                    break;
                default:
                    Console.WriteLine("Index inconnu");
                    break;
            }
        }
    }
}
