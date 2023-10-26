namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updclccfnccc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClCc", "Saldo", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.FncCc", "Saldo", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FncCc", "Saldo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.ClCc", "Saldo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
