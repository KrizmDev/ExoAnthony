using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2EF.Model2
{
    public enum CStatus
    {
        libre,
        occupé,
        nettoyage
    }
    [Table("chambre")]
    internal class Chambre
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {  get; set; }

        [Required]
        [Column("status")]
        [StringLength(15)]
        public CStatus Statut { get ; set; } = CStatus.libre;

        [Required]
        [Column("nombreDeLit")]
        [Range(1,4)]
        public int NbLits { get; set; } 

        [Required]
        [Column("tarif")]
        public double Tarif {  get; set; }

        public Chambre() { }

        public Chambre( CStatus statut, int nbLits, double tarif)
        {
            Statut = statut;
            NbLits = nbLits;
            Tarif = tarif;
        }

        public override string ToString()
        {
            return $"{Id} {Statut} {NbLits} nb lit, prix {Tarif}";
        }


    }
}
