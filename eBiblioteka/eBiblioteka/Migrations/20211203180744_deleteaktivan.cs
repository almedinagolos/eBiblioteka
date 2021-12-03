using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class deleteaktivan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Aktivan",
                table: "VrsteBiblioteka",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Aktivan",
                table: "Grad",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Aktivan",
                table: "Drzava",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "DrzavaID",
                keyValue: 1,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "DrzavaID",
                keyValue: 2,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "DrzavaID",
                keyValue: 3,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "DrzavaID",
                keyValue: 4,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 1,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 2,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 3,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 4,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 5,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 6,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 7,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 8,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 9,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "VrsteBiblioteka",
                keyColumn: "VrsteBibliotekaID",
                keyValue: 1,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "VrsteBiblioteka",
                keyColumn: "VrsteBibliotekaID",
                keyValue: 2,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "VrsteBiblioteka",
                keyColumn: "VrsteBibliotekaID",
                keyValue: 3,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "VrsteBiblioteka",
                keyColumn: "VrsteBibliotekaID",
                keyValue: 4,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "VrsteBiblioteka",
                keyColumn: "VrsteBibliotekaID",
                keyValue: 5,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "VrsteBiblioteka",
                keyColumn: "VrsteBibliotekaID",
                keyValue: 6,
                column: "Aktivan",
                value: true);

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 3, 19, 7, 43, 31, DateTimeKind.Local).AddTicks(7475), "MWYUDPvRjwnunAySjAQn/cfUsDQ=", "ymDH6pTzmcOVAEgAI5XuJw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aktivan",
                table: "VrsteBiblioteka");

            migrationBuilder.DropColumn(
                name: "Aktivan",
                table: "Grad");

            migrationBuilder.DropColumn(
                name: "Aktivan",
                table: "Drzava");

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 11, 27, 17, 51, 38, 801, DateTimeKind.Local).AddTicks(4863), "96EktwgZQyRuoc3k87hzWMb73W4=", "iRzNjJfpeGm9ArHOh06CeQ==" });
        }
    }
}
