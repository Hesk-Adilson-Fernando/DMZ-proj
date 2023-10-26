namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upd20231 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rdlcxml", "Querry", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rdlcxml", "Querry");
        }
    }
}
