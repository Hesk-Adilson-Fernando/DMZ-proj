namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updUsrPos1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "Sigla", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "Sigla");
        }
    }
}
