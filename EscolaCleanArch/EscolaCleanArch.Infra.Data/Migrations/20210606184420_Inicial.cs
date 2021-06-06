using Microsoft.EntityFrameworkCore.Migrations;

namespace EscolaCleanArch.Infra.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diciplinas",
                columns: table => new
                {
                    DiciplinaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NotaMinima = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diciplinas", x => x.DiciplinaId);
                });

            migrationBuilder.InsertData(
                table: "Diciplinas",
                columns: new[] { "DiciplinaId", "Nome", "NotaMinima" },
                values: new object[,]
                {
                    { 1, "Portugês", 7.0m },
                    { 2, "Matemática", 7.0m },
                    { 3, "Ciências", 7.0m },
                    { 4, "Histógia", 7.0m },
                    { 5, "Geográfia", 7.0m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diciplinas");
        }
    }
}
