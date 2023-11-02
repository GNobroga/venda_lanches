﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendaLanches.Migrations
{
    /// <inheritdoc />
    public partial class V3_Populate_Table_Lanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO \"Lanches\" (\"CategoriaId\",\"DescricaoCurta\",\"DescricaoDetalhada\",\"EmEstoque\",\"ImagemThumbnailUrl\",\"ImagemUrl\",\"IsLanchePreferido\",\"Nome\",\"Preco\") VALUES(1,'Pão, hambúrger, ovo, presunto, queijo e batata palha','Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',true, 'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg','http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', true ,'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO \"Lanches\" (\"CategoriaId\",\"DescricaoCurta\",\"DescricaoDetalhada\",\"EmEstoque\",\"ImagemThumbnailUrl\",\"ImagemUrl\",\"IsLanchePreferido\",\"Nome\",\"Preco\") VALUES(1,'Pão, presunto, mussarela e tomate','Delicioso pão francês quentinho na chapa com presunto e mussarela bem servidos com tomate preparado com carinho.',true,'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg','http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg',true,'Misto Quente', 8.00)");
            migrationBuilder.Sql("INSERT INTO \"Lanches\" (\"CategoriaId\",\"DescricaoCurta\",\"DescricaoDetalhada\",\"EmEstoque\",\"ImagemThumbnailUrl\",\"ImagemUrl\",\"IsLanchePreferido\",\"Nome\",\"Preco\") VALUES(1,'Pão, hambúrger, presunto, mussarela e batalha palha','Pão de hambúrger especial com hambúrger de nossa preparação e presunto e mussarela; acompanha batata palha.',true,'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg','http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg',true,'Cheese Burger', 11.00)");
            migrationBuilder.Sql("INSERT INTO \"Lanches\" (\"CategoriaId\",\"DescricaoCurta\",\"DescricaoDetalhada\",\"EmEstoque\",\"ImagemThumbnailUrl\",\"ImagemUrl\",\"IsLanchePreferido\",\"Nome\",\"Preco\") VALUES(2,'Pão Integral, queijo branco, peito de peru, cenoura, alface, iogurte','Pão integral natural com queijo branco, peito de peru e cenoura ralada com alface picado e iorgurte natural.',true,'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg','http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg',true,'Lanche Natural Peito Peru', 15.00)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
