namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updFp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Formasp", "Codtz2", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Formasp", "Contatesoura2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Formasp", "Trf", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "TrfConta", c => c.Boolean(nullable: false));
            DropColumn("dbo.Tdi", "maskqtt");
            DropColumn("dbo.Tdi", "maskpreco");
            DropColumn("dbo.Tdi", "maskoprecos");
            DropColumn("dbo.Tdi", "expressemidoc");
            DropColumn("dbo.Tdi", "expresstitulo");
            DropColumn("dbo.Tdi", "pastascan");
            DropColumn("dbo.Tdi", "tipoimg");
            DropColumn("dbo.Tdi", "saveimg");
            DropColumn("dbo.Tdi", "diagua");
            DropColumn("dbo.Tdi", "etpemiss");
            DropColumn("dbo.Tdi", "etpimpress");
            DropColumn("dbo.Tdi", "etpemail");
            DropColumn("dbo.Tdi", "etpemisstxt");
            DropColumn("dbo.Tdi", "etpimpresstxt");
            DropColumn("dbo.Tdi", "etpemailtxt");
            DropColumn("dbo.Tdi", "ctrqttorig");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tdi", "ctrqttorig", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "etpemailtxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "etpimpresstxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "etpemisstxt", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "etpemail", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "etpimpress", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "etpemiss", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "diagua", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "saveimg", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdi", "tipoimg", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "pastascan", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "expresstitulo", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "expressemidoc", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "maskoprecos", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "maskpreco", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdi", "maskqtt", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Tdi", "TrfConta");
            DropColumn("dbo.Formasp", "Trf");
            DropColumn("dbo.Formasp", "Contatesoura2");
            DropColumn("dbo.Formasp", "Codtz2");
        }
    }
}
