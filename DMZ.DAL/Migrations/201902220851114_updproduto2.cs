namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updproduto2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProdConposto",
                c => new
                    {
                        ProdConpostostamp = c.String(nullable: false, maxLength: 80),
                        Produtostamp = c.String(maxLength: 80),
                        descricao = c.String(maxLength: 80),
                        quantid = c.String(maxLength: 80),
                        Preco = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.ProdConpostostamp)
                .ForeignKey("dbo.Produto", t => t.Produtostamp)
                .Index(t => t.Produtostamp);
            
            CreateTable(
                "dbo.ProdPrecos",
                c => new
                    {
                        ProdPrecostamp = c.String(nullable: false, maxLength: 80),
                        Produtostamp = c.String(maxLength: 80),
                        CCusto = c.String(maxLength: 80),
                        CodCCu = c.String(maxLength: 80),
                        Ivainc = c.Boolean(nullable: false),
                        Preco = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.ProdPrecostamp)
                .ForeignKey("dbo.Produto", t => t.Produtostamp)
                .Index(t => t.Produtostamp);
            
            AddColumn("dbo.Produto", "Obs", c => c.String(maxLength: 80));
            AddColumn("dbo.Produto", "Unidade", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProdPrecos", "Produtostamp", "dbo.Produto");
            DropForeignKey("dbo.ProdConposto", "Produtostamp", "dbo.Produto");
            DropIndex("dbo.ProdPrecos", new[] { "Produtostamp" });
            DropIndex("dbo.ProdConposto", new[] { "Produtostamp" });
            DropColumn("dbo.Produto", "Unidade");
            DropColumn("dbo.Produto", "Obs");
            DropTable("dbo.ProdPrecos");
            DropTable("dbo.ProdConposto");
        }
    }
}
