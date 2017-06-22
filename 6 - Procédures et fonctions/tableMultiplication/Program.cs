using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableMultiplication
{
    class Program
    {   
        static void tableMultiplication(int nb)
        {            
            
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("{0}*{1} = {2}", i, nb, i * nb);
            }
            Console.ReadLine();
            
        }
        static void Main(string[] args)
        {
            int nbre;
            Console.WriteLine("Saisie un nombre");
            nbre = Convert.ToInt32(Console.ReadLine());
            tableMultiplication(nbre);

        }
    }
}
