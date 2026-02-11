using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo2EF.Model2;
using Microsoft.EntityFrameworkCore;

namespace exo2EF.DbManager2
{
    internal class DbHotel : DbContext
    {
        public DbSet<Client> clients { get; set; }
        public DbSet<Chambre> chambres { get; set; }
        public DbSet<Reservation> reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=ef2;uid=root;pwd=",
                ServerVersion.AutoDetect("server=localhost;database=ef2;uid=root;pwd=")
                );
        }
    }
}
