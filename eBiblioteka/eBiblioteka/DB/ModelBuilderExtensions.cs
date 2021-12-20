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

            #region Dodavanje zaposlenika
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
            #region Dodavanje clanova
            modelBuilder.Entity<Clan>().HasData(
                new Clan()
                {
                    ClanID = 1,
                    Ime = "Elvira",
                    Prezime = "Ćurić",
                    Email = "elvira@mail.com",
                    KorisnickoIme = "elvira",
                    LozinkaSalt = Salt[0],
                    LozinkaHash = PasswordHelper.GenerateHash(Salt[0], "Elvira123!"),
                    Adresa = "BP 3",
                    Aktivan = true,
                    DatumRodjenja = DateTime.Now.AddYears(-33),
                    JMBG = "0101999155988",
                    BibliotekaID = 2,
                    GradID = 2
                },
                new Clan()
                {
                    ClanID = 2,
                    Ime = "Harisa",
                    Prezime = "Gološ",
                    Email = "harisa@mail.com",
                    KorisnickoIme = "harisa",
                    LozinkaSalt = Salt[0],
                    LozinkaHash = PasswordHelper.GenerateHash(Salt[0], "Harisa123!"),
                    Adresa = "KL bb",
                    Aktivan = true,
                    DatumRodjenja = DateTime.Now.AddYears(-20),
                    JMBG = "0101111111001",
                    BibliotekaID = 1,
                    GradID = 1
                },
                new Clan()
                {
                    ClanID = 3,
                    Ime = "Erna",
                    Prezime = "Ćurić",
                    Email = "erna@mail.com",
                    KorisnickoIme = "erna",
                    LozinkaSalt = Salt[0],
                    LozinkaHash = PasswordHelper.GenerateHash(Salt[0], "Erna123!"),
                    Adresa = "BP 2",
                    Aktivan = true,
                    DatumRodjenja = DateTime.Now.AddYears(-35),
                    JMBG = "01011111110022",
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
                    Iznos = 20,
                    Aktivan = true
                },
                new TipClanarine()
                {
                    TipClanarineID = 2,
                    Naziv = "Godišnja",
                    Iznos = 200,
                    Aktivan = true
                }
               );
            #endregion
            #region Dodavanje pisaca
            modelBuilder.Entity<Pisac>().HasData(
                new Pisac()
                {
                    PisacID = 1,
                    Ime = "Ivo",
                    Prezime = "Andrić",
                    Biografija = "Ivo Andrić se rodio u Travniku, u hrvatskoj obitelji Antuna Andrića, sudskoga podvornika i Katarine Pejić. Mjesec dana po rođenju, dana 9. studenog 1892. godine, u Crkvi sv. Ivana Krstitelja u rodnom mjestu kršten je u katolika. U dobi od dvije godine ostaje bez oca i uskoro se s majkom seli u Višegrad kod očeve sestre Ane i njezinog muža Ivana Matkovšika, graničnog policajca.",
                    DatumRodjenja = DateTime.Now.AddYears(-100),
                    Aktivan = true
                },
                new Pisac()
                {
                    PisacID = 2,
                    Ime = "Meša",
                    Prezime = "Selimović",
                    Biografija = "Rodio se u uglednoj muslimanskoj porodici iz Bileće, od oca Alije i majke Paše. Njegov otac Alija rodio se u Visokom, prilikom selidbe njegove porodice iz Bileće prema sjeveroistoku Bosne gdje su imali znatna imanja. Meša je rođen u Tuzli, gdje je završio osnovnu školu i gimnaziju. ",
                    DatumRodjenja = DateTime.Now.AddYears(-100),
                    Aktivan = true
                },
                new Pisac()
                {
                    PisacID = 3,
                    Ime = "Albert",
                    Prezime = "Camus",
                    Biografija = "Albert Kami, francuski romanopisac, u ovom djelu nam je prikazao otuđenost pojedinca u društvu , bavio se pitanjem egzistencije ljudi , te besmislom (apsurdnosti) življenja.To nam je predstavio kroz glavnog lika , Mersoa, koji je jedan običan bankovni činovnik i kojemu je sve svejedno.",
                    DatumRodjenja = DateTime.Now.AddYears(-109),
                    Aktivan = true
                },
                 new Pisac()
                 {
                     PisacID = 4,
                     Ime = "J. R. R.",
                     Prezime = "Tolkien",
                     Biografija = "He served as the Rawlinson and Bosworth Professor of Anglo-Saxon and Fellow of Pembroke College, Oxford from 1925 to 1945 and the Merton Professor of English Language and Literature and Fellow of Merton College,",
                     DatumRodjenja = DateTime.Now.AddYears(-109),
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
                    GodinaIzdavanja = DateTime.Now.AddYears(-56),
                    Naziv = "Derviš i smrt",
                    Opis = "Ahmed Nurudin govori da stvari postoje samo onda kada se kažu ili napišu, pa on tako započinje i svoju priču. Početak je pesimističan, gorki Kur'anski ajjeti uokviruju djelo i govore da je svaki čovjek na gubitku.",
                    ZanrID = 1,
                    Slika = File.ReadAllBytes("Pictures/dervis_i_smrt_nova_knjiga.jpg")
                },
                new Knjiga()
                {
                    KnjigaID = 2,
                    Aktivan = true,
                    BibliotekaID = 1,
                    GodinaIzdavanja = DateTime.Now.AddYears(-79),
                    Naziv = "Mali princ",
                    Opis = "Mali princ autora Antoinea de Saint-Exupéryja djelo je pisano prvenstveno za djecu, ali zahvaljujući izrazitoj slojevitosti samog djela ima što ponuditi i odraslima. Djelo je prožeto simbolikom i alegoričnim smjernicama. Biljke i životinje su u djelu personificirane i kompleksne, kao da se radi o ljudskim likovima.",
                    ZanrID = 2,
                    Slika = File.ReadAllBytes("Pictures/mali_princ_novo.jpg")
                },
                new Knjiga()
                {
                    KnjigaID = 3,
                    Aktivan = true,
                    BibliotekaID = 2,
                    GodinaIzdavanja = DateTime.Now.AddYears(-80),
                    Naziv = "Stranac",
                    Opis = "Apsurdnost življenja u romanu 'Stranac' A.Kamija. Albert Kami, francuski romanopisac, u ovom djelu nam je prikazao otuđenost pojedinca u društvu, bavio se pitanjem egzistencije ljudi, te besmislom (apsurdnosti) življenja.",
                    ZanrID = 4,
                    Slika = File.ReadAllBytes("Pictures/stranac_strip.jpg")
                },
                new Knjiga()
                {
                    KnjigaID = 4,
                    Aktivan = true,
                    BibliotekaID = 2,
                    GodinaIzdavanja = DateTime.Now.AddYears(-85),
                    Naziv = "The Hobbit",
                    Opis = "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published in 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction. The book remains popular and is recognized as a classic in children's literature. ",
                    ZanrID = 3,
                    Slika = File.ReadAllBytes("Pictures/hobbit.jpg")
                },
                  new Knjiga()
                  {
                      KnjigaID = 5,
                      Aktivan = true,
                      BibliotekaID = 2,
                      GodinaIzdavanja = DateTime.Now.AddYears(-85),
                      Naziv = "A game of thrones",
                      Opis = "A Game of Thrones is the first novel in A Song of Ice and Fire, a series of fantasy novels by the American author George R. R. Martin. It was first published on August 1, 1996. The novel won the 1997 Locus Award and was nominated for both the 1997 Nebula Award and the 1997 World Fantasy Award. ",
                      ZanrID = 3,
                      Slika = File.ReadAllBytes("Pictures/got.jpg")
                  },

                  new Knjiga()
                  {
                      KnjigaID = 6,
                      Aktivan = true,
                      BibliotekaID = 2,
                      GodinaIzdavanja = DateTime.Now.AddYears(-85),
                      Naziv = "The Silmarillion",
                      Opis = "The Silmarillion is a collection of mythopoeic stories by the English writer J. R. R. Tolkien, edited and published posthumously by his son Christopher Tolkien in 1977 with assistance from the fantasy author Guy Gavriel Kay. ",
                      ZanrID = 3,
                      Slika = File.ReadAllBytes("Pictures/silm.jpg")
                  }

               );
            #endregion
            #region Dodavanje clanova
            modelBuilder.Entity<Clanarina>().HasData(
               new Clanarina()
               {
                   ClanarinaID = 1,
                   Aktivan = true,
                   ClanID = 1,
                   DatumUplate = DateTime.Now.AddMonths(-1),
                   TipClanarineID = 2,
                   Iznos = "200"
               },
               new Clanarina()
               {
                   ClanarinaID = 2,
                   Aktivan = true,
                   ClanID = 2,
                   DatumUplate = DateTime.Now.AddMonths(-2),
                   TipClanarineID = 2,
                   Iznos = "200"
               },
               new Clanarina()
               {
                   ClanarinaID = 3,
                   Aktivan = true,
                   ClanID = 3,
                   DatumUplate = DateTime.Now.AddMonths(-3),
                   TipClanarineID = 2,
                   Iznos = "200"
               }
               );
            #endregion

            #region Dodavanje pisaca za knjige
            modelBuilder.Entity<KnjigaPisac>().HasData(
               new KnjigaPisac()
               {
                   KnjigaPisacID = 1,
                   KnjigaID = 1,
                   PisacID = 1
               },
               new KnjigaPisac()
               {
                   KnjigaPisacID = 2,
                   KnjigaID = 2,
                   PisacID = 2
               },
               new KnjigaPisac()
               {
                   KnjigaPisacID = 3,
                   KnjigaID = 3,
                   PisacID = 3
               },
                new KnjigaPisac()
                {
                    KnjigaPisacID = 4,
                    KnjigaID = 4,
                    PisacID = 4
                },
                 new KnjigaPisac()
                 {
                     KnjigaPisacID = 5,
                     KnjigaID = 5,
                     PisacID = 4
                 },
                  new KnjigaPisac()
                  {
                      KnjigaPisacID = 6,
                      KnjigaID = 6,
                      PisacID = 4
                  }
               );
            #endregion

            #region Dodavanje rezervacija
            modelBuilder.Entity<RezervacijaKnjige>().HasData(
               new RezervacijaKnjige()
               {
                   RezervacijaKnjigeID = 1,
                   ClanID = 1,
                   KnjigaID = 1,
                   DatumRezervacije = DateTime.Now
               },
               new RezervacijaKnjige()
               {
                   RezervacijaKnjigeID = 2,
                   ClanID = 2,
                   KnjigaID = 2,
                   DatumRezervacije = DateTime.Now.AddDays(-7)
               }
              );
            #endregion
        }
    }
}
