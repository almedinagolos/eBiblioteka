using Microsoft.EntityFrameworkCore;
using eBiblioteka.Database;
using eBiblioteka.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBiblioteka.Helper;
using System.IO;

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
                },
                new Zaposlenik()
                {
                    ZaposlenikID = 2,
                    Ime = "Almedina",
                    Prezime = "Gološ",
                    Email = "almedina.golos@mail.com",
                    KorisnickoIme = "almedina.golos",
                    LozinkaSalt = Salt[0],
                    LozinkaHash = PasswordHelper.GenerateHash(Salt[0], "Almedina123!"),
                    Adresa = "BP bb",
                    Aktivan = true,
                    DatumRodjenja = DateTime.Now.AddYears(-22),
                    JMBG = "0101111111001",
                    UlogaID = 2,
                    BibliotekaID = 1,
                    GradID = 1
                }
               );
            #endregion
            #region Dodavanje žanra
            modelBuilder.Entity<Zanr>().HasData(
                new Zanr()
                {
                    ZanrID = 1,
                    Naziv = "Dramski romani",
                    Aktivan = true
                },
                new Zanr()
                {
                    ZanrID = 2,
                    Naziv = "Enciklopedistika",
                    Aktivan = true
                },
                 new Zanr()
                 {
                     ZanrID = 3,
                     Naziv = "Fantastika",
                     Aktivan = true
                 },
                  new Zanr()
                  {
                      ZanrID = 4,
                      Naziv = "Putopis",
                      Aktivan = true
                  },
                   new Zanr()
                   {
                       ZanrID = 5,
                       Naziv = "Naučni",
                       Aktivan = true
                   }
               );
            #endregion
            #region Dodavanje tipa članarine
            modelBuilder.Entity<TipClanarine>().HasData(
                new TipClanarine()
                {
                    TipClanarineID = 1,
                    Naziv = "Mjesečna",
                    Aktivan = true
                },
                new TipClanarine()
                {
                    TipClanarineID = 2,
                    Naziv = "Godišnja",
                    Aktivan = true
                }
               );
            #endregion
            #region Dodavanje žanra
            modelBuilder.Entity<Pisac>().HasData(
                new Pisac()
                {
                    PisacID = 1,
                    Ime = "Ivo",
                    Prezime="Andrić",
                    Biografija= "Ivo Andrić se rodio u Travniku, u hrvatskoj obitelji Antuna Andrića, sudskoga podvornika i Katarine Pejić. Mjesec dana po rođenju, dana 9. studenog 1892. godine, u Crkvi sv. Ivana Krstitelja u rodnom mjestu kršten je u katolika. U dobi od dvije godine ostaje bez oca i uskoro se s majkom seli u Višegrad kod očeve sestre Ane i njezinog muža Ivana Matkovšika, graničnog policajca.",
                    DatumRodjenja = DateTime.Now.AddYears(-100),
                    Aktivan = true
                },
                new Pisac()
                {
                    PisacID = 2,
                    Ime = "Meša",
                    Prezime= "Selimović",
                    Biografija = "Rodio se u uglednoj muslimanskoj porodici iz Bileće, od oca Alije i majke Paše. Njegov otac Alija rodio se u Visokom, prilikom selidbe njegove porodice iz Bileće prema sjeveroistoku Bosne gdje su imali znatna imanja. Meša je rođen u Tuzli, gdje je završio osnovnu školu i gimnaziju. ",
                    DatumRodjenja = DateTime.Now.AddYears(-100),
                    Aktivan = true
                }
               );
            #endregion
            #region Dodavanje knjiga
            modelBuilder.Entity<Knjiga>().HasData(
                new Knjiga()
                {
                   KnjigaID = 1,
                   Aktivan = true,
                   BibliotekaID = 1,
                   GodinaIzdavanja = DateTime.Now.AddYears(-50),
                   Naziv="Derviš i smrt",
                   Opis = "",
                   ZanrID = 1,
                   Slika = File.ReadAllBytes("Pictures/dervis_i_smrt_nova_knjiga.jpg")
                }, new Knjiga()
                {
                    KnjigaID = 2,
                    Aktivan = true,
                    BibliotekaID = 1,
                    GodinaIzdavanja = DateTime.Now.AddYears(-120),
                    Naziv = "Mali princ",
                    Opis = "",
                    ZanrID = 2,
                    Slika = File.ReadAllBytes("Pictures/mali_princ_novo.jpg")
                }

               );
            #endregion
        }
    }
}
