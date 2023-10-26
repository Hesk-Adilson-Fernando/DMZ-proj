namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatepjemp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pj", "Po", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pj", "Morada", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pj", "Contrato", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pj", "Empfiscal", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pjdoc", "Doclc", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pjdoc", "Doclc");
            DropColumn("dbo.Pj", "Empfiscal");
            DropColumn("dbo.Pj", "Contrato");
            DropColumn("dbo.Pj", "Morada");
            DropColumn("dbo.Pj", "Po");
        }
    }
}
