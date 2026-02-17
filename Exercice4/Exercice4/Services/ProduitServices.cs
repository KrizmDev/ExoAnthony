using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice4.Interface;
using Exercice4.Models;

namespace Exercice4.Services
{
    public class ProduitServices : IProduitServices
    {
        private List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop",Category = "Electronics", Price = 1200 },
            new Product { Id = 2, Name = "Jeans",Category ="Clothing", Price = 50 },
            new Product { Id = 3, Name = "Chocolate",Category ="Food", Price = 5 },
            new Product { Id = 4, Name = "Headphones",Category ="Electronics", Price = 150 },
            new Product { Id = 5, Name = "T-shirt",Category ="Clothing", Price = 20 },
            new Product { Id = 6, Name = "Smartphone", Category = "Electronics", Price = 900 },
            new Product { Id = 7, Name = "Tablet", Category = "Electronics", Price = 600 },
            new Product { Id = 8, Name = "Smartwatch", Category = "Electronics", Price = 250 },
            new Product { Id = 9, Name = "Camera", Category = "Electronics", Price = 750 },
            new Product { Id = 10, Name = "Bluetooth Speaker", Category = "Electronics", Price = 120 },

            new Product { Id = 11, Name = "Jacket", Category = "Clothing", Price = 100 },
            new Product { Id = 12, Name = "Sneakers", Category = "Clothing", Price = 80 },
            new Product { Id = 13, Name = "Hat", Category = "Clothing", Price = 25 },
            new Product { Id = 14, Name = "Sweater", Category = "Clothing", Price = 60 },
            new Product { Id = 15, Name = "Shorts", Category = "Clothing", Price = 35 },

            new Product { Id = 16, Name = "Pizza", Category = "Food", Price = 12 },
            new Product { Id = 17, Name = "Burger", Category = "Food", Price = 8 },
            new Product { Id = 18, Name = "Pasta", Category = "Food", Price = 10 },
            new Product { Id = 19, Name = "Ice Cream", Category = "Food", Price = 6 },
            new Product { Id = 20, Name = "Salad", Category = "Food", Price = 7 }


        };

        public Product RecupererProduitParId(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }

        public List <Product> RecupererLaListDesProduits()
        {
            return Products;
        }
        public List<Product> FiltrerLesProduits(string? category , double? MaxPrice)
        {
            var list = Products.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            { 
                list = list.Where(p => p.Category.ToLower() == category.ToLower());
            }

            if (MaxPrice.HasValue)
            {
                list = list.Where(p=> p.Price <=  MaxPrice.Value);
            }
            return list.ToList();

        }

      
    }
}
