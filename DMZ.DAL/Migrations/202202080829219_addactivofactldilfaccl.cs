namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addactivofactldilfaccl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factl", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Dil", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Faccl", "Activo", c => c.Boolean(nullable: false));
            //DropColumn("dbo.Factl", "Stactivo");
            //DropColumn("dbo.Dil", "Stactivo");
            //DropColumn("dbo.Faccl", "Stactivo");
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Faccl", "Stactivo", c => c.Boolean(nullable: false));
            //AddColumn("dbo.Dil", "Stactivo", c => c.Boolean(nullable: false));
            //AddColumn("dbo.Factl", "Stactivo", c => c.Boolean(nullable: false));
            DropColumn("dbo.Faccl", "Activo");
            DropColumn("dbo.Dil", "Activo");
            DropColumn("dbo.Factl", "Activo");
        }
    }
}
