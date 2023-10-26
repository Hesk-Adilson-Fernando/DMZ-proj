namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteraParam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Prc", "Errosl", c => c.String(nullable: false, maxLength: 4000));
            AddColumn("dbo.Proces", "Erros", c => c.String(nullable: false, maxLength: 4000));
            AddColumn("dbo.Param", "Horastrab", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Proces", "Obs", c => c.String(nullable: false, maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Proces", "Obs", c => c.String(nullable: false, maxLength: 500));
            DropColumn("dbo.Param", "Horastrab");
            DropColumn("dbo.Proces", "Erros");
            DropColumn("dbo.Prc", "Errosl");
        }
    }
}
