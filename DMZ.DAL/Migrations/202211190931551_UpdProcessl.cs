namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdProcessl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Processol", "Dias", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.Tdocpe", "Nomfile", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Tdocpe", "Defa", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tdocpe", "Defa");
            DropColumn("dbo.Tdocpe", "Nomfile");
            DropColumn("dbo.Processol", "Dias");
        }
    }
}
