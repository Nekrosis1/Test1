using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fc7cbd1-4a7d-490f-b8b8-4ad2b659a4af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63b5e08f-41e8-48ba-bbcf-4bb4e3b4a0a6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9e24a193-1061-45cd-be67-16cd9f4acedb", "18916e30-b381-4091-b7dd-87cd4014215b", "Administrator", "ADMINISTRATOR" },
                    { "9e24a193-1061-45cd-be67-46cd9f4aceda", "388d370f-9cbb-4d6f-8991-9a59ac643949", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "52cfd4d1-bde3-45dd-86a1-e74c5dfb8a92", 0, "aa1de3d2-a2a7-4377-820e-7ecce57e15d9", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGF++QIB9Fs/9eHaFFlaNdqcfLZGYFmnb9ZFaeqCU7yhZ0xML97lDm1FJ/YGiHVTag==", null, false, "87495f4e-0f4d-461f-bf5e-6ee4568812e8", false, "admin@localhost.com" },
                    { "8a721152-96bd-432a-9b97-06ab6d7b6fee", 0, "9ece7d04-8455-4022-9670-c814fb3c2df0", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDI5IWtDzLh63XgeJgEO2Fiw0o5rNYDT3ePhhUbdqIfO5RsUki3lL/ncWVvqJND8mg==", null, false, "5309bd4f-2963-4c9e-a9e0-2fbe7c6648e2", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2116), new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2144), new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2283), new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2341), new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2345), new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2348), new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2351), new DateTime(2023, 8, 25, 17, 52, 36, 200, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9e24a193-1061-45cd-be67-16cd9f4acedb", "52cfd4d1-bde3-45dd-86a1-e74c5dfb8a92" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9e24a193-1061-45cd-be67-46cd9f4aceda", "8a721152-96bd-432a-9b97-06ab6d7b6fee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e24a193-1061-45cd-be67-16cd9f4acedb", "52cfd4d1-bde3-45dd-86a1-e74c5dfb8a92" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e24a193-1061-45cd-be67-46cd9f4aceda", "8a721152-96bd-432a-9b97-06ab6d7b6fee" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-16cd9f4acedb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-46cd9f4aceda");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52cfd4d1-bde3-45dd-86a1-e74c5dfb8a92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a721152-96bd-432a-9b97-06ab6d7b6fee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fc7cbd1-4a7d-490f-b8b8-4ad2b659a4af", "b7139519-e69b-44b0-b797-2c3539271c27", "User", "USER" },
                    { "63b5e08f-41e8-48ba-bbcf-4bb4e3b4a0a6", "0f0fa2ac-9a61-4f54-99c5-6e62394a9ee3", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3353), new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3380), new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3520), new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3525), new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3597), new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3601), new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3604), new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3607), new DateTime(2023, 8, 24, 18, 51, 33, 189, DateTimeKind.Local).AddTicks(3609) });
        }
    }
}
