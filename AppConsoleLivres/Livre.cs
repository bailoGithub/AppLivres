using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Livre
    {

        public int NombrePages { get; set; }
        public string Titre {  get; set; }
        public string Auteur { get; set; }

        public Livre(string titre , string auteur , int nombrePages) { 
        
        Titre = titre;
        Auteur = auteur;
        NombrePages = nombrePages;
        
        }
        public void AfficherInfoDuLivre() 
        {
            Console.WriteLine($"le titre du roman est : { Titre } , et lauteur de ce roman est :{ Auteur } , pour un nombre de page de { NombrePages }");
            
        }

    }
}
