using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class add_sample_product_image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Caption", "DateCreated", "FileSize", "ImagePath", "IsDefault", "ProductId", "SortOrder" },
                values: new object[,]
                {
                    { 20, "", new DateTime(2021, 9, 10, 19, 13, 59, 769, DateTimeKind.Local).AddTicks(1714), 0L, "/themes/images/products/large/3.jpg", false, 4, 0 },
                    { 23, "", new DateTime(2021, 9, 10, 19, 13, 59, 769, DateTimeKind.Local).AddTicks(1721), 0L, "/themes/images/products/large/f3.jpg", false, 4, 0 },
                    { 21, "", new DateTime(2021, 9, 10, 19, 13, 59, 769, DateTimeKind.Local).AddTicks(1716), 0L, "/themes/images/products/large/f1.jpg", false, 4, 0 },
                    { 22, "", new DateTime(2021, 9, 10, 19, 13, 59, 769, DateTimeKind.Local).AddTicks(1720), 0L, "/themes/images/products/large/f2.jpg", false, 4, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23);
        }
    }
}