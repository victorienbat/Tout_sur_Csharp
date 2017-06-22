using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbrePremier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un nombre est - il premier
            //Ecrivez un programme qui permet de tester si un nombre est premier.

            double nbre;
            double res;
            double racine;

            Console.WriteLine("Saisie un nombre");
            nbre = Convert.ToDouble(Console.ReadLine());

            racine = Math.Sqrt(nbre);
            //racine = Math.Round(nbre);
            //Console.WriteLine(racine);

            for (int i = 2; i < racine; i ++)
            {
                res = nbre % i;

                if ((res == 0) && (racine / 2 == 0))
                {
                    Console.WriteLine(nbre + " n'est pas premier");
                }
                else
                {
                    Console.WriteLine(nbre + " est premier");
                }
            }
            Console.ReadLine();

        }
    }
}

