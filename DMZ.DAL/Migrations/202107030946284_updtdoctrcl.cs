namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updtdoctrcl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tdoc", "Nomfile2", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.TRcl", "Nomfile2", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TRcl", "Nomfile2");
            DropColumn("dbo.Tdoc", "Nomfile2");
        }
    }
}
