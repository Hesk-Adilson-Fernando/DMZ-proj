namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpDMvTdecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mvt", "Entrada", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Mvt", "Saida", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Contas", "Saldo", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Contas", "Saldor", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AlterColumn("dbo.Usr", "ValorMaxPagamento", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usr", "ValorMaxPagamento", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Contas", "Saldor", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Contas", "Saldo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Mvt", "Saida", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Mvt", "Entrada", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
    }
}
