using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_5_Majorite
{
    class Program
    {
        static void Main(string[] args)
        {
            //A partir de la saisie de sa date de naissance, affichez si le candidat est majeur ou non.
            //Plusieurs solutions sont possibles …

            DateTime dn = new DateTime();
            DateTime dj = DateTime.Today;

            Console.WriteLine("Entrez votre Date de Naissance");            
            dn = Convert.ToDateTime(Console.ReadLine());
            //dn = DateTime.Parse(Console.ReadLine());

            int age = dj.Year - dn.Year;            
            Console.WriteLine("vous avez : {0} ans",age);            

            if (age>18)
            {
                Console.WriteLine("vous etes majeur");
            }
            else
            {
                Console.WriteLine("vous etes mineur");
            }

            Console.ReadLine();

            
            //Console.WriteLine("{0}/{1}/{2}", dn.Day, dn.Month, dn.Year);
            //Console.WriteLine(dj);
            //int age = DateTime.Compare(dj, dn);
            //TimeSpan ts = dj - dn;
            //Console.WriteLine("Nbre de jour ecoules depuis ta naissance : {0}", ts.Days);
            //Console.WriteLine("18 ans = 6575");
            //int nbre = Convert.ToInt32(ts);
        }
    }
}
