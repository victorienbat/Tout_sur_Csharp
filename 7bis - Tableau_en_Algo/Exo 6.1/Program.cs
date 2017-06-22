using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ecrire un algorithme qui déclare et remplisse un tableau de 7 valeurs numériques en les mettant
            //toutes à zéro.

            int[] Tab = new int[7] {0,0,0,0,0,0,0};
            Console.WriteLine("votre tableau est :");
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(Tab[i]);
            //}

            foreach (int valeur in Tab)
            {
                Console.WriteLine(valeur);
            }
            Console.ReadLine();
        }
    }
}
