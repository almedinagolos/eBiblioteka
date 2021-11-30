using eBiblioteka.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.DB
{
    public partial class MojDbContext : DbContext
    {
        public MojDbContext(DbContextOptions<MojDbContext> options) : base(options)
        {

        }
        public DbSet<Biblioteka> Biblioteka { get; set; }
        public DbSet<Clan> Clan { get; set; }
        public DbSet<Clanarina> Clanarina { get; set; }
        public DbSet<Drzava> Drzava { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Knjiga> Knjiga { get; set; }
        public DbSet<KnjigaPisac> KnjigaPisac { get; set; }
        public DbSet<KnjigaZanr> KnjigaZanr { get; set; }
        public DbSet<Pisac> Pisac { get; set; }
        public DbSet<RezervacijaKnjige> RezervacijaKnjige { get; set; }
        public DbSet<TipClanarine> TipClanarine { get; set; }
        public DbSet<Uloga> Uloga { get; set; }
        public DbSet<VrsteBiblioteka> VrsteBiblioteka { get; set; }
        public DbSet<Zanr> Zanr { get; set; }
        public DbSet<Zaposlenik> Zaposlenik { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

    }
}
