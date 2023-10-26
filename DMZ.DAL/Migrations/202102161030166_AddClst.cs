namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clst",
                c => new
                    {
                        Clststamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Referenc = c.String(nullable: false, maxLength: 80),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Preco = c.Decimal(nullable: false, precision: 16, scale: 2),
                        Quant = c.Decimal(nullable: false, precision: 6, scale: 1),
                    })
                .PrimaryKey(t => t.Clststamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
            AddColumn("dbo.Cl", "Tipocl", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clst", "Clstamp", "dbo.Cl");
            DropIndex("dbo.Clst", new[] { "Clstamp" });
            DropColumn("dbo.Cl", "Tipocl");
            DropTable("dbo.Clst");
        }
    }
}
