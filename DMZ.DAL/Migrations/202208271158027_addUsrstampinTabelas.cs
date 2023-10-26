namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUsrstampinTabelas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Caixa", "Contasstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixal", "Contasstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Fact", "Usrstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mstk", "Usrstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Usrstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Usrstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Rlt", "Mostrausr", c => c.Boolean(nullable: false));
            AddColumn("dbo.StPrecos", "Ccustamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.UsrAudit", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.UsrAudit", "Coment", c => c.String(nullable: false, maxLength: 3000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UsrAudit", "Coment", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.UsrAudit", "Total");
            DropColumn("dbo.StPrecos", "Ccustamp");
            DropColumn("dbo.Rlt", "Mostrausr");
            DropColumn("dbo.Facc", "Usrstamp");
            DropColumn("dbo.Di", "Usrstamp");
            DropColumn("dbo.Mstk", "Usrstamp");
            DropColumn("dbo.Fact", "Usrstamp");
            DropColumn("dbo.Caixal", "Contasstamp");
            DropColumn("dbo.Caixa", "Contasstamp");
        }
    }
}
