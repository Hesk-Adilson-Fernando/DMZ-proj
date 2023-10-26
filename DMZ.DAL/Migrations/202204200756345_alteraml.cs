namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteraml : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ml", "Processado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ml", "Processado");
        }
    }
}
