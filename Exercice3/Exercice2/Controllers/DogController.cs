using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice2.Controllers
{
    public class DogController : Controller
    {
        public List<Dog> dogs { get ; set;}
        
        public DogController() {
            dogs = new List<Dog>(); 
            dogs.Add(new Dog(1,"Odin" ,"Cane Corso" , 7));
            dogs.Add(new Dog(2,"April", "Teckel", 1));
            dogs.Add(new Dog(3,"Haya", "Border collie", 13));
            dogs.Add(new Dog(4,"Danka", "Labrador", 15));


        }

        public IActionResult Display(int id) 
        {
            
            if (id == null)
            {
                return RedirectToAction("DisplayAll");
            }
            Dog d = dogs.Where(d => d.Id == id).Single();
            
            ViewData ["id"] = d.Id;
            ViewData["nom"] = d.Nom;
            ViewData["race"] = d.Race;
            ViewData["age"] = d.Age;

            return View();

        }
        public IActionResult DisplayAll() 
        {
            ViewData["DogsList"] = dogs;

            return View();
        }
        public IActionResult Greeting(string? nom)
        {
            string Message = "Bienvenue sur notre site";

            if (!String.IsNullOrEmpty(nom)) 
            {
                Message = $"Bienvenue a {nom}";
            }

            ViewData ["message"] = Message;
            return View();
        }
    }
}
