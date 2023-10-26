namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Quantvenda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St", "Quantvenda", c => c.Decimal(nullable: false, precision: 10, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.St", "Quantvenda");
        }
    }
}
