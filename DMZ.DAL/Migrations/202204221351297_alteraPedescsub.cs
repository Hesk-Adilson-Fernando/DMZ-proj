namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteraPedescsub : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pedesc", "Tipodesc", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Pesub", "Tiposub", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AlterColumn("dbo.Pedesc", "Tipo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pedesc", "Tipo", c => c.Decimal(nullable: false, precision: 16, scale: 2));
            DropColumn("dbo.Pesub", "Tiposub");
            DropColumn("dbo.Pedesc", "Tipodesc");
        }
    }
}
