using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Classe
{
    public class ClasseImage
    {
        public Bitmap GetUneImage(string cheminDeLImage)
        {
            Bitmap uneImage = new Bitmap(cheminDeLImage);
            Bitmap imageRedimensionner = new Bitmap(uneImage, new Size(256, 256));
            uneImage = imageRedimensionner;

            return uneImage;
        }
    }
}
