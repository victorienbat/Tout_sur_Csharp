using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_7_ConversionDeBases
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Conversion de bases
            //Ecrivez un programme qui convertit un nombre en base 2 vers son équivalent en base 10
            //Ecrivez le programme qui effectue l'opération inverse.

            double b2; // binaire
            double b10 = 0; // decimal
            int compteur = 0;


            // convertion binaire(base 2) en decimal (base 10)
            int[] Tab = new int[4]; //{ 1, 0, 0, 1,0 };

            Console.WriteLine("entrez le nombre binaires; que des [0 et 1]");
            for (int j = 0; j < Tab.Length; j++)
            {
                Tab[j] = Convert.ToInt32(Console.ReadLine());
                if ((Tab[j] != 0) && (Tab[j] != 1))
                {
                    Console.WriteLine("Saisie incorrecte");
                }
            }
            Console.WriteLine("Le nombre binaire est:");
            foreach (int valeur in Tab)
            {
                Console.Write(valeur);
            }
            Console.ReadLine();

            for (int i = Tab.Length - 1; i >= 0; i--)
            {
                b10 += Tab[i] * Math.Pow(2, compteur);
                compteur++;

            }
            Console.WriteLine("Le nombre decimal (Base 10) est : " + b10);
            Console.ReadLine();

            // convertion decimal (base 10) en binaire (base 2)

            int[] T = new int[20];
            int  a, b = 0;

            Console.WriteLine("Saisie un nombre decimal a convertir en binaire");
            int dec = Int32.Parse(Console.ReadLine());            

            do
            {
                T[b] = dec % 2;
                dec = dec / 2;
                b++;
            } while (dec != 0);

            Console.Write("Le nombre binaire est : ");
            for ( a = b-1; a>=0; a--)
            {
                Console.Write(T[a]);
            }
            Console.ReadLine();
        }
    }
}
