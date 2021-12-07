using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class uloga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Aktivan",
                table: "Zanr",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Aktivan",
                table: "Uloga",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Aktivan",
                table: "Pisac",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Uloga",
                keyColumn: "UlogaID",
                keyValue: 1,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Uloga",
                keyColumn: "UlogaID",
                keyValue: 2,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 7, 20, 1, 27, 21, DateTimeKind.Local).AddTicks(2439), "B12DnBwiIW8s7IVNrbsuwrtTbxw=", "9i7Dv4gf7rbzNvjpa/JM4g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aktivan",
                table: "Zanr");

            migrationBuilder.DropColumn(
                name: "Aktivan",
                table: "Uloga");

            migrationBuilder.DropColumn(
                name: "Aktivan",
                table: "Pisac");

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 3, 22, 43, 34, 323, DateTimeKind.Local).AddTicks(3686), "IyA+M3zcRo80kpwnqkwTwYwGeCI=", "IbOPwWK610ML6boWaeFDng==" });
        }
    }
}
