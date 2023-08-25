using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7437), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7464), "Black", "System" },
                    { 2, "System", new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7466), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7468), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7597), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7600), "Toyota", "System" },
                    { 2, "System", new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7602), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7603), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7659), "Prius", "System" },
                    { 2, "System", new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7661), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7662), "Vitz", "System" },
                    { 3, "System", new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7664), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7666), "3 Series", "System" },
                    { 4, "System", new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7668), new DateTime(2023, 8, 24, 18, 42, 51, 616, DateTimeKind.Local).AddTicks(7669), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
