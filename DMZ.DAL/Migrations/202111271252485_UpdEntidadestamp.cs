namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdEntidadestamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factl", "Entidadestamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mstk", "Entidadestamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "Entidadestamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Faccl", "Entidadestamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.StFnc", "Fncstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.StFnc", "Devolvido", c => c.Decimal(nullable: false, precision: 16, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StFnc", "Devolvido");
            DropColumn("dbo.StFnc", "Fncstamp");
            DropColumn("dbo.Faccl", "Entidadestamp");
            DropColumn("dbo.Dil", "Entidadestamp");
            DropColumn("dbo.Mstk", "Entidadestamp");
            DropColumn("dbo.Factl", "Entidadestamp");
        }
    }
}
