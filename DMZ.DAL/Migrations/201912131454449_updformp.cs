namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updformp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formasp", "Codmovtz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Formasp", "Descmovtz", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Formasp", "Codmovtz2", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Formasp", "Descmovtz2", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Formasp", "Descmovtz2");
            DropColumn("dbo.Formasp", "Codmovtz2");
            DropColumn("dbo.Formasp", "Descmovtz");
            DropColumn("dbo.Formasp", "Codmovtz");
        }
    }
}
