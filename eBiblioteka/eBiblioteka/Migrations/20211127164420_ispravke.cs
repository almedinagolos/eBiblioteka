using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class ispravke : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lozinka",
                table: "Zaposlenik",
                newName: "LozinkaSalt");

            migrationBuilder.AddColumn<string>(
                name: "LozinkaHash",
                table: "Zaposlenik",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "VrsteBiblioteka",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Aktivan",
                table: "Biblioteka",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LozinkaHash",
                table: "Zaposlenik");

            migrationBuilder.DropColumn(
                name: "Aktivan",
                table: "Biblioteka");

            migrationBuilder.RenameColumn(
                name: "LozinkaSalt",
                table: "Zaposlenik",
                newName: "Lozinka");

            migrationBuilder.AlterColumn<int>(
                name: "Naziv",
                table: "VrsteBiblioteka",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
