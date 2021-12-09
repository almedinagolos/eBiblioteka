using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class Default_True : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 1,
                column: "GodinaIzdavanja",
                value: new DateTime(1971, 12, 9, 20, 8, 34, 773, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 2,
                column: "GodinaIzdavanja",
                value: new DateTime(1901, 12, 9, 20, 8, 34, 774, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 9, 20, 8, 34, 773, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 9, 20, 8, 34, 773, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 9, 20, 8, 34, 765, DateTimeKind.Local).AddTicks(1746), "qZFyOmG8ZBQBchhk/BOJek/A51c=", "5/ZdB7gfCoVe+xTlnNAPRA==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 9, 20, 8, 34, 772, DateTimeKind.Local).AddTicks(2470), "jtguNwQXEI4v8d9a/PVKWb8tJ3g=", "5/ZdB7gfCoVe+xTlnNAPRA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 1,
                column: "GodinaIzdavanja",
                value: new DateTime(1971, 12, 9, 19, 44, 10, 61, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 2,
                column: "GodinaIzdavanja",
                value: new DateTime(1901, 12, 9, 19, 44, 10, 62, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 9, 19, 44, 10, 61, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 9, 19, 44, 10, 61, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 9, 19, 44, 10, 52, DateTimeKind.Local).AddTicks(1791), "BV3fTI5dhUT39UZMnJuOp1kdZdQ=", "XRlwC1tozpMDSlShJ/7/MA==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 9, 19, 44, 10, 60, DateTimeKind.Local).AddTicks(6587), "8obAu8hGgfabhO14b50xg/vOw/Y=", "XRlwC1tozpMDSlShJ/7/MA==" });
        }
    }
}
