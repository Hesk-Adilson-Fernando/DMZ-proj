namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updPlafond : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdoc", "Plafond", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tdoc", "Plafond");
        }
    }
}
