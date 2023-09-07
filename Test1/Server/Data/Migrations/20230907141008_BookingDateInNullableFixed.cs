using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1.Server.Data.Migrations
{
    public partial class BookingDateInNullableFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-16cd9f4acedb",
                column: "ConcurrencyStamp",
                value: "15a869ce-93a8-4c67-9be3-c6ad164c43e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-46cd9f4aceda",
                column: "ConcurrencyStamp",
                value: "84d97202-f020-4927-a688-27769a580417");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52cfd4d1-bde3-45dd-86a1-e74c5dfb8a92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "662e2c6e-7e6e-4460-8bb8-2ad8efa0e2f2", "AQAAAAEAACcQAAAAEHgiA6B8sIWZdRWwcmuVjIYQ12QdPejfbHg1NBhC8GOxFEX4MZRi4JMSeoyaq59jlw==", "40916837-165c-4385-af84-ca6207cfec34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a721152-96bd-432a-9b97-06ab6d7b6fee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e84b8c44-f6b6-454c-839a-fe1e52e24028", "AQAAAAEAACcQAAAAEFGd8A51Bfd0lA0Zry0cCVdzxGmD3IMwKFSISty4rgOW0bCi8sx01DcrvSG/zthhRQ==", "4763706a-f918-4d6e-a593-f16eb35389db" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(372), new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(442), new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(678), new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(686), new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(689) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(802), new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(809), new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(814), new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(819), new DateTime(2023, 9, 7, 16, 10, 8, 371, DateTimeKind.Local).AddTicks(821) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
