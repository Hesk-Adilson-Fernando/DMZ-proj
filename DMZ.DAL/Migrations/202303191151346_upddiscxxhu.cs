namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upddiscxxhu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AnoSem", "Anolectstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Curso", "Pestamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Curso", "Director", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Pedagogico", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Coordenador", c => c.Boolean(nullable: false));
            CreateIndex("dbo.AnoSem", "Anolectstamp");
            AddForeignKey("dbo.AnoSem", "Anolectstamp", "dbo.Anolect", "Anolectstamp", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AnoSem", "Anolectstamp", "dbo.Anolect");
            DropIndex("dbo.AnoSem", new[] { "Anolectstamp" });
            DropColumn("dbo.Pe", "Coordenador");
            DropColumn("dbo.Pe", "Pedagogico");
            DropColumn("dbo.Curso", "Director");
            DropColumn("dbo.Curso", "Pestamp");
            DropColumn("dbo.AnoSem", "Anolectstamp");
        }
    }
}
