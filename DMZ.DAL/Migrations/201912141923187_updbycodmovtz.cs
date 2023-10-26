namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updbycodmovtz : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdoc", "Codmovtz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdoc", "Descmovtz", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocf", "Codmovtz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdocf", "Descmovtz", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tpgf", "Codmovtz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tpgf", "Descmovtz", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.TRcl", "Codmovtz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.TRcl", "Descmovtz", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TRcl", "Descmovtz");
            DropColumn("dbo.TRcl", "Codmovtz");
            DropColumn("dbo.Tpgf", "Descmovtz");
            DropColumn("dbo.Tpgf", "Codmovtz");
            DropColumn("dbo.Tdocf", "Descmovtz");
            DropColumn("dbo.Tdocf", "Codmovtz");
            DropColumn("dbo.Tdoc", "Descmovtz");
            DropColumn("dbo.Tdoc", "Codmovtz");
        }
    }
}
