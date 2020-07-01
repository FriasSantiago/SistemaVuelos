using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaAerolinea.Migrations
{
    public partial class ReservaRegistro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NroTarjeta",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "TitularTarjeta",
                table: "Reservas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NroTarjeta",
                table: "Reservas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitularTarjeta",
                table: "Reservas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
