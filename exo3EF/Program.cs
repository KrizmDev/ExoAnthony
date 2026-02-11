using exo3EF.DbManager3;
using exo3EF.Model;
using exo3EF.Services;
using Microsoft.EntityFrameworkCore;

using (DbRecette db = new DbRecette())
{
    db.Database.Migrate();

    RecetteService rs = new RecetteService(db);

    Ingredient farine = new Ingredient("farine","Blé");
    Ingredient oeuf = new Ingredient("oeuf", "poule");
    Ingredient chocolat = new Ingredient("chocolat", "noir");
    Ingredient sucre = new Ingredient("sucre", "blanc");

    rs.AjouterIngredient(chocolat);
    rs.AjouterIngredient(oeuf);
    rs.AjouterIngredient(farine);
    rs.AjouterIngredient(sucre);


    Recette gateau = new Recette("Gateau" , "Gateau au chocolat", "melanger ingredient");
    Recette gateau2 = new Recette("Gateau2", "Gateau avec moin de choco", "Tout melanger");



    rs.AJouterRecette(gateau, new List<(int, string)>
    {
        (farine.Id , "150g"),
        (oeuf.Id , "2"),
        (chocolat.Id , "100g")

    });

    rs.AJouterRecette(gateau2, new List<(int, string)>
    {
        (farine.Id , "150g"),
        (oeuf.Id , "2"),
        (chocolat.Id , "25g"),
        (sucre.Id , "30g")

    });

    var listeRecette = rs.ToutesLesRecettes();

    Console.WriteLine("Liste des recette :");
    foreach(var recette in listeRecette)
    {
        Console.WriteLine(recette);
    }

    var recetteComplete = rs.RecetteAvecIngredient(2);
    Console.WriteLine("Recette complete de la recette 1");
    foreach (var recette in recetteComplete)
    {
        Console.WriteLine(recette);
    }


    rs.SupprimerRecette(1);

    rs.IngredientLePlusUtilise();

    rs.RecetteAvecLePlusIngredients();

}