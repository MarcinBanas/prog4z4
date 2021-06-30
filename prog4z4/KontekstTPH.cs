using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace prog4z4
{
    class KontekstTPH : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9K2SBT4;Initial Catalog=KontekstTPH;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Klient> Klients { get; set; }
        public DbSet<Pracownik> Pracowniks { get; set; }
        public DbSet<Osoba> Osobas { get; set; }
    }
}
