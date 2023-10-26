namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrltsqlXmlstring : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rltsql", "XmlString", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rltsql", "XmlString");
        }
    }
}
