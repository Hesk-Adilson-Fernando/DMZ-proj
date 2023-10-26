namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class colunprecopos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Esconderef", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Escondestock", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Escondecolprecos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Preco1", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Preco2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Preco3", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Preco4", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Preco5", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Preco6", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Param", "Preco7", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.StPrecos", "Preco1", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.StPrecos", "Preco2", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.StPrecos", "Preco3", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.StPrecos", "Preco4", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.StPrecos", "Preco5", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.StPrecos", "Preco6", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            AddColumn("dbo.StPrecos", "Preco7", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StPrecos", "Preco7");
            DropColumn("dbo.StPrecos", "Preco6");
            DropColumn("dbo.StPrecos", "Preco5");
            DropColumn("dbo.StPrecos", "Preco4");
            DropColumn("dbo.StPrecos", "Preco3");
            DropColumn("dbo.StPrecos", "Preco2");
            DropColumn("dbo.StPrecos", "Preco1");
            DropColumn("dbo.Param", "Preco7");
            DropColumn("dbo.Param", "Preco6");
            DropColumn("dbo.Param", "Preco5");
            DropColumn("dbo.Param", "Preco4");
            DropColumn("dbo.Param", "Preco3");
            DropColumn("dbo.Param", "Preco2");
            DropColumn("dbo.Param", "Preco1");
            DropColumn("dbo.Param", "Escondecolprecos");
            DropColumn("dbo.Param", "Escondestock");
            DropColumn("dbo.Param", "Esconderef");
        }
    }
}
