using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo15.Class
{
    internal class Arme
    {
        public string _nom { get; set; }
        public int _degatSupplementaire { get; set; }
        public int _durabilité { get; set; }

        public Arme(string Nom , int DegatSuplementaire , int Durabilité )
        {
                _nom = Nom;
            _durabilité = Durabilité;
            _degatSupplementaire = DegatSuplementaire;

        }

        public int Utiliser()
        {
            if (_durabilité > 0)
            {
                _durabilité -= 1;
            }
            else
            {
                Console.WriteLine($"{_nom} est cassée !");
            }
            return _degatSupplementaire;
        }
        public override string ToString()
        {
            return $"{_nom} (Dégâts: {_degatSupplementaire}, Durabilité: {_durabilité})";
        }
    }


}
