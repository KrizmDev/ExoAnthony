using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_2_ADO.Class
{
    internal class Commande
    {
        public int id {  get; set; }
        public int id_client { get; set; }
        public DateTime dateCommande { get; set; }
        public decimal tot {  get; set; }


        public Commande(int id, int id_client, DateTime dateCommande, decimal tot)
        {
            this.id = id;
            this.id_client = id_client;
            this.dateCommande = dateCommande;
            this.tot = tot;
        }
    }
}
