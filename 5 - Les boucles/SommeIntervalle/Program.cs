using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommeIntervalle
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Somme d'un intervalle
            //Ecrivez un programme qui saisit deux nombres n1 et n2 et qui calcul ensuite la
            //somme des entiers de n1 à n2.

            int n1, n2;
            // saisie des nombre n2 et n2
            Console.WriteLine("saisie le premier nombre");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("saisie le premier nombre");
            n2 = Convert.ToInt32(Console.ReadLine());

            // calcul de la somme des entiers de n1 à n2
            int somme=0;
            int i;

             for(i=n1; i<=n2; i++)
            {
                somme = somme + i;
                            
            }
            Console.WriteLine("La somme des entiers entre {0} et {1} est : {2} ", n1, n2, somme);
            Console.ReadLine();
        }
    }
}
