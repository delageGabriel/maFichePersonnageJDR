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
            string valueToReturn = string.Empty;

            /**
             * CAS PIECE OR
             */
            if (valueToConvert >= 100)
            {
                /*
                 * PLUSIEURS CAS POSSIBLES :
                 * 100.000 PO
                 * 10.000 PO
                 * 1.000 PO
                 * 100 PO
                 */
                if (valueToConvert > 99999)
                {
                    // Décorticage de l'or
                    int valueOrCentaineMillier = (valueToConvert / 100000) % 10;
                    int valueOrDizaineMillier = (valueToConvert / 10000) % 10;
                    int valueOrMillier = (valueToConvert / 1000) % 10;
                    int valueOrCentaine = (valueToConvert / 100) % 10;

                    // Rajout des pièces d'argent et de cuivre
                    int valueArgent = (valueToConvert / 10) % 10;
                    int valueCuivre = valueToConvert % 10;
                    valueToReturn += valueOrCentaineMillier.ToString() + valueOrDizaineMillier.ToString() + valueOrMillier.ToString() + valueOrCentaine.ToString() + " PO, "
                        + valueArgent.ToString() + " PA, " + valueCuivre.ToString() + " PC";
                }
                else if( valueToConvert > 9999)
                {
                    // Décorticage de l'or
                    int valueOrDizaineMillier = (valueToConvert / 10000) % 10;
                    int valueOrMillier = (valueToConvert / 1000) % 10;
                    int valueOrCentaine = (valueToConvert / 100) % 10;

                    // Rajout des pièces d'argent et de cuivre
                    int valueArgent = (valueToConvert / 10) % 10;
                    int valueCuivre = valueToConvert % 10;
                    valueToReturn += valueOrDizaineMillier.ToString() + valueOrMillier.ToString() + valueOrCentaine.ToString() + " PO, " 
                        + valueArgent.ToString() + " PA, " + valueCuivre.ToString() + " PC";
                }
                else if (valueToConvert > 999)
                {
                    // Décorticage de l'or
                    int valueOrMillier = (valueToConvert / 1000) % 10;
                    int valueOrCentaine = (valueToConvert / 100) % 10;

                    // Rajout des pièces d'argent et de cuivre
                    int valueArgent = (valueToConvert / 10) % 10;
                    int valueCuivre = valueToConvert % 10;
                    valueToReturn += valueOrMillier.ToString() + valueOrCentaine.ToString() + " PO, " + valueArgent.ToString() + " PA, " 
                        + valueCuivre.ToString() + " PC";
                }
                else
                {
                    // Décorticage de l'or
                    int valueOrCentaine = (valueToConvert / 100) % 10;

                    // Rajout des pièces d'argent et de cuivre
                    int valueArgent = (valueToConvert / 10) % 10;
                    int valueCuivre = valueToConvert % 10;
                    valueToReturn += valueOrCentaine.ToString() + " PO, " + valueArgent.ToString() + " PA, "
                        + valueCuivre.ToString() + " PC";
                }

            }
            /**
             * CAS PIECE ARGENT
             */
            else if (valueToConvert >= 10)
            {
                int valueArgent = (valueToConvert / 10) % 10;
                int valueCuivre = valueToConvert % 10;
                valueToReturn += valueArgent.ToString() + " PA, " + valueCuivre.ToString() + " PC";
            }
            else
            {
                int valueCuivre = valueToConvert % 10;
                valueToReturn = valueCuivre.ToString() + " PC";
            }

            return valueToReturn;
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
        public static string DeleteCharacterFromString(string stringToClean, string[] arraysCharToDelete)
        {
            foreach(string character in arraysCharToDelete)
            {
                stringToClean = stringToClean.Replace(character, "");
            }

            return stringToClean;
        }
    }
}
