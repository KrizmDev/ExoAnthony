using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo19.Class
{
    internal abstract class Paiement
    {
        public int _id { get ; set; }
        public DateTime _date { get; set; }


        public Paiement(int id, DateTime date)
        {
            _id = id;
            this._date = date;
        }

        public abstract void Payer(double montant);

        public override string ToString()
        {
            return $"{_id} {_date}";
        }
       
    }
}
