using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestionare_Camere_Hotel.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AngajatiId",
                table: "Etaj",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Etaj_AngajatiId",
                table: "Etaj",
                column: "AngajatiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Etaj_Angajati_AngajatiId",
                table: "Etaj",
                column: "AngajatiId",
                principalTable: "Angajati",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etaj_Angajati_AngajatiId",
                table: "Etaj");

            migrationBuilder.DropIndex(
                name: "IX_Etaj_AngajatiId",
                table: "Etaj");

            migrationBuilder.DropColumn(
                name: "AngajatiId",
                table: "Etaj");
        }
    }
}
