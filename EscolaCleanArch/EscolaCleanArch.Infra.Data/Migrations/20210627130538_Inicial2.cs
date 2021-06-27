using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaCleanArch.Infra.Data.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Cursos_CursoId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Diciplinas_Cursos_CursoId",
                table: "Diciplinas");

            migrationBuilder.DropForeignKey(
                name: "FK_NotasAlunos_Alunos_AlunoId",
                table: "NotasAlunos");

            migrationBuilder.DropForeignKey(
                name: "FK_NotasAlunos_Cursos_CursoId",
                table: "NotasAlunos");

            migrationBuilder.DropForeignKey(
                name: "FK_NotasAlunos_Diciplinas_DiciplinaId",
                table: "NotasAlunos");

            migrationBuilder.DropIndex(
                name: "IX_NotasAlunos_AlunoId",
                table: "NotasAlunos");

            migrationBuilder.DropIndex(
                name: "IX_NotasAlunos_CursoId",
                table: "NotasAlunos");

            migrationBuilder.DropIndex(
                name: "IX_NotasAlunos_DiciplinaId",
                table: "NotasAlunos");

            migrationBuilder.DropIndex(
                name: "IX_Diciplinas_CursoId",
                table: "Diciplinas");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_CursoId",
                table: "Alunos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_NotasAlunos_AlunoId",
                table: "NotasAlunos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasAlunos_CursoId",
                table: "NotasAlunos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasAlunos_DiciplinaId",
                table: "NotasAlunos",
                column: "DiciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Diciplinas_CursoId",
                table: "Diciplinas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CursoId",
                table: "Alunos",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Cursos_CursoId",
                table: "Alunos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diciplinas_Cursos_CursoId",
                table: "Diciplinas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NotasAlunos_Alunos_AlunoId",
                table: "NotasAlunos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "AlunoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotasAlunos_Cursos_CursoId",
                table: "NotasAlunos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotasAlunos_Diciplinas_DiciplinaId",
                table: "NotasAlunos",
                column: "DiciplinaId",
                principalTable: "Diciplinas",
                principalColumn: "DiciplinaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
