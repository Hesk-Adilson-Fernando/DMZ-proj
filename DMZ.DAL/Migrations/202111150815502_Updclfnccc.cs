namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updclfnccc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClCc",
                c => new
                    {
                        ClCcstamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Moeda = c.String(nullable: false, maxLength: 80),
                        Saldo = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.ClCcstamp)
                .ForeignKey("dbo.Cl", t => t.Clstamp, cascadeDelete: true)
                .Index(t => t.Clstamp);
            
            CreateTable(
                "dbo.FncCc",
                c => new
                    {
                        FncCcstamp = c.String(nullable: false, maxLength: 80),
                        Fncstamp = c.String(nullable: false, maxLength: 80),
                        Moeda = c.String(nullable: false, maxLength: 80),
                        Saldo = c.Decimal(nullable: false, precision: 9, scale: 0),
                    })
                .PrimaryKey(t => t.FncCcstamp)
                .ForeignKey("dbo.Fnc", t => t.Fncstamp, cascadeDelete: true)
                .Index(t => t.Fncstamp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FncCc", "Fncstamp", "dbo.Fnc");
            DropForeignKey("dbo.ClCc", "Clstamp", "dbo.Cl");
            DropIndex("dbo.FncCc", new[] { "Fncstamp" });
            DropIndex("dbo.ClCc", new[] { "Clstamp" });
            DropTable("dbo.FncCc");
            DropTable("dbo.ClCc");
        }
    }
}
