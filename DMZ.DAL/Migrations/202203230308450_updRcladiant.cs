namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updRcladiant : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cc", "Rcladiant", c => c.Boolean(nullable: false));
            AddColumn("dbo.Fcc", "Rcladiant", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgf", "Rcladiant", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pgfl", "Rcladiant", c => c.Boolean(nullable: false));
            AddColumn("dbo.RCL", "Rcladiant", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rcll", "Rcladiant", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tpgf", "Rcladiant", c => c.Boolean(nullable: false));
            AddColumn("dbo.TRcl", "Rcladiant", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TRcl", "Rcladiant");
            DropColumn("dbo.Tpgf", "Rcladiant");
            DropColumn("dbo.Rcll", "Rcladiant");
            DropColumn("dbo.RCL", "Rcladiant");
            DropColumn("dbo.Pgfl", "Rcladiant");
            DropColumn("dbo.Pgf", "Rcladiant");
            DropColumn("dbo.Fcc", "Rcladiant");
            DropColumn("dbo.Cc", "Rcladiant");
        }
    }
}
