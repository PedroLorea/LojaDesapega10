﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace LojaDesapega10.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
           name: "Produto",
           columns: table => new
           {
               Id = table.Column<int>(type: "int", nullable: false)
                   .Annotation("SqlServer:Identity", "1, 1"),
               Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
               Data = table.Column<DateTime>(type: "datetime2", nullable: false),
               Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
               Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
           },
           constraints: table =>
           {
               table.PrimaryKey("PK_Produto", x => x.Id);
           });
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

        }
    }
}
