using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maFichePersonnageJDR.Classe;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireCompAttri : Form
    {
        private int x = Convert.ToInt16(Properties.Settings.Default.Niveau);
        public static Control.ControlCollection formStateCompAttri;
        public int X { get => x; set => x = value; }

        public FormulaireCompAttri()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Obtiens les paramètres utilisateurs
        /// </summary>
        public void GetSettings()
        {
            rchTbAttributs.Text = Properties.Settings.Default.Attributs;
            nudPV.Value = Properties.Settings.Default.PV;
            nudEnergie.Value = Properties.Settings.Default.Energie;
            nudPhysique.Value = Properties.Settings.Default.Physique;
            nudMental.Value = Properties.Settings.Default.Mental;
            nudSocial.Value = Properties.Settings.Default.Social;
            nudDexterite.Value = Properties.Settings.Default.Dexterite;
            nudAgilite.Value = Properties.Settings.Default.Agilité;
            nudDressage.Value = Properties.Settings.Default.Dressage;
            nudArtisanat.Value = Properties.Settings.Default.Artisanat;
            nudConnNatures.Value = Properties.Settings.Default.ConnNature;
            nudCharme.Value = Properties.Settings.Default.Charme;
            nudConnGeographiques.Value = Properties.Settings.Default.ConnGeographiques;
            nudConnHistoriques.Value = Properties.Settings.Default.ConnHistoriques;
            nudMagiques.Value = Properties.Settings.Default.ConnMagiques;
            nudConnReligieuses.Value = Properties.Settings.Default.ConnReligieuses;
            nudCrochetage.Value = Properties.Settings.Default.Crochetage;
            nudDiplomatie.Value = Properties.Settings.Default.Diplomatie;
            nudDiscretion.Value = Properties.Settings.Default.Discretion;
            nudEscalade.Value = Properties.Settings.Default.Escalade;
            nudEscamotage.Value = Properties.Settings.Default.Escamotage;
            nudExplosifs.Value = Properties.Settings.Default.Explosifs;
            nudForce.Value = Properties.Settings.Default.Force;
            nudIntimidation.Value = Properties.Settings.Default.Intimidation;
            nudDecryptage.Value = Properties.Settings.Default.Decryptage;
            nudMarchandage.Value = Properties.Settings.Default.Marchandage;
            nudMecanique.Value = Properties.Settings.Default.Mecanique;
            nudMedecine.Value = Properties.Settings.Default.Medecine;
            nudMemoire.Value = Properties.Settings.Default.Memoire;
            nudNatation.Value = Properties.Settings.Default.Natation;
            nudPerception.Value = Properties.Settings.Default.Perception;
            nudPerspicacite.Value = Properties.Settings.Default.Perspicacité;
            nudPrestance.Value = Properties.Settings.Default.Prestance;
            nudProvocation.Value = Properties.Settings.Default.Provocation;
            nudEsprit.Value = Properties.Settings.Default.Esprit;
            nudReflexes.Value = Properties.Settings.Default.Reflexes;
            nudVigueur.Value = Properties.Settings.Default.Vigueur;
            nudVolonte.Value = Properties.Settings.Default.Volonte;
        }
        /// <summary>
        /// Rempli la richtextbox en fonction des attributs cochés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetAttribut(object sender, ItemCheckEventArgs e)
        {
            string strTemp;
            if (chckLstAttributs.SelectedItem != null)
            {
                strTemp = (string)chckLstAttributs.SelectedItem;
                if (rchTbAttributs.Text.Contains(strTemp))
                {
                    if (rchTbAttributs.Text.IndexOf(strTemp) == 0 && rchTbAttributs.Text.Contains(strTemp + ", "))
                    {
                        strTemp = (string)chckLstAttributs.SelectedItem + ", ";
                        rchTbAttributs.Text = rchTbAttributs.Text.Remove(rchTbAttributs.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbAttributs.Text.Contains(", " + strTemp))
                    {
                        strTemp = ", " + (string)chckLstAttributs.SelectedItem;
                        rchTbAttributs.Text = rchTbAttributs.Text.Remove(rchTbAttributs.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbAttributs.Text = rchTbAttributs.Text.Remove(rchTbAttributs.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(rchTbAttributs.Text))
                    {
                        rchTbAttributs.Text += ", ";
                    }
                    rchTbAttributs.Text += chckLstAttributs.SelectedItem;
                }

            }
        }

        /// <summary>
        /// Génère le contenu du formulaire en appelant les deux méthodes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormulaireCompAttri_Load(object sender, EventArgs e)
        {
            GetSettings();
            GetAttributCheckbox();
        }

        /// <summary>
        /// Sauvegarde les paramètres de l'utilisateur lorsque celui-ci clique sur le bouton Sauvegarder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Attributs = rchTbAttributs.Text;
            Properties.Settings.Default.PV = Convert.ToInt32(nudPV.Value);
            Properties.Settings.Default.Energie = Convert.ToInt32(nudEnergie.Value);
            Properties.Settings.Default.Physique = Convert.ToInt32(nudPhysique.Value);
            Properties.Settings.Default.Mental = Convert.ToInt32(nudMental.Value);
            Properties.Settings.Default.Social = Convert.ToInt32(nudSocial.Value);
            Properties.Settings.Default.Dexterite = Convert.ToInt32(nudDexterite.Value);
            Properties.Settings.Default.Agilité = Convert.ToInt32(nudAgilite.Value);
            Properties.Settings.Default.Dressage = Convert.ToInt32(nudDressage.Value);
            Properties.Settings.Default.Artisanat = Convert.ToInt32(nudArtisanat.Value);
            Properties.Settings.Default.ConnNature = Convert.ToInt32(nudConnNatures.Value);
            Properties.Settings.Default.Charme = Convert.ToInt32(nudCharme.Value);
            Properties.Settings.Default.ConnGeographiques = Convert.ToInt32(nudConnGeographiques.Value);
            Properties.Settings.Default.ConnHistoriques = Convert.ToInt32(nudConnHistoriques.Value);
            Properties.Settings.Default.ConnMagiques = Convert.ToInt32(nudMagiques.Value);
            Properties.Settings.Default.ConnReligieuses = Convert.ToInt32(nudConnReligieuses.Value);
            Properties.Settings.Default.Crochetage = Convert.ToInt32(nudCrochetage.Value);
            Properties.Settings.Default.Diplomatie = Convert.ToInt32(nudDiplomatie.Value);
            Properties.Settings.Default.Discretion = Convert.ToInt32(nudDiscretion.Value);
            Properties.Settings.Default.Escalade = Convert.ToInt32(nudEscalade.Value);
            Properties.Settings.Default.Escamotage = Convert.ToInt32(nudEscamotage.Value);
            Properties.Settings.Default.Explosifs = Convert.ToInt32(nudExplosifs.Value);
            Properties.Settings.Default.Force = Convert.ToInt32(nudForce.Value);
            Properties.Settings.Default.Intimidation = Convert.ToInt32(nudIntimidation.Value);
            Properties.Settings.Default.Decryptage = Convert.ToInt32(nudDecryptage.Value);
            Properties.Settings.Default.Marchandage = Convert.ToInt32(nudMarchandage.Value);
            Properties.Settings.Default.Mecanique = Convert.ToInt32(nudMecanique.Value);
            Properties.Settings.Default.Medecine = Convert.ToInt32(nudMedecine.Value);
            Properties.Settings.Default.Memoire = Convert.ToInt32(nudMemoire.Value);
            Properties.Settings.Default.Natation = Convert.ToInt32(nudNatation.Value);
            Properties.Settings.Default.Perception = Convert.ToInt32(nudPerception.Value);
            Properties.Settings.Default.Perspicacité = Convert.ToInt32(nudPerspicacite.Value);
            Properties.Settings.Default.Prestance = Convert.ToInt32(nudPrestance.Value);
            Properties.Settings.Default.Provocation = Convert.ToInt32(nudProvocation.Value);
            Properties.Settings.Default.Esprit = Convert.ToInt32(nudEsprit.Value);
            Properties.Settings.Default.Reflexes = Convert.ToInt32(nudReflexes.Value);
            Properties.Settings.Default.Vigueur = Convert.ToInt32(nudVigueur.Value);
            Properties.Settings.Default.Volonte = Convert.ToInt32(nudVolonte.Value);
            Properties.Settings.Default.Save();
            MessageBox.Show("Formulaire sauvegardé !");
        }

        /// <summary>
        /// Méthode qui passe l'état d'une checkbox checked à true si le contenu
        /// de cette dernière apparaît dans la richtextbox
        /// </summary>
        public void GetAttributCheckbox()
        {
            List<int> tableau = new List<int>();
            foreach (string checkItems in chckLstAttributs.Items)
            {
                if (rchTbAttributs.Text.Contains(checkItems))
                {
                    tableau.Add(chckLstAttributs.Items.IndexOf(checkItems));
                }
            }
            foreach (int index in tableau)
            {
                chckLstAttributs.SetItemChecked(index, true);
            }
        }

        private void btnViderRchTbAttributs_Click(object sender, EventArgs e)
        {
            List<int> tableauIndex = new List<int>();
            foreach (string chkItems in chckLstAttributs.Items)
            {
                tableauIndex.Add(chckLstAttributs.Items.IndexOf(chkItems));
            }
            foreach (int index in tableauIndex)
            {
                chckLstAttributs.SetItemChecked(index, false);
            }
            rchTbAttributs.Text = rchTbAttributs.Text.Remove(0, rchTbAttributs.TextLength);
        }

        /// <summary>
        /// Calcul les points à répartir dans les différentes cases
        /// Fais la différence avec les points ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownValeurChangeCompetencesPhysique_ValueChanged(object sender, EventArgs e)
        {
            int valeurTotaleRepartitionPhysique = GlobalesVariable.PtsPhysiqueMax;
            int valeurCommunePhysique = 0;
            int valeurRepartitionPhysiqueRetournee = 0;

            NumericUpDown numericUp = (NumericUpDown)sender;
            /// Cas Physique
            if(numericUp.Tag.ToString().Contains("Physique"))
            {
                foreach(object uneCompetence in grpbCompetences.Controls)
                {
                    if(uneCompetence is NumericUpDown)
                    {
                        NumericUpDown numComp = (NumericUpDown)uneCompetence;
                        if(numComp.Tag.ToString().Contains("Physique"))
                        {
                            valeurCommunePhysique += Convert.ToInt32(numComp.Value);
                        }
                    }
                }
                valeurRepartitionPhysiqueRetournee = valeurTotaleRepartitionPhysique - valeurCommunePhysique;
                txtPntsPhysique.Text = valeurRepartitionPhysiqueRetournee.ToString();
            }
            /// Cas Physique
            if (txtPntsPhysique.Text == "0")
            {
                foreach (object uneCompetence in grpbCompetences.Controls)
                {
                    if (uneCompetence is NumericUpDown)
                    {
                        NumericUpDown numComp = (NumericUpDown)uneCompetence;
                        /// Cas Physique
                        if (numComp.Tag.ToString().Contains("Physique") && 
                            !numComp.Tag.ToString().Contains("Mental") &&
                            !numComp.Tag.ToString().Contains("Social"))
                        {
                            numComp.Maximum = Convert.ToInt32(numComp.Value);
                        }
                    }
                }
            }
            else
            {
                foreach (object uneCompetence in grpbCompetences.Controls)
                {
                    if (uneCompetence is NumericUpDown)
                    {
                        NumericUpDown numComp = (NumericUpDown)uneCompetence;
                        numComp.Maximum = 15;
                    }
                }
            }
        }

        /// <summary>
        /// Calcul les points à répartir dans les différentes cases
        /// Fais la différence avec les points ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownValeurChangeCompetencesMental_ValueChanged(object sender, EventArgs e)
        {
            int valeurTotaleRepartitionMental = GlobalesVariable.PtsMentalMax;
            int valeurCommuneMental = 0;
            int valeurRepartitionMentalRetournee = 0;
            NumericUpDown numericUp = (NumericUpDown)sender;

            /// Cas Mental
            if (numericUp.Tag.ToString().Contains("Mental"))
            {
                foreach (object uneCompetence in grpbCompetences.Controls)
                {
                    if (uneCompetence is NumericUpDown)
                    {
                        NumericUpDown numComp = (NumericUpDown)uneCompetence;
                        if (numComp.Tag.ToString().Contains("Mental"))
                        {
                            valeurCommuneMental += Convert.ToInt32(numComp.Value);
                        }
                    }
                }
                valeurRepartitionMentalRetournee = valeurTotaleRepartitionMental - valeurCommuneMental;
                txtPntsMental.Text = valeurRepartitionMentalRetournee.ToString();
            }
            /// Cas Mental
            if (txtPntsMental.Text == "0")
            {
                foreach (object uneCompetence in grpbCompetences.Controls)
                {
                    if (uneCompetence is NumericUpDown)
                    {
                        NumericUpDown numComp = (NumericUpDown)uneCompetence;
                        if (!numComp.Tag.ToString().Contains("Physique") &&
                             numComp.Tag.ToString().Contains("Mental") &&
                            !numComp.Tag.ToString().Contains("Social"))
                        {
                            numComp.Maximum = Convert.ToInt32(numComp.Value);
                        }
                    }
                }
            }
            else
            {
                foreach (object uneCompetence in grpbCompetences.Controls)
                {
                    if (uneCompetence is NumericUpDown)
                    {
                        NumericUpDown numComp = (NumericUpDown)uneCompetence;
                        numComp.Maximum = 15;
                    }
                }
            }
        }
        /// <summary>
        /// Calcul les points à répartir dans les différentes cases
        /// Fais la différence avec les points ajouter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownValeurChangeCompetencesSocial_ValueChanged(object sender, EventArgs e)
        {
            int valeurTotaleRepartitionSocial = GlobalesVariable.PtsSocialMax;
            int valeurCommuneSocial = 0;
            int valeurRepartitionSocialRetournee = 0;

            NumericUpDown numericUp = (NumericUpDown)sender;
            
            /// Cas Social
            if (numericUp.Tag.ToString().Contains("Social"))
            {
                foreach (object uneCompetence in grpbCompetences.Controls)
                {
                    if (uneCompetence is NumericUpDown)
                    {
                        NumericUpDown numComp = (NumericUpDown)uneCompetence;
                        if (numComp.Tag.ToString().Contains("Social"))
                        {
                            valeurCommuneSocial += Convert.ToInt32(numComp.Value);
                        }
                    }
                }
                valeurRepartitionSocialRetournee = valeurTotaleRepartitionSocial - valeurCommuneSocial;
                txtPntsSocial.Text = valeurRepartitionSocialRetournee.ToString();
            }
            if (txtPntsSocial.Text == "0")
            {
                foreach (object uneCompetence in grpbCompetences.Controls)
                {
                    if (uneCompetence is NumericUpDown)
                    {
                        NumericUpDown numComp = (NumericUpDown)uneCompetence;
                        /// Cas Social
                        if (!numComp.Tag.ToString().Contains("Physique") &&
                            !numComp.Tag.ToString().Contains("Mental") &&
                             numComp.Tag.ToString().Contains("Social"))
                        {
                            numComp.Maximum = Convert.ToInt32(numComp.Value);
                        }
                    }
                }
            }
            else
            {
                foreach (object uneCompetence in grpbCompetences.Controls)
                {
                    if (uneCompetence is NumericUpDown)
                    {
                        NumericUpDown numComp = (NumericUpDown)uneCompetence;
                        numComp.Maximum = 15;
                    }
                }
            }
        }
        /// <summary>
        /// Calcule la répartition des points entre les PV et l'énergie
        /// Impose une limite entre les deux numericUpDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownValeurChangePVEnergie_ValueChanged(object sender, EventArgs e)
        {

            int valeurRepartitionBox = 12;
            int valeurPV = Convert.ToInt32(nudPV.Value);
            int valeurEnergie = Convert.ToInt32(nudEnergie.Value);
            int valeurCommune = 0;
            int valeurRepartitionRetournee = 0;

            NumericUpDown numericUpDown = (NumericUpDown)sender;

            if (numericUpDown.Tag.ToString().Contains("PV"))
            {
                nudEnergie.Maximum = valeurRepartitionBox - valeurPV;

                valeurCommune = valeurPV + valeurEnergie;

                valeurRepartitionRetournee = valeurRepartitionBox - valeurCommune;
                txtPntsPVEnergie.Text = valeurRepartitionRetournee.ToString();

            }
            if (numericUpDown.Tag.ToString().Contains("Energie"))
            {
                nudPV.Maximum = valeurRepartitionBox - valeurEnergie;

                valeurCommune = valeurPV + valeurEnergie;

                valeurRepartitionRetournee = valeurRepartitionBox - valeurCommune;
                txtPntsPVEnergie.Text = valeurRepartitionRetournee.ToString();

            }
        }

        /// <summary>
        /// Calcule la répartition des points entre les trois caractéristiques
        /// Impose une limite entre les trois numericUpDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownValeurChangeCaracteristiques_ValueChanged(object sender, EventArgs e)
        {
            int valeurRepartitionTotale = 135;
            int valeurPhysique = Convert.ToInt32(nudPhysique.Value);
            int valeurMental = Convert.ToInt32(nudMental.Value);
            int valeurSocial = Convert.ToInt32(nudSocial.Value);
            int valeurCommune = 0;
            int valeurRepartitionRetournee = 0;

            NumericUpDown numericUpDown = (NumericUpDown)sender;
            if(numericUpDown.Tag.ToString().Contains("Physique"))
            {
                valeurCommune = valeurPhysique + valeurMental + valeurSocial;
                valeurRepartitionRetournee = valeurRepartitionTotale - valeurCommune;
                nudDexterite.Value = (nudPhysique.Value + nudMental.Value) / 10;
                txtPntsCaracteristiques.Text = valeurRepartitionRetournee.ToString();
            }
            if (numericUpDown.Tag.ToString().Contains("Mental"))
            {
                valeurCommune = valeurPhysique + valeurMental + valeurSocial;
                valeurRepartitionRetournee = valeurRepartitionTotale - valeurCommune;
                nudDexterite.Value = (nudPhysique.Value + nudMental.Value) / 10;
                txtPntsCaracteristiques.Text = valeurRepartitionRetournee.ToString();
            }
            if (numericUpDown.Tag.ToString().Contains("Social"))
            {
                valeurCommune = valeurPhysique + valeurMental + valeurSocial;
                valeurRepartitionRetournee = valeurRepartitionTotale - valeurCommune;

                txtPntsCaracteristiques.Text = valeurRepartitionRetournee.ToString();
            }
            if(txtPntsCaracteristiques.Text == "0")
            {
                nudPhysique.Maximum = Convert.ToInt32(nudPhysique.Value);
                nudMental.Maximum = Convert.ToInt32(nudMental.Value);
                nudSocial.Maximum = Convert.ToInt32(nudSocial.Value);
            }
            else
            {
                nudPhysique.Maximum = 55;
                nudMental.Maximum = 55;
                nudSocial.Maximum = 55;
            }
        }

        private void rchTbAttributs_TextChanged(object sender, EventArgs e)
        {

            string[] subs = rchTbAttributs.Text.Split(',');

            if (Properties.Settings.Default.Niveau == 1)
            {
                if (subs.Count() > 1)
                {
                    chckLstAttributs.Enabled = false;

                }
                else
                {
                    chckLstAttributs.Enabled = true;
                }
            }
        }

        private void chckAttribut_click(object sender, EventArgs e)
        {

        }
    }
}
