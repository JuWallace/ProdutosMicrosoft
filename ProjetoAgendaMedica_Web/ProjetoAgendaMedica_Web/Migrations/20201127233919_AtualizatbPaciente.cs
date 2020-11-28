using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoAgendaMedica_Web.Migrations
{
    public partial class AtualizatbPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlanoSaudeId",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_PlanoSaudeId",
                table: "Pacientes",
                column: "PlanoSaudeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_PlanosSaude_PlanoSaudeId",
                table: "Pacientes",
                column: "PlanoSaudeId",
                principalTable: "PlanosSaude",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_PlanosSaude_PlanoSaudeId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_PlanoSaudeId",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "PlanoSaudeId",
                table: "Pacientes");
        }
    }
}
