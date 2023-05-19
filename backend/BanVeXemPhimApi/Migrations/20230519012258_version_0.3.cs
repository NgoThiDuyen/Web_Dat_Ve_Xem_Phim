using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BanVeXemPhimApi.Migrations
{
    public partial class version_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "admins",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "NumberPhone", "Password", "Role", "UpdatedDate", "Username" },
                values: new object[] { 1, new DateTime(2023, 5, 19, 8, 22, 57, 598, DateTimeKind.Local).AddTicks(4669), "admin@gmail.com", "Admin", null, "75D23AF433E0CEA4C0E45A56DBA18B30", "Manager", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "admins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 5, 18, 18, 17, 48, 952, DateTimeKind.Local).AddTicks(3232), new DateTime(2023, 5, 18, 18, 17, 48, 952, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 5, 18, 18, 17, 48, 952, DateTimeKind.Local).AddTicks(5681), new DateTime(2023, 5, 18, 18, 17, 48, 952, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 5, 18, 18, 17, 48, 952, DateTimeKind.Local).AddTicks(5690), new DateTime(2023, 5, 18, 18, 17, 48, 952, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 5, 18, 18, 17, 48, 952, DateTimeKind.Local).AddTicks(5692), new DateTime(2023, 5, 18, 18, 17, 48, 952, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 5, 18, 18, 17, 48, 952, DateTimeKind.Local).AddTicks(5695), new DateTime(2023, 5, 18, 18, 17, 48, 952, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 18, 17, 48, 947, DateTimeKind.Local).AddTicks(512));
        }
    }
}
