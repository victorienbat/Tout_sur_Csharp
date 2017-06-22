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
            bool ce_nombre_est_premier;

            do
            {
                Console.Clear();
                Console.WriteLine("Saisie un nombre");
                nbre = Convert.ToDouble(Console.ReadLine());

                racine = Math.Sqrt(nbre);
                //racine = Math.Round(nbre);
                //Console.WriteLine(racine);

                ce_nombre_est_premier = true;

                for (int i = 2; i < racine; i++)
                {
                    res = nbre % i;
                    if ((res == 0))
                    {
                        //Console.WriteLine(nbre + " n'est pas premier");
                        ce_nombre_est_premier = false;
                    }
                }
                if (ce_nombre_est_premier == true)
                {
                    Console.WriteLine("le nombre {0} est un nombre premier", nbre);
                }
                else
                {
                    Console.WriteLine("le nombre {0} n'est pas un nombre premier", nbre);
                }
                Console.ReadLine();
            } while (nbre != 0);

        }
    }
}

