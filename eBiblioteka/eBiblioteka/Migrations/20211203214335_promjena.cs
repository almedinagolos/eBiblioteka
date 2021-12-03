using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class promjena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clan_Uloga_UlogaID",
                table: "Clan");

            migrationBuilder.DropIndex(
                name: "IX_Clan_UlogaID",
                table: "Clan");

            migrationBuilder.DropColumn(
                name: "UlogaID",
                table: "Clan");

            migrationBuilder.AddColumn<bool>(
                name: "Aktivan",
                table: "Knjiga",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 3, 22, 43, 34, 323, DateTimeKind.Local).AddTicks(3686), "IyA+M3zcRo80kpwnqkwTwYwGeCI=", "IbOPwWK610ML6boWaeFDng==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aktivan",
                table: "Knjiga");

            migrationBuilder.AddColumn<int>(
                name: "UlogaID",
                table: "Clan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 3, 19, 7, 43, 31, DateTimeKind.Local).AddTicks(7475), "MWYUDPvRjwnunAySjAQn/cfUsDQ=", "ymDH6pTzmcOVAEgAI5XuJw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Clan_UlogaID",
                table: "Clan",
                column: "UlogaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clan_Uloga_UlogaID",
                table: "Clan",
                column: "UlogaID",
                principalTable: "Uloga",
                principalColumn: "UlogaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
