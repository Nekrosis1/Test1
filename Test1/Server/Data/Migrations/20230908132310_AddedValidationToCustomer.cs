using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1.Server.Data.Migrations
{
    public partial class AddedValidationToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-16cd9f4acedb",
                column: "ConcurrencyStamp",
                value: "bde03177-ff22-454b-855d-753f9cab226e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-46cd9f4aceda",
                column: "ConcurrencyStamp",
                value: "f5d199aa-4860-4600-9669-01fe6ed634ab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52cfd4d1-bde3-45dd-86a1-e74c5dfb8a92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f9e049e-5d30-4543-8063-e9e4ee64ce71", "AQAAAAEAACcQAAAAEB0K5jLKd8Gv+/oSLNslJWHI7eetoLCu/m0Ivvldb6+LzJAHQlsfOqZpCWJgq7IqMg==", "72c89473-caff-4790-b868-72fa2c108b2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a721152-96bd-432a-9b97-06ab6d7b6fee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9470aaa-cf5e-462b-b244-182566324fa0", "AQAAAAEAACcQAAAAEJhoJfxyLZVToMsBEu+6v9pgzIU3h3HJMQqXJltIQZ01sXIrGyyYSKfHrvBgUfLO+A==", "875cd9a3-dc76-4696-a3e5-a912e9032ec7" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1365), new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1424), new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1737), new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1745), new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1841), new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1848), new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1853), new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1859), new DateTime(2023, 9, 8, 15, 23, 9, 965, DateTimeKind.Local).AddTicks(1861) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-16cd9f4acedb",
                column: "ConcurrencyStamp",
                value: "c6ae4e9d-1bd0-46e2-9e02-7270a4db8b9f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-46cd9f4aceda",
                column: "ConcurrencyStamp",
                value: "c53e0d06-e56a-4452-b2d9-1e80446d033d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52cfd4d1-bde3-45dd-86a1-e74c5dfb8a92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23e5aaeb-c441-4a15-bf3b-0fe092b91c69", "AQAAAAEAACcQAAAAEN3NTR/IzwybrBzxsSl7cNIKYraakT0FwJxoeUcWCkDw2jTnMQIE8n76PQXa+ooTRQ==", "529002d5-3a3d-458f-8f03-1887d5f1d136" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a721152-96bd-432a-9b97-06ab6d7b6fee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d7260cd-3dcd-40ba-9fd8-1bca695bdb0a", "AQAAAAEAACcQAAAAEAMlSiDCpQjJvI1Suyrr9pzIe8azKyykZoFOhUOtX7U5lBUCiuXRz+MNqRxWF5aQ8w==", "0f6737be-6378-4c11-9a4e-5d0c58ba45d5" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7361), new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7415), new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7641), new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7648), new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7743), new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7750), new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7756), new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7761), new DateTime(2023, 9, 8, 14, 44, 16, 206, DateTimeKind.Local).AddTicks(7763) });
        }
    }
}
