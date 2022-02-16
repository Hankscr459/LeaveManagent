using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagent.Data.Migrations
{
    public partial class addedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bb115775-33b1-5434-34a1-ad1b12beb5fa", "09a35a67-1039-4249-848a-d7ee172e2aa9", "User", "USER" },
                    { "da115585-33b1-1354-94b3-5d6bcabeb51a", "deea1c64-bc1b-448f-b78d-7a77386ce41a", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "43122545-c122-115f-c66a-4a6a11b81a1c", 0, "e65cdad7-90ca-41f7-bd73-f7248ea51837", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "user@ADMINLOCALHOST.COM", null, "AQAAAAEAACcQAAAAEMsEcQohCpVluIs5rzjT+W21VOhh/QCddGzjghDxQVUC7Jj2BtTxVnZ3Di+c9bvSOA==", null, false, "e9fef132-38d5-4250-9fca-65f27d0b6fad", null, false, null },
                    { "af1155f5-b121-225a-a43d-5a6a11beb522", 0, "be08f729-2ef3-404f-9cc9-e2655261d2e3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "user@ADMINLOCALHOST.COM", null, "AQAAAAEAACcQAAAAED8F24+7r95D7U0Eu6hlxHxGFvLTYMoILsoqJrmFgC1F9Na9V40kytyH4GtT88ct2Q==", null, false, "2f4c5b31-6909-4964-b780-a4b1aa4f13a9", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bb115775-33b1-5434-34a1-ad1b12beb5fa", "43122545-c122-115f-c66a-4a6a11b81a1c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "da115585-33b1-1354-94b3-5d6bcabeb51a", "af1155f5-b121-225a-a43d-5a6a11beb522" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb115775-33b1-5434-34a1-ad1b12beb5fa", "43122545-c122-115f-c66a-4a6a11b81a1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da115585-33b1-1354-94b3-5d6bcabeb51a", "af1155f5-b121-225a-a43d-5a6a11beb522" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb115775-33b1-5434-34a1-ad1b12beb5fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da115585-33b1-1354-94b3-5d6bcabeb51a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43122545-c122-115f-c66a-4a6a11b81a1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af1155f5-b121-225a-a43d-5a6a11beb522");
        }
    }
}
