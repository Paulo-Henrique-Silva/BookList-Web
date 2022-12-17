using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookList.Migrations
{
    /// <inheritdoc />
    public partial class RenomeandoColunas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "tb_livros",
                newName: "titulo");

            migrationBuilder.RenameColumn(
                name: "Isbn",
                table: "tb_livros",
                newName: "isbn");

            migrationBuilder.RenameColumn(
                name: "Autor",
                table: "tb_livros",
                newName: "autor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_livros",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "titulo",
                table: "tb_livros",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "isbn",
                table: "tb_livros",
                newName: "Isbn");

            migrationBuilder.RenameColumn(
                name: "autor",
                table: "tb_livros",
                newName: "Autor");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tb_livros",
                newName: "Id");
        }
    }
}
