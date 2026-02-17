using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice4.Models;

namespace Exercice4.Interface
{
    public interface IProduitServices
    {
        public Product RecupererProduitParId(int id);

        public List<Product> RecupererLaListDesProduits();

        public List<Product> FiltrerLesProduits(string? category, double? MaxPrice);


    }
}
