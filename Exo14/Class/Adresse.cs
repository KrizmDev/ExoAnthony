using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo14.Class
{
    internal class Adresse
    {
        private int _numeroRue;
        private string _nomRUe;
        private string _ville;
        private string _codePostal;

        public int NumeroRue { get { return _numeroRue; } set { _numeroRue = value; } }
        public string NomRUe { get { return _nomRUe;} set { _nomRUe = value; } }
        public string Ville { get { return _ville; } set { _ville = value; } }
        public string CodePostal {get { return _codePostal; } set {_codePostal = value; } }


        public Adresse(int NumeroRue , string NomRUe , string Ville , string CodePostal) 
        {
            _numeroRue=NumeroRue;
            _nomRUe=NomRUe;
            _ville=Ville;
            _codePostal=CodePostal;

        }

        public override string ToString()
        {
            return $"{NumeroRue} {NomRUe} {Ville} {CodePostal}";
        }
    }
}
