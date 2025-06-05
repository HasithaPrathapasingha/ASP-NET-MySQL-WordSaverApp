using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordSaverApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDateToWordEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "WordEntries",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "WordEntries");
        }
    }
}
