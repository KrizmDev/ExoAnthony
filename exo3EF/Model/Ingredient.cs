using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace exo3EF.Model
{
    [Table("Ingredient")]
    internal class Ingredient
    {
        

        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Nom")]
        [StringLength(50)]
        public string Nom {  get; set; }

        [Required]
        [Column("Description")]
        [StringLength(200)]
        public string Description { get; set; }

        public ICollection<RecetteIngredient> RecetteIngredients { get; set; } = new List<RecetteIngredient>();

        public Ingredient() { }

        public Ingredient( string nom, string description)
        {
            
            Nom = nom;
            Description = description;

        }

        public override string ToString()
        {
            return $"{Nom} {Description}";
        }
    }
}
