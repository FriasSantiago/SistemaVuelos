using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaAerolinea.Migrations
{
    public partial class RegistroAsientos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CapacidadMaxima",
                table: "Vuelos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 1,
                columns: new[] { "AsientosDisponibles", "CapacidadMaxima", "HoraFechaLlegada", "HoraFechaSalida" },
                values: new object[] { 2, 2, new DateTime(2020, 7, 7, 16, 54, 55, 742, DateTimeKind.Local).AddTicks(284), new DateTime(2020, 7, 7, 16, 54, 55, 739, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 2,
                columns: new[] { "CapacidadMaxima", "HoraFechaLlegada", "HoraFechaSalida" },
                values: new object[] { 200, new DateTime(2020, 7, 7, 16, 54, 55, 742, DateTimeKind.Local).AddTicks(2523), new DateTime(2020, 7, 7, 16, 54, 55, 742, DateTimeKind.Local).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 3,
                columns: new[] { "CapacidadMaxima", "HoraFechaLlegada", "HoraFechaSalida" },
                values: new object[] { 200, new DateTime(2020, 7, 7, 16, 54, 55, 742, DateTimeKind.Local).AddTicks(2564), new DateTime(2020, 7, 7, 16, 54, 55, 742, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 4,
                columns: new[] { "CapacidadMaxima", "HoraFechaLlegada", "HoraFechaSalida" },
                values: new object[] { 200, new DateTime(2020, 7, 7, 16, 54, 55, 742, DateTimeKind.Local).AddTicks(2566), new DateTime(2020, 7, 7, 16, 54, 55, 742, DateTimeKind.Local).AddTicks(2565) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CapacidadMaxima",
                table: "Vuelos");

            migrationBuilder.UpdateData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 1,
                columns: new[] { "AsientosDisponibles", "HoraFechaLlegada", "HoraFechaSalida" },
                values: new object[] { 200, new DateTime(2020, 6, 28, 16, 25, 50, 545, DateTimeKind.Local).AddTicks(4813), new DateTime(2020, 6, 28, 16, 25, 50, 544, DateTimeKind.Local).AddTicks(6338) });

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
    }
}
