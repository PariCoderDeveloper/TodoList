using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddisDeletedcolumntothetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isRemoved",
                table: "Todo",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 1L,
                column: "isRemoved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 2L,
                column: "isRemoved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 3L,
                column: "isRemoved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "ID",
                keyValue: 4L,
                column: "isRemoved",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isRemoved",
                table: "Todo");
        }
    }
}
