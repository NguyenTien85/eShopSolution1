using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 26, 15, 46, 31, 597, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 26, 15, 46, 31, 597, DateTimeKind.Local).AddTicks(7822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("342d0c2b-adf6-4b25-a631-7242cd9472c4"),
                column: "ConcurrencyStamp",
                value: "d302418f-b374-4bde-8afa-ec9608274670");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b08221c3-af8c-4297-b0a7-73d70f660359"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f78f3f8-b62a-405b-b6c7-5393492127be", "AQAAAAEAACcQAAAAEF+buEcxxlSC87QnRbAiR88ST+FqSziQcyzO1IQkTsBWsBqcagq5ppUf+aH7L9adNQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 26, 15, 46, 31, 610, DateTimeKind.Local).AddTicks(4350));
        }
    }
}
