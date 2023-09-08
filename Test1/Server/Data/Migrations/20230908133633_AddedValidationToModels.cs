using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1.Server.Data.Migrations
{
    public partial class AddedValidationToModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-16cd9f4acedb",
                column: "ConcurrencyStamp",
                value: "1f16d383-1de6-424e-9f1d-a880ea0b2e65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-46cd9f4aceda",
                column: "ConcurrencyStamp",
                value: "78aefa87-0c7d-449d-bec3-764904267591");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52cfd4d1-bde3-45dd-86a1-e74c5dfb8a92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a32210af-19e3-4d70-891d-e5809441dfa2", "AQAAAAEAACcQAAAAECzXUnmusk0MuPhlyFLdqqPldFgwPOYW5AbWmO/LVcomy4mF1GRVgRiBHK0tL7Ax2A==", "4278a366-39df-4395-9e1d-a63a06d42fff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a721152-96bd-432a-9b97-06ab6d7b6fee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f014ec23-231d-46d7-9042-8e965f21db36", "AQAAAAEAACcQAAAAEB7sZkFBveRvF+mq99xQ1spqVEQw6gxYpEJXUuExVLXki31A7TP/P/AOtjNR37b1Aw==", "8b84565a-1a1b-45ab-9a67-7a36a601a0a9" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(571), new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(621), new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(828), new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(835), new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(920), new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(927), new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(932), new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(937), new DateTime(2023, 9, 8, 15, 36, 33, 345, DateTimeKind.Local).AddTicks(939) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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
    }
}
