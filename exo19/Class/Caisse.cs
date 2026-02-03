using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo19.Class
{
    internal class Caisse
    {
        public List<Produit> _produit{ get; set; }
        public List<Vente> _vente { get; set; }

        public Caisse()
        {
            _produit = new List<Produit>();
            _vente = new List<Vente>();
        }

        public void ajoutProduit(Produit produit)
        {
            _produit.Add(produit);
        }

        public Vente ajoutVente(int numero)
        {
            Vente vente = new Vente(numero);
            _vente.Add(vente);
            return vente;
        }

        public void afficherProduit()
        {
            Console.WriteLine("=== Liste des produit en stock ===");
            foreach (Produit produit in _produit)
            {
                Console.WriteLine(produit);
            }
        }
        public void afficherVente()
        {
            Console.WriteLine("=== Liste des produit vendu ===");
            foreach (Vente vente in _vente)
            {
                Console.WriteLine(vente);
            }
        }


    }
}
