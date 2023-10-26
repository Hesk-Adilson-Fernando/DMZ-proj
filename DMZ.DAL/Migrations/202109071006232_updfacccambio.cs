namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updfacccambio : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Facc", "Cambiousd", c => c.Decimal(nullable: false, precision: 8, scale: 2));
            DropColumn("dbo.Facc", "Codvend");
            DropColumn("dbo.Facc", "Vendedor");
            DropColumn("dbo.Facc", "Cambio");
            DropColumn("dbo.Facc", "Cambfixo");
            DropColumn("dbo.Facc", "Impresso");
            DropColumn("dbo.Facc", "Usrimpress");
            DropColumn("dbo.Facc", "Impressodh");
            DropColumn("dbo.Facc", "Clivainc");
            DropColumn("dbo.Facc", "Custos");
            DropColumn("dbo.Facc", "Calc");
            DropColumn("dbo.Facc", "Nodiario");
            DropColumn("dbo.Facc", "Diario");
            DropColumn("dbo.Facc", "NdocCont");
            DropColumn("dbo.Facc", "DescDocCont");
            DropColumn("dbo.Facc", "Codarm");
            DropColumn("dbo.Facc", "Tprocess");
            DropColumn("dbo.Facc", "Nrordem");
            DropColumn("dbo.Facc", "Nrtimms");
            DropColumn("dbo.Facc", "Numreceita");
            DropColumn("dbo.Facc", "Refpagam");
            DropColumn("dbo.Facc", "Ndeclara");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Facc", "Ndeclara", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Facc", "Refpagam", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Numreceita", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Facc", "Nrtimms", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Facc", "Nrordem", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Facc", "Tprocess", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Codarm", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Facc", "DescDocCont", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "NdocCont", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Facc", "Diario", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Nodiario", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Facc", "Calc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Facc", "Custos", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Facc", "Clivainc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Facc", "Impressodh", c => c.DateTime(nullable: false));
            AddColumn("dbo.Facc", "Usrimpress", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Impresso", c => c.Boolean(nullable: false));
            AddColumn("dbo.Facc", "Cambfixo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Facc", "Cambio", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Facc", "Vendedor", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Facc", "Codvend", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Facc", "Cambiousd", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
    }
}
