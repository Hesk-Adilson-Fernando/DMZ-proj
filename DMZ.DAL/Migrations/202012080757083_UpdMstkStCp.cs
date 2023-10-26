namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdMstkStCp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mstk", "Reserva", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Mstk", "Reservasaida", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Mstk", "Encomenda", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Mstk", "Encomendaentrada", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Facc", "Encomenda", c => c.Boolean(nullable: false));
            AddColumn("dbo.St", "Bloqueado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.St", "Bloqueado");
            DropColumn("dbo.Facc", "Encomenda");
            DropColumn("dbo.Mstk", "Encomendaentrada");
            DropColumn("dbo.Mstk", "Encomenda");
            DropColumn("dbo.Mstk", "Reservasaida");
            DropColumn("dbo.Mstk", "Reserva");
        }
    }
}
