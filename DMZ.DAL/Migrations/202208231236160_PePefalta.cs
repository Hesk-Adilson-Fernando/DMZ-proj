namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PePefalta : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pefalta", "Processtamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefalta", "Prcstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pefalta", "DataProc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pehextra", "Processtamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Pehextra", "Prcstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pehextra", "Prcstamp");
            DropColumn("dbo.Pehextra", "Processtamp");
            DropColumn("dbo.Pefalta", "DataProc");
            DropColumn("dbo.Pefalta", "Prcstamp");
            DropColumn("dbo.Pefalta", "Processtamp");
        }
    }
}
