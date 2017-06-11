using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartGreenhouse.Migrations
{
    public partial class NoviKorisnici : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            String insert = "insert into TipoviKorisnika(Naziv) values(\"Zemljoradnik\");";
            migrationBuilder.Sql(insert);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
