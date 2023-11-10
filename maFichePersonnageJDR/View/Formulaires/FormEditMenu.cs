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

namespace maFichePersonnageJDR.View.Formulaires
{
    public partial class FormEditMenu : Form
    {
        public FormEditMenu()
        {
            InitializeComponent();
        }

        private void btnInfosGenerales_Click(object sender, EventArgs e)
        {
            FormulaireInfosGenerales formulaireInfosGenerales = new FormulaireInfosGenerales();
            formulaireInfosGenerales.Show();
            this.Hide();
        }

        private void btnAttributs_Click(object sender, EventArgs e)
        {
            FormulaireAttributs formulaireAttributs = new FormulaireAttributs();
            formulaireAttributs.Show();
        }

        private void btnCompCarac_Click(object sender, EventArgs e)
        {
            FormulaireCompetencesCaracteristiques formulaireCompetencesCaracteristiques = new FormulaireCompetencesCaracteristiques();
            formulaireCompetencesCaracteristiques.Show();
        }

        private void btnEquipement_Click(object sender, EventArgs e)
        {
            FormulaireEquipments formulaireEquipments = new FormulaireEquipments();
            formulaireEquipments.Show();
        }

        private void btnMagiesAptitudes_Click(object sender, EventArgs e)
        {
            FormulaireMagieEtAptitudes formulaireMagieEtAptitudes = new FormulaireMagieEtAptitudes();
            formulaireMagieEtAptitudes.Show();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
