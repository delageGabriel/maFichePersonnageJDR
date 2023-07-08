using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using maFichePersonnageJDR.Controller;

namespace maFichePersonnageJDR.Formulaires
{
    public partial class FormulaireEquipments : Form
    {
        public FormulaireEquipments()
        {
            InitializeComponent();
        }

        public void GetArmes(SQLiteConnection connexion)
        {
            // Commande
            SQLiteCommand command;
            // Reader
            SQLiteDataReader reader;
            // nombre de ligne
            List<string> listesArmes = new List<string>();

            /// On commence par récupérer la liste de toutes les armes
            connexion.Open();
            command = connexion.CreateCommand();
            command.CommandText = $"SELECT * FROM ARMES";
            reader = command.ExecuteReader();

            /// Pour chacune d'entre elles, on créait un string
            while (reader.Read())
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(reader.GetValue(1).ToString() + ".");
                stringBuilder.Append(reader.GetValue(2).ToString() + ".");
                stringBuilder.Append(reader.GetValue(3).ToString() + ".");
                stringBuilder.Append(reader.GetValue(4).ToString() + ".");
                stringBuilder.Append(reader.GetValue(5).ToString() + ".");
                stringBuilder.Append(reader.GetValue(6).ToString() + ".");
                stringBuilder.Append(reader.GetValue(7).ToString() + ".");
                stringBuilder.Append(reader.GetValue(8).ToString());

                listesArmes.Add(stringBuilder.ToString());
            }

            // On va parcourir chaque page du TabControl pour ajouter
            // les armes dans chaque tabPages
            foreach (TabPage tabPage in tbCntlArmes.TabPages)
            {
                // On rajoute toutes les épées
                if (tabPage.Text.Contains("Épées"))
                {
                    // On récupère uniquement les épées dans la liste d'armes
                    List<string> listesEpees = new List<string>();
                    listesEpees = listesArmes.Where(epee => epee.Contains("Épée")).ToList();

                    foreach(string epee in listesEpees)
                    {
                        string[] subSplit = epee.Split('.');

                        for (int i = 0; i < subSplit.Length; i++)
                        {
                            FormController.CreateAndPlaceControlInTabPage(tabPage, )
                        }
                    }
                }
            }
        }

        private void FormulaireEquipments_Load(object sender, EventArgs e)
        {
            /// On commence par créer nos objets qui vont communiquer avec la base de données                   
            // Connexion
            SQLiteConnection connection = new SQLiteConnection(@"Data Source =BDD\20221227_base_fiche_perso.db; Version = 3;");

            GetArmes(connection);
        }
    }
}
