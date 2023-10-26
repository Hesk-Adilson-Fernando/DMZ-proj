namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatepeprc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Prc", "TaxaSegSocial", c => c.Decimal(nullable: false, precision: 6, scale: 2));
            AddColumn("dbo.Prc", "TotalSegSocial", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "Obsinss", c => c.String(nullable: false, maxLength: 800));
            AddColumn("dbo.Prc", "TipoEvento", c => c.String(nullable: false, maxLength: 800));
            AddColumn("dbo.Param", "TaxaInsspe", c => c.Decimal(nullable: false, precision: 6, scale: 2));
            AddColumn("dbo.Param", "TaxaInssemp", c => c.Decimal(nullable: false, precision: 6, scale: 2));
            AddColumn("dbo.Pe", "BalcaoInss", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pe", "DataInss", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pe", "DataApoliceIn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pe", "DataApoliceTer", c => c.DateTime(nullable: false));
            DropColumn("dbo.Prc", "Tempo");
            DropColumn("dbo.Param", "HorasdeTrabalho");
            DropColumn("dbo.Param", "NDiasmes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Param", "NDiasmes", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Param", "HorasdeTrabalho", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Prc", "Tempo", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Pe", "DataApoliceTer");
            DropColumn("dbo.Pe", "DataApoliceIn");
            DropColumn("dbo.Pe", "DataInss");
            DropColumn("dbo.Pe", "BalcaoInss");
            DropColumn("dbo.Param", "TaxaInssemp");
            DropColumn("dbo.Param", "TaxaInsspe");
            DropColumn("dbo.Prc", "TipoEvento");
            DropColumn("dbo.Prc", "Obsinss");
            DropColumn("dbo.Prc", "TotalSegSocial");
            DropColumn("dbo.Prc", "TaxaSegSocial");
        }
    }
}
