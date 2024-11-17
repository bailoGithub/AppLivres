using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Revue : Livre
    {

        public int Numero {  get; set; }
        public int Annee { get; set; }
        public Revue (String titre ,string auteur ,int nbrePages ,int numero , int annee)
        : base ( titre , auteur , nbrePages)
        {

            Numero = numero;
            Annee = annee;
        
        }

        public void AfficherDetails ()
        {

            Console.WriteLine ($"le titre de la revue est : {Titre} ," +
                $" et lauteur de cette revue est :{Auteur} , pour un nombre de page de {NombrePages}" +
                $"avec un numero de : {Numero} sortit durant lannee : {Annee}");


        }


    }
}
