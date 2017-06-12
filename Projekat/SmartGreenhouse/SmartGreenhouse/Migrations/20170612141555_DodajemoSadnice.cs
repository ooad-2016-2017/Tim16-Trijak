using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartGreenhouse.Migrations
{
    public partial class DodajemoSadnice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Saadnice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cijena = table.Column<float>(nullable: true),
                    Kolicina = table.Column<int>(nullable: true),
                    NarudzbaId = table.Column<int>(nullable: true),
                    Naziv = table.Column<string>(nullable: true),
                    PonudaId = table.Column<int>(nullable: true),
                    Pozicija = table.Column<int>(nullable: true),
                    Prodato = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saadnice", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Saadnice");
        }
    }
}
