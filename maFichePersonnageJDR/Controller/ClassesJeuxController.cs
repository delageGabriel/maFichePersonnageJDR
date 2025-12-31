using System;
using System.Collections.Generic;
using maFichePersonnageJDR.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maFichePersonnageJDR.Controller
{
    class ClassesJeuxController
    {
        public static List<string> GetClassesNames()
        {
            Console.WriteLine("########### Méthode GetClassesNames ###########");

            ClassesJeuxModel classesJeuxModel = new ClassesJeuxModel();

            try
            {
                List<string> listClassesSortsAptitudes = classesJeuxModel.GetNameClasse();

                if (listClassesSortsAptitudes != null)
                {
                    return listClassesSortsAptitudes;
                }
                else
                {
                    Console.WriteLine("Liste vide !");
                    return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static Dictionary<int, ClassesJeux> GetAptitudeOrSortSkillTree(string name)
        {
            Console.WriteLine("########### Méthode GetAptitudeOrSortSkillTree ###########");

            Dictionary<int, ClassesJeux> classesJeuxTree = new Dictionary<int, ClassesJeux>();
            ClassesJeuxModel classesJeuxModel = new ClassesJeuxModel();

            List<string> capacitesClasse = classesJeuxModel.GetNameAptitudeSortByClasseName(name);
            List<int> seuilCapacitesClasse = classesJeuxModel.GetSeuilAptitudeSortByClasseName(name);

            /// Je fais ça comme ça pour les niveaux parce que j'en ai plus rien à foutre
            for (int i = 0; i < 10; i++)
            {
                ClassesJeux classe = new ClassesJeux();

                classe.Classe = name;
                classe.Niveau = i;

                if (capacitesClasse[i] != null)
                    classe.Nom = capacitesClasse[i];

                classe.Seuil = seuilCapacitesClasse[i];
                classesJeuxTree.Add(i, classe);
            }

            return classesJeuxTree;
        }
    }

    class ClassesJeux
    {
        public int Id { get; set; }
        public string Classe { get; set; }
        public int Niveau { get; set; }
        public string Nom { get; set; }
        public int Seuil { get; set; }
    }
}
