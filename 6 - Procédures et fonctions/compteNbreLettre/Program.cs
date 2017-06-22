using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compteNbreLettre
{
    class Program
    {
        //static void CompteLettre()
        //{
        //    Console.WriteLine("Saisie la phrase");
        //    string phrase = Console.ReadLine();
        //    Console.WriteLine("Saisie une lettre");
        //    string lettre = Console.ReadLine();
        //    int compteur = 0;

        //    for (int i = 0; i < phrase.Length; i++)
        //    {
        //        if (lettre == phrase.Substring(i, 1))
        //        {
        //            compteur++;
        //        }
        //    }

        //    Console.WriteLine("Compteur = " + compteur);
        //}

        //static void Main(string[] args)
        //{

        //    CompteLettre();

        //}

        //static void CompteLettre(string p, string l)
        //{

        //    int compteur = 0;

        //    for (int i = 0; i < p.Length; i++)
        //    {
        //        if (l == p.Substring(i, 1))
        //        {
        //            compteur++;
        //        }
        //    }

        //    Console.WriteLine("Compteur = " + compteur);
        //}

        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("Saisie la phrase");
        //    //string phrase = Console.ReadLine();
        //    //Console.WriteLine("Saisie une lettre");
        //    //string lettre = Console.ReadLine();

        //    CompteLettre("il fait beau a paris", "i");

        //}


        static int CompteLettre(string p, string l)
        {

            int compteur = 0;

            for (int i = 0; i < p.Length; i++)
            {
                if (l == p.Substring(i, 1))
                {
                    compteur++;
                }
            }

            return compteur;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Saisie la phrase");
            string phrase = Console.ReadLine();
            Console.WriteLine("Saisie une lettre");
            string lettre = Console.ReadLine();

            int nb = CompteLettre(phrase, lettre);

            Console.WriteLine(nb);
            Console.ReadLine();

        }
    }

  }

