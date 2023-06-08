using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BanVeXemPhimApi.Migrations
{
    public partial class version_04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SeatHaveBeenBookedList",
                table: "schedules",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatHaveBeenBookedList",
                table: "schedules");

            migrationBuilder.UpdateData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 5, 19, 8, 22, 57, 597, DateTimeKind.Local).AddTicks(9455), new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2192), new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2199), new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2202), new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2205), new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 19, 8, 22, 57, 592, DateTimeKind.Local).AddTicks(2458));
        }
    }
}
