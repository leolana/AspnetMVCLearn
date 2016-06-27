namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carrinho",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        CPF = c.String(nullable: false, maxLength: 14),
                        Endereco = c.String(nullable: false, maxLength: 255),
                        Municipio = c.String(nullable: false, maxLength: 50),
                        UF = c.String(nullable: false, maxLength: 2),
                        CEP = c.String(nullable: false, maxLength: 9),
                        Telefone = c.String(nullable: false, maxLength: 13),
                        Email = c.String(nullable: false, maxLength: 255),
                        Senha = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        LivroId = c.Int(nullable: false),
                        CarrinhoId = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.LivroId, t.CarrinhoId })
                .ForeignKey("dbo.Carrinho", t => t.CarrinhoId, cascadeDelete: true)
                .ForeignKey("dbo.Livro", t => t.LivroId, cascadeDelete: true)
                .Index(t => t.LivroId)
                .Index(t => t.CarrinhoId);
            
            CreateTable(
                "dbo.Livro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Autor = c.String(nullable: false, maxLength: 100),
                        Titulo = c.String(nullable: false, maxLength: 100),
                        Sinopse = c.String(maxLength: 2048),
                        DataLancamento = c.DateTime(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categoria", t => t.CategoriaId, cascadeDelete: true)
                .Index(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Compra",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CarrinhoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carrinho", t => t.CarrinhoId, cascadeDelete: true)
                .Index(t => t.CarrinhoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compra", "CarrinhoId", "dbo.Carrinho");
            DropForeignKey("dbo.Item", "LivroId", "dbo.Livro");
            DropForeignKey("dbo.Livro", "CategoriaId", "dbo.Categoria");
            DropForeignKey("dbo.Item", "CarrinhoId", "dbo.Carrinho");
            DropForeignKey("dbo.Carrinho", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Compra", new[] { "CarrinhoId" });
            DropIndex("dbo.Livro", new[] { "CategoriaId" });
            DropIndex("dbo.Item", new[] { "CarrinhoId" });
            DropIndex("dbo.Item", new[] { "LivroId" });
            DropIndex("dbo.Carrinho", new[] { "ClienteId" });
            DropTable("dbo.Compra");
            DropTable("dbo.Categoria");
            DropTable("dbo.Livro");
            DropTable("dbo.Item");
            DropTable("dbo.Cliente");
            DropTable("dbo.Carrinho");
        }
    }
}
