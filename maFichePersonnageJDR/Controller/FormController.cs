using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Controller
{
    class FormController
    {
        public static void CreateAndPlaceControlInTabPage(TabPage tabPage, Control control, int positionX, int positionY, string nomControl, string content)
        {
            control.Text = content;
            control.Location = new System.Drawing.Point(positionX, positionY);
            control.Name = nomControl;

            tabPage.Controls.Add(control);
        }
    }
}
