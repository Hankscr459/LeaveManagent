using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagent.Data.Migrations
{
    public partial class updateLeaveRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb115775-33b1-5434-34a1-ad1b12beb5fa",
                column: "ConcurrencyStamp",
                value: "610abc5c-ec1a-46ef-8c41-42a863c8f15f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da115585-33b1-1354-94b3-5d6bcabeb51a",
                column: "ConcurrencyStamp",
                value: "fd34f4d5-3b37-4ec0-9c53-a2265031bdbe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43122545-c122-115f-c66a-4a6a11b81a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7084ae09-f673-4fcc-96b3-4b01ba0aa974", "AQAAAAEAACcQAAAAEB8efgG/TmughAERAvIQsoox1S0NdAKzBv8GSzbAsWZY8iJzmazET8r+b7dygD/bTA==", "efadd127-2047-4190-b8c2-0735a2d54463" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af1155f5-b121-225a-a43d-5a6a11beb522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a136aa8-abda-4009-9214-06c0734b3df3", "AQAAAAEAACcQAAAAEO3f0S3uJA08Zg0LJhmfD6tChz64RJOSyzBWcsnMg37ooJmvNOA9XjeaKE7leI2/tQ==", "a2dbe072-3ac3-42a5-afbf-200d393b536a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb115775-33b1-5434-34a1-ad1b12beb5fa",
                column: "ConcurrencyStamp",
                value: "15605138-885f-4284-b374-2a5d7e27832d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da115585-33b1-1354-94b3-5d6bcabeb51a",
                column: "ConcurrencyStamp",
                value: "8f49f50a-9560-4b4b-ae6c-4056fa458146");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43122545-c122-115f-c66a-4a6a11b81a1c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef9aa7f9-bc48-48ec-a073-1e7c0cb3bcad", "AQAAAAEAACcQAAAAEEAS0Ry/jdFmQouxLRrWiVFy+faAkY3Z+LPSn8aBPVKd0HDJ8AB4qDZd+69uaZGwyQ==", "e14ded4e-fc36-4dcf-8cd1-16828b626a9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af1155f5-b121-225a-a43d-5a6a11beb522",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77761ced-f898-4489-93f5-b97097e351ec", "AQAAAAEAACcQAAAAEMeD4Yt6ych7mVYjRNstlACWCLFpaITLVFLL7+BUgkY+0lW9rMC160kxifkfsyVjIg==", "ee45654f-627a-415c-a0bf-3e9f5f614430" });
        }
    }
}
