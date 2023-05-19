using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BanVeXemPhimApi.Migrations
{
    public partial class version_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "reviewMovies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviewMovies", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reviewMovies");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 4, 11, 5, 34, 37, 550, DateTimeKind.Utc).AddTicks(1959), new DateTime(2023, 4, 11, 12, 34, 37, 550, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 4, 11, 5, 34, 37, 553, DateTimeKind.Utc).AddTicks(639), new DateTime(2023, 4, 11, 12, 34, 37, 553, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 4, 11, 5, 34, 37, 553, DateTimeKind.Utc).AddTicks(861), new DateTime(2023, 4, 11, 12, 34, 37, 553, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 4, 11, 5, 34, 37, 553, DateTimeKind.Utc).AddTicks(872), new DateTime(2023, 4, 11, 12, 34, 37, 553, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2023, 4, 11, 5, 34, 37, 553, DateTimeKind.Utc).AddTicks(882), new DateTime(2023, 4, 11, 12, 34, 37, 553, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 11, 5, 34, 37, 532, DateTimeKind.Utc).AddTicks(7170));
        }
    }
}
