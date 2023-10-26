namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updFormasp1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Formasp", "Pgfstamp", "dbo.Pgf");
            DropIndex("dbo.Formasp", new[] { "Pgfstamp" });
            AlterColumn("dbo.Formasp", "Pgfstamp", c => c.String(maxLength: 80));
            CreateIndex("dbo.Formasp", "Pgfstamp");
            AddForeignKey("dbo.Formasp", "Pgfstamp", "dbo.Pgf", "Pgfstamp");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Formasp", "Pgfstamp", "dbo.Pgf");
            DropIndex("dbo.Formasp", new[] { "Pgfstamp" });
            AlterColumn("dbo.Formasp", "Pgfstamp", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Formasp", "Pgfstamp");
            AddForeignKey("dbo.Formasp", "Pgfstamp", "dbo.Pgf", "Pgfstamp", cascadeDelete: true);
        }
    }
}
