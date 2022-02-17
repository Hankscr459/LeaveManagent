using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagent.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb115775-33b1-5434-34a1-ad1b12beb5fa",
                column: "ConcurrencyStamp",
                value: "f7a14146-9168-46c0-a5b9-e6acdab9d573");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da115585-33b1-1354-94b3-5d6bcabeb51a",
                column: "ConcurrencyStamp",
                value: "876c94e6-d9db-4632-8bc2-ab88b6cc91ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43122545-c122-115f-c66a-4a6a11b81a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd4e7eb2-cade-4b08-aac3-1458b764939e", "AQAAAAEAACcQAAAAEHcA/dXWqajn2P6Scs+GZtgmmTy24PW1sAuw1pN/hAb+pKWFOeysLzNQbk1VYmi6WA==", "5260308a-1618-4b3c-ba27-ba704e4bb8f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af1155f5-b121-225a-a43d-5a6a11beb522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db992f61-8e55-4943-9f26-08c03938e598", "AQAAAAEAACcQAAAAENMqLCjeaf4AMd14GSZz4Z+5wBJMapp41MsNGj0z5fGZNQBCDrKyoe/Ran2Joi1X0A==", "9e84f3e1-c1c2-462c-a7ad-989f1d34b85d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
    }
}
