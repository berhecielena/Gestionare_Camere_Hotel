using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestionare_Camere_Hotel.Migrations
{
    /// <inheritdoc />
    public partial class updte6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Camere_Camere_CameraID",
                table: "Camere");

            migrationBuilder.DropForeignKey(
                name: "FK_Camere_Etaj_EtajId",
                table: "Camere");

            migrationBuilder.DropIndex(
                name: "IX_Camere_CameraID",
                table: "Camere");

            migrationBuilder.DropColumn(
                name: "CameraID",
                table: "Camere");

            migrationBuilder.RenameColumn(
                name: "EtajId",
                table: "Camere",
                newName: "EtajID");

            migrationBuilder.RenameIndex(
                name: "IX_Camere_EtajId",
                table: "Camere",
                newName: "IX_Camere_EtajID");

            migrationBuilder.AddForeignKey(
                name: "FK_Camere_Etaj_EtajID",
                table: "Camere",
                column: "EtajID",
                principalTable: "Etaj",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Camere_Etaj_EtajID",
                table: "Camere");

            migrationBuilder.RenameColumn(
                name: "EtajID",
                table: "Camere",
                newName: "EtajId");

            migrationBuilder.RenameIndex(
                name: "IX_Camere_EtajID",
                table: "Camere",
                newName: "IX_Camere_EtajId");

            migrationBuilder.AddColumn<int>(
                name: "CameraID",
                table: "Camere",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Camere_CameraID",
                table: "Camere",
                column: "CameraID");

            migrationBuilder.AddForeignKey(
                name: "FK_Camere_Camere_CameraID",
                table: "Camere",
                column: "CameraID",
                principalTable: "Camere",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Camere_Etaj_EtajId",
                table: "Camere",
                column: "EtajId",
                principalTable: "Etaj",
                principalColumn: "Id");
        }
    }
}
