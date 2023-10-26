namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterUSr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "Mostrasaldo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "Mostraextrato", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "NaoMostrafacturacao", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "NaoMostraProcessos", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "NaoMostraCadastro", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "NaoMostraConfig", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "NaoMostracompras", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usr", "NaoMostravendas", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "NaoMostravendas");
            DropColumn("dbo.Usr", "NaoMostracompras");
            DropColumn("dbo.Usr", "NaoMostraConfig");
            DropColumn("dbo.Usr", "NaoMostraCadastro");
            DropColumn("dbo.Usr", "NaoMostraProcessos");
            DropColumn("dbo.Usr", "NaoMostrafacturacao");
            DropColumn("dbo.Usr", "Mostraextrato");
            DropColumn("dbo.Usr", "Mostrasaldo");
        }
    }
}
