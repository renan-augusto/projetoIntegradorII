using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoIntegradorII.Api.Migrations
{
    /// <inheritdoc />
    public partial class entitiesfixies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beneficaries_Adresses_AdressId",
                table: "Beneficaries");

            migrationBuilder.AlterColumn<int>(
                name: "AdressId",
                table: "Beneficaries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Beneficaries_Adresses_AdressId",
                table: "Beneficaries",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beneficaries_Adresses_AdressId",
                table: "Beneficaries");

            migrationBuilder.AlterColumn<int>(
                name: "AdressId",
                table: "Beneficaries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Beneficaries_Adresses_AdressId",
                table: "Beneficaries",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
