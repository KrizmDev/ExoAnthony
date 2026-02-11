using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using exo3EF.DbManager3;
using exo3EF.Model;
using Microsoft.EntityFrameworkCore;

namespace exo3EF.Services
{
    internal class RecetteService
    {
        public readonly DbRecette _dbrecette;

        public RecetteService (DbRecette dbrecette)
        {
            _dbrecette = dbrecette;
        }


        public List<Recette> ToutesLesRecettes()
        {
            return _dbrecette.recettes.ToList();
        }
        public List<Ingredient> ToutLesIngrediants()
        {
            return _dbrecette.ingredients.ToList();
        }

        public void AJouterRecette(Recette recette,
            List<(int ingredientId, string quatite)> ingredients)
        {
            _dbrecette.recettes.Add(recette);
            _dbrecette.SaveChanges();

            foreach(var igr in ingredients)
            {
                RecetteIngredient recetteIngredient = new RecetteIngredient
                {
                    RecetteId = recette.Id,
                    IngredientId = igr.ingredientId,
                    Quantite = igr.quatite
                };

                _dbrecette.recetteIngredients.Add(recetteIngredient);
            }
            _dbrecette.SaveChanges();
        }

        public void AjouterIngredient(Ingredient ingredient)
        {
            _dbrecette.ingredients.Add(ingredient);
            _dbrecette.SaveChanges();
            Console.WriteLine("Ingredient Ajouter");
        }

        public List<RecetteIngredient> RecetteAvecIngredient(int recetteId)
        {
            return _dbrecette.recetteIngredients
                .Include(r => r.Recette)
                .Include(r => r.Ingredient)
                .Where(r => r.RecetteId == recetteId)
                .ToList();
        }

        public void SupprimerRecette(int recetteid)
        {
            Recette recette = _dbrecette.recettes
                               .Include(r => r.recetteIngredients)
                               .FirstOrDefault(r => r.Id == recetteid);


            if (recette != null)
            {
                _dbrecette.recetteIngredients.RemoveRange(recette.recetteIngredients);
                _dbrecette.recettes.Remove(recette);
                _dbrecette.SaveChanges();
                Console.WriteLine("Recette supprimer");
            }
            else
            {
                Console.WriteLine("Recette INTROUVABLE");
            }
         
        }
        public void IngredientLePlusUtilise()
        {
            Ingredient igdt = _dbrecette.ingredients
                 .Include(i => i.RecetteIngredients)
                           .OrderByDescending(i => i.RecetteIngredients.Count)
                           .FirstOrDefault();


            if (igdt != null)
            {
                Console.WriteLine($"Ingrédient le plus utilisé : {igdt.Nom} ({igdt.RecetteIngredients.Count} recettes)");
            }
            else
            {
                Console.WriteLine("Aucun ingrédient trouvé.");
            }
        }
        public void RecetteAvecLePlusIngredients()
        {
            Recette rct = _dbrecette.recettes
                .Include(r => r.recetteIngredients)
                .OrderByDescending(r => r.recetteIngredients.Count)
                .FirstOrDefault();
            if ((rct != null))
            {
                Console.WriteLine($"La reste avec le plus d'ingredient est : {rct.Nom}");
            }
        }

    }
}
