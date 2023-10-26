namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addxmla5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tpgp", "XmlString", c => c.String(nullable: false));
            AddColumn("dbo.Tpgp", "XmlStringa5", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tpgp", "XmlStringa5");
            DropColumn("dbo.Tpgp", "XmlString");
        }
    }
}
