namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPeTb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pedesc", "Perc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pefalta", "Injustificada", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "Total", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pefalta", "Docjustifica", c => c.Binary());
            AddColumn("dbo.Pehextra", "Inicio", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pehextra", "Fim", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pehextra", "Document", c => c.Binary());
            AlterColumn("dbo.Desconto", "Valor", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pefalta", "Justificada", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pehextra", "Obs", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Sub", "Valor", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            DropColumn("dbo.Pefalta", "Descricao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pefalta", "Descricao", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Sub", "Valor", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pehextra", "Obs", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Pefalta", "Justificada", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Desconto", "Valor", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Pehextra", "Document");
            DropColumn("dbo.Pehextra", "Fim");
            DropColumn("dbo.Pehextra", "Inicio");
            DropColumn("dbo.Pefalta", "Docjustifica");
            DropColumn("dbo.Pefalta", "Total");
            DropColumn("dbo.Pefalta", "Injustificada");
            DropColumn("dbo.Pedesc", "Perc");
        }
    }
}
