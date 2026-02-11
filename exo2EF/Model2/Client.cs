using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2EF.Model2
{
    [Table("Client")]
    internal class Client
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("nom")]
        [StringLength(255)]
        public string Nom { get; set; }

        [Column("prenom")]
        [StringLength(255)]
        public string Prenom { get; set; }

        [Required]
        [Column("tel")]
        [StringLength(10)]
        [Phone]
        public string NumTel { get; set; }


        public Client() { }

        public Client(string nom, string prenom, string numTel)
        {
           
            Nom = nom;
            Prenom = prenom;
            NumTel = numTel;
        }

        public override string ToString()
        {
            return $"{Id} {Nom} {Prenom} {NumTel}";
        }
    }
}
