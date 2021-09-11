using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class update_image_default : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("342d0c2b-adf6-4b25-a631-7242cd9472c4"),
                column: "ConcurrencyStamp",
                value: "4ea6c755-3da9-4116-9b64-2b2ad118cfd8");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("b08221c3-af8c-4297-b0a7-73d70f660359"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "523075a5-5d23-4e3e-9d4d-7855fa0a9a92", "AQAAAAEAACcQAAAAEKtctBGIoxgmaKlsmub+tbD/NEPRdulJ8p/orJgZGQB5Ka9sImTC50QReLSnDF/Hrg==" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(4964), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5723), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5731), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5733), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5736), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5738), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5741), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5743), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5746), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5748), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5750), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5752), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5755), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5757), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5759), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5761), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5764), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5766), true });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 9, 6, 42, 18, 734, DateTimeKind.Local).AddTicks(5769), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2021, 9, 9, 6, 42, 18, 733, DateTimeKind.Local).AddTicks(7670));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(9495), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(244), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(252), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(254), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(256), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(258), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(261), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(263), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(265), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(267), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(268), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(271), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(272), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(274), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(277), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(279), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(281), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(283), false });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "IsDefault" },
                values: new object[] { new DateTime(2021, 9, 8, 22, 3, 15, 648, DateTimeKind.Local).AddTicks(285), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 646, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2021, 9, 8, 22, 3, 15, 647, DateTimeKind.Local).AddTicks(1731));
        }
    }
}
