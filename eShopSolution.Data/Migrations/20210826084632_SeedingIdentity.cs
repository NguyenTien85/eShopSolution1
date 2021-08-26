using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 26, 15, 46, 31, 597, DateTimeKind.Local).AddTicks(7822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 26, 15, 29, 23, 882, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("342d0c2b-adf6-4b25-a631-7242cd9472c4"), "d302418f-b374-4bde-8afa-ec9608274670", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b08221c3-af8c-4297-b0a7-73d70f660359"), 0, "8f78f3f8-b62a-405b-b6c7-5393492127be", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "nmt08051985@gmail.com", true, "Nguyen", "Tien", false, null, "nmt08051985@gmail.com", "admin", "AQAAAAEAACcQAAAAEF+buEcxxlSC87QnRbAiR88ST+FqSziQcyzO1IQkTsBWsBqcagq5ppUf+aH7L9adNQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 26, 15, 46, 31, 610, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("342d0c2b-adf6-4b25-a631-7242cd9472c4"), new Guid("b08221c3-af8c-4297-b0a7-73d70f660359") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("342d0c2b-adf6-4b25-a631-7242cd9472c4"), new Guid("b08221c3-af8c-4297-b0a7-73d70f660359") });

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("342d0c2b-adf6-4b25-a631-7242cd9472c4"));

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b08221c3-af8c-4297-b0a7-73d70f660359"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 26, 15, 29, 23, 882, DateTimeKind.Local).AddTicks(5696),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 26, 15, 46, 31, 597, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 26, 15, 29, 23, 894, DateTimeKind.Local).AddTicks(6355));
        }
    }
}
