namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdStkmov : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fact", "Vendido", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mstk", "Vendido", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Mstk", "Vendidosaida", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Mstk", "Comparado", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Mstk", "Comparadoentrada", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Di", "Vendido", c => c.Boolean(nullable: false));
            AddColumn("dbo.Di", "Comprado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Di", "Estorno", c => c.Boolean(nullable: false));
            AddColumn("dbo.Facc", "Pjnome", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Pjtamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Comprado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Vendido", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Comprado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "Estorno", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "Vendido", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.St", "Comprado", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.Starm", "Vendido", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.Starm", "Comprado", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AlterColumn("dbo.St", "Stock", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AlterColumn("dbo.St", "Stockmin", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AlterColumn("dbo.St", "Stockmax", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AlterColumn("dbo.St", "Reserva", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AlterColumn("dbo.St", "Encomenda", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AlterColumn("dbo.Starm", "Stock", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AlterColumn("dbo.Starm", "StockMin", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AlterColumn("dbo.Starm", "StockMax", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AlterColumn("dbo.Starm", "Reserva", c => c.Decimal(nullable: false, precision: 20, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Starm", "Reserva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Starm", "StockMax", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Starm", "StockMin", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Starm", "Stock", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.St", "Encomenda", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.St", "Reserva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.St", "Stockmax", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.St", "Stockmin", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.St", "Stock", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Starm", "Comprado");
            DropColumn("dbo.Starm", "Vendido");
            DropColumn("dbo.St", "Comprado");
            DropColumn("dbo.St", "Vendido");
            DropColumn("dbo.Tdi", "Estorno");
            DropColumn("dbo.Tdi", "Comprado");
            DropColumn("dbo.Tdi", "Vendido");
            DropColumn("dbo.Facc", "Comprado");
            DropColumn("dbo.Facc", "Pjtamp");
            DropColumn("dbo.Facc", "Pjnome");
            DropColumn("dbo.Di", "Estorno");
            DropColumn("dbo.Di", "Comprado");
            DropColumn("dbo.Di", "Vendido");
            DropColumn("dbo.Mstk", "Comparadoentrada");
            DropColumn("dbo.Mstk", "Comparado");
            DropColumn("dbo.Mstk", "Vendidosaida");
            DropColumn("dbo.Mstk", "Vendido");
            DropColumn("dbo.Fact", "Vendido");
        }
    }
}
