using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculFactorielle
{
    class Program
    {   
        static double factorielles(double n)
        {
            if (n == 1)
            {
                return 1;
            }

            else
            {
                return n * factorielles(n - 1);
            }
        }
        static void Main(string[] args)
        {
            double Facto;
            double valeur;

            Console.WriteLine("saisie une valeur");
            valeur = Convert.ToDouble(Console.ReadLine());

            Facto = factorielles(valeur);
            
            Console.WriteLine("le factorielle de {0} est : {1} ", valeur, Facto);           
            Console.ReadLine();
        }
    }
}
