namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdclCrtlPlafont : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cl", "Ctrlplanfond", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cl", "Ctrlplanfond");
        }
    }
}
