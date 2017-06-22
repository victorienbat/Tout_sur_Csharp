using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommeEntiersInferieur
{
    class Program
    {
        static void Main(string[] args)
        {
            //    La somme des entiers inférieurs à N
            //Ecrivez un programme qui affiche les nombres inférieurs à N.

            int i = 0;
            int somme = 0;
            int N = 100;
            Console.WriteLine("Ecrivez un programme qui affiche la somme des nombres inférieurs à N");

            for (i=0; i<N; i++)
            {
                somme = somme + i;
                
            }
            Console.WriteLine("Voici la somme des {0} premiers entiers : {1}", N, somme);
            Console.ReadLine();
        }
    }
}
