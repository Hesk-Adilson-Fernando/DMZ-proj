namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updproduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "Refornec", c => c.String(maxLength: 80));
            AddColumn("dbo.Produto", "Fornecedor", c => c.String(maxLength: 80));
            AddColumn("dbo.Produto", "Status", c => c.String(maxLength: 80));
            AddColumn("dbo.Produto", "Codsubfam", c => c.String(maxLength: 80));
            AddColumn("dbo.Produto", "Subfamilia", c => c.String(maxLength: 80));
            AddColumn("dbo.Produto", "Codarm", c => c.String(maxLength: 80));
            AddColumn("dbo.Produto", "Armazem", c => c.String(maxLength: 80));
            AddColumn("dbo.Produto", "Codfab", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Produto", "Fabricante", c => c.String(maxLength: 80));
            AddColumn("dbo.Produto", "Negativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Produto", "Avisanegativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Produto", "Descontinuado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Produto", "Combustivel", c => c.Boolean(nullable: false));
            AddColumn("dbo.Produto", "Ligaprojecto", c => c.Boolean(nullable: false));
            AddColumn("dbo.Produto", "Composto", c => c.Boolean(nullable: false));
            AddColumn("dbo.Produto", "Stock", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Produto", "ultimopreco", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Produto", "precoponderado", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "precoponderado");
            DropColumn("dbo.Produto", "ultimopreco");
            DropColumn("dbo.Produto", "Stock");
            DropColumn("dbo.Produto", "Composto");
            DropColumn("dbo.Produto", "Ligaprojecto");
            DropColumn("dbo.Produto", "Combustivel");
            DropColumn("dbo.Produto", "Descontinuado");
            DropColumn("dbo.Produto", "Avisanegativo");
            DropColumn("dbo.Produto", "Negativo");
            DropColumn("dbo.Produto", "Fabricante");
            DropColumn("dbo.Produto", "Codfab");
            DropColumn("dbo.Produto", "Armazem");
            DropColumn("dbo.Produto", "Codarm");
            DropColumn("dbo.Produto", "Subfamilia");
            DropColumn("dbo.Produto", "Codsubfam");
            DropColumn("dbo.Produto", "Status");
            DropColumn("dbo.Produto", "Fornecedor");
            DropColumn("dbo.Produto", "Refornec");
        }
    }
}
