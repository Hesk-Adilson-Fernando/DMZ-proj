namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDescturma : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fact", "Cursostamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Desccurso", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Turmastamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Descturma", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Anosem", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Etapa", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fact", "Etapa");
            DropColumn("dbo.Fact", "Anosem");
            DropColumn("dbo.Fact", "Descturma");
            DropColumn("dbo.Fact", "Turmastamp");
            DropColumn("dbo.Fact", "Desccurso");
            DropColumn("dbo.Fact", "Cursostamp");
        }
    }
}
