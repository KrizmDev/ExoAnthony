using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo2EF.Model2
{
    public enum etatResevation
    {
        prévu,
        Encours,
        Fini,
        Annulé
    }
    [Table("reservation")]

   
    internal class Reservation
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("Chambre_id")]

        public int ChambresId { get; set; }

        public Chambre? Chambres { get; set; }

        [Required]
        [Column("Client_id")]
        public int ClientsId { get; set; }

        public Client? Clients { get; set; }


        [Required]
        [Column("status")]
        [StringLength(15)]
        public etatResevation StatutR { get; set; } = etatResevation.Fini;


        public Reservation() { }

        public Reservation(int clientsId , int chambreId,etatResevation statutR) 
        {
            ClientsId = clientsId;
            ChambresId = chambreId;
            StatutR = statutR;

        }
        public override string ToString()
        {
            return $"{Chambres} {Clients} {StatutR}";
        }
    }

    



}
