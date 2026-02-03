using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo19.Class
{
    public enum EtatVente
    {
        EnCours,
        Validé,
        Annulé
    }
    internal class Vente
    {
        public int _numero {  get; set; }
        public EtatVente _etat {  get; set; } = EtatVente.EnCours;
        public List <Produit> _produit { get; set; } = new List<Produit>();


        public Vente(int numero)
        {
            _numero = numero;

        }
        public void ajoutProduit(Produit produit)
        {
            _produit.Add(produit);
        }
        public void Validation()
        {
           
            if (_etat != EtatVente.EnCours)
            {
                Console.WriteLine("La transaction est impossible");
                return;
            }
            foreach (Produit produit in _produit) 
            {
                produit._stock-=1;
              
            }
            _etat = EtatVente.Validé;
            Console.WriteLine($"Vente {_numero} validée !");

        }
        public void Anulation()
        {
            if (_etat != EtatVente.EnCours)
            {
                Console.WriteLine("La transaction est impossible");
                return;
            }
        
            _etat = EtatVente.Annulé;
            Console.WriteLine($"Vente {_numero} annulée !");
        }
        public override string ToString()
        {
            string listeProduits = string.Join("," , _produit.Select(p => p._nom));
            return $"Vente {_numero} {_etat} : {listeProduits}";
        }
    }
 

}
