using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "ID", "IsCompleted", "Title", "date" },
                values: new object[,]
                {
                    { 1L, false, "خواندن کتاب Clean Architecture", new DateOnly(2025, 7, 11) },
                    { 2L, false, "انجام تمرینات پروژه ASP.NET", new DateOnly(2025, 7, 10) },
                    { 3L, false, "خرید کتاب جدید", new DateOnly(2025, 7, 10) },
                    { 4L, true, "نوشتن مقاله درباره‌ی Repository Pattern", new DateOnly(2025, 7, 10) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 4L);
        }
    }
}
