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
using System.IO;
using maFichePersonnageJDR.Classe;
using maFichePersonnageJDR.Controller;
using System.Windows;
using maFichePersonnageJDR.View.Formulaires;

namespace maFichePersonnageJDR
{
    public partial class FrmPrincipal : Form
    {
        public string cheminTemplate = Path.GetFullPath(@"Templates\template_fiche_personnage.docx");
        public string cheminPdf = Path.GetFullPath(@"Templates\template_fiche.pdf");
        public string cheminDocx = Path.GetFullPath(@"Templates\template_fiche.docx");
        public ClasseImage imgAvatar = new ClasseImage();

        int[] tableauBaseNormaleExp = { 0,
            3000,
            9650,
            18490,
            30255,
            45900,
            66710,
            94385,
            131190,
            180145,
            245250,
            331845,
            447015,
            600190,
            803915,
            1074865,
            1435235,
            1914520,
            2551975,
            3399785
        };
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public bool PairOuImpair(int chiffre)
        {
            bool retour = false;

            int[] tableauPair = new int[]{0,
                2,
                4,
                6,
                8,
                10,
                12,
                14,
                16,
                18,
                20,
                22,
                24,
                26,
                28,
                30,
                32,
                34,
                36,
                38,
                40,
                42,
                44,
                46,
                48,
                50,
                52,
                54,
                56,
                58,
                60,
                62,
                64,
                66,
                68,
                70,
                72,
                74,
                76,
                78,
                80
            };

            int[] tableauImpair = new int[]{
                1,
                3,
                5,
                7,
                9,
                11,
                13,
                15,
                17,
                19,
                21,
                23,
                25,
                27,
                29,
                31,
                33,
                35,
                37,
                39,
                41,
                43,
                45,
                47,
                49,
                51,
                53,
                55,
                57,
                59,
                61,
                63,
                65,
                67,
                69,
                71,
                73,
                75,
                77,
                79,
                81
            };

            for (int i = 0; i < tableauPair.Length; i++)
            {
                if (tableauPair[i].Equals(chiffre))
                {
                    retour = true;
                    break;
                }
            }
            for (int i = 0; i < tableauImpair.Length; i++)
            {
                if (tableauImpair[i].Equals(chiffre))
                {
                    retour = false;
                    break;
                }
            }
            return retour;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnInfosGenerales_Click(object sender, EventArgs e)
        {
            FormulaireInfosGenerales frmIG = new FormulaireInfosGenerales();
            frmIG.Show();
        }

        private void btnSoumettreFiche_Click(object sender, EventArgs e)
        {

        }

        private void btnEquipments_Click(object sender, EventArgs e)
        {
            FormulaireEquipments frmEquipment = new FormulaireEquipments();
            frmEquipment.Show();
        }

        private void btnMagieAptitudes_Click(object sender, EventArgs e)
        {
            FormulaireMagieEtAptitudes frmMagieEtAptitudes = new FormulaireMagieEtAptitudes();
            frmMagieEtAptitudes.Show();
        }

        private void btnCreerPersonnage_Click(object sender, EventArgs e)
        {
            //int testCentaine = (2078 / 100) % 100;
            //int testdizaine = (2078 / 10) % 10;
            //int testUnite = 2078 % 10;
            FormulaireInfosGenerales formulaireMenu = new FormulaireInfosGenerales();
            formulaireMenu.Show();
        }
    }
}