namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterstcp2022 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stcp", "Ivainc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Stcp", "Oristamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stcp", "Oristamp");
            DropColumn("dbo.Stcp", "Ivainc");
        }
    }
}
