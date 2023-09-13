using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maFichePersonnageJDR.Classe
{
    class Utils
    {
        /// <summary>
        /// Permet d'obtenir le numéro de ligne d'un texte à supprimer dans une richtextbox
        /// </summary>
        /// <param name="textToRemove"></param>
        /// <param name="richTextBox"></param>
        /// <returns></returns>
        public static int GetLineNumberToDelete(string textToRemove, RichTextBox richTextBox)
        {
            try
            {
                int indexLineToRemove = 0;

                // FR : On parcourt la liste jusqu'à retrouver la ligne
                // EN : Go through the list until you find the line
                for (int i = 0; i < richTextBox.Lines.Length; i++)
                {
                    if (richTextBox.Lines[i] == textToRemove)
                    {
                        indexLineToRemove = i;
                    }
                }

                return indexLineToRemove;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
