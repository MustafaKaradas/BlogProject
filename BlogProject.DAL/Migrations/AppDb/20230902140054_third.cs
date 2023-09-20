using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject.DAL.Migrations.AppDb
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7865), "\\images\\category\\istatistik.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7873), "\\images\\category\\sporr.jpg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 17, 0, 54, 61, DateTimeKind.Local).AddTicks(7875));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 533, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 57, 45, 534, DateTimeKind.Local).AddTicks(38), "\\images\\category\\istatistik.jpg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 534, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 534, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 534, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2023, 9, 2, 14, 57, 45, 534, DateTimeKind.Local).AddTicks(46), "\\images\\category\\spor.jpg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 2, 14, 57, 45, 534, DateTimeKind.Local).AddTicks(48));
        }
    }
}
