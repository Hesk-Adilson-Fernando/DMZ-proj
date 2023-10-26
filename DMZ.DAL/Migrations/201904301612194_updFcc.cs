namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updFcc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Fcc", "Pgfstamp", "dbo.Pgf");
            DropForeignKey("dbo.Fcc", "Faccstamp", "dbo.Facc");
            DropForeignKey("dbo.Fcc", "Rdfstamp", "dbo.Rdf");
            DropIndex("dbo.Fcc", new[] { "Faccstamp" });
            DropIndex("dbo.Fcc", new[] { "Pgfstamp" });
            DropIndex("dbo.Fcc", new[] { "Rdfstamp" });
            AlterColumn("dbo.Fcc", "Faccstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Fcc", "Pgfstamp", c => c.String(maxLength: 80));
            AlterColumn("dbo.Fcc", "Rdfstamp", c => c.String(maxLength: 80));
            CreateIndex("dbo.Fcc", "Faccstamp");
            CreateIndex("dbo.Fcc", "Pgfstamp");
            CreateIndex("dbo.Fcc", "Rdfstamp");
            AddForeignKey("dbo.Fcc", "Pgfstamp", "dbo.Pgf", "Pgfstamp");
            AddForeignKey("dbo.Fcc", "Faccstamp", "dbo.Facc", "Faccstamp");
            AddForeignKey("dbo.Fcc", "Rdfstamp", "dbo.Rdf", "Rdfstamp");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fcc", "Rdfstamp", "dbo.Rdf");
            DropForeignKey("dbo.Fcc", "Faccstamp", "dbo.Facc");
            DropForeignKey("dbo.Fcc", "Pgfstamp", "dbo.Pgf");
            DropIndex("dbo.Fcc", new[] { "Rdfstamp" });
            DropIndex("dbo.Fcc", new[] { "Pgfstamp" });
            DropIndex("dbo.Fcc", new[] { "Faccstamp" });
            AlterColumn("dbo.Fcc", "Rdfstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Fcc", "Pgfstamp", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Fcc", "Faccstamp", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.Fcc", "Rdfstamp");
            CreateIndex("dbo.Fcc", "Pgfstamp");
            CreateIndex("dbo.Fcc", "Faccstamp");
            AddForeignKey("dbo.Fcc", "Rdfstamp", "dbo.Rdf", "Rdfstamp", cascadeDelete: true);
            AddForeignKey("dbo.Fcc", "Faccstamp", "dbo.Facc", "Faccstamp", cascadeDelete: true);
            AddForeignKey("dbo.Fcc", "Pgfstamp", "dbo.Pgf", "Pgfstamp", cascadeDelete: true);
        }
    }
}
