namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updmstk : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Mstk", "Factlstamp", "dbo.Factl");
            DropForeignKey("dbo.Mstk", "Dilstamp", "dbo.Dil");
            DropForeignKey("dbo.Mstk", "Facclstamp", "dbo.Faccl");
            DropIndex("dbo.Mstk", new[] { "Factlstamp" });
            DropIndex("dbo.Mstk", new[] { "Facclstamp" });
            DropIndex("dbo.Mstk", new[] { "Dilstamp" });
            AlterColumn("dbo.Mstk", "Factstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Mstk", "Faccstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Mstk", "Distamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Mstk", "Ivstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Mstk", "Factlstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Mstk", "Facclstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Mstk", "Dilstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Mstk", "Ivlstamp", c => c.String(maxLength: 80));
            CreateIndex("dbo.Mstk", "Factlstamp");
            CreateIndex("dbo.Mstk", "Facclstamp");
            CreateIndex("dbo.Mstk", "Dilstamp");
            AddForeignKey("dbo.Mstk", "Factlstamp", "dbo.Factl", "Factlstamp");
            AddForeignKey("dbo.Mstk", "Dilstamp", "dbo.Dil", "Dilstamp");
            AddForeignKey("dbo.Mstk", "Facclstamp", "dbo.Faccl", "Facclstamp");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mstk", "Facclstamp", "dbo.Faccl");
            DropForeignKey("dbo.Mstk", "Dilstamp", "dbo.Dil");
            DropForeignKey("dbo.Mstk", "Factlstamp", "dbo.Factl");
            DropIndex("dbo.Mstk", new[] { "Dilstamp" });
            DropIndex("dbo.Mstk", new[] { "Facclstamp" });
            DropIndex("dbo.Mstk", new[] { "Factlstamp" });
            AlterColumn("dbo.Mstk", "Ivlstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Mstk", "Dilstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Mstk", "Facclstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Mstk", "Factlstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Mstk", "Ivstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Mstk", "Distamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Mstk", "Faccstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Mstk", "Factstamp", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Mstk", "Dilstamp");
            CreateIndex("dbo.Mstk", "Facclstamp");
            CreateIndex("dbo.Mstk", "Factlstamp");
            AddForeignKey("dbo.Mstk", "Facclstamp", "dbo.Faccl", "Facclstamp", cascadeDelete: true);
            AddForeignKey("dbo.Mstk", "Dilstamp", "dbo.Dil", "Dilstamp", cascadeDelete: true);
            AddForeignKey("dbo.Mstk", "Factlstamp", "dbo.Factl", "Factlstamp", cascadeDelete: true);
        }
    }
}
