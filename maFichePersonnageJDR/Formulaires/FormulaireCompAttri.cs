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
        /// Établi une liste de checkbox
        /// </summary>
        public void SetAttributs()
        {
            chckLstAttributs.Items.AddRange(new[] {$"Alifère: capacité de voler à {X} mètres d'altitude",
                    $"Amphibien: capacité de nager à {X} mètres de profondeur, peut respirer sous l'eau et sur la terre",
                    "Armure naturelle: peau épaisse, jusqu'à x% de dégâts physiques absorbés",
                    $"Avantage du terrain: sur {X} terrain(s) en particulier, la créature n'a pas de malus",
                    "Célérité: attaque toujours en premier lors de tour d'initiative",
                    "Corps artificiels: créature artificielle, nul besoin pour elle de respirer",
                    "Dégagement: impossible d'être encerclé", "Double frappe: capacité d'attaquer deux fois par tour de jeu",
                    "Fin limier: plafond supplémentaire de 5% dans une des compétences techniques",
                    "Frigifugé: capacité de survivre à basse température jusqu'à x degrés Celsius",
                    "Gros dormeur: temps de récupération divisé par deux lors de repos",
                    "Hyperesthésie: chance de ne pas être empoisonné égale à x%",
                    "Ignifugé: capacité de survivre à haute température jusqu'à x degrés Celsius",
                    "Insensibilité contondante: Insensible aux dégâts contondants",
                    "Insensibilité perforante: Insensible aux dégâts perforants",
                    "Insensibilité tranchante: Insensible aux dégâts tranchants",
                    "Insubmersible: impossible d'être submergé",
                    "Lourdaud: trop lourd pour attaquer en premier, attaque en dernier",
                    "Magie Aquatique — magie de l'eau",
                    "Magie Céleste — magie du ciel",
                    "Magie Démoniaque — magie liée aux ténèbres",
                    "Magie Divine — magie liée aux divinités",
                    "Magie Ignis — magie du feu",
                    "Magie Naturelle — magie de la nature",
                    "Magie Neutre — magie neutre",
                    "Magie Terrestre: magie de la terre",
                    "Mithridatisation: chance de ne pas être empoisonné égale à x%",
                    "Mort-vivant: ne peut pas être soigné par des moyens conventionnels (sauf repos), est obligé de dévorer un corps ou boire des fluides corporels",
                    "Porteur de charges lourdes: capacité de porter 20% la charge maximum que l'on peut porter",
                    "Prodige: plafond supplémentaire de 5% dans une des compétences naturelles",
                    "Régénération spirituelle: à chaque début de tour, 10% de l'énergie est régénérée par le lanceur",
                    "Régénération vitale: à chaque début de tour, 10% de PV régénérés pour le lanceur",
                    "Soif de bataille: plafond supplémentaire de 5% dans une des compétences de combat",
                    "Souffle: la créature est capable de cracher du feu ou n'importe quel autre élément (dégâts non magiques)",
                    "Vague de panique: fais trop peur, les adversaires doivent réussir un jet de Volonté tous les x tour(s) pour agir, mais peuvent toujours esquiver en cas d'échec",
                    "Voie libre: capacité de déplacement doublée lorsque le terrain est dégagé."
                }); ;
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
            SetAttributs();
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

        private void nudEndurance_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
