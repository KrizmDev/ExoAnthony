using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exercice2.Controllers
{
    public class DisplayController : Controller
    {
        public IActionResult Index()
        {
            string Prenom = "toto";
            int Age = 20;
            List<string> Hobbies = new List<string>
{
    "Lecture",
    "Sport",
    "Voyage",
    "Programmation"
};



            ViewData["prenom"] = Prenom;
            ViewData["age"] = Age;
            ViewData["hobbies"] = Hobbies;
            return View();
        }
    }
}
