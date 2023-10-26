namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updDiEntergas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fact", "Motorista", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Localentrega", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Departamento", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Motorista", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Pais", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Mail", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Cell", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Pcontacto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Di", "Dataentrega", c => c.DateTime(nullable: false));
            AddColumn("dbo.Di", "Datapartida", c => c.DateTime(nullable: false));
            AddColumn("dbo.Di", "Entrega", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "GeraGuiaAutomatica", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "GeraGuiaAutomatica");
            DropColumn("dbo.Di", "Entrega");
            DropColumn("dbo.Di", "Datapartida");
            DropColumn("dbo.Di", "Dataentrega");
            DropColumn("dbo.Di", "Pcontacto");
            DropColumn("dbo.Di", "Cell");
            DropColumn("dbo.Di", "Mail");
            DropColumn("dbo.Di", "Pais");
            DropColumn("dbo.Di", "Motorista");
            DropColumn("dbo.Di", "Departamento");
            DropColumn("dbo.Di", "Localentrega");
            DropColumn("dbo.Fact", "Motorista");
        }
    }
}
