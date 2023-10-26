namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTvendas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Caixa", "Ccutvstamp", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Caixa", "Ccutvdesc", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Caixa", "Posto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Caixa", "Posto", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            DropColumn("dbo.Caixa", "Ccutvdesc");
            DropColumn("dbo.Caixa", "Ccutvstamp");
        }
    }
}
