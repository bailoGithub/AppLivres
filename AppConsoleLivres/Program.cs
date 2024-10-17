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
            revue2.AfficherLesInfoRevue ();
            revue3.AfficherLesInfoRevue ();

            Console.ReadLine ();
        }
    }

}

