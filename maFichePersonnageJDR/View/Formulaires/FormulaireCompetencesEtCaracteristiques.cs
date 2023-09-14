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
using System.Data.SQLite;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireCompAttri : Form
    {
        private SQLiteConnection sqlLiteConnection = new SQLiteConnection(@"Data Source =BDD\20221227_base_fiche_perso.db; Version = 3;");

        private int x = Properties.Settings.Default.Niveau;

        private short[] tableauCaracteristiques = {
            135,
            135,
            140,
            140,
            140,
            145,
            155,
            155,
            160,
            165,
            170,
            170,
            180,
            180,
            180,
            185,
            185,
            190,
            190,
            195
        };
        public int X { get => x; set => x = value; }
        public short[] TableauCaracteristiques { get => tableauCaracteristiques; set => tableauCaracteristiques = value; }
        public SQLiteConnection SqlLiteConnection { get => sqlLiteConnection; set => sqlLiteConnection = value; }

        public FormulaireCompAttri()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Obtiens les paramètres utilisateurs
        /// </summary>
        public void GetSettings()
        {
            
        }

        public void GetAttributJoueurOuMJ()
        {
#if MJ
            chckLstAttributs.Items.Clear();
            chckLstAttributs.Items.AddRange(new[]   {
                "Alifère: capacité de voler à 3 mètres d'altitude",
                "Amphibien: capacité de nager à 6 mètres de profondeur, peut respirer sous l'eau et sur la terre",
                "Armure naturelle: peau épaisse, jusqu'à 10% de dégâts physiques absorbés par l'ennemi",
                "Arachnoïde : la créature peut grimper sur les surfaces",
                "Avantage du terrain: sur un terrain(s), la créature n'a pas de malus",
                "Bras fin : la créature a des petits bras et ne peut pas porter beaucoup de poids",
                "Canaliseur : la créature posséde un pourcentage supplémentaire de ses points d'énergie basé sur le total",
                "Célérité: attaque toujours en premier lors de tour d'initiative",
                "Corps artificiels: créature artificielle, nul besoin pour elle de respirer",
                "Dégagement: impossible d'être encerclé",
                "Frigifugé: capacité de survivre à basse température jusqu'à -50 degrés Celsius",
                "Gigantisme : la créature est tellement grande que l'adversaire a un bonus pour le toucher",
                "Gros dormeur: temps de récupération divisé par deux lors de repos",
                "Guerrier aguerri: l'adversaire a un malus pour toucher le détenteur de cet attribut",
                "Hyperesthésie: chance de ne pas être empoisonné égale à 15%",
                "Ignifugé: capacité de survivre à haute température jusqu'à 65 degrés Celsius",
                "Immortel : la créature ne peut pas mourir",
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
                "Maladie : La créature peut apporter des maladies",
                "Méditation : toutes les 4 heure(s), la créature régénère un point d'énergie supplémentaire",
                "Minus : l'adversaire a un malus pour toucher la créature",
                "Mithridatisation: chance de ne pas être empoisonné égale à 15%",
                "Mort-vivant: ne peut pas être soigné par des moyens conventionnels (sauf repos), est obligé de dévorer un corps ou boire des fluides corporels",
                "Multifrappe : la créature peut agir plusieurs fois en combat",
                "Paralysateur : la créature peut paralyser ses ennemis",
                "Peau enflammée : si la créature reçoit un coup physique, l'adversaire reçoit 1dX dégâts.",
                "Personnage non joueur : ne possède pas d'attributs",
                "Porteur de charges lourdes: capacité de porter 25% la charge maximum que l'on peut porter",
                "Régénération spirituelle: à chaque début de tour, 10% de l'énergie est régénérée par le lanceur",
                "Régénération vitale: à chaque début de tour, 10% de PV régénérés pour le lanceur",
                "Sac d'énergie : la créature posséde un pourcentage supplémentaire de ses points de vie basé sur le total",
                "Souffle: la créature est capable de cracher du feu ou n'importe quel autre élément (dégâts non magiques)",
                "Tour gratuit : la créature attaque quand elle veut (priorité sur les autres attributs de priorité)",
                "Vague de panique: fais trop peur, les adversaires doivent réussir un jet de Volonté tous les 1d4 tour(s) pour agir, mais peuvent toujours esquiver en cas d'échec",
                "Venimeux : La créature peut empoisonner ses ennemis",
                "Voie libre: capacité de déplacement doublée lorsque le terrain est dégagé."
            }) ;
#endif
#if JOUEUR
            chckLstAttributs.Items.Clear();
            chckLstAttributs.Items.AddRange(new[]
            {
                "Alifère: capacité de voler à 3 mètres d'altitude",
                "Amphibien: capacité de nager à 6 mètres de profondeur peut respirer sous l'eau et sur la terre",
                "Armure naturelle: peau épaisse jusqu'à 10 % de dégâts physiques absorbés",
                "Artiller : la créature est capable d'utiliser les armes de traits sans malus.",
                "Avantage du terrain: sur un terrain choisi par la créature, celle-ci n'a pas de malus liés aux conditions environnementales",
                "Coagulation : le sang de la créature lui permet d'arrêter le saignement au bout de 1d4 tour(s)",
                "Corps artificiels: créature artificielle, non organique",
                "Frigifugé: capacité de survivre à basse température jusqu'à -50 degrés Celsius",
                "Gros dormeur: temps de récupération divisé par deux lors de repos",
                "Hyperesthésie: chance de ne pas être paralysé égale à 15%",
                "Ignifugé: capacité de survivre à haute température jusqu'à 65 degrés Celsius",
                "Lourdaud: attaque forcément en dernier en combat",
                "Magie Aquatique — magie de l'eau",
                "Magie Céleste — magie des cieux",
                "Magie Démoniaque — magie liée aux ténèbres",
                "Magie Divine — magie liée aux divinités",
                "Magie Ignis — magie du feu",
                "Magie Naturelle — magie de la nature",
                "Magie Neutre — magie neutre",
                "Magie Terrestre — magie de la terre",
                "Méditation : toutes les 4 heure(s), la créature régénère un point d'énergie supplémentaire",
                "Mithridatisation: chance de ne pas être empoisonné égale à 15%",
                "Mort-vivant: ne peut pas être soigné par des moyens conventionnels (sauf repos) est obligé de dévorer un corps ou boire des fluides corporels",
                "Porteur de charges lourdes: capacité de porter 12% la charge maximum que l'on peut porter",
                "Résistance innée : La créature a une résistance innées au(x) type(s) de dégâts de son choix.",
                "Souffle: la créature est capable de cracher du feu ou n'importe quel autre élément (dégâts non magiques)",
                "Vision dans les grottes: la créature peut voir jusqu'à 9 m autour de lui dans les grottes",
                "Voie libre: capacité de déplacement doublée lorsque le terrain est dégagé.",
            });
#endif
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
            GetAttributJoueurOuMJ();
            txtPntsPVEnergie.Text = GetPointsPVEnergie(SqlLiteConnection, Properties.Settings.Default.Niveau).ToString();
            GetPointsCaracteristiques(SqlLiteConnection);
        }

        /// <summary>
        /// Sauvegarde les paramètres de l'utilisateur lorsque celui-ci clique sur le bouton Sauvegarder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Méthode qui passe l'état d'une checkbox checked à true si le contenu
        /// de cette dernière apparaît dans la richtextbox
        /// </summary>
        public void GetAttributCheckbox()
        {
            
        }

        private void btnViderRchTbAttributs_Click(object sender, EventArgs e)
        {
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

            foreach (object uneCompetence in grpbCompetences.Controls)
            {
                if (uneCompetence is NumericUpDown)
                {
                    NumericUpDown numComp = (NumericUpDown)uneCompetence;

                    if (numComp.Tag.ToString().Contains("Physique"))
                    {
                        valeurCommunePhysique += Convert.ToInt32(numComp.Value);
                    }
                }
            }

            valeurRepartitionPhysiqueRetournee = valeurTotaleRepartitionPhysique - valeurCommunePhysique;
            txtPntsPhysique.Text = valeurRepartitionPhysiqueRetournee.ToString();
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
            int maxPvValue = 0;
            int maxEnergieValue = 0;

            if (GetPointsPVEnergie(SqlLiteConnection, Properties.Settings.Default.Niveau) > Convert.ToInt32(nudEnergie.Value))
            {
                maxPvValue = GetPointsPVEnergie(SqlLiteConnection, Properties.Settings.Default.Niveau) - Convert.ToInt32(nudEnergie.Value);
            }
            else if (GetPointsPVEnergie(SqlLiteConnection, Properties.Settings.Default.Niveau) > Convert.ToInt32(nudEnergie.Value))
            {
                maxPvValue = Convert.ToInt32(nudEnergie.Value) - GetPointsPVEnergie(SqlLiteConnection, Properties.Settings.Default.Niveau);
            }
            else if (int.Parse(txtPntsPVEnergie.Text) == Convert.ToInt32(nudEnergie.Value))
            {
                maxPvValue = int.Parse(txtPntsPVEnergie.Text);
            }

            if (GetPointsPVEnergie(SqlLiteConnection, Properties.Settings.Default.Niveau) > Convert.ToInt32(nudPV.Value))
            {
                maxEnergieValue = GetPointsPVEnergie(SqlLiteConnection, Properties.Settings.Default.Niveau) - Convert.ToInt32(nudPV.Value);
            }
            else if (GetPointsPVEnergie(SqlLiteConnection, Properties.Settings.Default.Niveau) > Convert.ToInt32(nudPV.Value))
            {
                maxEnergieValue = Convert.ToInt32(nudPV.Value) - GetPointsPVEnergie(SqlLiteConnection, Properties.Settings.Default.Niveau);
            }
            else if (int.Parse(txtPntsPVEnergie.Text) == Convert.ToInt32(nudPV.Value))
            {
                maxEnergieValue = int.Parse(txtPntsPVEnergie.Text);
            }

            int pointsRestants = GetPointsPVEnergie(SqlLiteConnection, Properties.Settings.Default.Niveau) - Convert.ToInt32(nudPV.Value + nudEnergie.Value);

            nudEnergie.Maximum = maxEnergieValue;
            nudPV.Maximum = maxPvValue;
            txtPntsPVEnergie.Text = pointsRestants.ToString();
        }

        /// <summary>
        /// Calcule la répartition des points entre les trois caractéristiques
        /// Impose une limite entre les trois numericUpDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownValeurChangeCaracteristiques_ValueChanged(object sender, EventArgs e)
        {
            int valeurRepartitionTotale = TableauCaracteristiques[X - 1];

            int valeurPhysique = Convert.ToInt32(nudPhysique.Value);
            int valeurMental = Convert.ToInt32(nudMental.Value);
            int valeurSocial = Convert.ToInt32(nudSocial.Value);
            int valeurCommune = 0;
            int valeurRepartitionRetournee = 0;

            NumericUpDown numericUpDown = (NumericUpDown)sender;
            if (numericUpDown.Tag.ToString().Contains("Physique"))
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
            if (txtPntsCaracteristiques.Text == "0")
            {
                nudPhysique.Maximum = Convert.ToInt32(nudPhysique.Value);
                nudMental.Maximum = Convert.ToInt32(nudMental.Value);
                nudSocial.Maximum = Convert.ToInt32(nudSocial.Value);
            }
            else
            {
                if (X >= 1 && X <= 4)
                {
                    nudPhysique.Maximum = 55;
                    nudMental.Maximum = 55;
                    nudSocial.Maximum = 55;
                }
                else if (X >= 5 && X <= 9)
                {
                    nudPhysique.Maximum = 65;
                    nudMental.Maximum = 65;
                    nudSocial.Maximum = 65;
                }
                else if (X >= 10 && X <= 14)
                {
                    nudPhysique.Maximum = 70;
                    nudMental.Maximum = 70;
                    nudSocial.Maximum = 70;
                }
                else if (X >= 15 && X <= 20)
                {
                    nudPhysique.Maximum = 75;
                    nudMental.Maximum = 75;
                    nudSocial.Maximum = 75;
                }
            }
        }

        private void rchTbAttributs_TextChanged(object sender, EventArgs e)
        {

#if JOUEUR
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
#endif
        }

        private void chckAttribut_click(object sender, EventArgs e)
        {

        }

        private void btnReinitialiserCompetences_Click(object sender, EventArgs e)
        {
            foreach (Control competencesControls in grpbCompetences.Controls)
            {
                NumericUpDown numericUpDown = new NumericUpDown();

                if (competencesControls is NumericUpDown)
                {
                    numericUpDown = (NumericUpDown)competencesControls;
                    Console.WriteLine(numericUpDown.TabIndex);
                    numericUpDown.Value = 0;
                }
            }
        }

        public int GetPointsPVEnergie(SQLiteConnection connexion, int niveauPersonnage)
        {
            // Commande
            SQLiteCommand command;
            // Reader
            SQLiteDataReader reader;
            object idReader = 12;

            connexion.Open();
            command = connexion.CreateCommand();
            command.CommandText = $"SELECT nb_pv_point_personnage FROM POINTS_VIE_ENERGIE WHERE niveau_personnage = {niveauPersonnage}";
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                idReader = reader.GetValue(0);
            }
            connexion.Close();
            return Convert.ToInt32(idReader);
        }

        public void GetPointsCaracteristiques(SQLiteConnection connection)
        {
            SQLiteCommand command;

            SQLiteDataReader reader;

            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = $"SELECT nb_points_caracteristiques FROM POINTS_CARACTERISTIQUES WHERE niveau_personnage = {Properties.Settings.Default.Niveau}";
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                object idReader = reader.GetValue(0);

                txtPntsCaracteristiques.Text += idReader.ToString();
            }

            connection.Close();
        }
    }
}
