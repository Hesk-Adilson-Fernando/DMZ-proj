namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteraml2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ml", "Apuraiva", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ml", "Apurares", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ml", "Apurares");
            DropColumn("dbo.Ml", "Apuraiva");
        }
    }
}
