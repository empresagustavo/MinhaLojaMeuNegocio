using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Aplicacao.Migrations
{
    public partial class AddNiveis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                $"INSERT INTO NIVEL" +
                $"(EntidadeId, Nome, DataDeCadastro, Valor, Ativo)" +
                $"VALUES" +
                $"('{Guid.NewGuid()}', 'Mestre', '{DateTime.Now}', {1}, {1})," +
                $"('{Guid.NewGuid()}', 'Administrador', '{DateTime.Now}', {2}, {1})," +
                $"('{Guid.NewGuid()}', 'Padrão', '{DateTime.Now}', {3}, {1})");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
