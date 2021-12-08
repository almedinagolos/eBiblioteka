using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class removedostupno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dostupna",
                table: "Knjiga");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Dostupna",
                table: "Knjiga",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 8, 14, 9, 6, 961, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 8, 14, 9, 6, 961, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 8, 14, 9, 6, 954, DateTimeKind.Local).AddTicks(9617), "mbN4r02QUI3uePWgZ+J99GmSNQo=", "SlZ2FLg++xqEtquwESAYFw==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 8, 14, 9, 6, 961, DateTimeKind.Local).AddTicks(795), "ms6+zoOTYKCVIhPvBhL7NXsp4GM=", "SlZ2FLg++xqEtquwESAYFw==" });
        }
    }
}
