using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
                        /*Multiples
            Ecrire un programme qui calcule les N premiers multiples d'un nombre entier X, N et
            X étant entrés au clavier.
            Exemple pour N=5 et X=7
            1 x 7 = 7
            2 x 7 = 14
            3 x 7 = 21
            4 x 7 = 28
            5 x 7 = 35
            Il est demandé de choisir la structure répétitive (for, while, do...while) la mieux
            appropriée au problème.
            On ne demande pas pour le moment de gérer les débordements (overflows) dus à
            des demandes de calcul dépassant la capacité de la machine.  */

            int N,X;
            int resultat;

            Console.WriteLine("Entrer X");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer N");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                resultat = i * X;
                Console.WriteLine("{0} * {1} = {2} ",i, X, resultat);
            }Console.ReadLine();
        }
    }
}
