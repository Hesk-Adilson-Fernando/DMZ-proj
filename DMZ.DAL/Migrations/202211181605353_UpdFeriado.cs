namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdFeriado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feriado", "Nacional", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Feriado", "Nacional");
        }
    }
}
