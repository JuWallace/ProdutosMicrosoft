using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoAgendaMedica_Web.Migrations
{
    public partial class AtualBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Fone",
                table: "Pacientes");

            migrationBuilder.RenameTable(
                name: "Pacientes",
                newName: "Pessoas");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "Pessoas",
                newName: "Cpf");

            migrationBuilder.RenameIndex(
                name: "IX_Pacientes_PlanoSaudeId",
                table: "Pessoas",
                newName: "IX_Pessoas_PlanoSaudeId");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Especialidade",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nascimento",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rg",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Medicos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nascimento",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rg",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Pessoas",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Especialidade",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Nascimento",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Rg",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Rua",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Nascimento",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Rg",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Rua",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "Pacientes");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Pacientes",
                newName: "CPF");

            migrationBuilder.RenameIndex(
                name: "IX_Pessoas_PlanoSaudeId",
                table: "Pacientes",
                newName: "IX_Pacientes_PlanoSaudeId");

            migrationBuilder.AddColumn<string>(
                name: "Fone",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
