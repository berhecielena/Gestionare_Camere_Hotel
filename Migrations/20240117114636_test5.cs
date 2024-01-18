using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestionare_Camere_Hotel.Migrations
{
    /// <inheritdoc />
    public partial class test5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Angajati_Camere_CamereID",
                table: "Angajati");

            migrationBuilder.DropForeignKey(
                name: "FK_Etaj_Angajati_AngajatiId",
                table: "Etaj");

            migrationBuilder.DropForeignKey(
                name: "FK_Etaj_Camere_CamereID",
                table: "Etaj");

            migrationBuilder.DropForeignKey(
                name: "FK_TipCamera_Camere_CamereID",
                table: "TipCamera");

            migrationBuilder.DropIndex(
                name: "IX_TipCamera_CamereID",
                table: "TipCamera");

            migrationBuilder.DropIndex(
                name: "IX_Etaj_AngajatiId",
                table: "Etaj");

            migrationBuilder.DropIndex(
                name: "IX_Etaj_CamereID",
                table: "Etaj");

            migrationBuilder.DropIndex(
                name: "IX_Angajati_CamereID",
                table: "Angajati");

            migrationBuilder.DropColumn(
                name: "CamereID",
                table: "TipCamera");

            migrationBuilder.DropColumn(
                name: "AngajatiId",
                table: "Etaj");

            migrationBuilder.DropColumn(
                name: "CamereID",
                table: "Etaj");

            migrationBuilder.DropColumn(
                name: "CamereID",
                table: "Angajati");

            migrationBuilder.AddColumn<int>(
                name: "AngajatiID",
                table: "Camere",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CameraID",
                table: "Camere",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EtajId",
                table: "Camere",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipCameraID",
                table: "Camere",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Camere_AngajatiID",
                table: "Camere",
                column: "AngajatiID");

            migrationBuilder.CreateIndex(
                name: "IX_Camere_CameraID",
                table: "Camere",
                column: "CameraID");

            migrationBuilder.CreateIndex(
                name: "IX_Camere_EtajId",
                table: "Camere",
                column: "EtajId");

            migrationBuilder.CreateIndex(
                name: "IX_Camere_TipCameraID",
                table: "Camere",
                column: "TipCameraID");

            migrationBuilder.AddForeignKey(
                name: "FK_Camere_Angajati_AngajatiID",
                table: "Camere",
                column: "AngajatiID",
                principalTable: "Angajati",
                principalColumn: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Camere_TipCamera_TipCameraID",
                table: "Camere",
                column: "TipCameraID",
                principalTable: "TipCamera",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Camere_Angajati_AngajatiID",
                table: "Camere");

            migrationBuilder.DropForeignKey(
                name: "FK_Camere_Camere_CameraID",
                table: "Camere");

            migrationBuilder.DropForeignKey(
                name: "FK_Camere_Etaj_EtajId",
                table: "Camere");

            migrationBuilder.DropForeignKey(
                name: "FK_Camere_TipCamera_TipCameraID",
                table: "Camere");

            migrationBuilder.DropIndex(
                name: "IX_Camere_AngajatiID",
                table: "Camere");

            migrationBuilder.DropIndex(
                name: "IX_Camere_CameraID",
                table: "Camere");

            migrationBuilder.DropIndex(
                name: "IX_Camere_EtajId",
                table: "Camere");

            migrationBuilder.DropIndex(
                name: "IX_Camere_TipCameraID",
                table: "Camere");

            migrationBuilder.DropColumn(
                name: "AngajatiID",
                table: "Camere");

            migrationBuilder.DropColumn(
                name: "CameraID",
                table: "Camere");

            migrationBuilder.DropColumn(
                name: "EtajId",
                table: "Camere");

            migrationBuilder.DropColumn(
                name: "TipCameraID",
                table: "Camere");

            migrationBuilder.AddColumn<int>(
                name: "CamereID",
                table: "TipCamera",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AngajatiId",
                table: "Etaj",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CamereID",
                table: "Etaj",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CamereID",
                table: "Angajati",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipCamera_CamereID",
                table: "TipCamera",
                column: "CamereID");

            migrationBuilder.CreateIndex(
                name: "IX_Etaj_AngajatiId",
                table: "Etaj",
                column: "AngajatiId");

            migrationBuilder.CreateIndex(
                name: "IX_Etaj_CamereID",
                table: "Etaj",
                column: "CamereID");

            migrationBuilder.CreateIndex(
                name: "IX_Angajati_CamereID",
                table: "Angajati",
                column: "CamereID");

            migrationBuilder.AddForeignKey(
                name: "FK_Angajati_Camere_CamereID",
                table: "Angajati",
                column: "CamereID",
                principalTable: "Camere",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Etaj_Angajati_AngajatiId",
                table: "Etaj",
                column: "AngajatiId",
                principalTable: "Angajati",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Etaj_Camere_CamereID",
                table: "Etaj",
                column: "CamereID",
                principalTable: "Camere",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TipCamera_Camere_CamereID",
                table: "TipCamera",
                column: "CamereID",
                principalTable: "Camere",
                principalColumn: "Id");
        }
    }
}
