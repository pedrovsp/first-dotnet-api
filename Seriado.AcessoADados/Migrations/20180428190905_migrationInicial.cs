using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Seriado.AcessoADados.Migrations
{
    public partial class migrationInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seriados",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AvaliacaCriticos = table.Column<int>(nullable: false),
                    AvaliacaoPublico = table.Column<int>(nullable: false),
                    Categoria = table.Column<string>(nullable: true),
                    Duracao = table.Column<float>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    QtdEpisodios = table.Column<int>(nullable: false),
                    Temporada = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seriados", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seriados");
        }
    }
}
