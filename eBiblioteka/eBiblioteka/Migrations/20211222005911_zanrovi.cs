using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class zanrovi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1988, 12, 22, 1, 58, 58, 706, DateTimeKind.Local).AddTicks(7623), "hs8z6RtvLkpAwW18F4MMoJRhFl4=", "h7EwLgu9tB1l0C0KJViodw==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2001, 12, 22, 1, 58, 58, 707, DateTimeKind.Local).AddTicks(1495), "w2Eco/BIzDoucgBX/7W/9RMQF8g=", "h7EwLgu9tB1l0C0KJViodw==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 3,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1986, 12, 22, 1, 58, 58, 707, DateTimeKind.Local).AddTicks(2038), "q2xCiAo75q120CVSOFWnUdKPrxQ=", "h7EwLgu9tB1l0C0KJViodw==" });

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 1,
                column: "DatumUplate",
                value: new DateTime(2021, 11, 22, 1, 58, 58, 716, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 2,
                column: "DatumUplate",
                value: new DateTime(2021, 10, 22, 1, 58, 58, 716, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 3,
                column: "DatumUplate",
                value: new DateTime(2021, 9, 22, 1, 58, 58, 716, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 1,
                column: "GodinaIzdavanja",
                value: new DateTime(1965, 12, 22, 1, 58, 58, 709, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 2,
                columns: new[] { "GodinaIzdavanja", "ZanrID" },
                values: new object[] { new DateTime(1942, 12, 22, 1, 58, 58, 711, DateTimeKind.Local).AddTicks(5754), 1 });

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 3,
                columns: new[] { "GodinaIzdavanja", "ZanrID" },
                values: new object[] { new DateTime(1941, 12, 22, 1, 58, 58, 712, DateTimeKind.Local).AddTicks(4992), 1 });

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 4,
                column: "GodinaIzdavanja",
                value: new DateTime(1936, 12, 22, 1, 58, 58, 713, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 5,
                column: "GodinaIzdavanja",
                value: new DateTime(1936, 12, 22, 1, 58, 58, 714, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 6,
                column: "GodinaIzdavanja",
                value: new DateTime(1936, 12, 22, 1, 58, 58, 715, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 22, 1, 58, 58, 708, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 22, 1, 58, 58, 708, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(1912, 12, 22, 1, 58, 58, 708, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(1912, 12, 22, 1, 58, 58, 708, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 1,
                column: "DatumRezervacije",
                value: new DateTime(2021, 12, 22, 1, 58, 58, 717, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 2,
                column: "DatumRezervacije",
                value: new DateTime(2021, 12, 15, 1, 58, 58, 717, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 22, 1, 58, 58, 681, DateTimeKind.Local).AddTicks(8381), "tzpD0HaBf8SVNUHPBCPftdA9wRg=", "h7EwLgu9tB1l0C0KJViodw==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 22, 1, 58, 58, 704, DateTimeKind.Local).AddTicks(3611), "kZPgY3TigQ+SJWDmGDOT3q0dxRI=", "h7EwLgu9tB1l0C0KJViodw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1988, 12, 20, 21, 0, 50, 747, DateTimeKind.Local).AddTicks(7992), "TAI9v4Gq/3CUjcAM7pDyYwEXo80=", "D8NKfF7oLCFzRFg5URAeyQ==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2001, 12, 20, 21, 0, 50, 748, DateTimeKind.Local).AddTicks(174), "+1CYoVd2/+TKTKm58/gnanNy3Bg=", "D8NKfF7oLCFzRFg5URAeyQ==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 3,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1986, 12, 20, 21, 0, 50, 748, DateTimeKind.Local).AddTicks(440), "8tD3l52MSurWwHgHQHuEQv5hS0E=", "D8NKfF7oLCFzRFg5URAeyQ==" });

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 1,
                column: "DatumUplate",
                value: new DateTime(2021, 11, 20, 21, 0, 50, 751, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 2,
                column: "DatumUplate",
                value: new DateTime(2021, 10, 20, 21, 0, 50, 751, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 3,
                column: "DatumUplate",
                value: new DateTime(2021, 9, 20, 21, 0, 50, 751, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 1,
                column: "GodinaIzdavanja",
                value: new DateTime(1965, 12, 20, 21, 0, 50, 749, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 2,
                columns: new[] { "GodinaIzdavanja", "ZanrID" },
                values: new object[] { new DateTime(1942, 12, 20, 21, 0, 50, 749, DateTimeKind.Local).AddTicks(8382), 2 });

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 3,
                columns: new[] { "GodinaIzdavanja", "ZanrID" },
                values: new object[] { new DateTime(1941, 12, 20, 21, 0, 50, 750, DateTimeKind.Local).AddTicks(740), 4 });

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 4,
                column: "GodinaIzdavanja",
                value: new DateTime(1936, 12, 20, 21, 0, 50, 750, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 5,
                column: "GodinaIzdavanja",
                value: new DateTime(1936, 12, 20, 21, 0, 50, 750, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 6,
                column: "GodinaIzdavanja",
                value: new DateTime(1936, 12, 20, 21, 0, 50, 750, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 20, 21, 0, 50, 748, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 20, 21, 0, 50, 748, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(1912, 12, 20, 21, 0, 50, 748, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(1912, 12, 20, 21, 0, 50, 748, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 1,
                column: "DatumRezervacije",
                value: new DateTime(2021, 12, 20, 21, 0, 50, 752, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 2,
                column: "DatumRezervacije",
                value: new DateTime(2021, 12, 13, 21, 0, 50, 752, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 20, 21, 0, 50, 738, DateTimeKind.Local).AddTicks(695), "n4aiLl2Kyf1J49kiawBiM9nCnZI=", "D8NKfF7oLCFzRFg5URAeyQ==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 20, 21, 0, 50, 746, DateTimeKind.Local).AddTicks(9766), "lqw4k8f3gjUCVYjJUwcB8hgQ5lc=", "D8NKfF7oLCFzRFg5URAeyQ==" });
        }
    }
}
