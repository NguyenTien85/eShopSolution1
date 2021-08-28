using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class changeFileNameType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("342d0c2b-adf6-4b25-a631-7242cd9472c4"),
                column: "ConcurrencyStamp",
                value: "9851c69b-8978-422d-aca4-e1a99bd02025");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b08221c3-af8c-4297-b0a7-73d70f660359"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a8d37c38-fd1d-4233-bf73-a581ef8fdd07", "AQAAAAEAACcQAAAAEJyoCCtGWro2kqfExue6/cb/i51xW20EBwo1ppG9pChkbd+YX1pEl5a0KN/dazHUGw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 27, 16, 49, 38, 189, DateTimeKind.Local).AddTicks(7138));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("342d0c2b-adf6-4b25-a631-7242cd9472c4"),
                column: "ConcurrencyStamp",
                value: "4272cef4-76c5-40e6-97ef-88b2c573a82e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b08221c3-af8c-4297-b0a7-73d70f660359"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3af7f364-2852-4154-8d77-a5d8613ba848", "AQAAAAEAACcQAAAAEB3hGxHOrJWRLFdgKRyP/uDspfNpLYVWUne+Hb9gMEl5BCfKtQDHwngkJeLrKyBytQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 27, 15, 38, 0, 212, DateTimeKind.Local).AddTicks(2588));
        }
    }
}
