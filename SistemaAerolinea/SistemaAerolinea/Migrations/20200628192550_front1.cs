using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaAerolinea.Migrations
{
    public partial class front1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 1,
                columns: new[] { "HoraFechaLlegada", "HoraFechaSalida" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 25, 50, 545, DateTimeKind.Local).AddTicks(4813), new DateTime(2020, 6, 28, 16, 25, 50, 544, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 2,
                columns: new[] { "HoraFechaLlegada", "HoraFechaSalida" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 25, 50, 545, DateTimeKind.Local).AddTicks(6578), new DateTime(2020, 6, 28, 16, 25, 50, 545, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 3,
                columns: new[] { "HoraFechaLlegada", "HoraFechaSalida" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 25, 50, 545, DateTimeKind.Local).AddTicks(6610), new DateTime(2020, 6, 28, 16, 25, 50, 545, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 4,
                columns: new[] { "HoraFechaLlegada", "HoraFechaSalida" },
                values: new object[] { new DateTime(2020, 6, 28, 16, 25, 50, 545, DateTimeKind.Local).AddTicks(6612), new DateTime(2020, 6, 28, 16, 25, 50, 545, DateTimeKind.Local).AddTicks(6611) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 1,
                columns: new[] { "HoraFechaLlegada", "HoraFechaSalida" },
                values: new object[] { new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(5749), new DateTime(2020, 6, 26, 19, 40, 13, 308, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 2,
                columns: new[] { "HoraFechaLlegada", "HoraFechaSalida" },
                values: new object[] { new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(7853), new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 3,
                columns: new[] { "HoraFechaLlegada", "HoraFechaSalida" },
                values: new object[] { new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(7892), new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 4,
                columns: new[] { "HoraFechaLlegada", "HoraFechaSalida" },
                values: new object[] { new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(7894), new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(7893) });
        }
    }
}
