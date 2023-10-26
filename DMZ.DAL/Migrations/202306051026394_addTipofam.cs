namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTipofam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Familia", "Tipofam", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Familia", "Tipofam");
        }
    }
}
