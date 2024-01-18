using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestionare_Camere_Hotel.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Camere",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camere", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Angajati",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumarTelefon = table.Column<int>(type: "int", nullable: false),
                    Tura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CamereID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Angajati", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Angajati_Camere_CamereID",
                        column: x => x.CamereID,
                        principalTable: "Camere",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Etaj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumarEtaj = table.Column<int>(type: "int", nullable: false),
                    CamereID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etaj", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Etaj_Camere_CamereID",
                        column: x => x.CamereID,
                        principalTable: "Camere",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TipCamera",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CamereID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipCamera", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipCamera_Camere_CamereID",
                        column: x => x.CamereID,
                        principalTable: "Camere",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Angajati_CamereID",
                table: "Angajati",
                column: "CamereID");

            migrationBuilder.CreateIndex(
                name: "IX_Etaj_CamereID",
                table: "Etaj",
                column: "CamereID");

            migrationBuilder.CreateIndex(
                name: "IX_TipCamera_CamereID",
                table: "TipCamera",
                column: "CamereID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Angajati");

            migrationBuilder.DropTable(
                name: "Etaj");

            migrationBuilder.DropTable(
                name: "TipCamera");

            migrationBuilder.DropTable(
                name: "Camere");
        }
    }
}
