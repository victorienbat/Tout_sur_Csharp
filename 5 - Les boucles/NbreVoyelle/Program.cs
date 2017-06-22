using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbreVoyelle
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Nombre de voyelles.
           Ecrire le programme qui compte le nombre de voyelles d’un mot saisi au clavier, en utilisant :
             Length qui rend le nombre de lettres d’une chaîne donnée.
             Substring(p, n) qui extrait d’une chaîne donnée une sous chaîne de n
            caractères à partir de la position p.
             IndexOf(schaîne) qui restitue le rang de la première occurrence de
            schaîne dans chaîne donnée(si non trouvé: -1).*/

            string mot;
            string lettre;
            int compteur = 0;

            Console.WriteLine("Entrer le mot");
            mot = Console.ReadLine();

            for (int i = 0; i < mot.Length; i++)
            {
                lettre = mot.Substring(i, 1);
               
                if (lettre=="a" || lettre == "i" || lettre == "u" || lettre == "o" || lettre == "e" || lettre == "y" )
                {
                    compteur++;
                }
            }            
            Console.WriteLine(compteur);
            Console.ReadLine();
            

            //Console.WriteLine(mot.Length);
            //Console.WriteLine(mot.Substring(1,1));
            //Console.WriteLine(mot.IndexOf(mot));
        }
    }
}
