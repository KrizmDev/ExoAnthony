using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo15.Interface;

namespace exo15.Class
{
    internal class Guerrier : Personnage , IAttaqueSpeciale
    {
        public Arme Arme { get; set; }
        public Guerrier(string nom, string prenom, int pv, int damage,Arme arme) : base(nom , prenom , pv , damage)
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
            Console.WriteLine($"{_prenom} attaque {cible._prenom} avec {Arme._nom} pour {totalDamage} dégâts !");
            cible._pv-=totalDamage;
        }

        public void AttaqueSpeciale(Personnage cible) 
        {
            int damageSpe = _damage * 2;
            if (Arme._durabilité > 0)
            {
                damageSpe += Arme._degatSupplementaire;
            }
            Console.WriteLine($"{_prenom} utilise son attaque spéciale sur {cible._prenom} pour {damageSpe} dégâts !");
            cible._pv -= damageSpe;
        }

    }
}
