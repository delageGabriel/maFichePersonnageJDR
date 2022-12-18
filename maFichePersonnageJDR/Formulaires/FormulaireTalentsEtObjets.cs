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

        private string[] tableauInventaire = {"Scramasax"
                , "Épée courte"
                , "Épée longue"
                , "Glaive"
                , "Latte"
                , "Sabre courbé"
                , "Contus"
                , "Javelot"
                , "Fourche"
                , "Sarisse"
                , "Trident"
                , "Couteau"
                , "Dague"
                , "Faucille de guerre"
                , "Dague d'assassin"
                , "Francisque"
                , "Arc"
                , "Arbalète"
                , "Fronde"
                , "Fouet"
                , "Faucille à chaîne"
                , "Bâton de chêne"
                , "Sceptre"
                , "Spangenlhem"
                , "Coiffe de mailles"
                , "Morion"
                , "Cervelière"
                , "Chapel de fer"
                , "Casque barbare"
                , "Vêtements"
                , "Broigne"
                , "Cataphracte"
                , "Cuirasse de fer"
                , "Robe de cuir"
                , "Cuirasse de bronze"
                , "Gants de mailles"
                , "Gantelets"
                , "Mitaines"
                , "Mitons"
                , "Cuissardes de fer"
                , "Pantalon de toile"
                , "Cnémide"
                , "Sandales"
                , "Chaussures de cuir"
                , "Écu"
                , "Pavois"
                , "Bouclier en amande"
                , "Bouclier de bronze"
                , "Pelta"
                , "Torche"
                , "Corde"
                , "Outre"
                , "Sac"
                , "Tente"};
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
            Properties.Settings.Default.VNScramasax = Convert.ToInt32(nudScrmx.Value);
            Properties.Settings.Default.VNEpeeCourte = Convert.ToInt32(nudEpCrte.Value);
            Properties.Settings.Default.VNEpeeLongue = Convert.ToInt32(nudEpLge.Value);
            Properties.Settings.Default.VNGlaive = Convert.ToInt32(nudGlve.Value);
            Properties.Settings.Default.VNLatte = Convert.ToInt32(nudLte.Value);
            Properties.Settings.Default.VNSabreCourbe = Convert.ToInt32(nudSbreCrbe.Value);
            Properties.Settings.Default.VNContus = Convert.ToInt32(nudCntus.Value);
            Properties.Settings.Default.VNJavelot = Convert.ToInt32(nudJvlot.Value);
            Properties.Settings.Default.VNFourche = Convert.ToInt32(nudFrche.Value);
            Properties.Settings.Default.VNSarisse = Convert.ToInt32(nudSrse.Value);
            Properties.Settings.Default.VNTrident = Convert.ToInt32(nudTrdnt.Value);
            Properties.Settings.Default.VNCouteau = Convert.ToInt32(nudCtau.Value);
            Properties.Settings.Default.VNDague = Convert.ToInt32(nudDge.Value);
            Properties.Settings.Default.VNFaucilleGuerre = Convert.ToInt32(nudFclGure.Value);
            Properties.Settings.Default.VNDagueAssassin = Convert.ToInt32(nudDgeAssin.Value);
            Properties.Settings.Default.VNFrancisque = Convert.ToInt32(nudFrncsque.Value);
            Properties.Settings.Default.VNArc = Convert.ToInt32(nudArc.Value);
            Properties.Settings.Default.VNArbalete = Convert.ToInt32(nudAblte.Value);
            Properties.Settings.Default.VNFronde = Convert.ToInt32(nudFnde.Value);
            Properties.Settings.Default.VNFouet = Convert.ToInt32(nudFouet.Value);
            Properties.Settings.Default.VNFaucilleChaine = Convert.ToInt32(nudFaC.Value);
            Properties.Settings.Default.VNBatonChene = Convert.ToInt32(nudBtonChne.Value);
            Properties.Settings.Default.VNSceptre = Convert.ToInt32(nudSctre.Value);
            Properties.Settings.Default.VNSpangenhelm = Convert.ToInt32(nudSpghlm.Value);
            Properties.Settings.Default.VNCoiffeMailles = Convert.ToInt32(nudCfeMle.Value);
            Properties.Settings.Default.VNMorion = Convert.ToInt32(nudMrn.Value);
            Properties.Settings.Default.VNCerveliere = Convert.ToInt32(nudCrvlre.Value);
            Properties.Settings.Default.VNChapelFer = Convert.ToInt32(nudChplFr.Value);
            Properties.Settings.Default.VNCasqueBarbare = Convert.ToInt32(nudCsqueBrbre.Value);
            Properties.Settings.Default.VNVetements = Convert.ToInt32(nudVtments.Value);
            Properties.Settings.Default.VNBroigne = Convert.ToInt32(nudBrgne.Value);
            Properties.Settings.Default.VNCataphracte = Convert.ToInt32(nudCtphrcte.Value);
            Properties.Settings.Default.VNCuirasseFer = Convert.ToInt32(nudCrsFr.Value);
            Properties.Settings.Default.VNRobeCuir = Convert.ToInt32(nudRbeCuir.Value);
            Properties.Settings.Default.VNCuirasseBronze = Convert.ToInt32(nudCrsBze.Value);
            Properties.Settings.Default.VNGantsMailles = Convert.ToInt32(nudGntMles.Value);
            Properties.Settings.Default.VNGantelets = Convert.ToInt32(nudGntlet.Value);
            Properties.Settings.Default.VNMitaines = Convert.ToInt32(nudMitne.Value);
            Properties.Settings.Default.VNMitons = Convert.ToInt32(nudMton.Value);
            Properties.Settings.Default.VNCuirasseFer = Convert.ToInt32(nudCuissrd.Value);
            Properties.Settings.Default.VNPantalonToile = Convert.ToInt32(nudPntlonTle.Value);
            Properties.Settings.Default.VNCnemide = Convert.ToInt32(nudCmide.Value);
            Properties.Settings.Default.VNSandales = Convert.ToInt32(nudSndles.Value);
            Properties.Settings.Default.VNChaussuresCuir = Convert.ToInt32(nudChssuresCuir.Value);
            Properties.Settings.Default.VNEcu = Convert.ToInt32(nudEcu.Value);
            Properties.Settings.Default.VNPavois = Convert.ToInt32(nudPvois.Value);
            Properties.Settings.Default.VNBouclierAmande = Convert.ToInt32(nudBclrAmde.Value);
            Properties.Settings.Default.VNBouclierBronze = Convert.ToInt32(nudBclrBze.Value);
            Properties.Settings.Default.VNPelta = Convert.ToInt32(nudPlta.Value);
            Properties.Settings.Default.VNTorche = Convert.ToInt32(nudTrche.Value);
            Properties.Settings.Default.VNCorde = Convert.ToInt32(nudCrde.Value);
            Properties.Settings.Default.VNOutre = Convert.ToInt32(nudOte.Value);
            Properties.Settings.Default.VNSac = Convert.ToInt32(nudSc.Value);
            Properties.Settings.Default.VNTente = Convert.ToInt32(nudTnte.Value);
            Properties.Settings.Default.Save();
        }

        public void GetSettings()
        {
            nudScrmx.Value = Properties.Settings.Default.VNScramasax;
            nudEpCrte.Value = Properties.Settings.Default.VNEpeeCourte;
            nudEpLge.Value = Properties.Settings.Default.VNEpeeLongue;
            nudGlve.Value = Properties.Settings.Default.VNGlaive;
            nudLte.Value = Properties.Settings.Default.VNLatte;
            nudSbreCrbe.Value = Properties.Settings.Default.VNSabreCourbe;
            nudCntus.Value = Properties.Settings.Default.VNContus;
            nudJvlot.Value = Properties.Settings.Default.VNJavelot;
            nudFrche.Value = Properties.Settings.Default.VNFourche;
            nudSrse.Value = Properties.Settings.Default.VNSarisse;
            nudTrdnt.Value = Properties.Settings.Default.VNTrident;
            nudCtau.Value = Properties.Settings.Default.VNCouteau;
            nudFclGure.Value = Properties.Settings.Default.VNFaucilleGuerre;
            nudDgeAssin.Value = Properties.Settings.Default.VNDagueAssassin;
            nudFrncsque.Value = Properties.Settings.Default.VNFrancisque;
            nudArc.Value = Properties.Settings.Default.VNArc;
            nudAblte.Value = Properties.Settings.Default.VNArbalete;
            nudFnde.Value = Properties.Settings.Default.VNFronde;
            nudFouet.Value = Properties.Settings.Default.VNFouet;
            nudFaC.Value = Properties.Settings.Default.VNFaucilleChaine;
            nudBtonChne.Value = Properties.Settings.Default.VNBatonChene;
            nudSctre.Value = Properties.Settings.Default.VNSceptre;
            nudSpghlm.Value = Properties.Settings.Default.VNSpangenhelm;
            nudCfeMle.Value = Properties.Settings.Default.VNCoiffeMailles;
            nudMrn.Value = Properties.Settings.Default.VNMorion;
            nudCrvlre.Value = Properties.Settings.Default.VNCerveliere;
            nudChplFr.Value = Properties.Settings.Default.VNChapelFer;
            nudCsqueBrbre.Value = Properties.Settings.Default.VNCasqueBarbare;
            nudVtments.Value = Properties.Settings.Default.VNVetements;
            nudBrgne.Value = Properties.Settings.Default.VNBroigne;
            nudCtphrcte.Value = Properties.Settings.Default.VNCataphracte;
            nudCrsFr.Value = Properties.Settings.Default.VNCuirasseFer;
            nudRbeCuir.Value = Properties.Settings.Default.VNRobeCuir;
            nudCrsBze.Value = Properties.Settings.Default.VNCuirasseBronze;
            nudGntMles.Value = Properties.Settings.Default.VNGantsMailles;
            nudGntlet.Value = Properties.Settings.Default.VNGantelets;
            nudMitne.Value = Properties.Settings.Default.VNMitaines;
            nudMton.Value = Properties.Settings.Default.VNMitons;
            nudCuissrd.Value = Properties.Settings.Default.VNCuissardesFer;
            nudPntlonTle.Value = Properties.Settings.Default.VNPantalonToile;
            nudCmide.Value = Properties.Settings.Default.VNCnemide;
            nudSndles.Value = Properties.Settings.Default.VNSandales;
            nudChssuresCuir.Value = Properties.Settings.Default.VNChaussuresCuir;
            nudEcu.Value = Properties.Settings.Default.VNEcu;
            nudPvois.Value = Properties.Settings.Default.VNPavois;
            nudBclrAmde.Value = Properties.Settings.Default.VNBouclierAmande;
            nudBclrBze.Value = Properties.Settings.Default.VNBouclierBronze;
            nudPlta.Value = Properties.Settings.Default.VNPelta;
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
        #region Clique_chk_sortileges
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
        #region Boutons_vider
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

        /// <summary>
        /// Groupe de méthode qui permet d'extraire avec précision
        /// le Name des label et du numericUpDown en fouillant dans
        /// les pages à l'aide d'une boucle foreach et le retourne
        /// une méthode récupère aussi le numericUpDown avec le
        /// même
        /// </summary>
        /// <param name="tagObjet">partie extraite du nom d'un objet</param>
        /// <returns></returns>
        #region Get_Champs_Objets_Inventaire
        public string GetNomObjet(string tagObjet)
        {
            string strReturn = string.Empty;
            foreach (TabPage tabPagesArmes in tcArmes.Controls)
            {
                foreach (object tpControlsArmes in tabPagesArmes.Controls)
                {
                    if (tpControlsArmes is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsArmes;

                        if (label.Name.StartsWith("lblNom") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (TabPage tabPagesArmures in tcArmure.Controls)
                {
                    foreach (object tpControlsArmures in tabPagesArmures.Controls)
                    {
                        if (tpControlsArmures is Label)
                        {
                            Label label = new Label();
                            label = (Label)tpControlsArmures;

                            if (label.Name.StartsWith("lblNom") && label.Name.EndsWith(tagObjet))
                            {
                                strReturn = label.Text;
                            }
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (object tpControlsObjets in tpObjets.Controls)
                {
                    if (tpControlsObjets is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsObjets;

                        if (label.Name.StartsWith("lblNom") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            return strReturn;
        }

        public string GetPoidsObjet(string tagObjet)
        {
            string strReturn = string.Empty;
            foreach (TabPage tabPagesArmes in tcArmes.Controls)
            {
                foreach (object tpControlsArmes in tabPagesArmes.Controls)
                {
                    if (tpControlsArmes is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsArmes;

                        if (label.Name.StartsWith("lblPds") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (TabPage tabPagesArmures in tcArmure.Controls)
                {
                    foreach (object tpControlsArmures in tabPagesArmures.Controls)
                    {
                        if (tpControlsArmures is Label)
                        {
                            Label label = new Label();
                            label = (Label)tpControlsArmures;

                            if (label.Name.StartsWith("lblPds") && label.Name.EndsWith(tagObjet))
                            {
                                strReturn = label.Text;
                            }
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (object tpControlsObjets in tpObjets.Controls)
                {
                    if (tpControlsObjets is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsObjets;

                        if (label.Name.StartsWith("lblPds") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            return strReturn;
        }

        public string GetPorteeObjet(string tagObjet)
        {
            string strReturn = string.Empty;
            foreach (TabPage tabPagesArmes in tcArmes.Controls)
            {
                foreach (object tpControlsArmes in tabPagesArmes.Controls)
                {
                    if (tpControlsArmes is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsArmes;

                        if (label.Name.StartsWith("lblPrte") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (TabPage tabPagesArmures in tcArmure.Controls)
                {
                    foreach (object tpControlsArmures in tabPagesArmures.Controls)
                    {
                        if (tpControlsArmures is Label)
                        {
                            Label label = new Label();
                            label = (Label)tpControlsArmures;

                            if (label.Name.StartsWith("lblPrte") && label.Name.EndsWith(tagObjet))
                            {
                                strReturn = label.Text;
                            }
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (object tpControlsObjets in tpObjets.Controls)
                {
                    if (tpControlsObjets is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsObjets;

                        if (label.Name.StartsWith("lblPrte") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            return strReturn;
        }

        public string GetQuantiteObjet(string tagObjet)
        {
            string strReturn = string.Empty;
            foreach (TabPage tabPagesArmes in tcArmes.Controls)
            {
                foreach (object tpControlsArmes in tabPagesArmes.Controls)
                {
                    if (tpControlsArmes is NumericUpDown)
                    {
                        NumericUpDown numeric = new NumericUpDown();
                        numeric = (NumericUpDown)tpControlsArmes;

                        if (numeric.Name.StartsWith("nud") && numeric.Name.EndsWith(tagObjet))
                        {
                            strReturn = numeric.Value.ToString();
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (TabPage tabPagesArmures in tcArmure.Controls)
                {
                    foreach (object tpControlsArmures in tabPagesArmures.Controls)
                    {
                        if (tpControlsArmures is NumericUpDown)
                        {
                            NumericUpDown numeric = new NumericUpDown();
                            numeric = (NumericUpDown)tpControlsArmures;

                            if (numeric.Name.StartsWith("nud") && numeric.Name.EndsWith(tagObjet))
                            {
                                strReturn = numeric.Value.ToString();
                            }
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (object tpControlsObjets in tpObjets.Controls)
                {
                    if (tpControlsObjets is NumericUpDown)
                    {
                        NumericUpDown numeric = new NumericUpDown();
                        numeric = (NumericUpDown)tpControlsObjets;

                        if (numeric.Name.StartsWith("nud") && numeric.Name.EndsWith(tagObjet))
                        {
                            strReturn = numeric.Value.ToString(); ;
                        }
                    }
                }
            }
            return strReturn;
        }

        public NumericUpDown GetNudObjet(string tagObjet)
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            foreach (TabPage tabPagesArmes in tcArmes.Controls)
            {
                foreach (object tpControlsArmes in tabPagesArmes.Controls)
                {
                    if (tpControlsArmes is NumericUpDown)
                    {
                        NumericUpDown numeric = new NumericUpDown();
                        numeric = (NumericUpDown)tpControlsArmes;

                        if (numeric.Name.StartsWith("nud") && numeric.Name.EndsWith(tagObjet))
                        {
                            numericUpDown = numeric;
                        }
                    }
                }
            }
            if (numericUpDown == null)
            {
                foreach (TabPage tabPagesArmures in tcArmure.Controls)
                {
                    foreach (object tpControlsArmures in tabPagesArmures.Controls)
                    {
                        if (tpControlsArmures is NumericUpDown)
                        {
                            NumericUpDown numeric = new NumericUpDown();
                            numeric = (NumericUpDown)tpControlsArmures;

                            if (numeric.Name.StartsWith("nud") && numeric.Name.EndsWith(tagObjet))
                            {
                                numericUpDown = numeric;
                            }
                        }
                    }
                }
            }
            if (numericUpDown == null)
            {
                foreach (object tpControlsObjets in tpObjets.Controls)
                {
                    if (tpControlsObjets is NumericUpDown)
                    {
                        NumericUpDown numeric = new NumericUpDown();
                        numeric = (NumericUpDown)tpControlsObjets;

                        if (numeric.Name.StartsWith("nud") && numeric.Name.EndsWith(tagObjet))
                        {
                            numericUpDown = numeric;
                        }
                    }
                }
            }
            return numericUpDown;
        }
        public string GetTypeObjet(string tagObjet)
        {
            string strReturn = string.Empty;
            foreach (TabPage tabPagesArmes in tcArmes.Controls)
            {
                foreach (object tpControlsArmes in tabPagesArmes.Controls)
                {
                    if (tpControlsArmes is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsArmes;

                        if (label.Name.StartsWith("lblTpe") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (TabPage tabPagesArmures in tcArmure.Controls)
                {
                    foreach (object tpControlsArmures in tabPagesArmures.Controls)
                    {
                        if (tpControlsArmures is Label)
                        {
                            Label label = new Label();
                            label = (Label)tpControlsArmures;

                            if (label.Name.StartsWith("lblTpe") && label.Name.EndsWith(tagObjet))
                            {
                                strReturn = label.Text;
                            }
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (object tpControlsObjets in tpObjets.Controls)
                {
                    if (tpControlsObjets is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsObjets;

                        if (label.Name.StartsWith("lblTpe") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            return strReturn;
        }

        public string GetDegatsObjet(string tagObjet)
        {
            string strReturn = string.Empty;
            foreach (TabPage tabPagesArmes in tcArmes.Controls)
            {
                foreach (object tpControlsArmes in tabPagesArmes.Controls)
                {
                    if (tpControlsArmes is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsArmes;

                        if (label.Name.StartsWith("lblDgts") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (TabPage tabPagesArmures in tcArmure.Controls)
                {
                    foreach (object tpControlsArmures in tabPagesArmures.Controls)
                    {
                        if (tpControlsArmures is Label)
                        {
                            Label label = new Label();
                            label = (Label)tpControlsArmures;

                            if (label.Name.StartsWith("lblDgts") && label.Name.EndsWith(tagObjet))
                            {
                                strReturn = label.Text;
                            }
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (object tpControlsObjets in tpObjets.Controls)
                {
                    if (tpControlsObjets is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsObjets;

                        if (label.Name.StartsWith("lblDgts") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            return strReturn;
        }

        public string GetValeursObjet(string tagObjet)
        {
            string strReturn = string.Empty;
            foreach (TabPage tabPagesArmes in tcArmes.Controls)
            {
                foreach (object tpControlsArmes in tabPagesArmes.Controls)
                {
                    if (tpControlsArmes is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsArmes;

                        if (label.Name.StartsWith("lblVleur") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (TabPage tabPagesArmures in tcArmure.Controls)
                {
                    foreach (object tpControlsArmures in tabPagesArmures.Controls)
                    {
                        if (tpControlsArmures is Label)
                        {
                            Label label = new Label();
                            label = (Label)tpControlsArmures;

                            if (label.Name.StartsWith("lblVleur") && label.Name.EndsWith(tagObjet))
                            {
                                strReturn = label.Text;
                            }
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (object tpControlsObjets in tpObjets.Controls)
                {
                    if (tpControlsObjets is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsObjets;

                        if (label.Name.StartsWith("lblVleur") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            return strReturn;
        }

        public string GetProprieteObjet(string tagObjet)
        {
            string strReturn = string.Empty;
            foreach (TabPage tabPagesArmes in tcArmes.Controls)
            {
                foreach (object tpControlsArmes in tabPagesArmes.Controls)
                {
                    if (tpControlsArmes is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsArmes;

                        if (label.Name.StartsWith("lblPrpiete") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (TabPage tabPagesArmures in tcArmure.Controls)
                {
                    foreach (object tpControlsArmures in tabPagesArmures.Controls)
                    {
                        if (tpControlsArmures is Label)
                        {
                            Label label = new Label();
                            label = (Label)tpControlsArmures;

                            if (label.Name.StartsWith("lblPrpiete") && label.Name.EndsWith(tagObjet))
                            {
                                strReturn = label.Text;
                            }
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (object tpControlsObjets in tpObjets.Controls)
                {
                    if (tpControlsObjets is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsObjets;

                        if (label.Name.StartsWith("lblPrpiete") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            return strReturn;
        }

        public string GetEffetsObjet(string tagObjet)
        {
            string strReturn = string.Empty;
            foreach (TabPage tabPagesArmes in tcArmes.Controls)
            {
                foreach (object tpControlsArmes in tabPagesArmes.Controls)
                {
                    if (tpControlsArmes is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsArmes;

                        if (label.Name.StartsWith("lblEfts") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (TabPage tabPagesArmures in tcArmure.Controls)
                {
                    foreach (object tpControlsArmures in tabPagesArmures.Controls)
                    {
                        if (tpControlsArmures is Label)
                        {
                            Label label = new Label();
                            label = (Label)tpControlsArmures;

                            if (label.Name.StartsWith("lblEfts") && label.Name.EndsWith(tagObjet))
                            {
                                strReturn = label.Text;
                            }
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (object tpControlsObjets in tpObjets.Controls)
                {
                    if (tpControlsObjets is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsObjets;

                        if (label.Name.StartsWith("lblEfts") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            return strReturn;
        }

        public string GetTailleObjet(string tagObjet)
        {
            string strReturn = string.Empty;
            foreach (TabPage tabPagesArmes in tcArmes.Controls)
            {
                foreach (object tpControlsArmes in tabPagesArmes.Controls)
                {
                    if (tpControlsArmes is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsArmes;

                        if (label.Name.StartsWith("lblTlle") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (TabPage tabPagesArmures in tcArmure.Controls)
                {
                    foreach (object tpControlsArmures in tabPagesArmures.Controls)
                    {
                        if (tpControlsArmures is Label)
                        {
                            Label label = new Label();
                            label = (Label)tpControlsArmures;

                            if (label.Name.StartsWith("lblTlle") && label.Name.EndsWith(tagObjet))
                            {
                                strReturn = label.Text;
                            }
                        }
                    }
                }
            }
            if (String.IsNullOrEmpty(strReturn))
            {
                foreach (object tpControlsObjets in tpObjets.Controls)
                {
                    if (tpControlsObjets is Label)
                    {
                        Label label = new Label();
                        label = (Label)tpControlsObjets;

                        if (label.Name.StartsWith("lblTlle") && label.Name.EndsWith(tagObjet))
                        {
                            strReturn = label.Text;
                        }
                    }
                }
            }
            return strReturn;
        }
        #endregion
        #region Numeric_inventaires
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

        private void nudDgeAssin_ValueChanged(object sender, EventArgs e)
        {
            if (nudDgeAssin.Value == 0)
            {
                chkDgeAssin.Visible = false;
                double poids = GlobalesVariable.PdsDagueAssassin;
                double poidsModifie = poids * Convert.ToDouble(nudDgeAssin.Value);
                lblPdsDgeAssin.Text = poidsModifie.ToString() + " kg";
            }
            else if (nudDgeAssin.Value > 0)
            {
                chkDgeAssin.Visible = true;
                double poids = GlobalesVariable.PdsDagueAssassin;
                double poidsModifie = poids * Convert.ToDouble(nudDgeAssin.Value);
                lblPdsDgeAssin.Text = poidsModifie.ToString() + " kg";
            }
        }
        #endregion

        /// <summary>
        /// Méthode qui permet d'ajouter ou de retirer une ligne
        /// de la richtextbox inventaire en cliquant sur la 
        /// checkbox associée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkAddOrDeleteItem_click(object sender, EventArgs e)
        {
            string strTemp = string.Empty;
            CheckBox chkName = (CheckBox)sender;
            string tagEvenement = chkName.Name.Substring(3);
            NumericUpDown nudEvenement = GetNudObjet(tagEvenement);
            string nomEvenement = GetNomObjet(tagEvenement);
            string pdsEvenement = GetPoidsObjet(tagEvenement);
            string porteeEvenement = GetPorteeObjet(tagEvenement);
            string qteEvenement = GetQuantiteObjet(tagEvenement);
            string typeEvenement = GetTypeObjet(tagEvenement);
            string degatsEvenement = GetDegatsObjet(tagEvenement);
            string valeurEvenement = GetValeursObjet(tagEvenement);
            string proprieteEvenement = GetProprieteObjet(tagEvenement);
            string effetsEvenement = GetEffetsObjet(tagEvenement);
            string tailleEvenement = GetTailleObjet(tagEvenement);
            if (!String.IsNullOrEmpty(tailleEvenement))
            {
                strTemp = GlobalesVariable.Nom + nomEvenement + GlobalesVariable.Poids + pdsEvenement
                    + GlobalesVariable.Taille + tailleEvenement + GlobalesVariable.Quantite + qteEvenement
                    + GlobalesVariable.Effets + effetsEvenement + GlobalesVariable.Valeur + valeurEvenement;
            }
            else if (!String.IsNullOrEmpty(degatsEvenement) && !String.IsNullOrEmpty(porteeEvenement)
                && !String.IsNullOrEmpty(effetsEvenement) && !String.IsNullOrEmpty(proprieteEvenement))
            {
                strTemp = GlobalesVariable.Nom + nomEvenement + GlobalesVariable.Poids + pdsEvenement
                                + GlobalesVariable.Portee + porteeEvenement + GlobalesVariable.Quantite + qteEvenement
                                + GlobalesVariable.Type + typeEvenement + GlobalesVariable.Degats + degatsEvenement
                                + GlobalesVariable.Effets + effetsEvenement + GlobalesVariable.Valeur + valeurEvenement
                                + GlobalesVariable.Propriete + proprieteEvenement;
            }
            else if (!String.IsNullOrEmpty(effetsEvenement) && String.IsNullOrEmpty(degatsEvenement)
                && String.IsNullOrEmpty(porteeEvenement))
            {
                strTemp = GlobalesVariable.Nom + nomEvenement + GlobalesVariable.Poids + pdsEvenement
                    + GlobalesVariable.Quantite + qteEvenement + GlobalesVariable.Effets + effetsEvenement
                    + GlobalesVariable.Valeur + valeurEvenement + GlobalesVariable.Propriete + proprieteEvenement;
            }
            else if (!String.IsNullOrEmpty(degatsEvenement) && !String.IsNullOrEmpty(porteeEvenement))
            {
                strTemp = GlobalesVariable.Nom + nomEvenement + GlobalesVariable.Poids + pdsEvenement
                                + GlobalesVariable.Portee + porteeEvenement + GlobalesVariable.Quantite + qteEvenement
                                + GlobalesVariable.Type + typeEvenement + GlobalesVariable.Degats + degatsEvenement
                                + GlobalesVariable.Valeur + valeurEvenement + GlobalesVariable.Propriete + proprieteEvenement;
            }
            if (chkName.Checked)
            {
                nudEvenement.Enabled = false;
                rchTxtIvtaires.Text += String.IsNullOrEmpty(rchTxtIvtaires.Text) ? strTemp : "\n" + strTemp;
            }
            else if (!chkName.Checked)
            {
                for (int i = 0; i < rchTxtIvtaires.Lines.Length; i++)
                {
                    if (strTemp == rchTxtIvtaires.Lines[i])
                    {
                        strTemp = rchTxtIvtaires.Lines[i];
                    }
                }
                nudEvenement.Enabled = true;
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
