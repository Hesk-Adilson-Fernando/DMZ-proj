namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upst1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St", "Pos", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.St", "Pos");
        }
    }
}
