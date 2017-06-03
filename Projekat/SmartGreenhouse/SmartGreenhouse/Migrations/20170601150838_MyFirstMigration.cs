using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartGreenhouse.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Narudzbe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DatumNarudzbe = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzbe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ponude",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BrojSadnica = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ponude", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreuzeteInformacije",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NivoVode = table.Column<double>(nullable: false),
                    Osvijetljenost = table.Column<double>(nullable: false),
                    Temperatura = table.Column<double>(nullable: false),
                    VlaznostZemljista = table.Column<double>(nullable: false),
                    VlaznostZraka = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreuzeteInformacije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoviIzvjestaja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoviIzvjestaja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoviKorisnika",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoviKorisnika", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sadnice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cijena = table.Column<float>(nullable: false),
                    Kolicina = table.Column<int>(nullable: false),
                    NarudzbaId = table.Column<int>(nullable: true),
                    Naziv = table.Column<string>(nullable: true),
                    PonudaId = table.Column<int>(nullable: true),
                    Pozicija = table.Column<int>(nullable: false),
                    Prodato = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sadnice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sadnice_Narudzbe_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzbe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sadnice_Ponude_PonudaId",
                        column: x => x.PonudaId,
                        principalTable: "Ponude",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Izvjestaji",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DatumIzvjestaja = table.Column<DateTime>(nullable: false),
                    TipIzvjestajaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izvjestaji", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Izvjestaji_TipoviIzvjestaja_TipIzvjestajaId",
                        column: x => x.TipIzvjestajaId,
                        principalTable: "TipoviIzvjestaja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Statistike",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DatumIzvjestaja = table.Column<DateTime>(nullable: false),
                    VrstaSadniceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statistike_Sadnice_VrstaSadniceId",
                        column: x => x.VrstaSadniceId,
                        principalTable: "Sadnice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Izvjestaji_TipIzvjestajaId",
                table: "Izvjestaji",
                column: "TipIzvjestajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sadnice_NarudzbaId",
                table: "Sadnice",
                column: "NarudzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sadnice_PonudaId",
                table: "Sadnice",
                column: "PonudaId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistike_VrstaSadniceId",
                table: "Statistike",
                column: "VrstaSadniceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Izvjestaji");

            migrationBuilder.DropTable(
                name: "PreuzeteInformacije");

            migrationBuilder.DropTable(
                name: "Statistike");

            migrationBuilder.DropTable(
                name: "TipoviKorisnika");

            migrationBuilder.DropTable(
                name: "TipoviIzvjestaja");

            migrationBuilder.DropTable(
                name: "Sadnice");

            migrationBuilder.DropTable(
                name: "Narudzbe");

            migrationBuilder.DropTable(
                name: "Ponude");
        }
    }
}
