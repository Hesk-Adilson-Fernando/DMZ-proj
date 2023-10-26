namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upprod : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProdPrecos", "padrao", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProdPrecos", "padrao");
        }
    }
}
