using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_18.Class
{
    internal class Bibliotheque
    {
        private List<Livre> listeDeLivres = new List<Livre>();

        public List<Livre> ListeDeLivres { get { return listeDeLivres; } set { listeDeLivres = value; } }

        public void ajouterUnLivre(Livre livre)
        {
            ListeDeLivres.Add(livre);
        }
        public void supprimerUnLivre(int numero)
        {
            Livre livreASupprimer = ListeDeLivres
                .FirstOrDefault(l => l.Numero == numero);
            ListeDeLivres.Remove(livreASupprimer);
        }
        public void afficherTout()
        {
            for (int i = 0; i < ListeDeLivres.Count; i++)
            {
                Console.WriteLine(ListeDeLivres[i]);
            }
        }
 
       public void RechercherUnLivre(string titre)
        {
            foreach (Livre livre in ListeDeLivres)
            {
                if (livre.Titre == titre || livre.Auteur ==titre)
                {
                    Console.WriteLine(livre);
                    return;
                }
             
            }

            Console.WriteLine("Livre non trouvé.");
        }


    }
}
