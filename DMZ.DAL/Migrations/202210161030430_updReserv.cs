namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updReserv : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reserva", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Reserva", "Usrstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Reserva", "Ccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Reserva", "Clstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Reserva", "Total", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Reserval", "Mesastamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Reserval", "Din", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reserval", "Dfim", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reserval", "Hin", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reserval", "Hfim", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Reserval", "Quant", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Reserval", "Valor", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Reserval", "Totall", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Usrcontas", "Conta", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Usrcontas", "Contasstamp", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Reserva", "Taxa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reserva", "Taxa", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Usrcontas", "Contasstamp", c => c.String(nullable: false, maxLength: 90));
            AlterColumn("dbo.Usrcontas", "Conta", c => c.String(nullable: false, maxLength: 90));
            AlterColumn("dbo.Reserval", "Totall", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Reserval", "Valor", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Reserval", "Quant", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Reserval", "Hfim");
            DropColumn("dbo.Reserval", "Hin");
            DropColumn("dbo.Reserval", "Dfim");
            DropColumn("dbo.Reserval", "Din");
            DropColumn("dbo.Reserval", "Mesastamp");
            DropColumn("dbo.Reserva", "Total");
            DropColumn("dbo.Reserva", "Clstamp");
            DropColumn("dbo.Reserva", "Ccusto");
            DropColumn("dbo.Reserva", "Usrstamp");
            DropColumn("dbo.Reserva", "Ccustamp");
        }
    }
}
