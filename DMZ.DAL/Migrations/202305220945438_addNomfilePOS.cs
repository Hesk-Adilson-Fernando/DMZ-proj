namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNomfilePOS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TRcl", "NomfilePOS", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TRcl", "NomfilePOS");
        }
    }
}
