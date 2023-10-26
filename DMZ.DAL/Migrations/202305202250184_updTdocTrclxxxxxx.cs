namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updTdocTrclxxxxxx : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdoc", "XmlStringA5", c => c.String(nullable: false));
            AddColumn("dbo.Tdoc", "XmlStringPOS", c => c.String(nullable: false));
            AddColumn("dbo.TRcl", "XmlStringA5", c => c.String(nullable: false));
            AddColumn("dbo.TRcl", "XmlStringPOS", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TRcl", "XmlStringPOS");
            DropColumn("dbo.TRcl", "XmlStringA5");
            DropColumn("dbo.Tdoc", "XmlStringPOS");
            DropColumn("dbo.Tdoc", "XmlStringA5");
        }
    }
}
