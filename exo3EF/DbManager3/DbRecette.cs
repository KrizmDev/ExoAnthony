using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo3EF.Model;
using Microsoft.EntityFrameworkCore;

namespace exo3EF.DbManager3
{
    internal class DbRecette : DbContext
    {

        public DbSet<Recette> recettes { get; set; }
        public DbSet<Ingredient> ingredients { get; set; }
        public DbSet<RecetteIngredient> recetteIngredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=ef3;uid=root;pwd=",
                ServerVersion.AutoDetect("server=localhost;database=ef3;uid=root;pwd=")
                );
        }

    }
}
