using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreAPIBank3170.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardInfoes",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 1, 13, 39, 19, 955, DateTimeKind.Local).AddTicks(549));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CardInfoes",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 1, 13, 33, 14, 750, DateTimeKind.Local).AddTicks(9556));
        }
    }
}
