using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoSurPoo.Class.NewFolder1
{
    internal abstract class Vehicule 
    {
        private string _nom;
        private string _marque;


        public string Nom {get { return _nom; }set { _nom = value;  } }
        public string Marque { get { return _marque; } set { _marque = value; } }


        public Vehicule(string Nom, string Marque)
        {
            _nom = Nom;
            _marque = Marque;
        }


        public override string ToString()
        {
            return $"{Nom} {Marque}";
        }



    }
}
