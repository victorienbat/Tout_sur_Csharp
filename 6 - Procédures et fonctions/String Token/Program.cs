using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Token
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("saisie une phrase contenant des separateur (; , . / - ou autre");
            string str1 = Console.ReadLine();
            Console.WriteLine("Indique le separateur");
            string str2 = Console.ReadLine();
            Console.WriteLine("Donner la position du bloc à trier");
            int n = Convert.ToInt32(Console.ReadLine());
            int compteur = 0;
            int bloc = n;
            string rep = "";

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1.Substring(i, 1) == str2)
                {
                    compteur++;
                }
                else if(compteur == bloc) 
                {
                    rep = rep + str1.Substring(i, 1);
                }
            }
            Console.WriteLine(" Le groupe de mot est : " + rep);
            Console.ReadLine();
        }
    }
}
