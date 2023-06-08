using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BanVeXemPhimApi.Migrations
{
    public partial class version_05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "order_tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    NumberPhone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SeatList = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalPrice = table.Column<double>(type: "double", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_tickets", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 2, 17, 24, 47, 256, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 24, 47, 255, DateTimeKind.Local).AddTicks(8692), new DateTime(2023, 6, 2, 17, 24, 47, 256, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 24, 47, 256, DateTimeKind.Local).AddTicks(2594), new DateTime(2023, 6, 2, 17, 24, 47, 256, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 24, 47, 256, DateTimeKind.Local).AddTicks(2607), new DateTime(2023, 6, 2, 17, 24, 47, 256, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 24, 47, 256, DateTimeKind.Local).AddTicks(2612), new DateTime(2023, 6, 2, 17, 24, 47, 256, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 24, 47, 256, DateTimeKind.Local).AddTicks(2616), new DateTime(2023, 6, 2, 17, 24, 47, 256, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 2, 17, 24, 47, 246, DateTimeKind.Local).AddTicks(9770));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "order_tickets");

            migrationBuilder.UpdateData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 2, 9, 35, 30, 160, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 9, 35, 30, 160, DateTimeKind.Local).AddTicks(1285), new DateTime(2023, 6, 2, 9, 35, 30, 160, DateTimeKind.Local).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 9, 35, 30, 160, DateTimeKind.Local).AddTicks(3593), new DateTime(2023, 6, 2, 9, 35, 30, 160, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 9, 35, 30, 160, DateTimeKind.Local).AddTicks(3600), new DateTime(2023, 6, 2, 9, 35, 30, 160, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 9, 35, 30, 160, DateTimeKind.Local).AddTicks(3603), new DateTime(2023, 6, 2, 9, 35, 30, 160, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 9, 35, 30, 160, DateTimeKind.Local).AddTicks(3605), new DateTime(2023, 6, 2, 9, 35, 30, 160, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 2, 9, 35, 30, 153, DateTimeKind.Local).AddTicks(8882));
        }
    }
}
