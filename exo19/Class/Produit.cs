using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo19.Class
{
    internal class Produit
    {
        public int _numero { get; set; }
        public string _nom { get; set; }
        public double _prix {  get; set; }
        public int _stock {  get; set; }


        public Produit(int numero, string nom, double prix, int stock)
        {
            _numero = numero;
            _nom = nom;
            _prix = prix;
            _stock = stock;
        }

        public override string ToString()
        {
            return $"{_nom} (ref : {_numero} , Prix {_prix} euro , Stock:{_stock})";
        }
    }
}
