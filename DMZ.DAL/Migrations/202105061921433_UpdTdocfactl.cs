namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdTdocfactl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factl", "Contrato", c => c.String(nullable: false, maxLength: 200));
            AddColumn("dbo.Tdoc", "Mostraguia", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "MostraContrato", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tdoc", "MostraContrato");
            DropColumn("dbo.Tdoc", "Mostraguia");
            DropColumn("dbo.Factl", "Contrato");
        }
    }
}
