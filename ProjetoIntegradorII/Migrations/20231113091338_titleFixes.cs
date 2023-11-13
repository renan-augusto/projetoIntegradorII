using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoIntegradorII.Api.Migrations
{
    /// <inheritdoc />
    public partial class titleFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beneficaries_Adresses_AdressId",
                table: "Beneficaries");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_BeneficiaryId",
                table: "Titles",
                column: "BeneficiaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beneficaries_Adresses_AdressId",
                table: "Beneficaries",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_Beneficaries_BeneficiaryId",
                table: "Titles",
                column: "BeneficiaryId",
                principalTable: "Beneficaries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beneficaries_Adresses_AdressId",
                table: "Beneficaries");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_Beneficaries_BeneficiaryId",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_BeneficiaryId",
                table: "Titles");

            migrationBuilder.AddForeignKey(
                name: "FK_Beneficaries_Adresses_AdressId",
                table: "Beneficaries",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
