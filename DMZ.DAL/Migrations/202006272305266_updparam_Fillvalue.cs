namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updparam_Fillvalue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Fillvalue", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Fillvalue");
        }
    }
}
