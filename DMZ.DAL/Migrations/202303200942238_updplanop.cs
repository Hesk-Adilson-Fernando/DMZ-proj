namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updplanop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planopag", "Cursostamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Planopag", "Desccurso", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Planopag", "Desccurso");
            DropColumn("dbo.Planopag", "Cursostamp");
        }
    }
}
