using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sysestoque_CyberKnight.Migrations
{
    /// <inheritdoc />
    public partial class v700 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Numeracao",
                table: "NotasEntrada",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numeracao",
                table: "NotasEntrada");
        }
    }
}
