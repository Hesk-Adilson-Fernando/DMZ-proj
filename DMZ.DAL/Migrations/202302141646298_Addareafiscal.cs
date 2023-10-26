namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addareafiscal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cl", "Areafiscal", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cl", "Areafiscal");
        }
    }
}
