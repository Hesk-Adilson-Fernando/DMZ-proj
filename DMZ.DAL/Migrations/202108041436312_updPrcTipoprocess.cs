namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updPrcTipoprocess : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Prc", "Tipoproces", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Proces", "CCusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Proces", "Tipoproces", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Prc", "ValorSeguroEmp");
            DropColumn("dbo.Prc", "ValorSeguroFunc");
            DropColumn("dbo.Prc", "ValorSegSocemp");
            DropColumn("dbo.Prc", "ValorSegSocFunc");
            DropColumn("dbo.Prc", "TaxaIrps");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Prc", "TaxaIrps", c => c.Decimal(nullable: false, precision: 6, scale: 2));
            AddColumn("dbo.Prc", "ValorSegSocFunc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "ValorSegSocemp", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "ValorSeguroFunc", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.Prc", "ValorSeguroEmp", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            DropColumn("dbo.Proces", "Tipoproces");
            DropColumn("dbo.Proces", "CCusto");
            DropColumn("dbo.Prc", "Tipoproces");
        }
    }
}
