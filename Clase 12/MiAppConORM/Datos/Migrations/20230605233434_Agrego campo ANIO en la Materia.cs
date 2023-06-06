using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    public partial class AgregocampoANIOenlaMateria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Anio",
                table: "Materia",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Anio",
                table: "Materia");
        }
    }
}
