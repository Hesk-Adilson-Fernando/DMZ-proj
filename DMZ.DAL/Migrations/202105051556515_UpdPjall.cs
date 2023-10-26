namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPjall : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Facc", "Pjstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Pjno", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pgf", "Pjno", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pgf", "Pjstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgf", "PjNome", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "Pjno", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.RCL", "Pjstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "PjNome", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Facc", "Pjtamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Facc", "Pjtamp", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.RCL", "PjNome");
            DropColumn("dbo.RCL", "Pjstamp");
            DropColumn("dbo.RCL", "Pjno");
            DropColumn("dbo.Pgf", "PjNome");
            DropColumn("dbo.Pgf", "Pjstamp");
            DropColumn("dbo.Pgf", "Pjno");
            DropColumn("dbo.Facc", "Pjno");
            DropColumn("dbo.Facc", "Pjstamp");
        }
    }
}
