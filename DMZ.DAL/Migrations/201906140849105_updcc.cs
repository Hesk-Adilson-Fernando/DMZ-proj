namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updcc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cc", "Factstamp", "dbo.Fact");
            DropForeignKey("dbo.Cc", "Rclstamp", "dbo.RCL");
            DropForeignKey("dbo.Cc", "Rdstamp", "dbo.Rd");
            DropIndex("dbo.Cc", new[] { "Factstamp" });
            DropIndex("dbo.Cc", new[] { "Rclstamp" });
            DropIndex("dbo.Cc", new[] { "Rdstamp" });
            AlterColumn("dbo.Cc", "Factstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Cc", "Rclstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Cc", "Rdstamp", c => c.String(maxLength: 80));
            CreateIndex("dbo.Cc", "Factstamp");
            CreateIndex("dbo.Cc", "Rclstamp");
            CreateIndex("dbo.Cc", "Rdstamp");
            AddForeignKey("dbo.Cc", "Factstamp", "dbo.Fact", "Factstamp");
            AddForeignKey("dbo.Cc", "Rclstamp", "dbo.RCL", "Rclstamp");
            AddForeignKey("dbo.Cc", "Rdstamp", "dbo.Rd", "Rdstamp");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cc", "Rdstamp", "dbo.Rd");
            DropForeignKey("dbo.Cc", "Rclstamp", "dbo.RCL");
            DropForeignKey("dbo.Cc", "Factstamp", "dbo.Fact");
            DropIndex("dbo.Cc", new[] { "Rdstamp" });
            DropIndex("dbo.Cc", new[] { "Rclstamp" });
            DropIndex("dbo.Cc", new[] { "Factstamp" });
            AlterColumn("dbo.Cc", "Rdstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Cc", "Rclstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Cc", "Factstamp", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Cc", "Rdstamp");
            CreateIndex("dbo.Cc", "Rclstamp");
            CreateIndex("dbo.Cc", "Factstamp");
            AddForeignKey("dbo.Cc", "Rdstamp", "dbo.Rd", "Rdstamp", cascadeDelete: true);
            AddForeignKey("dbo.Cc", "Rclstamp", "dbo.RCL", "Rclstamp", cascadeDelete: true);
            AddForeignKey("dbo.Cc", "Factstamp", "dbo.Fact", "Factstamp", cascadeDelete: true);
        }
    }
}
