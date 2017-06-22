using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Tab;
            Console.WriteLine("saisie un nombre");
            int n = Convert.ToInt32(Console.ReadLine());
            int taille = n;
            Tab = new int[taille];

            for (int i=1; i < Tab.Length; i++)
            {
                Tab[i] = 1;                
            }
            double m = Math.Sqrt(n);

            for(int i = 2; i < m; i++)
            {
                if (Tab[i]==1)
                {
                    for(int j = 2; j < Tab.Length; j++)
                    {
                        Tab[i * j] = 0;
                    }
                }
            }
            foreach(int valeur in Tab)
            {
                Console.Write(valeur);
            }
            Console.ReadLine();
        }
    }
}
