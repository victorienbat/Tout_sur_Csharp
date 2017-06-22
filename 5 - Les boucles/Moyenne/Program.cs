using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            //        Somme et Moyenne
            //Ecrire un programme qui saisit des entiers et en affiche la somme et la moyenne (on
            //arrête la saisie avec la valeur 0)

            int saisie = 1;
            double moyenne;
            double somme = 0;
            double compteur = 0;

            Console.WriteLine(" Entre les Nombres");

            while (saisie != 0)
            {               
                saisie = Convert.ToInt32(Console.ReadLine());
                    // if (saisie==0) break; ***
                somme = somme + saisie;
                if (saisie!=0)   //***
                {
                    compteur++;
                }               
               
            }
            moyenne = somme / compteur;
            //Console.WriteLine(compteur);
            Console.WriteLine("La somme est de {0} et la moyenne es de {1}  ",somme, moyenne);
            Console.ReadLine();
        }  
    }
}
