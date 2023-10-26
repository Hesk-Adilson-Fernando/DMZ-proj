namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdContasstamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formasp", "Contasstamp2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pgf", "Fncstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.RCL", "Clstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RCL", "Clstamp");
            DropColumn("dbo.Pgf", "Fncstamp");
            DropColumn("dbo.Formasp", "Contasstamp2");
        }
    }
}
