using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    public partial class SeagregaelcampoProfesorTitularenlamateria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfesorTitular",
                table: "Materia",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfesorTitular",
                table: "Materia");
        }
    }
}
