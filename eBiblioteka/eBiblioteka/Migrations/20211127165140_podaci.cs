using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class podaci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Drzava",
                columns: new[] { "DrzavaID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Bosna i Hercegovina" },
                    { 2, "Srbija" },
                    { 3, "Hrvatska" },
                    { 4, "Velika Britanija" }
                });

            migrationBuilder.InsertData(
                table: "Uloga",
                columns: new[] { "UlogaID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Zaposlenik" }
                });

            migrationBuilder.InsertData(
                table: "VrsteBiblioteka",
                columns: new[] { "VrsteBibliotekaID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Školska" },
                    { 2, "Univerzitetska" },
                    { 3, "Narodna" },
                    { 4, "Internacionalna" },
                    { 5, "Nacionalna" },
                    { 6, "Dječija" }
                });

            migrationBuilder.InsertData(
                table: "Grad",
                columns: new[] { "GradID", "DrzavaID", "Naziv" },
                values: new object[,]
                {
                    { 1, 1, "Sarajevo" },
                    { 2, 1, "Mostar" },
                    { 3, 1, "Banja Luka" },
                    { 4, 2, "Beograd" },
                    { 5, 3, "Zagreb" },
                    { 6, 4, "London" },
                    { 7, 4, "Cardiff" },
                    { 8, 4, "Edinburgh" },
                    { 9, 4, "Belfast" }
                });

            migrationBuilder.InsertData(
                table: "Biblioteka",
                columns: new[] { "BibliotekaID", "Adresa", "Aktivan", "BrojTelefona", "Email", "GradID", "Naziv", "VrsteBibliotekaID" },
                values: new object[] { 1, "Branislava Nušića 95", true, "033/461-300", "aleksa_santic@bih.net.ba", 1, "Školska biblioteka Aleksa Šantić", 1 });

            migrationBuilder.InsertData(
                table: "Biblioteka",
                columns: new[] { "BibliotekaID", "Adresa", "Aktivan", "BrojTelefona", "Email", "GradID", "Naziv", "VrsteBibliotekaID" },
                values: new object[] { 2, "Univerzitetski kampus", true, "036/571-543", "biblioteka@unmo.ba", 2, "Univerzitetska biblioteka Džemal Bijedić", 2 });

            migrationBuilder.InsertData(
                table: "Zaposlenik",
                columns: new[] { "ZaposlenikID", "Adresa", "Aktivan", "BibliotekaID", "DatumRodjenja", "Email", "GradID", "Ime", "JMBG", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "UlogaID" },
                values: new object[] { 1, "Mostar", true, 2, new DateTime(1999, 11, 27, 17, 51, 38, 801, DateTimeKind.Local).AddTicks(4863), "admin@mail.com", 2, "Admin", "0101999155999", "admin", "96EktwgZQyRuoc3k87hzWMb73W4=", "iRzNjJfpeGm9ArHOh06CeQ==", "Admin", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Biblioteka",
                keyColumn: "BibliotekaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Uloga",
                keyColumn: "UlogaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VrsteBiblioteka",
                keyColumn: "VrsteBibliotekaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VrsteBiblioteka",
                keyColumn: "VrsteBibliotekaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VrsteBiblioteka",
                keyColumn: "VrsteBibliotekaID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VrsteBiblioteka",
                keyColumn: "VrsteBibliotekaID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Biblioteka",
                keyColumn: "BibliotekaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drzava",
                keyColumn: "DrzavaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drzava",
                keyColumn: "DrzavaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Drzava",
                keyColumn: "DrzavaID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Uloga",
                keyColumn: "UlogaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VrsteBiblioteka",
                keyColumn: "VrsteBibliotekaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VrsteBiblioteka",
                keyColumn: "VrsteBibliotekaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drzava",
                keyColumn: "DrzavaID",
                keyValue: 1);
        }
    }
}
