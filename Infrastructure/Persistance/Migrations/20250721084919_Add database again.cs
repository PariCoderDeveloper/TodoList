using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Adddatabaseagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 1L,
                column: "Title",
                value: "Read the book Clean Architecture");

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 2L,
                column: "Title",
                value: "Do ASP.NET project exercises");

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 3L,
                column: "Title",
                value: "Buy a new book");

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 4L,
                column: "Title",
                value: "Write an article about the Repository Pattern");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 1L,
                column: "Title",
                value: "خواندن کتاب Clean Architecture");

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 2L,
                column: "Title",
                value: "انجام تمرینات پروژه ASP.NET");

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 3L,
                column: "Title",
                value: "خرید کتاب جدید");

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 4L,
                column: "Title",
                value: "نوشتن مقاله درباره‌ی Repository Pattern");
        }
    }
}
