using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo14.Class
{
    internal class User
    {
        private string _nom;
        private string _prenom;
        private Adresse _adresse;

        public string Nom { get { return _nom; } set { _nom = value; } }
        public string Prenom { get { return _prenom; } set { _prenom = value; } }
        public Adresse Adresse { get { return _adresse; } set { _adresse = value; } }

        public User(string Nom, string Prenom , Adresse adresse)
        {
                _adresse = adresse;
                 _nom = Nom;
                 _prenom = Prenom;
        }


        public override string ToString()
        {
            return $"{Nom} , {Prenom} , {Adresse}";
        }

     

    }
}
