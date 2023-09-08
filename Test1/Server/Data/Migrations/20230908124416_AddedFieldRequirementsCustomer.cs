using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1.Server.Data.Migrations
{
    public partial class AddedFieldRequirementsCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
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
                value: "8d3d55f4-129b-465f-a1bf-51e671ac8d6f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e24a193-1061-45cd-be67-46cd9f4aceda",
                column: "ConcurrencyStamp",
                value: "3644cf23-c069-42be-9b6d-57910b89efb7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52cfd4d1-bde3-45dd-86a1-e74c5dfb8a92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aced6eed-d7f8-40b9-a735-2e1e475eac1a", "AQAAAAEAACcQAAAAEDujUbyCuA679yUaHPbI0I7ZtKRGRjZGEC1C4CtmTDCyVk4bi3n6zWRXimrZqdHhhQ==", "334af3ff-f012-4600-a429-281c034fddf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a721152-96bd-432a-9b97-06ab6d7b6fee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f4c173d-cb27-469b-8e0c-36e336661015", "AQAAAAEAACcQAAAAEHQ6du5SwtevlSYUN4ZTYHl+IiZU80QluHwnAF5hjyzdSDSicMIvF7cZ7Lgq84GzGg==", "5c1241e5-2bfc-49f5-a093-2644aa000637" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(2667), new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(2729), new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(2973), new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(2980), new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(3089), new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(3101), new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(3106), new DateTime(2023, 9, 8, 14, 28, 32, 439, DateTimeKind.Local).AddTicks(3108) });
        }
    }
}
