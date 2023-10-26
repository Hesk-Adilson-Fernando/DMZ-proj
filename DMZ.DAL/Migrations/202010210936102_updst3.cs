namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updst3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.St", "Anomodelo", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "Eixos", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "Pneus", c => c.Decimal(nullable: false, precision: 9, scale: 0));
            AddColumn("dbo.St", "Carga", c => c.Decimal(nullable: false, precision: 20, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.St", "Carga");
            DropColumn("dbo.St", "Pneus");
            DropColumn("dbo.St", "Eixos");
            DropColumn("dbo.St", "Anomodelo");
        }
    }
}
