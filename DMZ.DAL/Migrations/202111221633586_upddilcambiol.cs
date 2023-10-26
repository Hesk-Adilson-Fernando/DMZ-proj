namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upddilcambiol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dil", "Descarm2", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Dil", "cambiol");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dil", "cambiol", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            DropColumn("dbo.Dil", "Descarm2");
        }
    }
}
