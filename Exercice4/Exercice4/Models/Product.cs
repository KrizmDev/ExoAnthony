using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4.Models
{
    public class Product
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public Product () { }

        public Product (int id, string name, string category, double price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} {Category} {Price}";
        }
    }
}
