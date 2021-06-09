using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaCleanArch.Infra.Data.Migrations
{
    public partial class Inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiciplinaId",
                table: "Cursos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_DiciplinaId",
                table: "Cursos",
                column: "DiciplinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Diciplinas_DiciplinaId",
                table: "Cursos",
                column: "DiciplinaId",
                principalTable: "Diciplinas",
                principalColumn: "DiciplinaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Diciplinas_DiciplinaId",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_DiciplinaId",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "DiciplinaId",
                table: "Cursos");
        }
    }
}
