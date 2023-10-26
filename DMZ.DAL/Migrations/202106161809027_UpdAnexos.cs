namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdAnexos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Faccanexo", "Di_Distamp", "dbo.Di");
            DropForeignKey("dbo.Factanexo", "Di_Distamp", "dbo.Di");
            DropIndex("dbo.Faccanexo", new[] { "Di_Distamp" });
            DropIndex("dbo.Factanexo", new[] { "Di_Distamp" });
            AddColumn("dbo.Fact", "Departamento", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.ClMorada", "Departamento", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Factanexo", "Factstamp");
            CreateIndex("dbo.Faccanexo", "Faccstamp");
            AddForeignKey("dbo.Factanexo", "Factstamp", "dbo.Fact", "Factstamp", cascadeDelete: true);
            AddForeignKey("dbo.Faccanexo", "Faccstamp", "dbo.Facc", "Faccstamp", cascadeDelete: true);
            DropColumn("dbo.ClMorada", "Zona");
            DropColumn("dbo.Faccanexo", "Di_Distamp");
            DropColumn("dbo.Factanexo", "Di_Distamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Factanexo", "Di_Distamp", c => c.String(maxLength: 80));
            AddColumn("dbo.Faccanexo", "Di_Distamp", c => c.String(maxLength: 80));
            AddColumn("dbo.ClMorada", "Zona", c => c.String(nullable: false, maxLength: 80));
            DropForeignKey("dbo.Faccanexo", "Faccstamp", "dbo.Facc");
            DropForeignKey("dbo.Factanexo", "Factstamp", "dbo.Fact");
            DropIndex("dbo.Faccanexo", new[] { "Faccstamp" });
            DropIndex("dbo.Factanexo", new[] { "Factstamp" });
            DropColumn("dbo.ClMorada", "Departamento");
            DropColumn("dbo.Fact", "Departamento");
            CreateIndex("dbo.Factanexo", "Di_Distamp");
            CreateIndex("dbo.Faccanexo", "Di_Distamp");
            AddForeignKey("dbo.Factanexo", "Di_Distamp", "dbo.Di", "Distamp");
            AddForeignKey("dbo.Faccanexo", "Di_Distamp", "dbo.Di", "Distamp");
        }
    }
}
