namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addReportXml : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ccu_Caixa", "Cx", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ccu_Caixa", "Descpos", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "ReportXml", c => c.String(nullable: false));
            AddColumn("dbo.Tdoc", "ReportXml", c => c.String(nullable: false));
            AddColumn("dbo.Tdocf", "ReportXml", c => c.String(nullable: false));
            AddColumn("dbo.TPercl", "ReportXml", c => c.String(nullable: false));
            AddColumn("dbo.Tpgf", "ReportXml", c => c.String(nullable: false));
            AddColumn("dbo.TRcl", "ReportXml", c => c.String(nullable: false));
            AddColumn("dbo.Usrcontas", "Descpos", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Ccu_Caixa", "Banco");
            DropColumn("dbo.Ccu_Caixa", "Sigla");
            DropColumn("dbo.Ccu_Caixa", "Poscaixa");
            DropColumn("dbo.Ccu_Caixa", "Posbanco");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ccu_Caixa", "Posbanco", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ccu_Caixa", "Poscaixa", c => c.Boolean(nullable: false));
            AddColumn("dbo.Ccu_Caixa", "Sigla", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Ccu_Caixa", "Banco", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Usrcontas", "Descpos");
            DropColumn("dbo.TRcl", "ReportXml");
            DropColumn("dbo.Tpgf", "ReportXml");
            DropColumn("dbo.TPercl", "ReportXml");
            DropColumn("dbo.Tdocf", "ReportXml");
            DropColumn("dbo.Tdoc", "ReportXml");
            DropColumn("dbo.Tdi", "ReportXml");
            DropColumn("dbo.Ccu_Caixa", "Descpos");
            DropColumn("dbo.Ccu_Caixa", "Cx");
        }
    }
}
