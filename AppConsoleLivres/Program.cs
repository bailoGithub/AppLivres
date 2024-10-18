using System;

namespace AppConsoleLivres
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Revue revue1 = new Revue ("Revue sur les Mamadou et bineta ", "Ousmane", 40, 205, 1996);
            Revue revue2 = new Revue("Revue sur la Litterature africaine ", "Diop", 95, 102, 2022);
            Revue revue3 = new Revue("Revue sur la reussite ", "Fatoumata ba", 60, 105, 2020);


            revue1.AfficherLesInfoRevue ();
            Console.WriteLine();
            revue2.AfficherLesInfoRevue ();
            Console.WriteLine();
            revue3.AfficherLesInfoRevue ();
            Console.WriteLine();

            Roman roman1 = new Roman("Les Bouts de bois de Dieu", "Ousmane Sembène", 200, "Roman Social");
            Roman roman2 = new Roman("La Nuit des temps", "René Barjavel", 300, "Science-fiction");
            Roman roman3 = new Roman("La Maison de la Place", "Driss Chraïbi", 210, "Fiction");

            roman1.AfficherDetails();
            Console.WriteLine();
            roman2.AfficherDetails();
            Console.WriteLine();
            roman3.AfficherDetails();
            Console.WriteLine();


            Console.ReadLine ();
        }
    }

}

