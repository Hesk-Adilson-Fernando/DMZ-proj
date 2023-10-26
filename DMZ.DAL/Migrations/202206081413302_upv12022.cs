namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upv12022 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rlt", "Mostrafp", c => c.Boolean(nullable: false));
            AddColumn("dbo.Rlt", "MostraTesoura", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rlt", "MostraTesoura");
            DropColumn("dbo.Rlt", "Mostrafp");
        }
    }
}
