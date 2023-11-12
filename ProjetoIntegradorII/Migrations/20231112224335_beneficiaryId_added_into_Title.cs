using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoIntegradorII.Api.Migrations
{
    /// <inheritdoc />
    public partial class beneficiaryId_added_into_Title : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BeneficiaryId",
                table: "Titles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeneficiaryId",
                table: "Titles");
        }
    }
}
