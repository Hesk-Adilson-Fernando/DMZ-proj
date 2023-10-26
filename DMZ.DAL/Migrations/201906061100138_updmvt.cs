namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updmvt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Mvt", "Formaspstamp", "dbo.Formasp");
            DropForeignKey("dbo.Mvt", "Trfstamp", "dbo.Trf");
            DropIndex("dbo.Mvt", new[] { "Trfstamp" });
            DropIndex("dbo.Mvt", new[] { "Formaspstamp" });
            AlterColumn("dbo.Mvt", "Oristamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Mvt", "Dpstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Mvt", "Trfstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Mvt", "Formaspstamp", c => c.String(maxLength: 80));
            CreateIndex("dbo.Mvt", "Trfstamp");
            CreateIndex("dbo.Mvt", "Formaspstamp");
            AddForeignKey("dbo.Mvt", "Formaspstamp", "dbo.Formasp", "Formaspstamp");
            AddForeignKey("dbo.Mvt", "Trfstamp", "dbo.Trf", "Trfstamp");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mvt", "Trfstamp", "dbo.Trf");
            DropForeignKey("dbo.Mvt", "Formaspstamp", "dbo.Formasp");
            DropIndex("dbo.Mvt", new[] { "Formaspstamp" });
            DropIndex("dbo.Mvt", new[] { "Trfstamp" });
            AlterColumn("dbo.Mvt", "Formaspstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Mvt", "Trfstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Mvt", "Dpstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Mvt", "Oristamp", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Mvt", "Formaspstamp");
            CreateIndex("dbo.Mvt", "Trfstamp");
            AddForeignKey("dbo.Mvt", "Trfstamp", "dbo.Trf", "Trfstamp", cascadeDelete: true);
            AddForeignKey("dbo.Mvt", "Formaspstamp", "dbo.Formasp", "Formaspstamp", cascadeDelete: true);
        }
    }
}
