﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eBiblioteka.DB;

namespace eBiblioteka.Migrations
{
    [DbContext(typeof(MojDbContext))]
    partial class MojDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eBiblioteka.Database.Biblioteka", b =>
                {
                    b.Property<int>("BibliotekaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VrsteBibliotekaID")
                        .HasColumnType("int");

                    b.HasKey("BibliotekaID");

                    b.HasIndex("GradID");

                    b.HasIndex("VrsteBibliotekaID");

                    b.ToTable("Biblioteka");

                    b.HasData(
                        new
                        {
                            BibliotekaID = 1,
                            Adresa = "Branislava Nušića 95",
                            Aktivan = true,
                            BrojTelefona = "033/461-300",
                            Email = "aleksa_santic@bih.net.ba",
                            GradID = 1,
                            Naziv = "Školska biblioteka Aleksa Šantić",
                            VrsteBibliotekaID = 1
                        },
                        new
                        {
                            BibliotekaID = 2,
                            Adresa = "Univerzitetski kampus",
                            Aktivan = true,
                            BrojTelefona = "036/571-543",
                            Email = "biblioteka@unmo.ba",
                            GradID = 2,
                            Naziv = "Univerzitetska biblioteka Džemal Bijedić",
                            VrsteBibliotekaID = 2
                        });
                });

            modelBuilder.Entity("eBiblioteka.Database.Clan", b =>
                {
                    b.Property<int>("ClanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<int>("BibliotekaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClanID");

                    b.HasIndex("BibliotekaID");

                    b.HasIndex("GradID");

                    b.ToTable("Clan");
                });

            modelBuilder.Entity("eBiblioteka.Database.Clanarina", b =>
                {
                    b.Property<int>("ClanarinaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClanID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumUplate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Iznos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipClanarineID")
                        .HasColumnType("int");

                    b.HasKey("ClanarinaID");

                    b.HasIndex("ClanID");

                    b.HasIndex("TipClanarineID");

                    b.ToTable("Clanarina");
                });

            modelBuilder.Entity("eBiblioteka.Database.Drzava", b =>
                {
                    b.Property<int>("DrzavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrzavaID");

                    b.ToTable("Drzava");

                    b.HasData(
                        new
                        {
                            DrzavaID = 1,
                            Aktivan = true,
                            Naziv = "Bosna i Hercegovina"
                        },
                        new
                        {
                            DrzavaID = 2,
                            Aktivan = true,
                            Naziv = "Srbija"
                        },
                        new
                        {
                            DrzavaID = 3,
                            Aktivan = true,
                            Naziv = "Hrvatska"
                        },
                        new
                        {
                            DrzavaID = 4,
                            Aktivan = true,
                            Naziv = "Velika Britanija"
                        });
                });

            modelBuilder.Entity("eBiblioteka.Database.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<int>("DrzavaID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradID");

                    b.HasIndex("DrzavaID");

                    b.ToTable("Grad");

                    b.HasData(
                        new
                        {
                            GradID = 1,
                            Aktivan = true,
                            DrzavaID = 1,
                            Naziv = "Sarajevo"
                        },
                        new
                        {
                            GradID = 2,
                            Aktivan = true,
                            DrzavaID = 1,
                            Naziv = "Mostar"
                        },
                        new
                        {
                            GradID = 3,
                            Aktivan = true,
                            DrzavaID = 1,
                            Naziv = "Banja Luka"
                        },
                        new
                        {
                            GradID = 4,
                            Aktivan = true,
                            DrzavaID = 2,
                            Naziv = "Beograd"
                        },
                        new
                        {
                            GradID = 5,
                            Aktivan = true,
                            DrzavaID = 3,
                            Naziv = "Zagreb"
                        },
                        new
                        {
                            GradID = 6,
                            Aktivan = true,
                            DrzavaID = 4,
                            Naziv = "London"
                        },
                        new
                        {
                            GradID = 7,
                            Aktivan = true,
                            DrzavaID = 4,
                            Naziv = "Cardiff"
                        },
                        new
                        {
                            GradID = 8,
                            Aktivan = true,
                            DrzavaID = 4,
                            Naziv = "Edinburgh"
                        },
                        new
                        {
                            GradID = 9,
                            Aktivan = true,
                            DrzavaID = 4,
                            Naziv = "Belfast"
                        });
                });

            modelBuilder.Entity("eBiblioteka.Database.Knjiga", b =>
                {
                    b.Property<int>("KnjigaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<int>("BibliotekaID")
                        .HasColumnType("int");

                    b.Property<bool>("Dostupna")
                        .HasColumnType("bit");

                    b.Property<DateTime>("GodinaIzdavanja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("ZanrID")
                        .HasColumnType("int");

                    b.HasKey("KnjigaID");

                    b.HasIndex("BibliotekaID");

                    b.HasIndex("ZanrID");

                    b.ToTable("Knjiga");
                });

            modelBuilder.Entity("eBiblioteka.Database.KnjigaPisac", b =>
                {
                    b.Property<int>("KnjigaPisacID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KnjigaID")
                        .HasColumnType("int");

                    b.Property<int>("PisacID")
                        .HasColumnType("int");

                    b.HasKey("KnjigaPisacID");

                    b.HasIndex("KnjigaID");

                    b.HasIndex("PisacID");

                    b.ToTable("KnjigaPisac");
                });

            modelBuilder.Entity("eBiblioteka.Database.KnjigaZanr", b =>
                {
                    b.Property<int>("KnjigaZanrID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KnjigaID")
                        .HasColumnType("int");

                    b.Property<int>("KnjigaKategorijaID")
                        .HasColumnType("int");

                    b.Property<int>("ZanrID")
                        .HasColumnType("int");

                    b.HasKey("KnjigaZanrID");

                    b.HasIndex("KnjigaID");

                    b.HasIndex("ZanrID");

                    b.ToTable("KnjigaZanr");
                });

            modelBuilder.Entity("eBiblioteka.Database.Pisac", b =>
                {
                    b.Property<int>("PisacID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("Biografija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PisacID");

                    b.ToTable("Pisac");
                });

            modelBuilder.Entity("eBiblioteka.Database.RezervacijaKnjige", b =>
                {
                    b.Property<int>("RezervacijaKnjigeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClanID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumRezervacije")
                        .HasColumnType("datetime2");

                    b.Property<int>("KnjigaID")
                        .HasColumnType("int");

                    b.HasKey("RezervacijaKnjigeID");

                    b.HasIndex("ClanID");

                    b.HasIndex("KnjigaID");

                    b.ToTable("RezervacijaKnjige");
                });

            modelBuilder.Entity("eBiblioteka.Database.TipClanarine", b =>
                {
                    b.Property<int>("TipClanarineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipClanarineID");

                    b.ToTable("TipClanarine");
                });

            modelBuilder.Entity("eBiblioteka.Database.Uloga", b =>
                {
                    b.Property<int>("UlogaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UlogaID");

                    b.ToTable("Uloga");

                    b.HasData(
                        new
                        {
                            UlogaID = 1,
                            Aktivan = true,
                            Naziv = "Admin"
                        },
                        new
                        {
                            UlogaID = 2,
                            Aktivan = true,
                            Naziv = "Zaposlenik"
                        });
                });

            modelBuilder.Entity("eBiblioteka.Database.VrsteBiblioteka", b =>
                {
                    b.Property<int>("VrsteBibliotekaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VrsteBibliotekaID");

                    b.ToTable("VrsteBiblioteka");

                    b.HasData(
                        new
                        {
                            VrsteBibliotekaID = 1,
                            Aktivan = true,
                            Naziv = "Školska"
                        },
                        new
                        {
                            VrsteBibliotekaID = 2,
                            Aktivan = true,
                            Naziv = "Univerzitetska"
                        },
                        new
                        {
                            VrsteBibliotekaID = 3,
                            Aktivan = true,
                            Naziv = "Narodna"
                        },
                        new
                        {
                            VrsteBibliotekaID = 4,
                            Aktivan = true,
                            Naziv = "Internacionalna"
                        },
                        new
                        {
                            VrsteBibliotekaID = 5,
                            Aktivan = true,
                            Naziv = "Nacionalna"
                        },
                        new
                        {
                            VrsteBibliotekaID = 6,
                            Aktivan = true,
                            Naziv = "Dječija"
                        });
                });

            modelBuilder.Entity("eBiblioteka.Database.Zanr", b =>
                {
                    b.Property<int>("ZanrID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZanrID");

                    b.ToTable("Zanr");
                });

            modelBuilder.Entity("eBiblioteka.Database.Zaposlenik", b =>
                {
                    b.Property<int>("ZaposlenikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<int>("BibliotekaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UlogaID")
                        .HasColumnType("int");

                    b.HasKey("ZaposlenikID");

                    b.HasIndex("BibliotekaID");

                    b.HasIndex("GradID");

                    b.HasIndex("UlogaID");

                    b.ToTable("Zaposlenik");

                    b.HasData(
                        new
                        {
                            ZaposlenikID = 1,
                            Adresa = "Mostar",
                            Aktivan = true,
                            BibliotekaID = 2,
                            DatumRodjenja = new DateTime(1999, 12, 7, 21, 39, 6, 387, DateTimeKind.Local).AddTicks(864),
                            Email = "admin@mail.com",
                            GradID = 2,
                            Ime = "Admin",
                            JMBG = "0101999155999",
                            KorisnickoIme = "admin",
                            LozinkaHash = "4ReZxrrvRUNRxNZB2fWMbiqJ5Ks=",
                            LozinkaSalt = "b6ACuH3gF9VLtOHvHEeGRg==",
                            Prezime = "Admin",
                            UlogaID = 1
                        });
                });

            modelBuilder.Entity("eBiblioteka.Database.Biblioteka", b =>
                {
                    b.HasOne("eBiblioteka.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBiblioteka.Database.VrsteBiblioteka", "VrsteBiblioteka")
                        .WithMany()
                        .HasForeignKey("VrsteBibliotekaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grad");

                    b.Navigation("VrsteBiblioteka");
                });

            modelBuilder.Entity("eBiblioteka.Database.Clan", b =>
                {
                    b.HasOne("eBiblioteka.Database.Biblioteka", "Biblioteka")
                        .WithMany()
                        .HasForeignKey("BibliotekaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBiblioteka.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Biblioteka");

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("eBiblioteka.Database.Clanarina", b =>
                {
                    b.HasOne("eBiblioteka.Database.Clan", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBiblioteka.Database.TipClanarine", "TipClanarine")
                        .WithMany()
                        .HasForeignKey("TipClanarineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clan");

                    b.Navigation("TipClanarine");
                });

            modelBuilder.Entity("eBiblioteka.Database.Grad", b =>
                {
                    b.HasOne("eBiblioteka.Database.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("eBiblioteka.Database.Knjiga", b =>
                {
                    b.HasOne("eBiblioteka.Database.Biblioteka", "Biblioteka")
                        .WithMany()
                        .HasForeignKey("BibliotekaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBiblioteka.Database.Zanr", "Zanr")
                        .WithMany()
                        .HasForeignKey("ZanrID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Biblioteka");

                    b.Navigation("Zanr");
                });

            modelBuilder.Entity("eBiblioteka.Database.KnjigaPisac", b =>
                {
                    b.HasOne("eBiblioteka.Database.Knjiga", "Knjiga")
                        .WithMany()
                        .HasForeignKey("KnjigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBiblioteka.Database.Pisac", "Pisac")
                        .WithMany()
                        .HasForeignKey("PisacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Knjiga");

                    b.Navigation("Pisac");
                });

            modelBuilder.Entity("eBiblioteka.Database.KnjigaZanr", b =>
                {
                    b.HasOne("eBiblioteka.Database.Knjiga", "Knjiga")
                        .WithMany()
                        .HasForeignKey("KnjigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBiblioteka.Database.Zanr", "Zanr")
                        .WithMany()
                        .HasForeignKey("ZanrID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Knjiga");

                    b.Navigation("Zanr");
                });

            modelBuilder.Entity("eBiblioteka.Database.RezervacijaKnjige", b =>
                {
                    b.HasOne("eBiblioteka.Database.Clan", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBiblioteka.Database.Knjiga", "Knjiga")
                        .WithMany()
                        .HasForeignKey("KnjigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clan");

                    b.Navigation("Knjiga");
                });

            modelBuilder.Entity("eBiblioteka.Database.Zaposlenik", b =>
                {
                    b.HasOne("eBiblioteka.Database.Biblioteka", "Biblioteka")
                        .WithMany()
                        .HasForeignKey("BibliotekaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBiblioteka.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBiblioteka.Database.Uloga", "Uloga")
                        .WithMany()
                        .HasForeignKey("UlogaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Biblioteka");

                    b.Navigation("Grad");

                    b.Navigation("Uloga");
                });
#pragma warning restore 612, 618
        }
    }
}
