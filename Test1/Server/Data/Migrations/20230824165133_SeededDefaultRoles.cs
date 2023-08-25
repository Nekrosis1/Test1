using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1.Server.Data.Migrations
{
    public partial class SeededDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fc7cbd1-4a7d-490f-b8b8-4ad2b659a4af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63b5e08f-41e8-48ba-bbcf-4bb4e3b4a0a6");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7437), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7466), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7597), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7602), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7661), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7664), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7668), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7669) });
        }
    }
}
