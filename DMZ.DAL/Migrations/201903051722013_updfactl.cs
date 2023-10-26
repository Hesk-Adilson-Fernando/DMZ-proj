namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updfactl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Factl", "Subtotall", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Factl", "Mtotall", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Factl", "Contatz", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Factl", "usadesign");
            DropColumn("dbo.Factl", "remotestamp");
            DropColumn("dbo.Factl", "quant2");
            DropColumn("dbo.Factl", "quant3");
            DropColumn("dbo.Factl", "preco2");
            DropColumn("dbo.Factl", "preco3");
            DropColumn("dbo.Factl", "usalote");
            DropColumn("dbo.Factl", "lotevalid");
            DropColumn("dbo.Factl", "lotelimft");
            DropColumn("dbo.Factl", "qttmedida");
            DropColumn("dbo.Factl", "totalmedida");
            DropColumn("dbo.Factl", "grupo");
            DropColumn("dbo.Factl", "usaperlinha");
            DropColumn("dbo.Factl", "perlinha");
            DropColumn("dbo.Factl", "tipocheck");
            DropColumn("dbo.Factl", "qttdecim");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Factl", "qttdecim", c => c.Boolean(nullable: false));
            AddColumn("dbo.Factl", "tipocheck", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Factl", "perlinha", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Factl", "usaperlinha", c => c.Boolean(nullable: false));
            AddColumn("dbo.Factl", "grupo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Factl", "totalmedida", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Factl", "qttmedida", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Factl", "lotelimft", c => c.DateTime(nullable: false));
            AddColumn("dbo.Factl", "lotevalid", c => c.DateTime(nullable: false));
            AddColumn("dbo.Factl", "usalote", c => c.Boolean(nullable: false));
            AddColumn("dbo.Factl", "preco3", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Factl", "preco2", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Factl", "quant3", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Factl", "quant2", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Factl", "remotestamp", c => c.String(maxLength: 80));
            AddColumn("dbo.Factl", "usadesign", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Factl", "Contatz", c => c.Decimal(precision: 9, scale: 0));
            AlterColumn("dbo.Factl", "Mtotall", c => c.Decimal(precision: 9, scale: 0));
            AlterColumn("dbo.Factl", "Subtotall", c => c.Decimal(precision: 9, scale: 0));
        }
    }
}
