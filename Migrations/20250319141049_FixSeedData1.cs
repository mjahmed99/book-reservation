using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_Reservation.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 19, 10, 9, 3, 674, DateTimeKind.Local).AddTicks(3625), "john.doe@example.com", "John Doe", "$2a$12$F3X.5xP72vGjWcHMG6KOfu2G9pGvP1FsNhf0FnhBQ87Eb.c3HtG1W" },
                    { 2, new DateTime(2025, 3, 19, 10, 9, 3, 677, DateTimeKind.Local).AddTicks(3190), "jane.smith@example.com", "Jane Smith", "$2a$12$A9NZXOr02hz7.pWBq4l3HeG.eUX3MHRPugMY1MKIE/3J1GucPiKmK" }
                });
        }
    }
}
