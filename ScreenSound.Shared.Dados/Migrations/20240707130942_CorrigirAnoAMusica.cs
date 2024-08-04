using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class CorrigirAnoAMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Musicas");

            migrationBuilder.AddColumn<int>(
                name: "AnoLancamento",
                table: "Musicas",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnoLancamento",
                table: "Musicas");

            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Musicas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
