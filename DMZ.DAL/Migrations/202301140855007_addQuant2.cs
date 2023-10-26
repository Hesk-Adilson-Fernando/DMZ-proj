namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addQuant2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StQuant",
                c => new
                    {
                        StQuantstamp = c.String(nullable: false, maxLength: 80),
                        Ststamp = c.String(nullable: false, maxLength: 80),
                        Quant = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Descpos = c.String(nullable: false, maxLength: 2000),
                        Preco = c.Decimal(nullable: false, precision: 20, scale: 2),
                    })
                .PrimaryKey(t => t.StQuantstamp)
                .ForeignKey("dbo.St", t => t.Ststamp, cascadeDelete: true)
                .Index(t => t.Ststamp);
            
            AddColumn("dbo.Factl", "Usaquant2", c => c.Boolean(nullable: false));
            AddColumn("dbo.Factl", "Quant2", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Dil", "Usaquant2", c => c.Boolean(nullable: false));
            AddColumn("dbo.Dil", "Quant2", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Faccl", "Usaquant2", c => c.Boolean(nullable: false));
            AddColumn("dbo.Faccl", "Quant2", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Param", "Mostrarefornec", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "Usaquant2", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StQuant", "Ststamp", "dbo.St");
            DropIndex("dbo.StQuant", new[] { "Ststamp" });
            DropColumn("dbo.St", "Usaquant2");
            DropColumn("dbo.Param", "Mostrarefornec");
            DropColumn("dbo.Faccl", "Quant2");
            DropColumn("dbo.Faccl", "Usaquant2");
            DropColumn("dbo.Dil", "Quant2");
            DropColumn("dbo.Dil", "Usaquant2");
            DropColumn("dbo.Factl", "Quant2");
            DropColumn("dbo.Factl", "Usaquant2");
            DropTable("dbo.StQuant");
        }
    }
}
