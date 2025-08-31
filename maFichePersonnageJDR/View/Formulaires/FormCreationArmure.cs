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

        public FrmCreationArmure()
        {
            InitializeComponent();
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
                    }

                    // 4 Assignation des valeurs de chacun des matériaux
                    if (chkLstBxCompositionArmure.Items.Count == 1)
                        valeurFirstMateriau = Convert.ToInt32(GetValueMateriauByNameAndQuality(qualite, nomMateriau));
                    else if (chkLstBxCompositionArmure.Items.Count == 2)
                        valeurSecondMateriau = Convert.ToInt32(GetValueMateriauByNameAndQuality(qualite, nomMateriau));
                    else if (chkLstBxCompositionArmure.Items.Count == 3)
                        valeurThirdMateriau = Convert.ToInt32(GetValueMateriauByNameAndQuality(qualite, nomMateriau));

                    // 5 Mise à jour du coût total de l'armure
                    UpdateCoutArmure();
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
            }

            if (chkLstBxCompositionArmure.CheckedItems.Count == 1)
            {

                int index = chkLstBxCompositionArmure.CheckedIndices[0];

                // 1 Retirer l'élément coché.
                string chkBx = chkLstBxCompositionArmure.CheckedItems[0].ToString();
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
                coutTotalArmure = Convert.ToInt32(coutTotalArmure * 1.2);
            else if (cmbBxTaille.SelectedIndex == 4)
                coutTotalArmure = Convert.ToInt32(coutTotalArmure * 1.8);
            else if (cmbBxTaille.SelectedIndex == 5)
                coutTotalArmure = Convert.ToInt32(coutTotalArmure * 3);

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
    }
}
