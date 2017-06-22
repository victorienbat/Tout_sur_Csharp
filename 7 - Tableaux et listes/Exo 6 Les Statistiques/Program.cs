using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_6_Les_Statistiques
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Les statistiques
            //On saisit des entiers et on les range dans un tableau(maximum 50)
            //Ecrire un programme qui affiche le maximum, le minimum et la valeur moyenne de
            //ces nombres.


            Console.WriteLine("Definissez la Taille de votre Tableau");  // Declaration et Initialisation de tableau Tab
            int T = Convert.ToInt32(Console.ReadLine());
            int[] Tab = new int[T];

            // Remplissage du tableau
            Console.WriteLine("Saisissez les valeurs de votre tableau");
            for (int i = 0; i < Tab.Length; i++)
            {
                Tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Voici votre Tableau ");

            foreach (int entier in Tab)
            {
                Console.WriteLine(entier);
            }
            Console.ReadLine();

            // Rangement des Entiers
            //int[] test = new int[] { 44, 1, 56, 22, -75, 10 };

            foreach (int entier in Tab)
            {
                Console.WriteLine(entier);
            }
                int a;
                for (int z = 0; z < Tab.Length -1; z++)
                {
            
                for(int j=0; j< Tab.Length -1; j++)
                {
                    if (Tab [j]> Tab[j+1])
                    {               
                    a = Tab[j];
                    Tab[j] = Tab[j + 1];
                    Tab[j + 1] = a;
                    }
                }
            }
            Console.WriteLine("Votre tableau après rangement est ");

            foreach (int entier in Tab)
            {
                Console.WriteLine(entier);
            }

            // Affichage du maximum
            int maxi = 0;
            foreach (int entier in Tab)
            {                
                if (entier > maxi)
                {
                    maxi = entier;
                }
            }Console.ReadLine();

            Console.WriteLine("Votre maximum est : " + maxi);
            Console.ReadLine();

            // Affichage du minimum
            int mini = 999999;
            foreach (int entier in Tab)
            {
                if (entier < mini)
                {
                    mini = entier;
                }
            }
            Console.WriteLine("Votre minimum est : " + mini);
            Console.ReadLine();

            // Affichage de la Moyenne
            int somme = 0;
            int moyenne = 0;
            int compteur = 0;

            foreach (int entier in Tab)
            {
                somme += entier;
                compteur++;
            }
            moyenne = somme / compteur;

            Console.WriteLine("Le compteur est de : " + compteur);
            Console.WriteLine("Votre somme est : " + somme);
            Console.WriteLine("Votre moyenne est : " + moyenne);
            Console.ReadLine();
        }
    }
}
