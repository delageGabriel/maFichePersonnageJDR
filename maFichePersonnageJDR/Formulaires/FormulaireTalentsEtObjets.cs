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
using System.Configuration;
using maFichePersonnageJDR.Classe;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireTalentsEtObjets : Form
    {
        public FormulaireTalentsEtObjets()
        {
            InitializeComponent();
        }

        private void FormulaireTalentsEtObjets_Load(object sender, EventArgs e)
        {
            GetSettings();
            GetSortileges();
            GetInventaires();
            GetSortilegeProperties();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Inventaires = rchTxtIvtaires.Text;
            Properties.Settings.Default.Sortilèges = rchTbSorts.Text;
            Properties.Settings.Default.Save();
        }

        public void GetSettings()
        {
            rchTxtIvtaires.Text = Properties.Settings.Default.Inventaires;
            rchTbSorts.Text = Properties.Settings.Default.Sortilèges;
        }

        /// <summary>
        /// Méthode qui permet de vérifier dans les attributs si
        /// la créature peut apprendre certains sorts, sinon, ils sont désactivés
        /// </summary>
        public void GetSortileges()
        {
            if (!Properties.Settings.Default.Attributs.Contains("Magie Aquatique — magie de l'eau"))
            {
                chkMgieAqua.Visible = false;
                lblMgieAqua.Visible = false;
            }
            if (!Properties.Settings.Default.Attributs.Contains("Magie Céleste — magie du ciel"))
            {
                chkMgieCeleste.Visible = false;
                lblMgieCeleste.Visible = false;
            }
            if (!Properties.Settings.Default.Attributs.Contains("Magie Démoniaque — magie liée aux ténèbres"))
            {
                chkMgieDemoniaqueAbspton.Visible = false;
                lblMgieDemoniaqueAbspton.Visible = false;
                chkMgieDemoniaqueCntrole.Visible = false;
                lblMgieDemoniaqueCntrole.Visible = false;
                chkMgieDemoniaqueMldction.Visible = false;
                lblMgieDemoniaqueMldction.Visible = false;
                chkMgieDemoniaqueNecro.Visible = false;
                lblMgieDemoniaqueNecro.Visible = false;
            }
            if (!Properties.Settings.Default.Attributs.Contains("Magie Divine — magie liée aux divinités"))
            {
                chkMgieDivineBclrPrtc.Visible = false;
                lblMgieDivineBclrPrtc.Visible = false;
                chkMgieDivineBene.Visible = false;
                lblMgieDivineBene.Visible = false;
                chkMgieDivineDvnation.Visible = false;
                lblMgieDivineDvnation.Visible = false;
                chkMgieDivineGueri.Visible = false;
                lblMgieDivineGueri.Visible = false;
                chkMgieDivineRestauration.Visible = false;
                lblMgieDivineRestauration.Visible = false;
            }
            if (!Properties.Settings.Default.Attributs.Contains("Magie Ignis — magie du feu"))
            {
                chkMgieIgnis.Visible = false;
                lblMgieIgnis.Visible = false;
            }
            if (!Properties.Settings.Default.Attributs.Contains("Magie Naturelle — magie de la nature"))
            {
                chkMgieNatureChgmTemp.Visible = false;
                lblMgieNatureChgmTemp.Visible = false;
                chkMgieNatureComm.Visible = false;
                lblMgieNatureComm.Visible = false;
                chkMgieNatureInvoc.Visible = false;
                lblMgieNatureInvoc.Visible = false;
                chkMgieNatureVsionNoir.Visible = false;
                lblMgieNatureVsionNoir.Visible = false;
            }
            if (!Properties.Settings.Default.Attributs.Contains("Magie Neutre — magie neutre"))
            {
                chkMgieNeutreAltration.Visible = false;
                lblMgieNeutreAltration.Visible = false;
                chkMgieNeutreInvsbilté.Visible = false;
                lblMgieNeutreInvsbilté.Visible = false;
                chkMgieNeutreMsg.Visible = false;
                lblMgieNeutreMsg.Visible = false;
                chkMgieNeutreSsie.Visible = false;
                lblMgieNeutreSsie.Visible = false;
                chkMgieNeutreTelkinesie.Visible = false;
                lblMgieNeutreTelkinesie.Visible = false;
            }
            if (!Properties.Settings.Default.Attributs.Contains("Magie Terrestre: magie de la terre"))
            {
                chkMgieTerrestre.Visible = false;
                lblMgieTerrestre.Visible = false;
            }
        }

        public void GetInventaires()
        {
            if (Properties.Settings.Default.Inventaires.Contains("Scramasax"))
            {
                chkScrmx.Checked = true;
                nudScrmx.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Épée courte"))
            {
                chkEpCrte.Checked = true;
                nudEpCrte.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Épée longue"))
            {
                chkEpLge.Checked = true;
                nudEpLge.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Glaive"))
            {
                chkGlve.Checked = true;
                nudGlve.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Latte"))
            {
                chkLte.Checked = true;
                nudLte.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Sabre courbé"))
            {
                chkSbreCrbe.Checked = true;
                nudSbreCrbe.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Contus"))
            {
                chkCntus.Checked = true;
                nudCntus.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Javelot"))
            {
                chkJvlot.Checked = true;
                nudJvlot.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Trident"))
            {
                chkTrdnt.Checked = true;
                nudTrdnt.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Fourche"))
            {
                chkFrche.Checked = true;
                nudFrche.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Sarisse"))
            {
                chkSrse.Checked = true;
                nudSrse.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Sarisse"))
            {
                chkSrse.Checked = true;
                nudSrse.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Couteau"))
            {
                chkCtau.Checked = true;
                nudCtau.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Dague"))
            {
                chkDge.Checked = true;
                nudDge.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Faucille de guerre"))
            {
                chkFclGure.Checked = true;
                nudFclGure.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Francisque"))
            {
                chkFrncsque.Checked = true;
                nudFrncsque.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Arc"))
            {
                chkArc.Checked = true;
                nudArc.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Arbalète"))
            {
                chkAblte.Checked = true;
                nudAblte.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Fronde"))
            {
                chkFnde.Checked = true;
                nudFnde.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Fouet"))
            {
                chkFouet.Checked = true;
                nudFouet.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Faucille à chaîne"))
            {
                chkFaC.Checked = true;
                nudFaC.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Bâton de chêne"))
            {
                chkBtonChne.Checked = true;
                nudBtonChne.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Sceptre"))
            {
                chkSctre.Checked = true;
                nudSctre.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Spangenhelm"))
            {
                chkSpghlm.Checked = true;
                nudSpghlm.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Coiffe de mailles"))
            {
                chkCfeMle.Checked = true;
                nudCfeMle.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Morion"))
            {
                chkMrn.Checked = true;
                nudMrn.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Cervelière"))
            {
                chkCrvlre.Checked = true;
                nudCrvlre.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Chapel de fer"))
            {
                chkChplFr.Checked = true;
                nudChplFr.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Casque barbare"))
            {
                chkCsqueBrbre.Checked = true;
                nudCsqueBrbre.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Vêtements"))
            {
                chkVtments.Checked = true;
                nudVtments.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Broigne"))
            {
                chkBrgne.Checked = true;
                nudBrgne.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Cataphracte"))
            {
                chkCtphrcte.Checked = true;
                nudCtphrcte.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Cuirasse de fer"))
            {
                chkCrsFr.Checked = true;
                nudCrsBze.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Cape de cuir"))
            {
                chkRbeCuir.Checked = true;
                nudRbeCuir.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Cuirasse de bronze"))
            {
                chkCrsBze.Checked = true;
                nudCrsBze.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Gants de mailles"))
            {
                chkGntMles.Checked = true;
                nudGntMles.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Gantelet"))
            {
                chkGntlet.Checked = true;
                nudGntlet.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Mitaines"))
            {
                chkMitne.Checked = true;
                nudMitne.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Mitons"))
            {
                chkMton.Checked = true;
                nudMton.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Cuissardes"))
            {
                chkCuissrd.Checked = true;
                nudCuissrd.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Pantalon de toile"))
            {
                chkPntlonTle.Checked = true;
                nudPntlonTle.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Cnémide"))
            {
                chkCmide.Checked = true;
                nudCmide.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Sandales"))
            {
                chkSndles.Checked = true;
                nudSndles.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Chaussures de cuir"))
            {
                chkChssuresCuir.Checked = true;
                nudChssuresCuir.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Écu"))
            {
                chkEcu.Checked = true;
                nudEcu.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Pavois"))
            {
                chkPvois.Checked = true;
                nudPvois.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Bouclier en amande"))
            {
                chkPvois.Checked = true;
                nudPvois.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Bouclier de bronze"))
            {
                chkBclrBze.Checked = true;
                nudBclrBze.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Pelta"))
            {
                chkPlta.Checked = true;
                nudPlta.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Torche"))
            {
                chkTrche.Checked = true;
                nudTrche.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Corde"))
            {
                chkCrde.Checked = true;
                nudCrde.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Outre"))
            {
                chkOte.Checked = true;
                nudOte.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Sac"))
            {
                chkSc.Checked = true;
                nudSc.Enabled = false;
            }
            if (Properties.Settings.Default.Inventaires.Contains("Tente"))
            {
                chkTnte.Checked = true;
                nudTnte.Enabled = false;
            }
        }

        public void GetSortilegeProperties()
        {
            if (Properties.Settings.Default.Sortilèges.Contains("eau"))
            {
                chkMgieAqua.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("flammes"))
            {
                chkMgieIgnis.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("cieux"))
            {
                chkMgieCeleste.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("terre"))
            {
                chkMgieTerrestre.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Communication avec l'environnement"))
            {
                chkMgieNatureComm.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Invocation d'un familier"))
            {
                chkMgieNatureInvoc.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Changement de la température"))
            {
                chkMgieNatureChgmTemp.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Vision dans le noir"))
            {
                chkMgieNatureVsionNoir.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Métamorphose"))
            {
                chkMgieNatureMetamphse.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Bouclier de protection"))
            {
                chkMgieDivineBclrPrtc.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Restauration"))
            {
                chkMgieDivineRestauration.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Guérison"))
            {
                chkMgieDivineGueri.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Bénédiction"))
            {
                chkMgieDivineBene.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Divination"))
            {
                chkMgieDivineDvnation.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Absorption"))
            {
                chkMgieDemoniaqueAbspton.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Nécromancie"))
            {
                chkMgieDemoniaqueNecro.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Malédiction"))
            {
                chkMgieDemoniaqueMldction.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Contrôle"))
            {
                chkMgieDemoniaqueCntrole.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Illusion"))
            {
                chkMgieDemoniaqueIllusions.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Altération corporelle"))
            {
                chkMgieNeutreAltration.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Invisibité"))
            {
                chkMgieNeutreInvsbilté.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Sosie"))
            {
                chkMgieNeutreSsie.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Message"))
            {
                chkMgieNeutreMsg.Checked = true;
            }
            if (Properties.Settings.Default.Sortilèges.Contains("Télékinésie"))
            {
                chkMgieNeutreTelkinesie.Checked = true;
            }
        }
        #region clique_chk_inventaire
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
                nudScrmx.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkScrmx.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (rchTxtIvtaires.Lines[i].Contains("Scramasax"))
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudScrmx.Enabled = true;
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
                nudEpCrte.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkEpCrte.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudEpCrte.Enabled = true;
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
                nudEpLge.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkEpLge.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudEpLge.Enabled = true;
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
                nudGlve.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkGlve.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudGlve.Enabled = true;
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
                nudLte.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkLte.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudLte.Enabled = true;
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
                nudSbreCrbe.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSbreCrbe.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudSbreCrbe.Enabled = true;
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
                nudCntus.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCntus.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudCntus.Enabled = true;
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
                nudJvlot.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkJvlot.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudJvlot.Enabled = true;
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
                nudFrche.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkFrche.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudFrche.Enabled = true;
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
                nudSrse.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSrse.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudSrse.Enabled = true;
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
            if (chkCtau.Checked)
            {
                nudCtau.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCtau.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudCtau.Enabled = true;
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
                nudDge.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkDge.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudDge.Enabled = true;
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
                nudFclGure.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkFclGure.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudFclGure.Enabled = true;
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
                nudFrncsque.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkFrncsque.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudFrncsque.Enabled = true;
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
                nudArc.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkArc.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudArc.Enabled = true;
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
                nudAblte.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkAblte.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudAblte.Enabled = true;
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
                nudFnde.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkFnde.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudFnde.Enabled = true;
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
                nudFouet.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkFouet.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudFouet.Enabled = true;
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
                nudFaC.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkFaC.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudFaC.Enabled = true;
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
                nudBtonChne.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkBtonChne.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudBtonChne.Enabled = true;
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
                nudSctre.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSctre.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudSctre.Enabled = true;
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
                nudSpghlm.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSpghlm.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudSpghlm.Enabled = true;
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
                nudCfeMle.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCfeMle.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudCfeMle.Enabled = true;
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
                nudMrn.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMrn.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudMrn.Enabled = true;
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
                nudCrvlre.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCrvlre.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudCrvlre.Enabled = true;
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
                nudChplFr.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkChplFr.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudChplFr.Enabled = true;
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
                nudCsqueBrbre.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCsqueBrbre.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudCsqueBrbre.Enabled = true;
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
                nudVtments.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkVtments.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudVtments.Enabled = true;
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
                nudBrgne.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkBrgne.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudBrgne.Enabled = true;
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
                nudCtphrcte.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCtphrcte.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudCtphrcte.Enabled = true;
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
                nudCrsFr.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCrsFr.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudCrsFr.Enabled = true;
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
        private void chkRbeCuir_Click(object sender, EventArgs e)
        {
            string strTemp = lblRbeCuir.Text + " " + lblPdsRbeCuir.Text + " " + nudRbeCuir.Value.ToString() + " " + lblEftsRbeCuir.Text;
            if (chkRbeCuir.Checked)
            {
                nudRbeCuir.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkRbeCuir.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudRbeCuir.Enabled = true;
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
                nudCrsBze.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCrsBze.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudCrsBze.Enabled = true;
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
                nudGntMles.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkGntMles.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudGntMles.Enabled = true;
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
                nudGntlet.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkGntlet.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudGntlet.Enabled = true;
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
                nudMitne.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMitne.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudMitne.Enabled = true;
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
                nudMton.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMton.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudMton.Enabled = true;
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
                nudCuissrd.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCuissrd.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudCuissrd.Enabled = true;
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
                nudPntlonTle.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkPntlonTle.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudPntlonTle.Enabled = true;
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
                nudCmide.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCmide.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudCmide.Enabled = true;
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
                nudSndles.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSndles.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudSndles.Enabled = true;
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
                nudChssuresCuir.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkChssuresCuir.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudChssuresCuir.Enabled = true;
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
                nudEcu.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkEcu.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudEcu.Enabled = true;
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
                nudPvois.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkPvois.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudPvois.Enabled = true;
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
                nudBclrAmde.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkBclrAmde.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudBclrAmde.Enabled = true;
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
                nudBclrBze.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkBclrBze.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudBclrBze.Enabled = true;
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
                nudPlta.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkPlta.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudPlta.Enabled = true;
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
            string strTemp = lblTrche.Text + " " + lblPdsTrche.Text + " " + lblTlleTrche.Text + " " + nudTrche.Value.ToString() + " " + lblEftsTrche.Text;
            if (chkTrche.Checked)
            {
                nudTrche.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkTrche.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudTrche.Enabled = true;
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
            string strTemp = lblCrde.Text + " " + lblPdsCrde.Text + " " + lblTlleCrde.Text + " " + nudCrde.Value.ToString() + " " + lblEftsCrde.Text;
            if (chkCrde.Checked)
            {
                nudCrde.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCrde.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudCrde.Enabled = true;
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
            string strTemp = lblOte.Text + " " + lblPdsOte.Text + " " + lblTlleOte.Text + " " + nudOte.Value.ToString() + " " + lblEftsOte.Text;
            if (chkOte.Checked)
            {
                nudOte.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkOte.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudOte.Enabled = true;
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
            string strTemp = lblSc.Text + " " + lblPdsSc.Text + " " + lblTlleSc.Text + " " + nudSc.Value.ToString() + " " + lblEftsSc.Text;
            if (chkSc.Checked)
            {
                nudSc.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSc.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudSc.Enabled = true;
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
            string strTemp = lblTnte.Text + " " + lblPdsTnte.Text + " " + lblTlleTnte.Text + " " + nudTnte.Value.ToString() + " " + lblEftsTnte.Text;
            if (chkTnte.Checked)
            {
                nudTnte.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkTnte.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudTnte.Enabled = true;
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

        private void chkTrdnt_Click(object sender, EventArgs e)
        {
            string strTemp = lblTrdnt.Text + " " + lblPdsTrdnt.Text + " " + lblPrteTrdnt.Text + " " + nudTrdnt.Value.ToString() + " " + lblTpeTrdnt.Text + " " + lblDgtsTrdnt.Text;
            if (chkTrdnt.Checked)
            {
                nudTrdnt.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkTrdnt.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudTrdnt.Enabled = true;
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
        #endregion
        #region clique_chk_sortileges
        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne manipulation aquatique
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieAqua_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieAqua.Text;
            if (chkMgieAqua.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieAqua.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }
        
        
        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne manipulation du feu
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieIgnis_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieIgnis.Text;
            if (chkMgieIgnis.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieIgnis.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne manipulation des objets céleste
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieCeleste_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieCeleste.Text;
            if (chkMgieCeleste.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieCeleste.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne manipulation terrestre
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieTerrestre_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieTerrestre.Text;
            if (chkMgieTerrestre.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieTerrestre.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne communication avec l'environnement
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieNatureComm_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieNatureComm.Text;
            if (chkMgieNatureComm.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieNatureComm.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne invocation familier
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieNatureInvoc_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieNatureInvoc.Text;
            if (chkMgieNatureInvoc.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieNatureInvoc.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne changement température
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieNatureChgmTemp_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieNatureChgmTemp.Text;
            if (chkMgieNatureChgmTemp.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieNatureChgmTemp.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne vision dans le noir
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieNatureVsionNoir_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieNatureVsionNoir.Text;
            if (chkMgieNatureVsionNoir.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieNatureVsionNoir.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne bouclier protecteur
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieDivineBclrPrtc_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieDivineBclrPrtc.Text;
            if (chkMgieDivineBclrPrtc.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieDivineBclrPrtc.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne restauration
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieDivineRestauration_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieDivineRestauration.Text;
            if (chkMgieDivineRestauration.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieDivineRestauration.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne guérison
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieDivineGueri_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieDivineGueri.Text;
            if (chkMgieDivineGueri.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieDivineGueri.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne bénédiction
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieDivineBene_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieDivineBene.Text;
            if (chkMgieDivineBene.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieDivineBene.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne divination
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieDivineDvnation_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieDivineDvnation.Text;
            if (chkMgieDivineDvnation.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieDivineDvnation.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne absorption
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieDemoniaqueAbspton_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieDemoniaqueAbspton.Text;
            if (chkMgieDemoniaqueAbspton.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieDemoniaqueAbspton.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne nécromancie
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieDemoniaqueNecro_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieDemoniaqueNecro.Text;
            if (chkMgieDemoniaqueNecro.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieDemoniaqueNecro.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne malédiction
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieDemoniaqueMldction_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieDemoniaqueMldction.Text;
            if (chkMgieDemoniaqueMldction.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieDemoniaqueMldction.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne contrôle
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieDemoniaqueCntrole_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieDemoniaqueCntrole.Text;
            if (chkMgieDemoniaqueCntrole.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieDemoniaqueCntrole.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne altération corporelle
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieNeutreAltration_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieNeutreAltration.Text;
            if (chkMgieNeutreAltration.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieNeutreAltration.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne invisibilité
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieNeutreInvsbilté_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieNeutreInvsbilté.Text;
            if (chkMgieNeutreInvsbilté.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieNeutreInvsbilté.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne invisibilité
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieNeutreSsie_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieNeutreSsie.Text;
            if (chkMgieNeutreSsie.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieNeutreSsie.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne message
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieNeutreMsg_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieNeutreMsg.Text;
            if (chkMgieNeutreMsg.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieNeutreMsg.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne métamorphose
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieNatureMetamphse_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieNatureMetamphse.Text;
            if (chkMgieNatureMetamphse.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieNatureMetamphse.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne télékinésie
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieNeutreTelkinesie_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieNeutreTelkinesie.Text;
            if (chkMgieNeutreTelkinesie.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieNeutreTelkinesie.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter ou retirer la ligne télékinésie
        /// à la richtextbox lorsque l'utilisateur clique sur la checkbox associée
        /// à la ligne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMgieDemoniaqueIllusions_Click(object sender, EventArgs e)
        {
            string strTemp = lblMgieDemoniaqueIllusion.Text;
            if (chkMgieDemoniaqueIllusions.Checked)
            {
                rchTbSorts.Text += String.IsNullOrEmpty(rchTbSorts.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkMgieDemoniaqueIllusions.Checked)
            {
                if (rchTbSorts.Text.Contains(strTemp))
                {
                    if (rchTbSorts.Text.Contains(strTemp + "\n"))
                    {
                        strTemp = strTemp + "\n";
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else if (rchTbSorts.Text.Contains("\n" + strTemp))
                    {
                        strTemp = "\n" + strTemp;
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                    else
                    {
                        rchTbSorts.Text = rchTbSorts.Text.Remove(rchTbSorts.Text.IndexOf(strTemp), strTemp.Length);
                    }
                }
            }
        }
        #endregion
        #region boutons_vider
        private void btnViderRchTbInventaires_Click(object sender, EventArgs e)
        {
            rchTxtIvtaires.Text = rchTxtIvtaires.Text.Remove(0, rchTxtIvtaires.TextLength);
            foreach (TabPage tabPage in tcArmes.Controls)
            {
                VideRichTextBoxBoutonVider(tabPage);
            }
            foreach (TabPage tabPage in tcArmure.Controls)
            {
                VideRichTextBoxBoutonVider(tabPage);
            }
            VideRichTextBoxBoutonVider(tpObjets);
        }


        private void btnViderRchTbSortileges_Click(object sender, EventArgs e)
        {
            rchTbSorts.Text = rchTbSorts.Text.Remove(0, rchTbSorts.TextLength);
            foreach (TabPage tabPage in tcSortilege.Controls)
            {
                VideRichTextBoxBoutonVider(tabPage);
            }
        }

        public void VideRichTextBoxBoutonVider(TabPage uneTabPage)
        {
            foreach (object tpControls in uneTabPage.Controls)
            {
                if (tpControls is CheckBox)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox = (CheckBox)tpControls;
                    checkBox.Checked = false;
                }

                if (tpControls is NumericUpDown)
                {
                    NumericUpDown numericUpDown = new NumericUpDown();
                    numericUpDown = (NumericUpDown)tpControls;
                    numericUpDown.Enabled = true;
                }
            }
        }





        #endregion
        #region numeric_inventaires
        private void nudScrmx_ValueChanged(object sender, EventArgs e)
        {
            if (nudScrmx.Value == 0)
            {
                chkScrmx.Visible = false;
                double poids = GlobalesVariable.PdsScrasamax;
                double poidsModifie = poids * Convert.ToDouble(nudScrmx.Value);
                lblPdsScrmx.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudScrmx.Value > 0)
            {
                chkScrmx.Visible = true;
                double poids = GlobalesVariable.PdsScrasamax;
                double poidsModifie = poids * Convert.ToDouble(nudScrmx.Value);
                lblPdsScrmx.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudEpCrte_ValueChanged(object sender, EventArgs e)
        {
            if (nudEpCrte.Value == 0)
            {
                chkEpCrte.Visible = false;
                double poids = GlobalesVariable.PdsEpeeCourte;
                double poidsModifie = poids * Convert.ToDouble(nudEpCrte.Value);
                lblPdsEpCrte.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudEpCrte.Value > 0)
            {
                chkEpCrte.Visible = true;
                double poids = GlobalesVariable.PdsEpeeCourte;
                double poidsModifie = poids * Convert.ToDouble(nudEpCrte.Value);
                lblPdsEpCrte.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudEpLge_ValueChanged(object sender, EventArgs e)
        {
            if (nudEpLge.Value == 0)
            {
                chkEpLge.Visible = false;
                double poids = GlobalesVariable.PdsEpeeLongue;
                double poidsModifie = poids * Convert.ToDouble(nudEpLge.Value);
                lblPdsEpLge.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudEpLge.Value > 0)
            {
                chkEpLge.Visible = true;
                double poids = GlobalesVariable.PdsEpeeLongue;
                double poidsModifie = poids * Convert.ToDouble(nudEpLge.Value);
                lblPdsEpLge.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudGlve_ValueChanged(object sender, EventArgs e)
        {
            if (nudGlve.Value == 0)
            {
                chkGlve.Visible = false;
                double poids = GlobalesVariable.PdsGlaive;
                double poidsModifie = poids * Convert.ToDouble(nudGlve.Value);
                lblPdsGlve.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudGlve.Value > 0)
            {
                chkGlve.Visible = true;
                double poids = GlobalesVariable.PdsGlaive;
                double poidsModifie = poids * Convert.ToDouble(nudGlve.Value);
                lblPdsGlve.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudLte_ValueChanged(object sender, EventArgs e)
        {
            if (nudLte.Value == 0)
            {
                chkLte.Visible = false;
                double poids = GlobalesVariable.PdsLatte;
                double poidsModifie = poids * Convert.ToDouble(nudLte.Value);
                lblPdsLte.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudLte.Value > 0)
            {
                chkLte.Visible = true;
                double poids = GlobalesVariable.PdsLatte;
                double poidsModifie = poids * Convert.ToDouble(nudLte.Value);
                lblPdsLte.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudSbreCrbe_ValueChanged(object sender, EventArgs e)
        {
            if (nudSbreCrbe.Value == 0)
            {
                chkSbreCrbe.Visible = false;
                double poids = GlobalesVariable.PdsSabreCourbe;
                double poidsModifie = poids * Convert.ToDouble(nudSbreCrbe.Value);
                lblPdsSbreCrbe.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudSbreCrbe.Value > 0)
            {
                chkSbreCrbe.Visible = true;
                double poids = GlobalesVariable.PdsSabreCourbe;
                double poidsModifie = poids * Convert.ToDouble(nudSbreCrbe.Value);
                lblPdsSbreCrbe.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudCntus_ValueChanged(object sender, EventArgs e)
        {
            if (nudCntus.Value == 0)
            {
                chkCntus.Visible = false;
                double poids = GlobalesVariable.PdsContus;
                double poidsModifie = poids * Convert.ToDouble(nudCntus.Value);
                lblPdsCntus.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudCntus.Value > 0)
            {
                chkCntus.Visible = true;
                double poids = GlobalesVariable.PdsContus;
                double poidsModifie = poids * Convert.ToDouble(nudCntus.Value);
                lblPdsCntus.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudJvlot_ValueChanged(object sender, EventArgs e)
        {
            if (nudJvlot.Value == 0)
            {
                chkJvlot.Visible = false;
                double poids = GlobalesVariable.PdsJavelot;
                double poidsModifie = poids * Convert.ToDouble(nudJvlot.Value);
                lblPdsJvlot.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudJvlot.Value > 0)
            {
                chkJvlot.Visible = true;
                double poids = GlobalesVariable.PdsJavelot;
                double poidsModifie = poids * Convert.ToDouble(nudJvlot.Value);
                lblPdsJvlot.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudFrche_ValueChanged(object sender, EventArgs e)
        {
            if (nudFrche.Value == 0)
            {
                chkFrche.Visible = false;
                double poids = GlobalesVariable.PdsFourche;
                double poidsModifie = poids * Convert.ToDouble(nudFrche.Value);
                lblPdsFrche.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudFrche.Value > 0)
            {
                chkFrche.Visible = true;
                double poids = GlobalesVariable.PdsFourche;
                double poidsModifie = poids * Convert.ToDouble(nudFrche.Value);
                lblPdsFrche.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudSrse_ValueChanged(object sender, EventArgs e)
        {
            if (nudSrse.Value == 0)
            {
                chkSrse.Visible = false;
                double poids = GlobalesVariable.PdsSarisse;
                double poidsModifie = poids * Convert.ToDouble(nudSrse.Value);
                lblPdsSrse.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudSrse.Value > 0)
            {
                chkSrse.Visible = true;
                double poids = GlobalesVariable.PdsSarisse;
                double poidsModifie = poids * Convert.ToDouble(nudSrse.Value);
                lblPdsSrse.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudTrdnt_ValueChanged(object sender, EventArgs e)
        {
            if (nudTrdnt.Value == 0)
            {
                chkTrdnt.Visible = false;
                double poids = GlobalesVariable.PdsTrident;
                double poidsModifie = poids * Convert.ToDouble(nudTrdnt.Value);
                lblPdsTrdnt.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudTrdnt.Value > 0)
            {
                chkTrdnt.Visible = true;
                double poids = GlobalesVariable.PdsTrident;
                double poidsModifie = poids * Convert.ToDouble(nudTrdnt.Value);
                lblPdsTrdnt.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudCtau_ValueChanged(object sender, EventArgs e)
        {
            if (nudCtau.Value == 0)
            {
                chkCtau.Visible = false;
                double poids = GlobalesVariable.PdsCouteau;
                double poidsModifie = poids * Convert.ToDouble(nudCtau.Value);
                lblPdsCtau.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudCtau.Value > 0)
            {
                chkCtau.Visible = true;
                double poids = GlobalesVariable.PdsCouteau;
                double poidsModifie = poids * Convert.ToDouble(nudCtau.Value);
                lblPdsCtau.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudDge_ValueChanged(object sender, EventArgs e)
        {
            if (nudDge.Value == 0)
            {
                chkDge.Visible = false;
                double poids = GlobalesVariable.PdsDague;
                double poidsModifie = poids * Convert.ToDouble(nudDge.Value);
                lblPdsDge.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudDge.Value > 0)
            {
                chkDge.Visible = true;
                double poids = GlobalesVariable.PdsDague;
                double poidsModifie = poids * Convert.ToDouble(nudDge.Value);
                lblPdsDge.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudFclGure_ValueChanged(object sender, EventArgs e)
        {
            if (nudFclGure.Value == 0)
            {
                chkFclGure.Visible = false;
                double poids = GlobalesVariable.PdsFaucilleGuerre;
                double poidsModifie = poids * Convert.ToDouble(nudFclGure.Value);
                lblPdsFclGure.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudFclGure.Value > 0)
            {
                chkFclGure.Visible = true;
                double poids = GlobalesVariable.PdsFaucilleGuerre;
                double poidsModifie = poids * Convert.ToDouble(nudFclGure.Value);
                lblPdsFclGure.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudFrncsque_ValueChanged(object sender, EventArgs e)
        {
            if (nudFrncsque.Value == 0)
            {
                chkFrncsque.Visible = false;
                double poids = GlobalesVariable.PdsFrancisque;
                double poidsModifie = poids * Convert.ToDouble(nudFrncsque.Value);
                lblPdsFrncsque.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudFrncsque.Value > 0)
            {
                chkFrncsque.Visible = true;
                double poids = GlobalesVariable.PdsFrancisque;
                double poidsModifie = poids * Convert.ToDouble(nudFrncsque.Value);
                lblPdsFrncsque.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudArc_ValueChanged(object sender, EventArgs e)
        {
            if (nudArc.Value == 0)
            {
                chkArc.Visible = false;
                double poids = GlobalesVariable.PdsArc;
                double poidsModifie = poids * Convert.ToDouble(nudArc.Value);
                lblPdsArc.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudArc.Value > 0)
            {
                chkArc.Visible = true;
                double poids = GlobalesVariable.PdsArc;
                double poidsModifie = poids * Convert.ToDouble(nudArc.Value);
                lblPdsArc.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudAblte_ValueChanged(object sender, EventArgs e)
        {
            if (nudAblte.Value == 0)
            {
                chkAblte.Visible = false;
                double poids = GlobalesVariable.PdsArbalete;
                double poidsModifie = poids * Convert.ToDouble(nudAblte.Value);
                lblPdsAblte.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudAblte.Value > 0)
            {
                chkAblte.Visible = true;
                double poids = GlobalesVariable.PdsArbalete;
                double poidsModifie = poids * Convert.ToDouble(nudAblte.Value);
                lblPdsAblte.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudFnde_ValueChanged(object sender, EventArgs e)
        {
            if (nudFnde.Value == 0)
            {
                chkFnde.Visible = false;
                double poids = GlobalesVariable.PdsFronde;
                double poidsModifie = poids * Convert.ToDouble(nudFnde.Value);
                lblPdsFnde.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudFnde.Value > 0)
            {
                chkFnde.Visible = true;
                double poids = GlobalesVariable.PdsFronde;
                double poidsModifie = poids * Convert.ToDouble(nudFnde.Value);
                lblPdsFnde.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudFouet_ValueChanged(object sender, EventArgs e)
        {
            if (nudFouet.Value == 0)
            {
                chkFouet.Visible = false;
                double poids = GlobalesVariable.PdsFouet;
                double poidsModifie = poids * Convert.ToDouble(nudFouet.Value);
                lblPdsFouet.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudFouet.Value > 0)
            {
                chkFouet.Visible = true;
                double poids = GlobalesVariable.PdsFouet;
                double poidsModifie = poids * Convert.ToDouble(nudFouet.Value);
                lblPdsFouet.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudFaC_ValueChanged(object sender, EventArgs e)
        {
            if (nudFaC.Value == 0)
            {
                chkFaC.Visible = false;
                double poids = GlobalesVariable.PdsFaucilleChaine;
                double poidsModifie = poids * Convert.ToDouble(nudFaC.Value);
                lblPdsFaC.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudFaC.Value > 0)
            {
                chkFaC.Visible = true;
                double poids = GlobalesVariable.PdsFaucilleChaine;
                double poidsModifie = poids * Convert.ToDouble(nudFaC.Value);
                lblPdsFaC.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudBtonChne_ValueChanged(object sender, EventArgs e)
        {
            if (nudBtonChne.Value == 0)
            {
                chkBtonChne.Visible = false;
                double poids = GlobalesVariable.PdsFaucilleChaine;
                double poidsModifie = poids * Convert.ToDouble(nudBtonChne.Value);
                lblPdsBtonChne.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudBtonChne.Value > 0)
            {
                chkBtonChne.Visible = true;
                double poids = GlobalesVariable.PdsFaucilleChaine;
                double poidsModifie = poids * Convert.ToDouble(nudBtonChne.Value);
                lblPdsBtonChne.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudSctre_ValueChanged(object sender, EventArgs e)
        {
            if (nudSctre.Value == 0)
            {
                chkSctre.Visible = false;
                double poids = GlobalesVariable.PdsSceptre;
                double poidsModifie = poids * Convert.ToDouble(nudSctre.Value);
                lblPdsSctre.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudSctre.Value > 0)
            {
                chkSctre.Visible = true;
                double poids = GlobalesVariable.PdsSceptre;
                double poidsModifie = poids * Convert.ToDouble(nudSctre.Value);
                lblPdsSctre.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudSpghlm_ValueChanged(object sender, EventArgs e)
        {
            if (nudSpghlm.Value == 0)
            {
                chkSpghlm.Visible = false;
                double poids = GlobalesVariable.PdsSpangenhelm;
                double poidsModifie = poids * Convert.ToDouble(nudSpghlm.Value);
                lblPdsSpghlm.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudSpghlm.Value > 0)
            {
                chkSpghlm.Visible = true;
                double poids = GlobalesVariable.PdsSpangenhelm;
                double poidsModifie = poids * Convert.ToDouble(nudSpghlm.Value);
                lblPdsSpghlm.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudCfeMle_ValueChanged(object sender, EventArgs e)
        {
            if (nudCfeMle.Value == 0)
            {
                chkCfeMle.Visible = false;
                double poids = GlobalesVariable.PdsCoiffeMaille;
                double poidsModifie = poids * Convert.ToDouble(nudCfeMle.Value);
                lblPdsCfeMle.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudCfeMle.Value > 0)
            {
                chkCfeMle.Visible = true;
                double poids = GlobalesVariable.PdsCoiffeMaille;
                double poidsModifie = poids * Convert.ToDouble(nudCfeMle.Value);
                lblPdsCfeMle.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudMrn_ValueChanged(object sender, EventArgs e)
        {
            if (nudMrn.Value == 0)
            {
                chkMrn.Visible = false;
                double poids = GlobalesVariable.PdsMorion;
                double poidsModifie = poids * Convert.ToDouble(nudMrn.Value);
                lblPdsMrn.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudMrn.Value > 0)
            {
                chkMrn.Visible = true;
                double poids = GlobalesVariable.PdsMorion;
                double poidsModifie = poids * Convert.ToDouble(nudMrn.Value);
                lblPdsMrn.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudCrvlre_ValueChanged(object sender, EventArgs e)
        {
            if (nudCrvlre.Value == 0)
            {
                chkCrvlre.Visible = false;
                double poids = GlobalesVariable.PdsCerveliere;
                double poidsModifie = poids * Convert.ToDouble(nudCrvlre.Value);
                lblPdsCrvlre.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudCrvlre.Value > 0)
            {
                chkCrvlre.Visible = true;
                double poids = GlobalesVariable.PdsCerveliere;
                double poidsModifie = poids * Convert.ToDouble(nudCrvlre.Value);
                lblPdsCrvlre.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudChplFr_ValueChanged(object sender, EventArgs e)
        {
            if (nudChplFr.Value == 0)
            {
                chkChplFr.Visible = false;
                double poids = GlobalesVariable.PdsChapelFer;
                double poidsModifie = poids * Convert.ToDouble(nudChplFr.Value);
                lblPdsChplFr.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudChplFr.Value > 0)
            {
                chkChplFr.Visible = true;
                double poids = GlobalesVariable.PdsChapelFer;
                double poidsModifie = poids * Convert.ToDouble(nudChplFr.Value);
                lblPdsChplFr.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudCsqueBrbre_ValueChanged(object sender, EventArgs e)
        {
            if (nudCsqueBrbre.Value == 0)
            {
                chkCsqueBrbre.Visible = false;
                double poids = GlobalesVariable.PdsCasqueBarbare;
                double poidsModifie = poids * Convert.ToDouble(nudCsqueBrbre.Value);
                lblPdsCsqueBrbre.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudCsqueBrbre.Value > 0)
            {
                chkCsqueBrbre.Visible = true;
                double poids = GlobalesVariable.PdsCasqueBarbare;
                double poidsModifie = poids * Convert.ToDouble(nudCsqueBrbre.Value);
                lblPdsCsqueBrbre.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudVtments_ValueChanged(object sender, EventArgs e)
        {
            if (nudVtments.Value == 0)
            {
                chkVtments.Visible = false;
                double poids = GlobalesVariable.PdsVetements;
                double poidsModifie = poids * Convert.ToDouble(nudVtments.Value);
                lblPdsVtments.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudVtments.Value > 0)
            {
                chkVtments.Visible = true;
                double poids = GlobalesVariable.PdsVetements;
                double poidsModifie = poids * Convert.ToDouble(nudVtments.Value);
                lblPdsVtments.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudBrgne_ValueChanged(object sender, EventArgs e)
        {
            if (nudBrgne.Value == 0)
            {
                chkBrgne.Visible = false;
                double poids = GlobalesVariable.PdsBroigne;
                double poidsModifie = poids * Convert.ToDouble(nudBrgne.Value);
                lblPdsBrgne.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudBrgne.Value > 0)
            {
                chkBrgne.Visible = true;
                double poids = GlobalesVariable.PdsBroigne;
                double poidsModifie = poids * Convert.ToDouble(nudBrgne.Value);
                lblPdsBrgne.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudCtphrcte_ValueChanged(object sender, EventArgs e)
        {
            if (nudCtphrcte.Value == 0)
            {
                chkCtphrcte.Visible = false;
                double poids = GlobalesVariable.PdsCataphracte;
                double poidsModifie = poids * Convert.ToDouble(nudCtphrcte.Value);
                lblPdsCtphrcte.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudCtphrcte.Value > 0)
            {
                chkCtphrcte.Visible = true;
                double poids = GlobalesVariable.PdsCataphracte;
                double poidsModifie = poids * Convert.ToDouble(nudCtphrcte.Value);
                lblPdsCtphrcte.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudCrsBze_ValueChanged(object sender, EventArgs e)
        {
            if (nudCrsBze.Value == 0)
            {
                chkCrsBze.Visible = false;
                double poids = GlobalesVariable.PdsCuirasseBronze;
                double poidsModifie = poids * Convert.ToDouble(nudCrsBze.Value);
                lblPdsCrsBze.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudCrsBze.Value > 0)
            {
                chkCrsBze.Visible = true;
                double poids = GlobalesVariable.PdsCuirasseBronze;
                double poidsModifie = poids * Convert.ToDouble(nudCrsBze.Value);
                lblPdsCrsBze.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudCrsFr_ValueChanged(object sender, EventArgs e)
        {
            if (nudCrsFr.Value == 0)
            {
                chkCrsFr.Visible = false;
                double poids = GlobalesVariable.PdsCuirasseFer;
                double poidsModifie = poids * Convert.ToDouble(nudCrsFr.Value);
                lblPdsCrsFr.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudCrsFr.Value > 0)
            {
                chkCrsFr.Visible = true;
                double poids = GlobalesVariable.PdsCuirasseFer;
                double poidsModifie = poids * Convert.ToDouble(nudCrsFr.Value);
                lblPdsCrsFr.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudRbeCuir_ValueChanged(object sender, EventArgs e)
        {
            if (nudRbeCuir.Value == 0)
            {
                chkRbeCuir.Visible = false;
                double poids = GlobalesVariable.PdsRobeCuir;
                double poidsModifie = poids * Convert.ToDouble(nudRbeCuir.Value);
                lblPdsRbeCuir.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudRbeCuir.Value > 0)
            {
                chkRbeCuir.Visible = true;
                double poids = GlobalesVariable.PdsRobeCuir;
                double poidsModifie = poids * Convert.ToDouble(nudRbeCuir.Value);
                lblPdsRbeCuir.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudGntMles_ValueChanged(object sender, EventArgs e)
        {
            if (nudGntMles.Value == 0)
            {
                chkGntMles.Visible = false;
                double poids = GlobalesVariable.PdsGantsMailles;
                double poidsModifie = poids * Convert.ToDouble(nudGntMles.Value);
                lblPdsGntMles.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudGntMles.Value > 0)
            {
                chkGntMles.Visible = true;
                double poids = GlobalesVariable.PdsGantsMailles;
                double poidsModifie = poids * Convert.ToDouble(nudGntMles.Value);
                lblPdsGntMles.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudGntlet_ValueChanged(object sender, EventArgs e)
        {
            if (nudGntlet.Value == 0)
            {
                chkGntlet.Visible = false;
                double poids = GlobalesVariable.PdsGantelet;
                double poidsModifie = poids * Convert.ToDouble(nudGntlet.Value);
                lblPdsGntlet.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudGntlet.Value > 0)
            {
                chkGntlet.Visible = true;
                double poids = GlobalesVariable.PdsGantelet;
                double poidsModifie = poids * Convert.ToDouble(nudGntlet.Value);
                lblPdsGntlet.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudMitne_ValueChanged(object sender, EventArgs e)
        {
            if (nudMitne.Value == 0)
            {
                chkMitne.Visible = false;
                double poids = GlobalesVariable.PdsMitaines;
                double poidsModifie = poids * Convert.ToDouble(nudMitne.Value);
                lblPdsMitne.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudMitne.Value > 0)
            {
                chkMitne.Visible = true;
                double poids = GlobalesVariable.PdsMitaines;
                double poidsModifie = poids * Convert.ToDouble(nudMitne.Value);
                lblPdsMitne.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudMton_ValueChanged(object sender, EventArgs e)
        {
            if (nudMton.Value == 0)
            {
                chkMton.Visible = false;
                double poids = GlobalesVariable.PdsMitons;
                double poidsModifie = poids * Convert.ToDouble(nudMton.Value);
                lblPdsMton.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudMton.Value > 0)
            {
                chkMton.Visible = true;
                double poids = GlobalesVariable.PdsMitons;
                double poidsModifie = poids * Convert.ToDouble(nudMton.Value);
                lblPdsMton.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudCuissrd_ValueChanged(object sender, EventArgs e)
        {
            if (nudCuissrd.Value == 0)
            {
                chkCuissrd.Visible = false;
                double poids = GlobalesVariable.PdsCuissardes;
                double poidsModifie = poids * Convert.ToDouble(nudCuissrd.Value);
                lblPdsCuissrd.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudCuissrd.Value > 0)
            {
                chkCuissrd.Visible = true;
                double poids = GlobalesVariable.PdsCuissardes;
                double poidsModifie = poids * Convert.ToDouble(nudCuissrd.Value);
                lblPdsCuissrd.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudPntlonTle_ValueChanged(object sender, EventArgs e)
        {
            if (nudPntlonTle.Value == 0)
            {
                chkPntlonTle.Visible = false;
                double poids = GlobalesVariable.PdsPantalonToile;
                double poidsModifie = poids * Convert.ToDouble(nudPntlonTle.Value);
                lblPdsPntlonTle.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudPntlonTle.Value > 0)
            {
                chkPntlonTle.Visible = true;
                double poids = GlobalesVariable.PdsPantalonToile;
                double poidsModifie = poids * Convert.ToDouble(nudPntlonTle.Value);
                lblPdsPntlonTle.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudCmide_ValueChanged(object sender, EventArgs e)
        {
            if (nudCmide.Value == 0)
            {
                chkCmide.Visible = false;
                double poids = GlobalesVariable.PdsCnemide;
                double poidsModifie = poids * Convert.ToDouble(nudCmide.Value);
                lblPdsCmide.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudCmide.Value > 0)
            {
                chkCmide.Visible = true;
                double poids = GlobalesVariable.PdsCnemide;
                double poidsModifie = poids * Convert.ToDouble(nudCmide.Value);
                lblPdsCmide.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudSndles_ValueChanged(object sender, EventArgs e)
        {
            if (nudSndles.Value == 0)
            {
                chkSndles.Visible = false;
                double poids = GlobalesVariable.PdsSandales;
                double poidsModifie = poids * Convert.ToDouble(nudSndles.Value);
                lblPdsSndles.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudSndles.Value > 0)
            {
                chkSndles.Visible = true;
                double poids = GlobalesVariable.PdsSandales;
                double poidsModifie = poids * Convert.ToDouble(nudSndles.Value);
                lblPdsSndles.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudChssuresCuir_ValueChanged(object sender, EventArgs e)
        {
            if (nudChssuresCuir.Value == 0)
            {
                chkChssuresCuir.Visible = false;
                double poids = GlobalesVariable.PdsChaussuresCuir;
                double poidsModifie = poids * Convert.ToDouble(nudChssuresCuir.Value);
                lblPdsChssuresCuir.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudChssuresCuir.Value > 0)
            {
                chkChssuresCuir.Visible = true;
                double poids = GlobalesVariable.PdsChaussuresCuir;
                double poidsModifie = poids * Convert.ToDouble(nudChssuresCuir.Value);
                lblPdsChssuresCuir.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudEcu_ValueChanged(object sender, EventArgs e)
        {
            if (nudEcu.Value == 0)
            {
                chkEcu.Visible = false;
                double poids = GlobalesVariable.PdsEcu;
                double poidsModifie = poids * Convert.ToDouble(nudEcu.Value);
                lblPdsEcu.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudEcu.Value > 0)
            {
                chkEcu.Visible = true;
                double poids = GlobalesVariable.PdsEcu;
                double poidsModifie = poids * Convert.ToDouble(nudEcu.Value);
                lblPdsEcu.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudPvois_ValueChanged(object sender, EventArgs e)
        {
            if (nudPvois.Value == 0)
            {
                chkPvois.Visible = false;
                double poids = GlobalesVariable.PdsPavois;
                double poidsModifie = poids * Convert.ToDouble(nudPvois.Value);
                lblPdsPvois.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudPvois.Value > 0)
            {
                chkPvois.Visible = true;
                double poids = GlobalesVariable.PdsPavois;
                double poidsModifie = poids * Convert.ToDouble(nudPvois.Value);
                lblPdsPvois.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudBclrAmde_ValueChanged(object sender, EventArgs e)
        {
            if (nudBclrAmde.Value == 0)
            {
                chkBclrAmde.Visible = false;
                double poids = GlobalesVariable.PdsBouclierAmande;
                double poidsModifie = poids * Convert.ToDouble(nudBclrAmde.Value);
                lblPdsBclrAmde.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudBclrAmde.Value > 0)
            {
                chkBclrAmde.Visible = true;
                double poids = GlobalesVariable.PdsBouclierAmande;
                double poidsModifie = poids * Convert.ToDouble(nudBclrAmde.Value);
                lblPdsBclrAmde.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudBclrBze_ValueChanged(object sender, EventArgs e)
        {
            if (nudBclrBze.Value == 0)
            {
                chkBclrBze.Visible = false;
                double poids = GlobalesVariable.PdsBouclierBronze;
                double poidsModifie = poids * Convert.ToDouble(nudBclrBze.Value);
                lblPdsBclrBze.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudBclrBze.Value > 0)
            {
                chkBclrBze.Visible = true;
                double poids = GlobalesVariable.PdsBouclierBronze;
                double poidsModifie = poids * Convert.ToDouble(nudBclrBze.Value);
                lblPdsBclrBze.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudPlta_ValueChanged(object sender, EventArgs e)
        {
            if (nudPlta.Value == 0)
            {
                chkPlta.Visible = false;
                double poids = GlobalesVariable.PdsPelta;
                double poidsModifie = poids * Convert.ToDouble(nudPlta.Value);
                lblPdsPlta.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudPlta.Value > 0)
            {
                chkPlta.Visible = true;
                double poids = GlobalesVariable.PdsPelta;
                double poidsModifie = poids * Convert.ToDouble(nudPlta.Value);
                lblPdsPlta.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudTrche_ValueChanged(object sender, EventArgs e)
        {
            if (nudTrche.Value == 0)
            {
                chkTrche.Visible = false;
                double poids = GlobalesVariable.PdsTorche;
                double poidsModifie = poids * Convert.ToDouble(nudTrche.Value);
                lblPdsTrche.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudTrche.Value > 0)
            {
                chkTrche.Visible = true;
                double poids = GlobalesVariable.PdsTorche;
                double poidsModifie = poids * Convert.ToDouble(nudTrche.Value);
                lblPdsTrche.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudCrde_ValueChanged(object sender, EventArgs e)
        {
            if (nudCrde.Value == 0)
            {
                chkCrde.Visible = false;
                double poids = GlobalesVariable.PdsCorde;
                double poidsModifie = poids * Convert.ToDouble(nudCrde.Value);
                lblPdsCrde.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudCrde.Value > 0)
            {
                chkCrde.Visible = true;
                double poids = GlobalesVariable.PdsCorde;
                double poidsModifie = poids * Convert.ToDouble(nudCrde.Value);
                lblPdsCrde.Text = poidsModifie.ToString() + " kg";
            }
        }

        private void nudOte_ValueChanged(object sender, EventArgs e)
        {
            if (nudOte.Value == 0)
            {
                chkOte.Visible = false;
                double poids = GlobalesVariable.PdsOutre;
                double poidsModifie = poids * Convert.ToDouble(nudOte.Value);
                lblPdsOte.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudOte.Value > 0)
            {
                chkOte.Visible = true;
                double poids = GlobalesVariable.PdsOutre;
                double poidsModifie = poids * Convert.ToDouble(nudOte.Value);
                lblPdsOte.Text = poidsModifie.ToString() + " kg";
            }
        }
        private void nudSc_ValueChanged(object sender, EventArgs e)
        {
            if (nudSc.Value == 0)
            {
                chkSc.Visible = false;
                double poids = GlobalesVariable.PdsSac;
                double poidsModifie = poids * Convert.ToDouble(nudSc.Value);
                lblPdsSc.Text = poidsModifie.ToString() + " kg(pleine)";
            }
            else if (nudSc.Value > 0)
            {
                chkSc.Visible = true;
                double poids = GlobalesVariable.PdsSac;
                double poidsModifie = poids * Convert.ToDouble(nudSc.Value);
                lblPdsSc.Text = poidsModifie.ToString() + " kg(vide)";
            }
        }
        private void nudTnte_ValueChanged(object sender, EventArgs e)
        {
            if (nudTnte.Value == 0)
            {
                chkTnte.Visible = false;
                double poids = GlobalesVariable.PdsTente;
                double poidsModifie = poids * Convert.ToDouble(nudTnte.Value);
                lblPdsTnte.Text = poidsModifie.ToString() + " kg(pleine)";
            }
            else if (nudTnte.Value > 0)
            {
                chkTnte.Visible = true;
                double poids = GlobalesVariable.PdsTente;
                double poidsModifie = poids * Convert.ToDouble(nudTnte.Value);
                lblPdsTnte.Text = poidsModifie.ToString() + " kg(vide)";
            }
        }
        #endregion
    }
}
