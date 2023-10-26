namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdPlanopagam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Planopag", "Descanosem", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Planopag", "AnoSemstamp", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Planopag", "AnoSemstamp");
            DropColumn("dbo.Planopag", "Descanosem");
        }
    }
}
