using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Race { get; set; }
        public int Age { get; set; }

        public Dog() { }

        public Dog (int id ,string nom, string race, int age)
        {
            Id = id;
            Nom = nom;
            Race = race;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Nom} {Race} {Age}";
        }
    }
}
