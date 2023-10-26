namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterUSrAnalises : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "NaoMostraAnalises", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "NaoMostraAnalises");
        }
    }
}
