namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdParamIva : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Ivaposdesconto", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Ivaposdesconto");
        }
    }
}
