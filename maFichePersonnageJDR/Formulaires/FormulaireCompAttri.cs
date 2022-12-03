using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtBoxPV.Text = Properties.Settings.Default.PV;
            txtBoxEnrgie.Text = Properties.Settings.Default.Energie;
            txtPhysique.Text = Properties.Settings.Default.Physique;
            txtMental.Text = Properties.Settings.Default.Mental;
            txtSocial.Text = Properties.Settings.Default.Social;
            nudAdresse.Value = Properties.Settings.Default.Adresse;
            nudAgilite.Value = Properties.Settings.Default.Agilité;
            nudAnmale.Value = Properties.Settings.Default.Animale;
            nudArtisanat.Value = Properties.Settings.Default.Artisanat;
            nudBotanique.Value = Properties.Settings.Default.Botanique;
            nudConnGeographiques.Value = Properties.Settings.Default.ConnGeographiques;
            nudConnHistoriques.Value = Properties.Settings.Default.ConnHistoriques;
            nudMagiques.Value = Properties.Settings.Default.ConnMagiques;
            nudConnReligieuses.Value = Properties.Settings.Default.ConnReligieuses;
            nudCrochetage.Value = Properties.Settings.Default.Crochetage;
            nudDiplomatie.Value = Properties.Settings.Default.Diplomatie;
            nudDiscretion.Value = Properties.Settings.Default.Discretion;
            nudEndurance.Value = Properties.Settings.Default.Endurance;
            nudEscalade.Value = Properties.Settings.Default.Escalade;
            nudExplosifs.Value = Properties.Settings.Default.Explosifs;
            nudForce.Value = Properties.Settings.Default.Force;
            nudIntimidation.Value = Properties.Settings.Default.Intimidation;
            nudLangages.Value = Properties.Settings.Default.Langages;
            nudMecanique.Value = Properties.Settings.Default.Mecanique;
            nudMedecine.Value = Properties.Settings.Default.Medecine;
            nudNatation.Value = Properties.Settings.Default.Natation;
            nudPerception.Value = Properties.Settings.Default.Perception;
            nudPerspicacite.Value = Properties.Settings.Default.Perspicacité;
            nudPersuasion.Value = Properties.Settings.Default.Persuasion;
            nudPsyche.Value = Properties.Settings.Default.Psyche;
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
                    if(rchTbAttributs.Text.IndexOf(strTemp) == 0 && rchTbAttributs.Text.Contains(strTemp + ", "))
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
            Properties.Settings.Default.PV = txtBoxPV.Text;
            Properties.Settings.Default.Energie = txtBoxEnrgie.Text;
            Properties.Settings.Default.Physique = txtPhysique.Text;
            Properties.Settings.Default.Mental = txtMental.Text;
            Properties.Settings.Default.Social = txtSocial.Text;
            Properties.Settings.Default.Adresse = Convert.ToInt32(nudAdresse.Value);
            Properties.Settings.Default.Agilité = Convert.ToInt32(nudAgilite.Value);
            Properties.Settings.Default.Animale = Convert.ToInt32(nudAnmale.Value);
            Properties.Settings.Default.Artisanat = Convert.ToInt32(nudArtisanat.Value);
            Properties.Settings.Default.Botanique = Convert.ToInt32(nudBotanique.Value);
            Properties.Settings.Default.ConnGeographiques = Convert.ToInt32(nudConnGeographiques.Value);
            Properties.Settings.Default.ConnHistoriques = Convert.ToInt32(nudConnHistoriques.Value);
            Properties.Settings.Default.ConnMagiques = Convert.ToInt32(nudMagiques.Value);
            Properties.Settings.Default.ConnReligieuses = Convert.ToInt32(nudConnReligieuses.Value);
            Properties.Settings.Default.Crochetage = Convert.ToInt32(nudCrochetage.Value);
            Properties.Settings.Default.Diplomatie = Convert.ToInt32(nudDiplomatie.Value);
            Properties.Settings.Default.Discretion = Convert.ToInt32(nudDiscretion.Value);
            Properties.Settings.Default.Endurance = Convert.ToInt32(nudEndurance.Value);
            Properties.Settings.Default.Escalade = Convert.ToInt32(nudEscalade.Value);
            Properties.Settings.Default.Explosifs = Convert.ToInt32(nudExplosifs.Value);
            Properties.Settings.Default.Force = Convert.ToInt32(nudForce.Value);
            Properties.Settings.Default.Intimidation = Convert.ToInt32(nudIntimidation.Value);
            Properties.Settings.Default.Langages = Convert.ToInt32(nudLangages.Value);
            Properties.Settings.Default.Mecanique = Convert.ToInt32(nudMecanique.Value);
            Properties.Settings.Default.Medecine = Convert.ToInt32(nudMedecine.Value);
            Properties.Settings.Default.Natation = Convert.ToInt32(nudNatation.Value);
            Properties.Settings.Default.Perception = Convert.ToInt32(nudPerception.Value);
            Properties.Settings.Default.Perspicacité = Convert.ToInt32(nudPerspicacite.Value);
            Properties.Settings.Default.Persuasion = Convert.ToInt32(nudPersuasion.Value);
            Properties.Settings.Default.Psyche = Convert.ToInt32(nudPsyche.Value);
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
    }
}
