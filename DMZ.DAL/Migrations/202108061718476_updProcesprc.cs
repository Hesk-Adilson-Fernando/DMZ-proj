namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updProcesprc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Prc", "TotalSegSocEmp", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "TotalSegSocfunc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "TotalIrps", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Proces", "TotalSubsidio", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Proces", "TotalBaseVencimento", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Proces", "TotalDesconto", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Proces", "TotalAliment", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Proces", "TotalHextra", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Proces", "TotalFaltas", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Proces", "TotalSindicato", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Proces", "TotalSegSocfunc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Proces", "TotalSegSocEmp", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Proces", "TotalIrps", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Pe", "NaoInss", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pe", "NaoIRPS", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pedesc", "Datain", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pedesc", "Datafim", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pesub", "Datain", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pesub", "Datafim", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Pedesc", "Tipo", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            DropColumn("dbo.Prc", "SegSocEmp");
            DropColumn("dbo.Prc", "SegSocfunc");
            DropColumn("dbo.Prc", "ValorIrpsAlim");
            DropColumn("dbo.Pedesc", "Perc");
            DropColumn("dbo.Pedesc", "Estado");
            DropColumn("dbo.Pesub", "Perc");
            DropColumn("dbo.Pesub", "Estado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pesub", "Estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pesub", "Perc", c => c.Decimal(nullable: false, precision: 9, scale: 2));
            AddColumn("dbo.Pedesc", "Estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pedesc", "Perc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "ValorIrpsAlim", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "SegSocfunc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "SegSocEmp", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Pedesc", "Tipo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Pesub", "Datafim");
            DropColumn("dbo.Pesub", "Datain");
            DropColumn("dbo.Pedesc", "Datafim");
            DropColumn("dbo.Pedesc", "Datain");
            DropColumn("dbo.Pe", "NaoIRPS");
            DropColumn("dbo.Pe", "NaoInss");
            DropColumn("dbo.Proces", "TotalIrps");
            DropColumn("dbo.Proces", "TotalSegSocEmp");
            DropColumn("dbo.Proces", "TotalSegSocfunc");
            DropColumn("dbo.Proces", "TotalSindicato");
            DropColumn("dbo.Proces", "TotalFaltas");
            DropColumn("dbo.Proces", "TotalHextra");
            DropColumn("dbo.Proces", "TotalAliment");
            DropColumn("dbo.Proces", "TotalDesconto");
            DropColumn("dbo.Proces", "TotalBaseVencimento");
            DropColumn("dbo.Proces", "TotalSubsidio");
            DropColumn("dbo.Prc", "TotalIrps");
            DropColumn("dbo.Prc", "TotalSegSocfunc");
            DropColumn("dbo.Prc", "TotalSegSocEmp");
        }
    }
}
