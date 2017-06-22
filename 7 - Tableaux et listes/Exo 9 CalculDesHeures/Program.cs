using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_9_CalculDesHeures
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Le calcul des heures
            //Le programme réalise l'addition de deux données exprimées en HH:MM:SS et affiche
            //le résultat sous la même forme.

            DateTime d1 = new DateTime();
            DateTime d2 = new DateTime();

            //TimeSpan d1 = new TimeSpan();
            //TimeSpan d2 = new TimeSpan();

            Console.WriteLine("saisie l'heure en seconde");
            d1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("saisie l'heure en seconde");
            d2 = DateTime.Parse(Console.ReadLine());

            TimeSpan somme = d1 + d2;

        }
    }
}
