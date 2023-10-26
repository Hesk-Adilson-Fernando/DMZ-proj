namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pehextra", "Obs", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.PeForm", "Pestamp");
            AddForeignKey("dbo.PeForm", "Pestamp", "dbo.Pe", "Pestamp", cascadeDelete: true);
            DropColumn("dbo.PeForm", "Codnivel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PeForm", "Codnivel", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropForeignKey("dbo.PeForm", "Pestamp", "dbo.Pe");
            DropIndex("dbo.PeForm", new[] { "Pestamp" });
            DropColumn("dbo.Pehextra", "Obs");
        }
    }
}
