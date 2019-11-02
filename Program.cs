using System;
using System.Linq;

namespace TirageLoto
{
    class Program
    {
        // Methode Main qui est le point de départ du programme et execute les méthodes appelées
        static void Main(string[] args)
        {
            // Déclarations de variables 
            String username = Environment.UserName;
            int[] resultLoto;

            // Appel des méthodes
            welcomeUser(username);
            resultLoto = tirageLoto();
            afficheResultatLoto(resultLoto);
            Console.WriteLine(Environment.NewLine);
            goodbyeUser(username);
        }

        // Methode servant à souhaiter la bienvenue en mode console à partir d'une variable user
        static void welcomeUser(String user)
        {
            Console.WriteLine("Bonjour " + user);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Activité - Tirage de Loto : ");
            Console.WriteLine(Environment.NewLine);
        }

        // Methode servant à dire au revoir en mode console à partir d'une variable user
        static void goodbyeUser(String user)
        {
            Console.WriteLine("Bonne journée " + user);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Fin d'Activité - Tirage de Loto");
            Console.WriteLine(Environment.NewLine);

        }

        // Methode afficheResultatLoto qui affiche le résultat via une Console.WriteLine grâce à une boucle for
        static void afficheResultatLoto(int[] tabChiffres)
        {
            Console.WriteLine("Le résultat du tirage : \n");

            for (int index = 0; index < tabChiffres.Length; index++)
            {
                Console.WriteLine(tabChiffres[index].ToString());
            }
        }

        // Methode qui renvoi un chiffre aléatoire entre 1 & 49
        static int random()
        {
            Random random = new Random();
            int aleatoire = random.Next(1, 49);
            return aleatoire;
        }

        // Methode Loto qui crée un chiffre random entre 1 & 50 grâce à une boucle for qui n'a pas déjà été tiré grâce au while
        static int[] tirageLoto()
        {
            int[] tab = new int[7];

            for (int index = 0; index < tab.Length; index++)
            {
                int chiffre = random();
                while (tab.Contains(chiffre))
                {
                    chiffre = random();
                }
                tab[index] = chiffre;

            }
            return tab;
        }
    }
}
