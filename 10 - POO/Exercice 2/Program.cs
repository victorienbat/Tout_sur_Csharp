using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    //Implémenter un système similaire permettant de représenter des véhicules(Avion, Vélo, Bateau,
    //Camion, …), Chaque objet doit hériter d’une classe de base, qui possède un méthode Marche().
    public abstract class vehicule
    {
        // Attributs
        public string Marque;
        public int Puissance;
        public int AnneeFabrication;

        //Constructeur
        public vehicule(string m, int p, int d)
        {
            Marque = m;
            Puissance = p;
            AnneeFabrication = d;
        }
        // Methode
        public virtual void Marche()
        {
            Console.WriteLine("Le véhicule se met en marche");
        }
        public class Avion : vehicule
        {
            //private int nbrePlace;
            public Avion(string m, int p, int d) : base(m,p,d)
            {
                //nbrePlace = np;
            }
            public override void Marche()
            {
                base.Marche();
                Console.WriteLine("L'avion vole dans les airs");
            }

        }
        public class Velo : vehicule
        {
            public Velo(string m, int p, int d) : base(m, p, d)
            {

            }
            public override void Marche()
            {
                Console.WriteLine("Il faut pedaler fort pour faire avancer le Velo");
            }

        }
        
        public class Bateau : vehicule
        {
            public Bateau(string m, int p, int d) : base(m, p, d)
            {

            }
            public override void Marche()
            {
                Console.WriteLine("Le bateau flotte sur les eaux");
            }

        }

        public class Camion : vehicule
        {
            public Camion (string m, int p, int d) : base(m, p, d)
            {

            }
            public override void Marche()
            {                
                Console.WriteLine("Le Camion transport les marchandises");
            }
        }    
        static void Main(string[] args)
        {
            Avion Av = new Avion("Boeing", 10000, 2010);
            Av.Marche();

            Velo Ve = new Velo("", 0, 0);
            Ve.Marche();

            Bateau Ba = new Bateau("", 0, 0);
            Ba.Marche();

            Camion Ca = new Camion("", 0, 0);
            Ca.Marche();

            Console.ReadLine();
        }
    }
}
