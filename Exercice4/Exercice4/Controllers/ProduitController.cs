using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice4.Interface;
using Exercice4.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Exercice4.Controllers
{
    public class ProduitController :Controller
    {
        IProduitServices ProduitServices { get; set; }
        public ProduitController(IProduitServices produitServices) 
        {
            ProduitServices = produitServices;
        }
        public IActionResult AfficherProduitParId(int id)
        {
            Product p = ProduitServices.RecupererProduitParId(id);
            return View(p);
        }

        public IActionResult AfficherToutLesProduit()
        {
           List <Product> p = ProduitServices.RecupererLaListDesProduits();
            return View(p);
        }
        public IActionResult FiltrerLesProduit(string cat , double MPrice)
        {
            List <Product> p = ProduitServices.FiltrerLesProduits(cat, MPrice);
            return View(p);
        }
    }
}
