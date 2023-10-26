namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDatapagamento : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fact", "Departamento", c => c.String(nullable: false));
            AlterColumn("dbo.Empresa", "Nome", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empresa", "Nome", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Fact", "Departamento", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Fact", "Datapagamento");
            DropColumn("dbo.Fact", "Data_limite_pagamento");
            DropColumn("dbo.Fact", "Obscc");
            DropColumn("dbo.Fact", "Pago");
            DropColumn("dbo.Cc", "Datapagamento");
            DropColumn("dbo.Cc", "Data_limite_pagamento");
            DropColumn("dbo.Cc", "Obsrcc");
            DropColumn("dbo.Cc", "Pago");
        }
    }
}
