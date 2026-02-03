using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_18.Class
{
    internal class Livre
    {
        public int Numero { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int ExemplairesDisponibles { get; set; }

        public Livre(int numero, string titre, string auteur, int exemplairesDisponibles)
        {
            Numero = numero;
            Titre = titre;
            Auteur = auteur;
            ExemplairesDisponibles = exemplairesDisponibles;
        }

        public override string ToString()
        {
            return $"{Numero} , {Titre} , {Auteur} , {ExemplairesDisponibles}";
        }
    }
}
