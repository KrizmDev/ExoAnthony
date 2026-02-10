using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo1Entity.Model
{

    [Table("adresse")]

    internal class Adresse
    {

        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("numeroVoie")]
        [StringLength(255)]
        public string NumeroVoie { get; set; }

        [Required]
        [Column("Voie")]
        [StringLength(255)]
        public string Voie { get; set; }

        [Column("complement")]
        [StringLength(255)]
        public string Complement { get; set; }

        [Required]
        [Column("commune")]
        [StringLength(255)]
        
        public string Commune { get; set; }

        [Required]
        [Column("codePostal")]
        [StringLength(255)]

        public string CodePostal { get; set; }



        public Adresse() { }

        public Adresse(string numeroVoie, string voie, string complement, string commune, string codePostal)
        {
            NumeroVoie = numeroVoie;
            Voie = voie;
            Complement = complement;
            Commune = commune;
            CodePostal = codePostal;
        }
        public override string ToString()
        {
            return $"{Id} {NumeroVoie} {Voie} {Complement} {Commune} {CodePostal}";
        }
    }
}
