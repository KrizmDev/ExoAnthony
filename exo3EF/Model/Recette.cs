using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3EF.Model
{
    [Table("Recette")]
    internal class Recette
    {
      

        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Nom")]
        [StringLength(50)]
        public string Nom { get; set; }

        [Required]
        [Column("Descitpion")]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        [Column("Instruction")]
        [StringLength(99999)]

        public string  Instruction { get; set; }
        public ICollection<RecetteIngredient> recetteIngredients { get; set; } = new List<RecetteIngredient>();
        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public int RecetteId { get; internal set; }

       

        public Recette(string nom , string description , string instruction)
        {
                Nom = nom;
            Description = description;
            Instruction = instruction;
        }


        public override string ToString()
        {
            return $"{Nom} {Description} {Instruction}";
        }
    }
}
