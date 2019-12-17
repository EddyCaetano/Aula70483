namespace SistemaContrtoleEstoque.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Estoque : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estoques",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Produto = c.String(),
                        Quantidade = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.String(),
                        UsuarioAlteracao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Estoques");
        }
    }
}
