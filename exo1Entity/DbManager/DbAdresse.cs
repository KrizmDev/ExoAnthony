using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using exo1Entity.Model;
using Microsoft.EntityFrameworkCore;



namespace exo1Entity.DbManager
{
    internal class DbAdresse :  DbContext
    {
        public DbSet<Adresse> adresse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=ef1;uid=root;pwd=",
                ServerVersion.AutoDetect("server=localhost;database=ef1;uid=root;pwd=")
                );
        }

    }
}
