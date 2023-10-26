namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updcontas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contas", "Codpos", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Contas", "Descpos", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contas", "Descpos");
            DropColumn("dbo.Contas", "Codpos");
        }
    }
}
