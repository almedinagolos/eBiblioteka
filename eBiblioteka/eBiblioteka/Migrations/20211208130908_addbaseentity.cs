using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class addbaseentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Aktivan",
                table: "TipClanarine",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Aktivan",
                table: "Clanarina",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Pisac",
                columns: new[] { "PisacID", "Aktivan", "Biografija", "DatumRodjenja", "Ime", "Prezime" },
                values: new object[,]
                {
                    { 1, true, "Ivo Andrić se rodio u Travniku, u hrvatskoj obitelji Antuna Andrića, sudskoga podvornika i Katarine Pejić. Mjesec dana po rođenju, dana 9. studenog 1892. godine, u Crkvi sv. Ivana Krstitelja u rodnom mjestu kršten je u katolika. U dobi od dvije godine ostaje bez oca i uskoro se s majkom seli u Višegrad kod očeve sestre Ane i njezinog muža Ivana Matkovšika, graničnog policajca.", new DateTime(1921, 12, 8, 14, 9, 6, 961, DateTimeKind.Local).AddTicks(7562), "Ivo", "Andrić" },
                    { 2, true, "Rodio se u uglednoj muslimanskoj porodici iz Bileće, od oca Alije i majke Paše. Njegov otac Alija rodio se u Visokom, prilikom selidbe njegove porodice iz Bileće prema sjeveroistoku Bosne gdje su imali znatna imanja. Meša je rođen u Tuzli, gdje je završio osnovnu školu i gimnaziju. ", new DateTime(1921, 12, 8, 14, 9, 6, 961, DateTimeKind.Local).AddTicks(8155), "Meša", "Selimović" }
                });

            migrationBuilder.InsertData(
                table: "TipClanarine",
                columns: new[] { "TipClanarineID", "Aktivan", "Naziv" },
                values: new object[,]
                {
                    { 1, true, "Mjesečna" },
                    { 2, true, "Godišnja" }
                });

            migrationBuilder.InsertData(
                table: "Zanr",
                columns: new[] { "ZanrID", "Aktivan", "Naziv" },
                values: new object[,]
                {
                    { 1, true, "Dramski romani" },
                    { 2, true, "Enciklopedistika" },
                    { 3, true, "Fantastika" },
                    { 4, true, "Putopis" },
                    { 5, true, "Naučni" }
                });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 8, 14, 9, 6, 954, DateTimeKind.Local).AddTicks(9617), "mbN4r02QUI3uePWgZ+J99GmSNQo=", "SlZ2FLg++xqEtquwESAYFw==" });

            migrationBuilder.InsertData(
                table: "Zaposlenik",
                columns: new[] { "ZaposlenikID", "Adresa", "Aktivan", "BibliotekaID", "DatumRodjenja", "Email", "GradID", "Ime", "JMBG", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "UlogaID" },
                values: new object[] { 2, "BP bb", true, 1, new DateTime(1999, 12, 8, 14, 9, 6, 961, DateTimeKind.Local).AddTicks(795), "almedina.golos@mail.com", 1, "Almedina", "0101111111001", "almedina.golos", "ms6+zoOTYKCVIhPvBhL7NXsp4GM=", "SlZ2FLg++xqEtquwESAYFw==", "Gološ", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipClanarine",
                keyColumn: "TipClanarineID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipClanarine",
                keyColumn: "TipClanarineID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "ZanrID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "ZanrID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "ZanrID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "ZanrID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "ZanrID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Aktivan",
                table: "TipClanarine");

            migrationBuilder.DropColumn(
                name: "Aktivan",
                table: "Clanarina");

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 7, 21, 39, 6, 387, DateTimeKind.Local).AddTicks(864), "4ReZxrrvRUNRxNZB2fWMbiqJ5Ks=", "b6ACuH3gF9VLtOHvHEeGRg==" });
        }
    }
}
