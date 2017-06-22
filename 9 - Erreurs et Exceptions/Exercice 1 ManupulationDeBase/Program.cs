using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_ManupulationDeBase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercice 1 : Manipulations de base
 Ecrivez un programme permettant de créer un tableau, dont la taille est saisie au
 clavier.
 Ensuite l'utilisateur doit rentrer les différentes valeurs du tableau.
 Puis votre programme doit afficher le contenu du tableau.*/

            int[] tableau;

            Console.WriteLine("Quelle est la taille de votre Tableau");
            int taille = Convert.ToInt32(Console.ReadLine());
            try
            {
            tableau = new int[taille];/*{ 1, 2, 3, 4, 5, 6, 9, 8, 5, 7 }*/
                        
            Console.WriteLine("entrer les entiers");

            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Voici votre Tableau ");            
            
            foreach (int entier in tableau)
            {
                Console.WriteLine(entier);
            }
            }
            catch(Exception er)
            {
                Console.WriteLine("voici l'erreur \n" + er.Message);
            }
            Console.ReadKey();
        }
    }
}
