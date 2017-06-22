using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Multiplication(int nb)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1} = {2}", nb, i, nb*i);
            }
            Console.ReadLine();
        }

        static void SommeMoyenne()
        {
            int saisie = 1;
            double moyenne;
            double somme = 0;
            double compteur = 0;

            Console.WriteLine("Entrez les nombres (0 pour arreter)");

            while (saisie != 0)
            {
                
                saisie = Convert.ToInt32(Console.ReadLine());
                                
                somme = somme + saisie;              

                if (saisie != 0)   
                {
                    compteur++;
                }

            }
            moyenne = somme / compteur;

            Console.WriteLine("Somme = {0}", somme);
            Console.WriteLine("Moyenne = {0}", moyenne);
            //return moyenne;

            Console.ReadLine();
        }

        static void nombreVoyelle()
        {
            string mot;
            string lettre;
            int compteur = 0;

            Console.WriteLine("Entrer le mot");
            mot = Console.ReadLine();

            for (int i = 0; i < mot.Length; i++)
            {
                lettre = mot.Substring(i, 1);

                if (lettre == "a" || lettre == "i" || lettre == "u" || lettre == "o" || lettre == "e" || lettre == "y")
                {
                    compteur++;
                }
            }
            Console.WriteLine(" Le nombre de voyelles dans {0} est de : {1}", mot, compteur);
            Console.ReadLine();
        }

        static int nombreCaractere(string p, string l)
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

        static int factorielle( int n)
        {
            if ( n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorielle(n - 1);
            }
        }

        static void strtok()
        {
            Console.WriteLine("saisie les mots");
            string str1 = Console.ReadLine();
            Console.WriteLine("Indique le separateur");
            string str2 = Console.ReadLine();
            Console.WriteLine("Donner la position");
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
                else if (compteur == bloc)
                {
                    rep = rep + str1.Substring(i, 1);
                }
            }
            Console.WriteLine("Le groupe de mot est : " + rep);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int reponse;
            do
            {
                Console.Clear();
                Console.WriteLine(" 1 - Multiples ");
                Console.WriteLine(" 2 - Somme et moyenne");
                Console.WriteLine(" 3 - Recherche du nombre voyelles");
                Console.WriteLine(" 4 - Recherche du nombre des caracteres suivants");
                Console.WriteLine(" 5 - Calcul de la factorielle X");
                Console.WriteLine(" 6 - String Token ");
                Console.WriteLine(" 0 - Quitter");
                Console.WriteLine("Entrez votre choix: ");

                reponse = Convert.ToInt32(Console.ReadLine());

                switch (reponse)
                {
                    case 1:
                        Console.WriteLine("Affichage multiplications ");
                        Console.WriteLine("Entrez un nombre");
                        int nombre = Convert.ToInt32(Console.ReadLine());
                        Multiplication(nombre);
                        break;

                    case 2:
                        Console.WriteLine("Somme et moyenne");
                        SommeMoyenne();
                        break;

                    case 3:
                        Console.WriteLine(" Affichage du Nombre de Voyelle");
                        nombreVoyelle();
                        break;
                    case 4:
                        Console.WriteLine("Affichage du Nombre de caracteres");
                        Console.WriteLine("Saisie la phrase");
                        string phrase = Console.ReadLine();
                        Console.WriteLine("Quelle est la lettre a compter");
                        string lettre = Console.ReadLine();

                        int nbre = nombreCaractere(phrase, lettre);
                        Console.WriteLine("Dans cette phrase, la lettre {0} se repete {1} fois ", lettre, nbre);
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("calcul Factorielle");
                        Console.WriteLine("Saisie un nombre");
                        int X = Convert.ToInt32(Console.ReadLine());
                        factorielle(X);
                        Console.WriteLine("Factorielle de {0} est : {1}", X, factorielle(X));
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Affiche d'un bloc de mot d'une position donnée");
                        strtok();
                        break;
                }

            } while (reponse != 0);
        }
       
    }
}
