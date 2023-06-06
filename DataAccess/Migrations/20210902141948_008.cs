using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _008 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1,
                column: "FotoUrl",
                value: "https://i.imgur.com/DqaowIO.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 2,
                column: "FotoUrl",
                value: "https://i.imgur.com/DCTgKSH.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 3,
                column: "FotoUrl",
                value: "https://i.imgur.com/k4Z4I2l.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 4,
                column: "FotoUrl",
                value: "https://i.imgur.com/tlApF7U.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 5,
                column: "FotoUrl",
                value: "https://i.imgur.com/uShdCOu.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 6,
                column: "FotoUrl",
                value: "https://i.imgur.com/I89ETSR.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 7,
                column: "FotoUrl",
                value: "https://i.imgur.com/wnp7Laf.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 8,
                column: "FotoUrl",
                value: "https://i.imgur.com/daJE9SS.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 9,
                column: "FotoUrl",
                value: "https://i.imgur.com/DPKc8P3.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 10,
                column: "FotoUrl",
                value: "https://i.imgur.com/k1HO1zQ.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 11,
                column: "FotoUrl",
                value: "https://i.imgur.com/5OeUSZc.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 12,
                column: "FotoUrl",
                value: "https://i.imgur.com/Of9C7qm.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 13,
                column: "FotoUrl",
                value: "https://i.imgur.com/NUo4xJE.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 14,
                column: "FotoUrl",
                value: "https://i.imgur.com/17hchGL.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 15,
                column: "FotoUrl",
                value: "https://i.imgur.com/Yf6mLFV.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 16,
                column: "FotoUrl",
                value: "https://i.imgur.com/BkUoUMT.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 17,
                column: "FotoUrl",
                value: "https://i.imgur.com/rSMPT8C.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 18,
                column: "FotoUrl",
                value: "https://i.imgur.com/FWKpcKo.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 19,
                column: "FotoUrl",
                value: "https://i.imgur.com/ZrbNMoP.jpg");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 20,
                column: "FotoUrl",
                value: "https://i.imgur.com/H8n63fg.jpg");

            migrationBuilder.UpdateData(
                table: "Locacao",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DiaLocado", "DiaPrazo" },
                values: new object[] { new DateTime(2021, 9, 2, 11, 19, 46, 447, DateTimeKind.Local).AddTicks(5360), new DateTime(2021, 9, 9, 11, 19, 46, 460, DateTimeKind.Local).AddTicks(77) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 2,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 3,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 4,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 5,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 6,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 7,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 8,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 9,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 10,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 11,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 12,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 13,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 14,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 15,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 16,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 17,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 18,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 19,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 20,
                column: "FotoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Locacao",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DiaLocado", "DiaPrazo" },
                values: new object[] { new DateTime(2021, 9, 1, 14, 49, 0, 179, DateTimeKind.Local).AddTicks(954), new DateTime(2021, 9, 8, 14, 49, 0, 180, DateTimeKind.Local).AddTicks(8232) });
        }
    }
}
