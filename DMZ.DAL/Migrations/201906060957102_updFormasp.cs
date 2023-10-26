namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updFormasp : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Formasp", "Rclstamp", "dbo.RCL");
            DropForeignKey("dbo.Formasp", "Factstamp", "dbo.Fact");
            DropForeignKey("dbo.Formasp", "Rdstamp", "dbo.Rd");
            DropForeignKey("dbo.Formasp", "Rdfstamp", "dbo.Rdf");
            DropForeignKey("dbo.Formasp", "Faccstamp", "dbo.Facc");
            DropIndex("dbo.Formasp", new[] { "Rclstamp" });
            DropIndex("dbo.Formasp", new[] { "Rdstamp" });
            DropIndex("dbo.Formasp", new[] { "Factstamp" });
            DropIndex("dbo.Formasp", new[] { "Faccstamp" });
            DropIndex("dbo.Formasp", new[] { "Rdfstamp" });
            AlterColumn("dbo.Formasp", "Rclstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Formasp", "Rdstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Formasp", "Factstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Formasp", "Faccstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Formasp", "Rdfstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Formasp", "Distamp", c => c.String(maxLength: 80));
            CreateIndex("dbo.Formasp", "Rclstamp");
            CreateIndex("dbo.Formasp", "Rdstamp");
            CreateIndex("dbo.Formasp", "Factstamp");
            CreateIndex("dbo.Formasp", "Faccstamp");
            CreateIndex("dbo.Formasp", "Rdfstamp");
            AddForeignKey("dbo.Formasp", "Rclstamp", "dbo.RCL", "Rclstamp");
            AddForeignKey("dbo.Formasp", "Factstamp", "dbo.Fact", "Factstamp");
            AddForeignKey("dbo.Formasp", "Rdstamp", "dbo.Rd", "Rdstamp");
            AddForeignKey("dbo.Formasp", "Rdfstamp", "dbo.Rdf", "Rdfstamp");
            AddForeignKey("dbo.Formasp", "Faccstamp", "dbo.Facc", "Faccstamp");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Formasp", "Faccstamp", "dbo.Facc");
            DropForeignKey("dbo.Formasp", "Rdfstamp", "dbo.Rdf");
            DropForeignKey("dbo.Formasp", "Rdstamp", "dbo.Rd");
            DropForeignKey("dbo.Formasp", "Factstamp", "dbo.Fact");
            DropForeignKey("dbo.Formasp", "Rclstamp", "dbo.RCL");
            DropIndex("dbo.Formasp", new[] { "Rdfstamp" });
            DropIndex("dbo.Formasp", new[] { "Faccstamp" });
            DropIndex("dbo.Formasp", new[] { "Factstamp" });
            DropIndex("dbo.Formasp", new[] { "Rdstamp" });
            DropIndex("dbo.Formasp", new[] { "Rclstamp" });
            AlterColumn("dbo.Formasp", "Distamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Formasp", "Rdfstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Formasp", "Faccstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Formasp", "Factstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Formasp", "Rdstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Formasp", "Rclstamp", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Formasp", "Rdfstamp");
            CreateIndex("dbo.Formasp", "Faccstamp");
            CreateIndex("dbo.Formasp", "Factstamp");
            CreateIndex("dbo.Formasp", "Rdstamp");
            CreateIndex("dbo.Formasp", "Rclstamp");
            AddForeignKey("dbo.Formasp", "Faccstamp", "dbo.Facc", "Faccstamp", cascadeDelete: true);
            AddForeignKey("dbo.Formasp", "Rdfstamp", "dbo.Rdf", "Rdfstamp", cascadeDelete: true);
            AddForeignKey("dbo.Formasp", "Rdstamp", "dbo.Rd", "Rdstamp", cascadeDelete: true);
            AddForeignKey("dbo.Formasp", "Factstamp", "dbo.Fact", "Factstamp", cascadeDelete: true);
            AddForeignKey("dbo.Formasp", "Rclstamp", "dbo.RCL", "Rclstamp", cascadeDelete: true);
        }
    }
}
