namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updusr2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "MostraLimpar", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "MostraLimpar");
        }
    }
}
