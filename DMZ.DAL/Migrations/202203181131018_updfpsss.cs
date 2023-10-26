namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updfpsss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TabelaAmort", "Grupo", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.TabelaAmort", "SubGrupo", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.TabelaAmort", "Divisao");
            DropColumn("dbo.TabelaAmort", "Tipo");
            DropColumn("dbo.TabelaAmort", "Diploma");
            DropColumn("dbo.TabelaAmort", "Vidamax");
            DropColumn("dbo.TabelaAmort", "Perc2");
            DropColumn("dbo.TabelaAmort", "Desc2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TabelaAmort", "Desc2", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.TabelaAmort", "Perc2", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AddColumn("dbo.TabelaAmort", "Vidamax", c => c.Decimal(nullable: false, precision: 5, scale: 2));
            AddColumn("dbo.TabelaAmort", "Diploma", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.TabelaAmort", "Tipo", c => c.String(nullable: false, maxLength: 5));
            AddColumn("dbo.TabelaAmort", "Divisao", c => c.String(nullable: false, maxLength: 5));
            DropColumn("dbo.TabelaAmort", "SubGrupo");
            DropColumn("dbo.TabelaAmort", "Grupo");
        }
    }
}
