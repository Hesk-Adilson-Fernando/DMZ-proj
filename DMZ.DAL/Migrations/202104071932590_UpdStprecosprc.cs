namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdStprecosprc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StPrecos", "Perc", c => c.Decimal(nullable: false, precision: 9, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StPrecos", "Perc", c => c.Decimal(nullable: false, precision: 4, scale: 2));
        }
    }
}
