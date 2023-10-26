namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updparamct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Paramgct", "Cc", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Paramgct", "Cc");
        }
    }
}
