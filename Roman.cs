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
        public Roman (string titre , string auteur ,int nbrPages, string genre) 
        : base (titre ,auteur , nbrPages)
        { 
            Genre = genre;
        }

        public void AfficherDetails()
        {

            Console.WriteLine($"le Titre du roman est  : {Titre}");
            Console.WriteLine($"l Auteur du roman s'appelle : {Auteur}");
            Console.WriteLine($"Pour un nombre total de pages de : {NombrePages}");
            Console.WriteLine($"A pour Genre : {Genre}");

        }
    }


}
