namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updFcc2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fcc", "Pgflstamp", c => c.String(maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fcc", "Pgflstamp", c => c.String(nullable: false, maxLength: 80));
        }
    }
}
