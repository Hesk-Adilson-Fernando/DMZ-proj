namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTpgfXmlString2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tpgf", "XmlString2", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tpgf", "XmlString2");
        }
    }
}
