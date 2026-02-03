using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo19.Class
{
    internal class PaiementEspece : Paiement
    {
        public string _numCB { get; set; }

        public PaiementEspece( int id, DateTime date) : base(id, date)
        {
        }
        public override void Payer(double montant)
        {
            Console.WriteLine($"paiement{montant} par cash");
        }
    }
}
