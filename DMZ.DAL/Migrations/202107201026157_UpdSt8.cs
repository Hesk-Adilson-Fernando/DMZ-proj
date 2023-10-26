namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdSt8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lcont", "Moeda", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Ivametade", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.St", "Ivametade");
            DropColumn("dbo.Lcont", "Moeda");
        }
    }
}
