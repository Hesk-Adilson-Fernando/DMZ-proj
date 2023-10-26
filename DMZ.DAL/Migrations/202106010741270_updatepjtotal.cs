namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatepjtotal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pj", "Subtotal", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pj", "Desconto", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pj", "Totaliva", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pj", "Total", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pj", "Total");
            DropColumn("dbo.Pj", "Totaliva");
            DropColumn("dbo.Pj", "Desconto");
            DropColumn("dbo.Pj", "Subtotal");
        }
    }
}
