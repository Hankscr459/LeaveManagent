using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagent.Data.Migrations
{
    public partial class addLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
