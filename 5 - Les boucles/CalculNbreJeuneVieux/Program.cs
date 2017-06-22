using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculNbreJeuneVieux
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calcul du nombre de jeunes, de moyens et de vieux.
            Il s’agit de dénombrer les personnes d'âge inférieur strictement à 20 ans, les
            personnes d'âge supérieur strictement à 40 ans et celles dont l'âge est compris entre
            20 ans et 40 ans (20 ans et 40 ans y compris).
            Le programme doit demander les âges successifs.
            Le comptage est arrêté dès la saisie d’un centenaire. Le centenaire est compté.
            Donnez le programme C# correspondant qui affiche les résultats.*/

            int age = 0;
            int compteur1 = 0;
            int compteur2 = 0;
            int compteur3 = 0;

            Console.WriteLine("Entrer les ages");

            do
            {
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 20)
                {
                    compteur1++;
                }
                else if (age > 40)
                {
                    compteur2++;
                }
                else
                {
                    compteur3++;
                }

            } while (age < 100);
            Console.WriteLine("Le Nbre de jeunes est : " + compteur1);
            Console.WriteLine("Le Nbre de moyens est : " + compteur3);
            Console.WriteLine("Le Nbre de vieux est : " + compteur2);
            Console.ReadLine();

        }
    }
}
