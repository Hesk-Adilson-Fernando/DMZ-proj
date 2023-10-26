namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPRCRH : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Prc", "Proces_Processtamp", "dbo.Proces");
            DropIndex("dbo.Prc", new[] { "Proces_Processtamp" });
            RenameColumn(table: "dbo.Prc", name: "Proces_Processtamp", newName: "Processtamp");
            AddColumn("dbo.Sub", "SubFixo", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Prc", "Processtamp", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Prc", "Processtamp");
            AddForeignKey("dbo.Prc", "Processtamp", "dbo.Proces", "Processtamp", cascadeDelete: true);
            DropColumn("dbo.Prc", "Processstamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Prc", "Processstamp", c => c.String(nullable: false, maxLength: 80));
            DropForeignKey("dbo.Prc", "Processtamp", "dbo.Proces");
            DropIndex("dbo.Prc", new[] { "Processtamp" });
            AlterColumn("dbo.Prc", "Processtamp", c => c.String(maxLength: 80));
            DropColumn("dbo.Sub", "SubFixo");
            RenameColumn(table: "dbo.Prc", name: "Processtamp", newName: "Proces_Processtamp");
            CreateIndex("dbo.Prc", "Proces_Processtamp");
            AddForeignKey("dbo.Prc", "Proces_Processtamp", "dbo.Proces", "Processtamp");
        }
    }
}
