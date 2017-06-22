using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Mini et maxi
            //Modifiez le programme de la moyenne pour afficher le minimum et le maximum

            int saisie = 1;
            int mini = 0;
            int maxi = 0;          

            Console.WriteLine(" Entre les Nombres");                     
            saisie = Convert.ToInt32(Console.ReadLine());

               mini = saisie;               
               maxi = saisie;         
                  
             while (saisie != 0)
            {
                Console.WriteLine(" Entre les Nombres");
                 saisie = Convert.ToInt32(Console.ReadLine());
                if ((saisie < mini) && (saisie!=0))
                {
                    mini = saisie;
                }
                if (saisie > maxi)
                {
                    maxi = saisie;
                }
                
            }
            
            //Console.WriteLine(compteur);
            Console.WriteLine("Le mini est de {0} et le maxi est de {1}  ", mini, maxi);
            Console.ReadLine();
        }
    }
}
