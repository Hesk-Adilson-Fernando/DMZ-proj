namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addctauxiliar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ctauxiliar",
                c => new
                    {
                        Ctauxiliarstamp = c.String(nullable: false, maxLength: 80),
                        Codigo = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Descricao = c.String(nullable: false, maxLength: 80),
                        Tabela = c.Decimal(nullable: false, precision: 9, scale: 0),
                        Desctabela = c.String(nullable: false, maxLength: 80),
                        Padrao = c.Boolean(nullable: false),
                        Obs = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.Ctauxiliarstamp);
            
            AddColumn("dbo.Paramemail", "Codtipo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Paramemail", "Tipo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Paramgct", "Codtipo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Paramemail", "Stockmin");
            DropColumn("dbo.Paramemail", "Aprovacompra");
            DropColumn("dbo.Paramemail", "Param1");
            DropColumn("dbo.Paramemail", "Param2");
            DropColumn("dbo.Paramemail", "Param3");
            DropColumn("dbo.Paramemail", "Param4");
            DropColumn("dbo.Paramemail", "Param5");
            DropColumn("dbo.Paramemail", "Param6");
            DropColumn("dbo.Paramemail", "Param7");
            DropColumn("dbo.Paramemail", "Param8");
            DropColumn("dbo.Paramemail", "Param9");
            DropColumn("dbo.Paramemail", "Param10");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Paramemail", "Param10", c => c.Boolean(nullable: false));
            AddColumn("dbo.Paramemail", "Param9", c => c.Boolean(nullable: false));
            AddColumn("dbo.Paramemail", "Param8", c => c.Boolean(nullable: false));
            AddColumn("dbo.Paramemail", "Param7", c => c.Boolean(nullable: false));
            AddColumn("dbo.Paramemail", "Param6", c => c.Boolean(nullable: false));
            AddColumn("dbo.Paramemail", "Param5", c => c.Boolean(nullable: false));
            AddColumn("dbo.Paramemail", "Param4", c => c.Boolean(nullable: false));
            AddColumn("dbo.Paramemail", "Param3", c => c.Boolean(nullable: false));
            AddColumn("dbo.Paramemail", "Param2", c => c.Boolean(nullable: false));
            AddColumn("dbo.Paramemail", "Param1", c => c.Boolean(nullable: false));
            AddColumn("dbo.Paramemail", "Aprovacompra", c => c.Boolean(nullable: false));
            AddColumn("dbo.Paramemail", "Stockmin", c => c.Boolean(nullable: false));
            DropColumn("dbo.Paramgct", "Codtipo");
            DropColumn("dbo.Paramemail", "Tipo");
            DropColumn("dbo.Paramemail", "Codtipo");
            DropTable("dbo.Ctauxiliar");
        }
    }
}
