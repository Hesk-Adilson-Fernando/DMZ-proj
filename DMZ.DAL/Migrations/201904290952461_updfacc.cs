namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updfacc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Faccl", "Faccstamp", "dbo.Facc");
            DropIndex("dbo.Faccl", new[] { "Faccstamp" });
            AlterColumn("dbo.Faccl", "Faccstamp", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Faccl", "Faccstamp");
            AddForeignKey("dbo.Faccl", "Faccstamp", "dbo.Facc", "Faccstamp", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faccl", "Faccstamp", "dbo.Facc");
            DropIndex("dbo.Faccl", new[] { "Faccstamp" });
            AlterColumn("dbo.Faccl", "Faccstamp", c => c.String(maxLength: 80));
            CreateIndex("dbo.Faccl", "Faccstamp");
            AddForeignKey("dbo.Faccl", "Faccstamp", "dbo.Facc", "Faccstamp");
        }
    }
}
