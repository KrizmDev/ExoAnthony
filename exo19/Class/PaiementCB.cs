
namespace exo19.Class
{
    internal class PaiementCB : Paiement
    {
        public string _numCB {  get; set; }

        public PaiementCB(string numCB,int id , DateTime date) :base(id, date)
        {
            _numCB = numCB;
        }
        public override void Payer(double montant)
        {
            Console.WriteLine($"paiement {montant} par cb");
        }
    }
}
