namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RltMostraCorresdor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rlt", "MostraCorredor", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rlt", "MostraCorredor");
        }
    }
}
