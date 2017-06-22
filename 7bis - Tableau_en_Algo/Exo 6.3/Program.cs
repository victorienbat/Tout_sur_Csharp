using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ecrire un algorithme qui déclare un tableau de 9 notes, dont on fait ensuite saisir les valeurs par l’utilisateur.

            int[] Tab = new int[9];
            Console.WriteLine("Saises les notes pour remplir le Tableau");
            for(int i = 0; i<9; i++)
            {
                Tab[i] =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Tab[i]);
            }
            Console.ReadLine();
        }
    }
}
