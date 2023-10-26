namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updiv : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IV", "Lancado", c => c.Boolean(nullable: false));
            AddColumn("dbo.IV", "Ccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.IV", "Codccu", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.IV", "Codccu");
            DropColumn("dbo.IV", "Ccusto");
            DropColumn("dbo.IV", "Lancado");
        }
    }
}
