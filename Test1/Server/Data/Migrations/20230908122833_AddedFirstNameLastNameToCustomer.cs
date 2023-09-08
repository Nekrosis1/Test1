using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1.Server.Data.Migrations
{
    public partial class AddedFirstNameLastNameToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
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
    }
}
