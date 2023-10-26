namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updhorasex : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoraExtra", "Valor", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.HoraExtra", "Tipo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pesub", "ExcluiProc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefalta", "Descricao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefalta", "Codigo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefalta", "ExcluiProc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefalta", "ExcluiEstat", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefalta", "DescontaVenc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefalta", "DescontaRem", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefalta", "NumPeriodoProcessado", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "ValorDescontado", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pefalta", "AnoProcessado", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "NumProc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "DescontaSubsTurno", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefalta", "SubAlimProporcional", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pehextra", "Descricao", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pehextra", "Codigo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pehextra", "Tempo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pehextra", "ExcluiProc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pehextra", "DataProc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pehextra", "NumPeriodoProcessado", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pehextra", "AnoProcessado", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pehextra", "NumProc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.HoraExtra", "ValorPorHora");
            DropColumn("dbo.Pefalta", "DescricaoFalta");
            DropColumn("dbo.Pefalta", "CodigoDescricaoFalta");
            DropColumn("dbo.Pefalta", "ExcluiProcess");
            DropColumn("dbo.Pefalta", "ExcluiEstatistica");
            DropColumn("dbo.Pehextra", "TipoHoraExtra");
            DropColumn("dbo.Pehextra", "CodigoTipoHoraExtra");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pehextra", "CodigoTipoHoraExtra", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pehextra", "TipoHoraExtra", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefalta", "ExcluiEstatistica", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefalta", "ExcluiProcess", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pefalta", "CodigoDescricaoFalta", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "DescricaoFalta", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.HoraExtra", "ValorPorHora", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Pehextra", "NumProc");
            DropColumn("dbo.Pehextra", "AnoProcessado");
            DropColumn("dbo.Pehextra", "NumPeriodoProcessado");
            DropColumn("dbo.Pehextra", "DataProc");
            DropColumn("dbo.Pehextra", "ExcluiProc");
            DropColumn("dbo.Pehextra", "Tempo");
            DropColumn("dbo.Pehextra", "Codigo");
            DropColumn("dbo.Pehextra", "Descricao");
            DropColumn("dbo.Pefalta", "SubAlimProporcional");
            DropColumn("dbo.Pefalta", "DescontaSubsTurno");
            DropColumn("dbo.Pefalta", "NumProc");
            DropColumn("dbo.Pefalta", "AnoProcessado");
            DropColumn("dbo.Pefalta", "ValorDescontado");
            DropColumn("dbo.Pefalta", "NumPeriodoProcessado");
            DropColumn("dbo.Pefalta", "DescontaRem");
            DropColumn("dbo.Pefalta", "DescontaVenc");
            DropColumn("dbo.Pefalta", "ExcluiEstat");
            DropColumn("dbo.Pefalta", "ExcluiProc");
            DropColumn("dbo.Pefalta", "Codigo");
            DropColumn("dbo.Pefalta", "Descricao");
            DropColumn("dbo.Pesub", "ExcluiProc");
            DropColumn("dbo.HoraExtra", "Tipo");
            DropColumn("dbo.HoraExtra", "Valor");
        }
    }
}
