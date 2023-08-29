using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sysestoque_CyberKnight.Migrations
{
    /// <inheritdoc />
    public partial class v2000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "precoUnit",
                table: "Produtos",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "precoUnit",
                table: "Produtos");
        }
    }
}
