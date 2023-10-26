namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpUsr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "Desconto", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "Desconto");
        }
    }
}
