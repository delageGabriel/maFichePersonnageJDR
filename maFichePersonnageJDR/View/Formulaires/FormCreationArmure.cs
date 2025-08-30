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
        public FrmCreationArmure()
        {
            InitializeComponent();
        }

        private void FrmCreationArmure_Load(object sender, EventArgs e)
        {
            cmbBxQualiteMateriau.SelectedIndex = 2; // Valeur par défaut de la ComboBox pour éviter d'éventuels bugs.
            GetAllMateriauxByCategorie();
        }

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
            int qualite = Convert.ToInt32(cmbBxQualiteMateriau.SelectedItem);
            ListBox nomMateriau = (ListBox)sender;

            GetMateriauxEffectsByNameAndQuality(qualite, nomMateriau.SelectedItem.ToString());
        }

        private void lstBxMetaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qualite = Convert.ToInt32(cmbBxQualiteMateriau.SelectedItem);
            ListBox nomMateriau = (ListBox)sender;

            GetMateriauxEffectsByNameAndQuality(qualite, nomMateriau.SelectedItem.ToString());
        }

        private void lstBxMinerais_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qualite = Convert.ToInt32(cmbBxQualiteMateriau.SelectedItem);
            ListBox nomMateriau = (ListBox)sender;

            GetMateriauxEffectsByNameAndQuality(qualite, nomMateriau.SelectedItem.ToString());
        }

        private void lstBxAnimaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qualite = Convert.ToInt32(cmbBxQualiteMateriau.SelectedItem);
            ListBox nomMateriau = (ListBox)sender;

            GetMateriauxEffectsByNameAndQuality(qualite, nomMateriau.SelectedItem.ToString());
        }

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
    }
}
