namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdSt222 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St2", "Depin", c => c.DateTime(nullable: false));
            AddColumn("dbo.St2", "Valmvaliacusto", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.St2", "Valmvaliareivest", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.St2", "ValMatricial", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.St2", "Percndep", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AddColumn("dbo.St2", "Perctaxaceite", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AddColumn("dbo.St2", "Quotasperdidas", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.St2", "Deptotaisperdidas", c => c.Decimal(nullable: false, precision: 20, scale: 2));
            AddColumn("dbo.St2", "SNC", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Depex", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Depacu", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Mvalia", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Venda", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Aliena", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Abate", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Reaval", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Perdaimpa", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Reversimpa", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Perdaimpacum", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Excedreval", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Passimposto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.St2", "Menosvalia", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.St2", "Quantrec", c => c.Decimal(nullable: false, precision: 20, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.St2", "Quantrec", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.St2", "Menosvalia");
            DropColumn("dbo.St2", "Passimposto");
            DropColumn("dbo.St2", "Excedreval");
            DropColumn("dbo.St2", "Perdaimpacum");
            DropColumn("dbo.St2", "Reversimpa");
            DropColumn("dbo.St2", "Perdaimpa");
            DropColumn("dbo.St2", "Reaval");
            DropColumn("dbo.St2", "Abate");
            DropColumn("dbo.St2", "Aliena");
            DropColumn("dbo.St2", "Venda");
            DropColumn("dbo.St2", "Mvalia");
            DropColumn("dbo.St2", "Depacu");
            DropColumn("dbo.St2", "Depex");
            DropColumn("dbo.St2", "SNC");
            DropColumn("dbo.St2", "Deptotaisperdidas");
            DropColumn("dbo.St2", "Quotasperdidas");
            DropColumn("dbo.St2", "Perctaxaceite");
            DropColumn("dbo.St2", "Percndep");
            DropColumn("dbo.St2", "ValMatricial");
            DropColumn("dbo.St2", "Valmvaliareivest");
            DropColumn("dbo.St2", "Valmvaliacusto");
            DropColumn("dbo.St2", "Depin");
        }
    }
}
