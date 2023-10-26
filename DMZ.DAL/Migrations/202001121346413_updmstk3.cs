namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updmstk3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mstk", "Ccusto", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mstk", "Codccu", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Mstk", "Unidade", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mstk", "Unidade");
            DropColumn("dbo.Mstk", "Codccu");
            DropColumn("dbo.Mstk", "Ccusto");
        }
    }
}
