namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updtdi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdi", "Codtz2", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdi", "Desccodtz2", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tdi", "Desccodtz2");
            DropColumn("dbo.Tdi", "Codtz2");
        }
    }
}
