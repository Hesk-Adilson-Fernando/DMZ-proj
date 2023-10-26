namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upddiscxx : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cl", "Gradestamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cl", "Descgrelha", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Grade", "TotalCargaTeorica", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Grade", "TotalCargaPratica", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Grade", "TotalCargaPratica");
            DropColumn("dbo.Grade", "TotalCargaTeorica");
            DropColumn("dbo.Cl", "Descgrelha");
            DropColumn("dbo.Cl", "Gradestamp");
        }
    }
}
