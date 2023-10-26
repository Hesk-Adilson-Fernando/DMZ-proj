namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updcliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cl", "Precoespecial", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cl", "Precoespecial");
        }
    }
}
