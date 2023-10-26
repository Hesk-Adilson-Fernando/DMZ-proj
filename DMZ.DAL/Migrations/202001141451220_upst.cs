namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upst : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St", "Reserva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "Encomenda", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Starm", "Reserva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Starm", "Encomenda", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.St", "Stockmax", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.St", "Stockmax", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Starm", "Encomenda");
            DropColumn("dbo.Starm", "Reserva");
            DropColumn("dbo.St", "Encomenda");
            DropColumn("dbo.St", "Reserva");
        }
    }
}
