using Microsoft.EntityFrameworkCore.Migrations;

namespace Colomb.Migrations
{
    public partial class AddedRolesUserAndAdministrator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0dfa321e-4c90-47fa-9a9f-4a34cb3e1e2a", "3caf7511-4734-4b39-a8ed-4f2bce922e80", "User", "USER" },
                    { "ee0785df-97af-4508-a8ce-ee372fe21c78", "49ec1768-f071-4c01-b2ec-63b4d88612d0", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2ecf4b3e-0db8-4199-b9e8-6d4a32902650", "9cd43ba9-611b-42d4-b6a4-6ed069c87886" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2521680d-d11f-4d9a-acfe-e03b5fb5d4fe", "fff7c791-b526-483a-b771-9d27636d66f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1da0af21-fac5-4bce-934c-3b796be0a0bc", "557bfcd7-4337-4d40-a84b-facdf2445c43" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dfa321e-4c90-47fa-9a9f-4a34cb3e1e2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee0785df-97af-4508-a8ce-ee372fe21c78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "18962d5d-da57-4dd1-973b-724eb13a91c5", "522c707e-18e8-46cb-b20d-f5976d4130a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b92832d-d6c3-4def-9c41-3dc5e173671f", "6ebfe1e0-6110-43f0-8845-3bb5cbd56165" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f7058ddf-bafe-4b15-b9ae-0395b3236c77", "016144b3-1c0e-4467-88cb-79b838696f4e" });
        }
    }
}
