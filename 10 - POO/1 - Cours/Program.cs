using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Cours
{
    public abstract class Forme
    {
        public virtual float Aire()
        {
            return 0;
        }

        public class Carre : Forme
        {
            private float cote;
            public Carre(float c)
            {
                cote = c;
            }
            public override float Aire()
            {
                return (float)Math.Pow(cote, 2);
            }
        }
        public class Cercle : Forme
        {
            private float rayon;
            public Cercle(float r)
            {
                rayon = r;
            }
            public override float Aire()
            {
                return (float)(Math.PI * Math.Pow(rayon, 2));
            }
        }
        public class Triangle : Forme
        {
            private float Base;
            private float hauteur;
            public Triangle(float B, float h)
            {
                Base = B;
                hauteur = h;
            }
            public override float Aire()
            {
                return (float)((Base * hauteur) / 2);
            }
        }
        public class Rectangle : Forme
        {
            private float Longueur;
            private float largeur;
            public Rectangle(float L, float l)
            {
                Longueur = L;
                largeur = l;
            }
            public override float Aire()
            {
                return (float)(Longueur * largeur);
            }
        }
        public class Losange : Forme
        {
            private float grandeDiagonal;
            private float petiteDiagonal;
            public Losange(float gd, float pd)
            {
                grandeDiagonal = gd;
                petiteDiagonal = pd;
            }
            public override float Aire()
            {
                return (grandeDiagonal * petiteDiagonal) / 2;
            }
        }
        public class Trapeze : Forme
        {
            private float grandeBase;
            private float petiteBase;
            private float hauteur;
            public Trapeze(float gb, float pb, float h)
            {
                grandeBase = gb;
                petiteBase = pb;
                hauteur = h;
            }
            public override float Aire()
            {
                return ((grandeBase+petiteBase)*hauteur)/ 2;
            }
        }
        public class Parallelogramme : Forme
        {
            private float LongueurBase;
            private float hauteur;
            public Parallelogramme(float lb, float h)
            {
                LongueurBase = lb;
                hauteur = h;
            }
            public override float Aire()
            {
                return LongueurBase * hauteur;
            }
        }
        public class Pentagone : Forme
        {
            private float hauteur;
            private float LongueurTriangle;
            public Pentagone(float h, float lt)
            {
                hauteur = h;
                LongueurTriangle = lt;
            }
            public override float Aire()
            {
                return 5 * ((LongueurTriangle * hauteur) / 2);
            }
        }
        public class Couronne : Forme
        {
            private float grandRayon;
            private float petitRayon;
            public Couronne(float R, float r)
            {
                grandRayon = R;
                petitRayon = r;
            }
            public override float Aire()
            {
                return (float)(Math.PI * (Math.Pow(grandRayon, 2) - Math.Pow(petitRayon, 2)));
            }
        }
        public class Demicercle : Forme
        {
            private float rayon;
            public Demicercle(float r)
            {
                rayon = r;
            }
            public override float Aire()
            {
                return (float)(Math.PI * Math.Pow(rayon, 2))/2;
            }
        }
        public class Ellipse : Forme
        {
            private float moitierGrandAxe;
            private float moitierPetitAxe;
            public Ellipse(float ga, float pa)
            {
                moitierGrandAxe = ga;
                moitierPetitAxe = pa;
            }
            public override float Aire()
            {
                return (float)(Math.PI * moitierGrandAxe * moitierPetitAxe);
            }
        }
        public class Hexagone : Forme
        {
            private float cote;
            public Hexagone(float c)
            {
                cote = c;
            }
            public override float Aire()
            {
                return (float)(3*Math.Sqrt(3)*Math.Pow(cote,2))/2;
            }
        }

        static void Figure()
        {
            //Console.SetCursorPosition(45, 20);
            //Console.WriteLine("-----------------");
            //Console.WriteLine("|               |");
            //Console.WriteLine("|               |");
            //Console.WriteLine("-----------------");

        }



        static void Main(string[] args)
        {
            int reponse;
            do
            {
                Console.Clear();
                //Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(15, 2);
                Console.WriteLine("1  - Calcul de la surface d'un Carre");
                Console.SetCursorPosition(15, 3);
                Console.WriteLine("2  - Calcul de la surface d'un Cercle");
                Console.SetCursorPosition(15, 4);
                Console.WriteLine("3  - Calcul de la surface d'un Triangle");
                Console.SetCursorPosition(15, 5);
                Console.WriteLine("4  - Calcul de la Surface d'un Rectangle");
                Console.SetCursorPosition(15, 6);
                Console.WriteLine("5  - Calcul de la surface d'un Losange");
                Console.SetCursorPosition(15, 7);
                Console.WriteLine("6  - Calcul de la surface d'un Trapeze");
                Console.SetCursorPosition(15, 8);
                Console.WriteLine("7  - Calcul de la surface d'un Parallelogramme");
                Console.SetCursorPosition(15, 9);
                Console.WriteLine("8  - Calcul de la surface d'un Pentagone Regulier");
                Console.SetCursorPosition(15, 10);
                Console.WriteLine("9  - Calcul de la surface d'une Couronne(Anneau)");
                Console.SetCursorPosition(15, 11);
                Console.WriteLine("10 - Calcul de la surface d'un Demi - Cercle");
                Console.SetCursorPosition(15, 12);
                Console.WriteLine("11 - Calcul de la surface d'une Ellipse");
                Console.SetCursorPosition(15, 13);
                Console.WriteLine("12 - Calcul de la surface d'un Hexagone Regulier");
                Console.SetCursorPosition(15, 14);                
                Console.WriteLine("0 - Quitter");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("Entrez votre Choix");
                reponse = Convert.ToInt32(Console.ReadLine());

                switch (reponse)
                {
                    // Calcul de la surface d'un carre
                    case 1:
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(15, 19);
                        Console.WriteLine("LA SURFACE D'UN CARRE");                     
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.WriteLine("Donnez la longueur du Cote");
                        float c = float.Parse(Console.ReadLine());

                        Carre ca = new Carre(c);
                        float aireCarre = ca.Aire();
                        Console.WriteLine("La Surface d'un carre de {0} Cm de cote est : {1} Cm2", c, aireCarre);
                        Console.ReadLine();
                        break;
                    // Calcul de la surface d'un Cercle
                    case 2:
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(15, 19);
                        Console.WriteLine("LA SURFACE D'UN CERCLE");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Donnez la longueur du Rayon");
                        float r = float.Parse(Console.ReadLine());

                        Cercle ce = new Cercle(r);
                        float aireCercle = ce.Aire();
                        Console.WriteLine("La surface d'un cercle de {0} Cm de rayon est : {1} Cm2", r, aireCercle);
                        Console.ReadLine();
                        break;
                    // Calcul de la surface d'un Triangle
                    case 3:
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(15, 19);
                        Console.WriteLine("LA SURFACE D'UN TRIANGLE");
                        Console.ForegroundColor = ConsoleColor.Gray;                       
                        //Figure();
                        Console.WriteLine("Donnez la longueur de la base du triangle");
                        float B = float.Parse(Console.ReadLine());
                        Console.WriteLine("Donnez la longueur de la hauteur de triangle");
                        float h = float.Parse(Console.ReadLine());

                        Triangle tr = new Triangle(B, h);
                        float aireTriangle = tr.Aire();
                        Console.WriteLine("La surface d'un Triangle de {0} Cm de base et {1} Cm de hauteur est : {2} Cm2", B, h, aireTriangle);
                        Console.ReadLine();
                        break;
                    // Calcul de la Surface d'un rectangle
                    case 4:
                        
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(15, 19);
                        Console.WriteLine("LA SURFACE D'UN RECTANGLE");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Donnez la longueur du rectangle");
                        float L = float.Parse(Console.ReadLine());
                        Console.WriteLine("Donnez la largeur du rectangle");
                        float l = float.Parse(Console.ReadLine());

                        Rectangle re = new Rectangle(L, l);
                        float aireRectangle = re.Aire();
                        Console.WriteLine("La surface d'un rectangle de {0} Cm de Long et {1} Cm de large est : {2} Cm2", L, l, aireRectangle);
                        Console.ReadLine();
                        break;
                    // Calcul de la surface d'un Losange
                    case 5:
                        
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(15, 19);
                        Console.WriteLine("LA SURFACE D'UN LOSANGE");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Donnez la taille de la grande diagonale");
                        float gd = float.Parse(Console.ReadLine());
                        Console.WriteLine("Donnez la taille de la petite diagonale");
                        float pd = float.Parse(Console.ReadLine());

                        Losange lo = new Losange(gd, pd);
                        float aireLosange = lo.Aire();
                        Console.WriteLine("La surface d'un Losange de {0} Cm de grande diagonal et {1} Cm de petite diagonale est : {2} Cm2", gd, pd, aireLosange);
                        Console.ReadLine();
                        break;
                    // Calcul de la surface d'un Trapeze
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(15, 19);
                        Console.WriteLine("LA SURFACE D'UN TRAPEZE");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Donnez la taille de la grande base");
                        float gb = float.Parse(Console.ReadLine());
                        Console.WriteLine("Donnez la taille de la petite base");
                        float pb = float.Parse(Console.ReadLine());
                        Console.WriteLine("Donnez la taille de la hauteur");
                        float ha = float.Parse(Console.ReadLine());

                        Trapeze Tr = new Trapeze(gb, pb, ha);
                        float aireTrapeze = Tr.Aire();
                        Console.WriteLine("La surface d'un Trapeze de {0} Cm de grande base, {1} Cm de petite base et {2} de hauteur est : {3} Cm2", gb, pb,ha, aireTrapeze);
                        Console.ReadLine();
                        break;
                    // Calcul de la surface d'un Parallelogramme
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition(15, 19);
                        Console.WriteLine("LA SURFACE D'UN PARALLELOGRAMME");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Donnez la longueur de la grande base du parallelogramme");
                        float lb = float.Parse(Console.ReadLine());
                        Console.WriteLine("Donnez la taille de la hauteur du parallelogramme");
                        float ht = float.Parse(Console.ReadLine());

                        Parallelogramme Pa = new Parallelogramme(lb, ht);
                        float aireParallelogramme = Pa.Aire();
                        Console.WriteLine("La surface d'un Parallelogramme de {0} Cm de longueur de la base et de {1} Cm de hauteur est : {2} Cm2", lb,ht,aireParallelogramme);
                        Console.ReadLine();

                        break;
                    // Calcul de la surface d'un Pentagone Regulier
                    case 8:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(15, 19);
                        Console.WriteLine("LA SURFACE D'UN PENTAGONE REGULIER");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Donnez la Longueur du triangle");
                        float LT = float.Parse(Console.ReadLine());
                        Console.WriteLine("Donnez la longueur de la hauteur");
                        float HT = float.Parse(Console.ReadLine());

                        Pentagone Pe = new Pentagone(LT, HT);
                        float airePentagone = Pe.Aire();
                        Console.WriteLine("La surface d'un Pentagone de {0} cm de la Longueur du triangle et de {1} Cm de hauteur est : {2} Cm2", LT,HT,airePentagone);
                        Console.ReadLine();
                        break;
                    // Calcul de la surface d'une Couronne(Anneau)
                    case 9:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.SetCursorPosition(15, 19);
                        Console.WriteLine("LA SURFACE D'UNE COURONNE");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Donnez la taille du grand Rayon");
                        float gR = float.Parse(Console.ReadLine());
                        Console.WriteLine("Donnez la taille du petit Rayon");
                        float pR = float.Parse(Console.ReadLine());

                        Couronne Cou = new Couronne(gR, pR);
                        float aireCouronne = Cou.Aire();
                        Console.WriteLine("La surface d'une Couronne de {0} Cm de grand rayon et de {1} Cm de petit rayon est {2} Cm2", gR,pR,aireCouronne);
                        Console.ReadLine();

                        break;
                    // Calcul de la surface d'un Demi - Cercle
                    case 10:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(15, 19);
                        Console.WriteLine("LA SURFACE D'UN DEMI-CERCLE");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Donnez la taille du rayon du Demi - cercle");
                        float R = float.Parse(Console.ReadLine());

                        Demicercle DC = new Demicercle(R);
                        float aireDemicercle = DC.Aire();
                        Console.WriteLine("La surface d'un Demi Cercle de rayon {0} Cm est : {1} Cm2", R,aireDemicercle);
                        Console.ReadLine();
                        break;
                    // Calcul de la surface d'une Ellipse
                    case 11:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.SetCursorPosition(15, 19);
                        Console.WriteLine("LA SURFACE D'UNE ELLIPSE");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Donnez la taille de la moitier du grand axe");
                        float mga = float.Parse(Console.ReadLine());
                        Console.WriteLine("Donnez la taille de la moitier du grand axe");
                        float mpa = float.Parse(Console.ReadLine());

                        Ellipse El = new Ellipse(mga, mpa);
                        float aireEllipse = El.Aire();
                        Console.WriteLine("La surface d'une Ellipse de {0} Cm de grand axe et de {1} Cm de petit axe est : {2} Cm2", mga,mpa,aireEllipse);
                        Console.ReadLine();
                        break;
                    // Calcul de la surface d'un Hexagone Regulier
                    case 12:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(15, 19);
                        Console.WriteLine("LA SURFACE D'UN HEXAGONE");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Donnez la longueur du Coté de l'Hexagone");
                        float Ct = float.Parse(Console.ReadLine());

                        Hexagone He = new Hexagone(Ct);
                        float aireHexagone = He.Aire();
                        Console.WriteLine("La surface d'un Hexagone de {0} Cm de cote est : {1} m2", Ct, aireHexagone);
                        Console.ReadLine();
                        break;                    

                    default:
                        break;
                }

            } while (reponse != 0);

        }
    }
}

