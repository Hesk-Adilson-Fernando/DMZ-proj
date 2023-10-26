namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteraAlimentacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Prc", "Alimentacao", c => c.Boolean(nullable: false));
            AddColumn("dbo.Prc", "Ferias", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Prc", "Ferias");
            DropColumn("dbo.Prc", "Alimentacao");
        }
    }
}
