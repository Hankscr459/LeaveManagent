using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagent.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb115775-33b1-5434-34a1-ad1b12beb5fa",
                column: "ConcurrencyStamp",
                value: "400097f6-dd70-49ac-bfdc-643ef670d605");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da115585-33b1-1354-94b3-5d6bcabeb51a",
                column: "ConcurrencyStamp",
                value: "efda784d-4953-4eb0-ae12-fc40cecebe2f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43122545-c122-115f-c66a-4a6a11b81a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0ab6c20-b68d-43b4-83ed-b4be21d62077", "AQAAAAEAACcQAAAAEETaHLGzT4U2eZl85UAvoG2BzPnIKSHb0tNPfEF5BAuZPC1i2W+/dY6w9PZsuWcUBw==", "8e3827a8-2560-406c-95ca-4cbaf7434f11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af1155f5-b121-225a-a43d-5a6a11beb522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c505347-9e14-467c-b1f2-a7b6d7141280", "AQAAAAEAACcQAAAAELAFkHdcSzCPwDL+mqT2OaHWcUKGzvRHEPL2pnXsJCRmYcdhxfrznzPYaMagTLQeOA==", "9c85fe52-3724-4b55-92d1-106d57db7122" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb115775-33b1-5434-34a1-ad1b12beb5fa",
                column: "ConcurrencyStamp",
                value: "09a35a67-1039-4249-848a-d7ee172e2aa9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da115585-33b1-1354-94b3-5d6bcabeb51a",
                column: "ConcurrencyStamp",
                value: "deea1c64-bc1b-448f-b78d-7a77386ce41a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43122545-c122-115f-c66a-4a6a11b81a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e65cdad7-90ca-41f7-bd73-f7248ea51837", "AQAAAAEAACcQAAAAEMsEcQohCpVluIs5rzjT+W21VOhh/QCddGzjghDxQVUC7Jj2BtTxVnZ3Di+c9bvSOA==", "e9fef132-38d5-4250-9fca-65f27d0b6fad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af1155f5-b121-225a-a43d-5a6a11beb522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be08f729-2ef3-404f-9cc9-e2655261d2e3", "AQAAAAEAACcQAAAAED8F24+7r95D7U0Eu6hlxHxGFvLTYMoILsoqJrmFgC1F9Na9V40kytyH4GtT88ct2Q==", "2f4c5b31-6909-4964-b780-a4b1aa4f13a9" });
        }
    }
}
