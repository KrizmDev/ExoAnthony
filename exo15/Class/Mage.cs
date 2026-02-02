using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo15.Interface;

namespace exo15.Class
{
    internal class Mage : Personnage, IMagie
    {
        public Arme Arme { get; set; }
        public Mage(string nom, string prenom, int pv, int damage, Arme arme) : base(nom, prenom, pv, damage)
        {
            Arme = arme;
        }

        public override void Attaquer(Personnage cible)
        {
            int totalDamage = _damage;

            if (Arme._durabilité > 0)
            {
                totalDamage += Arme._degatSupplementaire;
            }
            cible._pv -= totalDamage;
            Console.WriteLine($"{_prenom} attaque {cible._prenom} avec {Arme._nom} pour {totalDamage} dégâts !");
            cible._pv -= totalDamage;
          
        }

        public void LancerSort(Personnage cible)
        {
            int damageSpeS = _damage * 2;
            if (Arme._durabilité > 0)
            {
                damageSpeS += Arme._degatSupplementaire;
            }
            Console.WriteLine($"{_prenom} lance un sort sur {cible._prenom} pour {damageSpeS} dégâts !");
            cible._pv -= damageSpeS;
        }
    }
}
