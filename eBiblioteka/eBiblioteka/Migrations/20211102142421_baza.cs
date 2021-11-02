using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class baza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "Pisac",
                columns: table => new
                {
                    PisacID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Biografija = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pisac", x => x.PisacID);
                });

            migrationBuilder.CreateTable(
                name: "TipClanarine",
                columns: table => new
                {
                    TipClanarineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipClanarine", x => x.TipClanarineID);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    UlogaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.UlogaID);
                });

            migrationBuilder.CreateTable(
                name: "VrsteBiblioteka",
                columns: table => new
                {
                    VrsteBibliotekaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrsteBiblioteka", x => x.VrsteBibliotekaID);
                });

            migrationBuilder.CreateTable(
                name: "Zanr",
                columns: table => new
                {
                    ZanrID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zanr", x => x.ZanrID);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrzavaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradID);
                    table.ForeignKey(
                        name: "FK_Grad_Drzava_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Biblioteka",
                columns: table => new
                {
                    BibliotekaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradID = table.Column<int>(type: "int", nullable: false),
                    VrsteBibliotekaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biblioteka", x => x.BibliotekaID);
                    table.ForeignKey(
                        name: "FK_Biblioteka_Grad_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Biblioteka_VrsteBiblioteka_VrsteBibliotekaID",
                        column: x => x.VrsteBibliotekaID,
                        principalTable: "VrsteBiblioteka",
                        principalColumn: "VrsteBibliotekaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clan",
                columns: table => new
                {
                    ClanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JMBG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktivan = table.Column<bool>(type: "bit", nullable: false),
                    BibliotekaID = table.Column<int>(type: "int", nullable: false),
                    GradID = table.Column<int>(type: "int", nullable: false),
                    UlogaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clan", x => x.ClanID);
                    table.ForeignKey(
                        name: "FK_Clan_Biblioteka_BibliotekaID",
                        column: x => x.BibliotekaID,
                        principalTable: "Biblioteka",
                        principalColumn: "BibliotekaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clan_Grad_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Clan_Uloga_UlogaID",
                        column: x => x.UlogaID,
                        principalTable: "Uloga",
                        principalColumn: "UlogaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Knjiga",
                columns: table => new
                {
                    KnjigaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GodinaIzdavanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Dostupna = table.Column<bool>(type: "bit", nullable: false),
                    BibliotekaID = table.Column<int>(type: "int", nullable: false),
                    ZanrID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knjiga", x => x.KnjigaID);
                    table.ForeignKey(
                        name: "FK_Knjiga_Biblioteka_BibliotekaID",
                        column: x => x.BibliotekaID,
                        principalTable: "Biblioteka",
                        principalColumn: "BibliotekaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Knjiga_Zanr_ZanrID",
                        column: x => x.ZanrID,
                        principalTable: "Zanr",
                        principalColumn: "ZanrID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zaposlenik",
                columns: table => new
                {
                    ZaposlenikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JMBG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktivan = table.Column<bool>(type: "bit", nullable: false),
                    BibliotekaID = table.Column<int>(type: "int", nullable: false),
                    GradID = table.Column<int>(type: "int", nullable: false),
                    UlogaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenik", x => x.ZaposlenikID);
                    table.ForeignKey(
                        name: "FK_Zaposlenik_Biblioteka_BibliotekaID",
                        column: x => x.BibliotekaID,
                        principalTable: "Biblioteka",
                        principalColumn: "BibliotekaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zaposlenik_Grad_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Zaposlenik_Uloga_UlogaID",
                        column: x => x.UlogaID,
                        principalTable: "Uloga",
                        principalColumn: "UlogaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clanarina",
                columns: table => new
                {
                    ClanarinaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipClanarineID = table.Column<int>(type: "int", nullable: false),
                    DatumUplate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Iznos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClanID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clanarina", x => x.ClanarinaID);
                    table.ForeignKey(
                        name: "FK_Clanarina_Clan_ClanID",
                        column: x => x.ClanID,
                        principalTable: "Clan",
                        principalColumn: "ClanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clanarina_TipClanarine_TipClanarineID",
                        column: x => x.TipClanarineID,
                        principalTable: "TipClanarine",
                        principalColumn: "TipClanarineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KnjigaPisac",
                columns: table => new
                {
                    KnjigaPisacID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KnjigaID = table.Column<int>(type: "int", nullable: false),
                    PisacID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnjigaPisac", x => x.KnjigaPisacID);
                    table.ForeignKey(
                        name: "FK_KnjigaPisac_Knjiga_KnjigaID",
                        column: x => x.KnjigaID,
                        principalTable: "Knjiga",
                        principalColumn: "KnjigaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KnjigaPisac_Pisac_PisacID",
                        column: x => x.PisacID,
                        principalTable: "Pisac",
                        principalColumn: "PisacID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KnjigaZanr",
                columns: table => new
                {
                    KnjigaZanrID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KnjigaKategorijaID = table.Column<int>(type: "int", nullable: false),
                    KnjigaID = table.Column<int>(type: "int", nullable: false),
                    ZanrID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnjigaZanr", x => x.KnjigaZanrID);
                    table.ForeignKey(
                        name: "FK_KnjigaZanr_Knjiga_KnjigaID",
                        column: x => x.KnjigaID,
                        principalTable: "Knjiga",
                        principalColumn: "KnjigaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KnjigaZanr_Zanr_ZanrID",
                        column: x => x.ZanrID,
                        principalTable: "Zanr",
                        principalColumn: "ZanrID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RezervacijaKnjige",
                columns: table => new
                {
                    RezervacijaKnjigeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumRezervacije = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClanID = table.Column<int>(type: "int", nullable: false),
                    KnjigaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervacijaKnjige", x => x.RezervacijaKnjigeID);
                    table.ForeignKey(
                        name: "FK_RezervacijaKnjige_Clan_ClanID",
                        column: x => x.ClanID,
                        principalTable: "Clan",
                        principalColumn: "ClanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RezervacijaKnjige_Knjiga_KnjigaID",
                        column: x => x.KnjigaID,
                        principalTable: "Knjiga",
                        principalColumn: "KnjigaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biblioteka_GradID",
                table: "Biblioteka",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Biblioteka_VrsteBibliotekaID",
                table: "Biblioteka",
                column: "VrsteBibliotekaID");

            migrationBuilder.CreateIndex(
                name: "IX_Clan_BibliotekaID",
                table: "Clan",
                column: "BibliotekaID");

            migrationBuilder.CreateIndex(
                name: "IX_Clan_GradID",
                table: "Clan",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Clan_UlogaID",
                table: "Clan",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_Clanarina_ClanID",
                table: "Clanarina",
                column: "ClanID");

            migrationBuilder.CreateIndex(
                name: "IX_Clanarina_TipClanarineID",
                table: "Clanarina",
                column: "TipClanarineID");

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaID",
                table: "Grad",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Knjiga_BibliotekaID",
                table: "Knjiga",
                column: "BibliotekaID");

            migrationBuilder.CreateIndex(
                name: "IX_Knjiga_ZanrID",
                table: "Knjiga",
                column: "ZanrID");

            migrationBuilder.CreateIndex(
                name: "IX_KnjigaPisac_KnjigaID",
                table: "KnjigaPisac",
                column: "KnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_KnjigaPisac_PisacID",
                table: "KnjigaPisac",
                column: "PisacID");

            migrationBuilder.CreateIndex(
                name: "IX_KnjigaZanr_KnjigaID",
                table: "KnjigaZanr",
                column: "KnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_KnjigaZanr_ZanrID",
                table: "KnjigaZanr",
                column: "ZanrID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaKnjige_ClanID",
                table: "RezervacijaKnjige",
                column: "ClanID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaKnjige_KnjigaID",
                table: "RezervacijaKnjige",
                column: "KnjigaID");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenik_BibliotekaID",
                table: "Zaposlenik",
                column: "BibliotekaID");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenik_GradID",
                table: "Zaposlenik",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenik_UlogaID",
                table: "Zaposlenik",
                column: "UlogaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clanarina");

            migrationBuilder.DropTable(
                name: "KnjigaPisac");

            migrationBuilder.DropTable(
                name: "KnjigaZanr");

            migrationBuilder.DropTable(
                name: "RezervacijaKnjige");

            migrationBuilder.DropTable(
                name: "Zaposlenik");

            migrationBuilder.DropTable(
                name: "TipClanarine");

            migrationBuilder.DropTable(
                name: "Pisac");

            migrationBuilder.DropTable(
                name: "Clan");

            migrationBuilder.DropTable(
                name: "Knjiga");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "Biblioteka");

            migrationBuilder.DropTable(
                name: "Zanr");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "VrsteBiblioteka");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
