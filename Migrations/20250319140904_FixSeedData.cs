using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_Reservation.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 3, 19, 10, 9, 3, 674, DateTimeKind.Local).AddTicks(3625), "$2a$12$F3X.5xP72vGjWcHMG6KOfu2G9pGvP1FsNhf0FnhBQ87Eb.c3HtG1W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 3, 19, 10, 9, 3, 677, DateTimeKind.Local).AddTicks(3190), "$2a$12$A9NZXOr02hz7.pWBq4l3HeG.eUX3MHRPugMY1MKIE/3J1GucPiKmK" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 3, 19, 10, 1, 18, 705, DateTimeKind.Local).AddTicks(512), "$2a$11$3sjmKFI6czID1UxBafuo1Okg24EUPTF0vvLZ8Q0blxawHcS3Itsam" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 3, 19, 10, 1, 19, 39, DateTimeKind.Local).AddTicks(870), "$2a$11$8M1dU/7dVOdgsFf9BG4zx.v.6u5Lo1LPChSn6PzpBl6ZiTK9Vmg5i" });
        }
    }
}
