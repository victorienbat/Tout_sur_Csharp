using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Fonctions
{
    class Test2
    {
        //// définition de la fonction
        //static void Incremente(int n)
        //{
        //    n++;
        //    Console.WriteLine("n= {0}", n); // Affiche 2
        //}
        //// programme principal
        //static void Main()
        //{
        //    Console.WriteLine("Programme principal");
        //    // ....
        //    int x = 1;
        //    Incremente(x);
        //    Console.WriteLine("x= {0}", x); // Affiche 1
        //    Console.ReadLine();
        //}


        // définition de la fonction
        static void Incremente(ref int n)
        {
            n++;
            Console.WriteLine("n= {0}", n); // Affiche 2
        }
        // programme principal
        static void Main()
        {
            Console.WriteLine("Programme principal");
            // ....
            int x = 1;
            Incremente(ref x);
            Console.WriteLine("x= {0}", x); // Affiche 2
            Console.ReadLine();
        }

    }
}