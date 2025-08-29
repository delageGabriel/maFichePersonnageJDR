using System.Linq;
using maFichePersonnageJDR.Classe;
using maFichePersonnageJDR.Controller;
using maFichePersonnageJDR.View.Formulaires;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace maFichePersonnageJDR.View.Formulaires
{
    public partial class FrmCreationArmure : Form
    {
        public FrmCreationArmure()
        {
            InitializeComponent();
        }

        public void GetAllMateriauxByCategorie()
        {
            Console.WriteLine("########### Classe : FormulaireEquipments; Méthode : GetAllMateriauxByCategorie; ###########");

            try
            {
                Dictionary<string, Model.MateriauxModel> dictionnaireMateriauxCateg = MateriauxController.GetAllMateriauNameAndCategorie();

                if (dictionnaireMateriauxCateg != null)
                {
                    foreach (var materiaux in dictionnaireMateriauxCateg.Values)
                    {
                        if (materiaux.Categorie == "Transformé")
                            lstBxTransformes.Items.Add(materiaux.NomMateriau);
                        else if (materiaux.Categorie == "Métaux")
                            lstBxMetaux.Items.Add(materiaux.NomMateriau);
                        else if (materiaux.Categorie == "Minerai")
                            lstBxMinerais.Items.Add(materiaux.NomMateriau);
                        else if (materiaux.Categorie == "Animal")
                            lstBxAnimaux.Items.Add(materiaux.NomMateriau);
                        else
                            break;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void FrmCreationArmure_Load(object sender, EventArgs e)
        {
            GetAllMateriauxByCategorie();
        }
    }
}
