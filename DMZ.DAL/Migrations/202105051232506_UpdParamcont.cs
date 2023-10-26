namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdParamcont : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Criacl", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Criafnc", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Criast", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Criacontas", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Criacontasprazo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Param", "Criape", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Criape");
            DropColumn("dbo.Param", "Criacontasprazo");
            DropColumn("dbo.Param", "Criacontas");
            DropColumn("dbo.Param", "Criast");
            DropColumn("dbo.Param", "Criafnc");
            DropColumn("dbo.Param", "Criacl");
        }
    }
}
