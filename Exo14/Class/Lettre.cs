using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo14.Class
{
    internal class Lettre
    {
        private User _expediteur;
        private User _destinataire;
        private string _contenu;
        private IStatutLettre _statut;

        public User Expediteur { get { return _expediteur; } set { _expediteur = value; } }
        public User Destinataire { get { return _destinataire; } set { _destinataire = value; } }
        public string Contenu { get { return _contenu; } set { _contenu = value; } }
        public IStatutLettre Statut { get { return _statut; } set { _statut = value; } }


        public Lettre(User expediteur, User destinataire, string contenu)
        {
            Expediteur = expediteur;
            Destinataire = destinataire;
            Contenu = contenu;
            Statut = IStatutLettre.EnAttente;
        }
        public void Envoyer()
        {
             Statut = IStatutLettre.Envoyee;
        }
        public void Lire()
        {
            Statut = IStatutLettre.Lue;
        }

        public override string ToString()
        {
            return $"{Expediteur} , {Destinataire} {Contenu} {Statut}";
        }


    }
}
