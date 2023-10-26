namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updst : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St", "CodigoBarras", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Usr", "Codccu", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Usr", "Ccusto", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "Ccusto");
            DropColumn("dbo.Usr", "Codccu");
            DropColumn("dbo.St", "CodigoBarras");
        }
    }
}
