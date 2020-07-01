using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaAerolinea.Migrations
{
    public partial class DBSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vuelos",
                columns: new[] { "VueloId", "AsientosDisponibles", "CostoPasaje", "Destino", "Duracion", "HoraFechaLlegada", "HoraFechaSalida", "Origen" },
                values: new object[,]
                {
                    { 1, 200, 20000f, "Barcelona", 100, new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(5749), new DateTime(2020, 6, 26, 19, 40, 13, 308, DateTimeKind.Local).AddTicks(3674), "Buenos Aires" },
                    { 2, 200, 50000f, "Berlin", 100, new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(7853), new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(7838), "Buenos Aires" },
                    { 3, 200, 22000f, "Nueva York", 100, new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(7892), new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(7891), "Buenos Aires" },
                    { 4, 200, 18000f, "San Diego", 100, new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(7894), new DateTime(2020, 6, 26, 19, 40, 13, 309, DateTimeKind.Local).AddTicks(7893), "Buenos Aires" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vuelos",
                keyColumn: "VueloId",
                keyValue: 4);
        }
    }
}
