using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurante.Data.Migrations
{
    public partial class ModificacionCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImagen",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImagen",
                table: "Categorias");
        }
    }
}
