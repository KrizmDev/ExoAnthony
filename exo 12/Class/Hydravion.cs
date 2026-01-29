using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoSurPoo.Class.NewFolder1
{
    internal class Hydravion : Vehicule ,IMotorise,IVolant,IFlottant
    {
        public Hydravion(string Nom, string Marque ) : base(Nom, Marque)
        {

        }

        public void Atterrir()
        {
            Console.WriteLine($"{Nom} Atterri");
        }

        public void Decoller()
        {
            Console.WriteLine($"{Nom} Décolle");
        }

        public void Demarrer()
        {
            Console.WriteLine($"{Nom} démarre");
        }

        public void Naviguer()
        {
            Console.WriteLine($"{Nom} Navigue");
        }
    }
}
