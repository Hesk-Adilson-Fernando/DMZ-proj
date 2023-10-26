namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRcllParam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Montanumero", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Rcll", "Nrdoc", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rcll", "Nrdoc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Param", "Montanumero");
        }
    }
}
