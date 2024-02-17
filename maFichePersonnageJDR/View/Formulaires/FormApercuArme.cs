using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maFichePersonnageJDR.View.Formulaires
{
    public partial class FormApercuArme : Form
    {
        /// <summary>
        /// Setter pour modifier les valeurs des textes du formulaire
        /// pour s'adapter à l'arme.
        /// </summary>
        public string LabelTypeArme { get => lblTypeArme.Text; set => lblTypeArme.Text = value; }
        public string LabelNomArme { get => lblNomArme.Text;  set => lblNomArme.Text = value; }
        public string LabelPoidsArme { get => lblPoidsArme.Text; set => lblPoidsArme.Text = value; }
        public string LabelAllongeArme { get => lblAllongeArme.Text; set => lblAllongeArme.Text = value; }
        public string LabelMainsArme { get => lblMainArme.Text; set => lblMainArme.Text = value; }
        public string LabelValeurArme { get => lblValeurArme.Text; set => lblValeurArme.Text = value; }
        public string TextBoxDegatsTranchant { get => txtDgtsTranchant.Text; set => txtDgtsTranchant.Text = value; }
        public string TextBoxDegatsContondant { get => txtDgtsContondant.Text; set => txtDgtsContondant.Text = value; }
        public string TextBoxDegatsPerforant { get => txtDgtsPerforant.Text; set => txtDgtsPerforant.Text = value; }
        public string TextBoxDegatsIgnee { get => txtDgtsIgnee.Text; set => txtDgtsIgnee.Text = value; }
        public string TextBoxDegatsAquatique { get => txtDgtsAquatique.Text; set => txtDgtsAquatique.Text = value; }
        public string TextBoxDegatsCeleste { get => txtDgtsCeleste.Text; set => txtDgtsCeleste.Text = value; }
        public string TextBoxDegatsTerrestre { get => txtDgtsTerrestre.Text; set => txtDgtsTerrestre.Text = value; }
        public string RichTextBoxSpecial { get => rtbSpecialArme.Text; set => rtbSpecialArme.Text = value; }
        public string RichTextBoxDescription { get => rtbDescriptionArme.Text; set => rtbDescriptionArme.Text = value; }
        public FormApercuArme()
        {
            InitializeComponent();
        }
    }
}
