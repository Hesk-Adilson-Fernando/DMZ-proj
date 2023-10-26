namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Geramapa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rltmapa", "Rlt_Rltstamp", "dbo.Rlt");
            DropIndex("dbo.Rltmapa", new[] { "Rlt_Rltstamp" });
            RenameColumn(table: "dbo.Rltmapa", name: "Rlt_Rltstamp", newName: "Rltstamp");
            AddColumn("dbo.Rlt", "Geramapa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rltmapa", "ColumnType", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rltmapa", "Col1", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rltmapa", "Col2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rltmapa", "Col3", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rltmapa", "Col4", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rltmapa", "Col5", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Rltmapa", "Rltstamp", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Rltmapa", "Rltstamp");
            AddForeignKey("dbo.Rltmapa", "Rltstamp", "dbo.Rlt", "Rltstamp", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rltmapa", "Rltstamp", "dbo.Rlt");
            DropIndex("dbo.Rltmapa", new[] { "Rltstamp" });
            AlterColumn("dbo.Rltmapa", "Rltstamp", c => c.String(maxLength: 80));
            DropColumn("dbo.Rltmapa", "Col5");
            DropColumn("dbo.Rltmapa", "Col4");
            DropColumn("dbo.Rltmapa", "Col3");
            DropColumn("dbo.Rltmapa", "Col2");
            DropColumn("dbo.Rltmapa", "Col1");
            DropColumn("dbo.Rltmapa", "ColumnType");
            DropColumn("dbo.Rlt", "Geramapa");
            RenameColumn(table: "dbo.Rltmapa", name: "Rltstamp", newName: "Rlt_Rltstamp");
            CreateIndex("dbo.Rltmapa", "Rlt_Rltstamp");
            AddForeignKey("dbo.Rltmapa", "Rlt_Rltstamp", "dbo.Rlt", "Rltstamp");
        }
    }
}
