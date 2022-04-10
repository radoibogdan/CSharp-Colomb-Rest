using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Colomb.Migrations
{
    public partial class ChangeFakeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Evenements",
                keyColumn: "EvenementId",
                keyValue: 1,
                columns: new[] { "Date", "HeureFermeture", "HeureOuverture" },
                values: new object[] { new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Evenements",
                keyColumn: "EvenementId",
                keyValue: 2,
                columns: new[] { "Date", "HeureFermeture", "HeureOuverture" },
                values: new object[] { new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Evenements",
                keyColumn: "EvenementId",
                keyValue: 3,
                columns: new[] { "Date", "HeureFermeture", "HeureOuverture" },
                values: new object[] { new DateTime(2022, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Evenements",
                keyColumn: "EvenementId",
                keyValue: 1,
                columns: new[] { "Date", "HeureFermeture", "HeureOuverture" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Evenements",
                keyColumn: "EvenementId",
                keyValue: 2,
                columns: new[] { "Date", "HeureFermeture", "HeureOuverture" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 19, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Evenements",
                keyColumn: "EvenementId",
                keyValue: 3,
                columns: new[] { "Date", "HeureFermeture", "HeureOuverture" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
