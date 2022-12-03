﻿using System;
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
                nudScrmx.Enabled = true;
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
                nudEpCrte.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkEpCrte.Checked)
            {
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
                nudGgdne.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkGgdne.Checked)
            {
                nudGgdne.Enabled = true;
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
                nudJvline.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkJvline.Checked)
            {
                nudJvline.Enabled = true;
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
                nudLnce.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkLnce.Checked)
            {
                nudLnce.Enabled = true;
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
        private void chkCpeCuir_Click(object sender, EventArgs e)
        {
            string strTemp = lblCpeCuir.Text + " " + lblPdsCpeCuir.Text + " " + nudCpeCuir.Value.ToString() + " " + lblEftsCpeCuir.Text;
            if (chkCpeCuir.Checked)
            {
                nudCpeCuir.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCpeCuir.Checked)
            {
                nudCpeCuir.Enabled = true;
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
            string strTemp = lblTrche.Text + " " + lblPdsTrche.Text + " " + lblLgrTrche.Text + " " + nudTrche.Value.ToString() + " " + lblEftsTrche.Text;
            if (chkTrche.Checked)
            {
                nudTrche.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkTrche.Checked)
            {
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
            string strTemp = lblCrde.Text + " " + lblPdsCrde.Text + " " + lblLgrCrde.Text + " " + nudCrde.Value.ToString() + " " + lblEftsCrde.Text;
            if (chkCrde.Checked)
            {
                nudCrde.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkCrde.Checked)
            {
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
            string strTemp = lblOte.Text + " " + lblPdsOte.Text + " " + lblLgrOte.Text + " " + nudOte.Value.ToString() + " " + lblEftsOte.Text;
            if (chkOte.Checked)
            {
                nudOte.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkOte.Checked)
            {
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
            string strTemp = lblSc.Text + " " + lblPdsSc.Text + " " + lblLgrSc.Text + " " + nudSc.Value.ToString() + " " + lblEftsSc.Text;
            if (chkSc.Checked)
            {
                nudSc.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkSc.Checked)
            {
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
            string strTemp = lblTnte.Text + " " + lblPdsTnte.Text + " " + lblLgrTnte.Text + " " + nudTnte.Value.ToString() + " " + lblEftsTnte.Text;
            if (chkTnte.Checked)
            {
                nudTnte.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkTnte.Checked)
            {
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
        #endregion
    }
}
