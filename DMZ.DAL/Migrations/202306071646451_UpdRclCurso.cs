namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRclCurso : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RCL", "Cursostamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "Desccurso", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "Turmastamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "Descturma", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "Anosem", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "Etapa", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RCL", "Etapa");
            DropColumn("dbo.RCL", "Anosem");
            DropColumn("dbo.RCL", "Descturma");
            DropColumn("dbo.RCL", "Turmastamp");
            DropColumn("dbo.RCL", "Desccurso");
            DropColumn("dbo.RCL", "Cursostamp");
        }
    }
}
