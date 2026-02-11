using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3EF.Model
{
    [Table("RecetteIngredient")]
    internal class RecetteIngredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int RecetteId { get; set; }
        public Recette? Recette { get; set; }

        [Required]
        public int IngredientId { get; set; }
        public Ingredient? Ingredient { get; set; }

        [Required]
        [StringLength(10)]
        public string Quantite { get; set; }

        public RecetteIngredient() { }

        public RecetteIngredient(int ingredientId, int recetteId, string quantite)
        {
            IngredientId = ingredientId;
            RecetteId = recetteId;
            Quantite = quantite;
        }

        public override string ToString()
        {
            return $"{Ingredient?.Nom ?? "Inconnu"} - {Recette?.Nom ?? "Inconnu"} : {Quantite}";
        }
    }
}
