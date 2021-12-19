using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class rezervacija_izdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Izdata",
                table: "RezervacijaKnjige",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1988, 12, 19, 13, 51, 13, 502, DateTimeKind.Local).AddTicks(2762), "xcfcSJ6SiGw1h4/SzU24MrPaQtg=", "dU3+13qFuKOmRhM3Ljzztw==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2001, 12, 19, 13, 51, 13, 502, DateTimeKind.Local).AddTicks(6089), "K0bmJpQWoskOlz7Up6GUHC7eae8=", "dU3+13qFuKOmRhM3Ljzztw==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 3,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1986, 12, 19, 13, 51, 13, 502, DateTimeKind.Local).AddTicks(6483), "qTVtuespn+DxYRHPDNmmQEzAhKk=", "dU3+13qFuKOmRhM3Ljzztw==" });

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 1,
                column: "DatumUplate",
                value: new DateTime(2021, 11, 19, 13, 51, 13, 508, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 2,
                column: "DatumUplate",
                value: new DateTime(2021, 10, 19, 13, 51, 13, 508, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 3,
                column: "DatumUplate",
                value: new DateTime(2021, 9, 19, 13, 51, 13, 508, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 1,
                column: "GodinaIzdavanja",
                value: new DateTime(1965, 12, 19, 13, 51, 13, 503, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 2,
                column: "GodinaIzdavanja",
                value: new DateTime(1942, 12, 19, 13, 51, 13, 505, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 3,
                column: "GodinaIzdavanja",
                value: new DateTime(1941, 12, 19, 13, 51, 13, 506, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 19, 13, 51, 13, 503, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 19, 13, 51, 13, 503, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(1912, 12, 19, 13, 51, 13, 503, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 1,
                column: "DatumRezervacije",
                value: new DateTime(2021, 12, 19, 13, 51, 13, 509, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 2,
                column: "DatumRezervacije",
                value: new DateTime(2021, 12, 12, 13, 51, 13, 509, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 19, 13, 51, 13, 495, DateTimeKind.Local).AddTicks(3731), "KYRtC/TWDCRxshI36Ad2UNi1xjk=", "dU3+13qFuKOmRhM3Ljzztw==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 19, 13, 51, 13, 501, DateTimeKind.Local).AddTicks(5306), "V7JQ3gsS3eJAozJkJFB+FaaQJTU=", "dU3+13qFuKOmRhM3Ljzztw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Izdata",
                table: "RezervacijaKnjige");

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
                column: "DatumRezervacije",
                value: new DateTime(2021, 12, 18, 21, 24, 58, 956, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 2,
                column: "DatumRezervacije",
                value: new DateTime(2021, 12, 11, 21, 24, 58, 956, DateTimeKind.Local).AddTicks(9531));

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
    }
}
