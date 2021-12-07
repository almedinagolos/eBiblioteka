using Microsoft.EntityFrameworkCore;
using eBiblioteka.Database;
using eBiblioteka.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBiblioteka.Helper;

namespace eBiblioteka.DB
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<string> Salt = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Salt.Add(PasswordHelper.GenerateSalt());
            }

            #region Dodavanje korisnickih uloga
            modelBuilder.Entity<Uloga>().HasData(
                new Uloga()
                {
                    UlogaID = 1,
                    Naziv = "Admin"
                },
                new Uloga()
                {
                    UlogaID = 2,
                    Naziv = "Zaposlenik"
                }
            );
            #endregion

            #region Dodavanje vrsta biblioteka
            modelBuilder.Entity<VrsteBiblioteka>().HasData(
                new VrsteBiblioteka()
                {
                    VrsteBibliotekaID = 1,
                    Naziv = "Školska"
                },
                new VrsteBiblioteka()
                {
                    VrsteBibliotekaID = 2,
                    Naziv = "Univerzitetska"
                },
                new VrsteBiblioteka()
                {
                    VrsteBibliotekaID = 3,
                    Naziv = "Narodna"
                },
                new VrsteBiblioteka()
                {
                    VrsteBibliotekaID = 4,
                    Naziv = "Internacionalna"
                },
                new VrsteBiblioteka()
                {
                    VrsteBibliotekaID = 5,
                    Naziv = "Nacionalna"
                },
                new VrsteBiblioteka()
                {
                    VrsteBibliotekaID = 6,
                    Naziv = "Dječija"
                }
            );

            #endregion
            #region Dodavanje država
            modelBuilder.Entity<Drzava>().HasData(
                new Drzava()
                {
                    DrzavaID = 1,
                    Naziv = "Bosna i Hercegovina"
                },
                new Drzava()
                {
                    DrzavaID = 2,
                    Naziv = "Srbija"
                },
                new Drzava()
                {
                    DrzavaID = 3,
                    Naziv = "Hrvatska"
                },
                new Drzava()
                {
                    DrzavaID = 4,
                    Naziv = "Velika Britanija"
                }
            );
            #endregion

            #region Dodavanje gradova
            modelBuilder.Entity<Grad>().HasData(
                new Grad()
                {
                    GradID = 1,
                    DrzavaID = 1,
                    Naziv = "Sarajevo"
                },
                new Grad()
                {
                    GradID = 2,
                    DrzavaID = 1,
                    Naziv = "Mostar"
                },
                new Grad()
                {
                    GradID = 3,
                    DrzavaID = 1,
                    Naziv = "Banja Luka"
                },
                new Grad()
                {
                    GradID = 4,
                    DrzavaID = 2,
                    Naziv = "Beograd"
                },
                new Grad()
                {
                    GradID = 5,
                    DrzavaID = 3,
                    Naziv = "Zagreb"
                },
                new Grad()
                {
                    GradID = 6,
                    DrzavaID = 4,
                    Naziv = "London"
                },
                new Grad()
                {
                    GradID = 7,
                    DrzavaID = 4,
                    Naziv = "Cardiff"
                },
                new Grad()
                {
                    GradID = 8,
                    DrzavaID = 4,
                    Naziv = "Edinburgh"
                },
                new Grad()
                {
                    GradID = 9,
                    DrzavaID = 4,
                    Naziv = "Belfast"
                }
            );
            #endregion

            #region Dodavanje biblioteka
            modelBuilder.Entity<Biblioteka>().HasData(
                new Biblioteka()
                {
                    BibliotekaID = 1,
                    Naziv = "Školska biblioteka Aleksa Šantić",
                    VrsteBibliotekaID = 1,
                    GradID = 1,
                    Email = "aleksa_santic@bih.net.ba",
                    Adresa = "Branislava Nušića 95",
                    BrojTelefona = "033/461-300"
                },
                new Biblioteka()
                {
                    BibliotekaID = 2,
                    Naziv = "Univerzitetska biblioteka Džemal Bijedić",
                    VrsteBibliotekaID = 2,
                    GradID = 2,
                    Email = "biblioteka@unmo.ba",
                    Adresa = "Univerzitetski kampus",
                    BrojTelefona = "036/571-543"
                }
            );
            #endregion

            #region Dodavanje korisnika
            modelBuilder.Entity<Zaposlenik>().HasData(
                new Zaposlenik()
                {
                    ZaposlenikID = 1,
                    Ime = "Admin",
                    Prezime = "Admin",
                    Email = "admin@mail.com",
                    KorisnickoIme = "admin",
                    LozinkaSalt = Salt[0],
                    LozinkaHash = PasswordHelper.GenerateHash(Salt[0], "Admin123!"),
                    Adresa = "Mostar",
                    Aktivan = true,
                    DatumRodjenja = DateTime.Now.AddYears(-22),
                    JMBG = "0101999155999",
                    UlogaID = 1,
                    BibliotekaID = 2,
                    GradID = 2
                }
               );
            #endregion
           
        }
    }
}
