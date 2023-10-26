namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updStstamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factl", "Ststamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mstk", "Ststamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "Ststamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Dil", "LineAnulado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Faccl", "Ststamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Faccl", "LineAnulado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Faccl", "LineAnulado");
            DropColumn("dbo.Faccl", "Ststamp");
            DropColumn("dbo.Dil", "LineAnulado");
            DropColumn("dbo.Dil", "Ststamp");
            DropColumn("dbo.Mstk", "Ststamp");
            DropColumn("dbo.Factl", "Ststamp");
        }
    }
}
