using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartGreenhouse.Migrations
{
    public partial class Inserti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            String insert = "insert into TipoviKorisnika(Naziv) values(\"Direktor\");";
            migrationBuilder.Sql(insert);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
