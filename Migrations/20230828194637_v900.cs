using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sysestoque_CyberKnight.Migrations
{
    /// <inheritdoc />
    public partial class v900 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RazaoSocial",
                table: "Fornecedores",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Responsavel",
                table: "Fornecedores",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RazaoSocial",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "Responsavel",
                table: "Fornecedores");
        }
    }
}
