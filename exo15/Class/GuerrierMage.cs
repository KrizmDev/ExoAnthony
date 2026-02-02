using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo15.Interface;

namespace exo15.Class
{
    internal class GuerrierMage : Personnage, IAttaqueSpeciale, IMagie
    {
        public Arme Arme { get; set; }
        public GuerrierMage(string nom, string prenom, int pv, int damage, Arme arme) : base(nom, prenom, pv, damage)
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
