namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdTab2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdi", "Lancacustopj", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdoc", "Lancacustopj", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tdocf", "Lancacustopj", c => c.Boolean(nullable: false));
            DropColumn("dbo.Tdi", "Obrigapj");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tdi", "Obrigapj", c => c.Boolean(nullable: false));
            DropColumn("dbo.Tdocf", "Lancacustopj");
            DropColumn("dbo.Tdoc", "Lancacustopj");
            DropColumn("dbo.Tdi", "Lancacustopj");
        }
    }
}
