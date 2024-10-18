using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Roman : Livre 
    {
        public string Genre { get; set; }
        public Roman (string titre , string auteur ,int nombrePages , string genre) 
        : base (titre ,auteur , nombrePages )
        { 
            Genre = genre;
        }

        public void AfficherDetails()
        {

            Console.WriteLine($"le Titre est  : {Titre}");
            Console.WriteLine($"l Auteur s'appelle : {Auteur}");
            Console.WriteLine($"Pour un nombre total de pages de : {NombrePages}");
            Console.WriteLine($"A pour Genre : {Genre}");

        }
    }


}
