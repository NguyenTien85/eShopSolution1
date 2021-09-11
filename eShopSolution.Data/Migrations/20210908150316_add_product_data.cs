using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class add_product_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("342d0c2b-adf6-4b25-a631-7242cd9472c4"),
                column: "ConcurrencyStamp",
                value: "43fe3e0b-e60c-4677-8454-8887a2c89046");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b08221c3-af8c-4297-b0a7-73d70f660359"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e288ab54-feff-43c9-a283-4b5d904e2cb6", "AQAAAAEAACcQAAAAEFV584YufNeVpCzOgLX+fcqKqKQTO/wu31mG1nqBuoO3QA7ojzX0l2Aa9mCACOEfyw==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 3, true, null, 1, 1 },
                    { 4, true, null, 2, 1 }
                });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "máy ảnh", "may-anh", "máy ảnh", "máy ảnh" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "camera", "camera", "camera", "camera" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "thẻ nhớ", "the-nho", "thẻ nhớ", "thẻ nhớ" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "memory-card", "memory-card", "memory-card", "memory-card" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Caption", "DateCreated", "FileSize", "ImagePath", "IsDefault", "ProductId", "SortOrder" },
                values: new object[] { 1, "", new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(9495), 0L, "/themes/images/products/1.jpg", false, 1, 0 });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "máy ảnh 1", "máy ảnh 1", "máy ảnh 1", "may anh", "máy ảnh 1", "máy ảnh 1" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "camera 1", "camera 1", "camera 1", "camera 1", "camera 1", "camera 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 646, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "IsFeatured", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 11, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1711), null, 100000m, 200000m },
                    { 2, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1669), null, 100000m, 200000m },
                    { 3, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1688), null, 100000m, 200000m },
                    { 4, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1692), null, 100000m, 200000m },
                    { 5, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1695), null, 100000m, 200000m },
                    { 6, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1697), null, 100000m, 200000m },
                    { 7, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1700), null, 100000m, 200000m },
                    { 10, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1709), null, 100000m, 200000m },
                    { 8, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1703), null, 100000m, 200000m },
                    { 18, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1729), null, 100000m, 200000m },
                    { 17, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1727), null, 100000m, 200000m },
                    { 16, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1725), null, 100000m, 200000m },
                    { 15, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1722), null, 100000m, 200000m },
                    { 9, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1706), null, 100000m, 200000m },
                    { 13, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1716), null, 100000m, 200000m },
                    { 12, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1713), null, 100000m, 200000m },
                    { 19, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1731), null, 100000m, 200000m },
                    { 14, new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1719), null, 100000m, 200000m }
                });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 5, 3, "vi", "giầy nữ", "giay-nu", "giầy nữ", "giầy nữ" },
                    { 6, 3, "en", "boots", "boots", "boots", "boots" },
                    { 7, 4, "vi", "máy đọc sách", "may-doc-sach", "máy đọc sách", "máy đọc sách" },
                    { 8, 4, "en", "e-book reader", "e-book-reader", "e-book reader", "e-book reader" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Caption", "DateCreated", "FileSize", "ImagePath", "IsDefault", "ProductId", "SortOrder" },
                values: new object[,]
                {
                    { 10, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(267), 0L, "/themes/images/products/10.jpg", false, 10, 0 },
                    { 8, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(263), 0L, "/themes/images/products/8.jpg", false, 8, 0 },
                    { 11, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(268), 0L, "/themes/images/products/11.jpg", false, 11, 0 },
                    { 12, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(271), 0L, "/themes/images/products/12.jpg", false, 12, 0 },
                    { 7, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(261), 0L, "/themes/images/products/7.jpg", false, 7, 0 },
                    { 13, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(272), 0L, "/themes/images/products/13.jpg", false, 13, 0 },
                    { 6, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(258), 0L, "/themes/images/products/6.jpg", false, 6, 0 },
                    { 14, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(274), 0L, "/themes/images/products/b1.jpg", false, 14, 0 },
                    { 15, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(277), 0L, "/themes/images/products/b2.jpg", false, 15, 0 },
                    { 5, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(256), 0L, "/themes/images/products/5.jpg", false, 5, 0 },
                    { 9, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(265), 0L, "/themes/images/products/9.jpg", false, 9, 0 },
                    { 2, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(244), 0L, "/themes/images/products/2.jpg", false, 2, 0 },
                    { 4, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(254), 0L, "/themes/images/products/4.jpg", false, 4, 0 },
                    { 17, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(281), 0L, "/themes/images/products/b4.jpg", false, 17, 0 },
                    { 19, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(285), 0L, "/themes/images/products/panasonic.jpg", false, 19, 0 },
                    { 18, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(283), 0L, "/themes/images/products/kindle.png", false, 18, 0 },
                    { 16, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(279), 0L, "/themes/images/products/b3.jpg", false, 16, 0 },
                    { 3, "", new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(252), 0L, "/themes/images/products/3.jpg", false, 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 1, 9 },
                    { 1, 19 },
                    { 1, 11 },
                    { 2, 12 },
                    { 1, 13 },
                    { 3, 17 },
                    { 3, 14 },
                    { 3, 16 },
                    { 4, 18 },
                    { 3, 15 },
                    { 2, 10 },
                    { 1, 5 },
                    { 1, 2 },
                    { 2, 8 },
                    { 2, 6 },
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 7 }
                });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 29, "giầy nữ 2", "giầy nữ 2", "vi", "giầy nữ 2", 15, "giay nu 2", "giầy nữ 2", "giầy nữ 2" },
                    { 30, "boots 2", "boots 2", "en", "boots 2", 15, "boots 2", "boots 2", "boots 2" }
                });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 7, "máy ảnh 4", "máy ảnh 4", "vi", "máy ảnh 4", 4, "may anh", "máy ảnh 4", "máy ảnh 4" },
                    { 31, "giầy nữ 3", "giầy nữ 3", "vi", "giầy nữ 3", 16, "giay nu 3", "giầy nữ 3", "giầy nữ 3" },
                    { 32, "boots 3", "boots 3", "en", "boots 3", 16, "boots 3", "boots 3", "boots 3" },
                    { 5, "máy ảnh 3", "máy ảnh 3", "vi", "máy ảnh 3", 3, "may anh", "máy ảnh 3", "máy ảnh 3" },
                    { 8, "camera 4", "camera 4", "en", "camera 4", 4, "camera 4", "camera 4", "camera 4" },
                    { 33, "giầy nữ 4", "giầy nữ 4", "vi", "giầy nữ 4", 17, "giay nu 4", "giầy nữ 4", "giầy nữ 4" },
                    { 34, "boots 4", "boots 4", "en", "boots 4", 17, "boots 4", "boots 4", "boots 4" },
                    { 4, "camera 2", "camera 2", "en", "camera 2", 2, "camera 2", "camera 2", "camera 2" },
                    { 35, "máy đọc sách 1", "máy đọc sách 1", "vi", "máy đọc sách 1", 18, "may doc sach 1", "máy đọc sách 1", "máy đọc sách 1" },
                    { 36, "kindle 1", "kindle 1", "en", "kindle 1", 18, "kindle 1", "kindle 1", "kindle 1" },
                    { 3, "máy ảnh 2", "máy ảnh 2", "vi", "máy ảnh 2", 2, "may anh", "máy ảnh 2", "máy ảnh 2" },
                    { 6, "camera 3", "camera 3", "en", "camera 3", 3, "camera 3", "camera 3", "camera 3" },
                    { 15, "thẻ nhớ 3", "thẻ nhớ 3", "vi", "thẻ nhớ 3", 8, "the nho 3", "thẻ nhớ 3", "thẻ nhớ 3" },
                    { 27, "giầy nữ 1", "giầy nữ 1", "vi", "giầy nữ 1", 14, "giay nu 1", "giầy nữ 1", "giầy nữ 1" },
                    { 16, "memory card 3", "memory card 3", "en", "memory card 3", 8, "memory card 3", "memory card 3", "memory card 3" },
                    { 17, "bộ phụ kiện máy ảnh 1", "bộ phụ kiện máy ảnh 1", "vi", "bộ phụ kiện máy ảnh 1", 9, "bo phu kien may anh 1", "bộ phụ kiện máy ảnh 1", "bộ phụ kiện máy ảnh 1" },
                    { 18, "camera combo 1", "camera combo 1", "en", "camera combo 1", 9, "camera combo 1", "camera combo 1", "camera combo 1" },
                    { 37, "máy ảnh 8", "máy ảnh 8", "vi", "máy ảnh 8", 19, "may anh 8", "máy ảnh 8", "máy ảnh 8" },
                    { 19, "thẻ nhớ 4", "thẻ nhớ 4", "vi", "thẻ nhớ 4", 10, "the nho 4", "thẻ nhớ 4", "thẻ nhớ 4" },
                    { 20, "memory card 4", "memory card 4", "en", "memory card 4", 10, "memory card 4", "memory card 4", "memory card 4" },
                    { 14, "memory card 2", "memory card 2", "en", "memory card 2", 7, "memory card 2", "memory card 2", "memory card 2" },
                    { 13, "thẻ nhớ 2", "thẻ nhớ 2", "vi", "thẻ nhớ 2", 7, "the nho 2", "thẻ nhớ 2", "thẻ nhớ 2" },
                    { 21, "máy ảnh 6", "máy ảnh 6", "vi", "máy ảnh 6", 11, "may anh", "máy ảnh 6", "máy ảnh 6" },
                    { 22, "camera 6", "camera 6", "en", "camera 6", 11, "camera 6", "camera 6", "camera 6" },
                    { 12, "memory card 1", "memory card 1", "en", "memory card 1", 6, "memory card 1", "memory card 1", "memory card 1" },
                    { 23, "thẻ nhớ 5", "thẻ nhớ 5", "vi", "thẻ nhớ 5", 12, "the nho 5", "thẻ nhớ 5", "thẻ nhớ 5" },
                    { 24, "memory card 5", "memory card 5", "en", "memory card 5", 12, "memory card 5", "memory card 5", "memory card 5" },
                    { 11, "thẻ nhớ 1", "thẻ nhớ 1", "vi", "thẻ nhớ 1", 6, "the nho 1", "thẻ nhớ 1", "thẻ nhớ 1" },
                    { 25, "máy ảnh 7", "máy ảnh 7", "vi", "máy ảnh 7", 13, "may anh", "máy ảnh 7", "máy ảnh 7" },
                    { 26, "camera 7", "camera 7", "en", "camera 7", 13, "camera 7", "camera 7", "camera 7" },
                    { 10, "camera 5", "camera 5", "en", "camera 5", 5, "camera 5", "camera 5", "camera 5" },
                    { 9, "máy ảnh 5", "máy ảnh 5", "vi", "máy ảnh 5", 5, "may anh", "máy ảnh 5", "máy ảnh 5" },
                    { 28, "boots 1", "boots 1", "en", "boots 1", 14, "boots 1", "boots 1", "boots 1" },
                    { 38, "camera 8", "camera 8", "en", "camera 8", 19, "camera 8", "camera 8", "camera 8" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("342d0c2b-adf6-4b25-a631-7242cd9472c4"),
                column: "ConcurrencyStamp",
                value: "9b35adfc-d950-427a-875d-412a6f321c45");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b08221c3-af8c-4297-b0a7-73d70f660359"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "33f23b0e-a1e9-4ba7-91e5-5b21b6df74cc", "AQAAAAEAACcQAAAAEP9whlHspgNlEaY9HYX24YE6GZHGDTY2OJP0pgXyaVBmxs5xWnTVSU8iH1VpbK9o7w==" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo nam", "ao-nam", "Sản phẩm áo thời trang nam", "Sản phẩm áo thời trang nam" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Men Shirt", "men-shirt", "The shirt products for men", "The shirt products for men" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo nữ", "ao-nu", "Sản phẩm áo thời trang nữ", "Sản phẩm áo thời trang women" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Women Shirt", "women-shirt", "The shirt products for women", "The shirt products for women" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "ao-so-mi-nam-trang-viet-tien", "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt", "viet-tien-men-t-shirt", "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 16, 33, 0, 385, DateTimeKind.Local).AddTicks(7204));
        }
    }
}