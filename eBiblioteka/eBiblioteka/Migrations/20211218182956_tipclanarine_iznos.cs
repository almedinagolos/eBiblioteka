using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class tipclanarine_iznos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Iznos",
                table: "TipClanarine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1988, 12, 18, 19, 29, 53, 958, DateTimeKind.Local).AddTicks(209), "sqvTt3DGpVR1Qy4Nc5Yl/7Tii0o=", "2SX60rCoLox5Vq0+JW+0uQ==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2001, 12, 18, 19, 29, 53, 958, DateTimeKind.Local).AddTicks(2330), "xTjNA6siCaEEBy4aL90/zi5ea2s=", "2SX60rCoLox5Vq0+JW+0uQ==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 3,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1986, 12, 18, 19, 29, 53, 958, DateTimeKind.Local).AddTicks(2602), "LM2xlAGJSUUB6ZqxurRdIKW9Ttg=", "2SX60rCoLox5Vq0+JW+0uQ==" });

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 1,
                columns: new[] { "DatumUplate", "Iznos" },
                values: new object[] { new DateTime(2021, 11, 18, 19, 29, 53, 962, DateTimeKind.Local).AddTicks(157), "200" });

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 2,
                columns: new[] { "DatumUplate", "Iznos" },
                values: new object[] { new DateTime(2021, 10, 18, 19, 29, 53, 962, DateTimeKind.Local).AddTicks(2637), "200" });

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 3,
                columns: new[] { "DatumUplate", "Iznos" },
                values: new object[] { new DateTime(2021, 9, 18, 19, 29, 53, 962, DateTimeKind.Local).AddTicks(2731), "200" });

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 1,
                column: "GodinaIzdavanja",
                value: new DateTime(1965, 12, 18, 19, 29, 53, 959, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 2,
                column: "GodinaIzdavanja",
                value: new DateTime(1942, 12, 18, 19, 29, 53, 960, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 3,
                column: "GodinaIzdavanja",
                value: new DateTime(1941, 12, 18, 19, 29, 53, 961, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 18, 19, 29, 53, 958, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 18, 19, 29, 53, 959, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(1912, 12, 18, 19, 29, 53, 959, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 1,
                column: "DatumRezervacije",
                value: new DateTime(2021, 12, 18, 19, 29, 53, 962, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 2,
                column: "DatumRezervacije",
                value: new DateTime(2021, 12, 11, 19, 29, 53, 962, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "TipClanarine",
                keyColumn: "TipClanarineID",
                keyValue: 1,
                column: "Iznos",
                value: 20);

            migrationBuilder.UpdateData(
                table: "TipClanarine",
                keyColumn: "TipClanarineID",
                keyValue: 2,
                column: "Iznos",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 18, 19, 29, 53, 948, DateTimeKind.Local).AddTicks(3346), "Rjjvr0MO+eziS86cY4Km+SLNIH4=", "2SX60rCoLox5Vq0+JW+0uQ==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 18, 19, 29, 53, 957, DateTimeKind.Local).AddTicks(5180), "TQqlaoCkz2dX5Li/o7LWbOxYVYU=", "2SX60rCoLox5Vq0+JW+0uQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iznos",
                table: "TipClanarine");

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1988, 12, 16, 23, 25, 24, 164, DateTimeKind.Local).AddTicks(447), "sWsZtmxYSf9JMwpsPCJ9Rfsygyo=", "kKIW8IPeytK3QcFxqwvqiQ==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2001, 12, 16, 23, 25, 24, 164, DateTimeKind.Local).AddTicks(4237), "yJVLulx8vwgT6oGthLzL1Rt7pho=", "kKIW8IPeytK3QcFxqwvqiQ==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 3,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1986, 12, 16, 23, 25, 24, 164, DateTimeKind.Local).AddTicks(4606), "avwA86SSdrHZ2ZBmHmyPC28B58g=", "kKIW8IPeytK3QcFxqwvqiQ==" });

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 1,
                columns: new[] { "DatumUplate", "Iznos" },
                values: new object[] { new DateTime(2021, 11, 16, 23, 25, 24, 168, DateTimeKind.Local).AddTicks(43), "100" });

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 2,
                columns: new[] { "DatumUplate", "Iznos" },
                values: new object[] { new DateTime(2021, 10, 16, 23, 25, 24, 168, DateTimeKind.Local).AddTicks(1571), "100" });

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 3,
                columns: new[] { "DatumUplate", "Iznos" },
                values: new object[] { new DateTime(2021, 9, 16, 23, 25, 24, 168, DateTimeKind.Local).AddTicks(1636), "100" });

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 1,
                column: "GodinaIzdavanja",
                value: new DateTime(1965, 12, 16, 23, 25, 24, 165, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 2,
                column: "GodinaIzdavanja",
                value: new DateTime(1942, 12, 16, 23, 25, 24, 166, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 3,
                column: "GodinaIzdavanja",
                value: new DateTime(1941, 12, 16, 23, 25, 24, 167, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 16, 23, 25, 24, 165, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 16, 23, 25, 24, 165, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(1912, 12, 16, 23, 25, 24, 165, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 1,
                column: "DatumRezervacije",
                value: new DateTime(2021, 12, 16, 23, 25, 24, 168, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 2,
                column: "DatumRezervacije",
                value: new DateTime(2021, 12, 9, 23, 25, 24, 168, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 16, 23, 25, 24, 158, DateTimeKind.Local).AddTicks(2680), "X4hliC54u6bkuLgB3xp7/t995mk=", "kKIW8IPeytK3QcFxqwvqiQ==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 16, 23, 25, 24, 163, DateTimeKind.Local).AddTicks(2978), "asF1GTKUOyboNiObYBsbmENPndU=", "kKIW8IPeytK3QcFxqwvqiQ==" });
        }
    }
}
