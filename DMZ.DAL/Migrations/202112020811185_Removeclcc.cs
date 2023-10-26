namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removeclcc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClCc", "Clstamp", "dbo.Cl");
            DropForeignKey("dbo.FncCc", "Fncstamp", "dbo.Fnc");
            DropIndex("dbo.ClCc", new[] { "Clstamp" });
            DropIndex("dbo.FncCc", new[] { "Fncstamp" });
            DropTable("dbo.ClCc");
            DropTable("dbo.FncCc");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FncCc",
                c => new
                    {
                        FncCcstamp = c.String(nullable: false, maxLength: 80),
                        Fncstamp = c.String(nullable: false, maxLength: 80),
                        Moeda = c.String(nullable: false, maxLength: 80),
                        Saldo = c.Decimal(nullable: false, precision: 16, scale: 2),
                    })
                .PrimaryKey(t => t.FncCcstamp);
            
            CreateTable(
                "dbo.ClCc",
                c => new
                    {
                        ClCcstamp = c.String(nullable: false, maxLength: 80),
                        Clstamp = c.String(nullable: false, maxLength: 80),
                        Moeda = c.String(nullable: false, maxLength: 80),
                        Saldo = c.Decimal(nullable: false, precision: 16, scale: 2),
                    })
                .PrimaryKey(t => t.ClCcstamp);
            
            CreateIndex("dbo.FncCc", "Fncstamp");
            CreateIndex("dbo.ClCc", "Clstamp");
            AddForeignKey("dbo.FncCc", "Fncstamp", "dbo.Fnc", "Fncstamp", cascadeDelete: true);
            AddForeignKey("dbo.ClCc", "Clstamp", "dbo.Cl", "Clstamp", cascadeDelete: true);
        }
    }
}
