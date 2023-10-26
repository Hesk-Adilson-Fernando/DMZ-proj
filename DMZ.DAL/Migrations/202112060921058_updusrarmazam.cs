namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updusrarmazam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usr", "Codarm", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Usr", "Armazem", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usr", "Armazem");
            DropColumn("dbo.Usr", "Codarm");
        }
    }
}
