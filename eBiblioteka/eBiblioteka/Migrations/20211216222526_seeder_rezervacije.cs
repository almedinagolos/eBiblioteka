using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBiblioteka.Migrations
{
    public partial class seeder_rezervacije : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "DatumUplate",
                value: new DateTime(2021, 11, 16, 23, 25, 24, 168, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 2,
                column: "DatumUplate",
                value: new DateTime(2021, 10, 16, 23, 25, 24, 168, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 3,
                column: "DatumUplate",
                value: new DateTime(2021, 9, 16, 23, 25, 24, 168, DateTimeKind.Local).AddTicks(1636));

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

            migrationBuilder.InsertData(
                table: "RezervacijaKnjige",
                columns: new[] { "RezervacijaKnjigeID", "ClanID", "DatumRezervacije", "KnjigaID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 12, 16, 23, 25, 24, 168, DateTimeKind.Local).AddTicks(5966), 1 },
                    { 2, 2, new DateTime(2021, 12, 9, 23, 25, 24, 168, DateTimeKind.Local).AddTicks(6498), 2 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RezervacijaKnjige",
                keyColumn: "RezervacijaKnjigeID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1988, 12, 16, 23, 10, 37, 894, DateTimeKind.Local).AddTicks(5255), "2h3oQI9W7DSsO4ARWwkAZYV5dWk=", "0CFsq6wfucfFWgd5JC7bmw==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2001, 12, 16, 23, 10, 37, 894, DateTimeKind.Local).AddTicks(8311), "Y/J7DnvhsN0lL1hgdhKnRFIMuIw=", "0CFsq6wfucfFWgd5JC7bmw==" });

            migrationBuilder.UpdateData(
                table: "Clan",
                keyColumn: "ClanID",
                keyValue: 3,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1986, 12, 16, 23, 10, 37, 894, DateTimeKind.Local).AddTicks(8681), "ULlKRDChvR0sVsou6hkOfhkwZWg=", "0CFsq6wfucfFWgd5JC7bmw==" });

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 1,
                column: "DatumUplate",
                value: new DateTime(2021, 11, 16, 23, 10, 37, 898, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 2,
                column: "DatumUplate",
                value: new DateTime(2021, 10, 16, 23, 10, 37, 898, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Clanarina",
                keyColumn: "ClanarinaID",
                keyValue: 3,
                column: "DatumUplate",
                value: new DateTime(2021, 9, 16, 23, 10, 37, 898, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 1,
                column: "GodinaIzdavanja",
                value: new DateTime(1965, 12, 16, 23, 10, 37, 896, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 2,
                column: "GodinaIzdavanja",
                value: new DateTime(1942, 12, 16, 23, 10, 37, 897, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "KnjigaID",
                keyValue: 3,
                column: "GodinaIzdavanja",
                value: new DateTime(1941, 12, 16, 23, 10, 37, 897, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 16, 23, 10, 37, 895, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(1921, 12, 16, 23, 10, 37, 895, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "PisacID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(1912, 12, 16, 23, 10, 37, 895, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 16, 23, 10, 37, 888, DateTimeKind.Local).AddTicks(7674), "eo+yxHbe3mbHDGJ1KWrIpsTaH48=", "0CFsq6wfucfFWgd5JC7bmw==" });

            migrationBuilder.UpdateData(
                table: "Zaposlenik",
                keyColumn: "ZaposlenikID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(1999, 12, 16, 23, 10, 37, 893, DateTimeKind.Local).AddTicks(7321), "E2XSaGRZ0z2GSRo7+F21Bm/TD2A=", "0CFsq6wfucfFWgd5JC7bmw==" });
        }
    }
}
