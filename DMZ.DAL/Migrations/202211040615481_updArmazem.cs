namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updArmazem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Armazem", "Cozinha", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Armazem", "Padrao", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Armazem", "Padrao", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Armazem", "Cozinha");
        }
    }
}
