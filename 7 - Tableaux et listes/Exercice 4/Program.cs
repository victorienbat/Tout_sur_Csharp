using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Exercice 4 : Tri d’un tableau
            //Ecrire le programme C# qui réalise le tri à bulles.

            int[] Tab = new int[] {26, 50, 14, 4, 2, 10, 20, 0, 0, 0, 0, 0, 0};      // Creation tableau et Initialisation

            Console.WriteLine("Voici votre Tableau");
            foreach (int valeur in Tab)
            {
                Console.WriteLine(valeur);
            }

            // Tri en ordre croissant
           

            for (int j = 0; j < Tab.Length - 1; j++)
            {
                                
                int x;                
                for (int i = 0; i < Tab.Length - 1; i++)
                {
                    if ((Tab[i] > Tab[i + 1]))
                    {
                        x = Tab[i];
                        Tab[i] = Tab[i + 1];
                        Tab[i + 1] = x;
                    }

                }
            }


            Console.WriteLine("Le nouveau tableau apres le tri est : ");
            foreach (int valeur in Tab)
            {
                Console.WriteLine(valeur);
            }
            Console.ReadLine();
        }
    }
}
