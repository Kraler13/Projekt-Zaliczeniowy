using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Baza : DbContext
    {
        public Baza()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Baza;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        public DbSet<Samochod> Samochods { get; set; }
        public DbSet<Silnik> Silniks { get; set; }
        public DbSet<Lakier> Lakiers { get; set; }
        public DbSet<Uzytkownik> Uzytkowniks { get; set; }
    }
}

