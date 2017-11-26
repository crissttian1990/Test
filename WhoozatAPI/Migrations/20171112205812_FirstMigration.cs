using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WhoozatAPI.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    active = table.Column<sbyte>(type: "tinyint", nullable: false),
                    address = table.Column<string>(type: "longtext", nullable: true),
                    city = table.Column<string>(type: "longtext", nullable: true),
                    creationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    idCountry = table.Column<int>(type: "int", nullable: false),
                    idEstate = table.Column<int>(type: "int", nullable: false),
                    idUserEstate = table.Column<int>(type: "int", nullable: true),
                    lastUpdate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    name = table.Column<string>(type: "longtext", nullable: true),
                    phone = table.Column<string>(type: "longtext", nullable: true),
                    photo = table.Column<string>(type: "longtext", nullable: true),
                    postalCode = table.Column<string>(type: "longtext", nullable: true),
                    state = table.Column<string>(type: "longtext", nullable: true),
                    unitsNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estates", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estates");
        }
    }
}
