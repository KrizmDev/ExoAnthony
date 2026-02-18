using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice5.Controllers
{
    [Route("Accueil")]
    public class ProductController : Controller
        {
            [HttpGet("Produit")]
            public IActionResult AfficherProduct()
            {
                Product p = new Product();
                return View(p);
            }
           [HttpPost("Produit")]
           public IActionResult AjouterProduct(Product p)
            {
            if (!ModelState.IsValid)
            {
                return View("AfficherProduct" , p);
            }
            return RedirectToAction ("AfficherDetail" , p);
            }


        [Route ("Details")]
        public IActionResult AfficherDetail(Product p) 
        {
            return View(p);
        }
        }
}
