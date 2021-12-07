using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class ClanPasswordHash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lozinka",
                table: "Clan",
                newName: "LozinkaSalt");

            migrationBuilder.AddColumn<string>(
                name: "LozinkaHash",
                table: "Clan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 7, 21, 39, 6, 387, DateTimeKind.Local).AddTicks(864), "4ReZxrrvRUNRxNZB2fWMbiqJ5Ks=", "b6ACuH3gF9VLtOHvHEeGRg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LozinkaHash",
                table: "Clan");

            migrationBuilder.RenameColumn(
                name: "LozinkaSalt",
                table: "Clan",
                newName: "Lozinka");

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 7, 20, 1, 27, 21, DateTimeKind.Local).AddTicks(2439), "B12DnBwiIW8s7IVNrbsuwrtTbxw=", "9i7Dv4gf7rbzNvjpa/JM4g==" });
        }
    }
}
