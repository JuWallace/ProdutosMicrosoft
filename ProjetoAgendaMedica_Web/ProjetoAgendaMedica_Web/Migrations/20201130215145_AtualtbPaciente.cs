using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoAgendaMedica_Web.Migrations
{
    public partial class AtualtbPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Pessoas_PacienteId",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_PlanosSaude_PlanoSaudeId",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "Pacientes");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoas_PlanoSaudeId",
                table: "Pacientes",
                newName: "IX_Pacientes_PlanoSaudeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Pacientes_PacienteId",
                table: "Consultas",
                column: "PacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Consultas_Pacientes_PacienteId",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_PlanosSaude_PlanoSaudeId",
                table: "Pacientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes");

            migrationBuilder.RenameTable(
                name: "Pacientes",
                newName: "Pessoas");

            migrationBuilder.RenameIndex(
                name: "IX_Pacientes_PlanoSaudeId",
                table: "Pessoas",
                newName: "IX_Pessoas_PlanoSaudeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Pessoas_PacienteId",
                table: "Consultas",
                column: "PacienteId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_PlanosSaude_PlanoSaudeId",
                table: "Pessoas",
                column: "PlanoSaudeId",
                principalTable: "PlanosSaude",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
