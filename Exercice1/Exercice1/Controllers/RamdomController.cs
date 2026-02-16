using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exercice1.Controllers
{
    public class RamdomController : Controller
    {
        public IActionResult index()
        {
            Random rdn = new Random();
            int nombre = rdn.Next(1,101);
            

            ViewData["Nombre_aléatoire"] = nombre;

            return View();
        }
    }
}
