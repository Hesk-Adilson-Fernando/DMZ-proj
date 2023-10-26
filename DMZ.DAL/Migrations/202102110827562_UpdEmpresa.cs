namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdEmpresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empresa", "Grupo1", c => c.String(nullable: false, maxLength: 200));
            AddColumn("dbo.Empresa", "Grupo2", c => c.String(nullable: false, maxLength: 200));
            AddColumn("dbo.Empresa", "Logo1", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo2", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo3", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo4", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo5", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo6", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo7", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo8", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo9", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo10", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo11", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo12", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo13", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo14", c => c.Binary());
            AddColumn("dbo.Empresa", "Logo15", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl1", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl2", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl3", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl4", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl5", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl6", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl7", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl8", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl9", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl10", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl11", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl12", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl13", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl14", c => c.Binary());
            AddColumn("dbo.Empresa", "Cl15", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empresa", "Cl15");
            DropColumn("dbo.Empresa", "Cl14");
            DropColumn("dbo.Empresa", "Cl13");
            DropColumn("dbo.Empresa", "Cl12");
            DropColumn("dbo.Empresa", "Cl11");
            DropColumn("dbo.Empresa", "Cl10");
            DropColumn("dbo.Empresa", "Cl9");
            DropColumn("dbo.Empresa", "Cl8");
            DropColumn("dbo.Empresa", "Cl7");
            DropColumn("dbo.Empresa", "Cl6");
            DropColumn("dbo.Empresa", "Cl5");
            DropColumn("dbo.Empresa", "Cl4");
            DropColumn("dbo.Empresa", "Cl3");
            DropColumn("dbo.Empresa", "Cl2");
            DropColumn("dbo.Empresa", "Cl1");
            DropColumn("dbo.Empresa", "Logo15");
            DropColumn("dbo.Empresa", "Logo14");
            DropColumn("dbo.Empresa", "Logo13");
            DropColumn("dbo.Empresa", "Logo12");
            DropColumn("dbo.Empresa", "Logo11");
            DropColumn("dbo.Empresa", "Logo10");
            DropColumn("dbo.Empresa", "Logo9");
            DropColumn("dbo.Empresa", "Logo8");
            DropColumn("dbo.Empresa", "Logo7");
            DropColumn("dbo.Empresa", "Logo6");
            DropColumn("dbo.Empresa", "Logo5");
            DropColumn("dbo.Empresa", "Logo4");
            DropColumn("dbo.Empresa", "Logo3");
            DropColumn("dbo.Empresa", "Logo2");
            DropColumn("dbo.Empresa", "Logo1");
            DropColumn("dbo.Empresa", "Grupo2");
            DropColumn("dbo.Empresa", "Grupo1");
        }
    }
}
