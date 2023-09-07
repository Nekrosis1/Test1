using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1.Server.Data.Migrations
{
    public partial class BookingDateInNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-16cd9f4acedb",
                column: "ConcurrencyStamp",
                value: "a4a6dfe0-40c4-4715-bec1-ef2d539914d2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-46cd9f4aceda",
                column: "ConcurrencyStamp",
                value: "a27c03f6-743e-48c1-b5d2-bc80df8d0723");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52cfd4d1-bde3-45dd-86a1-e74c5dfb8a92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15191255-cd76-47c4-824f-00c3e444546b", "AQAAAAEAACcQAAAAECKT5eJ1FoUuD9brt0G+6+foGtKw0aVOxg8k3szR20MNOd5a0aJm/0jteP9VcTu6Zw==", "31108f20-37fb-494b-9b21-4b68d4e25e80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a721152-96bd-432a-9b97-06ab6d7b6fee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d326fe6-9edc-4fc4-8c10-2c7aad4b6a1c", "AQAAAAEAACcQAAAAEPHa9MXIh0HHhRHcWDfv2DCgDLIM9sOnvU/R3OGE6lQwBDxktNeWFdA3XqkFoYG6sw==", "04722bf1-c76f-4c25-8062-cb3f639a68cb" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(5767), new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(5823), new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(6073), new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(6081), new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(6189), new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(6195), new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(6200), new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(6205), new DateTime(2023, 9, 7, 14, 49, 12, 299, DateTimeKind.Local).AddTicks(6208) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-16cd9f4acedb",
                column: "ConcurrencyStamp",
                value: "13f7a12c-f211-49c1-bb6b-143fa15ca8bf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-46cd9f4aceda",
                column: "ConcurrencyStamp",
                value: "3fbe2435-ed56-47af-bf3f-43e332a9b5c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52cfd4d1-bde3-45dd-86a1-e74c5dfb8a92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2e9b975-db83-478b-83ec-bfdbb7bd665f", "AQAAAAEAACcQAAAAEArMzLDt4cTq+iCIO3S/c2/caVWKa4MZqJRR2iWBSK0+8P2t50AojmNwQK6aYX9DQA==", "c74a1498-c9f6-4b7f-9b0c-09429e08815e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a721152-96bd-432a-9b97-06ab6d7b6fee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71bf6df3-a43c-4f3b-a958-6f4e1805edad", "AQAAAAEAACcQAAAAEH7MhrPis9x9EkygeT0nQPZUmA/fdfq+VNMyaUQFdZK9n4gMheH6847PPhIEwwyaUw==", "16d1ba43-6aee-434f-b312-8ef34b7a919a" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(4889), new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(4957), new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(5176), new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(5183), new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(5273), new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(5279), new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(5284), new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(5289), new DateTime(2023, 9, 4, 14, 32, 43, 89, DateTimeKind.Local).AddTicks(5291) });
        }
    }
}
