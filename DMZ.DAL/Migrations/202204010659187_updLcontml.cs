namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updLcontml : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lcont", "Diariostamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ml", "Pgcstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ml", "Pgcstamp");
            DropColumn("dbo.Lcont", "Diariostamp");
        }
    }
}
