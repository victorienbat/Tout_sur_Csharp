using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_8_TriParInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Voici l’algorithme du tri par insertion, traduisez le en langage C#
                 array est un tableau < - [666, 1, 7, 69, 33, 13]
                 j < -1
                 n < -longueur de array
                 TantQue j <> n
                 i < -j - 1
                 tmp = array[j]
                 TantQue i > -1 et array[i] > tmp
                 array[i + 1] < -array[i]
                 i < -i – 1
                 FinTantQue
                 array[i + 1] < -tmp
                 j < -j + 1
                 FinTantQue*/

            int[] tableau = new int[] { 666, 1, 7, 69, 33, 131 };
            int j = 1;
            int n = tableau.Length;
            
            while (j != n)
            {
                int i = j - 1;
                int tmp = tableau[j];
                //Console.WriteLine(tmp);
                //Console.ReadLine();

                while ((i>-1) && (tableau[i]>tmp))
                    {
                        tableau[i + 1] = tableau[i];
                        i = i - 1;
                    }
                tableau[i + 1] = tmp;
                j = j + 1;

                Console.WriteLine(tmp);
                //Console.WriteLine(tableau[i]);
                //Console.WriteLine(tableau[j]);
            }
            Console.ReadLine();
            
        }
    }
}
