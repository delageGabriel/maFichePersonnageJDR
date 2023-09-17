using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maFichePersonnageJDR.Controller;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="richTextBox"></param>
        /// <param name="ListOfId"></param>
        /// <param name="indexToSubstring"></param>
        /// <param name="numberCharToSubstring"></param>
        /// <returns></returns>
        public static List<int> AddIdInList(RichTextBox richTextBox, List<int> ListOfId, int indexToSubstring, int numberCharToSubstring, string TableNameToExtract)
        {
            // Parcours de toutes les lignes de la RichTextBox
            foreach (string line in richTextBox.Lines)
            {
                string[] substring = line.Split(',');

                // On s'assure que notre ligne ne soit pas vide
                if (substring.Length > 1)
                {
                    /**
                     * On ajoute les ID dans la liste au cas par cas
                     */
                    if (TableNameToExtract == "ARMES")
                    {
                        ListOfId.Add(Controller.EquipmentController.GetIdArmeByName(substring[indexToSubstring].Substring(numberCharToSubstring).Trim()));
                    }
                    else if(TableNameToExtract == "ARMURES")
                    {
                        ListOfId.Add(Controller.EquipmentController.GetIdArmureByName(substring[indexToSubstring].Substring(numberCharToSubstring).Trim()));
                    }
                    else if(TableNameToExtract == "OBJETS")
                    {
                        ListOfId.Add(Controller.EquipmentController.GetIdObjetByName(substring[indexToSubstring].Substring(numberCharToSubstring).Trim()));
                    }
                }
            }

            return ListOfId;
        }
    }
}
