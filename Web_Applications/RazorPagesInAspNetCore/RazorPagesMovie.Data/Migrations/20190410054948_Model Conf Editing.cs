using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesMovie.Data.Migrations
{
    public partial class ModelConfEditing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Release Datge",
                table: "Movies",
                newName: "Release Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Release Date",
                table: "Movies",
                newName: "Release Datge");
        }
    }
}
