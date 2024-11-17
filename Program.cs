using System;

namespace AppConsoleLivres
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            List<Livre> livres = new List<Livre>();

            Revue revue1 = new Revue ("Revue sur les Mamadou et bineta ", "Ousmane", 40, 205, 1996);
            Revue revue2 = new Revue("Revue sur la Litterature africaine ", "Diop", 95, 102, 2022);
            Revue revue3 = new Revue("Revue sur la reussite ", "Fatoumata ba", 60, 105, 2020);

            livres.Add(revue1);
            livres.Add(revue2);
            livres.Add(revue3);

            

            Roman roman1 = new Roman("Les Bouts de bois de Dieu", "Ousmane Sembène", 200, "Roman Social");
            Roman roman2 = new Roman("La Nuit des temps", "René Barjavel", 300, "Science-fiction");
            Roman roman3 = new Roman("La Maison de la Place", "Driss Chraïbi", 210, "Fiction");

            livres.Add (roman1);
            livres.Add (roman2);
            livres.Add (roman3);

            
            foreach (var livre in livres)
            {

                if (livre is Revue revue)
                {
                    revue.AfficherDetails();
                }
                else if (livre is Roman roman)
                {

                    roman.AfficherDetails();
                }

                Console.WriteLine();

            }


            Console.ReadLine ();
        }
    }

}

