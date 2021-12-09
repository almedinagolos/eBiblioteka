using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class addknjige : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Knjiga",
                columns: new[] { "KnjigaID", "Aktivan", "BibliotekaID", "GodinaIzdavanja", "Naziv", "Opis", "Slika", "ZanrID" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTime(1971, 12, 9, 19, 38, 49, 62, DateTimeKind.Local).AddTicks(5658), "Derviš i smrt", "", new byte[0], 1 },
                    { 2, true, 1, new DateTime(1901, 12, 9, 19, 38, 49, 62, DateTimeKind.Local).AddTicks(8334), "Mali princ", "", new byte[0], 2 }
                });

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 9, 19, 38, 49, 62, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 9, 19, 38, 49, 62, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 9, 19, 38, 49, 55, DateTimeKind.Local).AddTicks(6820), "AhxSN4VqjXRGhPTOneVcbNDYF30=", "Ox23pKWvhmSASL6m1tNAhQ==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 9, 19, 38, 49, 61, DateTimeKind.Local).AddTicks(7088), "S9lx5QuWrtiKSLaJcjwZHkqnM4Y=", "Ox23pKWvhmSASL6m1tNAhQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 8, 14, 28, 23, 615, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 8, 14, 28, 23, 615, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 8, 14, 28, 23, 607, DateTimeKind.Local).AddTicks(3505), "zxcJ1ONroGftFKWOcQdM/i/gWcc=", "Lw60CcnFsn1kR9dIB6iO/w==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 8, 14, 28, 23, 613, DateTimeKind.Local).AddTicks(9630), "8mZic30UnX0byOOlST264JDEZa8=", "Lw60CcnFsn1kR9dIB6iO/w==" });
        }
    }
}
