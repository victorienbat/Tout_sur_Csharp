using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ecrire un algorithme qui déclare et remplisse un tableau contenant les six voyelles de l’alphabet latin.

            string[] Tab = new string[] {"i","u","o","a","e","y"};

            Console.WriteLine("Votre tableau est : ");
            foreach (string voyelle in Tab)
            {
                Console.WriteLine(voyelle);
            }
            Console.ReadLine();
        }
    }
}
