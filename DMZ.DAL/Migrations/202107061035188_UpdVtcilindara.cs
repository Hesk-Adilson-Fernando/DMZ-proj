namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdVtcilindara : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St", "Nofrota", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Cor", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.St", "Cilindrada", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.St", "Cilindrada", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            DropColumn("dbo.St", "Cor");
            DropColumn("dbo.St", "Nofrota");
        }
    }
}
