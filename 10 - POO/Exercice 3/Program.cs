using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_3
{
    public class Client
    {
        // Attributs
        public string nomClient;
        public string prenomClient;
        public string adresseClient;
        public string villeClient;

        // Construteur par defaut (vide)
        public Client()
        {
            nomClient = "";
            prenomClient = "";
            adresseClient = null;
            villeClient = "";
        }

        // Constructeur d'initalisation
        public Client(string nom, string prenom, string adresse, string ville)
        {
            nomClient = nom;
            prenomClient = prenom;
            adresseClient = adresse;
            villeClient = ville;
        }

        // Methode (Pr afficher la saisie)
        public void Affichage()
        {
            Console.WriteLine(" {0}, {1} - {2} - {3}", prenomClient, nomClient,this.adresseClient,this.villeClient);
        }

        static void Main(string[] args)
        {
            // Creation des Objets
            Client monPremier = new Client();
            monPremier.prenomClient ="Paul";
            monPremier.nomClient = "WELLER";
            monPremier.adresseClient = "";
            monPremier.villeClient = "Londre";
            

            Client mondeuxiemeClient = new Client("White", "JACK", "Quartier sud", "Detroit");
            

            Client monTroisiemeClient = new Client();
            monTroisiemeClient.prenomClient = "Claypool";
            monTroisiemeClient.nomClient = "LES";
            monTroisiemeClient.adresseClient = "";
            monTroisiemeClient.villeClient = "San Francisco";

            Client monQuatriemeClient = new Client("Thunders", "JOHNNY", "Quartier Nord", "New York");

            // Affichage des Clients 
            Console.WriteLine("Voici la liste de mes Client : ");
            monPremier.Affichage();
            mondeuxiemeClient.Affichage();
            monTroisiemeClient.Affichage();
            monQuatriemeClient.Affichage();

            Console.ReadLine();

        }
    }
}
