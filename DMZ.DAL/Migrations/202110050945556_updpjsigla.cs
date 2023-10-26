namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updpjsigla : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pj", "Sigla", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pj", "Sigla");
        }
    }
}
