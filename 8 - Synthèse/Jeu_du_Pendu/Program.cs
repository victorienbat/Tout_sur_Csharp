using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_du_Pendu
{
    class Program
    {
        static void pendu( int a)
        {
            if (a == 6)
            {                
                Console.WriteLine("________");
                Console.WriteLine("|       |");
                Console.WriteLine("|       O");
                Console.WriteLine("|     \\/|\\/");
                Console.WriteLine("|       |");
                Console.WriteLine("|      /\\");
                Console.WriteLine("|     /  \\");
                Console.WriteLine("|");
                Console.WriteLine("----------------------");
            }
            else if (a == 5)
            {
                Console.WriteLine(" ________");
                Console.WriteLine("|        |");
                Console.WriteLine("|        O");
                Console.WriteLine("|     \\/|\\/");
                Console.WriteLine("|        |");
                Console.WriteLine("|       /");
                Console.WriteLine("|      /");
                Console.WriteLine("|");
                Console.WriteLine("----------------------");

            }
            if (a == 4)
            {
                Console.WriteLine("		 ________        ");
                Console.WriteLine("		|		|        ");
                Console.WriteLine("		|		O        ");
                Console.WriteLine("		|    \\/|\\/	 ");
                Console.WriteLine("		|		|		 ");
                Console.WriteLine("		|	    		 ");
                Console.WriteLine("		|	  	  		 ");
                Console.WriteLine("		|			     ");
                Console.WriteLine("----------------------");

            }
            if (a == 3)
            {
                Console.WriteLine("		 ________        ");
                Console.WriteLine("		|		|        ");
                Console.WriteLine("		|		O        ");
                Console.WriteLine("		|    \\/|		 ");
                Console.WriteLine("		|		|		 ");
                Console.WriteLine("		|	    		 ");
                Console.WriteLine("		|	  	  		 ");
                Console.WriteLine("		|			     ");
                Console.WriteLine("----------------------");

            }
            if (a == 2)
            {
                Console.WriteLine("		 ________        ");
                Console.WriteLine("		|		|        ");
                Console.WriteLine("		|		O        ");
                Console.WriteLine("		|       |		 ");
                Console.WriteLine("		|		|		 ");
                Console.WriteLine("		|	    		 ");
                Console.WriteLine("		|	  	  		 ");
                Console.WriteLine("		|			     ");
                Console.WriteLine("----------------------");

            }
            if (a == 1)
            {
                Console.WriteLine("		 ________        ");
                Console.WriteLine("		|		|        ");
                Console.WriteLine("		|		O        ");
                Console.WriteLine("		|       		 ");
                Console.WriteLine("		|				 ");
                Console.WriteLine("		|	    		 ");
                Console.WriteLine("		|	  	  		 ");
                Console.WriteLine("		|			     ");
                Console.WriteLine("----------------------");

            }
        }
        static void Main(string[] args)
        {
            string MotSecret = "victorien";
            char[] MotConstruit = new char[MotSecret.Length];
            char saisie;

            // Initialisation du tableau
            for (int i = 0; i < MotSecret.Length; i++)
            {
                MotConstruit[i] = '_';
            }
            //Affichage du tableau
            for (int i = 0; i < MotSecret.Length; i++)
            {
                Console.Write(MotConstruit[i] + " ");
            }
          
            int erreur = 0;
            bool encoreDesTirets = true;

            while ((encoreDesTirets) && (erreur <6))
            {
                Console.WriteLine("\n");
                Console.WriteLine("Proposez une lettre");
                saisie = Convert.ToChar(Console.ReadLine());
                //int compteur = 0;

                bool trouve = false;
                // Place la lettre dans le tableau
                for (int i = 0; i < MotSecret.Length; i++)
                {                    
                    if (saisie == MotSecret[i])
                    {
                        MotConstruit[i] = saisie;
                        //Console.ForegroundColor = ConsoleColor.Green;  
                        trouve = true;                                              
                    }                  
                }
                
                if (trouve == false)
                {
                    erreur++;
                }

                //Console.WriteLine(compteur);
                
                Console.WriteLine("nombre d'erreurs : " + erreur);

                encoreDesTirets = false;
                // Affichage du tableau
                for (int i = 0; i < MotSecret.Length; i++)
                {
                    Console.Write(MotConstruit[i] + " ");

                    if (MotConstruit[i] == '_')
                    {
                        encoreDesTirets = true;
                    }
                }
                Console.WriteLine("\n");              
                pendu(erreur);
                
            }
            Console.WriteLine("C'est la fin");
            Console.ReadLine();

        }
    }
}
