using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class rezervacija_aktiavn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Aktivan",
                table: "RezervacijaKnjige",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1988, 12, 18, 21, 24, 58, 950, DateTimeKind.Local).AddTicks(4870), "JCYw1srCB8L3yDhj7xQHTihStTQ=", "FQ1VbLfai0qwKoEvkJRc2w==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2001, 12, 18, 21, 24, 58, 951, DateTimeKind.Local).AddTicks(6494), "+9dxeU9/M2MllpMvFllVxVm6fQY=", "FQ1VbLfai0qwKoEvkJRc2w==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 3,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1986, 12, 18, 21, 24, 58, 951, DateTimeKind.Local).AddTicks(6935), "9/OfEhoML4GwPoa7AJd2rn+wjBk=", "FQ1VbLfai0qwKoEvkJRc2w==" });

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 1,
                column: "DatumUplate",
                value: new DateTime(2021, 11, 18, 21, 24, 58, 955, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 2,
                column: "DatumUplate",
                value: new DateTime(2021, 10, 18, 21, 24, 58, 955, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 3,
                column: "DatumUplate",
                value: new DateTime(2021, 9, 18, 21, 24, 58, 956, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 1,
                column: "GodinaIzdavanja",
                value: new DateTime(1965, 12, 18, 21, 24, 58, 953, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 2,
                column: "GodinaIzdavanja",
                value: new DateTime(1942, 12, 18, 21, 24, 58, 954, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 3,
                column: "GodinaIzdavanja",
                value: new DateTime(1941, 12, 18, 21, 24, 58, 955, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 18, 21, 24, 58, 952, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 18, 21, 24, 58, 952, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(1912, 12, 18, 21, 24, 58, 952, DateTimeKind.Local).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 1,
                columns: new[] { "Aktivan", "DatumRezervacije" },
                values: new object[] { true, new DateTime(2021, 12, 18, 21, 24, 58, 956, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 2,
                columns: new[] { "Aktivan", "DatumRezervacije" },
                values: new object[] { true, new DateTime(2021, 12, 11, 21, 24, 58, 956, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 18, 21, 24, 58, 941, DateTimeKind.Local).AddTicks(7518), "9312mx8bruP9hnmc2XuyjhsTjW8=", "FQ1VbLfai0qwKoEvkJRc2w==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 18, 21, 24, 58, 949, DateTimeKind.Local).AddTicks(4689), "+4+TMBvsWJH+ddfDRxrZ2t/nfcc=", "FQ1VbLfai0qwKoEvkJRc2w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aktivan",
                table: "RezervacijaKnjige");

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
                column: "DatumUplate",
                value: new DateTime(2021, 11, 18, 19, 29, 53, 962, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 2,
                column: "DatumUplate",
                value: new DateTime(2021, 10, 18, 19, 29, 53, 962, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 3,
                column: "DatumUplate",
                value: new DateTime(2021, 9, 18, 19, 29, 53, 962, DateTimeKind.Local).AddTicks(2731));

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
    }
}
