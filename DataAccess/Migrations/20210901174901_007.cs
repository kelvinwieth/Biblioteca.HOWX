using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _007 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locacao",
                columns: new[] { "Id", "DiaDevolucao", "DiaLocado", "DiaPrazo", "EstaAtrasado", "EstudanteId", "VolumeId" },
                values: new object[] { 1, null, new DateTime(2021, 9, 1, 14, 49, 0, 179, DateTimeKind.Local).AddTicks(954), new DateTime(2021, 9, 8, 14, 49, 0, 180, DateTimeKind.Local).AddTicks(8232), false, 4, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locacao",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
