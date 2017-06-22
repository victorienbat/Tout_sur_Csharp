using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_10_cribleErathostène
{
    class Program
    {  
        //static void NombrePremier()
        //{
        //    double nbre;
        //    double res;
        //    double racine;
        //    bool ce_nombre_est_premier;
            
            
        //        //Console.Clear();
        //        //Console.WriteLine("Saisie un nombre");
        //        nbre = Convert.ToDouble(Console.ReadLine());

        //        racine = Math.Sqrt(nbre);
        //        //racine = Math.Round(nbre);
        //        //Console.WriteLine(racine);

        //        ce_nombre_est_premier = true;

        //        for (int i = 2; i < racine; i++)
        //        {
        //            res = nbre % i;
        //            if ((res == 0))
        //            {
        //                //Console.WriteLine(nbre + " n'est pas premier");
        //                ce_nombre_est_premier = false;
        //            }
        //        }
        //        if (ce_nombre_est_premier == true)
        //        {
        //        Console.WriteLine("le nombre {0} est un nombre premier", nbre);            }

        //        else
        //        {
        //            Console.WriteLine("le nombre {0} n'est pas un nombre premier", nbre);
        //        }
        //        Console.ReadLine();
        //}
        
        static void Main(string[] args)
        {
            //            Cet algorithme permet d'afficher progressivement la liste des nombres premiers
            //inférieurs à une valeur donnée: MAX.
            //Pour ce faire on construit un tableau de MAX éléments, vide au départ, que l'on
            //parcourt.
            //Chaque fois que la case est vide cela signifie que l'indice du tableau est un nombre
            //premier, on l'affiche puis on remplit avec une valeur quelconque toutes les cases du
            //tableau indicées par un multiple de l'indice courant.

            //Ecrire un programme qui demande un nombre et affiche tous les nombres premiers
            //inférieurs à un nombre donné par l’utilisateur.


            Console.WriteLine("Donne un nombre");
            int nombre = Convert.ToInt32(Console.ReadLine());
            int[] Tab = new int[nombre];            

            // Remplissage du tableau
            for (int i = 3; i < Tab.Length; i += 2)
            {
                Tab[i] = 0;
            }

            // On sait que 2 est un nombre premier et 0 - 1 ne sont pas consernés
            Tab[0] = 1;
            Tab[1] = 1;
            Tab[2] = 0;

            // On sait que seuls les nombre impaire au dessus de 2 peuvent etre premiers
            Console.WriteLine("Les nombres premiers inferieur a {0} sont : ", nombre);
            for (int i = 2; i < Tab.Length; i++)
            {
                if (Tab[i]==0)
                {                    
                    for (int j = i; j < Tab.Length; j=j+i)
                    {
                        Tab[j] = 1;
                    }
                }
                Console.WriteLine(i);  
            }


            //Console.WriteLine("Le nouveau tableau est");
            //foreach (int a in Tab)
            //{
            //    Console.Write("{0} ", a);
            //}
            Console.ReadLine();


        }
    }
}
