using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo15.Class
{
    internal abstract class Personnage
    {
        public string _nom { get; set; }
        public string _prenom { get; set; }
        public int _pv { get; set; }
        public int _damage { get; set; }

        public Personnage(string nom,string prenom,int pv,int damage)
        {
            _damage = damage;
            _nom = nom;
            _prenom = prenom;
            _pv = pv;
        }
        public abstract void Attaquer(Personnage cible);



        public override string ToString()
        {
            return $"{_nom} {_prenom} PV : {_pv} damage : {_damage}";
        }

    }


}
