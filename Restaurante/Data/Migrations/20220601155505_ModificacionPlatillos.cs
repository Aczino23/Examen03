using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurante.Data.Migrations
{
    public partial class ModificacionPlatillos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImagen",
                table: "Platillos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImagen",
                table: "Platillos");
        }
    }
}
