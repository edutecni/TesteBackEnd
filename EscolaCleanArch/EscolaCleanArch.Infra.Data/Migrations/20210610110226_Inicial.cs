using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaCleanArch.Infra.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RA = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Periodo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.AlunoId);
                    table.ForeignKey(
                        name: "FK_Alunos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diciplinas",
                columns: table => new
                {
                    DiciplinaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NotaMinima = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diciplinas", x => x.DiciplinaId);
                    table.ForeignKey(
                        name: "FK_Diciplinas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NotasAlunos",
                columns: table => new
                {
                    NotaAlunoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlunoId = table.Column<int>(type: "int", nullable: true),
                    CursoId = table.Column<int>(type: "int", nullable: true),
                    DiciplinaId = table.Column<int>(type: "int", nullable: true),
                    NotaDiciplina = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasAlunos", x => x.NotaAlunoId);
                    table.ForeignKey(
                        name: "FK_NotasAlunos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "AlunoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotasAlunos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotasAlunos_Diciplinas_DiciplinaId",
                        column: x => x.DiciplinaId,
                        principalTable: "Diciplinas",
                        principalColumn: "DiciplinaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "Nome" },
                values: new object[,]
                {
                    { 1, "Ensino Fundamental" },
                    { 2, "Ensino Médio" },
                    { 3, "Faculdade" },
                    { 4, "Pós-Graduação" }
                });

            migrationBuilder.InsertData(
                table: "Diciplinas",
                columns: new[] { "DiciplinaId", "CursoId", "Nome", "NotaMinima" },
                values: new object[,]
                {
                    { 13, null, "Fisíca Faculdade", 7.0m },
                    { 12, null, "Matemática Faculdade", 7.0m },
                    { 11, null, "Portugês Faculdade", 7.0m },
                    { 10, null, "Geográfia Ensino Médio", 7.0m },
                    { 9, null, "Histógia Ensino Médio", 7.0m },
                    { 8, null, "Fisíca Ensino Médio", 7.0m },
                    { 6, null, "Portugês Ensino Médio", 7.0m },
                    { 14, null, "Histógia Faculdade", 7.0m },
                    { 5, null, "Geográfia Ensino Fundamental", 7.0m },
                    { 4, null, "Histógia Ensino Fundamental", 7.0m },
                    { 3, null, "Ciências Ensino Fundamental", 7.0m },
                    { 2, null, "Matemática Ensino Fundamental", 7.0m },
                    { 1, null, "Portugês Ensino Fundamental", 7.0m },
                    { 7, null, "Matemática Ensino Médio", 7.0m },
                    { 15, null, "Geográfia Faculdade", 7.0m }
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "AlunoId", "CursoId", "Foto", "Nome", "Periodo", "RA" },
                values: new object[] { 3, 1, null, "Thiago Fidelis Alves Canuto", "Noite", "00003" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "AlunoId", "CursoId", "Foto", "Nome", "Periodo", "RA" },
                values: new object[] { 2, 2, null, "Viviane Fidelis do Nascimento", "Tarde", "00002" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "AlunoId", "CursoId", "Foto", "Nome", "Periodo", "RA" },
                values: new object[] { 1, 3, null, "Eduardo Alves Canuto", "Manhã", "00001" });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_CursoId",
                table: "Alunos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Diciplinas_CursoId",
                table: "Diciplinas",
                column: "CursoId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotasAlunos");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Diciplinas");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
