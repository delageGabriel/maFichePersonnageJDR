using System;
using System.Collections.Generic;
using System.Drawing;
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
            for (int i = 0; i < richTextBox.Lines.Length; i++)
            {
                if(richTextBox.Lines[i].Contains(textToRemove))
                {
                    return i;
                }
            }

            return -1;
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
                    else if (TableNameToExtract == "ARMURES")
                    {
                        ListOfId.Add(Controller.EquipmentController.GetIdArmureByName(substring[indexToSubstring].Substring(numberCharToSubstring).Trim()));
                    }
                    else if (TableNameToExtract == "OBJETS")
                    {
                        ListOfId.Add(Controller.EquipmentController.GetIdObjetByName(substring[indexToSubstring].Substring(numberCharToSubstring).Trim()));
                    }
                }
            }

            return ListOfId;
        }

        /// <summary>
        /// Méthode qui permet d'ajouter les valeurs monétaires
        /// </summary>
        /// <param name="valueToConvert"></param>
        /// <returns></returns>
        public static string ConvertMoneyWithValue(int valueToConvert)
        {
            int or = valueToConvert / 100;
            int argent = (valueToConvert % 100) / 10;
            int cuivre = valueToConvert % 10;

            string result = "";

            if (or > 0)
            {
                result += or + " PO, ";
            }
            if (argent > 0 || or > 0) // Inclure des pièces d'argent si on a des pièces d'or
            {
                result += argent + " PA, ";
            }
            result += cuivre + " PC";

            return result;
        }

        /// <summary>
        /// Supprime les indices monétaires pour un prix donné
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public static int DeleteMoneyValue(string price)
        {
            // Supprimez tous les caractères non numériques de la chaîne
            string cleanedPrice = new string(price.Where(char.IsDigit).ToArray());

            // Essayez de convertir la chaîne nettoyée en entier
            if (int.TryParse(cleanedPrice, out int priceInInteger))
            {
                return priceInInteger;
            }

            // Si la conversion échoue, vous pouvez gérer l'erreur ici ou renvoyer une valeur par défaut
            return 0; // Ou une autre valeur par défaut selon votre besoin
        }

        /// <summary>
        /// Méthode pour supprimer tous les caractères d'une chaîne de caractères
        /// </summary>
        /// <param name="stringToClean"></param>
        /// <param name="arraysCharToDelete"></param>
        /// <returns></returns>
        public static string DeleteCharacterFromString(string stringToClean, params string[] arraysCharToDelete)
        {
            foreach (string character in arraysCharToDelete)
            {
                stringToClean = stringToClean.Replace(character, "");
            }

            return stringToClean;
        }

        /// <summary>
        /// Retire d'un panel les contrôles qui portent un tag donné
        /// </summary>
        /// <param name="tagControl"></param>
        /// <param name="panel"></param>
        public static void DeleteControlsFromPanelByTag(string tagControl, Panel panel)
        {
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control control in panel.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == tagControl)
                {
                    controlsToRemove.Add(control);
                }
            }

            // Retirer les contrôles du Panel après l'itération
            foreach (Control control in controlsToRemove)
            {
                panel.Controls.Remove(control);
                control.Dispose();
            }
        }

        public static void AdjustControlSizeAndPosition(Control control, Rectangle originalSize, float xRatio, float yRatio)
        {
            control.Width = (int)(originalSize.Width * xRatio);
            control.Height = (int)(originalSize.Height * yRatio);

            // Utilisation des coordonnées originales pour l'ajustement
            control.Left = (int)(originalSize.X * xRatio);
            control.Top = (int)(originalSize.Y * yRatio);
        }

        public static void AdjustLabelSizeAndPosition(Label label, Rectangle originalSize, float originalFontSize, float xRatio, float yRatio)
        {
            label.Width = (int)(originalSize.Width * xRatio);
            label.Height = (int)(originalSize.Height * yRatio);

            // Utilisation des coordonnées originales pour l'ajustement
            label.Left = (int)(originalSize.X * xRatio);
            label.Top = (int)(originalSize.Y * yRatio);

            // Ajustement de la taille de la police en fonction du ratio
            float newFontSize = originalFontSize * Math.Min(xRatio, yRatio); // Vous pouvez choisir xRatio ou yRatio selon ce qui convient le mieux
            label.Font = new Font(label.Font.FontFamily, newFontSize, label.Font.Style);
        }

        public static short GetDizaineInteger(int caracteristique)
        {
            return Convert.ToInt16((caracteristique / 10) % 10);
        }
    }
}