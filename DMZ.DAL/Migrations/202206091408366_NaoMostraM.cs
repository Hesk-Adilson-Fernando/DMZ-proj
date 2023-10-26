namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NaoMostraM : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rlt", "NaoMostraM", c => c.Boolean(nullable: false));
            //DropColumn("dbo.Rlt", "NaoMostraMoeda");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Rlt", "NaoMostraMoeda", c => c.Boolean(nullable: false));
            DropColumn("dbo.Rlt", "NaoMostraM");
        }
    }
}
