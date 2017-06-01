using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace SmartGreenhouse.Model
{
    class GreenhouseContext:DbContext
    {
        public DbSet<Sadnica> Sadnice { get; set; }
        public DbSet<Izvjestaj> Izvjestaji { get; set; }
        public DbSet<Narudzba> Narudzbe { get; set; }
        public DbSet<Ponuda> Ponude { get; set; }
        public DbSet<PreuzimanjeInformacija> PreuzeteInformacije { get; set; }
        public DbSet<Statistika> Statistike { get; set; }
        public DbSet<TipIzvjestaja> TipoviIzvjestaja { get; set; }
        public DbSet<TipKorisnika> TipoviKorisnika { get; set; }

        //dodati ostale setove/tabele

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "SmartGreenhouse.db";
            try
            {
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException) { }
            optionsBuilder.UseSqlite($"Data Source={databaseFilePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
