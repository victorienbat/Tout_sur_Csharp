using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace jeu_pendu_liste
{
    class Program
    {
        static List<string> chargerFichier(string nomFichier)
        {
            List<string> listeMots = new List<string>();
            StreamReader flux = new StreamReader(nomFichier);
            String ligne = flux.ReadLine();
            while (ligne != null)
            {
                listeMots.Add(ligne);
                ligne = flux.ReadLine();
            }
            flux.Close();
            return listeMots;
        }
        static string proposerMot()
        {
            List<string> tm = chargerFichier("listemots.txt");
            Random alea = new Random();
            return tm[alea.Next(0, tm.Count - 1)].ToLower();
        }
        static void afficherEtat(List<char> mot, List<bool> trouve)
        {
            for (int i = 0; i < trouve.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (trouve[i] == false)
                    System.Console.Write("?");
                else
                    System.Console.Write(mot[i]);
                Console.ResetColor();
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
        }
        static void iniTrouve(List<bool> trouve)
        {
            for (int i = 0; i < trouve.Count; i++)
            {
                trouve[i] = false;
            }
        }
        static List<bool> MetAJour(List<char> mot, List<bool> trouve, char c)
        {
            for (int i = 0; i < trouve.Count; i++)
            {
                if (mot[i] == c)
                {
                    trouve[i] = true;
                }
            }
            return trouve;
        }
        static Boolean partieFinie(List<bool> trouve)
        {
            bool ok = true;
            for (int i = 0; i < trouve.Count; i++)
            {
                if (trouve[i] != true)
                {
                    ok = false;
                }
            }
            return ok;
        }
        static Boolean existe(List<char> mot, char c)
        {
            bool ok = false;
            for (int i = 0; i < mot.Count; i++)
            {
                if (mot[i] == c)
                {
                    ok = true;
                }
            }
            return ok;
        }
        static void partie(string mot)
        {
            List<bool> trouve = new List<bool>();
            iniTrouve(trouve);
            int vie = 6;
            while (partieFinie(trouve) == false && vie != 0)
            {
                System.Console.WriteLine("entrer une lettre : ");
                char c = System.Console.ReadLine().ToCharArray()[0];
                trouve = (MetAJour(MotVerTab(mot), trouve, c));
                if (!existe(MotVerTab(mot), c))
                {
                    vie--;
                }
                System.Console.Write("Il vous reste " + vie + " essais");
                afficherEtat(MotVerTab(mot), trouve);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            if (partieFinie(trouve) == true)
            {
                System.Console.Write("vous avez gagné avec " + vie + " point de vie");
                System.Console.Write(" le mot etait : " + mot);
            }
            if (vie == 0)
            {
                System.Console.Write("Vous avez perdu,le mot etait: " + mot);
            }
        }
        static List<char> MotVerTab(string s)
        {
            return s.ToList<char>();
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("JEU DU PENDU");
            string mot = proposerMot();
            Console.ResetColor();
            List<char> tabMot = MotVerTab(mot);
            List<bool> trouve = new List<bool>();
            partie(mot);
            System.Console.ReadKey();
        }
    }
}