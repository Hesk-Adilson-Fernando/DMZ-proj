namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addImei : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stmaq", "IMEI", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Stpe", "Funcao", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Stpe", "No");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Stpe", "No", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Stpe", "Funcao");
            DropColumn("dbo.Stmaq", "IMEI");
        }
    }
}
