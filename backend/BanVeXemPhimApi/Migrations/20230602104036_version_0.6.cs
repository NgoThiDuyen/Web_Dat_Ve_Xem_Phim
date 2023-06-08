using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BanVeXemPhimApi.Migrations
{
    public partial class version_06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "order_tickets",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 2, 17, 40, 35, 833, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 40, 35, 833, DateTimeKind.Local).AddTicks(2855), new DateTime(2023, 6, 2, 17, 40, 35, 833, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 40, 35, 833, DateTimeKind.Local).AddTicks(6458), new DateTime(2023, 6, 2, 17, 40, 35, 833, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 40, 35, 833, DateTimeKind.Local).AddTicks(6471), new DateTime(2023, 6, 2, 17, 40, 35, 833, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 40, 35, 833, DateTimeKind.Local).AddTicks(6476), new DateTime(2023, 6, 2, 17, 40, 35, 833, DateTimeKind.Local).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 40, 35, 833, DateTimeKind.Local).AddTicks(6479), new DateTime(2023, 6, 2, 17, 40, 35, 833, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 2, 17, 40, 35, 823, DateTimeKind.Local).AddTicks(9855));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "order_tickets");

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
    }
}
