using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoSurPoo.Class.NewFolder1
{
    internal class Voiture : Vehicule , IMotorise
    {
        public Voiture(string Nom, string Marque) : base(Nom, Marque)
        {

        }

        public void Demarrer()
        {
            Console.WriteLine($"{Nom} démarre");
        }
    }
}
