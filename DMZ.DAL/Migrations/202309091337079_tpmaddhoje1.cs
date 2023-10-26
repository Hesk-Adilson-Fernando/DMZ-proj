namespace DMZ.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tpmaddhoje1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Param", "Modulos", c => c.Decimal(nullable: false, precision: 9, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Param", "Modulos");
        }
    }
}
