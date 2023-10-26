namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRH4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StPrecos", "Moeda", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Tirps", "Codigo", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tirps", "Codigo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.StPrecos", "Moeda");
        }
    }
}
