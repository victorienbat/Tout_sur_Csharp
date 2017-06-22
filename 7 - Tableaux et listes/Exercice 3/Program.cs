using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Exercice 3 :
            //On recherche dans un tableau contenant 20 prénoms, un prénom saisi au clavier.
            //Lorsque cet élément est trouvé, on l’élimine du tableau en décalant les cases qui le
            //suivent, et en mettant à blanc la dernière case

            string[] Tab; // Declaration de la table

            Console.WriteLine("Donnez la Taille de votre tableau");
            int taille = Convert.ToInt32(Console.ReadLine());

            Tab = new string[taille];  // Initialisation du tableau

            // Remplissage du tableau
            Console.WriteLine("Entrez les prenoms dans le tableau");
            
            for (int i = 0; i <Tab.Length; i++)
            {
                Tab[i] = Console.ReadLine();               
            }

            // Affichage du tableau
            Console.WriteLine("Voici votre Tableau");

            //foreach(string valeur in Tab)
            //{
            //    Console.WriteLine(valeur);
            //}
            for (int z = 0; z < Tab.Length; z++)
            {
                Console.WriteLine("{0} {1}", z, Tab[z]);
            }

            // Suppression d'un prenom
            Console.WriteLine("Entrez le prenom a supprimer");
            string prenom = Console.ReadLine();

            for (int j = 0; j<Tab.Length; j++)
            {
                if (prenom == Tab[j])
                {
                    Tab[j] = "";
                    for (int n = j; n<Tab.Length - 1; n++)
                    {
                        Tab[n] = Tab[n + 1];
                        Tab[n + 1] = "";
                    }
                }
            }
            // Nouveau tableau apres suppression
            Console.WriteLine("Voici votre nouveau tableau");
            for (int x = 0; x < Tab.Length; x++)
            {
                Console.WriteLine("{0} {1}", x, Tab[x]);
            }
            Console.ReadLine();
        }
    }
}
