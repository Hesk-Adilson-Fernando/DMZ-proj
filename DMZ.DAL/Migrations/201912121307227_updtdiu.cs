namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updtdiu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Di", "Codmovtz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "Descmovtz", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Codmovtz2", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "Descmovtz2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "Codmovtz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdi", "Descmovtz", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "Codmovtz2", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdi", "Descmovtz2", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Di", "Codtz2");
            DropColumn("dbo.Di", "Desccodtz2");
            DropColumn("dbo.Tdi", "Codtz2");
            DropColumn("dbo.Tdi", "Desccodtz2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tdi", "Desccodtz2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "Codtz2", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Di", "Desccodtz2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Codtz2", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Tdi", "Descmovtz2");
            DropColumn("dbo.Tdi", "Codmovtz2");
            DropColumn("dbo.Tdi", "Descmovtz");
            DropColumn("dbo.Tdi", "Codmovtz");
            DropColumn("dbo.Di", "Descmovtz2");
            DropColumn("dbo.Di", "Codmovtz2");
            DropColumn("dbo.Di", "Descmovtz");
            DropColumn("dbo.Di", "Codmovtz");
        }
    }
}
