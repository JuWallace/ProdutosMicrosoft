using Microsoft.EntityFrameworkCore.Migrations;

namespace AgendaMedica_WEB.Migrations
{
    public partial class AtualizaTabelaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Usuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Peso",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
