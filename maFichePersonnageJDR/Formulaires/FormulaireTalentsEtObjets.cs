using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maFichePersonnageJDR.Formulaires;
using maFichePersonnageJDR.Classes;
using System.Configuration;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireTalentsEtObjets : Form
    {
        private int htrControlInventaire = 1;
        private int htrControlTalent = 1;

        private List<Armes> lArmes = new List<Armes>();
        public int HtrControlInventaire { get => htrControlInventaire; set => htrControlInventaire = value; }
        public int HtrControlTalent { get => htrControlTalent; set => htrControlTalent = value; }
        internal List<Armes> LArmes { get => lArmes; set => lArmes = value; }

        public FormulaireTalentsEtObjets()
        {
            InitializeComponent();
        }

        private void FormulaireTalentsEtObjets_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Attributs.Contains("Magie Aquatique — magie de l'eau"))
            {
                cbbSortileges.Items.AddRange(new[] { "Manipulation des éléments aquatiques" });
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Ignis — magie du feu"))
            {
                cbbSortileges.Items.AddRange(new[] { "Manipulation des flammes" });
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Céleste: magie du ciel"))
            {
                cbbSortileges.Items.AddRange(new[] { "Manipulation des éléments célestes" });
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Terrestre: magie de la terre"))
            {
                cbbSortileges.Items.AddRange(new[] { "Manipulation des éléments terrestres" });
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Naturelle — magie de la nature"))
            {
                cbbSortileges.Items.AddRange(new[] { "Communication avec les forces naturelles (plantes, animaux, ...)",
                "Invocation d'une chimère (créature connue par le lanceur)",
                "Manipulation du terrain: peut modifier son environnement",
                "Métamorphose: êtres réels et connus par le lanceur"});
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Divine — magie liée aux divinités"))
            {
                cbbSortileges.Items.AddRange(new[] { "Bouclier protecteur: champ protecteur dans un rayon défini",
                "Soins magiques: peut soigner les blessures mais pas repousser les membres",
                "Guérison: maladie, problème état",
                "Bénédiction: soigne des malédictions",
                "Divination: voit un futur proche"});
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Démoniaque — magie liée aux ténèbres"))
            {
                cbbSortileges.Items.AddRange(new[] {"Absorption: PV, Énergie",
                "Nécromancie: ramener des cadavres à la vie, manipulation des os",
                "Malédiction: jette une malédiction à quelqu'un",
                "Contrôle: possession d'une personne, contrôle de volonté"
                });
            }
            if (Properties.Settings.Default.Attributs.Contains("Magie Neutre — magie neutre"))
            {
                cbbSortileges.Items.AddRange(new[] {"Modifications corporelles (supersaut, super force, ...) ",
                "Invisibilé",
                "Vision d'aura",
                "Images miroir: (clones, images rémanentes, ...)",
                "Message: connexion mentale, images mentales, ..."
                });
            }
        }

        private void btnAjoutSortilegeAptitude_Click(object sender, EventArgs e)
        { }

        private void btnAjouterSortileges_Click(object sender, EventArgs e)
        {
            Label lblSortilege = new Label();

            gpbSortilegesAptitudes.Controls.Add(lblSortilege);

            lblSortilege.AutoSize = true;
            lblSortilege.Text = (string)cbbSortileges.SelectedItem;
            lblSortilege.Top = HtrControlTalent * 25;
            lblSortilege.Left = 10;

            HtrControlTalent = HtrControlTalent + 1;
            btnAjouterTalents.Top = btnAjouterTalents.Top + 25;
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
        }

        public void GetSettings()
        {
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne Scrasamax
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkScrmx_Click(object sender, EventArgs e)
        {
            string strTemp = lblScrmx.Text + " " + lblPdsScrmx.Text + " " + lblPrteScrmx.Text + " " + nudScrmx.Value.ToString() + " " + lblTpeScrmx.Text + " " + lblDgtsScrmx.Text;
            if (chkScrmx.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkScrmx.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne épée courte
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkEpCrte_Click(object sender, EventArgs e)
        {
            string strTemp = lblEpCrte.Text + " " + lblPdsEpCrte.Text + " " + lblPrteEpCrte.Text + " " + nudEpCrte.Value.ToString() + " " + lblTpeEpCrte.Text + " " + lblDgtsEpCrte.Text;
            if (chkEpCrte.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkEpCrte.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne épée longue
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkEpLge_Click(object sender, EventArgs e)
        {
            string strTemp = lblEpLge.Text + " " + lblPdsEpLge.Text + " " + lblPrteEpLge.Text + " " + nudEpLge.Value.ToString() + " " + lblTpeEpLge.Text + " " + lblDgtsEpLge.Text;
            if (chkEpLge.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkEpLge.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne glaive
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkGlve_Click(object sender, EventArgs e)
        {
            string strTemp = lblGlve.Text + " " + lblPdsGlve.Text + " " + lblPrteGlve.Text + " " + nudGlve.Value.ToString() + " " + lblTpeGlve.Text + " " + lblDgtsGlve.Text;
            if (chkGlve.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkGlve.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne latte
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkLte_Click(object sender, EventArgs e)
        {
            string strTemp = lblLte.Text + " " + lblPdsLte.Text + " " + lblPrteLte.Text + " " + nudLte.Value.ToString() + " " + lblTpeLte.Text + " " + lblDgtsLte.Text;
            if (chkLte.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkLte.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne sabre courbé
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSbreCrbe_Click(object sender, EventArgs e)
        {
            string strTemp = lblSbreCrbe.Text + " " + lblPdsSbreCrbe.Text + " " + lblPrteSbreCrbe.Text + " " + nudSbreCrbe.Value.ToString() + " " + lblTpeSbreCrbe.Text + " " + lblDgtsSbreCrbe.Text;
            if (chkSbreCrbe.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSbreCrbe.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne gourgandine
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkGgdne_Click(object sender, EventArgs e)
        {
            string strTemp = lblGgdne.Text + " " + lblPdsGgdne.Text + " " + lblPrteGgdne.Text + " " + nudGgdne.Value.ToString() + " " + lblTpeGgdne.Text + " " + lblDgtsGgdne.Text;
            if (chkGgdne.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkGgdne.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne contus
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCntus_Click(object sender, EventArgs e)
        {
            string strTemp = lblCntus.Text + " " + lblPdsCntus.Text + " " + lblPrteCntus.Text + " " + nudCntus.Value.ToString() + " " + lblTpeCntus.Text + " " + lblDgtsCntus.Text;
            if (chkCntus.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCntus.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne javeline
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkJvline_Click(object sender, EventArgs e)
        {
            string strTemp = lblJvline.Text + " " + lblPdsJvline.Text + " " + lblPrteJvline.Text + " " + nudJvline.Value.ToString() + " " + lblTpeJvline.Text + " " + lblDgtsJvline.Text;
            if (chkJvline.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkJvline.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne javelot
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkJvlot_Click(object sender, EventArgs e)
        {
            string strTemp = lblJvlot.Text + " " + lblPdsJvlot.Text + " " + lblPrteJvlot.Text + " " + nudJvlot.Value.ToString() + " " + lblTpeJvlot.Text + " " + lblDgtsJvlot.Text;
            if (chkJvlot.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkJvlot.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne lance
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkLnce_Click(object sender, EventArgs e)
        {
            string strTemp = lblLnce.Text + " " + lblPdsLnce.Text + " " + lblPrteLnce.Text + " " + nudLnce.Value.ToString() + " " + lblTpeLnce.Text + " " + lblDgtsLnce.Text;
            if (chkLnce.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkLnce.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne fourche
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkFrche_Click(object sender, EventArgs e)
        {
            string strTemp = lblFrche.Text + " " + lblPdsFrche.Text + " " + lblPrteFrche.Text + " " + nudFrche.Value.ToString() + " " + lblTpeFrche.Text + " " + lblDgtsFrche.Text;
            if (chkFrche.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkFrche.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne sarisse
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSrse_Click(object sender, EventArgs e)
        {
            string strTemp = lblSrse.Text + " " + lblPdsSrse.Text + " " + lblPrteSrse.Text + " " + nudSrse.Value.ToString() + " " + lblTpeSrse.Text + " " + lblDgtsSrse.Text;
            if (chkSrse.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSrse.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne couteau
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCtau_Click(object sender, EventArgs e)
        {
            string strTemp = lblCtau.Text + " " + lblPdsCtau.Text + " " + lblPrteCtau.Text + " " + nudCtau.Value.ToString() + " " + lblTpeCtau.Text + " " + lblDgtsCtau.Text;
            if (chkSrse.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSrse.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne dague
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkDge_Click(object sender, EventArgs e)
        {
            string strTemp = lblDge.Text + " " + lblPdsDge.Text + " " + lblPrteDge.Text + " " + nudDge.Value.ToString() + " " + lblTpeDge.Text + " " + lblDgtsDge.Text;
            if (chkDge.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkDge.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne faucille de guerre
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkFclGure_Click(object sender, EventArgs e)
        {
            string strTemp = lblFclGure.Text + " " + lblPdsFclGure.Text + " " + lblPrteFclGure.Text + " " + nudFclGure.Value.ToString() + " " + lblTpeFclGure.Text + " " + lblDgtsFclGure.Text;
            if (chkFclGure.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkFclGure.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne francisque
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkFrncsque_Click(object sender, EventArgs e)
        {

            string strTemp = lblFrncsque.Text + " " + lblPdsFrncsque.Text + " " + lblPrteFrncsque.Text + " " + nudFrncsque.Value.ToString() + " " + lblTpeFrncsque.Text + " " + lblDgtsFrncsque.Text;
            if (chkFrncsque.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkFrncsque.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne arc
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkArc_Click(object sender, EventArgs e)
        {
            string strTemp = lblArc.Text + " " + lblPdsArc.Text + " " + lblPrteArc.Text + " " + nudArc.Value.ToString() + " " + lblTpeArc.Text + " " + lblDgtsArc.Text;
            if (chkArc.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkArc.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne arbalète
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkAblte_Click(object sender, EventArgs e)
        {
            string strTemp = lblAblte.Text + " " + lblPdsAblte.Text + " " + lblPrteAblte.Text + " " + nudAblte.Value.ToString() + " " + lblTpeAblte.Text + " " + lblDgtsAblte.Text;
            if (chkAblte.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkAblte.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne fronde
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkFnde_Click(object sender, EventArgs e)
        {
            string strTemp = lblFnde.Text + " " + lblPdsFnde.Text + " " + lblPrteFnde.Text + " " + nudFnde.Value.ToString() + " " + lblTpeFnde.Text + " " + lblDgtsFnde.Text;
            if (chkFnde.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkFnde.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne fouet
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkFouet_Click(object sender, EventArgs e)
        {
            string strTemp = lblFouet.Text + " " + lblPdsFouet.Text + " " + lblPrteFouet.Text + " " + nudFouet.Value.ToString() + " " + lblTpeFouet.Text + " " + lblDgtsFouet.Text;
            if (chkFouet.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkFouet.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne fouet
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkFaC_Click(object sender, EventArgs e)
        {
            string strTemp = lblFaC.Text + " " + lblPdsFaC.Text + " " + lblPrteFaC.Text + " " + nudFaC.Value.ToString() + " " + lblTpeFaC.Text + " " + lblDgtsFaC.Text;
            if (chkFaC.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkFaC.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne bâton de chêne
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBtonChne_Click(object sender, EventArgs e)
        {
            string strTemp = lblBtonChne.Text + " " + lblPdsBtonChne.Text + " " + lblPrteBtonChne.Text + " " + nudBtonChne.Value.ToString() + " " + lblTpeBtonChne.Text + " "
                + lblDgtsBtonChne.Text + lblEftsBtonChne.Text;
            if (chkBtonChne.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkBtonChne.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne sceptre
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSctre_Click(object sender, EventArgs e)
        {
            string strTemp = lblSctre.Text + " " + lblPdsSctre.Text + " " + lblPrteSctre.Text + " " + nudSctre.Value.ToString() + " " + lblTpeSctre.Text + " "
                + lblDgtsSctre.Text + lblEftsSctre.Text;
            if (chkSctre.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSctre.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne Spangenhelm
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSpghlm_Click(object sender, EventArgs e)
        {
            string strTemp = lblSpghlm.Text + " " + lblPdsSpghlm.Text + " " + nudSpghlm.Value.ToString() + " " + lblEftsSpghlm.Text;
            if (chkSpghlm.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSpghlm.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne coiffe de mailles
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCfeMle_Click(object sender, EventArgs e)
        {
            string strTemp = lblCfeMle.Text + " " + lblPdsCfeMle.Text + " " + nudCfeMle.Value.ToString() + " " + lblEftsCfeMle.Text;
            if (chkCfeMle.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCfeMle.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne morion
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMrn_Click(object sender, EventArgs e)
        {
            string strTemp = lblMrn.Text + " " + lblPdsMrn.Text + " " + nudMrn.Value.ToString() + " " + lblEftsMrn.Text;
            if (chkMrn.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMrn.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne cerveliere
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCrvlre_Click(object sender, EventArgs e)
        {
            string strTemp = lblCrvlre.Text + " " + lblPdsCrvlre.Text + " " + nudCrvlre.Value.ToString() + " " + lblEftsCrvlre.Text;
            if (chkCrvlre.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCrvlre.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne chapel de fer
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkChplFr_Click(object sender, EventArgs e)
        {
            string strTemp = lblChplFr.Text + " " + lblPdsChplFr.Text + " " + nudChplFr.Value.ToString() + " " + lblEftsChplFr.Text;
            if (chkChplFr.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkChplFr.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne casque de barbare
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCsqueBrbre_Click(object sender, EventArgs e)
        {
            string strTemp = lblCsqueBrbre.Text + " " + lblPdsCsqueBrbre.Text + " " + nudCsqueBrbre.Value.ToString() + " " + lblEftsCsqueBrbre.Text;
            if (chkCsqueBrbre.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCsqueBrbre.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne vêtements
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkVtments_Click(object sender, EventArgs e)
        {
            string strTemp = lblVtments.Text + " " + lblPdsVtments.Text + " " + nudVtments.Value.ToString() + " " + lblEftsVtments.Text;
            if (chkVtments.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkVtments.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne broigne
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBrgne_Click(object sender, EventArgs e)
        {
            string strTemp = lblBrgne.Text + " " + lblPdsBrgne.Text + " " + nudBrgne.Value.ToString() + " " + lblEftsBrgne.Text;
            if (chkBrgne.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkBrgne.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne broigne
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCtphrcte_Click(object sender, EventArgs e)
        {
            string strTemp = lblCtphrcte.Text + " " + lblPdsCtphrcte.Text + " " + nudCtphrcte.Value.ToString() + " " + lblEftsCtphrcte.Text;
            if (chkCtphrcte.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCtphrcte.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne cuirasse de fer
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCrsFr_Click(object sender, EventArgs e)
        {
            string strTemp = lblCrsFr.Text + " " + lblPdsCrsFr.Text + " " + nudCrsFr.Value.ToString() + " " + lblEftsCrsFr.Text;
            if (chkCrsFr.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCrsFr.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne cape de cuir
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCpeCuir_Click(object sender, EventArgs e)
        {
            string strTemp = lblCpeCuir.Text + " " + lblPdsCpeCuir.Text + " " + nudCpeCuir.Value.ToString() + " " + lblEftsCpeCuir.Text;
            if (chkCpeCuir.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCpeCuir.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne cuirasse de bronze
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCrsBze_Click(object sender, EventArgs e)
        {
            string strTemp = lblCrsBze.Text + " " + lblPdsCrsBze.Text + " " + nudCrsBze.Value.ToString() + " " + lblEftsCrsBze.Text;
            if (chkCrsBze.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCrsBze.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne gants de mailles
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkGntMles_Click(object sender, EventArgs e)
        {
            string strTemp = lblGntMles.Text + " " + lblPdsGntMles.Text + " " + nudGntMles.Value.ToString() + " " + lblEftsGntMles.Text;
            if (chkGntMles.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkGntMles.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne gantelet
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkGntlet_Click(object sender, EventArgs e)
        {
            string strTemp = lblGntlet.Text + " " + lblPdsGntlet.Text + " " + nudGntlet.Value.ToString() + " " + lblEftsGntlet.Text;
            if (chkGntlet.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkGntlet.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne mitaines
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMitne_Click(object sender, EventArgs e)
        {
            string strTemp = lblMitne.Text + " " + lblPdsMitne.Text + " " + nudMitne.Value.ToString() + " " + lblEftsMitne.Text;
            if (chkMitne.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMitne.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne mitons
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMton_Click(object sender, EventArgs e)
        {
            string strTemp = lblMton.Text + " " + lblPdsMton.Text + " " + nudMton.Value.ToString() + " " + lblEftsMton.Text;
            if (chkMton.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMton.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne cuissardes
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCuissrd_Click(object sender, EventArgs e)
        {
            string strTemp = lblCuissrd.Text + " " + lblPdsCuissrd.Text + " " + nudCuissrd.Value.ToString() + " " + lblEftsCuissrd.Text;
            if (chkCuissrd.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCuissrd.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne cuissardes
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkPntlonTle_Click(object sender, EventArgs e)
        {
            string strTemp = lblPntlonTle.Text + " " + lblPdsPntlonTle.Text + " " + nudPntlonTle.Value.ToString() + " " + lblEftsPntlonTle.Text;
            if (chkPntlonTle.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkPntlonTle.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne cnemides
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCmide_Click(object sender, EventArgs e)
        {
            string strTemp = lblCmide.Text + " " + lblPdsCmide.Text + " " + nudCmide.Value.ToString() + " " + lblEftsCmide.Text;
            if (chkCmide.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCmide.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne sandales
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSndles_Click(object sender, EventArgs e)
        {
            string strTemp = lblSndles.Text + " " + lblPdsSndles.Text + " " + nudSndles.Value.ToString() + " " + lblEftsSndles.Text;
            if (chkSndles.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSndles.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne chaussure de cuir
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkChssuresCuir_Click(object sender, EventArgs e)
        {
            string strTemp = lblChssuresCuir.Text + " " + lblPdsChssuresCuir.Text + " " + nudChssuresCuir.Value.ToString() + " " + lblEftsChssuresCuir.Text;
            if (chkChssuresCuir.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkChssuresCuir.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne ecu
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkEcu_Click(object sender, EventArgs e)
        {
            string strTemp = lblEcu.Text + " " + lblPdsEcu.Text + " " + nudEcu.Value.ToString() + " " + lblEftsEcu.Text;
            if (chkEcu.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkEcu.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne pavois
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkPvois_Click(object sender, EventArgs e)
        {
            string strTemp = lblPvois.Text + " " + lblPdsPvois.Text + " " + nudPvois.Value.ToString() + " " + lblEftsPvois.Text;
            if (chkPvois.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkPvois.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }
        
        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne bouclier amande
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBclrAmde_Click(object sender, EventArgs e)
        {
            string strTemp = lblBclrAmde.Text + " " + lblPdsBclrAmde.Text + " " + nudBclrAmde.Value.ToString() + " " + lblEftsBclrAmde.Text;
            if (chkBclrAmde.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkBclrAmde.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne bouclier bronze
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBclrBze_Click(object sender, EventArgs e)
        {
            string strTemp = lblBclrBze.Text + " " + lblPdsBclrBze.Text + " " + nudBclrBze.Value.ToString() + " " + lblEftsBclrBze.Text;
            if (chkBclrBze.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkBclrBze.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne pelta
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkPlta_Click(object sender, EventArgs e)
        {
            string strTemp = lblPlta.Text + " " + lblPdsPlta.Text + " " + nudPlta.Value.ToString() + " " + lblEftsPlta.Text;
            if (chkPlta.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkPlta.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne torche
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkTrche_Click(object sender, EventArgs e)
        {
            string strTemp = lblTrche.Text + " " + lblPdsTrche.Text + " " + lblLgrTrche.Text + " " + nudTrche.Value.ToString() + " " + lblEftsTrche.Text;
            if (chkTrche.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkTrche.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne corde
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCrde_Click(object sender, EventArgs e)
        {
            string strTemp = lblCrde.Text + " " + lblPdsCrde.Text + " " + lblLgrCrde.Text + " " + nudCrde.Value.ToString() + " " + lblEftsCrde.Text;
            if (chkCrde.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCrde.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne outre
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkOte_Click(object sender, EventArgs e)
        {
            string strTemp = lblOte.Text + " " + lblPdsOte.Text + " " + lblLgrOte.Text + " " + nudOte.Value.ToString() + " " + lblEftsOte.Text;
            if (chkOte.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkOte.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne sac
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSc_Click(object sender, EventArgs e)
        {
            string strTemp = lblSc.Text + " " + lblPdsSc.Text + " " + lblLgrSc.Text + " " + nudSc.Value.ToString() + " " + lblEftsSc.Text;
            if (chkSc.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSc.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne tente
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkTnte_Click(object sender, EventArgs e)
        {
            string strTemp = lblTnte.Text + " " + lblPdsTnte.Text + " " + lblLgrTnte.Text + " " + nudTnte.Value.ToString() + " " + lblEftsTnte.Text;
            if (chkTnte.Checked)
            {
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkTnte.Checked)
            {
                if (rchTxtIvtaires.Text.Contains(strTemp))
                {
                    if (rchTxtIvtaires.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTxtIvtaires.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(rchTxtIvtaires.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }
    }
}
