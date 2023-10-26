namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updrcll2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contas", "MSaldo", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contas", "MSaldo");
        }
    }
}
