using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_11_Factorielle_Suite
{
    class Program
    {
        static double factorielle(double n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorielle(n - 1);
            }
        }
        static void Main(string[] args)
        {
            double x;
            double resultat = 0;
            Console.WriteLine("saisie un nombre");
            x = Convert.ToDouble(Console.ReadLine());

            //resultat = factorielle(x);

            //Console.WriteLine(" {0} ! donne : {1} ", x, resultat);
            //Console.ReadLine();

            for (double I = 0; I <= x; I++)
            {
                resultat = factorielle(I);
                Console.WriteLine(" {0} ! est : {1} ", I, resultat);
            }

            Console.ReadLine();
        }
    }
}
