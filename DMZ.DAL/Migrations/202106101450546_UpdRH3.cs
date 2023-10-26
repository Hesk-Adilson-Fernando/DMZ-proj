namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRH3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pe", "Horasdia", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pe", "Codtipo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Tipo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Diasmes", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pe", "Apolice", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "Seguradora", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pedoc", "Anexo", c => c.Binary());
            DropColumn("dbo.Pe", "CodIrps");
            DropColumn("dbo.Pe", "Irps");
            DropColumn("dbo.Pe", "Percirps");
            DropColumn("dbo.Pe", "Inss");
            DropColumn("dbo.Pe", "Percinss");
            DropColumn("dbo.Pe", "Motorista");
            DropColumn("dbo.Pe", "Docente");
            DropColumn("dbo.Pe", "Mecanico");
            DropColumn("dbo.Pe", "UsaValBasico");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pe", "UsaValBasico", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Mecanico", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Docente", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Motorista", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Percinss", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pe", "Inss", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "Percirps", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pe", "Irps", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "CodIrps", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Pedoc", "Anexo");
            DropColumn("dbo.Pe", "Seguradora");
            DropColumn("dbo.Pe", "Apolice");
            DropColumn("dbo.Pe", "Diasmes");
            DropColumn("dbo.Pe", "Tipo");
            DropColumn("dbo.Pe", "Codtipo");
            DropColumn("dbo.Pe", "Horasdia");
        }
    }
}
