using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5.Models
{
    public class Product
    {
      
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range (0, 99999) ]
        public double Price { get; set; }

        [Required]
        public string Category { get; set; }

        public Product() { }

        public Product(int id, string name, double price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $" {Id} {Name} {Price} {Category}";
        }
    }
}
