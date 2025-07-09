using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_Reservation.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "PasswordHash" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 19, 10, 1, 18, 705, DateTimeKind.Local).AddTicks(512), "john.doe@example.com", "John Doe", "$2a$11$3sjmKFI6czID1UxBafuo1Okg24EUPTF0vvLZ8Q0blxawHcS3Itsam" },
                    { 2, new DateTime(2025, 3, 19, 10, 1, 19, 39, DateTimeKind.Local).AddTicks(870), "jane.smith@example.com", "Jane Smith", "$2a$11$8M1dU/7dVOdgsFf9BG4zx.v.6u5Lo1LPChSn6PzpBl6ZiTK9Vmg5i" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
