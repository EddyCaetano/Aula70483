namespace SistemaContrtoleEstoque.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Estoques", "UsuarioCriacao", c => c.Int(nullable: false));
            AlterColumn("dbo.Estoques", "UsuarioAlteracao", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Estoques", "UsuarioAlteracao", c => c.String());
            AlterColumn("dbo.Estoques", "UsuarioCriacao", c => c.String());
        }
    }
}
