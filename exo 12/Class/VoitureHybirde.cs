using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoSurPoo.Class.NewFolder1
{
    internal class VoitureHybirde : Vehicule, IMotorise, IElectrique
    {
        public VoitureHybirde(string Nom, string Marque) : base(Nom, Marque)
        {

        }

        public void Demarrer()
        {
            Console.WriteLine($"{Nom} démarre");
        }

        public void Recharger()
        {
            Console.WriteLine($"{Nom} se recharge");
        }
    }
}
