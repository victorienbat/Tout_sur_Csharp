using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    class Program
    {
        static int taille;
        static int[] Tab;        

        static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int A = Convert.ToInt32(Console.ReadLine());
            return A;
        }

        static void InitTab()
        {
            taille = GetInteger("Entrez la taille du tableau");
            Tab = new int[taille];         
        }

        static void SaisieTab()
        {
            //InitTab();
            for (int i = 0; i<Tab.Length; i++)
            {
                Tab[i] = GetInteger("Entrez un nombre pour la case " + i);
            }            
        }

        static void AfficheTab()
        {
            Console.WriteLine("Voici votre tableau");

            foreach (int valeur in Tab)
            {
                Console.WriteLine(valeur);
            }
        }

        static void RechercheTab()
        {
            int numero = GetInteger("Entrez un numéro de case");
            Console.WriteLine("Le contenu du poste " + numero + " est :");
            Console.WriteLine(Tab[numero]);
        }

        static void InfoTab()
        {
            int maxi = 0;

            foreach (int element in Tab)
            {
                if (element > maxi)
                {
                    maxi = element;
                }
            }

            int mini = 10000000;

            foreach (int element in Tab)
            {
                if (element < mini)
                {
                    mini = element;
                }
            }

            int somme = 0;
            int compteur = 0;
            double moyenne = 0;

            foreach (int element in Tab)
            {
                somme += element;
                compteur++;
            }
            moyenne = somme / compteur;



            Console.WriteLine("Votre Maximum est : " + maxi);
            Console.WriteLine("Votre Minimum est : " + mini);
            Console.WriteLine("Votre Somme est : " + somme);
            Console.WriteLine("Votre Moyenne est : " + moyenne);
            //Console.WriteLine("Le Total elements est : " + compteur);



        }
        static void Main(string[] args)
        {
            int reponse;
            do
            {
                Console.Clear();
                Console.WriteLine(" 1 - Affichage du contenue de tous les postes du tableau");
                Console.WriteLine(" 2 - Affichage du contenu d'un poste dont l'index est saisi au clavier");
                Console.WriteLine(" 3 - Affichage du maximum et la moyenne des postes du tableau");
                Console.WriteLine(" 0 - Pour Quitter");

               reponse = GetInteger("Entrez votre choix");
                switch (reponse)
                {
                    case 1:
                        Console.WriteLine("Affiche du contenue du tableau");
                        InitTab();
                        SaisieTab();
                        AfficheTab();
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Affichage du contenue d'un poste");
                        InitTab();
                        SaisieTab();
                        RechercheTab();
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Affichage du maximum et de la moyenne");
                        InitTab();
                        SaisieTab();
                        //Tab = new int[] { 23, 0, 45, -200, 8 };
                        InfoTab();
                        Console.ReadLine();
                        break;

                    //case 4:

                    //    break;

                }

            } while (reponse != 0);

            Console.ReadLine();
        }
    }
}
