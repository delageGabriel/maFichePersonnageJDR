using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Classes
{
    public class FormConverter : UriTypeConverter
    {

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                string[] parts = ((string)value).Split(new char[] { ',' });
                Formulaires.FormulaireTalentsEtObjets frm = new Formulaires.FormulaireTalentsEtObjets();
                return frm;
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}
