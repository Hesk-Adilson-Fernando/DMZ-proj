namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCont : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contas", "Cpoc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cpoc", "Nrdoc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Cpoc", "Documento", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cpoc", "Codccu", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Cpoc", "Ccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CpocCompra", "Taxaiva", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CpocCompra", "Descontofin", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CpocCompra", "ValVendaest", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CpocCompra", "ValVendaoutro", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CpocVend", "Taxaiva", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CpocVend", "Descontofin", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CpocVend", "ValVendaest", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.CpocVend", "ValVendaoutro", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "Cpoc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "ContaInv", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "ContaCev", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "ContaReo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St", "ContaCoi", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.CpocCompra", "IVA", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.CpocCompra", "Desconto", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.CpocVend", "Desconto", c => c.String(nullable: false, maxLength: 80));
            CreateIndex("dbo.St", "Referenc", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.St", new[] { "Referenc" });
            AlterColumn("dbo.CpocVend", "Desconto", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.CpocCompra", "Desconto", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.CpocCompra", "IVA", c => c.String(nullable: false, maxLength: 12));
            DropColumn("dbo.St", "ContaCoi");
            DropColumn("dbo.St", "ContaReo");
            DropColumn("dbo.St", "ContaCev");
            DropColumn("dbo.St", "ContaInv");
            DropColumn("dbo.St", "Cpoc");
            DropColumn("dbo.CpocVend", "ValVendaoutro");
            DropColumn("dbo.CpocVend", "ValVendaest");
            DropColumn("dbo.CpocVend", "Descontofin");
            DropColumn("dbo.CpocVend", "Taxaiva");
            DropColumn("dbo.CpocCompra", "ValVendaoutro");
            DropColumn("dbo.CpocCompra", "ValVendaest");
            DropColumn("dbo.CpocCompra", "Descontofin");
            DropColumn("dbo.CpocCompra", "Taxaiva");
            DropColumn("dbo.Cpoc", "Ccusto");
            DropColumn("dbo.Cpoc", "Codccu");
            DropColumn("dbo.Cpoc", "Documento");
            DropColumn("dbo.Cpoc", "Nrdoc");
            DropColumn("dbo.Contas", "Cpoc");
        }
    }
}
